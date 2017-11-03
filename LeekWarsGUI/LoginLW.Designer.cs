namespace LeekWarsGUI
{
    partial class LoginLW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLW));
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.TokenCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(88, 38);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(300, 20);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.Text = "Sienna";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(150, 100);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(100, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connexion";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant :";
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(100, 15);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(200, 200);
            this.ImageBox.TabIndex = 4;
            this.ImageBox.TabStop = false;
            this.ImageBox.Visible = false;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(88, 275);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(300, 20);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.Visible = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(34, 315);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(112, 23);
            this.ChangeButton.TabIndex = 7;
            this.ChangeButton.Text = "Changer d\'utilisateur";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Visible = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // TokenCheckbox
            // 
            this.TokenCheckbox.AutoSize = true;
            this.TokenCheckbox.Location = new System.Drawing.Point(321, 319);
            this.TokenCheckbox.Name = "TokenCheckbox";
            this.TokenCheckbox.Size = new System.Drawing.Size(57, 17);
            this.TokenCheckbox.TabIndex = 9;
            this.TokenCheckbox.Text = "Token";
            this.TokenCheckbox.UseVisualStyleBackColor = true;
            this.TokenCheckbox.Visible = false;
            // 
            // LoginLW
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelButton = this.ChangeButton;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.TokenCheckbox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginLW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.CheckBox TokenCheckbox;
    }
}