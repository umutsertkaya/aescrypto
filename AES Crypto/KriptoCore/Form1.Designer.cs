namespace KriptoCore
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
            this.panel = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Label();
            this.mtngrtxt = new System.Windows.Forms.Label();
            this.mtngir = new System.Windows.Forms.TextBox();
            this.sifrele = new System.Windows.Forms.PictureBox();
            this.sifmtntxt = new System.Windows.Forms.Label();
            this.sifmtn = new System.Windows.Forms.TextBox();
            this.txtmtngir = new System.Windows.Forms.RichTextBox();
            this.txtmtngirtext = new System.Windows.Forms.Label();
            this.txtsifmtn = new System.Windows.Forms.RichTextBox();
            this.txtsifmtntext = new System.Windows.Forms.Label();
            this.txtsifrele = new System.Windows.Forms.PictureBox();
            this.cöz = new System.Windows.Forms.PictureBox();
            this.txtcöz = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.ara = new System.Windows.Forms.OpenFileDialog();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifrele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cöz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcöz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kapat);
            this.panel.Location = new System.Drawing.Point(1, 1);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(867, 34);
            this.panel.TabIndex = 0;
            // 
            // kapat
            // 
            this.kapat.AutoSize = true;
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.Color.White;
            this.kapat.Location = new System.Drawing.Point(835, 5);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(21, 20);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "X";
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // mtngrtxt
            // 
            this.mtngrtxt.AutoSize = true;
            this.mtngrtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtngrtxt.ForeColor = System.Drawing.Color.White;
            this.mtngrtxt.Location = new System.Drawing.Point(-3, 60);
            this.mtngrtxt.Name = "mtngrtxt";
            this.mtngrtxt.Size = new System.Drawing.Size(114, 20);
            this.mtngrtxt.TabIndex = 1;
            this.mtngrtxt.Text = "Metni Giriniz:";
            // 
            // mtngir
            // 
            this.mtngir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtngir.Location = new System.Drawing.Point(118, 59);
            this.mtngir.Name = "mtngir";
            this.mtngir.Size = new System.Drawing.Size(677, 26);
            this.mtngir.TabIndex = 2;
            // 
            // sifrele
            // 
            this.sifrele.Image = ((System.Drawing.Image)(resources.GetObject("sifrele.Image")));
            this.sifrele.Location = new System.Drawing.Point(801, 41);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(58, 54);
            this.sifrele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sifrele.TabIndex = 3;
            this.sifrele.TabStop = false;
            this.sifrele.Click += new System.EventHandler(this.sifrele_Click);
            // 
            // sifmtntxt
            // 
            this.sifmtntxt.AutoSize = true;
            this.sifmtntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifmtntxt.ForeColor = System.Drawing.Color.White;
            this.sifmtntxt.Location = new System.Drawing.Point(-3, 124);
            this.sifmtntxt.Name = "sifmtntxt";
            this.sifmtntxt.Size = new System.Drawing.Size(109, 20);
            this.sifmtntxt.TabIndex = 4;
            this.sifmtntxt.Text = "Şifreli Metin:";
            // 
            // sifmtn
            // 
            this.sifmtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifmtn.Location = new System.Drawing.Point(112, 121);
            this.sifmtn.Name = "sifmtn";
            this.sifmtn.Size = new System.Drawing.Size(677, 26);
            this.sifmtn.TabIndex = 5;
            // 
            // txtmtngir
            // 
            this.txtmtngir.Location = new System.Drawing.Point(1, 269);
            this.txtmtngir.Name = "txtmtngir";
            this.txtmtngir.Size = new System.Drawing.Size(287, 232);
            this.txtmtngir.TabIndex = 7;
            this.txtmtngir.Text = "";
            // 
            // txtmtngirtext
            // 
            this.txtmtngirtext.AutoSize = true;
            this.txtmtngirtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmtngirtext.ForeColor = System.Drawing.Color.White;
            this.txtmtngirtext.Location = new System.Drawing.Point(-3, 246);
            this.txtmtngirtext.Name = "txtmtngirtext";
            this.txtmtngirtext.Size = new System.Drawing.Size(114, 20);
            this.txtmtngirtext.TabIndex = 8;
            this.txtmtngirtext.Text = "Metni Giriniz:";
            // 
            // txtsifmtn
            // 
            this.txtsifmtn.Location = new System.Drawing.Point(581, 269);
            this.txtsifmtn.Name = "txtsifmtn";
            this.txtsifmtn.Size = new System.Drawing.Size(287, 232);
            this.txtsifmtn.TabIndex = 9;
            this.txtsifmtn.Text = "";
            // 
            // txtsifmtntext
            // 
            this.txtsifmtntext.AutoSize = true;
            this.txtsifmtntext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifmtntext.ForeColor = System.Drawing.Color.White;
            this.txtsifmtntext.Location = new System.Drawing.Point(759, 246);
            this.txtsifmtntext.Name = "txtsifmtntext";
            this.txtsifmtntext.Size = new System.Drawing.Size(109, 20);
            this.txtsifmtntext.TabIndex = 10;
            this.txtsifmtntext.Text = "Şifreli Metin:";
            // 
            // txtsifrele
            // 
            this.txtsifrele.Image = ((System.Drawing.Image)(resources.GetObject("txtsifrele.Image")));
            this.txtsifrele.Location = new System.Drawing.Point(408, 434);
            this.txtsifrele.Name = "txtsifrele";
            this.txtsifrele.Size = new System.Drawing.Size(58, 54);
            this.txtsifrele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtsifrele.TabIndex = 11;
            this.txtsifrele.TabStop = false;
            this.txtsifrele.Click += new System.EventHandler(this.txtsifrele_Click);
            // 
            // cöz
            // 
            this.cöz.Image = ((System.Drawing.Image)(resources.GetObject("cöz.Image")));
            this.cöz.Location = new System.Drawing.Point(799, 101);
            this.cöz.Name = "cöz";
            this.cöz.Size = new System.Drawing.Size(58, 54);
            this.cöz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cöz.TabIndex = 6;
            this.cöz.TabStop = false;
            this.cöz.Click += new System.EventHandler(this.cöz_Click);
            // 
            // txtcöz
            // 
            this.txtcöz.Image = ((System.Drawing.Image)(resources.GetObject("txtcöz.Image")));
            this.txtcöz.Location = new System.Drawing.Point(408, 350);
            this.txtcöz.Name = "txtcöz";
            this.txtcöz.Size = new System.Drawing.Size(58, 54);
            this.txtcöz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtcöz.TabIndex = 12;
            this.txtcöz.TabStop = false;
            this.txtcöz.Click += new System.EventHandler(this.txtcöz_Click);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(408, 269);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(58, 54);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.search.TabIndex = 13;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ara
            // 
            this.ara.Filter = "TEXT|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(869, 500);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txtcöz);
            this.Controls.Add(this.txtsifrele);
            this.Controls.Add(this.txtsifmtntext);
            this.Controls.Add(this.txtsifmtn);
            this.Controls.Add(this.txtmtngirtext);
            this.Controls.Add(this.txtmtngir);
            this.Controls.Add(this.cöz);
            this.Controls.Add(this.sifmtn);
            this.Controls.Add(this.sifmtntxt);
            this.Controls.Add(this.sifrele);
            this.Controls.Add(this.mtngir);
            this.Controls.Add(this.mtngrtxt);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sifrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifrele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cöz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcöz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label kapat;
        private System.Windows.Forms.Label mtngrtxt;
        private System.Windows.Forms.TextBox mtngir;
        private System.Windows.Forms.PictureBox sifrele;
        private System.Windows.Forms.Label sifmtntxt;
        private System.Windows.Forms.TextBox sifmtn;
        private System.Windows.Forms.RichTextBox txtmtngir;
        private System.Windows.Forms.Label txtmtngirtext;
        private System.Windows.Forms.RichTextBox txtsifmtn;
        private System.Windows.Forms.Label txtsifmtntext;
        private System.Windows.Forms.PictureBox txtsifrele;
        private System.Windows.Forms.PictureBox cöz;
        private System.Windows.Forms.PictureBox txtcöz;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.OpenFileDialog ara;
    }
}

