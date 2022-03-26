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
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pnl_loginData = new System.Windows.Forms.Panel();
            this.tlp_loginData = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuTb_loginUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuTb_loginUserPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.llbl_loginForgotPassword = new System.Windows.Forms.LinkLabel();
            this.bunifuBtn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnl_loginTitle = new System.Windows.Forms.Panel();
            this.tlp_loginTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginTitle = new System.Windows.Forms.Label();
            this.lbl_loginTitleLogo = new System.Windows.Forms.Label();
            this.bunifuCbox_loginLanguage = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_loginClose = new System.Windows.Forms.Button();
            this.tlp_loginSignup = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_loginSignUp = new System.Windows.Forms.Label();
            this.llbl_loginSignUp = new System.Windows.Forms.LinkLabel();
            this.uiLogin = new mCloudB.services.api.ui();
            this.uiLoginBody = new mCloudB.services.api.ui();
            this.pnl_login.SuspendLayout();
            this.pnl_loginData.SuspendLayout();
            this.tlp_loginData.SuspendLayout();
            this.pnl_loginTitle.SuspendLayout();
            this.tlp_loginTitle.SuspendLayout();
            this.tlp_loginSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_login.Controls.Add(this.pnl_loginData);
            this.pnl_login.Controls.Add(this.pnl_loginTitle);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_login.Location = new System.Drawing.Point(3, 3);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(374, 245);
            this.pnl_login.TabIndex = 0;
            // 
            // pnl_loginData
            // 
            this.pnl_loginData.Controls.Add(this.tlp_loginData);
            this.pnl_loginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_loginData.Location = new System.Drawing.Point(0, 38);
            this.pnl_loginData.Name = "pnl_loginData";
            this.pnl_loginData.Size = new System.Drawing.Size(374, 207);
            this.pnl_loginData.TabIndex = 1;
            // 
            // tlp_loginData
            // 
            this.tlp_loginData.ColumnCount = 2;
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_loginData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_loginData.Controls.Add(this.bunifuTb_loginUser, 0, 1);
            this.tlp_loginData.Controls.Add(this.bunifuTb_loginUserPassword, 0, 2);
            this.tlp_loginData.Controls.Add(this.llbl_loginForgotPassword, 0, 3);
            this.tlp_loginData.Controls.Add(this.bunifuBtn_login, 0, 4);
            this.tlp_loginData.Controls.Add(this.tlp_loginSignup, 0, 5);
            this.tlp_loginData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginData.Location = new System.Drawing.Point(0, 0);
            this.tlp_loginData.Name = "tlp_loginData";
            this.tlp_loginData.RowCount = 7;
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_loginData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_loginData.Size = new System.Drawing.Size(374, 207);
            this.tlp_loginData.TabIndex = 0;
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
            this.bunifuTb_loginUser.Location = new System.Drawing.Point(3, 13);
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
            this.bunifuTb_loginUser.PlaceholderText = "Enter User Account / Email";
            this.bunifuTb_loginUser.ReadOnly = false;
            this.bunifuTb_loginUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTb_loginUser.SelectedText = "";
            this.bunifuTb_loginUser.SelectionLength = 0;
            this.bunifuTb_loginUser.SelectionStart = 0;
            this.bunifuTb_loginUser.ShortcutsEnabled = true;
            this.bunifuTb_loginUser.Size = new System.Drawing.Size(368, 32);
            this.bunifuTb_loginUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTb_loginUser.TabIndex = 0;
            this.bunifuTb_loginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTb_loginUser.TextMarginBottom = 0;
            this.bunifuTb_loginUser.TextMarginLeft = 3;
            this.bunifuTb_loginUser.TextMarginTop = 1;
            this.bunifuTb_loginUser.TextPlaceholder = "Enter User Account / Email";
            this.bunifuTb_loginUser.UseSystemPasswordChar = false;
            this.bunifuTb_loginUser.WordWrap = true;
            // 
            // bunifuTb_loginUserPassword
            // 
            this.bunifuTb_loginUserPassword.AcceptsReturn = false;
            this.bunifuTb_loginUserPassword.AcceptsTab = false;
            this.bunifuTb_loginUserPassword.AnimationSpeed = 200;
            this.bunifuTb_loginUserPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTb_loginUserPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTb_loginUserPassword.AutoSizeHeight = true;
            this.bunifuTb_loginUserPassword.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTb_loginUserPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTb_loginUserPassword.BackgroundImage")));
            this.bunifuTb_loginUserPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTb_loginUserPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTb_loginUserPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTb_loginUserPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTb_loginUserPassword.BorderRadius = 15;
            this.bunifuTb_loginUserPassword.BorderThickness = 1;
            this.bunifuTb_loginUserPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTb_loginUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginUserPassword.DefaultFont = new System.Drawing.Font("Pyidaungsu", 9.5F);
            this.bunifuTb_loginUserPassword.DefaultText = "";
            this.bunifuTb_loginUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuTb_loginUserPassword.FillColor = System.Drawing.Color.White;
            this.bunifuTb_loginUserPassword.HideSelection = true;
            this.bunifuTb_loginUserPassword.IconLeft = global::mCloudB.Properties.Resources.password_24px;
            this.bunifuTb_loginUserPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTb_loginUserPassword.IconPadding = 5;
            this.bunifuTb_loginUserPassword.IconRight = global::mCloudB.Properties.Resources.closed_eye_24px;
            this.bunifuTb_loginUserPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTb_loginUserPassword.Lines = new string[0];
            this.bunifuTb_loginUserPassword.Location = new System.Drawing.Point(3, 51);
            this.bunifuTb_loginUserPassword.MaxLength = 32767;
            this.bunifuTb_loginUserPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTb_loginUserPassword.Modified = false;
            this.bunifuTb_loginUserPassword.Multiline = false;
            this.bunifuTb_loginUserPassword.Name = "bunifuTb_loginUserPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUserPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTb_loginUserPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUserPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTb_loginUserPassword.OnIdleState = stateProperties8;
            this.bunifuTb_loginUserPassword.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTb_loginUserPassword.PasswordChar = '\0';
            this.bunifuTb_loginUserPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTb_loginUserPassword.PlaceholderText = "Enter Account Password";
            this.bunifuTb_loginUserPassword.ReadOnly = false;
            this.bunifuTb_loginUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTb_loginUserPassword.SelectedText = "";
            this.bunifuTb_loginUserPassword.SelectionLength = 0;
            this.bunifuTb_loginUserPassword.SelectionStart = 0;
            this.bunifuTb_loginUserPassword.ShortcutsEnabled = true;
            this.bunifuTb_loginUserPassword.Size = new System.Drawing.Size(368, 32);
            this.bunifuTb_loginUserPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTb_loginUserPassword.TabIndex = 1;
            this.bunifuTb_loginUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTb_loginUserPassword.TextMarginBottom = 0;
            this.bunifuTb_loginUserPassword.TextMarginLeft = 3;
            this.bunifuTb_loginUserPassword.TextMarginTop = 1;
            this.bunifuTb_loginUserPassword.TextPlaceholder = "Enter Account Password";
            this.bunifuTb_loginUserPassword.UseSystemPasswordChar = false;
            this.bunifuTb_loginUserPassword.WordWrap = true;
            // 
            // llbl_loginForgotPassword
            // 
            this.llbl_loginForgotPassword.AutoSize = true;
            this.llbl_loginForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_loginForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbl_loginForgotPassword.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_loginForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbl_loginForgotPassword.Location = new System.Drawing.Point(3, 86);
            this.llbl_loginForgotPassword.Name = "llbl_loginForgotPassword";
            this.llbl_loginForgotPassword.Size = new System.Drawing.Size(368, 38);
            this.llbl_loginForgotPassword.TabIndex = 2;
            this.llbl_loginForgotPassword.TabStop = true;
            this.llbl_loginForgotPassword.Text = "Forgot Account Password ?";
            this.llbl_loginForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.bunifuBtn_login.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Bold);
            this.bunifuBtn_login.ForeColor = System.Drawing.Color.White;
            this.bunifuBtn_login.IconLeft = null;
            this.bunifuBtn_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuBtn_login.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtn_login.IconLeftPadding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.bunifuBtn_login.IconMarginLeft = 11;
            this.bunifuBtn_login.IconPadding = 5;
            this.bunifuBtn_login.IconRight = null;
            this.bunifuBtn_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuBtn_login.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuBtn_login.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.bunifuBtn_login.IconSize = 25;
            this.bunifuBtn_login.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.IdleBorderRadius = 0;
            this.bunifuBtn_login.IdleBorderThickness = 0;
            this.bunifuBtn_login.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuBtn_login.IdleIconLeftImage = null;
            this.bunifuBtn_login.IdleIconRightImage = null;
            this.bunifuBtn_login.IndicateFocus = false;
            this.bunifuBtn_login.Location = new System.Drawing.Point(3, 127);
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
            this.bunifuBtn_login.Size = new System.Drawing.Size(368, 34);
            this.bunifuBtn_login.TabIndex = 3;
            this.bunifuBtn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuBtn_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuBtn_login.TextMarginLeft = 0;
            this.bunifuBtn_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuBtn_login.UseDefaultRadiusAndThickness = true;
            // 
            // pnl_loginTitle
            // 
            this.pnl_loginTitle.Controls.Add(this.tlp_loginTitle);
            this.pnl_loginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_loginTitle.Location = new System.Drawing.Point(0, 0);
            this.pnl_loginTitle.Name = "pnl_loginTitle";
            this.pnl_loginTitle.Size = new System.Drawing.Size(374, 38);
            this.pnl_loginTitle.TabIndex = 0;
            // 
            // tlp_loginTitle
            // 
            this.tlp_loginTitle.AutoSize = true;
            this.tlp_loginTitle.ColumnCount = 6;
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlp_loginTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_loginTitle.Controls.Add(this.lbl_loginTitle, 1, 0);
            this.tlp_loginTitle.Controls.Add(this.lbl_loginTitleLogo, 0, 0);
            this.tlp_loginTitle.Controls.Add(this.bunifuCbox_loginLanguage, 2, 0);
            this.tlp_loginTitle.Controls.Add(this.btn_loginClose, 3, 0);
            this.tlp_loginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginTitle.Location = new System.Drawing.Point(0, 0);
            this.tlp_loginTitle.Name = "tlp_loginTitle";
            this.tlp_loginTitle.RowCount = 1;
            this.tlp_loginTitle.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_loginTitle.Size = new System.Drawing.Size(374, 38);
            this.tlp_loginTitle.TabIndex = 0;
            // 
            // lbl_loginTitle
            // 
            this.lbl_loginTitle.AutoSize = true;
            this.lbl_loginTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginTitle.Font = new System.Drawing.Font("Pyidaungsu", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_loginTitle.Location = new System.Drawing.Point(40, 0);
            this.lbl_loginTitle.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_loginTitle.Name = "lbl_loginTitle";
            this.lbl_loginTitle.Size = new System.Drawing.Size(120, 38);
            this.lbl_loginTitle.TabIndex = 0;
            this.lbl_loginTitle.Text = "mCloudB";
            this.lbl_loginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_loginTitleLogo
            // 
            this.lbl_loginTitleLogo.AutoSize = true;
            this.lbl_loginTitleLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginTitleLogo.Image = global::mCloudB.Properties.Resources.mcloudb100;
            this.lbl_loginTitleLogo.Location = new System.Drawing.Point(0, 0);
            this.lbl_loginTitleLogo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbl_loginTitleLogo.Name = "lbl_loginTitleLogo";
            this.lbl_loginTitleLogo.Size = new System.Drawing.Size(37, 38);
            this.lbl_loginTitleLogo.TabIndex = 1;
            // 
            // bunifuCbox_loginLanguage
            // 
            this.bunifuCbox_loginLanguage.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCbox_loginLanguage.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCbox_loginLanguage.BorderColor = System.Drawing.Color.Silver;
            this.bunifuCbox_loginLanguage.BorderRadius = 1;
            this.bunifuCbox_loginLanguage.Color = System.Drawing.Color.Silver;
            this.bunifuCbox_loginLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCbox_loginLanguage.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuCbox_loginLanguage.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuCbox_loginLanguage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuCbox_loginLanguage.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuCbox_loginLanguage.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuCbox_loginLanguage.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuCbox_loginLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCbox_loginLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuCbox_loginLanguage.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuCbox_loginLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuCbox_loginLanguage.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuCbox_loginLanguage.FillDropDown = true;
            this.bunifuCbox_loginLanguage.FillIndicator = false;
            this.bunifuCbox_loginLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCbox_loginLanguage.Font = new System.Drawing.Font("Pyidaungsu", 9.5F);
            this.bunifuCbox_loginLanguage.ForeColor = System.Drawing.Color.Black;
            this.bunifuCbox_loginLanguage.FormattingEnabled = true;
            this.bunifuCbox_loginLanguage.Icon = null;
            this.bunifuCbox_loginLanguage.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuCbox_loginLanguage.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuCbox_loginLanguage.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuCbox_loginLanguage.IndicatorThickness = 2;
            this.bunifuCbox_loginLanguage.IsDropdownOpened = false;
            this.bunifuCbox_loginLanguage.ItemBackColor = System.Drawing.Color.White;
            this.bunifuCbox_loginLanguage.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuCbox_loginLanguage.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuCbox_loginLanguage.ItemHeight = 26;
            this.bunifuCbox_loginLanguage.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCbox_loginLanguage.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuCbox_loginLanguage.ItemTopMargin = 3;
            this.bunifuCbox_loginLanguage.Location = new System.Drawing.Point(166, 3);
            this.bunifuCbox_loginLanguage.Name = "bunifuCbox_loginLanguage";
            this.bunifuCbox_loginLanguage.Size = new System.Drawing.Size(159, 32);
            this.bunifuCbox_loginLanguage.TabIndex = 2;
            this.bunifuCbox_loginLanguage.Text = null;
            this.bunifuCbox_loginLanguage.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuCbox_loginLanguage.TextLeftMargin = 5;
            // 
            // btn_loginClose
            // 
            this.btn_loginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_loginClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_loginClose.FlatAppearance.BorderSize = 0;
            this.btn_loginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginClose.Image = global::mCloudB.Properties.Resources.Close_24px;
            this.btn_loginClose.Location = new System.Drawing.Point(331, 3);
            this.btn_loginClose.Name = "btn_loginClose";
            this.btn_loginClose.Size = new System.Drawing.Size(34, 32);
            this.btn_loginClose.TabIndex = 3;
            this.btn_loginClose.UseVisualStyleBackColor = true;
            this.btn_loginClose.Click += new System.EventHandler(this.btn_loginClose_Click);
            // 
            // tlp_loginSignup
            // 
            this.tlp_loginSignup.ColumnCount = 2;
            this.tlp_loginSignup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginSignup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_loginSignup.Controls.Add(this.lbl_loginSignUp, 0, 0);
            this.tlp_loginSignup.Controls.Add(this.llbl_loginSignUp, 1, 0);
            this.tlp_loginSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_loginSignup.Location = new System.Drawing.Point(3, 167);
            this.tlp_loginSignup.Name = "tlp_loginSignup";
            this.tlp_loginSignup.RowCount = 1;
            this.tlp_loginSignup.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_loginSignup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_loginSignup.Size = new System.Drawing.Size(368, 32);
            this.tlp_loginSignup.TabIndex = 4;
            // 
            // lbl_loginSignUp
            // 
            this.lbl_loginSignUp.AutoSize = true;
            this.lbl_loginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loginSignUp.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginSignUp.Location = new System.Drawing.Point(3, 0);
            this.lbl_loginSignUp.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_loginSignUp.Name = "lbl_loginSignUp";
            this.lbl_loginSignUp.Size = new System.Drawing.Size(181, 32);
            this.lbl_loginSignUp.TabIndex = 0;
            this.lbl_loginSignUp.Text = "Have no an account ?";
            this.lbl_loginSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // llbl_loginSignUp
            // 
            this.llbl_loginSignUp.AutoSize = true;
            this.llbl_loginSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_loginSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbl_loginSignUp.Font = new System.Drawing.Font("Pyidaungsu", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_loginSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbl_loginSignUp.Location = new System.Drawing.Point(184, 0);
            this.llbl_loginSignUp.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.llbl_loginSignUp.Name = "llbl_loginSignUp";
            this.llbl_loginSignUp.Size = new System.Drawing.Size(181, 32);
            this.llbl_loginSignUp.TabIndex = 1;
            this.llbl_loginSignUp.TabStop = true;
            this.llbl_loginSignUp.Text = "Create New Account";
            this.llbl_loginSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLogin
            // 
            this.uiLogin.CornerRadius = 30;
            this.uiLogin.TargetControl = this;
            // 
            // uiLoginBody
            // 
            this.uiLoginBody.CornerRadius = 30;
            this.uiLoginBody.TargetControl = this.pnl_login;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 251);
            this.Controls.Add(this.pnl_login);
            this.Font = new System.Drawing.Font("Pyidaungsu", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.pnl_login.ResumeLayout(false);
            this.pnl_loginData.ResumeLayout(false);
            this.tlp_loginData.ResumeLayout(false);
            this.tlp_loginData.PerformLayout();
            this.pnl_loginTitle.ResumeLayout(false);
            this.pnl_loginTitle.PerformLayout();
            this.tlp_loginTitle.ResumeLayout(false);
            this.tlp_loginTitle.PerformLayout();
            this.tlp_loginSignup.ResumeLayout(false);
            this.tlp_loginSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private services.api.ui uiLogin;
        private services.api.ui uiLoginBody;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_loginTitle;
        private System.Windows.Forms.TableLayoutPanel tlp_loginTitle;
        private System.Windows.Forms.Label lbl_loginTitle;
        private System.Windows.Forms.Label lbl_loginTitleLogo;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuCbox_loginLanguage;
        private System.Windows.Forms.Button btn_loginClose;
        private System.Windows.Forms.Panel pnl_loginData;
        private System.Windows.Forms.TableLayoutPanel tlp_loginData;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTb_loginUser;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTb_loginUserPassword;
        private System.Windows.Forms.LinkLabel llbl_loginForgotPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuBtn_login;
        private System.Windows.Forms.TableLayoutPanel tlp_loginSignup;
        private System.Windows.Forms.Label lbl_loginSignUp;
        private System.Windows.Forms.LinkLabel llbl_loginSignUp;
    }
}