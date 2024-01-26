using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SCI_Client
{
	internal class Crypt
	{
		public static readonly byte[] Salt = [10, 20, 30, 40, 50, 60, 70, 80];

		/// <summary>
		/// Encode string
		/// </summary>
		/// <param name="text"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string Encrypt(string text, byte[] key)
		{
			byte[] iv = new byte[16];
			byte[] array;

			using (Aes aes = Aes.Create())
			{
				// aes.Key = Encoding.UTF8.GetBytes(key);
				aes.Key = key;
				aes.IV = iv;

				ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

				using MemoryStream memoryStream = new();
				using CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write);
				using (StreamWriter streamWriter = new(cryptoStream))
				{
					streamWriter.Write(text);
				}

				array = memoryStream.ToArray();
			}
			return Convert.ToBase64String(array);
		}

		/// <summary>
		/// Decode string
		/// </summary>
		/// <param name="cryptedText"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string Decrypt(string cryptedText, byte[] key)
		{
			byte[] iv = new byte[16];
			byte[] buffer = Convert.FromBase64String(cryptedText);

			using Aes aes = Aes.Create();
			//aes.Key = Encoding.UTF8.GetBytes(key);
			aes.Key = key;
			aes.IV = iv;
			ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

			using MemoryStream memoryStream = new(buffer);
			using CryptoStream cryptoStream = new(memoryStream, decryptor, CryptoStreamMode.Read);
			using StreamReader streamReader = new(cryptoStream);
			return streamReader.ReadToEnd();
		}

		/// <summary>
		/// Create Key
		/// </summary>
		/// <param name="password"></param>
		/// <param name="keyBytes"></param>
		/// <returns>Key for en-decryping</returns>
		public static byte[] CreateKey(string password, int keyBytes = 32)
		{
			const int Iterations = 1;
			var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations, HashAlgorithmName.SHA512);
			return keyGenerator.GetBytes(keyBytes);
		}
	}
}
