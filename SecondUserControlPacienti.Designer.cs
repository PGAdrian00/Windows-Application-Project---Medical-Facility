
namespace ProiectPAW
{
    partial class SecondUserControlPacienti
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondUserControlPacienti));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_info_pacienti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_pacienti = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label_pacienti);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_info_pacienti);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(44, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 337);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_info_pacienti
            // 
            this.btn_info_pacienti.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_info_pacienti.FlatAppearance.BorderSize = 0;
            this.btn_info_pacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info_pacienti.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info_pacienti.ForeColor = System.Drawing.Color.White;
            this.btn_info_pacienti.Location = new System.Drawing.Point(284, 296);
            this.btn_info_pacienti.Name = "btn_info_pacienti";
            this.btn_info_pacienti.Size = new System.Drawing.Size(191, 38);
            this.btn_info_pacienti.TabIndex = 3;
            this.btn_info_pacienti.Text = "Informatii pacienti(confidential)";
            this.btn_info_pacienti.UseVisualStyleBackColor = false;
            this.btn_info_pacienti.Click += new System.EventHandler(this.btn_info_pacienti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pagina aceasta este exclusiv pentru personalul desemnat.\r\n Informatiile acestea s" +
    "unt foarte importante pentru noi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_pacienti
            // 
            this.label_pacienti.AutoSize = true;
            this.label_pacienti.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pacienti.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_pacienti.Location = new System.Drawing.Point(299, 0);
            this.label_pacienti.Name = "label_pacienti";
            this.label_pacienti.Size = new System.Drawing.Size(176, 47);
            this.label_pacienti.TabIndex = 5;
            this.label_pacienti.Text = "Pacienti";
            // 
            // SecondUserControlPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "SecondUserControlPacienti";
            this.Size = new System.Drawing.Size(817, 423);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_info_pacienti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_pacienti;
    }
}
