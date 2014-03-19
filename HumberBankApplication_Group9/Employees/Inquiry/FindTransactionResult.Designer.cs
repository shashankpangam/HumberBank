namespace HumberBankApplication_Group9.Employees.Inquiry
{
    partial class FindTransactionResult
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
            this.dgvFindTransaction = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFindTransaction
            // 
            this.dgvFindTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindTransaction.Location = new System.Drawing.Point(96, 58);
            this.dgvFindTransaction.Name = "dgvFindTransaction";
            this.dgvFindTransaction.Size = new System.Drawing.Size(527, 360);
            this.dgvFindTransaction.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 25);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FindTransactionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFindTransaction);
            this.Name = "FindTransactionResult";
            this.Text = "FindTransactionResult";
            this.Load += new System.EventHandler(this.FindTransactionResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFindTransaction;
        private System.Windows.Forms.Button btnClose;
    }
}