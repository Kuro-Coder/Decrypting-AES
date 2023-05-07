// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

Console.WriteLine("Yo yo, wellcome to string Decrypting-AES App.");

Console.Write("Type your string data:");

var cryptoData = Decrypting(Console.ReadLine());

Console.Write("Decrypting Data: ");
Console.WriteLine(cryptoData);

Console.WriteLine("Finish Decrypting, press any key pls.");

Console.ReadKey();


static string Decrypting(string ciphertxt)
{
    string plaintext = null;
    // Create AesManaged    
    return plaintext;
}