
namespace ProiectPAW
{
    partial class ThirdUserControlDoctori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_doctori = new System.Windows.Forms.DataGridView();
            this.label_doctori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_doctori
            // 
            this.dgv_doctori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doctori.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_doctori.Location = new System.Drawing.Point(28, 76);
            this.dgv_doctori.Name = "dgv_doctori";
            this.dgv_doctori.Size = new System.Drawing.Size(791, 327);
            this.dgv_doctori.TabIndex = 1;
            // 
            // label_doctori
            // 
            this.label_doctori.AutoSize = true;
            this.label_doctori.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doctori.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label_doctori.Location = new System.Drawing.Point(264, 17);
            this.label_doctori.Name = "label_doctori";
            this.label_doctori.Size = new System.Drawing.Size(335, 47);
            this.label_doctori.TabIndex = 2;
            this.label_doctori.Text = "Doctorii Ai Grija";
            // 
            // ThirdUserControlDoctori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_doctori);
            this.Controls.Add(this.dgv_doctori);
            this.Name = "ThirdUserControlDoctori";
            this.Size = new System.Drawing.Size(847, 425);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doctori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_doctori;
        private System.Windows.Forms.Label label_doctori;
    }
}
