namespace CheckHostTool
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Button btnDns;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.btnDns = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            
            this.txtHost.Location = new System.Drawing.Point(12, 12);
            this.txtHost.Size = new System.Drawing.Size(360, 23);
            
            this.btnPing.Location = new System.Drawing.Point(12, 41);
            this.btnPing.Size = new System.Drawing.Size(100, 30);
            this.btnPing.Text = "Ping";
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);

            this.btnDns.Location = new System.Drawing.Point(118, 41);
            this.btnDns.Size = new System.Drawing.Size(100, 30);
            this.btnDns.Text = "DNS Lookup";
            this.btnDns.Click += new System.EventHandler(this.btnDns_Click);

            this.btnPort.Location = new System.Drawing.Point(224, 41);
            this.btnPort.Size = new System.Drawing.Size(100, 30);
            this.btnPort.Text = "Port Check";
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);

            this.txtOutput.Location = new System.Drawing.Point(12, 77);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(360, 200);

            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnDns);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.txtOutput);
            this.Text = "Check-Host Tool";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}