using RDO.Data;
using RDO.Data.Types;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "RDO Files (*.rdo)|*.rdo|DAT Files (*.dat)|*.dat";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Root root = (Root)loadData(openFileDialog.FileName, Type.GetType("RDO.Data.Types.Root"));
                Connections conn = (Connections)root.Nodes[1];
                for (int i = 0; i < conn.Nodes.Count; i++)
                {

                    if (conn.Nodes[i].GetType().ToString() == "RDO.Data.Types.Folder")
                    {
                        ParseFolder((Folder)conn.Nodes[i]);
                    }
                    else if (conn.Nodes[i].GetType().ToString() == "RDO.Data.Types.RemoteDesktop")
                    {
                        ParseRemoteDesktop((RemoteDesktop)conn.Nodes[i]);
                    }
                }
                label1.Text = "记录数： " + (dataGridView1.Rows.Count - 1).ToString();
            }
        }
        public static object loadData(string string_0, Type type_0)
        {
            Stream stream = null;
            object result = null;
            stream = File.OpenRead(string_0);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            VersionBinder binder = new VersionBinder();
            binaryFormatter.Binder = binder;
            result = binaryFormatter.Deserialize(stream);
            return result;
        }

        public static string Decrypt(string string_0)
        {
            try
            {
                string strPassword = "swevA2t62We?5Cr+he4Tac?_E!redafa?re5+2huv*$rU9eS8Ub4?W!!R+s7uthU";
                byte[] array = new byte[string_0.Length / 2];
                for (int i = 0; i < string_0.Length / 2; i++)
                {
                    int num = Convert.ToInt32(string_0.Substring(i * 2, 2), 16);
                    array[i] = (byte)num;
                }
                PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(strPassword, new byte[]
                {
                    73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118
                });
                MemoryStream memoryStream = new MemoryStream();
                Rijndael rijndael = Rijndael.Create();
                rijndael.Key = passwordDeriveBytes.GetBytes(32);
                rijndael.IV = passwordDeriveBytes.GetBytes(16);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(array, 0, array.Length);
                cryptoStream.Close();
                return Encoding.Unicode.GetString(memoryStream.ToArray());
            }
            catch (Exception)
            {
                return "";
            }

        }

        public void ParseFolder(Folder folder)
        {
            for (int i = 0; i < folder.Nodes.Count; i++)
            {
                if (folder.Nodes[i].GetType().ToString() == "RDO.Data.Types.Folder")
                {
                    ParseFolder((Folder)folder.Nodes[i]);
                }
                else if (folder.Nodes[i].GetType().ToString() == "RDO.Data.Types.RemoteDesktop")
                {
                    ParseRemoteDesktop((RemoteDesktop)folder.Nodes[i]);
                }
            }
        }

        public void ParseRemoteDesktop(RemoteDesktop rdp)
        {
            dataGridView1.Rows.Add(rdp.Host, rdp.User, Decrypt(rdp.Password), rdp.Description);
        }
    }
}
