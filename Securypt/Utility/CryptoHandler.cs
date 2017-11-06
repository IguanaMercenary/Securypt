using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Securypt.Utility
{
    class CryptoHandler
    {
        internal string AESSecretKey;
        internal string securyptKeyName = "Securypt";

        public string textToEncrypt = "This text will now be encrypted.";
        public string textDecrypted;

        internal CspParameters cspp;
        internal RSACryptoServiceProvider rsa;

        public CryptoHandler() { }

        internal void initProgram()
        {
            try
            {
                cspp = new CspParameters();
                cspp.Flags |= CspProviderFlags.UseMachineKeyStore; //set CspProvider to use Machine Key Container, not User Key Container

                cspp.KeyContainerName = securyptKeyName;
                rsa = new RSACryptoServiceProvider(cspp);
                rsa.PersistKeyInCsp = true;

                if (doesKeyExist(securyptKeyName))
                {
                    Console.WriteLine("Keys found... Importing...");
                    Console.WriteLine("Key pair retrieved from container : {0}", rsa.ToXmlString(true));
                }
                else
                {
                    Console.WriteLine("No Securypt keys found");

                    //Console.WriteLine("Key pair generated and stored in container from container : {0}", rsa.ToXmlString(true));
                }



                testEncrypt();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/security/how-to-store-asymmetric-keys-in-a-key-container
        internal static void DeleteKeyFromContainer(string ContainerName)
        {
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            rsa.PersistKeyInCsp = false; //doesn't save 

            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }

        /// https://stackoverflow.com/questions/17640055/c-sharp-rsacryptoserviceprovider-how-to-check-if-a-key-already-exists-in-contai
        internal static bool doesKeyExist(string containerName)
        {
            var cspParams = new CspParameters
            {
                Flags = CspProviderFlags.UseExistingKey,
                KeyContainerName = containerName
            };

            try
            {
                var provider = new RSACryptoServiceProvider(cspParams);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        internal void testEncrypt()
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                String stringToEncrypt = "Hello world...";
                Console.WriteLine("String to encrypt: " + stringToEncrypt);

                byte[] bytesToEncrypt = ByteConverter.GetBytes(stringToEncrypt);
                byte[] encryptedBytes = rsa.Encrypt(bytesToEncrypt, false);
                Console.WriteLine("Encrypted Bytes: " + Convert.ToBase64String(encryptedBytes));

                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);
                Console.WriteLine("Decrypted Bytes: " + Convert.ToBase64String(decryptedBytes));

                String decryptedText = ByteConverter.GetString(decryptedBytes);
                Console.WriteLine("Decrypted text: " + decryptedText);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        internal void archiveFiles()
        {
            //check if file is already archived
            //if not, open archive file
            //add files to archive and close file
        }

        internal void encryptArchive()
        {

        }

        internal void decryptArchive()
        {

        }

        internal void encryptAESKey()
        {

        }

        internal void decryptAESKey()
        {

        }

        internal void testDecrypt()
        {

        }

    }
}
