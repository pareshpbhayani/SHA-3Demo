using System;
using System.Text;
using System.Threading.Tasks;
using HashLib;

class Program
{
    static void Main()
    {
        // Initialize SHA3-256 hasher
        var sha3 = HashFactory.Crypto.CreateSHA256();

        // Compute hash
        byte[] data = Encoding.UTF8.GetBytes("Hello!");
        var hashResult = sha3.ComputeBytes(data);
        string hashString = hashResult.ToString();

        // Print the hash to the console
        Console.WriteLine($"SHA3-256 Hash: {hashString}");

        // Keep the console window open until a key is pressed
        Console.ReadLine(); // This line prevents the console from closing immediately
    }
}
