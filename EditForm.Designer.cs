
namespace ProiectPAW
{
    partial class EditForm
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
            this.label_numeDoctor = new System.Windows.Forms.Label();
            this.label_prenumeDoctor = new System.Windows.Forms.Label();
            this.label_sectieDoctor = new System.Windows.Forms.Label();
            this.label_adresaMail = new System.Windows.Forms.Label();
            this.txtBox_numeDoctor = new System.Windows.Forms.TextBox();
            this.txtBox_prenumeDoctor = new System.Windows.Forms.TextBox();
            this.txtBox_adresaMail = new System.Windows.Forms.TextBox();
            this.comboBox_sectie = new System.Windows.Forms.ComboBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_numeDoctor
            // 
            this.label_numeDoctor.AutoSize = true;
            this.label_numeDoctor.Location = new System.Drawing.Point(7, 16);
            this.label_numeDoctor.Name = "label_numeDoctor";
            this.label_numeDoctor.Size = new System.Drawing.Size(70, 13);
            this.label_numeDoctor.TabIndex = 0;
            this.label_numeDoctor.Text = "Nume Doctor";
            // 
            // label_prenumeDoctor
            // 
            this.label_prenumeDoctor.AutoSize = true;
            this.label_prenumeDoctor.Location = new System.Drawing.Point(1, 60);
            this.label_prenumeDoctor.Name = "label_prenumeDoctor";
            this.label_prenumeDoctor.Size = new System.Drawing.Size(84, 13);
            this.label_prenumeDoctor.TabIndex = 1;
            this.label_prenumeDoctor.Text = "Prenume Doctor";
            // 
            // label_sectieDoctor
            // 
            this.label_sectieDoctor.AutoSize = true;
            this.label_sectieDoctor.Location = new System.Drawing.Point(7, 96);
            this.label_sectieDoctor.Name = "label_sectieDoctor";
            this.label_sectieDoctor.Size = new System.Drawing.Size(72, 13);
            this.label_sectieDoctor.TabIndex = 2;
            this.label_sectieDoctor.Text = "Sectie Doctor";
            // 
            // label_adresaMail
            // 
            this.label_adresaMail.AutoSize = true;
            this.label_adresaMail.Location = new System.Drawing.Point(12, 129);
            this.label_adresaMail.Name = "label_adresaMail";
            this.label_adresaMail.Size = new System.Drawing.Size(62, 13);
            this.label_adresaMail.TabIndex = 3;
            this.label_adresaMail.Text = "Adresa Mail";
            // 
            // txtBox_numeDoctor
            // 
            this.txtBox_numeDoctor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_numeDoctor.Location = new System.Drawing.Point(117, 12);
            this.txtBox_numeDoctor.Name = "txtBox_numeDoctor";
            this.txtBox_numeDoctor.Size = new System.Drawing.Size(148, 21);
            this.txtBox_numeDoctor.TabIndex = 4;
            // 
            // txtBox_prenumeDoctor
            // 
            this.txtBox_prenumeDoctor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prenumeDoctor.Location = new System.Drawing.Point(117, 60);
            this.txtBox_prenumeDoctor.Name = "txtBox_prenumeDoctor";
            this.txtBox_prenumeDoctor.Size = new System.Drawing.Size(148, 21);
            this.txtBox_prenumeDoctor.TabIndex = 5;
            // 
            // txtBox_adresaMail
            // 
            this.txtBox_adresaMail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_adresaMail.Location = new System.Drawing.Point(117, 129);
            this.txtBox_adresaMail.Name = "txtBox_adresaMail";
            this.txtBox_adresaMail.Size = new System.Drawing.Size(148, 21);
            this.txtBox_adresaMail.TabIndex = 6;
            // 
            // comboBox_sectie
            // 
            this.comboBox_sectie.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_sectie.FormattingEnabled = true;
            this.comboBox_sectie.Location = new System.Drawing.Point(120, 96);
            this.comboBox_sectie.Name = "comboBox_sectie";
            this.comboBox_sectie.Size = new System.Drawing.Size(143, 24);
            this.comboBox_sectie.TabIndex = 7;
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalvare.FlatAppearance.BorderSize = 0;
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.Color.White;
            this.btnSalvare.Location = new System.Drawing.Point(366, 171);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(87, 22);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 215);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.comboBox_sectie);
            this.Controls.Add(this.txtBox_adresaMail);
            this.Controls.Add(this.txtBox_prenumeDoctor);
            this.Controls.Add(this.txtBox_numeDoctor);
            this.Controls.Add(this.label_adresaMail);
            this.Controls.Add(this.label_sectieDoctor);
            this.Controls.Add(this.label_prenumeDoctor);
            this.Controls.Add(this.label_numeDoctor);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_numeDoctor;
        private System.Windows.Forms.Label label_prenumeDoctor;
        private System.Windows.Forms.Label label_sectieDoctor;
        private System.Windows.Forms.Label label_adresaMail;
        private System.Windows.Forms.TextBox txtBox_numeDoctor;
        private System.Windows.Forms.TextBox txtBox_prenumeDoctor;
        private System.Windows.Forms.TextBox txtBox_adresaMail;
        private System.Windows.Forms.ComboBox comboBox_sectie;
        private System.Windows.Forms.Button btnSalvare;
    }
}