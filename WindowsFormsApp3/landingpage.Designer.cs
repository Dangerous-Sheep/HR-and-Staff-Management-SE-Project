namespace WindowsFormsApp3
{
    partial class landingpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingpage));
            this.label1 = new System.Windows.Forms.Label();
            this.ProceedTOLoginButton = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-4, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to\r\nEmerald Care";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProceedTOLoginButton
            // 
            this.ProceedTOLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.ProceedTOLoginButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ProceedTOLoginButton.BorderColor = System.Drawing.Color.White;
            this.ProceedTOLoginButton.BorderRadius = 20;
            this.ProceedTOLoginButton.BorderSize = 4;
            this.ProceedTOLoginButton.FlatAppearance.BorderSize = 0;
            this.ProceedTOLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedTOLoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedTOLoginButton.ForeColor = System.Drawing.Color.White;
            this.ProceedTOLoginButton.Location = new System.Drawing.Point(855, 528);
            this.ProceedTOLoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProceedTOLoginButton.Name = "ProceedTOLoginButton";
            this.ProceedTOLoginButton.Size = new System.Drawing.Size(200, 49);
            this.ProceedTOLoginButton.TabIndex = 71;
            this.ProceedTOLoginButton.Text = "Proceed to Login";
            this.ProceedTOLoginButton.TextColor = System.Drawing.Color.White;
            this.ProceedTOLoginButton.UseVisualStyleBackColor = false;
            this.ProceedTOLoginButton.Click += new System.EventHandler(this.ProceedTOLoginButton_Click_1);
            // 
            // landingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.ProceedTOLoginButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "landingpage";
            this.Text = "landingpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton ProceedTOLoginButton;
    }
}