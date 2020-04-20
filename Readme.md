# RDODecrypt

Remote Desktop Organizer (RDO) <= 1.4.7 密码解密

逆向程序把关键解密方法拿出来用就好了，我顺便写了个反序列化配置文件一键读取密码，时间有限随便写写。

关键解密方法：
```csharp
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
```

读取配置文件默认只读取到二层文件夹，有需求的可以改改代码。

![圖片](https://user-images.githubusercontent.com/40329078/79737192-88cb1900-832d-11ea-80e9-724dc55ed03e.png)
