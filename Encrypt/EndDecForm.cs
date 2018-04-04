using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class EncDecForm : Form
    {
        private int _CipherSpace = 4;
        StringBuilder sbEnc = new StringBuilder();
        StringBuilder sbDec = new StringBuilder();

        public EncDecForm()
        {
            InitializeComponent();
        }

        private void btnEncDec_Click(object sender, EventArgs e)
        {
            txtEncDec.Text = DeCipherMe(txtEncDec.Text);
        }

        private string CipherMe(string blob)
        {
            sbEnc.Clear();
            
            foreach (char c in blob)
            {
                sbEnc.Append((char)(c + _CipherSpace));
            }

            return sbEnc.ToString();
        }

        private string DeCipherMe(string blob)
        {
            sbDec.Clear();

            foreach (char c in blob)
            {
                sbDec.Append((char)(c - _CipherSpace));
            }

            return sbDec.ToString();
        }

        private static void RSA(string blob)
        {
            var enc = Encrypt<AesManaged>(blob, "kapoor", "192.168.2.1");
            var dec = Decrypt<AesManaged>(enc, "kapoor", "192.168.2.1");
        }

        private static string Encrypt<T>(string value, string password, string salt)
        where T : SymmetricAlgorithm, new()
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

            SymmetricAlgorithm algorithm = new T();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

            ICryptoTransform transform = algorithm.CreateEncryptor(rgbKey, rgbIV);

            using (MemoryStream buffer = new MemoryStream())
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                    {
                        writer.Write(value);
                    }
                }

                return Convert.ToBase64String(buffer.ToArray());
            }
        }

        private static string Decrypt<T>(string text, string password, string salt)
           where T : SymmetricAlgorithm, new()
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));

            SymmetricAlgorithm algorithm = new T();

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

            ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

            using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(text)))
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            txtEncDec.Text = CipherMe(txtEncDec.Text);
        }

        private void cbEnc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnc.CheckState == CheckState.Checked)
            {
                txtEncDec.KeyPress += txtEncDec_KeyPress;
            }
            else
            {
                txtEncDec.KeyPress -= txtEncDec_KeyPress;
            }
        }

        private void txtEncDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter || e.KeyChar == 3 || e.KeyChar == 22)
            {
                return;
            }

            txtEncDec.Text += ((char)(e.KeyChar + _CipherSpace)).ToString();
            e.Handled = true;

            txtEncDec.Select(txtEncDec.Text.Length, 0);             
        }
    }
}
