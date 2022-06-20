namespace BITIRME_PROJESI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mustafa = new System.Windows.Forms.Label();
            this.ali = new System.Windows.Forms.Label();
            this.emre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mustafa
            // 
            this.mustafa.AutoSize = true;
            this.mustafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mustafa.Location = new System.Drawing.Point(232, 95);
            this.mustafa.Name = "mustafa";
            this.mustafa.Size = new System.Drawing.Size(280, 39);
            this.mustafa.TabIndex = 0;
            this.mustafa.Text = "Mustafa Erdoğan";
            this.mustafa.Click += new System.EventHandler(this.label1_Click);
            // 
            // ali
            // 
            this.ali.AutoSize = true;
            this.ali.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ali.Location = new System.Drawing.Point(254, 184);
            this.ali.Name = "ali";
            this.ali.Size = new System.Drawing.Size(214, 39);
            this.ali.TabIndex = 1;
            this.ali.Text = "Ali Naki Kıral";
            this.ali.Click += new System.EventHandler(this.label2_Click);
            // 
            // emre
            // 
            this.emre.AutoSize = true;
            this.emre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emre.Location = new System.Drawing.Point(254, 275);
            this.emre.Name = "emre";
            this.emre.Size = new System.Drawing.Size(191, 39);
            this.emre.TabIndex = 2;
            this.emre.Text = "Emre Vural";
            this.emre.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emre);
            this.Controls.Add(this.ali);
            this.Controls.Add(this.mustafa);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label mustafa;
        public System.Windows.Forms.Label ali;
        public System.Windows.Forms.Label emre;
    }
}