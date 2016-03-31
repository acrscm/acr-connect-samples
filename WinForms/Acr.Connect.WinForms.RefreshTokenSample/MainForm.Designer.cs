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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Scope = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Service URL:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // AuthServiceUrl
            // 
            this.AuthServiceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthServiceUrl.Location = new System.Drawing.Point(105, 3);
            this.AuthServiceUrl.Name = "AuthServiceUrl";
            this.AuthServiceUrl.Size = new System.Drawing.Size(303, 20);
            this.AuthServiceUrl.TabIndex = 1;
            // 
            // ClientId
            // 
            this.ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientId.Location = new System.Drawing.Point(105, 29);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(303, 20);
            this.ClientId.TabIndex = 3;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SignInButton.Location = new System.Drawing.Point(17, 3);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(80, 22);
            this.SignInButton.TabIndex = 14;
            this.SignInButton.Text = "Sing In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // RedirectUrl
            // 
            this.RedirectUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RedirectUrl.Location = new System.Drawing.Point(495, 3);
            this.RedirectUrl.Name = "RedirectUrl";
            this.RedirectUrl.Size = new System.Drawing.Size(303, 20);
            this.RedirectUrl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Redirect URL:";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SignOutButton.Location = new System.Drawing.Point(117, 3);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(80, 22);
            this.SignOutButton.TabIndex = 20;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // AuthCode
            // 
            this.AuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthCode.Location = new System.Drawing.Point(117, 101);
            this.AuthCode.Multiline = true;
            this.AuthCode.Name = "AuthCode";
            this.AuthCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AuthCode.Size = new System.Drawing.Size(693, 60);
            this.AuthCode.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 104);
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
            this._acrConnectOidcLogOnControl.Location = new System.Drawing.Point(12, 233);
            this._acrConnectOidcLogOnControl.Name = "_acrConnectOidcLogOnControl";
            this._acrConnectOidcLogOnControl.RedirectUrl = new System.Uri("http://localhost", System.UriKind.Absolute);
            this._acrConnectOidcLogOnControl.RequestTokens = true;
            this._acrConnectOidcLogOnControl.Scope = "openid email";
            this._acrConnectOidcLogOnControl.SignInUser = false;
            this._acrConnectOidcLogOnControl.Size = new System.Drawing.Size(801, 423);
            this._acrConnectOidcLogOnControl.TabIndex = 21;
            this._acrConnectOidcLogOnControl.AuthCodeReceived += new System.EventHandler<Acr.Connect.Security.Gui.AuthCodeReceivedEventArgs>(this.AcrConnectOidcLogonControl_AuthCodeReceived);
            this._acrConnectOidcLogOnControl.TokenReceived += new System.EventHandler<Acr.Connect.Security.Gui.TokenReceivedEventArgs>(this.AcrConnectOidcLogonControl_TokenReceived);
            // 
            // RefreshToken
            // 
            this.RefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshToken.Location = new System.Drawing.Point(117, 167);
            this.RefreshToken.Multiline = true;
            this.RefreshToken.Name = "RefreshToken";
            this.RefreshToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RefreshToken.Size = new System.Drawing.Size(693, 60);
            this.RefreshToken.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Refresh Token:";
            // 
            // ClientSecret
            // 
            this.ClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSecret.Location = new System.Drawing.Point(105, 59);
            this.ClientSecret.Name = "ClientSecret";
            this.ClientSecret.Size = new System.Drawing.Size(303, 20);
            this.ClientSecret.TabIndex = 28;
            this.ClientSecret.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Client Secret:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Scope, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuthServiceUrl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RedirectUrl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClientId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClientSecret, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 83);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // Scope
            // 
            this.Scope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Scope.Location = new System.Drawing.Point(495, 29);
            this.Scope.Name = "Scope";
            this.Scope.Size = new System.Drawing.Size(303, 20);
            this.Scope.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Scope:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.SignInButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SignOutButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(598, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 28);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Location = new System.Drawing.Point(31, 190);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(80, 37);
            this.CopyToClipboardButton.TabIndex = 30;
            this.CopyToClipboardButton.Text = "Copy to Clipboard";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 668);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RefreshToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._acrConnectOidcLogOnControl);
            this.Name = "MainForm";
            this.Text = "Sample: Get Refresh Token";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Scope;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CopyToClipboardButton;
    }
}

