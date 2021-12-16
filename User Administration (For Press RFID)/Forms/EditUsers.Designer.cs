
namespace User_Administration__For_Press_RFID_.Forms
{
    partial class EditUsers
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
            this.lbUsersList = new System.Windows.Forms.ListBox();
            this.btnClearParameters = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblTextUserList = new System.Windows.Forms.Label();
            this.tbSearchUser = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextPersonalID = new System.Windows.Forms.Label();
            this.lblTextFirstName = new System.Windows.Forms.Label();
            this.lblTextLastName = new System.Windows.Forms.Label();
            this.tbPersonalID = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.rdbNewRFIDID = new System.Windows.Forms.RadioButton();
            this.rdbOldRFIDID = new System.Windows.Forms.RadioButton();
            this.p0 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextRFIDID = new System.Windows.Forms.Label();
            this.tbRFIDID = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPermissionGroupList = new System.Windows.Forms.ListBox();
            this.lblTextPermissionGroupList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActualUserGroup = new System.Windows.Forms.Label();
            this.lblTextActualUserGroup = new System.Windows.Forms.Label();
            this.tlp0 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbNewUserPermGroup = new System.Windows.Forms.RadioButton();
            this.rdbOldUserPermGroup = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.p0.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.p2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp0.SuspendLayout();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsersList
            // 
            this.lbUsersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsersList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsersList.ForeColor = System.Drawing.Color.White;
            this.lbUsersList.FormattingEnabled = true;
            this.lbUsersList.ItemHeight = 20;
            this.lbUsersList.Location = new System.Drawing.Point(0, 57);
            this.lbUsersList.Name = "lbUsersList";
            this.lbUsersList.Size = new System.Drawing.Size(416, 280);
            this.lbUsersList.TabIndex = 33;
            this.lbUsersList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbUsersList_MouseDoubleClick);
            // 
            // btnClearParameters
            // 
            this.btnClearParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearParameters.FlatAppearance.BorderSize = 0;
            this.btnClearParameters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnClearParameters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearParameters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearParameters.ForeColor = System.Drawing.Color.White;
            this.btnClearParameters.Location = new System.Drawing.Point(3, 240);
            this.btnClearParameters.Name = "btnClearParameters";
            this.btnClearParameters.Size = new System.Drawing.Size(185, 50);
            this.btnClearParameters.TabIndex = 35;
            this.btnClearParameters.Text = "Clear Parameters";
            this.btnClearParameters.UseVisualStyleBackColor = false;
            this.btnClearParameters.Click += new System.EventHandler(this.btnClearParameters_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveUser.FlatAppearance.BorderSize = 0;
            this.btnSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Location = new System.Drawing.Point(236, 240);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(185, 50);
            this.btnSaveUser.TabIndex = 34;
            this.btnSaveUser.Text = "Add to Database";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblTextUserList
            // 
            this.lblTextUserList.AutoSize = true;
            this.lblTextUserList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextUserList.ForeColor = System.Drawing.Color.White;
            this.lblTextUserList.Location = new System.Drawing.Point(0, 3);
            this.lblTextUserList.Name = "lblTextUserList";
            this.lblTextUserList.Size = new System.Drawing.Size(77, 20);
            this.lblTextUserList.TabIndex = 43;
            this.lblTextUserList.Text = "Users List";
            // 
            // tbSearchUser
            // 
            this.tbSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchUser.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchUser.Location = new System.Drawing.Point(0, 26);
            this.tbSearchUser.Name = "tbSearchUser";
            this.tbSearchUser.Size = new System.Drawing.Size(383, 23);
            this.tbSearchUser.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(389, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSearch.Size = new System.Drawing.Size(27, 23);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTextPersonalID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextFirstName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTextLastName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPersonalID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rdbNewRFIDID, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.rdbOldRFIDID, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 345);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.274026F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 221);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // lblTextPersonalID
            // 
            this.lblTextPersonalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPersonalID.AutoSize = true;
            this.lblTextPersonalID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPersonalID.ForeColor = System.Drawing.Color.White;
            this.lblTextPersonalID.Location = new System.Drawing.Point(3, 5);
            this.lblTextPersonalID.Name = "lblTextPersonalID";
            this.lblTextPersonalID.Size = new System.Drawing.Size(89, 20);
            this.lblTextPersonalID.TabIndex = 3;
            this.lblTextPersonalID.Text = "Personal ID";
            // 
            // lblTextFirstName
            // 
            this.lblTextFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextFirstName.AutoSize = true;
            this.lblTextFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextFirstName.ForeColor = System.Drawing.Color.White;
            this.lblTextFirstName.Location = new System.Drawing.Point(3, 55);
            this.lblTextFirstName.Name = "lblTextFirstName";
            this.lblTextFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblTextFirstName.TabIndex = 4;
            this.lblTextFirstName.Text = "First Name";
            // 
            // lblTextLastName
            // 
            this.lblTextLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextLastName.AutoSize = true;
            this.lblTextLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextLastName.ForeColor = System.Drawing.Color.White;
            this.lblTextLastName.Location = new System.Drawing.Point(3, 105);
            this.lblTextLastName.Name = "lblTextLastName";
            this.lblTextLastName.Size = new System.Drawing.Size(84, 20);
            this.lblTextLastName.TabIndex = 5;
            this.lblTextLastName.Text = "Last Name";
            // 
            // tbPersonalID
            // 
            this.tbPersonalID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPersonalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPersonalID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPersonalID.ForeColor = System.Drawing.Color.White;
            this.tbPersonalID.Location = new System.Drawing.Point(3, 28);
            this.tbPersonalID.Name = "tbPersonalID";
            this.tbPersonalID.Size = new System.Drawing.Size(411, 20);
            this.tbPersonalID.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(3, 78);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(411, 20);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.Location = new System.Drawing.Point(3, 128);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(411, 20);
            this.tbLastName.TabIndex = 8;
            // 
            // rdbNewRFIDID
            // 
            this.rdbNewRFIDID.AutoSize = true;
            this.rdbNewRFIDID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbNewRFIDID.ForeColor = System.Drawing.Color.White;
            this.rdbNewRFIDID.Location = new System.Drawing.Point(3, 192);
            this.rdbNewRFIDID.Name = "rdbNewRFIDID";
            this.rdbNewRFIDID.Size = new System.Drawing.Size(104, 21);
            this.rdbNewRFIDID.TabIndex = 14;
            this.rdbNewRFIDID.TabStop = true;
            this.rdbNewRFIDID.Text = "New RFID ID";
            this.rdbNewRFIDID.UseVisualStyleBackColor = true;
            this.rdbNewRFIDID.CheckedChanged += new System.EventHandler(this.rbdPasswordSel_CheckedChanged);
            // 
            // rdbOldRFIDID
            // 
            this.rdbOldRFIDID.AutoSize = true;
            this.rdbOldRFIDID.Checked = true;
            this.rdbOldRFIDID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbOldRFIDID.ForeColor = System.Drawing.Color.White;
            this.rdbOldRFIDID.Location = new System.Drawing.Point(3, 167);
            this.rdbOldRFIDID.Name = "rdbOldRFIDID";
            this.rdbOldRFIDID.Size = new System.Drawing.Size(99, 19);
            this.rdbOldRFIDID.TabIndex = 13;
            this.rdbOldRFIDID.TabStop = true;
            this.rdbOldRFIDID.Text = "Old RFID ID";
            this.rdbOldRFIDID.UseVisualStyleBackColor = true;
            this.rdbOldRFIDID.CheckedChanged += new System.EventHandler(this.rbdPasswordSel_CheckedChanged);
            // 
            // p0
            // 
            this.p0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p0.Controls.Add(this.lbUsersList);
            this.p0.Controls.Add(this.lblTextUserList);
            this.p0.Controls.Add(this.tbSearchUser);
            this.p0.Controls.Add(this.tableLayoutPanel1);
            this.p0.Controls.Add(this.btnSearch);
            this.p0.Location = new System.Drawing.Point(13, 3);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(416, 565);
            this.p0.TabIndex = 49;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblTextRFIDID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbRFIDID, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632188F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.632189F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 46);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // lblTextRFIDID
            // 
            this.lblTextRFIDID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextRFIDID.AutoSize = true;
            this.lblTextRFIDID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextRFIDID.ForeColor = System.Drawing.Color.White;
            this.lblTextRFIDID.Location = new System.Drawing.Point(3, 2);
            this.lblTextRFIDID.Name = "lblTextRFIDID";
            this.lblTextRFIDID.Size = new System.Drawing.Size(99, 20);
            this.lblTextRFIDID.TabIndex = 9;
            this.lblTextRFIDID.Text = "Card RFID ID";
            // 
            // tbRFIDID
            // 
            this.tbRFIDID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbRFIDID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRFIDID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRFIDID.ForeColor = System.Drawing.Color.White;
            this.tbRFIDID.Location = new System.Drawing.Point(3, 25);
            this.tbRFIDID.Name = "tbRFIDID";
            this.tbRFIDID.Size = new System.Drawing.Size(410, 20);
            this.tbRFIDID.TabIndex = 11;
            // 
            // p2
            // 
            this.p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p2.Controls.Add(this.tableLayoutPanel3);
            this.p2.Controls.Add(this.btnSaveUser);
            this.p2.Controls.Add(this.btnClearParameters);
            this.p2.Location = new System.Drawing.Point(9, 3);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(424, 293);
            this.p2.TabIndex = 51;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbPermissionGroupList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTextPermissionGroupList, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.438819F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.56118F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(424, 234);
            this.tableLayoutPanel3.TabIndex = 37;
            // 
            // lbPermissionGroupList
            // 
            this.lbPermissionGroupList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPermissionGroupList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPermissionGroupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPermissionGroupList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPermissionGroupList.ForeColor = System.Drawing.Color.White;
            this.lbPermissionGroupList.FormattingEnabled = true;
            this.lbPermissionGroupList.ItemHeight = 20;
            this.lbPermissionGroupList.Location = new System.Drawing.Point(3, 22);
            this.lbPermissionGroupList.Name = "lbPermissionGroupList";
            this.lbPermissionGroupList.Size = new System.Drawing.Size(418, 209);
            this.lbPermissionGroupList.TabIndex = 23;
            // 
            // lblTextPermissionGroupList
            // 
            this.lblTextPermissionGroupList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextPermissionGroupList.AutoSize = true;
            this.lblTextPermissionGroupList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextPermissionGroupList.ForeColor = System.Drawing.Color.White;
            this.lblTextPermissionGroupList.Location = new System.Drawing.Point(3, 0);
            this.lblTextPermissionGroupList.Name = "lblTextPermissionGroupList";
            this.lblTextPermissionGroupList.Size = new System.Drawing.Size(163, 19);
            this.lblTextPermissionGroupList.TabIndex = 22;
            this.lblTextPermissionGroupList.Text = "Permission Group List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActualUserGroup);
            this.panel1.Controls.Add(this.lblTextActualUserGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 25);
            this.panel1.TabIndex = 36;
            // 
            // lblActualUserGroup
            // 
            this.lblActualUserGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblActualUserGroup.AutoSize = true;
            this.lblActualUserGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActualUserGroup.ForeColor = System.Drawing.Color.White;
            this.lblActualUserGroup.Location = new System.Drawing.Point(234, 3);
            this.lblActualUserGroup.Name = "lblActualUserGroup";
            this.lblActualUserGroup.Size = new System.Drawing.Size(69, 20);
            this.lblActualUserGroup.TabIndex = 8;
            this.lblActualUserGroup.Text = "XXXXXX";
            // 
            // lblTextActualUserGroup
            // 
            this.lblTextActualUserGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTextActualUserGroup.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextActualUserGroup.ForeColor = System.Drawing.Color.White;
            this.lblTextActualUserGroup.Location = new System.Drawing.Point(12, 3);
            this.lblTextActualUserGroup.Name = "lblTextActualUserGroup";
            this.lblTextActualUserGroup.Size = new System.Drawing.Size(216, 20);
            this.lblTextActualUserGroup.TabIndex = 7;
            this.lblTextActualUserGroup.Text = "Actual User Group:";
            this.lblTextActualUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp0
            // 
            this.tlp0.ColumnCount = 1;
            this.tlp0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp0.Controls.Add(this.p0, 0, 0);
            this.tlp0.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp0.Location = new System.Drawing.Point(0, 0);
            this.tlp0.Name = "tlp0";
            this.tlp0.RowCount = 1;
            this.tlp0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp0.Size = new System.Drawing.Size(443, 571);
            this.tlp0.TabIndex = 52;
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp1.Location = new System.Drawing.Point(0, 571);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Size = new System.Drawing.Size(443, 52);
            this.tlp1.TabIndex = 53;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Controls.Add(this.p2, 0, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp2.Location = new System.Drawing.Point(0, 706);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Size = new System.Drawing.Size(443, 299);
            this.tlp2.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 648);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 58);
            this.panel2.TabIndex = 55;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.rdbNewUserPermGroup, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.rdbOldUserPermGroup, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(287, 55);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rdbNewUserPermGroup
            // 
            this.rdbNewUserPermGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbNewUserPermGroup.AutoSize = true;
            this.rdbNewUserPermGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbNewUserPermGroup.ForeColor = System.Drawing.Color.White;
            this.rdbNewUserPermGroup.Location = new System.Drawing.Point(3, 30);
            this.rdbNewUserPermGroup.Name = "rdbNewUserPermGroup";
            this.rdbNewUserPermGroup.Size = new System.Drawing.Size(198, 21);
            this.rdbNewUserPermGroup.TabIndex = 15;
            this.rdbNewUserPermGroup.Text = "New Permission User Group";
            this.rdbNewUserPermGroup.UseVisualStyleBackColor = true;
            // 
            // rdbOldUserPermGroup
            // 
            this.rdbOldUserPermGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbOldUserPermGroup.AutoSize = true;
            this.rdbOldUserPermGroup.Checked = true;
            this.rdbOldUserPermGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbOldUserPermGroup.ForeColor = System.Drawing.Color.White;
            this.rdbOldUserPermGroup.Location = new System.Drawing.Point(3, 3);
            this.rdbOldUserPermGroup.Name = "rdbOldUserPermGroup";
            this.rdbOldUserPermGroup.Size = new System.Drawing.Size(193, 21);
            this.rdbOldUserPermGroup.TabIndex = 14;
            this.rdbOldUserPermGroup.TabStop = true;
            this.rdbOldUserPermGroup.Text = "Old Permission User Group";
            this.rdbOldUserPermGroup.UseVisualStyleBackColor = true;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(443, 1009);
            this.Controls.Add(this.tlp2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlp1);
            this.Controls.Add(this.tlp0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Users";
            this.VisibleChanged += new System.EventHandler(this.EditUsers_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.p0.ResumeLayout(false);
            this.p0.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.p2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlp0.ResumeLayout(false);
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbUsersList;
        private System.Windows.Forms.Button btnClearParameters;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblTextUserList;
        private System.Windows.Forms.TextBox tbSearchUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTextPersonalID;
        private System.Windows.Forms.Label lblTextFirstName;
        private System.Windows.Forms.Label lblTextLastName;
        private System.Windows.Forms.TextBox tbPersonalID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.RadioButton rdbNewRFIDID;
        private System.Windows.Forms.RadioButton rdbOldRFIDID;
        private System.Windows.Forms.Panel p0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTextRFIDID;
        private System.Windows.Forms.TextBox tbRFIDID;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.TableLayoutPanel tlp0;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActualUserGroup;
        private System.Windows.Forms.Label lblTextActualUserGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox lbPermissionGroupList;
        private System.Windows.Forms.Label lblTextPermissionGroupList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rdbNewUserPermGroup;
        private System.Windows.Forms.RadioButton rdbOldUserPermGroup;
    }
}