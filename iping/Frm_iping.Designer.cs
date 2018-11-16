namespace iping
{
    partial class Frm_iping
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
            this.Btn_Ping = new System.Windows.Forms.Button();
            this.Rtb_Output = new System.Windows.Forms.RichTextBox();
            this.Txt_Host = new System.Windows.Forms.TextBox();
            this.Txt_Timeout = new System.Windows.Forms.TextBox();
            this.Lbl_Host = new System.Windows.Forms.Label();
            this.Lbl_Timeout = new System.Windows.Forms.Label();
            this.LbL_PingSuccessRate = new System.Windows.Forms.Label();
            this.Lbl_AveragePing = new System.Windows.Forms.Label();
            this.Txt_SuccessRate = new System.Windows.Forms.TextBox();
            this.Txt_AverageTime = new System.Windows.Forms.TextBox();
            this.Btn_ClearOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ping
            // 
            this.Btn_Ping.Location = new System.Drawing.Point(430, 20);
            this.Btn_Ping.Name = "Btn_Ping";
            this.Btn_Ping.Size = new System.Drawing.Size(151, 23);
            this.Btn_Ping.TabIndex = 0;
            this.Btn_Ping.Text = "Ping";
            this.Btn_Ping.UseVisualStyleBackColor = true;
            this.Btn_Ping.Click += new System.EventHandler(this.Btn_Ping_Click);
            // 
            // Rtb_Output
            // 
            this.Rtb_Output.Location = new System.Drawing.Point(6, 48);
            this.Rtb_Output.Name = "Rtb_Output";
            this.Rtb_Output.ReadOnly = true;
            this.Rtb_Output.Size = new System.Drawing.Size(661, 390);
            this.Rtb_Output.TabIndex = 3;
            this.Rtb_Output.Text = "";
            this.Rtb_Output.TextChanged += new System.EventHandler(this.Rtb_Output_TextChanged);
            // 
            // Txt_Host
            // 
            this.Txt_Host.Location = new System.Drawing.Point(6, 22);
            this.Txt_Host.Name = "Txt_Host";
            this.Txt_Host.Size = new System.Drawing.Size(100, 20);
            this.Txt_Host.TabIndex = 4;
            this.Txt_Host.Text = "8.8.8.8";
            // 
            // Txt_Timeout
            // 
            this.Txt_Timeout.Location = new System.Drawing.Point(112, 22);
            this.Txt_Timeout.Name = "Txt_Timeout";
            this.Txt_Timeout.Size = new System.Drawing.Size(100, 20);
            this.Txt_Timeout.TabIndex = 5;
            this.Txt_Timeout.Text = "2500";
            // 
            // Lbl_Host
            // 
            this.Lbl_Host.AutoSize = true;
            this.Lbl_Host.Location = new System.Drawing.Point(6, 6);
            this.Lbl_Host.Name = "Lbl_Host";
            this.Lbl_Host.Size = new System.Drawing.Size(29, 13);
            this.Lbl_Host.TabIndex = 7;
            this.Lbl_Host.Text = "Host";
            // 
            // Lbl_Timeout
            // 
            this.Lbl_Timeout.AutoSize = true;
            this.Lbl_Timeout.Location = new System.Drawing.Point(109, 6);
            this.Lbl_Timeout.Name = "Lbl_Timeout";
            this.Lbl_Timeout.Size = new System.Drawing.Size(45, 13);
            this.Lbl_Timeout.TabIndex = 8;
            this.Lbl_Timeout.Text = "Timeout";
            // 
            // LbL_PingSuccessRate
            // 
            this.LbL_PingSuccessRate.AutoSize = true;
            this.LbL_PingSuccessRate.Location = new System.Drawing.Point(321, 6);
            this.LbL_PingSuccessRate.Name = "LbL_PingSuccessRate";
            this.LbL_PingSuccessRate.Size = new System.Drawing.Size(74, 13);
            this.LbL_PingSuccessRate.TabIndex = 9;
            this.LbL_PingSuccessRate.Text = "Success Rate";
            // 
            // Lbl_AveragePing
            // 
            this.Lbl_AveragePing.AutoSize = true;
            this.Lbl_AveragePing.Location = new System.Drawing.Point(215, 6);
            this.Lbl_AveragePing.Name = "Lbl_AveragePing";
            this.Lbl_AveragePing.Size = new System.Drawing.Size(73, 13);
            this.Lbl_AveragePing.TabIndex = 10;
            this.Lbl_AveragePing.Text = "Average Time";
            // 
            // Txt_SuccessRate
            // 
            this.Txt_SuccessRate.Location = new System.Drawing.Point(324, 22);
            this.Txt_SuccessRate.Name = "Txt_SuccessRate";
            this.Txt_SuccessRate.Size = new System.Drawing.Size(100, 20);
            this.Txt_SuccessRate.TabIndex = 11;
            this.Txt_SuccessRate.Text = "0%";
            // 
            // Txt_AverageTime
            // 
            this.Txt_AverageTime.Location = new System.Drawing.Point(218, 22);
            this.Txt_AverageTime.Name = "Txt_AverageTime";
            this.Txt_AverageTime.Size = new System.Drawing.Size(100, 20);
            this.Txt_AverageTime.TabIndex = 12;
            this.Txt_AverageTime.Text = "0 ms";
            // 
            // Btn_ClearOutput
            // 
            this.Btn_ClearOutput.Location = new System.Drawing.Point(587, 20);
            this.Btn_ClearOutput.Name = "Btn_ClearOutput";
            this.Btn_ClearOutput.Size = new System.Drawing.Size(75, 23);
            this.Btn_ClearOutput.TabIndex = 13;
            this.Btn_ClearOutput.Text = "Clear";
            this.Btn_ClearOutput.UseVisualStyleBackColor = true;
            this.Btn_ClearOutput.Click += new System.EventHandler(this.Btn_ClearOutput_Click);
            // 
            // Frm_iping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.Btn_ClearOutput);
            this.Controls.Add(this.Txt_AverageTime);
            this.Controls.Add(this.Txt_SuccessRate);
            this.Controls.Add(this.Lbl_AveragePing);
            this.Controls.Add(this.LbL_PingSuccessRate);
            this.Controls.Add(this.Lbl_Timeout);
            this.Controls.Add(this.Lbl_Host);
            this.Controls.Add(this.Txt_Timeout);
            this.Controls.Add(this.Txt_Host);
            this.Controls.Add(this.Rtb_Output);
            this.Controls.Add(this.Btn_Ping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_iping";
            this.ShowIcon = false;
            this.Text = "Improved Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ping;
        private System.Windows.Forms.RichTextBox Rtb_Output;
        private System.Windows.Forms.TextBox Txt_Host;
        private System.Windows.Forms.TextBox Txt_Timeout;
        private System.Windows.Forms.Label Lbl_Host;
        private System.Windows.Forms.Label Lbl_Timeout;
        private System.Windows.Forms.Label LbL_PingSuccessRate;
        private System.Windows.Forms.Label Lbl_AveragePing;
        private System.Windows.Forms.TextBox Txt_SuccessRate;
        private System.Windows.Forms.TextBox Txt_AverageTime;
        private System.Windows.Forms.Button Btn_ClearOutput;
    }
}

