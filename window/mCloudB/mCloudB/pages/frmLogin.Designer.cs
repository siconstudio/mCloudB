namespace mCloudB.pages
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.uiLogin = new mCloudB.services.api.ui();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_loginData = new System.Windows.Forms.Panel();
            this.tlp_loginData = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginWelcome = new System.Windows.Forms.Label();
            this.pnl_loginSk = new System.Windows.Forms.Panel();
            this.lbl_loginWelcomeText = new System.Windows.Forms.Label();
            this.bunifuTb_loginUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuTb_loginPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.llbl_loginForgotAccount = new System.Windows.Forms.LinkLabel();
            this.bunifuBtn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_loginLeft = new System.Windows.Forms.Panel();
            this.pnl_loginTitle = new System.Windows.Forms.Panel();
            this.tlp_loginTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginLogo = new System.Windows.Forms.Label();
            this.lbl_loginTitle = new System.Windows.Forms.Label();
            this.bunifudropDown_loginLanguage = new Bunifu.UI.WinForms.BunifuDropdown();
            this.uiLoginBody = new mCloudB.services.api.ui();
            this.tlp_loginSignUp = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginSignUp = new System.Windows.Forms.Label();
            this.btn_loginSignUp = new System.Windows.Forms.Button();
            this.pnl_login.SuspendLayout();
            this.pnl_loginData.SuspendLayout();
            this.tlp_loginData.SuspendLayout();
            this.pnl_loginLeft.SuspendLayout();
            this.pnl_loginTitle.SuspendLayout();
            this.tlp_loginTitle.SuspendLayout();
            this.tlp_loginSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLogin
            // 
            this.uiLogin.CornerRadius = 30;
            this.uiLogin.TargetControl = this;
            // 
            // pnl_login
            // 
            this.pnl_login.AutoSize = true;
            this.pnl_login.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_login.Controls.Add(this.pnl_loginData);
            this.pnl_login.Controls.Add(this.pnl_loginLeft);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_login.Location = new System.Drawing.Point(3, 3);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(628, 321);
            this.pnl_login.TabIndex = 0;
            // 
            // pnl_loginData
            // 
            this.pnl_loginData.Controls.Add(this.tlp_loginData);
            this.pnl_loginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_loginData.Location = new System.Drawing.Point(296, 0);
            this.pnl_loginData.Name = "pnl_loginData";
            this.pnl_loginData.Size = new System.Drawing.Size(332, 321);
            this.pnl_loginData.TabIndex = 1;
            // 
            // tlp_loginData
            // 
            this.tlp_loginData.ColumnCount = 4;
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_loginData.Controls.Add(this.lbl_loginWelcome, 1, 1);
            this.tlp_loginData.Controls.Add(this.pnl_loginSk, 1, 2);
            this.tlp_loginData.Controls.Add(this.lbl_loginWelcomeText, 1, 3);
            this.tlp_loginData.Controls.Add(this.bunifuTb_loginUser, 1, 4);
            this.tlp_loginData.Controls.Add(this.bunifuTb_loginPassword, 1, 5);
            this.tlp_loginData.Controls.Add(this.llbl_loginForgotAccount, 1, 6);
            this.tlp_loginData.Controls.Add(this.bunifuBtn_login, 1, 7);
            this.tlp_loginData.Controls.Add(this.tlp_loginSignUp, 1, 8);
            this.tlp_loginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginData.Location = new System.Drawing.Point(0, 0);
            this.tlp_loginData.Name = "tlp_loginData";
            this.tlp_loginData.RowCount = 11;
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_loginData.Size = new System.Drawing.Size(332, 321);
            this.tlp_loginData.TabIndex = 0;
            // 
            // lbl_loginWelcome
            // 
            this.lbl_loginWelcome.AutoSize = true;
            this.lbl_loginWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginWelcome.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginWelcome.Location = new System.Drawing.Point(10, 22);
            this.lbl_loginWelcome.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.lbl_loginWelcome.Name = "lbl_loginWelcome";
            this.lbl_loginWelcome.Size = new System.Drawing.Size(314, 36);
            this.lbl_loginWelcome.TabIndex = 0;
            this.lbl_loginWelcome.Text = "Hello !";
            this.lbl_loginWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_loginSk
            // 
            this.pnl_loginSk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_loginSk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_loginSk.Location = new System.Drawing.Point(8, 61);
            this.pnl_loginSk.Name = "pnl_loginSk";
            this.pnl_loginSk.Size = new System.Drawing.Size(316, 1);
            this.pnl_loginSk.TabIndex = 1;
            // 
            // lbl_loginWelcomeText
            // 
            this.lbl_loginWelcomeText.AutoSize = true;
            this.lbl_loginWelcomeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginWelcomeText.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginWelcomeText.Location = new System.Drawing.Point(8, 63);
            this.lbl_loginWelcomeText.Name = "lbl_loginWelcomeText";
            this.lbl_loginWelcomeText.Size = new System.Drawing.Size(316, 36);
            this.lbl_loginWelcomeText.TabIndex = 2;
            this.lbl_loginWelcomeText.Text = "Welcome to mCloudB ( POS )";
            this.lbl_loginWelcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuTb_loginUser
            // 
            this.bunifuTb_loginUser.AcceptsReturn = false;
            this.bunifuTb_loginUser.AcceptsTab = false;
            this.bunifuTb_loginUser.AnimationSpeed = 200;
            this.bunifuTb_loginUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTb_loginUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTb_loginUser.AutoSizeHeight = true;
            this.bunifuTb_loginUser.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTb_loginUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTb_loginUser.BackgroundImage")));
            this.bunifuTb_loginUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTb_loginUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTb_loginUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTb_loginUser.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTb_loginUser.BorderRadius = 15;
            this.bunifuTb_loginUser.BorderThickness = 1;
            this.bunifuTb_loginUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTb_loginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginUser.DefaultFont = new System.Drawing.Font("Pyidaungsu", 9.5F);
            this.bunifuTb_loginUser.DefaultText = "";
            this.bunifuTb_loginUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuTb_loginUser.FillColor = System.Drawing.Color.White;
            this.bunifuTb_loginUser.HideSelection = true;
            this.bunifuTb_loginUser.IconLeft = global::mCloudB.Properties.Resources.account_24px;
            this.bunifuTb_loginUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginUser.IconPadding = 5;
            this.bunifuTb_loginUser.IconRight = null;
            this.bunifuTb_loginUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginUser.Lines = new string[0];
            this.bunifuTb_loginUser.Location = new System.Drawing.Point(8, 102);
            this.bunifuTb_loginUser.MaxLength = 32767;
            this.bunifuTb_loginUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTb_loginUser.Modified = false;
            this.bunifuTb_loginUser.Multiline = false;
            this.bunifuTb_loginUser.Name = "bunifuTb_loginUser";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUser.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTb_loginUser.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUser.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUser.OnIdleState = stateProperties4;
            this.bunifuTb_loginUser.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTb_loginUser.PasswordChar = '\0';
            this.bunifuTb_loginUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTb_loginUser.PlaceholderText = "Enter Account Name / Email";
            this.bunifuTb_loginUser.ReadOnly = false;
            this.bunifuTb_loginUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTb_loginUser.SelectedText = "";
            this.bunifuTb_loginUser.SelectionLength = 0;
            this.bunifuTb_loginUser.SelectionStart = 0;
            this.bunifuTb_loginUser.ShortcutsEnabled = true;
            this.bunifuTb_loginUser.Size = new System.Drawing.Size(316, 34);
            this.bunifuTb_loginUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTb_loginUser.TabIndex = 3;
            this.bunifuTb_loginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTb_loginUser.TextMarginBottom = 0;
            this.bunifuTb_loginUser.TextMarginLeft = 3;
            this.bunifuTb_loginUser.TextMarginTop = 1;
            this.bunifuTb_loginUser.TextPlaceholder = "Enter Account Name / Email";
            this.bunifuTb_loginUser.UseSystemPasswordChar = false;
            this.bunifuTb_loginUser.WordWrap = true;
            // 
            // bunifuTb_loginPassword
            // 
            this.bunifuTb_loginPassword.AcceptsReturn = false;
            this.bunifuTb_loginPassword.AcceptsTab = false;
            this.bunifuTb_loginPassword.AnimationSpeed = 200;
            this.bunifuTb_loginPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTb_loginPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTb_loginPassword.AutoSizeHeight = true;
            this.bunifuTb_loginPassword.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTb_loginPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTb_loginPassword.BackgroundImage")));
            this.bunifuTb_loginPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTb_loginPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTb_loginPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTb_loginPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTb_loginPassword.BorderRadius = 15;
            this.bunifuTb_loginPassword.BorderThickness = 1;
            this.bunifuTb_loginPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTb_loginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginPassword.DefaultFont = new System.Drawing.Font("Pyidaungsu", 9.5F);
            this.bunifuTb_loginPassword.DefaultText = "";
            this.bunifuTb_loginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuTb_loginPassword.FillColor = System.Drawing.Color.White;
            this.bunifuTb_loginPassword.HideSelection = true;
            this.bunifuTb_loginPassword.IconLeft = global::mCloudB.Properties.Resources.password_24px;
            this.bunifuTb_loginPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginPassword.IconPadding = 5;
            this.bunifuTb_loginPassword.IconRight = global::mCloudB.Properties.Resources.closed_eye_24px;
            this.bunifuTb_loginPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTb_loginPassword.Lines = new string[0];
            this.bunifuTb_loginPassword.Location = new System.Drawing.Point(8, 142);
            this.bunifuTb_loginPassword.MaxLength = 32767;
            this.bunifuTb_loginPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTb_loginPassword.Modified = false;
            this.bunifuTb_loginPassword.Multiline = false;
            this.bunifuTb_loginPassword.Name = "bunifuTb_loginPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTb_loginPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginPassword.OnIdleState = stateProperties8;
            this.bunifuTb_loginPassword.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTb_loginPassword.PasswordChar = '\0';
            this.bunifuTb_loginPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTb_loginPassword.PlaceholderText = "Enter account password !";
            this.bunifuTb_loginPassword.ReadOnly = false;
            this.bunifuTb_loginPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTb_loginPassword.SelectedText = "";
            this.bunifuTb_loginPassword.SelectionLength = 0;
            this.bunifuTb_loginPassword.SelectionStart = 0;
            this.bunifuTb_loginPassword.ShortcutsEnabled = true;
            this.bunifuTb_loginPassword.Size = new System.Drawing.Size(316, 34);
            this.bunifuTb_loginPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTb_loginPassword.TabIndex = 4;
            this.bunifuTb_loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTb_loginPassword.TextMarginBottom = 0;
            this.bunifuTb_loginPassword.TextMarginLeft = 3;
            this.bunifuTb_loginPassword.TextMarginTop = 1;
            this.bunifuTb_loginPassword.TextPlaceholder = "Enter account password !";
            this.bunifuTb_loginPassword.UseSystemPasswordChar = false;
            this.bunifuTb_loginPassword.WordWrap = true;
            // 
            // llbl_loginForgotAccount
            // 
            this.llbl_loginForgotAccount.AutoSize = true;
            this.llbl_loginForgotAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_loginForgotAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbl_loginForgotAccount.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_loginForgotAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbl_loginForgotAccount.Location = new System.Drawing.Point(8, 179);
            this.llbl_loginForgotAccount.Name = "llbl_loginForgotAccount";
            this.llbl_loginForgotAccount.Size = new System.Drawing.Size(316, 40);
            this.llbl_loginForgotAccount.TabIndex = 5;
            this.llbl_loginForgotAccount.TabStop = true;
            this.llbl_loginForgotAccount.Text = "Forgot Account / Password ?";
            this.llbl_loginForgotAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuBtn_login
            // 
            this.bunifuBtn_login.AllowAnimations = true;
            this.bunifuBtn_login.AllowMouseEffects = true;
            this.bunifuBtn_login.AllowToggling = false;
            this.bunifuBtn_login.AnimationSpeed = 200;
            this.bunifuBtn_login.AutoGenerateColors = false;
            this.bunifuBtn_login.AutoRoundBorders = true;
            this.bunifuBtn_login.AutoSizeLeftIcon = true;
            this.bunifuBtn_login.AutoSizeRightIcon = true;
            this.bunifuBtn_login.BackColor = System.Drawing.Color.Transparent;
            this.bunifuBtn_login.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuBtn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuBtn_login.BackgroundImage")));
            this.bunifuBtn_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuBtn_login.ButtonText = "Login";
            this.bunifuBtn_login.ButtonTextMarginLeft = 0;
            this.bunifuBtn_login.ColorContrastOnClick = 45;
            this.bunifuBtn_login.ColorContrastOnHover = 45;
            this.bunifuBtn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuBtn_login.CustomizableEdges = borderEdges1;
            this.bunifuBtn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuBtn_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuBtn_login.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuBtn_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuBtn_login.Font = new System.Drawing.Font("Pyidaungsu", 9.5F);
            this.bunifuBtn_login.ForeColor = System.Drawing.Color.White;
            this.bunifuBtn_login.IconLeft = null;
            this.bunifuBtn_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuBtn_login.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtn_login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuBtn_login.IconMarginLeft = 11;
            this.bunifuBtn_login.IconPadding = 10;
            this.bunifuBtn_login.IconRight = null;
            this.bunifuBtn_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuBtn_login.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtn_login.IconRightPadding = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.bunifuBtn_login.IconSize = 40;
            this.bunifuBtn_login.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.IdleBorderRadius = 0;
            this.bunifuBtn_login.IdleBorderThickness = 0;
            this.bunifuBtn_login.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.IdleIconLeftImage = null;
            this.bunifuBtn_login.IdleIconRightImage = null;
            this.bunifuBtn_login.IndicateFocus = false;
            this.bunifuBtn_login.Location = new System.Drawing.Point(8, 222);
            this.bunifuBtn_login.Name = "bunifuBtn_login";
            this.bunifuBtn_login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuBtn_login.OnDisabledState.BorderRadius = 34;
            this.bunifuBtn_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuBtn_login.OnDisabledState.BorderThickness = 1;
            this.bunifuBtn_login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuBtn_login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuBtn_login.OnDisabledState.IconLeftImage = null;
            this.bunifuBtn_login.OnDisabledState.IconRightImage = null;
            this.bunifuBtn_login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuBtn_login.onHoverState.BorderRadius = 34;
            this.bunifuBtn_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuBtn_login.onHoverState.BorderThickness = 1;
            this.bunifuBtn_login.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuBtn_login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuBtn_login.onHoverState.IconLeftImage = null;
            this.bunifuBtn_login.onHoverState.IconRightImage = null;
            this.bunifuBtn_login.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuBtn_login.OnIdleState.BorderRadius = 34;
            this.bunifuBtn_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuBtn_login.OnIdleState.BorderThickness = 1;
            this.bunifuBtn_login.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuBtn_login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuBtn_login.OnIdleState.IconLeftImage = null;
            this.bunifuBtn_login.OnIdleState.IconRightImage = null;
            this.bunifuBtn_login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuBtn_login.OnPressedState.BorderRadius = 34;
            this.bunifuBtn_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuBtn_login.OnPressedState.BorderThickness = 1;
            this.bunifuBtn_login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuBtn_login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuBtn_login.OnPressedState.IconLeftImage = null;
            this.bunifuBtn_login.OnPressedState.IconRightImage = null;
            this.bunifuBtn_login.Size = new System.Drawing.Size(316, 34);
            this.bunifuBtn_login.TabIndex = 6;
            this.bunifuBtn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtn_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuBtn_login.TextMarginLeft = 0;
            this.bunifuBtn_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuBtn_login.UseDefaultRadiusAndThickness = true;
            // 
            // pnl_loginLeft
            // 
            this.pnl_loginLeft.Controls.Add(this.pnl_loginTitle);
            this.pnl_loginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_loginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_loginLeft.Name = "pnl_loginLeft";
            this.pnl_loginLeft.Size = new System.Drawing.Size(296, 321);
            this.pnl_loginLeft.TabIndex = 0;
            // 
            // pnl_loginTitle
            // 
            this.pnl_loginTitle.Controls.Add(this.tlp_loginTitle);
            this.pnl_loginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_loginTitle.Location = new System.Drawing.Point(0, 0);
            this.pnl_loginTitle.Name = "pnl_loginTitle";
            this.pnl_loginTitle.Size = new System.Drawing.Size(296, 40);
            this.pnl_loginTitle.TabIndex = 0;
            // 
            // tlp_loginTitle
            // 
            this.tlp_loginTitle.ColumnCount = 4;
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_loginTitle.Controls.Add(this.lbl_loginLogo, 0, 0);
            this.tlp_loginTitle.Controls.Add(this.lbl_loginTitle, 1, 0);
            this.tlp_loginTitle.Controls.Add(this.bunifudropDown_loginLanguage, 2, 0);
            this.tlp_loginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginTitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_loginTitle.Name = "tlp_loginTitle";
            this.tlp_loginTitle.RowCount = 1;
            this.tlp_loginTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loginTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginTitle.Size = new System.Drawing.Size(296, 40);
            this.tlp_loginTitle.TabIndex = 0;
            // 
            // lbl_loginLogo
            // 
            this.lbl_loginLogo.AutoSize = true;
            this.lbl_loginLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginLogo.Image = global::mCloudB.Properties.Resources.eip_300_;
            this.lbl_loginLogo.Location = new System.Drawing.Point(3, 0);
            this.lbl_loginLogo.Name = "lbl_loginLogo";
            this.lbl_loginLogo.Size = new System.Drawing.Size(34, 40);
            this.lbl_loginLogo.TabIndex = 0;
            // 
            // lbl_loginTitle
            // 
            this.lbl_loginTitle.AutoSize = true;
            this.lbl_loginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginTitle.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginTitle.Location = new System.Drawing.Point(43, 0);
            this.lbl_loginTitle.Name = "lbl_loginTitle";
            this.lbl_loginTitle.Size = new System.Drawing.Size(122, 40);
            this.lbl_loginTitle.TabIndex = 1;
            this.lbl_loginTitle.Text = "mCloudB";
            this.lbl_loginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifudropDown_loginLanguage
            // 
            this.bunifudropDown_loginLanguage.BackColor = System.Drawing.Color.Transparent;
            this.bunifudropDown_loginLanguage.BackgroundColor = System.Drawing.Color.White;
            this.bunifudropDown_loginLanguage.BorderColor = System.Drawing.Color.Silver;
            this.bunifudropDown_loginLanguage.BorderRadius = 1;
            this.bunifudropDown_loginLanguage.Color = System.Drawing.Color.Silver;
            this.bunifudropDown_loginLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifudropDown_loginLanguage.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifudropDown_loginLanguage.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifudropDown_loginLanguage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifudropDown_loginLanguage.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifudropDown_loginLanguage.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifudropDown_loginLanguage.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifudropDown_loginLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifudropDown_loginLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifudropDown_loginLanguage.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifudropDown_loginLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifudropDown_loginLanguage.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifudropDown_loginLanguage.FillDropDown = true;
            this.bunifudropDown_loginLanguage.FillIndicator = false;
            this.bunifudropDown_loginLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifudropDown_loginLanguage.Font = new System.Drawing.Font("Pyidaungsu", 9F);
            this.bunifudropDown_loginLanguage.ForeColor = System.Drawing.Color.Black;
            this.bunifudropDown_loginLanguage.FormattingEnabled = true;
            this.bunifudropDown_loginLanguage.Icon = null;
            this.bunifudropDown_loginLanguage.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifudropDown_loginLanguage.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifudropDown_loginLanguage.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifudropDown_loginLanguage.IndicatorThickness = 2;
            this.bunifudropDown_loginLanguage.IsDropdownOpened = false;
            this.bunifudropDown_loginLanguage.ItemBackColor = System.Drawing.Color.White;
            this.bunifudropDown_loginLanguage.ItemBorderColor = System.Drawing.Color.White;
            this.bunifudropDown_loginLanguage.ItemForeColor = System.Drawing.Color.Black;
            this.bunifudropDown_loginLanguage.ItemHeight = 26;
            this.bunifudropDown_loginLanguage.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifudropDown_loginLanguage.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifudropDown_loginLanguage.ItemTopMargin = 3;
            this.bunifudropDown_loginLanguage.Location = new System.Drawing.Point(171, 3);
            this.bunifudropDown_loginLanguage.Name = "bunifudropDown_loginLanguage";
            this.bunifudropDown_loginLanguage.Size = new System.Drawing.Size(115, 32);
            this.bunifudropDown_loginLanguage.TabIndex = 2;
            this.bunifudropDown_loginLanguage.Text = null;
            this.bunifudropDown_loginLanguage.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifudropDown_loginLanguage.TextLeftMargin = 5;
            // 
            // uiLoginBody
            // 
            this.uiLoginBody.CornerRadius = 30;
            this.uiLoginBody.TargetControl = this.pnl_login;
            // 
            // tlp_loginSignUp
            // 
            this.tlp_loginSignUp.ColumnCount = 3;
            this.tlp_loginSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_loginSignUp.Controls.Add(this.lbl_loginSignUp, 0, 0);
            this.tlp_loginSignUp.Controls.Add(this.btn_loginSignUp, 1, 0);
            this.tlp_loginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginSignUp.Location = new System.Drawing.Point(8, 262);
            this.tlp_loginSignUp.Name = "tlp_loginSignUp";
            this.tlp_loginSignUp.RowCount = 1;
            this.tlp_loginSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_loginSignUp.Size = new System.Drawing.Size(316, 34);
            this.tlp_loginSignUp.TabIndex = 7;
            // 
            // lbl_loginSignUp
            // 
            this.lbl_loginSignUp.AutoSize = true;
            this.lbl_loginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginSignUp.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginSignUp.Location = new System.Drawing.Point(3, 0);
            this.lbl_loginSignUp.Name = "lbl_loginSignUp";
            this.lbl_loginSignUp.Size = new System.Drawing.Size(152, 34);
            this.lbl_loginSignUp.TabIndex = 0;
            this.lbl_loginSignUp.Text = "Do you haven\'t account ?";
            this.lbl_loginSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_loginSignUp
            // 
            this.btn_loginSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_loginSignUp.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginSignUp.Location = new System.Drawing.Point(160, 2);
            this.btn_loginSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_loginSignUp.Name = "btn_loginSignUp";
            this.btn_loginSignUp.Size = new System.Drawing.Size(154, 30);
            this.btn_loginSignUp.TabIndex = 1;
            this.btn_loginSignUp.Text = "Create New Account";
            this.btn_loginSignUp.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 327);
            this.Controls.Add(this.pnl_login);
            this.Font = new System.Drawing.Font("Pyidaungsu", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "frmLogin";
            this.pnl_login.ResumeLayout(false);
            this.pnl_loginData.ResumeLayout(false);
            this.tlp_loginData.ResumeLayout(false);
            this.tlp_loginData.PerformLayout();
            this.pnl_loginLeft.ResumeLayout(false);
            this.pnl_loginTitle.ResumeLayout(false);
            this.tlp_loginTitle.ResumeLayout(false);
            this.tlp_loginTitle.PerformLayout();
            this.tlp_loginSignUp.ResumeLayout(false);
            this.tlp_loginSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private services.api.ui uiLogin;
        private System.Windows.Forms.Panel pnl_login;
        private services.api.ui uiLoginBody;
        private System.Windows.Forms.Panel pnl_loginLeft;
        private System.Windows.Forms.Panel pnl_loginData;
        private System.Windows.Forms.Panel pnl_loginTitle;
        private System.Windows.Forms.TableLayoutPanel tlp_loginTitle;
        private System.Windows.Forms.Label lbl_loginLogo;
        private System.Windows.Forms.Label lbl_loginTitle;
        private Bunifu.UI.WinForms.BunifuDropdown bunifudropDown_loginLanguage;
        private System.Windows.Forms.TableLayoutPanel tlp_loginData;
        private System.Windows.Forms.Label lbl_loginWelcome;
        private System.Windows.Forms.Panel pnl_loginSk;
        private System.Windows.Forms.Label lbl_loginWelcomeText;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTb_loginUser;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTb_loginPassword;
        private System.Windows.Forms.LinkLabel llbl_loginForgotAccount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuBtn_login;
        private System.Windows.Forms.TableLayoutPanel tlp_loginSignUp;
        private System.Windows.Forms.Label lbl_loginSignUp;
        private System.Windows.Forms.Button btn_loginSignUp;
    }
}