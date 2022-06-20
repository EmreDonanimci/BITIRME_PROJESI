using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BITIRME_PROJESI
{
    internal class Algoritmalar
    {
        //DES Start
        public string DESSifrele(string strGiris)
        {
            string sonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifrelenecek veri yok");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678"); // BURAYA 8 bit string DEĞER GİRİN
                byte[] aryIV = ByteConvert.Byte8("12345678"); // BURAYA 8 bit string DEĞER GİRİN
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
                StreamWriter writer = new StreamWriter(cs);
                writer.Write(strGiris);
                writer.Flush();
                cs.FlushFinalBlock();
                writer.Flush();
                sonuc = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                writer.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return sonuc;
        }

        public string DESCoz(string strGiris)
        {
            string strSonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifrelenecek veri yok.");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678");
                byte[] aryIV = ByteConvert.Byte8("12345678");
                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(strGiris));
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cs);
                strSonuc = reader.ReadToEnd();
                reader.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return strSonuc;
        }

        public string danahtar_çalıştırma()
        {

            DESCryptoServiceProvider kripto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(kripto.Key);
        }
        public void DES_dosya_sifreleme(string adres, string yeniadres, string StrKarma)
        {

            TripleDESCryptoServiceProvider TDCS = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream OkuStream = new FileStream(adres, FileMode.Open, FileAccess.Read);
            FileStream YazmaStream = new FileStream(yeniadres, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] Karma = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(StrKarma));
            byte[] Metin_Oku = File.ReadAllBytes(adres);

            md5.Clear();

            TDCS.Key = Karma;
            TDCS.Mode = CipherMode.ECB;

            CryptoStream kriptoStream = new CryptoStream(YazmaStream, TDCS.CreateEncryptor(), CryptoStreamMode.Write);
            int depo;
            long position = 0;
            while (position < OkuStream.Length)
            {
                depo = OkuStream.Read(Metin_Oku, 0, Metin_Oku.Length);
                position += depo;

                kriptoStream.Write(Metin_Oku, 0, depo);
            }

            OkuStream.Close();
            YazmaStream.Close();
        }
        public void DES_dosya_sifreCozme(string adres, string yeniadres, string StrKarma)
        {

            TripleDESCryptoServiceProvider TDCS = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream OkuStream = new FileStream(adres, FileMode.Open, FileAccess.Read);
            FileStream YazmaStream = new FileStream(yeniadres, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] Karma = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(StrKarma));
            byte[] Metin_Oku = File.ReadAllBytes(adres);

            md5.Clear();

            TDCS.Key = Karma;
            TDCS.Mode = CipherMode.ECB;

            CryptoStream kriptoStream = new CryptoStream(YazmaStream, TDCS.CreateDecryptor(), CryptoStreamMode.Write);
            int depo;
            long position = 0;
            while (position < OkuStream.Length)
            {
                depo = OkuStream.Read(Metin_Oku, 0, Metin_Oku.Length);
                position += depo;

                kriptoStream.Write(Metin_Oku, 0, depo);
            }

            OkuStream.Close();
            YazmaStream.Close();
        }
        //DES Stop



        //TRİPLEDES Start

        public string hash = "MustafaErdoganEmreVuralAliNakiKiral";

        public string tEncrypt(string sifre)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public string tDecrypt(string SifrelenmisDeger)
        {
            byte[] data = Convert.FromBase64String(SifrelenmisDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        public void TripleDES(string key)
        {
            des.Key = UTF8Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.ECB; //Electronic Code Book
            des.Padding = PaddingMode.PKCS7;
        }

        public void tEncryptFile(string filepath)
        {
            byte[] Bytes = File.ReadAllBytes(filepath);
            byte[] eBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filepath, eBytes);
        }

        public void tDecryptFile(string filepath)
        {
            byte[] Bytes = File.ReadAllBytes(filepath);
            byte[] dBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filepath, dBytes);
        }
        //TRİPLEDES Stop


        //RC2 Start
        public string RC2_Sifrele(string strGiris)
        {
            string sonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifrelenecek veri yok.");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678");
                byte[] aryIV = ByteConvert.Byte8("12345678");
                RC2CryptoServiceProvider dec = new RC2CryptoServiceProvider();
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, dec.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
                StreamWriter writer = new StreamWriter(cs);
                writer.Write(strGiris);
                writer.Flush();
                cs.FlushFinalBlock();
                writer.Flush();
                sonuc = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                writer.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return sonuc;
        }

        public string RC2_Coz(string strGiris)
        {
            string strSonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifresi çözülecek veri yok.");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678");
                byte[] aryIV = ByteConvert.Byte8("12345678");
                RC2CryptoServiceProvider cp = new RC2CryptoServiceProvider();
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(strGiris));
                CryptoStream cs = new CryptoStream(ms, cp.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cs);
                strSonuc = reader.ReadToEnd();
                reader.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return strSonuc;
        }
        public string rcanahtar_çalıştırma()
        {
            RC2CryptoServiceProvider kripto = (RC2CryptoServiceProvider)RC2CryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(kripto.Key);
        }
        public void RC2_dosya_sifreleme(string adres, string yeniadres, string StrKarma)
        {

            RC2CryptoServiceProvider TDCS = new RC2CryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream OkuStream = new FileStream(adres, FileMode.Open, FileAccess.Read);
            FileStream YazmaStream = new FileStream(yeniadres, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] Karma = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(StrKarma));
            byte[] Metin_Oku = File.ReadAllBytes(adres);

            md5.Clear();

            TDCS.Key = Karma;
            TDCS.Mode = CipherMode.ECB;

            CryptoStream kriptoStream = new CryptoStream(YazmaStream, TDCS.CreateEncryptor(), CryptoStreamMode.Write);
            int depo;
            long position = 0;
            while (position < OkuStream.Length)
            {
                depo = OkuStream.Read(Metin_Oku, 0, Metin_Oku.Length);
                position += depo;

                kriptoStream.Write(Metin_Oku, 0, depo);
            }

            OkuStream.Close();
            YazmaStream.Close();
        }
        public void RC2_dosya_sifreCozme(string adres, string yeniadres, string StrKarma)
        {

            RC2CryptoServiceProvider TDCS = new RC2CryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            FileStream OkuStream = new FileStream(adres, FileMode.Open, FileAccess.Read);
            FileStream YazmaStream = new FileStream(yeniadres, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] Karma = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(StrKarma));
            byte[] Metin_Oku = File.ReadAllBytes(adres);

            md5.Clear();

            TDCS.Key = Karma;
            TDCS.Mode = CipherMode.ECB;

            CryptoStream kriptoStream = new CryptoStream(YazmaStream, TDCS.CreateDecryptor(), CryptoStreamMode.Write);
            int depo;
            long position = 0;
            while (position < OkuStream.Length)
            {
                depo = OkuStream.Read(Metin_Oku, 0, Metin_Oku.Length);
                position += depo;

                kriptoStream.Write(Metin_Oku, 0, depo);
            }

            OkuStream.Close();
            YazmaStream.Close();
        }
        //RC2 Stop


        //RSA Start
        public string RSA_Encrypt(string Text)
        {
            var publicKey =
"<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            var testData = Encoding.UTF8.GetBytes(Text);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(publicKey.ToString());
                    var encryptedData = rsa.Encrypt(testData, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public string RSA_Decrypt(string Text)
        {
            string BOS = "";
            try
            {
                var privateKey =
    "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent><P>/aULPE6jd5IkwtWXmReyMUhmI/nfwfkQSyl7tsg2PKdpcxk4mpPZUdEQhHQLvE84w2DhTyYkPHCtq/mMKE3MHw==</P><Q>3WV46X9Arg2l9cxb67KVlNVXyCqc/w+LWt/tbhLJvV2xCF/0rWKPsBJ9MC6cquaqNPxWWEav8RAVbmmGrJt51Q==</Q><DP>8TuZFgBMpBoQcGUoS2goB4st6aVq1FcG0hVgHhUI0GMAfYFNPmbDV3cY2IBt8Oj/uYJYhyhlaj5YTqmGTYbATQ==</DP><DQ>FIoVbZQgrAUYIHWVEYi/187zFd7eMct/Yi7kGBImJStMATrluDAspGkStCWe4zwDDmdam1XzfKnBUzz3AYxrAQ==</DQ><InverseQ>QPU3Tmt8nznSgYZ+5jUo9E0SfjiTu435ihANiHqqjasaUNvOHKumqzuBZ8NRtkUhS6dsOEb8A2ODvy7KswUxyA==</InverseQ><D>cgoRoAUpSVfHMdYXW9nA3dfX75dIamZnwPtFHq80ttagbIe4ToYYCcyUz5NElhiNQSESgS5uCgNWqWXt5PnPu4XmCXx6utco1UVH8HGLahzbAnSy6Cj3iUIQ7Gj+9gQ7PkC434HTtHazmxVgIR5l56ZjoQ8yGNCPZnsdYEmhJWk=</D></RSAKeyValue>";

                var testData = Encoding.UTF8.GetBytes(Text);
                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    try
                    {
                        var base64Encrypted = Text;
                        rsa.FromXmlString(privateKey);
                        var resultBytes = Convert.FromBase64String(base64Encrypted);
                        var decryptedBytes = rsa.Decrypt(resultBytes, true);
                        var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                        return decryptedData.ToString();
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            catch { return BOS; }
        }


        readonly string pubKeyPath = "public.key";//change as needed
        readonly string priKeyPath = "private.key";//change as needed
        public void RSA_MakeKey()
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);

            RSAParameters privKey = csp.ExportParameters(true);

            RSAParameters pubKey = csp.ExportParameters(false);
            string pubKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, pubKey);
                pubKeyString = sw.ToString();
                File.WriteAllText(pubKeyPath, pubKeyString);
            }
            string privKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, privKey);
                privKeyString = sw.ToString();
                File.WriteAllText(priKeyPath, privKeyString);
            }
        }
        public void RSA_EncryptFile(string filePath)
        {
            string pubKeyString;
            {
                using (StreamReader reader = new StreamReader(pubKeyPath)) { pubKeyString = reader.ReadToEnd(); }
            }
            var sr = new StringReader(pubKeyString);

            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.ImportParameters((RSAParameters)xs.Deserialize(sr));
            byte[] bytesPlainTextData = File.ReadAllBytes(filePath);

            var bytesCipherText = csp.Encrypt(bytesPlainTextData, false);
            string encryptedText = Convert.ToBase64String(bytesCipherText);
            File.WriteAllText(filePath, encryptedText);
        }
        public void RSA_DecryptFile(string filePath)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();

            string privKeyString;
            {
                privKeyString = File.ReadAllText(priKeyPath);
                var sr = new StringReader(privKeyString);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                RSAParameters privKey = (RSAParameters)xs.Deserialize(sr);
                csp.ImportParameters(privKey);
            }
            string encryptedText;
            using (StreamReader reader = new StreamReader(filePath)) { encryptedText = reader.ReadToEnd(); }
            byte[] bytesCipherText = Convert.FromBase64String(encryptedText);

            byte[] bytesPlainTextData = csp.Decrypt(bytesCipherText, false);

            File.WriteAllBytes(filePath, bytesPlainTextData);
        }
        //RSA Stop

        //AES Start
        private const string AES_IV = @"!&+QWSDF!123126+";
        private string aeskey = @"QQsaw!257()%%ert";

        public string aessifrele(string metin)
        {
            AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;
            aesSaglayici.IV = Encoding.UTF8.GetBytes(AES_IV);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(aeskey);
            aesSaglayici.Mode = CipherMode.CBC;
            aesSaglayici.Padding = PaddingMode.PKCS7;
            byte[] kaynak = Encoding.Unicode.GetBytes(metin);
            using (ICryptoTransform sifrele = aesSaglayici.CreateEncryptor())
            {
                byte[] hedef = sifrele.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Convert.ToBase64String(hedef);
            }
        }
        public string aessifreCoz(string sifreliMetin)
        {
            AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;
            aesSaglayici.IV = Encoding.UTF8.GetBytes(AES_IV);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(aeskey);
            aesSaglayici.Mode = CipherMode.CBC;
            aesSaglayici.Padding = PaddingMode.PKCS7;
            byte[] kaynak = System.Convert.FromBase64String(sifreliMetin);
            using (ICryptoTransform decrypt = aesSaglayici.CreateDecryptor())
            {
                byte[] hedef = decrypt.TransformFinalBlock(kaynak, 0, kaynak.Length);
                return Encoding.Unicode.GetString(hedef);
            }
        }

        public string aesdanahtar_çalıştırma()
        {
            DESCryptoServiceProvider kripto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(kripto.Key);
        }
       

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        public void aesFileEncrypt(string inputFile, string password)
        {

            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);

            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                    cs.Write(buffer, 0, read);
                }

                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
        public void aesFileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
        //AES Stop
    }
}
