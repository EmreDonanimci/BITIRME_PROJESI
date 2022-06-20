using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security;
using System.IO;

namespace BITIRME_PROJESI
{
    internal class Basit_sifreleme
    {
        //Rijandel Start
        public string rSifrele(string strGiris)
        {
            string sonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifrelenecek veri yok.");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678");
                byte[] aryIV = ByteConvert.Byte8("1234567812345678");
                RijndaelManaged dec = new RijndaelManaged();
                dec.Mode = CipherMode.CBC;
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
        public string rCoz(string strGiris)
        {
            string strSonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("Şifrezi çözülecek veri yok.");
            }
            else
            {
                byte[] aryKey = ByteConvert.Byte8("12345678");
                byte[] aryIV = ByteConvert.Byte8("1234567812345678");
                RijndaelManaged cp = new RijndaelManaged();
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
        //Rijandel Stop

        //Sezar Start
        public byte anahtar;
        public string kullanici_yazi;
        public string sifre_yazi;

        public void CaesarCipher_kod(byte anahtar, string sifre_yazi)
        {
            this.anahtar = anahtar;
            this.kullanici_yazi = sifre_yazi;
        }

        private bool Kontrol_Sesli_Karakter(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string sSifrele()
        {
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !Kontrol_Sesli_Karakter(kullanici_yazi[i]))
                {
                    int formul;

                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) + anahtar) % 26;
                        sifre_yazi += (char)(formul + 65);
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) + anahtar) % 26;
                        sifre_yazi += (char)(formul + 97);
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            return sifre_yazi;
        }

        public string sSifre_coz()
        {
            sifre_yazi = "";

            for (int i = 0, s = kullanici_yazi.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yazi[i]) && !Kontrol_Sesli_Karakter(kullanici_yazi[i]))
                {
                    int formul;

                    if (char.IsUpper(kullanici_yazi[i]))
                    {
                        formul = ((kullanici_yazi[i] - 65) - anahtar) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 65);
                    }
                    else
                    {
                        formul = ((kullanici_yazi[i] - 97) - anahtar) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yazi += (char)(formul + 97);
                    }
                }
                else
                {
                    sifre_yazi += kullanici_yazi[i];
                }
            }

            return sifre_yazi;
        }
        //Sezar Stop

        //Anahtar Sözcük Vigenere Start

        private string anahtar_kelimev;
        private int anahtar_kelime_lengthv;
        private int anahtar_kelime_sayacv;
        private string kullanici_yaziv;
        private string sifre_yaziv;

        public void kodlar(string anahtar_kelime, string sifre_yazi)
        {
            this.anahtar_kelimev = anahtar_kelime;
            this.kullanici_yaziv = sifre_yazi;
            this.anahtar_kelime_lengthv = anahtar_kelime.Length;
        }

        private bool karakterkontrol(char karakter)
        {
            if (karakter == 'ç' || karakter == 'Ç' || karakter == 'ğ' || karakter == 'Ğ' || karakter == 'ı' || karakter == 'İ' || karakter == 'ö' || karakter == 'Ö' || karakter == 'ş' || karakter == 'Ş' || karakter == 'ü' || karakter == 'Ü')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AnahtarKelimeAlfabetikMi()
        {
            bool sonuc = true;

            for (int i = 0, s = anahtar_kelime_lengthv; i < s; i++)
            {
                if (char.IsLetter(anahtar_kelimev[i]) && !karakterkontrol(anahtar_kelimev[i]))
                {
                    continue;
                }
                else
                {
                    sonuc = false;
                    break;
                }
            }

            return sonuc;
        }

        public string vgSifrele()
        {
            sifre_yaziv = "";
            anahtar_kelime_sayacv = 0;

            for (int i = 0, s = kullanici_yaziv.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yaziv[i]) && !karakterkontrol(kullanici_yaziv[i]))
                {
                    int formul;

                    if (char.IsUpper(kullanici_yaziv[i]))
                    {
                        formul = ((kullanici_yaziv[i] - 65) + (char.ToUpper(anahtar_kelimev[anahtar_kelime_sayacv % anahtar_kelime_lengthv]) - 65)) % 26;
                        sifre_yaziv += (char)(formul + 65);
                        anahtar_kelime_sayacv++;
                    }
                    else
                    {
                        formul = ((kullanici_yaziv[i] - 97) + (char.ToLower(anahtar_kelimev[anahtar_kelime_sayacv % anahtar_kelime_lengthv]) - 97)) % 26;
                        sifre_yaziv += (char)(formul + 97);
                        anahtar_kelime_sayacv++;
                    }
                }
                else
                {
                    sifre_yaziv += kullanici_yaziv[i];
                }
            }

            return sifre_yaziv;
        }

        public string vgDesifreEt()
        {
            sifre_yaziv = "";
            anahtar_kelime_sayacv = 0;

            for (int i = 0, s = kullanici_yaziv.Length; i < s; i++)
            {
                if (char.IsLetter(kullanici_yaziv[i]) && !karakterkontrol(kullanici_yaziv[i]))
                {
                    int formul;

                    if (char.IsUpper(kullanici_yaziv[i]))
                    {
                        formul = ((kullanici_yaziv[i] - 65) - (char.ToUpper(anahtar_kelimev[anahtar_kelime_sayacv % anahtar_kelime_lengthv]) - 65)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yaziv += (char)(formul + 65);
                        anahtar_kelime_sayacv++;
                    }
                    else
                    {
                        formul = ((kullanici_yaziv[i] - 97) - (char.ToLower(anahtar_kelimev[anahtar_kelime_sayacv % anahtar_kelime_lengthv]) - 97)) % 26;
                        if (formul < 0)
                        {
                            formul += 26;
                        }

                        sifre_yaziv += (char)(formul + 97);
                        anahtar_kelime_sayacv++;
                    }
                }
                else
                {
                    sifre_yaziv += kullanici_yaziv[i];
                }
            }

            return sifre_yaziv;
        }
    }
}
