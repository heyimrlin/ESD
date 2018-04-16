namespace ESD
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgv_gwIP = new CCWin.SkinControl.SkinDataGridView();
            this.Col_SNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_gwIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fanList = new CCWin.SkinControl.SkinDataGridView();
            this.cMenu_FanList = new CCWin.SkinControl.SkinContextMenuStrip();
            this.cMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.btn_getDevices = new CCWin.SkinControl.SkinButton();
            this.btn_netPermit = new CCWin.SkinControl.SkinButton();
            this.lab_SNID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.btn_disconncet = new CCWin.SkinControl.SkinButton();
            this.lab_Fans = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.lab_Connected = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.lab_IP = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.menu = new CCWin.SkinControl.SkinMenuStrip();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_search = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.sb_tips0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb_tips1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_sbTips = new System.Windows.Forms.Timer(this.components);
            this.Timer_RefreshIPList = new System.Windows.Forms.Timer(this.components);
            this.Timer_Search = new System.Windows.Forms.Timer(this.components);
            this.Timer_Received = new System.Windows.Forms.Timer(this.components);
            this.Col_FanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LinkState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PressureState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FanState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_BalVoltage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PressureError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FanError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_ShortAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IEEEAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_EndPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Refresh = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gwIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList)).BeginInit();
            this.cMenu_FanList.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_gwIP
            // 
            this.dgv_gwIP.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_gwIP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_gwIP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_gwIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_gwIP.ColumnFont = null;
            this.dgv_gwIP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gwIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_gwIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gwIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_SNID,
            this.Col_gwIP});
            this.dgv_gwIP.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_gwIP.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_gwIP.EnableHeadersVisualStyles = false;
            this.dgv_gwIP.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_gwIP.HeadFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_gwIP.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_gwIP.Location = new System.Drawing.Point(12, 85);
            this.dgv_gwIP.Name = "dgv_gwIP";
            this.dgv_gwIP.ReadOnly = true;
            this.dgv_gwIP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_gwIP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_gwIP.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_gwIP.RowTemplate.Height = 23;
            this.dgv_gwIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_gwIP.Size = new System.Drawing.Size(415, 549);
            this.dgv_gwIP.TabIndex = 43;
            this.dgv_gwIP.TitleBack = null;
            this.dgv_gwIP.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_gwIP.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgv_gwIP.DoubleClick += new System.EventHandler(this.dgv_gwIP_DoubleClick);
            this.dgv_gwIP.MouseEnter += new System.EventHandler(this.dgv_gwIP_MouseEnter);
            // 
            // Col_SNID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_SNID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Col_SNID.HeaderText = "网关设备SNID";
            this.Col_SNID.Name = "Col_SNID";
            this.Col_SNID.ReadOnly = true;
            this.Col_SNID.Width = 160;
            // 
            // Col_gwIP
            // 
            this.Col_gwIP.HeaderText = "网关设备IP地址";
            this.Col_gwIP.Name = "Col_gwIP";
            this.Col_gwIP.ReadOnly = true;
            this.Col_gwIP.Width = 210;
            // 
            // dgv_fanList
            // 
            this.dgv_fanList.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_fanList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_fanList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fanList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fanList.ColumnFont = null;
            this.dgv_fanList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fanList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_fanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_FanID,
            this.Col_FanName,
            this.Col_LinkState,
            this.Col_PressureState,
            this.Col_FanState,
            this.Col_BalVoltage,
            this.Col_PressureError,
            this.Col_FanError,
            this.Col_ShortAddress,
            this.Col_IEEEAddress,
            this.Col_EndPoint,
            this.Col_Refresh});
            this.dgv_fanList.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.ContextMenuStrip = this.cMenu_FanList;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fanList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_fanList.EnableHeadersVisualStyles = false;
            this.dgv_fanList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_fanList.HeadFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_fanList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.Location = new System.Drawing.Point(427, 85);
            this.dgv_fanList.Name = "dgv_fanList";
            this.dgv_fanList.ReadOnly = true;
            this.dgv_fanList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_fanList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_fanList.RowTemplate.Height = 23;
            this.dgv_fanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fanList.Size = new System.Drawing.Size(861, 549);
            this.dgv_fanList.TabIndex = 44;
            this.dgv_fanList.TitleBack = null;
            this.dgv_fanList.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_fanList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // cMenu_FanList
            // 
            this.cMenu_FanList.Arrow = System.Drawing.Color.Black;
            this.cMenu_FanList.Back = System.Drawing.Color.White;
            this.cMenu_FanList.BackRadius = 4;
            this.cMenu_FanList.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.cMenu_FanList.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cMenu_FanList.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cMenu_FanList.Fore = System.Drawing.Color.Black;
            this.cMenu_FanList.HoverFore = System.Drawing.Color.White;
            this.cMenu_FanList.ItemAnamorphosis = true;
            this.cMenu_FanList.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_FanList.ItemBorderShow = true;
            this.cMenu_FanList.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_FanList.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_FanList.ItemRadius = 4;
            this.cMenu_FanList.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_FanList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_Delete,
            this.cMenu_Check});
            this.cMenu_FanList.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_FanList.Name = "cMenu_FanList";
            this.cMenu_FanList.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_FanList.Size = new System.Drawing.Size(107, 52);
            this.cMenu_FanList.SkinAllColor = true;
            this.cMenu_FanList.TitleAnamorphosis = true;
            this.cMenu_FanList.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.cMenu_FanList.TitleRadius = 4;
            this.cMenu_FanList.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_FanList.Opened += new System.EventHandler(this.cMenu_FanList_Opened);
            // 
            // cMenu_Delete
            // 
            this.cMenu_Delete.Name = "cMenu_Delete";
            this.cMenu_Delete.Size = new System.Drawing.Size(106, 24);
            this.cMenu_Delete.Text = "删除";
            this.cMenu_Delete.Click += new System.EventHandler(this.cMenu_Delete_Click);
            // 
            // cMenu_Check
            // 
            this.cMenu_Check.Name = "cMenu_Check";
            this.cMenu_Check.Size = new System.Drawing.Size(106, 24);
            this.cMenu_Check.Text = "查看";
            this.cMenu_Check.Click += new System.EventHandler(this.cMenu_Check_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.btn_getDevices);
            this.skinPanel1.Controls.Add(this.btn_netPermit);
            this.skinPanel1.Controls.Add(this.lab_SNID);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.btn_disconncet);
            this.skinPanel1.Controls.Add(this.lab_Fans);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.lab_Connected);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.lab_IP);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(427, 31);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(861, 53);
            this.skinPanel1.TabIndex = 45;
            // 
            // btn_getDevices
            // 
            this.btn_getDevices.AutoSize = true;
            this.btn_getDevices.BackColor = System.Drawing.Color.Transparent;
            this.btn_getDevices.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_getDevices.DownBack = null;
            this.btn_getDevices.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getDevices.Location = new System.Drawing.Point(624, 19);
            this.btn_getDevices.MouseBack = null;
            this.btn_getDevices.Name = "btn_getDevices";
            this.btn_getDevices.NormlBack = null;
            this.btn_getDevices.Size = new System.Drawing.Size(84, 31);
            this.btn_getDevices.TabIndex = 10;
            this.btn_getDevices.Text = "获取设备";
            this.btn_getDevices.UseVisualStyleBackColor = false;
            this.btn_getDevices.Click += new System.EventHandler(this.btn_getDevices_Click);
            // 
            // btn_netPermit
            // 
            this.btn_netPermit.AutoSize = true;
            this.btn_netPermit.BackColor = System.Drawing.Color.Transparent;
            this.btn_netPermit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_netPermit.DownBack = null;
            this.btn_netPermit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_netPermit.Location = new System.Drawing.Point(714, 19);
            this.btn_netPermit.MouseBack = null;
            this.btn_netPermit.Name = "btn_netPermit";
            this.btn_netPermit.NormlBack = null;
            this.btn_netPermit.Size = new System.Drawing.Size(84, 31);
            this.btn_netPermit.TabIndex = 9;
            this.btn_netPermit.Text = "允许入网";
            this.btn_netPermit.UseVisualStyleBackColor = false;
            this.btn_netPermit.Click += new System.EventHandler(this.btn_netPermit_Click);
            // 
            // lab_SNID
            // 
            this.lab_SNID.AutoSize = true;
            this.lab_SNID.BackColor = System.Drawing.Color.Transparent;
            this.lab_SNID.BorderColor = System.Drawing.Color.White;
            this.lab_SNID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_SNID.ForeColor = System.Drawing.Color.Blue;
            this.lab_SNID.Location = new System.Drawing.Point(67, 3);
            this.lab_SNID.Name = "lab_SNID";
            this.lab_SNID.Size = new System.Drawing.Size(82, 21);
            this.lab_SNID.TabIndex = 8;
            this.lab_SNID.Text = "11223344";
            this.lab_SNID.Visible = false;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(4, 3);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(65, 21);
            this.skinLabel5.TabIndex = 7;
            this.skinLabel5.Text = "SNID：";
            this.skinLabel5.Visible = false;
            // 
            // btn_disconncet
            // 
            this.btn_disconncet.AutoSize = true;
            this.btn_disconncet.BackColor = System.Drawing.Color.Transparent;
            this.btn_disconncet.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_disconncet.DownBack = null;
            this.btn_disconncet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_disconncet.Location = new System.Drawing.Point(804, 19);
            this.btn_disconncet.MouseBack = null;
            this.btn_disconncet.Name = "btn_disconncet";
            this.btn_disconncet.NormlBack = null;
            this.btn_disconncet.Size = new System.Drawing.Size(52, 31);
            this.btn_disconncet.TabIndex = 6;
            this.btn_disconncet.Text = "断开";
            this.btn_disconncet.UseVisualStyleBackColor = false;
            this.btn_disconncet.Click += new System.EventHandler(this.btn_disconncet_Click);
            // 
            // lab_Fans
            // 
            this.lab_Fans.AutoSize = true;
            this.lab_Fans.BackColor = System.Drawing.Color.Transparent;
            this.lab_Fans.BorderColor = System.Drawing.Color.White;
            this.lab_Fans.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Fans.ForeColor = System.Drawing.Color.Blue;
            this.lab_Fans.Location = new System.Drawing.Point(441, 24);
            this.lab_Fans.Name = "lab_Fans";
            this.lab_Fans.Size = new System.Drawing.Size(37, 21);
            this.lab_Fans.TabIndex = 5;
            this.lab_Fans.Text = "999";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(375, 24);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(74, 21);
            this.skinLabel6.TabIndex = 4;
            this.skinLabel6.Text = "风机数：";
            // 
            // lab_Connected
            // 
            this.lab_Connected.AutoSize = true;
            this.lab_Connected.BackColor = System.Drawing.Color.Transparent;
            this.lab_Connected.BorderColor = System.Drawing.Color.White;
            this.lab_Connected.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Connected.ForeColor = System.Drawing.Color.Red;
            this.lab_Connected.Location = new System.Drawing.Point(543, 24);
            this.lab_Connected.Name = "lab_Connected";
            this.lab_Connected.Size = new System.Drawing.Size(58, 21);
            this.lab_Connected.TabIndex = 3;
            this.lab_Connected.Text = "已连接";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(493, 24);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(58, 21);
            this.skinLabel4.TabIndex = 2;
            this.skinLabel4.Text = "状态：";
            // 
            // lab_IP
            // 
            this.lab_IP.AutoSize = true;
            this.lab_IP.BackColor = System.Drawing.Color.Transparent;
            this.lab_IP.BorderColor = System.Drawing.Color.White;
            this.lab_IP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_IP.ForeColor = System.Drawing.Color.Red;
            this.lab_IP.Location = new System.Drawing.Point(136, 24);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(130, 21);
            this.lab_IP.TabIndex = 1;
            this.lab_IP.Text = "255.255.255.255";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 24);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(137, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "当前网关设备IP：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(12, 55);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(74, 21);
            this.skinLabel2.TabIndex = 46;
            this.skinLabel2.Text = "在线列表";
            // 
            // menu
            // 
            this.menu.Arrow = System.Drawing.Color.Black;
            this.menu.Back = System.Drawing.Color.White;
            this.menu.BackRadius = 4;
            this.menu.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.menu.Base = System.Drawing.Color.LightCyan;
            this.menu.BaseFore = System.Drawing.Color.Black;
            this.menu.BaseForeAnamorphosis = false;
            this.menu.BaseForeAnamorphosisBorder = 4;
            this.menu.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.menu.BaseHoverFore = System.Drawing.Color.White;
            this.menu.BaseItemAnamorphosis = true;
            this.menu.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.BaseItemBorderShow = true;
            this.menu.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("menu.BaseItemDown")));
            this.menu.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("menu.BaseItemMouse")));
            this.menu.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.BaseItemRadius = 4;
            this.menu.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.menu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu.Fore = System.Drawing.Color.Black;
            this.menu.GripMargin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.HoverFore = System.Drawing.Color.White;
            this.menu.ItemAnamorphosis = true;
            this.menu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemBorderShow = true;
            this.menu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu.ItemRadius = 4;
            this.menu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu.Size = new System.Drawing.Size(1300, 28);
            this.menu.SkinAllColor = true;
            this.menu.TabIndex = 47;
            this.menu.Text = "skinMenuStrip1";
            this.menu.TitleAnamorphosis = true;
            this.menu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.menu.TitleRadius = 4;
            this.menu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_search,
            this.menu_stop,
            this.toolStripMenuItem1});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // menu_search
            // 
            this.menu_search.Enabled = false;
            this.menu_search.Name = "menu_search";
            this.menu_search.Size = new System.Drawing.Size(134, 24);
            this.menu_search.Text = "搜索设备";
            this.menu_search.Click += new System.EventHandler(this.menu_search_Click);
            // 
            // menu_stop
            // 
            this.menu_stop.Name = "menu_stop";
            this.menu_stop.Size = new System.Drawing.Size(134, 24);
            this.menu_stop.Text = "停止搜索";
            this.menu_stop.Click += new System.EventHandler(this.menu_stop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_tips0,
            this.sb_tips1});
            this.StatusBar.Location = new System.Drawing.Point(0, 639);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1300, 22);
            this.StatusBar.TabIndex = 70;
            // 
            // sb_tips0
            // 
            this.sb_tips0.AutoToolTip = true;
            this.sb_tips0.BackColor = System.Drawing.Color.White;
            this.sb_tips0.Name = "sb_tips0";
            this.sb_tips0.Size = new System.Drawing.Size(0, 17);
            // 
            // sb_tips1
            // 
            this.sb_tips1.BackColor = System.Drawing.Color.White;
            this.sb_tips1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sb_tips1.Name = "sb_tips1";
            this.sb_tips1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sb_tips1.Size = new System.Drawing.Size(4, 17);
            // 
            // Timer_sbTips
            // 
            this.Timer_sbTips.Enabled = true;
            this.Timer_sbTips.Tick += new System.EventHandler(this.Timer_sbTips_Tick);
            // 
            // Timer_RefreshIPList
            // 
            this.Timer_RefreshIPList.Enabled = true;
            this.Timer_RefreshIPList.Interval = 1000;
            this.Timer_RefreshIPList.Tick += new System.EventHandler(this.Timer_RefreshIPList_Tick);
            // 
            // Timer_Search
            // 
            this.Timer_Search.Enabled = true;
            this.Timer_Search.Interval = 180000;
            this.Timer_Search.Tick += new System.EventHandler(this.Timer_Search_Tick);
            // 
            // Timer_Received
            // 
            this.Timer_Received.Tick += new System.EventHandler(this.Timer_Received_Tick);
            // 
            // Col_FanID
            // 
            this.Col_FanID.DataPropertyName = "Device_ID";
            this.Col_FanID.HeaderText = "风机ID";
            this.Col_FanID.Name = "Col_FanID";
            this.Col_FanID.ReadOnly = true;
            // 
            // Col_FanName
            // 
            this.Col_FanName.DataPropertyName = "Device_Name";
            this.Col_FanName.HeaderText = "风机设备名";
            this.Col_FanName.Name = "Col_FanName";
            this.Col_FanName.ReadOnly = true;
            this.Col_FanName.Width = 150;
            // 
            // Col_LinkState
            // 
            this.Col_LinkState.DataPropertyName = "State_Net";
            this.Col_LinkState.HeaderText = "联网状态";
            this.Col_LinkState.Name = "Col_LinkState";
            this.Col_LinkState.ReadOnly = true;
            this.Col_LinkState.Width = 120;
            // 
            // Col_PressureState
            // 
            this.Col_PressureState.DataPropertyName = "State_Pressure";
            this.Col_PressureState.HeaderText = "高压状态";
            this.Col_PressureState.Name = "Col_PressureState";
            this.Col_PressureState.ReadOnly = true;
            this.Col_PressureState.Width = 120;
            // 
            // Col_FanState
            // 
            this.Col_FanState.DataPropertyName = "State_Fan";
            this.Col_FanState.HeaderText = "风扇状态";
            this.Col_FanState.Name = "Col_FanState";
            this.Col_FanState.ReadOnly = true;
            this.Col_FanState.Width = 120;
            // 
            // Col_BalVoltage
            // 
            this.Col_BalVoltage.DataPropertyName = "Voltage_Balance";
            this.Col_BalVoltage.HeaderText = "平衡电压";
            this.Col_BalVoltage.Name = "Col_BalVoltage";
            this.Col_BalVoltage.ReadOnly = true;
            this.Col_BalVoltage.Width = 180;
            // 
            // Col_PressureError
            // 
            this.Col_PressureError.DataPropertyName = "Error_Pressure";
            this.Col_PressureError.HeaderText = "高压异常";
            this.Col_PressureError.Name = "Col_PressureError";
            this.Col_PressureError.ReadOnly = true;
            this.Col_PressureError.Width = 120;
            // 
            // Col_FanError
            // 
            this.Col_FanError.DataPropertyName = "Error_Fan";
            this.Col_FanError.HeaderText = "风扇异常";
            this.Col_FanError.Name = "Col_FanError";
            this.Col_FanError.ReadOnly = true;
            this.Col_FanError.Width = 120;
            // 
            // Col_ShortAddress
            // 
            this.Col_ShortAddress.DataPropertyName = "Address_Short";
            this.Col_ShortAddress.HeaderText = "短地址";
            this.Col_ShortAddress.Name = "Col_ShortAddress";
            this.Col_ShortAddress.ReadOnly = true;
            this.Col_ShortAddress.Visible = false;
            // 
            // Col_IEEEAddress
            // 
            this.Col_IEEEAddress.DataPropertyName = "Address_IEEE";
            this.Col_IEEEAddress.HeaderText = "IEEE地址";
            this.Col_IEEEAddress.Name = "Col_IEEEAddress";
            this.Col_IEEEAddress.ReadOnly = true;
            this.Col_IEEEAddress.Visible = false;
            // 
            // Col_EndPoint
            // 
            this.Col_EndPoint.DataPropertyName = "endpoint";
            this.Col_EndPoint.HeaderText = "端口";
            this.Col_EndPoint.Name = "Col_EndPoint";
            this.Col_EndPoint.ReadOnly = true;
            this.Col_EndPoint.Visible = false;
            // 
            // Col_Refresh
            // 
            this.Col_Refresh.HeaderText = "操作";
            this.Col_Refresh.Name = "Col_Refresh";
            this.Col_Refresh.ReadOnly = true;
            this.Col_Refresh.Text = "刷新";
            this.Col_Refresh.Width = 120;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1300, 661);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.dgv_fanList);
            this.Controls.Add(this.dgv_gwIP);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Management System 1.0.0_20180416_Base";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gwIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList)).EndInit();
            this.cMenu_FanList.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgv_gwIP;
        private CCWin.SkinControl.SkinDataGridView dgv_fanList;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel lab_IP;
        private CCWin.SkinControl.SkinLabel lab_Fans;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel lab_Connected;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton btn_disconncet;
        private CCWin.SkinControl.SkinMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_search;
        private System.Windows.Forms.ToolStripMenuItem menu_stop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        public System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel sb_tips0;
        private System.Windows.Forms.ToolStripStatusLabel sb_tips1;
        private System.Windows.Forms.Timer Timer_sbTips;
        private System.Windows.Forms.Timer Timer_RefreshIPList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SNID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_gwIP;
        private System.Windows.Forms.Timer Timer_Search;
        private System.Windows.Forms.Timer Timer_Received;
        private CCWin.SkinControl.SkinLabel lab_SNID;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinButton btn_netPermit;
        private CCWin.SkinControl.SkinButton btn_getDevices;
        private CCWin.SkinControl.SkinContextMenuStrip cMenu_FanList;
        private System.Windows.Forms.ToolStripMenuItem cMenu_Delete;
        private System.Windows.Forms.ToolStripMenuItem cMenu_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LinkState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PressureState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FanState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_BalVoltage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PressureError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FanError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ShortAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IEEEAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_EndPoint;
        private System.Windows.Forms.DataGridViewButtonColumn Col_Refresh;
    }
}

