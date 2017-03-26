using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace CryptoCram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnRemoveSelectedFile.Enabled = false;
            btnClear.Enabled = false;
            btnEncrypt.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string filename = "";
            string path = "";
            filename = System.IO.Path.GetFileName(openFile.FileName);
            path = System.IO.Path.GetDirectoryName(openFile.FileName);
            lstFilesSelected.Items.Add(path + "\\" + filename);
            btnRemoveSelectedFile.Enabled = true;
            btnClear.Enabled = true;
            btnEncrypt.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFilesSelected.Items.Clear();
            btnClear.Enabled = false;
            btnEncrypt.Enabled = false;
            btnRemoveSelectedFile.Enabled = false;
        }

        private void btnRemoveSelectedFile_Click(object sender, EventArgs e)
        {
            if (this.lstFilesSelected.SelectedIndex >= 0)
                this.lstFilesSelected.Items.RemoveAt(this.lstFilesSelected.SelectedIndex);
            else
                MessageBox.Show("Select a file in order to remove it from the list of files that will be encrypted.", "No file selected");
        }

        //Encryption shenanigans

        static void EncryptFile(string sInputFilename,
           string sOutputFilename,
           string sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Mode = CipherMode.CFB;
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.Padding = PaddingMode.ISO10126;
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted, desencrypt, CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length - 1];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.FlushFinalBlock();
            fsInput.Close();
            fsEncrypted.Close();
        }

        //  Call this function to remove the key from memory after use for security.
        [System.Runtime.InteropServices.DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(ref string Destination, int Length);

        // Function to Generate a 64 bits Key.
        static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        string sSecretKey = GenerateKey();

        static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.Mode = CipherMode.CFB;
            DES.Padding = PaddingMode.ISO10126;
            FileStream fsread = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            CryptoStream cryptostreamDecr = new CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read);
            FileStream fsDecrypted = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
            cryptostreamDecr.CopyTo(fsDecrypted);
            cryptostreamDecr.Flush();
            cryptostreamDecr.Close();
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }

        public void OnTimerEvent(object source, EventArgs e)
        {
            DecryptFile(lstFilesSelected.SelectedItem.ToString() + "-crypt", lstFilesSelected.SelectedItem.ToString(), sSecretKey);
            File.Delete((lstFilesSelected.SelectedItem.ToString() + "-crypt"));
            timer1.Enabled = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int hours;
            int minutes;
            int seconds;
            int.TryParse(txtHour.Text, out hours);
            int.TryParse(txtMinutes.Text, out minutes);
            int.TryParse(txtSeconds.Text, out seconds);
            if (cmbMeridian.Text == "PM" && hours < 12)
            {
                hours += 12;
            }
            DateTime timeToDecrypt;
            timeToDecrypt = dateTimePicker1.Value.Date;
            timeToDecrypt = timeToDecrypt.AddHours(hours);
            timeToDecrypt = timeToDecrypt.AddMinutes(minutes);
            timeToDecrypt = timeToDecrypt.AddSeconds(seconds);
            long nowMilliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long futureMilliseconds = timeToDecrypt.Ticks / TimeSpan.TicksPerMillisecond;
            timer1.Interval = (int)(futureMilliseconds - nowMilliseconds);
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);

            if (lstFilesSelected.SelectedIndex == -1)
            {
                MessageBox.Show("Select a file to encrypt.", "No file selected");
            }

            else
            {
                GCHandle gch = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned);

                EncryptFile(lstFilesSelected.SelectedItem.ToString(), lstFilesSelected.SelectedItem.ToString() + "-crypt", sSecretKey);
                File.Delete(lstFilesSelected.SelectedItem.ToString());

                string asskey = gch.AddrOfPinnedObject().ToString();
                //Remove the Key from memory. 
                ZeroMemory(ref asskey, sSecretKey.Length * 2);
                gch.Free();

                MessageBox.Show("Success! Your file will decrypt on " + timeToDecrypt.ToShortDateString() + " at " + timeToDecrypt.ToShortTimeString());
            }
        }

    }
}
