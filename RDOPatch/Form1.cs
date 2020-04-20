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
            richTextBox1.Text = "";
            Root root = (Root)smethod_1("Connections.rdo", Type.GetType("RDO.Data.Types.Root"));

            //IdCards idcard = (IdCards)root.Nodes[0];
            Connections conn = (Connections)root.Nodes[1];
            for (int i = 0; i < conn.Nodes.Count; i++)
            {
                try
                {
                    Folder folder = (Folder)conn.Nodes[i];
                    for (int j = 0; j < folder.Nodes.Count; j++)
                    {
                        try
                        {
                            RemoteDesktop rdp = (RemoteDesktop)folder.Nodes[j];
                            richTextBox1.Text += " Host: " + rdp.Host + " Username: " + rdp.User + " Password: " + smethod_5(rdp.Password) + " Description: " + rdp.Description + "\n";
                        }
                        catch (Exception)  //二层文件夹，懒得判断，有需求的自己改写。
                        {
                            Folder folder2 = (Folder)folder.Nodes[j];
                            for (int k = 0; k < folder2.Nodes.Count; k++)
                            {
                                RemoteDesktop rdp2 = (RemoteDesktop)folder2.Nodes[k];
                                richTextBox1.Text += " Host: " + rdp2.Host + " Username: " + rdp2.User + " Password: " + smethod_5(rdp2.Password) + " Description: " + rdp2.Description + "\n";
                            }
                        }

                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }

            string[] count = richTextBox1.Lines;
            label1.Text = "记录数： " + (count.Length - 1).ToString();
        }
        public static object smethod_1(string string_0, Type type_0)
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

        public static byte[] smethod_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
        {
            MemoryStream memoryStream = new MemoryStream();
            Rijndael rijndael = Rijndael.Create();
            rijndael.Key = byte_1;
            rijndael.IV = byte_2;
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(byte_0, 0, byte_0.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public static string smethod_5(string string_0)
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
                73,
                118,
                97,
                110,
                32,
                77,
                101,
                100,
                118,
                101,
                100,
                101,
                118
            });
            byte[] bytes = smethod_4(array, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
            return Encoding.Unicode.GetString(bytes);
        }
    }
}
