namespace SocketServer
{
    partial class Server
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
            this.UI_Connect_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Connect_Btn
            // 
            this.UI_Connect_Btn.Location = new System.Drawing.Point(101, 293);
            this.UI_Connect_Btn.Name = "UI_Connect_Btn";
            this.UI_Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Connect_Btn.TabIndex = 0;
            this.UI_Connect_Btn.Text = "Connect";
            this.UI_Connect_Btn.UseVisualStyleBackColor = true;
            this.UI_Connect_Btn.Click += new System.EventHandler(this.UI_Connect_Btn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 328);
            this.Controls.Add(this.UI_Connect_Btn);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Connect_Btn;
    }
}

