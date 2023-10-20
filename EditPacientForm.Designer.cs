
namespace ProiectPAW
{
    partial class EditPacientForm
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
            this.btnSalvare_Pacient = new System.Windows.Forms.Button();
            this.txtBox_telefon_Pacient = new System.Windows.Forms.TextBox();
            this.txtBox_prenumePacient = new System.Windows.Forms.TextBox();
            this.txtBox_numePacient = new System.Windows.Forms.TextBox();
            this.label_adresaMail = new System.Windows.Forms.Label();
            this.label_prenumePacient = new System.Windows.Forms.Label();
            this.label_numePacient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvare_Pacient
            // 
            this.btnSalvare_Pacient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalvare_Pacient.FlatAppearance.BorderSize = 0;
            this.btnSalvare_Pacient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare_Pacient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare_Pacient.ForeColor = System.Drawing.Color.White;
            this.btnSalvare_Pacient.Location = new System.Drawing.Point(390, 186);
            this.btnSalvare_Pacient.Name = "btnSalvare_Pacient";
            this.btnSalvare_Pacient.Size = new System.Drawing.Size(87, 22);
            this.btnSalvare_Pacient.TabIndex = 17;
            this.btnSalvare_Pacient.Text = "Salveaza";
            this.btnSalvare_Pacient.UseVisualStyleBackColor = false;
            this.btnSalvare_Pacient.Click += new System.EventHandler(this.btnSalvare_Pacient_Click);
            // 
            // txtBox_telefon_Pacient
            // 
            this.txtBox_telefon_Pacient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_telefon_Pacient.Location = new System.Drawing.Point(141, 117);
            this.txtBox_telefon_Pacient.Name = "txtBox_telefon_Pacient";
            this.txtBox_telefon_Pacient.Size = new System.Drawing.Size(148, 21);
            this.txtBox_telefon_Pacient.TabIndex = 15;
            // 
            // txtBox_prenumePacient
            // 
            this.txtBox_prenumePacient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_prenumePacient.Location = new System.Drawing.Point(141, 75);
            this.txtBox_prenumePacient.Name = "txtBox_prenumePacient";
            this.txtBox_prenumePacient.Size = new System.Drawing.Size(148, 21);
            this.txtBox_prenumePacient.TabIndex = 14;
            // 
            // txtBox_numePacient
            // 
            this.txtBox_numePacient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_numePacient.Location = new System.Drawing.Point(141, 27);
            this.txtBox_numePacient.Name = "txtBox_numePacient";
            this.txtBox_numePacient.Size = new System.Drawing.Size(148, 21);
            this.txtBox_numePacient.TabIndex = 13;
            // 
            // label_adresaMail
            // 
            this.label_adresaMail.AutoSize = true;
            this.label_adresaMail.Location = new System.Drawing.Point(25, 117);
            this.label_adresaMail.Name = "label_adresaMail";
            this.label_adresaMail.Size = new System.Drawing.Size(82, 13);
            this.label_adresaMail.TabIndex = 12;
            this.label_adresaMail.Text = "Telefon Pacient";
            // 
            // label_prenumePacient
            // 
            this.label_prenumePacient.AutoSize = true;
            this.label_prenumePacient.Location = new System.Drawing.Point(25, 75);
            this.label_prenumePacient.Name = "label_prenumePacient";
            this.label_prenumePacient.Size = new System.Drawing.Size(88, 13);
            this.label_prenumePacient.TabIndex = 10;
            this.label_prenumePacient.Text = "Prenume Pacient";
            // 
            // label_numePacient
            // 
            this.label_numePacient.AutoSize = true;
            this.label_numePacient.Location = new System.Drawing.Point(25, 31);
            this.label_numePacient.Name = "label_numePacient";
            this.label_numePacient.Size = new System.Drawing.Size(74, 13);
            this.label_numePacient.TabIndex = 9;
            this.label_numePacient.Text = "Nume Pacient";
            // 
            // EditPacientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 236);
            this.Controls.Add(this.btnSalvare_Pacient);
            this.Controls.Add(this.txtBox_telefon_Pacient);
            this.Controls.Add(this.txtBox_prenumePacient);
            this.Controls.Add(this.txtBox_numePacient);
            this.Controls.Add(this.label_adresaMail);
            this.Controls.Add(this.label_prenumePacient);
            this.Controls.Add(this.label_numePacient);
            this.Name = "EditPacientForm";
            this.Text = "EditPacientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvare_Pacient;
        private System.Windows.Forms.TextBox txtBox_telefon_Pacient;
        private System.Windows.Forms.TextBox txtBox_prenumePacient;
        private System.Windows.Forms.TextBox txtBox_numePacient;
        private System.Windows.Forms.Label label_adresaMail;
        private System.Windows.Forms.Label label_prenumePacient;
        private System.Windows.Forms.Label label_numePacient;
    }
}