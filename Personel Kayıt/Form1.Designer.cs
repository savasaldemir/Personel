namespace Personel_Kayıt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            btnKayitEkle = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            txtid = new TextBox();
            btnGuncelleUpdate = new Button();
            panel2 = new Panel();
            btnVeriListele = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Century", 12F, FontStyle.Bold);
            lblAd.Location = new Point(38, 19);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(35, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Century", 12F, FontStyle.Bold);
            lblSoyad.Location = new Point(14, 49);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(59, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.Silver;
            txtAd.Font = new Font("Century", 12F, FontStyle.Bold);
            txtAd.Location = new Point(105, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(156, 27);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.Silver;
            txtSoyad.Font = new Font("Century", 12F, FontStyle.Bold);
            txtSoyad.Location = new Point(105, 50);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(156, 27);
            txtSoyad.TabIndex = 3;
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKayitEkle.Location = new Point(267, 3);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(158, 57);
            btnKayitEkle.TabIndex = 4;
            btnKayitEkle.Text = "KAYIT EKLE INSERT";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(btnGuncelleUpdate);
            panel1.Controls.Add(btnKayitEkle);
            panel1.Controls.Add(lblAd);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(lblSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 130);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Century", 14.25F, FontStyle.Bold);
            button1.Location = new Point(431, 3);
            button1.Name = "button1";
            button1.Size = new Size(135, 116);
            button1.TabIndex = 8;
            button1.Text = "SİL DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 99);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 7;
            label1.Text = "İD";
            // 
            // txtid
            // 
            txtid.BackColor = Color.Silver;
            txtid.Font = new Font("Century", 12F, FontStyle.Bold);
            txtid.Location = new Point(161, 92);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 27);
            txtid.TabIndex = 7;
            // 
            // btnGuncelleUpdate
            // 
            btnGuncelleUpdate.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuncelleUpdate.Location = new Point(267, 66);
            btnGuncelleUpdate.Name = "btnGuncelleUpdate";
            btnGuncelleUpdate.Size = new Size(158, 53);
            btnGuncelleUpdate.TabIndex = 5;
            btnGuncelleUpdate.Text = "Güncelle UPDATE";
            btnGuncelleUpdate.UseVisualStyleBackColor = true;
            btnGuncelleUpdate.Click += btnGuncelleUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnVeriListele);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(1, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 155);
            panel2.TabIndex = 6;
            // 
            // btnVeriListele
            // 
            btnVeriListele.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeriListele.Location = new Point(3, 34);
            btnVeriListele.Name = "btnVeriListele";
            btnVeriListele.Size = new Size(125, 78);
            btnVeriListele.TabIndex = 7;
            btnVeriListele.Text = "Veri Listele (SELECT)";
            btnVeriListele.UseVisualStyleBackColor = true;
            btnVeriListele.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(436, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(572, 291);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Kayıt";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button btnKayitEkle;
        private Panel panel1;
        private Panel panel2;
        private Button btnVeriListele;
        private DataGridView dataGridView1;
        private Button btnGuncelleUpdate;
        private Label label1;
        private TextBox txtid;
        private Button button1;
    }
}
