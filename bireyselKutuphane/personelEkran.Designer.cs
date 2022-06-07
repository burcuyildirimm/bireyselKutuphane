
namespace bireyselKutuphane
{
    partial class personelEkran
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelEkran));
            this.emanetIslemleriCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kitapBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.PapayaWhip;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.Color.DimGray;
            label1.Location = new System.Drawing.Point(176, 432);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(286, 25);
            label1.TabIndex = 2;
            label1.Text = "Kulllanıcı İşlemleri İçin Tıklayınız";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.PapayaWhip;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.ForeColor = System.Drawing.Color.DimGray;
            label2.Location = new System.Drawing.Point(176, 194);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(254, 25);
            label2.TabIndex = 4;
            label2.Text = "Kitap İşlemleri İçin Tıklayınız";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.PapayaWhip;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label3.ForeColor = System.Drawing.Color.DimGray;
            label3.Location = new System.Drawing.Point(176, 311);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 25);
            label3.TabIndex = 6;
            label3.Text = "Emanet İşlemleri";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // emanetIslemleriCmb
            // 
            this.emanetIslemleriCmb.BackColor = System.Drawing.Color.PapayaWhip;
            this.emanetIslemleriCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emanetIslemleriCmb.ForeColor = System.Drawing.Color.DimGray;
            this.emanetIslemleriCmb.FormattingEnabled = true;
            this.emanetIslemleriCmb.Items.AddRange(new object[] {
            "Emanet Kitap Alma",
            "Emanet Kitap Verme",
            "Emanet Kitap Listeleme"});
            this.emanetIslemleriCmb.Location = new System.Drawing.Point(528, 308);
            this.emanetIslemleriCmb.Name = "emanetIslemleriCmb";
            this.emanetIslemleriCmb.Size = new System.Drawing.Size(230, 28);
            this.emanetIslemleriCmb.TabIndex = 5;
            this.emanetIslemleriCmb.SelectedIndexChanged += new System.EventHandler(this.emanetIslemleriCmb_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1555, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1404, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(528, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kullanıcı İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapBtn
            // 
            this.kitapBtn.BackColor = System.Drawing.Color.PapayaWhip;
            this.kitapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapBtn.ForeColor = System.Drawing.Color.DimGray;
            this.kitapBtn.Location = new System.Drawing.Point(528, 194);
            this.kitapBtn.Name = "kitapBtn";
            this.kitapBtn.Size = new System.Drawing.Size(230, 46);
            this.kitapBtn.TabIndex = 9;
            this.kitapBtn.Text = "Kitap İşlemleri";
            this.kitapBtn.UseVisualStyleBackColor = false;
            this.kitapBtn.Click += new System.EventHandler(this.kitapBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1416, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 52);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // personelEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 753);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kitapBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label3);
            this.Controls.Add(this.emanetIslemleriCmb);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "personelEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personelEkran";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox emanetIslemleriCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kitapBtn;
        private System.Windows.Forms.Button button2;
    }
}