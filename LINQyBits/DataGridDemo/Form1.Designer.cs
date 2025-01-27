namespace DataGridDemo
{
    partial class Form1
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
            this.UI_DGVOutput = new System.Windows.Forms.DataGridView();
            this.UI_B_Populate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGVOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_DGVOutput
            // 
            this.UI_DGVOutput.AllowUserToAddRows = false;
            this.UI_DGVOutput.AllowUserToDeleteRows = false;
            this.UI_DGVOutput.AllowUserToResizeRows = false;
            this.UI_DGVOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DGVOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_DGVOutput.Location = new System.Drawing.Point(12, 12);
            this.UI_DGVOutput.Name = "UI_DGVOutput";
            this.UI_DGVOutput.Size = new System.Drawing.Size(538, 209);
            this.UI_DGVOutput.TabIndex = 0;
            // 
            // UI_B_Populate
            // 
            this.UI_B_Populate.Location = new System.Drawing.Point(475, 227);
            this.UI_B_Populate.Name = "UI_B_Populate";
            this.UI_B_Populate.Size = new System.Drawing.Size(75, 23);
            this.UI_B_Populate.TabIndex = 1;
            this.UI_B_Populate.Text = "Populate";
            this.UI_B_Populate.UseVisualStyleBackColor = true;
            this.UI_B_Populate.Click += new System.EventHandler(this.UI_B_Populate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.UI_B_Populate);
            this.Controls.Add(this.UI_DGVOutput);
            this.Name = "Form1";
            this.Text = "DataGridView Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGVOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_DGVOutput;
        private System.Windows.Forms.Button UI_B_Populate;
    }
}

