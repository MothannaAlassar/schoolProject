using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SchoolProject
{
    public partial class FrmConnectionSetting:Form
    {
        public static int MinTimeout = 3;
        public static int MaxTimeout = 30;
        public static int MiddleTimeout = 15;
        public static int DefaultTimeout = 0;
        public static string EncryptionKey = "AbulahZab-abo-sam";
        static string script = @"USE [master]
GO
/****** Object:  Table [dbo].[ZZ]    Script Date: 19/03/2019 05:06:47 ص ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ZZ]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ZZ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DBName] [nvarchar](50) NULL,
	[Fyear] [int] NULL,
	[ServerName] [nvarchar](50) NULL,
	[IsDefualt] [bit] NULL CONSTRAINT [DF_ZZ_IsDefualt]  DEFAULT ((0)),
	[UID] [nvarchar](500) NULL,
	[PWD] [nvarchar](1500) NULL,
 CONSTRAINT [PK_ZZ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[ZZ] ON 

GO
if not exists(select * from [dbo].[ZZ])
 begin
INSERT [dbo].[ZZ] ([ID], [DBName], [Fyear], [ServerName], [IsDefualt], [UID], [PWD]) VALUES (1, N'{0}', 2019, N'{1}', 1, N'{2}', N'{3}')
end
else update [dbo].[ZZ] set UID=N'{2}' PWD=N'{3}' where IsDefualt=1
GO
SET IDENTITY_INSERT [dbo].[ZZ] OFF
GO";
        public FrmConnectionSetting()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void RefreshInstances()
        {
            cmbServerInstances.Items.Clear();
            foreach (string s in SqlHelper.ListLocalSqlInstances())
                cmbServerInstances.Items.Add(s);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInstances();
        }
        public bool IsNull(string st)
        {
            return string.IsNullOrEmpty(st) || string.IsNullOrWhiteSpace(st);
        }
        private void btnConfigure_Click(object sender, EventArgs e)
        {
            //ConnStr = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=false;User ID={2};Password={3}; MultipleActiveResultSets=true;",
            //                       rdr.GetString(srvrO), rdr.GetString(dbO), rdr.GetString(uidO), rdr.GetString(PwdO));// rdr.GetString(dbO));
            errorProvider1.Clear();
            var sb = new StringBuilder();
            if (IsNull(cmbServerInstances.Text))
            {
                errorProvider1.SetError(cmbServerInstances, ".?");
                return;
            }
            if (IsNull(txtUserID.Text))
            {
                errorProvider1.SetError(txtUserID, ".?");
                return;
            }
          
            if (IsNull(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, ".?");
                return;
            }
            if (IsNull(txtCatalog.Text))
            {
                errorProvider1.SetError(txtCatalog, ".?");
                return;
            }
            sb.AppendFormat("Data Source={0};", cmbServerInstances.Text);
            sb.AppendFormat("Initial Catalog={0};Integrated Security=false;", txtCatalog.Text);
            sb.AppendFormat("User ID={0};", txtUserID.Text);
            sb.AppendFormat("Password={0};", txtPassword.Text);
            sb.AppendFormat("MultipleActiveResultSets=true;");
            sb.AppendFormat("Connect Timeout={0};",6);
            if (TryConnect(sb.ToString()))
            {
                MessageBox.Show("Operation is done Successfully");
                txtConn.Text = StringCipher.Encrypt(sb.ToString(), EncryptionKey);
                txtZpwd.Text = StringCipher.Encrypt(txtPassword.Text, EncryptionKey);
            }
            else
            {
                MessageBox.Show("Operation Failed");
                txtConn.Text = "";
                txtZpwd.Text = "";
            }
        }
        public static bool TryConnect(string ConnStr)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(ConnStr))
            {
                try
                {
                    
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    return true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.Replace("'sa'", "USER")); }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                conn.Dispose();
                return false;
            }
        }
        private void cmbServerInstances_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmbServerInstances.Text = Environment.MachineName;
        }

        private void FrmConnectionSetting_ResizeEnd(object sender, EventArgs e)
        {
            this.Width = 480;
        }

        private void FrmConnectionSetting_ResizeBegin(object sender, EventArgs e)
        {
            this.Width = 480;
        }

        private void FrmConnectionSetting_Resize(object sender, EventArgs e)
        {
            this.Width = 480;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (IsNull(txtConn.Text))
            {
                errorProvider1.SetError(txtConn, ".?");
                return;
            }
            if (IsNull(txtZpwd.Text))
            {
                errorProvider1.SetError(txtZpwd, ".?");
                return;
            }
            if (IsNull(txtVersion.Text) || !txtVersion.Text.Equals(Program.VERSIONSIGN))
            {
                errorProvider1.SetError(txtVersion, ".?");
                return;
            }
            if (IsNull(txtStep1.Text) || !txtStep1.Text.Equals("AbulahZab"))
            {
                errorProvider1.SetError(txtStep1, ".?");
                return;
            }
            if (IsNull(txtStep2.Text) || !txtStep2.Text.Equals("AlAssar"))
            {
                errorProvider1.SetError(txtStep2, ".?");
                return;
            }
            if (!TryConnect(StringCipher.Decrypt(txtConn.Text,EncryptionKey)))
            {
                errorProvider1.SetError(txtConn, "Trying Decrypting Is Not Correct!!??");
                return;
            }
            if (!File.Exists(Program.ConnFile))
            {
                File.Create(Program.ConnFile);
            }
            else
                File.WriteAllText(Program.ConnFile, txtConn.Text);
            MessageBox.Show("Operation is done Successfully");
        }
        private  bool GeneratSecretTable()
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(StringCipher.Decrypt(txtConn.Text, EncryptionKey)))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format(script, txtCatalog.Text, cmbServerInstances.Text, txtUserID.Text, txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message.Replace("'sa'", "USER")); }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
                conn.Dispose();
                return false;
            }
        }

        private void FrmConnectionSetting_Load(object sender, EventArgs e)
        {
            txtVersion.Text = Program.VERSIONSIGN;
            txtStep1.Text = "AbulahZab";
            txtStep2.Text = "AlAssar";
        }
    }
    public static class SqlHelper
    {
        public static IEnumerable<string> ListLocalSqlInstances()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }

                using (var hive = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                {
                    foreach (string item in ListLocalSqlInstances(hive))
                    {
                        yield return item;
                    }
                }
            }
            else
            {
                foreach (string item in ListLocalSqlInstances(Registry.LocalMachine))
                {
                    yield return item;
                }
            }
        }

        private static IEnumerable<string> ListLocalSqlInstances(RegistryKey hive)
        {
            const string keyName = @"Software\Microsoft\Microsoft SQL Server";
            const string valueName = "InstalledInstances";
            const string defaultName = "MSSQLSERVER";

            using (var key = hive.OpenSubKey(keyName, false))
            {
                if (key == null) return Enumerable.Empty<string>();

                var value = key.GetValue(valueName) as string[];
                if (value == null) return Enumerable.Empty<string>();

                for (int index = 0; index < value.Length; index++)
                {
                    if (string.Equals(value[index], defaultName, StringComparison.OrdinalIgnoreCase))
                    {
                        value[index] = ".";
                    }
                    else
                    {
                        value[index] = @".\" + value[index];
                    }
                }

                return value;
            }
        }
    }
    public static class StringCipher
    {
        // This constant is used to determine the keysize of the encryption algorithm in bits.
        // We divide this by 8 within the code below to get the equivalent number of bytes.
        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
