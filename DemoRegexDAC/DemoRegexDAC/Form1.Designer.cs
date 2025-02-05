namespace DemoRegexDAC
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
            this.UI_DGV_Output = new System.Windows.Forms.DataGridView();
            this.UI_B_DataA = new System.Windows.Forms.Button();
            this.UI_B_DataB = new System.Windows.Forms.Button();
            this.UI_B_DemoDGV = new System.Windows.Forms.Button();
            this.UI_B_LINQ_GPS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_DGV_Output
            // 
            this.UI_DGV_Output.AllowUserToAddRows = false;
            this.UI_DGV_Output.AllowUserToDeleteRows = false;
            this.UI_DGV_Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UI_DGV_Output.Location = new System.Drawing.Point(12, 12);
            this.UI_DGV_Output.MultiSelect = false;
            this.UI_DGV_Output.Name = "UI_DGV_Output";
            this.UI_DGV_Output.ReadOnly = true;
            this.UI_DGV_Output.RowHeadersVisible = false;
            this.UI_DGV_Output.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.UI_DGV_Output.ShowEditingIcon = false;
            this.UI_DGV_Output.Size = new System.Drawing.Size(635, 426);
            this.UI_DGV_Output.TabIndex = 0;
            // 
            // UI_B_DataA
            // 
            this.UI_B_DataA.Location = new System.Drawing.Point(653, 41);
            this.UI_B_DataA.Name = "UI_B_DataA";
            this.UI_B_DataA.Size = new System.Drawing.Size(135, 23);
            this.UI_B_DataA.TabIndex = 1;
            this.UI_B_DataA.Text = "Demo LINQ";
            this.UI_B_DataA.UseVisualStyleBackColor = true;
            this.UI_B_DataA.Click += new System.EventHandler(this.UI_B_DataA_Click);
            // 
            // UI_B_DataB
            // 
            this.UI_B_DataB.Location = new System.Drawing.Point(653, 70);
            this.UI_B_DataB.Name = "UI_B_DataB";
            this.UI_B_DataB.Size = new System.Drawing.Size(135, 23);
            this.UI_B_DataB.TabIndex = 2;
            this.UI_B_DataB.Text = "Demo Named Groups";
            this.UI_B_DataB.UseVisualStyleBackColor = true;
            this.UI_B_DataB.Click += new System.EventHandler(this.UI_B_DataB_Click);
            // 
            // UI_B_DemoDGV
            // 
            this.UI_B_DemoDGV.Location = new System.Drawing.Point(653, 12);
            this.UI_B_DemoDGV.Name = "UI_B_DemoDGV";
            this.UI_B_DemoDGV.Size = new System.Drawing.Size(135, 23);
            this.UI_B_DemoDGV.TabIndex = 3;
            this.UI_B_DemoDGV.Text = "Demo DGV";
            this.UI_B_DemoDGV.UseVisualStyleBackColor = true;
            this.UI_B_DemoDGV.Click += new System.EventHandler(this.UI_B_DemoDGV_Click);
            // 
            // UI_B_LINQ_GPS
            // 
            this.UI_B_LINQ_GPS.Location = new System.Drawing.Point(653, 99);
            this.UI_B_LINQ_GPS.Name = "UI_B_LINQ_GPS";
            this.UI_B_LINQ_GPS.Size = new System.Drawing.Size(135, 23);
            this.UI_B_LINQ_GPS.TabIndex = 4;
            this.UI_B_LINQ_GPS.Text = "Demo LINQ Gps";
            this.UI_B_LINQ_GPS.UseVisualStyleBackColor = true;
            this.UI_B_LINQ_GPS.Click += new System.EventHandler(this.UI_B_LINQ_GPS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_B_LINQ_GPS);
            this.Controls.Add(this.UI_B_DemoDGV);
            this.Controls.Add(this.UI_B_DataB);
            this.Controls.Add(this.UI_B_DataA);
            this.Controls.Add(this.UI_DGV_Output);
            this.Name = "Form1";
            this.Text = "Demo - LINQ, Data-Aware Controls, Named Groups";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UI_DGV_Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UI_DGV_Output;
        private System.Windows.Forms.Button UI_B_DataA;
        private System.Windows.Forms.Button UI_B_DataB;
        private System.Windows.Forms.Button UI_B_DemoDGV;
        private System.Windows.Forms.Button UI_B_LINQ_GPS;
    }
}

