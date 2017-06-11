# CryptoCram
<b><i>Locking away your distractions since 2017</i></b>

## Inspiration
When major academic or professional deadlines are looming, it's likely that the temptation to procrastinate rather than do what needs to be done is pretty strong. CryptoCram locks away your distractions. You pick the games, movies, or other files likely to distract you, run CryptoCram on them, and they'll be rendered temporarily unavailable for as long as you choose.

## What it does
CryptoCram is a utility for Windows that enables you to encrypt files and, after a certain period of time, have them decrypted and once again accessible to you.

## How it's built
CryptoCram is written in C# and utilizes the .NET framework. Windows Forms is used for the GUI and DES is used for the encryption algorithm.* <br><br>*While DES would not be effective at hiding secrets from the NSA, it is effective for CryptoCram's use case.

## Future improvements
* Implementing persistent storage
* Improving scalability when dealing with large files
