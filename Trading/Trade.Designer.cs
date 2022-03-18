namespace Trading
{
    partial class Trade
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yourAccount = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.exchange = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(176, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Exchange";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trading.Properties.Resources.exchange_dollar_icon_icons_com_53141__3_;
            this.pictureBox1.Location = new System.Drawing.Point(106, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(176, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Account";
            // 
            // yourAccount
            // 
            this.yourAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yourAccount.Location = new System.Drawing.Point(318, 204);
            this.yourAccount.Name = "yourAccount";
            this.yourAccount.Size = new System.Drawing.Size(180, 26);
            this.yourAccount.TabIndex = 3;
            this.yourAccount.TextChanged += new System.EventHandler(this.yourAccount_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Pink;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exit.ImageKey = "(ninguna)";
            this.exit.Location = new System.Drawing.Point(662, 393);
            this.exit.Name = "exit";
            this.exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exit.Size = new System.Drawing.Size(89, 37);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // exchange
            // 
            this.exchange.BackColor = System.Drawing.Color.Pink;
            this.exchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exchange.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exchange.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exchange.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exchange.ImageKey = "(ninguna)";
            this.exchange.Location = new System.Drawing.Point(336, 291);
            this.exchange.Name = "exchange";
            this.exchange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exchange.Size = new System.Drawing.Size(131, 27);
            this.exchange.TabIndex = 6;
            this.exchange.Text = "To Exchange";
            this.exchange.UseVisualStyleBackColor = false;
            this.exchange.Click += new System.EventHandler(this.exchange_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.exchange);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.yourAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Trade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Trade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yourAccount;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button exchange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
