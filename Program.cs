using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("CAESAR CIPHER");
      Console.WriteLine("What is your secret message?");
      string myMessage = Console.ReadLine().ToLower();
      char[] secretMessage = myMessage.ToCharArray();
      char[] encryptedMessageArray = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char secretMessageChar = secretMessage[i];
        if (!Char.IsLetter(secretMessageChar))
        {
          continue;
        }
        int secretMessageCharIndex = Array.IndexOf(alphabet, secretMessageChar);
        int encryptedMessageCharIndex = (secretMessageCharIndex + 3) % 26;
        char encryptedMessageChar = alphabet[encryptedMessageCharIndex];
        encryptedMessageArray[i] = encryptedMessageChar;
      }
      string encryptedMessage = String.Join("", encryptedMessageArray);
      Console.WriteLine($"Your encrypted message is: {encryptedMessage}");
    }
  }
}