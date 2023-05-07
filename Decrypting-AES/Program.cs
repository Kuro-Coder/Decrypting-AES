// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

Console.WriteLine("Yo yo, wellcome to string Decrypting-AES App.");

Console.Write("Type your string data:");

var cryptoData = Decrypting(Console.ReadLine());

//test data for 123 : BPTaXsPRMyfXTNiPZU1jkw==

Console.Write("Decrypting Data: ");
Console.WriteLine(cryptoData);

Console.WriteLine("Finish Decrypting, press any key pls.");

Console.ReadKey();


static string Decrypting(string ciphertxt)
{
    string plaintext = null;
    // Create AesManaged    
    using (var aes = new AesManaged())
    {
        byte[] IV = new byte[16];
        byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

        
        ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
        string plaintxt = "";
        // Create the streams used for decryption. 
        byte[] cipherBytes = Convert.FromBase64String(ciphertxt);
        using (MemoryStream ms = new MemoryStream(cipherBytes))
        {
            // Create crypto stream    
            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            {
                // Read crypto stream    
                using (StreamReader reader = new StreamReader(cs))
                    plaintext = reader.ReadToEnd();
            }
        }
        StringReader readers = new StringReader(plaintext);
        plaintxt = readers.ReadLine();
        return plaintxt;
    }
}