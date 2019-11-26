namespace Acr.Connect.Samples.WinForms.RefreshToken
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
            this.RefreshToken = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AccessTokenLabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AccessTokenLabel = new System.Windows.Forms.Label();
            this.CopyAccessTokenButton = new System.Windows.Forms.Button();
            this.UserClaims = new System.Windows.Forms.TextBox();
            this.IdToken = new System.Windows.Forms.TextBox();
            this.AccessToken = new System.Windows.Forms.TextBox();
            this.RefreshTokenLabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.CopyRefrestTokenButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Scope = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IdTokenLabel = new System.Windows.Forms.Label();
            this.CopyIdTokenButton = new System.Windows.Forms.Button();
            this.UserClaimsLabel = new System.Windows.Forms.Label();
            this.ClearTokens = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.AccessTokenLabelPanel.SuspendLayout();
            this.RefreshTokenLabelPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Service URL:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // AuthServiceUrl
            // 
            this.AuthServiceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthServiceUrl.Location = new System.Drawing.Point(109, 3);
            this.AuthServiceUrl.Name = "AuthServiceUrl";
            this.AuthServiceUrl.Size = new System.Drawing.Size(264, 20);
            this.AuthServiceUrl.TabIndex = 1;
            // 
            // ClientId
            // 
            this.ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientId.Location = new System.Drawing.Point(109, 29);
            this.ClientId.Name = "ClientId";
            this.ClientId.Size = new System.Drawing.Size(264, 20);
            this.ClientId.TabIndex = 3;
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInButton.Location = new System.Drawing.Point(571, 586);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(80, 22);
            this.SignInButton.TabIndex = 14;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // RedirectUrl
            // 
            this.RedirectUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RedirectUrl.Location = new System.Drawing.Point(460, 3);
            this.RedirectUrl.Name = "RedirectUrl";
            this.RedirectUrl.Size = new System.Drawing.Size(265, 20);
            this.RedirectUrl.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Redirect URL:";
            // 
            // SignOutButton
            // 
            this.SignOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignOutButton.Location = new System.Drawing.Point(657, 586);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(80, 22);
            this.SignOutButton.TabIndex = 20;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // RefreshToken
            // 
            this.RefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.SetColumnSpan(this.RefreshToken, 3);
            this.RefreshToken.Location = new System.Drawing.Point(109, 55);
            this.RefreshToken.Multiline = true;
            this.RefreshToken.Name = "RefreshToken";
            this.RefreshToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RefreshToken.Size = new System.Drawing.Size(616, 97);
            this.RefreshToken.TabIndex = 26;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.ColumnCount = 4;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Controls.Add(this.AccessTokenLabelPanel, 0, 4);
            this.MainPanel.Controls.Add(this.UserClaims, 1, 6);
            this.MainPanel.Controls.Add(this.IdToken, 1, 5);
            this.MainPanel.Controls.Add(this.AccessToken, 1, 4);
            this.MainPanel.Controls.Add(this.RefreshTokenLabelPanel, 0, 3);
            this.MainPanel.Controls.Add(this.label1, 0, 0);
            this.MainPanel.Controls.Add(this.AuthServiceUrl, 1, 0);
            this.MainPanel.Controls.Add(this.label2, 0, 1);
            this.MainPanel.Controls.Add(this.ClientId, 1, 1);
            this.MainPanel.Controls.Add(this.RefreshToken, 1, 3);
            this.MainPanel.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.MainPanel.Controls.Add(this.UserClaimsLabel, 0, 6);
            this.MainPanel.Controls.Add(this.RedirectUrl, 3, 0);
            this.MainPanel.Controls.Add(this.label4, 2, 0);
            this.MainPanel.Controls.Add(this.Scope, 3, 1);
            this.MainPanel.Controls.Add(this.label7, 2, 1);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 7;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainPanel.Size = new System.Drawing.Size(728, 568);
            this.MainPanel.TabIndex = 29;
            // 
            // AccessTokenLabelPanel
            // 
            this.AccessTokenLabelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AccessTokenLabelPanel.ColumnCount = 1;
            this.AccessTokenLabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccessTokenLabelPanel.Controls.Add(this.AccessTokenLabel, 0, 0);
            this.AccessTokenLabelPanel.Controls.Add(this.CopyAccessTokenButton, 0, 1);
            this.AccessTokenLabelPanel.Location = new System.Drawing.Point(0, 155);
            this.AccessTokenLabelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AccessTokenLabelPanel.Name = "AccessTokenLabelPanel";
            this.AccessTokenLabelPanel.RowCount = 2;
            this.AccessTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AccessTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AccessTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AccessTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AccessTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AccessTokenLabelPanel.Size = new System.Drawing.Size(106, 103);
            this.AccessTokenLabelPanel.TabIndex = 32;
            // 
            // AccessTokenLabel
            // 
            this.AccessTokenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AccessTokenLabel.AutoSize = true;
            this.AccessTokenLabel.Location = new System.Drawing.Point(24, 23);
            this.AccessTokenLabel.Name = "AccessTokenLabel";
            this.AccessTokenLabel.Size = new System.Drawing.Size(79, 13);
            this.AccessTokenLabel.TabIndex = 25;
            this.AccessTokenLabel.Text = "Access Token:";
            // 
            // CopyAccessTokenButton
            // 
            this.CopyAccessTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyAccessTokenButton.Location = new System.Drawing.Point(3, 63);
            this.CopyAccessTokenButton.Name = "CopyAccessTokenButton";
            this.CopyAccessTokenButton.Size = new System.Drawing.Size(100, 37);
            this.CopyAccessTokenButton.TabIndex = 30;
            this.CopyAccessTokenButton.Text = "Copy to Clipboard";
            this.CopyAccessTokenButton.UseVisualStyleBackColor = true;
            this.CopyAccessTokenButton.Click += new System.EventHandler(this.CopyAccessTokenButton_Click);
            // 
            // UserClaims
            // 
            this.UserClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.SetColumnSpan(this.UserClaims, 3);
            this.UserClaims.Location = new System.Drawing.Point(109, 364);
            this.UserClaims.Multiline = true;
            this.UserClaims.Name = "UserClaims";
            this.UserClaims.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserClaims.Size = new System.Drawing.Size(616, 201);
            this.UserClaims.TabIndex = 34;
            // 
            // IdToken
            // 
            this.IdToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.SetColumnSpan(this.IdToken, 3);
            this.IdToken.Location = new System.Drawing.Point(109, 261);
            this.IdToken.Multiline = true;
            this.IdToken.Name = "IdToken";
            this.IdToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IdToken.Size = new System.Drawing.Size(616, 97);
            this.IdToken.TabIndex = 33;
            // 
            // AccessToken
            // 
            this.AccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.SetColumnSpan(this.AccessToken, 3);
            this.AccessToken.Location = new System.Drawing.Point(109, 158);
            this.AccessToken.Multiline = true;
            this.AccessToken.Name = "AccessToken";
            this.AccessToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AccessToken.Size = new System.Drawing.Size(616, 97);
            this.AccessToken.TabIndex = 32;
            // 
            // RefreshTokenLabelPanel
            // 
            this.RefreshTokenLabelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RefreshTokenLabelPanel.ColumnCount = 1;
            this.RefreshTokenLabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RefreshTokenLabelPanel.Controls.Add(this.label3, 0, 0);
            this.RefreshTokenLabelPanel.Controls.Add(this.CopyRefrestTokenButton, 0, 1);
            this.RefreshTokenLabelPanel.Location = new System.Drawing.Point(0, 52);
            this.RefreshTokenLabelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshTokenLabelPanel.Name = "RefreshTokenLabelPanel";
            this.RefreshTokenLabelPanel.RowCount = 2;
            this.RefreshTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RefreshTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RefreshTokenLabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RefreshTokenLabelPanel.Size = new System.Drawing.Size(106, 103);
            this.RefreshTokenLabelPanel.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Refresh Token:";
            // 
            // CopyRefrestTokenButton
            // 
            this.CopyRefrestTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyRefrestTokenButton.Location = new System.Drawing.Point(3, 63);
            this.CopyRefrestTokenButton.Name = "CopyRefrestTokenButton";
            this.CopyRefrestTokenButton.Size = new System.Drawing.Size(100, 37);
            this.CopyRefrestTokenButton.TabIndex = 30;
            this.CopyRefrestTokenButton.Text = "Copy to Clipboard";
            this.CopyRefrestTokenButton.UseVisualStyleBackColor = true;
            this.CopyRefrestTokenButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Scope:";
            // 
            // Scope
            // 
            this.Scope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Scope.Location = new System.Drawing.Point(460, 29);
            this.Scope.Name = "Scope";
            this.Scope.Size = new System.Drawing.Size(265, 20);
            this.Scope.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.IdTokenLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CopyIdTokenButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 258);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(106, 103);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // IdTokenLabel
            // 
            this.IdTokenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IdTokenLabel.AutoSize = true;
            this.IdTokenLabel.Location = new System.Drawing.Point(48, 23);
            this.IdTokenLabel.Name = "IdTokenLabel";
            this.IdTokenLabel.Size = new System.Drawing.Size(55, 13);
            this.IdTokenLabel.TabIndex = 25;
            this.IdTokenLabel.Text = "ID Token:";
            // 
            // CopyIdTokenButton
            // 
            this.CopyIdTokenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyIdTokenButton.Location = new System.Drawing.Point(3, 63);
            this.CopyIdTokenButton.Name = "CopyIdTokenButton";
            this.CopyIdTokenButton.Size = new System.Drawing.Size(100, 37);
            this.CopyIdTokenButton.TabIndex = 30;
            this.CopyIdTokenButton.Text = "Copy to Clipboard";
            this.CopyIdTokenButton.UseVisualStyleBackColor = true;
            this.CopyIdTokenButton.Click += new System.EventHandler(this.CopyIdTokenButton_Click);
            // 
            // UserClaimsLabel
            // 
            this.UserClaimsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserClaimsLabel.AutoSize = true;
            this.UserClaimsLabel.Location = new System.Drawing.Point(38, 458);
            this.UserClaimsLabel.Name = "UserClaimsLabel";
            this.UserClaimsLabel.Size = new System.Drawing.Size(65, 13);
            this.UserClaimsLabel.TabIndex = 36;
            this.UserClaimsLabel.Text = "User Claims:";
            // 
            // ClearTokens
            // 
            this.ClearTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearTokens.Location = new System.Drawing.Point(12, 586);
            this.ClearTokens.Name = "ClearTokens";
            this.ClearTokens.Size = new System.Drawing.Size(80, 22);
            this.ClearTokens.TabIndex = 30;
            this.ClearTokens.Text = "Clear Tokens";
            this.ClearTokens.UseVisualStyleBackColor = true;
            this.ClearTokens.Click += new System.EventHandler(this.ClearTokens_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 620);
            this.Controls.Add(this.ClearTokens);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Sample: Get Refresh Token";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.AccessTokenLabelPanel.ResumeLayout(false);
            this.AccessTokenLabelPanel.PerformLayout();
            this.RefreshTokenLabelPanel.ResumeLayout(false);
            this.RefreshTokenLabelPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox RefreshToken;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TextBox Scope;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserClaims;
        private System.Windows.Forms.TextBox IdToken;
        private System.Windows.Forms.TextBox AccessToken;
        private System.Windows.Forms.TableLayoutPanel AccessTokenLabelPanel;
        private System.Windows.Forms.Label AccessTokenLabel;
        private System.Windows.Forms.Button CopyAccessTokenButton;
        private System.Windows.Forms.TableLayoutPanel RefreshTokenLabelPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CopyRefrestTokenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IdTokenLabel;
        private System.Windows.Forms.Button CopyIdTokenButton;
        private System.Windows.Forms.Label UserClaimsLabel;
        private System.Windows.Forms.Button ClearTokens;
    }
}

