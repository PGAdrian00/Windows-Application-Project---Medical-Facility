
namespace ProiectPAW
{
    partial class PacientiForm
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
            this.dgv_pacienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacienti
            // 
            this.dgv_pacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacienti.Location = new System.Drawing.Point(9, 10);
            this.dgv_pacienti.Name = "dgv_pacienti";
            this.dgv_pacienti.Size = new System.Drawing.Size(747, 344);
            this.dgv_pacienti.TabIndex = 0;
            this.dgv_pacienti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pacienti_CellClick);
            // 
            // PacientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_pacienti);
            this.Name = "PacientiForm";
            this.Text = "PacientiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacienti;
    }
}