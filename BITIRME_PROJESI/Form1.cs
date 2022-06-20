using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITIRME_PROJESI
{
    public partial class Form1 : Form
    {
        Basit_sifreleme easy = new Basit_sifreleme();
        Algoritmalar All = new Algoritmalar();
        Hash hash = new Hash();
        OpenFileDialog ac = new OpenFileDialog();               
        SaveFileDialog kaydet = new SaveFileDialog();
        string anahtar2;
        public string password = "MustafaErdoganEmreVuralAliNakiKiral";
        public Form1()
        {
            InitializeComponent();
            anahtar2 = All.danahtar_çalıştırma();
            //anahtar = All.tdanahtar_çalıştırma();
            anahtar2 = All.rcanahtar_çalıştırma();
            anahtar2 = All.aesdanahtar_çalıştırma();
            ANAHTAR.Select();
        }

        private void SIFRELE_Click(object sender, EventArgs e)
        {
            if (SIFRELE.Name == "Tdes_encryp")
            {
                SIFRELENMIS_METIN.Text = All.tEncrypt(SIFRELENECEK_METIN.Text);

            }

            if (SIFRELE.Name == "des_encryp")
            {
                SIFRELENMIS_METIN.Text = All.DESSifrele(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "rc2_encryp")
            {
                SIFRELENMIS_METIN.Text = All.RC2_Sifrele(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "rsa_encryp")
            {
                SIFRELENMIS_METIN.Text = All.RSA_Encrypt(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "aes_encryp")
            {
                SIFRELENMIS_METIN.Text = All.aessifrele(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "md5_encryp")
            {
                SIFRELENMIS_METIN.Text = hash.MD5st(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "sha1_encryp")
            {
                SIFRELENMIS_METIN.Text = hash.SHA1(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "sha256_encryp")
            {
                SIFRELENMIS_METIN.Text = hash.SHA256(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "sha384_encryp")
            {
                SIFRELENMIS_METIN.Text = hash.SHA384(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "sha512_encryp")
            {
                SIFRELENMIS_METIN.Text = hash.SHA512(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "rijandel_encryp")
            {
                SIFRELENMIS_METIN.Text = easy.rSifrele(SIFRELENECEK_METIN.Text);
            }

            if (SIFRELE.Name == "sezar_encryp")
            {
                if (ANAHTAR.Text != "" && SIFRELENECEK_METIN.Text != "")
                {
                    try
                    {
                        easy.CaesarCipher_kod(byte.Parse(ANAHTAR.Text), SIFRELENECEK_METIN.Text);

                        SIFRELENMIS_METIN.Text = easy.sSifrele();
                    }

                    catch
                    {
                        MessageBox.Show("Lütfen anahtar sayıya 0 ile 255 arasında bir değer giriniz.");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen anahtar ve şifrelenecek metini giriniz.");
                }
            }

            if (SIFRELE.Name == "VG_encryp")
            {
                if (ANAHTAR.Text != "" && SIFRELENECEK_METIN.Text != "")
                {
                    easy.kodlar(ANAHTAR.Text, SIFRELENECEK_METIN.Text);

                    if (easy.AnahtarKelimeAlfabetikMi())
                    {
                        SIFRELENMIS_METIN.Text = easy.vgSifrele();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen anahtar kelimeye İngilizce karakter dışında birşey girmeyiniz.");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
                }
            }

            if (SIFRELE.Name == "Tdes_encryp_file")
            {


                if (ac.ShowDialog() == DialogResult.Cancel)
                    return;

                SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                //SaveFileDialog kaydet = new SaveFileDialog();
                //kaydet.ShowDialog();


                All.tEncryptFile(ac.FileName/*, textBox2.Text*/);

            }

            if (SIFRELE.Name == "des_encryp_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    if(kaydet.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.

                    All.DES_dosya_sifreleme(SIFRELENECEK_METIN.Text, SIFRELENMIS_METIN.Text, anahtar2);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + kaydet.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }

            if (SIFRELE.Name == "RC2_encryp_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    if (kaydet.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.

                    All.RC2_dosya_sifreleme(SIFRELENECEK_METIN.Text, SIFRELENMIS_METIN.Text, anahtar2);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + kaydet.FileName + " yoluna başarı ile kaydedildi";

                    }

                }

            }

            if (SIFRELE.Name == "rsa_encryp_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    All.RSA_EncryptFile(SIFRELENECEK_METIN.Text);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + ac.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }

            if (SIFRELE.Name == "aes_encryp_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    //SaveFileDialog kaydet = new SaveFileDialog();
                    //kaydet.ShowDialog();

                    //SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.



                    All.aesFileEncrypt(SIFRELENECEK_METIN.Text, password);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + ac.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }
        }


        private void TDES_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "Tdes_encryp_file";
            SIFRELE.Text = "TDES şifrele dosya";
            label2.Text = "Şifrelenecek dosya yolu";
            label3.Text = "Şifrelenmiş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;
            
        }

        private void DES_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "des_encryp_file";
            SIFRELE.Text = "DES şifrele dosya";
            label2.Text = "Şifrelenecek dosya yolu";
            label3.Text = "Şifrelenmiş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void RC2_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "RC2_encryp_file";
            SIFRELE.Text = "RC2 şifrele dosya";
            label2.Text = "Şifrelenecek dosya yolu";
            label3.Text = "Şifrelenmiş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void RSA_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "rsa_encryp_file";
            SIFRELE.Text = "RSA şifrele dosya";
            label2.Text = "Şifrelenecek dosya yolu";
            label3.Text = "Şifrelenmiş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = true;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void AES_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "aes_encryp_file";
            SIFRELE.Text = "AES şifrele dosya";
            label2.Text = "Şifrelenecek dosya yolu";
            label3.Text = "Şifrelenmiş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void TDES__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "Tdes_encryp";
            SIFRELE.Text = "TDES şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void DES__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "des_encryp";
            SIFRELE.Text = "DES şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void RC2__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "rc2_encryp";
            SIFRELE.Text = "RC2 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void RSA__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "rsa_encryp";
            SIFRELE.Text = "RSA şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void AES__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "aes_encryp";
            SIFRELE.Text = "AES şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void MD5_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "md5_encryp";
            SIFRELE.Text = "MD5 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void SHA1_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "sha1_encryp";
            SIFRELE.Text = "SHA1 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;


        }

        private void SHA256_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "sha256_encryp";
            SIFRELE.Text = "SHA256 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void SHA384_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "sha384_encryp";
            SIFRELE.Text = "SHA384 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void SHA512_Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "sha512_encryp";
            SIFRELE.Text = "SHA512 şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void RIJENDAEL__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "rijandel_encryp";
            SIFRELE.Text = "Rijandel şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void SEZAR__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "sezar_encryp";
            SIFRELE.Text = "Sezar şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            ANAHTAR.Visible = true;
            label1.Visible = true;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }

        private void ANAHTAR_SOZCUK_V__Click(object sender, EventArgs e)
        {
            SIFRELE.Name = "VG_encryp";
            SIFRELE.Text = "VG şifrele";
            label2.Text = "Şifrelenecek metin";
            label3.Text = "Şifrelenmiş metin";
            ANAHTAR.Visible = true;
            label1.Visible = true;
            SIFRE_COZ.Visible = false;
            SIFRELE.Visible = true;

        }


        private void SIFRE_COZ_Click(object sender, EventArgs e)
        {
            if (SIFRE_COZ.Name == "Tdes_decrypt")
            {
                SIFRELENMIS_METIN.Text = All.tDecrypt(SIFRELENECEK_METIN.Text);

            }

            if (SIFRE_COZ.Name == "des_decrypt")
            {
                SIFRELENMIS_METIN.Text = All.DESCoz(SIFRELENECEK_METIN.Text);
            }

            if (SIFRE_COZ.Name == "rc2_decrypt")
            {
                SIFRELENMIS_METIN.Text = All.RC2_Coz(SIFRELENECEK_METIN.Text);
            }

            if (SIFRE_COZ.Name == "rsa_decrypt")
            {
                SIFRELENMIS_METIN.Text = All.RSA_Decrypt(SIFRELENECEK_METIN.Text);
            }

            if (SIFRE_COZ.Name == "aes_decrypt")
            {
                SIFRELENMIS_METIN.Text = All.aessifreCoz(SIFRELENECEK_METIN.Text);
            }


            if (SIFRE_COZ.Name == "rijandel_decrypt")
            {
                SIFRELENMIS_METIN.Text = easy.rCoz(SIFRELENECEK_METIN.Text);
            }

            if (SIFRE_COZ.Name == "sezar_decrypt")
            {
                if (ANAHTAR.Text != "" && SIFRELENECEK_METIN.Text != "")
                {
                    try
                    {
                        easy.CaesarCipher_kod(byte.Parse(ANAHTAR.Text), SIFRELENECEK_METIN.Text);

                        SIFRELENMIS_METIN.Text = easy.sSifre_coz();
                    }

                    catch
                    {
                        MessageBox.Show("Lütfen anahtar sayıya 0 ile 255 arasında bir değer giriniz.");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen anahtar ve şifrelenecek metini giriniz.");
                }
            }

            if (SIFRE_COZ.Name == "VG_decrypt")
            {
                if (ANAHTAR.Text != "" && SIFRELENECEK_METIN.Text != "")
                {
                    easy.kodlar(ANAHTAR.Text, SIFRELENECEK_METIN.Text);

                    if (easy.AnahtarKelimeAlfabetikMi())
                    {
                        SIFRELENMIS_METIN.Text = easy.vgDesifreEt();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen anahtar kelimeye İngilizce karakter dışında birşey girmeyiniz.");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen kutuları boş bırakmayınız.");
                }
            }

            if (SIFRE_COZ.Name == "Tdes_decrypt_file")
            {

                if (ac.ShowDialog() == DialogResult.Cancel)
                    return;

                SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                //SaveFileDialog kaydet = new SaveFileDialog();
                //kaydet.ShowDialog();


                All.tDecryptFile(ac.FileName/*, textBox2.Text*/);

            }

            if (SIFRE_COZ.Name == "des_decrypt_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    if (kaydet.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.

                    All.DES_dosya_sifreCozme(SIFRELENECEK_METIN.Text, SIFRELENMIS_METIN.Text, anahtar2);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + kaydet.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }

            if (SIFRE_COZ.Name == "RC2_decrypt_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    if (kaydet.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.

                    All.RC2_dosya_sifreCozme(SIFRELENECEK_METIN.Text, SIFRELENMIS_METIN.Text, anahtar2);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + kaydet.FileName + " yoluna başarı ile kaydedildi";

                    }

                }

            }

            if (SIFRE_COZ.Name == "rsa_decrypt_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    All.RSA_DecryptFile(SIFRELENECEK_METIN.Text);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + ac.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }

            if (SIFRE_COZ.Name == "aes_decrypt_file")
            {
                {
                    if (ac.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENECEK_METIN.Text = ac.FileName;//Disk üzerindeki şifrelenecek dosya dizini

                    if (kaydet.ShowDialog() == DialogResult.Cancel)
                        return;

                    SIFRELENMIS_METIN.Text = kaydet.FileName;//Yeni dosya dizinine farklı kaydet yaptık.

                    // For additional security Pin the password of your files

                    // Encrypt the file

                    // To increase the security of the encryption, delete the given password from the memory !


                    All.aesFileDecrypt(SIFRELENECEK_METIN.Text, SIFRELENMIS_METIN.Text, password);

                    {

                        SIFRELENECEK_METIN.Text = "Hedef Dosya: " + ac.FileName + " youndan alındı";

                        SIFRELENMIS_METIN.Text = "Şifrelenmiş Dosya " + ac.FileName + " yoluna başarı ile kaydedildi";

                    }
                }
            }
        }

        private void TDES_DC_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "Tdes_decrypt_file";
            SIFRE_COZ.Text = "TDES şifre çöz dosya";
            label2.Text = "Şifrelenmiş dosya yolu";
            label3.Text = "Çözülmüş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;
            
        }

        private void DES_DC_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "des_decrypt_file";
            SIFRE_COZ.Text = "DES şifre çöz dosya";
            label2.Text = "Şifrelenmiş dosya yolu";
            label3.Text = "Çözülmüş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void RC2_DC_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "RC2_decrypt_file";
            SIFRE_COZ.Text = "RC2 şifre çöz dosya";
            label2.Text = "Şifrelenmiş dosya yolu";
            label3.Text = "Çözülmüş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void RSA_DC_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "rsa_decrypt_file";
            SIFRE_COZ.Text = "RSA şifre çöz dosya";
            label2.Text = "Şifrelenmiş dosya yolu";
            label3.Text = "Çözülmüş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = true;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void AES_DC_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "aes_decrypt_file";
            SIFRE_COZ.Text = "AES şifre çöz dosya";
            label2.Text = "Şifrelenmiş dosya yolu";
            label3.Text = "Çözülmüş dosya yolu";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void TDES_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "Tdes_decrypt";
            SIFRE_COZ.Text = "TDES şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void DES_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "des_decrypt";
            SIFRE_COZ.Text = "DES şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void RC2_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "rc2_decrypt";
            SIFRE_COZ.Text = "RC2 şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void RSA_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "rsa_decrypt";
            SIFRE_COZ.Text = "RSA şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void AES_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "aes_decrypt";
            SIFRE_COZ.Text = "AES şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void RJ_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "rijandel_decrypt";
            SIFRE_COZ.Text = "Rijandel şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            label1.Visible = false;
            GENERATE_KEY.Visible = false;
            ANAHTAR.Visible = false;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void S_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "sezar_decrypt";
            SIFRE_COZ.Text = "Sezar şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            ANAHTAR.Visible = true;
            label1.Visible = true;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void VG_C_Click(object sender, EventArgs e)
        {
            SIFRE_COZ.Name = "VG_decrypt";
            SIFRE_COZ.Text = "VG şifre çöz";
            label2.Text = "Şifrelenmiş metin";
            label3.Text = "Çözülmüş metin";
            ANAHTAR.Visible = true;
            label1.Visible = true;
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = true;

        }

        private void GENERATE_KEY_Click(object sender, EventArgs e)
        {
            All.RSA_MakeKey();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }

        }

        private void METIN_SIFRELEME_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        private void HAKKINDA_Click(object sender, EventArgs e)
        {
            hakkind();
        }
        public void form()
        {
            Form2 hakkinda = new Form2();
            Form1 form1 = new Form1();
            this.Hide();
            hakkinda.Show();
            hakkinda.Closed += (s, Args) => form1.Show();
            form1.Closed += (s, Args) => this.Close();
           
        }
        public void hakkind()
        {
            SIFRELE.Visible = false;
            SIFRE_COZ.Visible = false;
            SIFRELENECEK_METIN.Visible = false;
            SIFRELENMIS_METIN.Visible = false;
            label1.Visible= false;
            label2.Visible= false;
            label3.Visible= false;
            ANAHTAR.Visible = false;
            GENERATE_KEY.Visible = false;
            clear.Visible=false;
            mustafa.Visible = true;
            ali.Visible = true;
            emre.Visible = true;
            mustafa.Text = "Mustafa Erdoğan";
            ali.Text = "Ali Naki Kıral";
            emre.Text = "Emre Vural";
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIFRELE.Visible = true;
            SIFRE_COZ.Visible = true;
            SIFRELENECEK_METIN.Visible = true;
            SIFRELENMIS_METIN.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            ANAHTAR.Visible = true;
            GENERATE_KEY.Visible = true;
            clear.Visible = true;
            mustafa.Visible = false;
            ali.Visible = false;
            emre.Visible = false;
            button1.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }

        private void DOSYA_SIFRELEME_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }
    }
}
