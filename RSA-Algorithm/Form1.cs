using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSA_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //UnicodeEncoder to convert between byte array and string.
        UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

        //Initializes a new instance of the RSACryptoServiceProvider class with a random key pair.
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

        //Byte arrays to hold original, encrypted, and decrypted data.
        byte[] plainText;
        byte[] encryptedText;

        /// <summary>
        /// Encrypt Button.
        /// </summary>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            plainText = unicodeEncoding.GetBytes(tbPlainEncryption.Text); //text from first textbox (text to encrypt)          

            //Encrypts data with RSA algorithm.
            encryptedText = Encryption(plainText, RSA.ExportParameters(false), false); //false for export the public key information            
            tbEncrypted.Text = Convert.ToBase64String(encryptedText); //pass data to the second textbox (encrypted data)

            using (var RSA = new RSACryptoServiceProvider())
            {
                rTbKey.Text = RSA.ToXmlString(true); //pass private key to the third textbox
                rTbPublicKey.Text = RSA.ToXmlString(false); //pass public key to the fourth textbox
            }                
        }

        /// <summary>
        /// Decrypt Button.
        /// </summary>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //Decrypts data with RSA algorithm.
            byte[] decryptedText = Decryption(encryptedText, RSA.ExportParameters(true), false); //true for export the private key information
            tbPlainDecryption.Text = unicodeEncoding.GetString(decryptedText); //pass data to the fourth textbox (decrypted data)

            using (var RSA = new RSACryptoServiceProvider())
            {
                string publicKey = RSA.ToXmlString(false); //pass public key to the variable
            }
        }

        /// <summary>
        /// Save private key to file.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PrivateKey.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(rTbKey.Text);
            writer.Close();

            string caption = "Saved!";
            string msg = "Private key saved succesfully!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(msg, caption, buttons);            
        }

        /// <summary>
        /// Save public key to file.
        /// </summary>
        private void btnSavePublicKey_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PublicKey.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.Write(rTbPublicKey.Text);
            writer.Close();

            string caption = "Saved!";
            string msg = "Public key saved succesfully!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(msg, caption, buttons);
        }

        /// <summary>
        /// Copy to clipbord encryption text.
        /// </summary>
        private void btnCopyEncrypts_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEncrypted.Text);
        }

        /// <summary>
        /// Copy to clipbord private key.
        /// </summary>
        private void btnCopyKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rTbKey.Text);
        }

        /// <summary>
        /// Copy to clipbord public key.
        /// </summary>
        private void btnCopyPublicKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rTbPublicKey.Text);
        }

        /// <summary>
        /// Clear all.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEncrypted.Text = "";
            tbPlainDecryption.Text = "";
            tbPlainEncryption.Text = "";
            rTbKey.Text = "";
        }

        /// <summary>
        /// Close application.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Function for Encryption
        /// </summary>
        /// <returns>Enrypted data or error.</returns>
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPading)
        {
            try
            {
                byte[] encryptedData;

                //New instance of RSACryptoServiceProvider to generate public and private key
                using (var RSA = new RSACryptoServiceProvider())
                {                    
                    RSA.ImportParameters(RSAKey); //to include the public key information
                    encryptedData = RSA.Encrypt(Data, DoOAEPPading); //data for encrypt
                }
                return encryptedData;
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Function for Decryption
        /// </summary>
        /// <returns>Decrypted data or error.</returns>
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPading)
        {
            try
            {
                byte[] decryptedData;

                //New instance of RSACryptoServiceProvider to generate public and private key
                using (var RSA = new RSACryptoServiceProvider())
                {                    
                    RSA.ImportParameters(RSAKey); //to include the private key information
                    decryptedData = RSA.Decrypt(Data, DoOAEPPading); //data for decrypt
                }
                return decryptedData;
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }        
    }
}
