# RDODecrypt

Remote Desktop Organizer (RDO) <= 1.4.7 密码解密

逆向程序把关键解密方法拿出来用就好了，我顺便写了个反序列化配置文件一键读取密码。

关键解密方法：
```csharp
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
```

![01](https://user-images.githubusercontent.com/40329078/82014576-771c2d80-96af-11ea-96ae-973a519065e9.png)
