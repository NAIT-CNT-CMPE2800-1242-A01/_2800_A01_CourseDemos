namespace SocketClient
{
    partial class Client
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
            this.Send_Btn = new System.Windows.Forms.Button();
            this.Soft_Disco_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Connect_Btn
            // 
            this.UI_Connect_Btn.Location = new System.Drawing.Point(126, 292);
            this.UI_Connect_Btn.Name = "UI_Connect_Btn";
            this.UI_Connect_Btn.Size = new System.Drawing.Size(75, 23);
            this.UI_Connect_Btn.TabIndex = 0;
            this.UI_Connect_Btn.Text = "Connect";
            this.UI_Connect_Btn.UseVisualStyleBackColor = true;
            this.UI_Connect_Btn.Click += new System.EventHandler(this.UI_Connect_Btn_Click);
            // 
            // Send_Btn
            // 
            this.Send_Btn.Location = new System.Drawing.Point(126, 254);
            this.Send_Btn.Name = "Send_Btn";
            this.Send_Btn.Size = new System.Drawing.Size(75, 23);
            this.Send_Btn.TabIndex = 1;
            this.Send_Btn.Text = "Send";
            this.Send_Btn.UseVisualStyleBackColor = true;
            this.Send_Btn.Click += new System.EventHandler(this.Send_Btn_Click);
            // 
            // Soft_Disco_Btn
            // 
            this.Soft_Disco_Btn.Location = new System.Drawing.Point(126, 210);
            this.Soft_Disco_Btn.Name = "Soft_Disco_Btn";
            this.Soft_Disco_Btn.Size = new System.Drawing.Size(75, 23);
            this.Soft_Disco_Btn.TabIndex = 2;
            this.Soft_Disco_Btn.Text = "Soft Disco";
            this.Soft_Disco_Btn.UseVisualStyleBackColor = true;
            this.Soft_Disco_Btn.Click += new System.EventHandler(this.Soft_Disco_Btn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 327);
            this.Controls.Add(this.Soft_Disco_Btn);
            this.Controls.Add(this.Send_Btn);
            this.Controls.Add(this.UI_Connect_Btn);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UI_Connect_Btn;
        private System.Windows.Forms.Button Send_Btn;
        private System.Windows.Forms.Button Soft_Disco_Btn;
    }
}

