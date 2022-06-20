namespace BITIRME_PROJESI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.DOSYA_SIFRELEME = new System.Windows.Forms.ToolStripMenuItem();
            this.ALGORITMALAR = new System.Windows.Forms.ToolStripMenuItem();
            this.TDES = new System.Windows.Forms.ToolStripMenuItem();
            this.DES = new System.Windows.Forms.ToolStripMenuItem();
            this.RC2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RSA = new System.Windows.Forms.ToolStripMenuItem();
            this.AES = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TDES_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.DES_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.RC2_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.RSA_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.AES_DC = new System.Windows.Forms.ToolStripMenuItem();
            this.METIN_SIFRELEME = new System.Windows.Forms.ToolStripMenuItem();
            this.ALGORITMALAR_ = new System.Windows.Forms.ToolStripMenuItem();
            this.TDES_ = new System.Windows.Forms.ToolStripMenuItem();
            this.DES_ = new System.Windows.Forms.ToolStripMenuItem();
            this.RC2_ = new System.Windows.Forms.ToolStripMenuItem();
            this.RSA_ = new System.Windows.Forms.ToolStripMenuItem();
            this.AES_ = new System.Windows.Forms.ToolStripMenuItem();
            this.HASH = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA256 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA384 = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA512 = new System.Windows.Forms.ToolStripMenuItem();
            this.BASIT_ = new System.Windows.Forms.ToolStripMenuItem();
            this.RIJENDAEL_ = new System.Windows.Forms.ToolStripMenuItem();
            this.SEZAR_ = new System.Windows.Forms.ToolStripMenuItem();
            this.ANAHTAR_SOZCUK_V_ = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.TDES_C = new System.Windows.Forms.ToolStripMenuItem();
            this.DES_C = new System.Windows.Forms.ToolStripMenuItem();
            this.RC2_C = new System.Windows.Forms.ToolStripMenuItem();
            this.RSA_C = new System.Windows.Forms.ToolStripMenuItem();
            this.AES_C = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.RJ_C = new System.Windows.Forms.ToolStripMenuItem();
            this.S_C = new System.Windows.Forms.ToolStripMenuItem();
            this.VG_C = new System.Windows.Forms.ToolStripMenuItem();
            this.HAKKINDA = new System.Windows.Forms.ToolStripMenuItem();
            this.GOZAT = new System.Windows.Forms.SaveFileDialog();
            this.SIFRELE = new System.Windows.Forms.Button();
            this.SIFRE_COZ = new System.Windows.Forms.Button();
            this.GENERATE_KEY = new System.Windows.Forms.Button();
            this.SIFRELENECEK_METIN = new System.Windows.Forms.TextBox();
            this.SIFRELENMIS_METIN = new System.Windows.Forms.TextBox();
            this.ANAHTAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.emre = new System.Windows.Forms.Label();
            this.ali = new System.Windows.Forms.Label();
            this.mustafa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DOSYA_SIFRELEME,
            this.toolStripMenuItem1,
            this.METIN_SIFRELEME,
            this.toolStripMenuItem8,
            this.HAKKINDA});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MENU.Size = new System.Drawing.Size(929, 24);
            this.MENU.TabIndex = 0;
            this.MENU.Text = "MENÜ";
            // 
            // DOSYA_SIFRELEME
            // 
            this.DOSYA_SIFRELEME.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ALGORITMALAR});
            this.DOSYA_SIFRELEME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DOSYA_SIFRELEME.Name = "DOSYA_SIFRELEME";
            this.DOSYA_SIFRELEME.Size = new System.Drawing.Size(134, 20);
            this.DOSYA_SIFRELEME.Text = "DOSYA ŞİFRELEME";
            this.DOSYA_SIFRELEME.Click += new System.EventHandler(this.DOSYA_SIFRELEME_Click);
            // 
            // ALGORITMALAR
            // 
            this.ALGORITMALAR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDES,
            this.DES,
            this.RC2,
            this.RSA,
            this.AES});
            this.ALGORITMALAR.Name = "ALGORITMALAR";
            this.ALGORITMALAR.Size = new System.Drawing.Size(180, 22);
            this.ALGORITMALAR.Text = "ALGORİTMALAR";
            // 
            // TDES
            // 
            this.TDES.Name = "TDES";
            this.TDES.Size = new System.Drawing.Size(180, 22);
            this.TDES.Text = "TDES";
            this.TDES.Click += new System.EventHandler(this.TDES_Click);
            // 
            // DES
            // 
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(180, 22);
            this.DES.Text = "DES";
            this.DES.Click += new System.EventHandler(this.DES_Click);
            // 
            // RC2
            // 
            this.RC2.Name = "RC2";
            this.RC2.Size = new System.Drawing.Size(180, 22);
            this.RC2.Text = "RC2";
            this.RC2.Click += new System.EventHandler(this.RC2_Click);
            // 
            // RSA
            // 
            this.RSA.Name = "RSA";
            this.RSA.Size = new System.Drawing.Size(180, 22);
            this.RSA.Text = "RSA";
            this.RSA.Click += new System.EventHandler(this.RSA_Click);
            // 
            // AES
            // 
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(180, 22);
            this.AES.Text = "AES";
            this.AES.Click += new System.EventHandler(this.AES_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 20);
            this.toolStripMenuItem1.Text = "DOSYA ŞİFRE ÇÖZME";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDES_DC,
            this.DES_DC,
            this.RC2_DC,
            this.RSA_DC,
            this.AES_DC});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "ALGORİTMALAR";
            // 
            // TDES_DC
            // 
            this.TDES_DC.Name = "TDES_DC";
            this.TDES_DC.Size = new System.Drawing.Size(180, 22);
            this.TDES_DC.Text = "TDES";
            this.TDES_DC.Click += new System.EventHandler(this.TDES_DC_Click);
            // 
            // DES_DC
            // 
            this.DES_DC.Name = "DES_DC";
            this.DES_DC.Size = new System.Drawing.Size(180, 22);
            this.DES_DC.Text = "DES";
            this.DES_DC.Click += new System.EventHandler(this.DES_DC_Click);
            // 
            // RC2_DC
            // 
            this.RC2_DC.Name = "RC2_DC";
            this.RC2_DC.Size = new System.Drawing.Size(180, 22);
            this.RC2_DC.Text = "RC2";
            this.RC2_DC.Click += new System.EventHandler(this.RC2_DC_Click);
            // 
            // RSA_DC
            // 
            this.RSA_DC.Name = "RSA_DC";
            this.RSA_DC.Size = new System.Drawing.Size(180, 22);
            this.RSA_DC.Text = "RSA";
            this.RSA_DC.Click += new System.EventHandler(this.RSA_DC_Click);
            // 
            // AES_DC
            // 
            this.AES_DC.Name = "AES_DC";
            this.AES_DC.Size = new System.Drawing.Size(180, 22);
            this.AES_DC.Text = "AES";
            this.AES_DC.Click += new System.EventHandler(this.AES_DC_Click);
            // 
            // METIN_SIFRELEME
            // 
            this.METIN_SIFRELEME.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ALGORITMALAR_,
            this.HASH,
            this.BASIT_});
            this.METIN_SIFRELEME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.METIN_SIFRELEME.Name = "METIN_SIFRELEME";
            this.METIN_SIFRELEME.Size = new System.Drawing.Size(131, 20);
            this.METIN_SIFRELEME.Text = "METİN ŞİFRELEME";
            this.METIN_SIFRELEME.Click += new System.EventHandler(this.METIN_SIFRELEME_Click);
            // 
            // ALGORITMALAR_
            // 
            this.ALGORITMALAR_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDES_,
            this.DES_,
            this.RC2_,
            this.RSA_,
            this.AES_});
            this.ALGORITMALAR_.Name = "ALGORITMALAR_";
            this.ALGORITMALAR_.Size = new System.Drawing.Size(180, 22);
            this.ALGORITMALAR_.Text = "ALGORİTMALAR";
            // 
            // TDES_
            // 
            this.TDES_.Name = "TDES_";
            this.TDES_.Size = new System.Drawing.Size(107, 22);
            this.TDES_.Text = "TDES";
            this.TDES_.Click += new System.EventHandler(this.TDES__Click);
            // 
            // DES_
            // 
            this.DES_.Name = "DES_";
            this.DES_.Size = new System.Drawing.Size(107, 22);
            this.DES_.Text = "DES";
            this.DES_.Click += new System.EventHandler(this.DES__Click);
            // 
            // RC2_
            // 
            this.RC2_.Name = "RC2_";
            this.RC2_.Size = new System.Drawing.Size(107, 22);
            this.RC2_.Text = "RC2";
            this.RC2_.Click += new System.EventHandler(this.RC2__Click);
            // 
            // RSA_
            // 
            this.RSA_.Name = "RSA_";
            this.RSA_.Size = new System.Drawing.Size(107, 22);
            this.RSA_.Text = "RSA";
            this.RSA_.Click += new System.EventHandler(this.RSA__Click);
            // 
            // AES_
            // 
            this.AES_.Name = "AES_";
            this.AES_.Size = new System.Drawing.Size(107, 22);
            this.AES_.Text = "AES";
            this.AES_.Click += new System.EventHandler(this.AES__Click);
            // 
            // HASH
            // 
            this.HASH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MD5,
            this.SHA1,
            this.SHA256,
            this.SHA384,
            this.SHA512});
            this.HASH.Name = "HASH";
            this.HASH.Size = new System.Drawing.Size(180, 22);
            this.HASH.Text = "HASH";
            // 
            // MD5
            // 
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(120, 22);
            this.MD5.Text = "MD5";
            this.MD5.Click += new System.EventHandler(this.MD5_Click);
            // 
            // SHA1
            // 
            this.SHA1.Name = "SHA1";
            this.SHA1.Size = new System.Drawing.Size(120, 22);
            this.SHA1.Text = "SHA1";
            this.SHA1.Click += new System.EventHandler(this.SHA1_Click);
            // 
            // SHA256
            // 
            this.SHA256.Name = "SHA256";
            this.SHA256.Size = new System.Drawing.Size(120, 22);
            this.SHA256.Text = "SHA256";
            this.SHA256.Click += new System.EventHandler(this.SHA256_Click);
            // 
            // SHA384
            // 
            this.SHA384.Name = "SHA384";
            this.SHA384.Size = new System.Drawing.Size(120, 22);
            this.SHA384.Text = "SHA384";
            this.SHA384.Click += new System.EventHandler(this.SHA384_Click);
            // 
            // SHA512
            // 
            this.SHA512.Name = "SHA512";
            this.SHA512.Size = new System.Drawing.Size(120, 22);
            this.SHA512.Text = "SHA512";
            this.SHA512.Click += new System.EventHandler(this.SHA512_Click);
            // 
            // BASIT_
            // 
            this.BASIT_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RIJENDAEL_,
            this.SEZAR_,
            this.ANAHTAR_SOZCUK_V_});
            this.BASIT_.Name = "BASIT_";
            this.BASIT_.Size = new System.Drawing.Size(180, 22);
            this.BASIT_.Text = "BASİT";
            // 
            // RIJENDAEL_
            // 
            this.RIJENDAEL_.Name = "RIJENDAEL_";
            this.RIJENDAEL_.Size = new System.Drawing.Size(258, 22);
            this.RIJENDAEL_.Text = "RİJENDAEL";
            this.RIJENDAEL_.Click += new System.EventHandler(this.RIJENDAEL__Click);
            // 
            // SEZAR_
            // 
            this.SEZAR_.Name = "SEZAR_";
            this.SEZAR_.Size = new System.Drawing.Size(258, 22);
            this.SEZAR_.Text = "SEZAR";
            this.SEZAR_.Click += new System.EventHandler(this.SEZAR__Click);
            // 
            // ANAHTAR_SOZCUK_V_
            // 
            this.ANAHTAR_SOZCUK_V_.Name = "ANAHTAR_SOZCUK_V_";
            this.ANAHTAR_SOZCUK_V_.Size = new System.Drawing.Size(258, 22);
            this.ANAHTAR_SOZCUK_V_.Text = "ANAHTAR SÖZCÜK(VİGENERE)";
            this.ANAHTAR_SOZCUK_V_.Click += new System.EventHandler(this.ANAHTAR_SOZCUK_V__Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem21});
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(145, 20);
            this.toolStripMenuItem8.Text = "METİN ŞİFRE ÇÖZME";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDES_C,
            this.DES_C,
            this.RC2_C,
            this.RSA_C,
            this.AES_C});
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "ALGORİTMALAR";
            // 
            // TDES_C
            // 
            this.TDES_C.Name = "TDES_C";
            this.TDES_C.Size = new System.Drawing.Size(180, 22);
            this.TDES_C.Text = "TDES";
            this.TDES_C.Click += new System.EventHandler(this.TDES_C_Click);
            // 
            // DES_C
            // 
            this.DES_C.Name = "DES_C";
            this.DES_C.Size = new System.Drawing.Size(180, 22);
            this.DES_C.Text = "DES";
            this.DES_C.Click += new System.EventHandler(this.DES_C_Click);
            // 
            // RC2_C
            // 
            this.RC2_C.Name = "RC2_C";
            this.RC2_C.Size = new System.Drawing.Size(180, 22);
            this.RC2_C.Text = "RC2";
            this.RC2_C.Click += new System.EventHandler(this.RC2_C_Click);
            // 
            // RSA_C
            // 
            this.RSA_C.Name = "RSA_C";
            this.RSA_C.Size = new System.Drawing.Size(180, 22);
            this.RSA_C.Text = "RSA";
            this.RSA_C.Click += new System.EventHandler(this.RSA_C_Click);
            // 
            // AES_C
            // 
            this.AES_C.Name = "AES_C";
            this.AES_C.Size = new System.Drawing.Size(180, 22);
            this.AES_C.Text = "AES";
            this.AES_C.Click += new System.EventHandler(this.AES_C_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RJ_C,
            this.S_C,
            this.VG_C});
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem21.Text = "BASİT";
            // 
            // RJ_C
            // 
            this.RJ_C.Name = "RJ_C";
            this.RJ_C.Size = new System.Drawing.Size(258, 22);
            this.RJ_C.Text = "RİJENDAEL";
            this.RJ_C.Click += new System.EventHandler(this.RJ_C_Click);
            // 
            // S_C
            // 
            this.S_C.Name = "S_C";
            this.S_C.Size = new System.Drawing.Size(258, 22);
            this.S_C.Text = "SEZAR";
            this.S_C.Click += new System.EventHandler(this.S_C_Click);
            // 
            // VG_C
            // 
            this.VG_C.Name = "VG_C";
            this.VG_C.Size = new System.Drawing.Size(258, 22);
            this.VG_C.Text = "ANAHTAR SÖZCÜK(VİGENERE)";
            this.VG_C.Click += new System.EventHandler(this.VG_C_Click);
            // 
            // HAKKINDA
            // 
            this.HAKKINDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HAKKINDA.Name = "HAKKINDA";
            this.HAKKINDA.Size = new System.Drawing.Size(82, 20);
            this.HAKKINDA.Text = "HAKKINDA";
            this.HAKKINDA.Click += new System.EventHandler(this.HAKKINDA_Click);
            // 
            // SIFRELE
            // 
            this.SIFRELE.BackColor = System.Drawing.Color.Cyan;
            this.SIFRELE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SIFRELE.Location = new System.Drawing.Point(133, 80);
            this.SIFRELE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SIFRELE.Name = "SIFRELE";
            this.SIFRELE.Size = new System.Drawing.Size(98, 42);
            this.SIFRELE.TabIndex = 1;
            this.SIFRELE.Text = "button1";
            this.SIFRELE.UseVisualStyleBackColor = false;
            this.SIFRELE.Click += new System.EventHandler(this.SIFRELE_Click);
            // 
            // SIFRE_COZ
            // 
            this.SIFRE_COZ.BackColor = System.Drawing.Color.Cyan;
            this.SIFRE_COZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SIFRE_COZ.Location = new System.Drawing.Point(366, 80);
            this.SIFRE_COZ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SIFRE_COZ.Name = "SIFRE_COZ";
            this.SIFRE_COZ.Size = new System.Drawing.Size(98, 42);
            this.SIFRE_COZ.TabIndex = 2;
            this.SIFRE_COZ.Text = "button2";
            this.SIFRE_COZ.UseVisualStyleBackColor = false;
            this.SIFRE_COZ.Click += new System.EventHandler(this.SIFRE_COZ_Click);
            // 
            // GENERATE_KEY
            // 
            this.GENERATE_KEY.BackColor = System.Drawing.Color.Cyan;
            this.GENERATE_KEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GENERATE_KEY.Location = new System.Drawing.Point(628, 80);
            this.GENERATE_KEY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GENERATE_KEY.Name = "GENERATE_KEY";
            this.GENERATE_KEY.Size = new System.Drawing.Size(98, 42);
            this.GENERATE_KEY.TabIndex = 3;
            this.GENERATE_KEY.Text = "RSA key oluştur";
            this.GENERATE_KEY.UseVisualStyleBackColor = false;
            this.GENERATE_KEY.Click += new System.EventHandler(this.GENERATE_KEY_Click);
            // 
            // SIFRELENECEK_METIN
            // 
            this.SIFRELENECEK_METIN.Location = new System.Drawing.Point(174, 234);
            this.SIFRELENECEK_METIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SIFRELENECEK_METIN.Name = "SIFRELENECEK_METIN";
            this.SIFRELENECEK_METIN.Size = new System.Drawing.Size(709, 20);
            this.SIFRELENECEK_METIN.TabIndex = 4;
            // 
            // SIFRELENMIS_METIN
            // 
            this.SIFRELENMIS_METIN.Location = new System.Drawing.Point(174, 269);
            this.SIFRELENMIS_METIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SIFRELENMIS_METIN.Multiline = true;
            this.SIFRELENMIS_METIN.Name = "SIFRELENMIS_METIN";
            this.SIFRELENMIS_METIN.Size = new System.Drawing.Size(709, 66);
            this.SIFRELENMIS_METIN.TabIndex = 5;
            // 
            // ANAHTAR
            // 
            this.ANAHTAR.Location = new System.Drawing.Point(174, 194);
            this.ANAHTAR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ANAHTAR.Name = "ANAHTAR";
            this.ANAHTAR.Size = new System.Drawing.Size(709, 20);
            this.ANAHTAR.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Anahtar:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifrelenecek metin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şİfrelenmiş metin:";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear.Location = new System.Drawing.Point(764, 364);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(119, 46);
            this.clear.TabIndex = 10;
            this.clear.Text = "Tümünü Temizle";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // emre
            // 
            this.emre.AutoSize = true;
            this.emre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emre.Location = new System.Drawing.Point(329, 296);
            this.emre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emre.Name = "emre";
            this.emre.Size = new System.Drawing.Size(0, 39);
            this.emre.TabIndex = 13;
            // 
            // ali
            // 
            this.ali.AutoSize = true;
            this.ali.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ali.Location = new System.Drawing.Point(329, 205);
            this.ali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ali.Name = "ali";
            this.ali.Size = new System.Drawing.Size(0, 39);
            this.ali.TabIndex = 12;
            // 
            // mustafa
            // 
            this.mustafa.AutoSize = true;
            this.mustafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mustafa.Location = new System.Drawing.Point(303, 116);
            this.mustafa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mustafa.Name = "mustafa";
            this.mustafa.Size = new System.Drawing.Size(0, 39);
            this.mustafa.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emre);
            this.Controls.Add(this.ali);
            this.Controls.Add(this.mustafa);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ANAHTAR);
            this.Controls.Add(this.SIFRELENMIS_METIN);
            this.Controls.Add(this.SIFRELENECEK_METIN);
            this.Controls.Add(this.GENERATE_KEY);
            this.Controls.Add(this.SIFRE_COZ);
            this.Controls.Add(this.SIFRELE);
            this.Controls.Add(this.MENU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.MENU;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem DOSYA_SIFRELEME;
        private System.Windows.Forms.ToolStripMenuItem ALGORITMALAR;
        private System.Windows.Forms.ToolStripMenuItem TDES;
        private System.Windows.Forms.ToolStripMenuItem DES;
        private System.Windows.Forms.ToolStripMenuItem RC2;
        private System.Windows.Forms.ToolStripMenuItem RSA;
        private System.Windows.Forms.ToolStripMenuItem AES;
        private System.Windows.Forms.ToolStripMenuItem METIN_SIFRELEME;
        private System.Windows.Forms.ToolStripMenuItem ALGORITMALAR_;
        private System.Windows.Forms.ToolStripMenuItem TDES_;
        private System.Windows.Forms.ToolStripMenuItem DES_;
        private System.Windows.Forms.ToolStripMenuItem RC2_;
        private System.Windows.Forms.ToolStripMenuItem RSA_;
        private System.Windows.Forms.ToolStripMenuItem AES_;
        private System.Windows.Forms.ToolStripMenuItem HASH;
        private System.Windows.Forms.ToolStripMenuItem MD5;
        private System.Windows.Forms.ToolStripMenuItem SHA1;
        private System.Windows.Forms.ToolStripMenuItem SHA256;
        private System.Windows.Forms.ToolStripMenuItem SHA384;
        private System.Windows.Forms.ToolStripMenuItem SHA512;
        private System.Windows.Forms.ToolStripMenuItem BASIT_;
        private System.Windows.Forms.ToolStripMenuItem RIJENDAEL_;
        private System.Windows.Forms.ToolStripMenuItem SEZAR_;
        private System.Windows.Forms.ToolStripMenuItem ANAHTAR_SOZCUK_V_;
        private System.Windows.Forms.ToolStripMenuItem HAKKINDA;
        private System.Windows.Forms.SaveFileDialog GOZAT;
        private System.Windows.Forms.Button SIFRELE;
        private System.Windows.Forms.Button SIFRE_COZ;
        private System.Windows.Forms.Button GENERATE_KEY;
        private System.Windows.Forms.TextBox SIFRELENECEK_METIN;
        private System.Windows.Forms.TextBox SIFRELENMIS_METIN;
        private System.Windows.Forms.TextBox ANAHTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TDES_DC;
        private System.Windows.Forms.ToolStripMenuItem DES_DC;
        private System.Windows.Forms.ToolStripMenuItem RC2_DC;
        private System.Windows.Forms.ToolStripMenuItem RSA_DC;
        private System.Windows.Forms.ToolStripMenuItem AES_DC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem TDES_C;
        private System.Windows.Forms.ToolStripMenuItem DES_C;
        private System.Windows.Forms.ToolStripMenuItem RC2_C;
        private System.Windows.Forms.ToolStripMenuItem RSA_C;
        private System.Windows.Forms.ToolStripMenuItem AES_C;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem RJ_C;
        private System.Windows.Forms.ToolStripMenuItem S_C;
        private System.Windows.Forms.ToolStripMenuItem VG_C;
        private System.Windows.Forms.Button clear;
        public System.Windows.Forms.Label emre;
        public System.Windows.Forms.Label ali;
        public System.Windows.Forms.Label mustafa;
        private System.Windows.Forms.Button button1;
    }
}

