using Acr.Connect.Security.Gui;

namespace Acr.Connect.WinForms.RefreshTokenSample
{
        partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthServiceUrl = new System.Windows.Forms.TextBox();
            this.ClientId = new System.Windows.Forms.TextBox();
            this.SignInButton = new System.Windows.Forms.Button();
            this.RedirectUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.AuthCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._acrConnectOidcLogOnControl = new Acr.Connect.Security.Gui.AcrConnectOidcLogOnControl();
            this.RefreshToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientSecret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Service URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // AuthServiceUrl
            // 
            this.AuthServiceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthServiceUrl.Location = new System.Drawing.Point(114, 12);
            this.AuthServiceUrl.Name = "AuthServiceUrl";
            this.AuthServiceUrl.Size = new System.Drawing.Size(613, 20);
            this.AuthServiceUrl.TabIndex = 1;
            // 
            // ClientId
            // 
            this.ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientId.Location = new System.Drawing.Point(114, 38);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(613, 20);
            this.ClientId.TabIndex = 3;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.Location = new System.Drawing.Point(733, 5);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(80, 23);
            this.SignInButton.TabIndex = 14;
            this.SignInButton.Text = "Sing In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // RedirectUrl
            // 
            this.RedirectUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RedirectUrl.Location = new System.Drawing.Point(114, 90);
            this.RedirectUrl.Name = "RedirectUrl";
            this.RedirectUrl.Size = new System.Drawing.Size(613, 20);
            this.RedirectUrl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Redirect URL:";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutButton.Location = new System.Drawing.Point(733, 35);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(80, 23);
            this.SignOutButton.TabIndex = 20;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // AuthCode
            // 
            this.AuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthCode.Location = new System.Drawing.Point(114, 116);
            this.AuthCode.Multiline = true;
            this.AuthCode.Name = "AuthCode";
            this.AuthCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthCode.Size = new System.Drawing.Size(699, 60);
            this.AuthCode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Auth Code:";
            // 
            // _acrConnectOidcLogOnControl
            // 
            this._acrConnectOidcLogOnControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._acrConnectOidcLogOnControl.AuthenticationServiceBaseUrl = new System.Uri("https://acrid.acr.org", System.UriKind.Absolute);
            this._acrConnectOidcLogOnControl.ClientId = "03b6dd32d0624705b8f2426da9a2fbca";
            this._acrConnectOidcLogOnControl.ClientSecret = null;
            this._acrConnectOidcLogOnControl.IdentityProviderName = "ACR ID TESTING";
            this._acrConnectOidcLogOnControl.Location = new System.Drawing.Point(12, 248);
            this._acrConnectOidcLogOnControl.Name = "_acrConnectOidcLogOnControl";
            this._acrConnectOidcLogOnControl.RedirectUrl = new System.Uri("http://localhost", System.UriKind.Absolute);
            this._acrConnectOidcLogOnControl.RequestTokens = true;
            this._acrConnectOidcLogOnControl.Scope = "openid email";
            this._acrConnectOidcLogOnControl.SignInUser = false;
            this._acrConnectOidcLogOnControl.Size = new System.Drawing.Size(801, 408);
            this._acrConnectOidcLogOnControl.TabIndex = 21;
            this._acrConnectOidcLogOnControl.AuthCodeReceived += new System.EventHandler<Acr.Connect.Security.Gui.AuthCodeReceivedEventArgs>(this.AcrConnectOidcLogonControl_AuthCodeReceived);
            this._acrConnectOidcLogOnControl.TokenReceived += new System.EventHandler<Acr.Connect.Security.Gui.TokenReceivedEventArgs>(this.AcrConnectOidcLogonControl_TokenReceived);
            // 
            // RefreshToken
            // 
            this.RefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshToken.Location = new System.Drawing.Point(114, 182);
            this.RefreshToken.Multiline = true;
            this.RefreshToken.Name = "RefreshToken";
            this.RefreshToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RefreshToken.Size = new System.Drawing.Size(699, 60);
            this.RefreshToken.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Refresh Token:";
            // 
            // ClientSecret
            // 
            this.ClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSecret.Location = new System.Drawing.Point(114, 64);
            this.ClientSecret.Name = "ClientSecret";
            this.ClientSecret.Size = new System.Drawing.Size(613, 20);
            this.ClientSecret.TabIndex = 28;
            this.ClientSecret.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Client Secret:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 668);
            this.Controls.Add(this.ClientSecret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RefreshToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._acrConnectOidcLogOnControl);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.RedirectUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.ClientId);
            this.Controls.Add(this.AuthServiceUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "ACR ID WinForms Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthServiceUrl;
        private System.Windows.Forms.TextBox ClientId;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox RedirectUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SignOutButton;
        private AcrConnectOidcLogOnControl _acrConnectOidcLogOnControl;
        private System.Windows.Forms.TextBox AuthCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RefreshToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientSecret;
        private System.Windows.Forms.Label label5;
    }
}

