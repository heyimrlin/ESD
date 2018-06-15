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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("设备分组列表");
            this.dgv_gwIP = new CCWin.SkinControl.SkinDataGridView();
            this.Col_SNID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_gwIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fanList = new CCWin.SkinControl.SkinDataGridView();
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
            this.cMenu_FanList = new CCWin.SkinControl.SkinContextMenuStrip();
            this.cMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenu_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_gw_toolbar = new CCWin.SkinControl.SkinPanel();
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
            this.panel_group = new CCWin.SkinControl.SkinPanel();
            this.lab_previous = new CCWin.SkinControl.SkinLabel();
            this.dgv_fanList_Group = new CCWin.SkinControl.SkinDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_gn_save = new CCWin.SkinControl.SkinButton();
            this.lab_groupName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.btn_del_group = new CCWin.SkinControl.SkinButton();
            this.btn_new_group = new CCWin.SkinControl.SkinButton();
            this.btn_back = new CCWin.SkinControl.SkinButton();
            this.tree_devices = new CCWin.SkinControl.SkinTreeView();
            this.cMenu_GroupFanList = new CCWin.SkinControl.SkinContextMenuStrip();
            this.cMenu_AddTo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_toolbar = new CCWin.SkinControl.SkinPanel();
            this.btn_SetAlarmV = new CCWin.SkinControl.SkinButton();
            this.num_alarmV = new CCWin.SkinControl.SkinNumericUpDown();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.btn_ACClose = new CCWin.SkinControl.SkinButton();
            this.btn_ACOpen = new CCWin.SkinControl.SkinButton();
            this.num_interval = new CCWin.SkinControl.SkinNumericUpDown();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gwIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList)).BeginInit();
            this.cMenu_FanList.SuspendLayout();
            this.panel_gw_toolbar.SuspendLayout();
            this.menu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.panel_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList_Group)).BeginInit();
            this.cMenu_GroupFanList.SuspendLayout();
            this.panel_toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alarmV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_gwIP
            // 
            this.dgv_gwIP.AllowUserToAddRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_gwIP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_gwIP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_gwIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_gwIP.ColumnFont = null;
            this.dgv_gwIP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_gwIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_gwIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gwIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_SNID,
            this.Col_gwIP});
            this.dgv_gwIP.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_gwIP.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_gwIP.EnableHeadersVisualStyles = false;
            this.dgv_gwIP.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_gwIP.HeadFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_gwIP.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_gwIP.Location = new System.Drawing.Point(12, 85);
            this.dgv_gwIP.Name = "dgv_gwIP";
            this.dgv_gwIP.ReadOnly = true;
            this.dgv_gwIP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_gwIP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_gwIP.RowsDefaultCellStyle = dataGridViewCellStyle43;
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col_SNID.DefaultCellStyle = dataGridViewCellStyle31;
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
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_fanList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgv_fanList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fanList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fanList.ColumnFont = null;
            this.dgv_fanList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle45.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fanList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
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
            this.Col_EndPoint});
            this.dgv_fanList.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.ContextMenuStrip = this.cMenu_FanList;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fanList.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgv_fanList.EnableHeadersVisualStyles = false;
            this.dgv_fanList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_fanList.HeadFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_fanList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.Location = new System.Drawing.Point(427, 85);
            this.dgv_fanList.Name = "dgv_fanList";
            this.dgv_fanList.ReadOnly = true;
            this.dgv_fanList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_fanList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList.RowsDefaultCellStyle = dataGridViewCellStyle47;
            this.dgv_fanList.RowTemplate.Height = 23;
            this.dgv_fanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fanList.Size = new System.Drawing.Size(861, 549);
            this.dgv_fanList.TabIndex = 44;
            this.dgv_fanList.TitleBack = null;
            this.dgv_fanList.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_fanList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // Col_FanID
            // 
            this.Col_FanID.DataPropertyName = "Device_ID";
            this.Col_FanID.HeaderText = "风机ID";
            this.Col_FanID.Name = "Col_FanID";
            this.Col_FanID.ReadOnly = true;
            this.Col_FanID.Width = 95;
            // 
            // Col_FanName
            // 
            this.Col_FanName.DataPropertyName = "Device_Name";
            this.Col_FanName.HeaderText = "设备名";
            this.Col_FanName.Name = "Col_FanName";
            this.Col_FanName.ReadOnly = true;
            this.Col_FanName.Width = 120;
            // 
            // Col_LinkState
            // 
            this.Col_LinkState.DataPropertyName = "State_Net";
            this.Col_LinkState.HeaderText = "联网状态";
            this.Col_LinkState.Name = "Col_LinkState";
            this.Col_LinkState.ReadOnly = true;
            this.Col_LinkState.Width = 112;
            // 
            // Col_PressureState
            // 
            this.Col_PressureState.DataPropertyName = "State_Pressure";
            this.Col_PressureState.HeaderText = "高压状态";
            this.Col_PressureState.Name = "Col_PressureState";
            this.Col_PressureState.ReadOnly = true;
            this.Col_PressureState.Width = 115;
            // 
            // Col_FanState
            // 
            this.Col_FanState.DataPropertyName = "State_Fan";
            this.Col_FanState.HeaderText = "风扇状态";
            this.Col_FanState.Name = "Col_FanState";
            this.Col_FanState.ReadOnly = true;
            this.Col_FanState.Width = 115;
            // 
            // Col_BalVoltage
            // 
            this.Col_BalVoltage.DataPropertyName = "Voltage_Balance";
            this.Col_BalVoltage.HeaderText = "平衡电压(V)";
            this.Col_BalVoltage.Name = "Col_BalVoltage";
            this.Col_BalVoltage.ReadOnly = true;
            // 
            // Col_PressureError
            // 
            this.Col_PressureError.DataPropertyName = "Error_Pressure";
            this.Col_PressureError.HeaderText = "高压异常";
            this.Col_PressureError.Name = "Col_PressureError";
            this.Col_PressureError.ReadOnly = true;
            this.Col_PressureError.Width = 80;
            // 
            // Col_FanError
            // 
            this.Col_FanError.DataPropertyName = "Error_Fan";
            this.Col_FanError.HeaderText = "风扇异常";
            this.Col_FanError.Name = "Col_FanError";
            this.Col_FanError.ReadOnly = true;
            this.Col_FanError.Width = 80;
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
            this.cMenu_Check,
            this.toolStripMenuItem2,
            this.cMenu_Group});
            this.cMenu_FanList.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_FanList.Name = "cMenu_FanList";
            this.cMenu_FanList.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_FanList.Size = new System.Drawing.Size(135, 82);
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
            this.cMenu_Delete.Size = new System.Drawing.Size(134, 24);
            this.cMenu_Delete.Text = "删除";
            this.cMenu_Delete.Click += new System.EventHandler(this.cMenu_Delete_Click);
            // 
            // cMenu_Check
            // 
            this.cMenu_Check.Name = "cMenu_Check";
            this.cMenu_Check.Size = new System.Drawing.Size(134, 24);
            this.cMenu_Check.Text = "查看";
            this.cMenu_Check.Click += new System.EventHandler(this.cMenu_Check_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 6);
            // 
            // cMenu_Group
            // 
            this.cMenu_Group.Name = "cMenu_Group";
            this.cMenu_Group.Size = new System.Drawing.Size(134, 24);
            this.cMenu_Group.Text = "分组操作";
            this.cMenu_Group.Click += new System.EventHandler(this.cMenu_Group_Click);
            // 
            // panel_gw_toolbar
            // 
            this.panel_gw_toolbar.BackColor = System.Drawing.Color.Transparent;
            this.panel_gw_toolbar.Controls.Add(this.btn_getDevices);
            this.panel_gw_toolbar.Controls.Add(this.btn_netPermit);
            this.panel_gw_toolbar.Controls.Add(this.lab_SNID);
            this.panel_gw_toolbar.Controls.Add(this.skinLabel5);
            this.panel_gw_toolbar.Controls.Add(this.btn_disconncet);
            this.panel_gw_toolbar.Controls.Add(this.lab_Fans);
            this.panel_gw_toolbar.Controls.Add(this.skinLabel6);
            this.panel_gw_toolbar.Controls.Add(this.lab_Connected);
            this.panel_gw_toolbar.Controls.Add(this.skinLabel4);
            this.panel_gw_toolbar.Controls.Add(this.lab_IP);
            this.panel_gw_toolbar.Controls.Add(this.skinLabel1);
            this.panel_gw_toolbar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_gw_toolbar.DownBack = null;
            this.panel_gw_toolbar.Location = new System.Drawing.Point(427, 31);
            this.panel_gw_toolbar.MouseBack = null;
            this.panel_gw_toolbar.Name = "panel_gw_toolbar";
            this.panel_gw_toolbar.NormlBack = null;
            this.panel_gw_toolbar.Size = new System.Drawing.Size(861, 53);
            this.panel_gw_toolbar.TabIndex = 45;
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
            this.menu_search.Size = new System.Drawing.Size(152, 24);
            this.menu_search.Text = "搜索设备";
            this.menu_search.Click += new System.EventHandler(this.menu_search_Click);
            // 
            // menu_stop
            // 
            this.menu_stop.Name = "menu_stop";
            this.menu_stop.Size = new System.Drawing.Size(152, 24);
            this.menu_stop.Text = "停止搜索";
            this.menu_stop.Click += new System.EventHandler(this.menu_stop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
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
            // panel_group
            // 
            this.panel_group.BackColor = System.Drawing.Color.Transparent;
            this.panel_group.BorderColor = System.Drawing.Color.Black;
            this.panel_group.Controls.Add(this.lab_previous);
            this.panel_group.Controls.Add(this.dgv_fanList_Group);
            this.panel_group.Controls.Add(this.btn_gn_save);
            this.panel_group.Controls.Add(this.lab_groupName);
            this.panel_group.Controls.Add(this.skinLabel3);
            this.panel_group.Controls.Add(this.btn_del_group);
            this.panel_group.Controls.Add(this.btn_new_group);
            this.panel_group.Controls.Add(this.btn_back);
            this.panel_group.Controls.Add(this.tree_devices);
            this.panel_group.Controls.Add(this.panel_toolbar);
            this.panel_group.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_group.DownBack = null;
            this.panel_group.Location = new System.Drawing.Point(427, 85);
            this.panel_group.MouseBack = null;
            this.panel_group.Name = "panel_group";
            this.panel_group.NormlBack = null;
            this.panel_group.Size = new System.Drawing.Size(861, 549);
            this.panel_group.TabIndex = 71;
            // 
            // lab_previous
            // 
            this.lab_previous.AutoSize = true;
            this.lab_previous.BackColor = System.Drawing.Color.Transparent;
            this.lab_previous.BorderColor = System.Drawing.Color.White;
            this.lab_previous.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_previous.Location = new System.Drawing.Point(693, 24);
            this.lab_previous.Name = "lab_previous";
            this.lab_previous.Size = new System.Drawing.Size(81, 17);
            this.lab_previous.TabIndex = 57;
            this.lab_previous.Text = "lab_previous";
            this.lab_previous.Visible = false;
            // 
            // dgv_fanList_Group
            // 
            this.dgv_fanList_Group.AllowUserToAddRows = false;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgv_fanList_Group.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dgv_fanList_Group.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fanList_Group.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fanList_Group.ColumnFont = null;
            this.dgv_fanList_Group.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fanList_Group.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgv_fanList_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fanList_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgv_fanList_Group.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList_Group.ContextMenuStrip = this.cMenu_FanList;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fanList_Group.DefaultCellStyle = dataGridViewCellStyle41;
            this.dgv_fanList_Group.EnableHeadersVisualStyles = false;
            this.dgv_fanList_Group.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_fanList_Group.HeadFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_fanList_Group.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList_Group.Location = new System.Drawing.Point(227, 52);
            this.dgv_fanList_Group.Name = "dgv_fanList_Group";
            this.dgv_fanList_Group.ReadOnly = true;
            this.dgv_fanList_Group.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_fanList_Group.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_fanList_Group.RowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dgv_fanList_Group.RowTemplate.Height = 23;
            this.dgv_fanList_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fanList_Group.Size = new System.Drawing.Size(628, 406);
            this.dgv_fanList_Group.TabIndex = 45;
            this.dgv_fanList_Group.TitleBack = null;
            this.dgv_fanList_Group.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgv_fanList_Group.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Device_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "风机ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Device_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "设备名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "State_Pressure";
            this.dataGridViewTextBoxColumn4.HeaderText = "高压状态";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State_Fan";
            this.dataGridViewTextBoxColumn5.HeaderText = "风扇状态";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Voltage_Balance";
            this.dataGridViewTextBoxColumn6.HeaderText = "平衡电压(V)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Address_Short";
            this.dataGridViewTextBoxColumn9.HeaderText = "短地址";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Address_IEEE";
            this.dataGridViewTextBoxColumn10.HeaderText = "IEEE地址";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "endpoint";
            this.dataGridViewTextBoxColumn11.HeaderText = "端口";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // btn_gn_save
            // 
            this.btn_gn_save.AutoSize = true;
            this.btn_gn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_gn_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_gn_save.DownBack = null;
            this.btn_gn_save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gn_save.Location = new System.Drawing.Point(635, 15);
            this.btn_gn_save.MouseBack = null;
            this.btn_gn_save.Name = "btn_gn_save";
            this.btn_gn_save.NormlBack = null;
            this.btn_gn_save.Size = new System.Drawing.Size(52, 31);
            this.btn_gn_save.TabIndex = 40;
            this.btn_gn_save.Text = "保存";
            this.btn_gn_save.UseVisualStyleBackColor = false;
            this.btn_gn_save.Click += new System.EventHandler(this.btn_gn_save_Click);
            // 
            // lab_groupName
            // 
            this.lab_groupName.BackColor = System.Drawing.Color.Transparent;
            this.lab_groupName.DownBack = null;
            this.lab_groupName.Icon = null;
            this.lab_groupName.IconIsButton = false;
            this.lab_groupName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.lab_groupName.IsPasswordChat = '\0';
            this.lab_groupName.IsSystemPasswordChar = false;
            this.lab_groupName.Lines = new string[0];
            this.lab_groupName.Location = new System.Drawing.Point(497, 17);
            this.lab_groupName.Margin = new System.Windows.Forms.Padding(0);
            this.lab_groupName.MaxLength = 32767;
            this.lab_groupName.MinimumSize = new System.Drawing.Size(28, 28);
            this.lab_groupName.MouseBack = null;
            this.lab_groupName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.lab_groupName.Multiline = false;
            this.lab_groupName.Name = "lab_groupName";
            this.lab_groupName.NormlBack = null;
            this.lab_groupName.Padding = new System.Windows.Forms.Padding(5);
            this.lab_groupName.ReadOnly = false;
            this.lab_groupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lab_groupName.Size = new System.Drawing.Size(125, 28);
            // 
            // 
            // 
            this.lab_groupName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lab_groupName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_groupName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.lab_groupName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.lab_groupName.SkinTxt.Name = "BaseText";
            this.lab_groupName.SkinTxt.Size = new System.Drawing.Size(115, 18);
            this.lab_groupName.SkinTxt.TabIndex = 0;
            this.lab_groupName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lab_groupName.SkinTxt.WaterText = "";
            this.lab_groupName.TabIndex = 39;
            this.lab_groupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lab_groupName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lab_groupName.WaterText = "";
            this.lab_groupName.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(442, 21);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(58, 21);
            this.skinLabel3.TabIndex = 11;
            this.skinLabel3.Text = "组名：";
            // 
            // btn_del_group
            // 
            this.btn_del_group.AutoSize = true;
            this.btn_del_group.BackColor = System.Drawing.Color.Transparent;
            this.btn_del_group.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_del_group.DownBack = null;
            this.btn_del_group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_del_group.Location = new System.Drawing.Point(320, 15);
            this.btn_del_group.MouseBack = null;
            this.btn_del_group.Name = "btn_del_group";
            this.btn_del_group.NormlBack = null;
            this.btn_del_group.Size = new System.Drawing.Size(84, 31);
            this.btn_del_group.TabIndex = 9;
            this.btn_del_group.Text = "删除分组";
            this.btn_del_group.UseVisualStyleBackColor = false;
            this.btn_del_group.Click += new System.EventHandler(this.btn_del_group_Click);
            // 
            // btn_new_group
            // 
            this.btn_new_group.AutoSize = true;
            this.btn_new_group.BackColor = System.Drawing.Color.Transparent;
            this.btn_new_group.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_new_group.DownBack = null;
            this.btn_new_group.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_new_group.Location = new System.Drawing.Point(230, 15);
            this.btn_new_group.MouseBack = null;
            this.btn_new_group.Name = "btn_new_group";
            this.btn_new_group.NormlBack = null;
            this.btn_new_group.Size = new System.Drawing.Size(84, 31);
            this.btn_new_group.TabIndex = 8;
            this.btn_new_group.Text = "新建分组";
            this.btn_new_group.UseVisualStyleBackColor = false;
            this.btn_new_group.Click += new System.EventHandler(this.btn_new_group_Click);
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_back.DownBack = null;
            this.btn_back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_back.Location = new System.Drawing.Point(800, 15);
            this.btn_back.MouseBack = null;
            this.btn_back.Name = "btn_back";
            this.btn_back.NormlBack = null;
            this.btn_back.Size = new System.Drawing.Size(52, 31);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tree_devices
            // 
            this.tree_devices.ContextMenuStrip = this.cMenu_GroupFanList;
            this.tree_devices.Location = new System.Drawing.Point(4, 5);
            this.tree_devices.Name = "tree_devices";
            treeNode1.Name = "节点0";
            treeNode1.Text = "设备分组列表";
            this.tree_devices.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tree_devices.Size = new System.Drawing.Size(222, 541);
            this.tree_devices.TabIndex = 0;
            this.tree_devices.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_devices_AfterSelect);
            // 
            // cMenu_GroupFanList
            // 
            this.cMenu_GroupFanList.Arrow = System.Drawing.Color.Black;
            this.cMenu_GroupFanList.Back = System.Drawing.Color.White;
            this.cMenu_GroupFanList.BackRadius = 4;
            this.cMenu_GroupFanList.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.cMenu_GroupFanList.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cMenu_GroupFanList.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.cMenu_GroupFanList.Fore = System.Drawing.Color.Black;
            this.cMenu_GroupFanList.HoverFore = System.Drawing.Color.White;
            this.cMenu_GroupFanList.ItemAnamorphosis = true;
            this.cMenu_GroupFanList.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_GroupFanList.ItemBorderShow = true;
            this.cMenu_GroupFanList.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_GroupFanList.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_GroupFanList.ItemRadius = 4;
            this.cMenu_GroupFanList.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_GroupFanList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_AddTo});
            this.cMenu_GroupFanList.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cMenu_GroupFanList.Name = "cMenu_GroupFanList";
            this.cMenu_GroupFanList.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_GroupFanList.Size = new System.Drawing.Size(158, 28);
            this.cMenu_GroupFanList.SkinAllColor = true;
            this.cMenu_GroupFanList.TitleAnamorphosis = true;
            this.cMenu_GroupFanList.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.cMenu_GroupFanList.TitleRadius = 4;
            this.cMenu_GroupFanList.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cMenu_GroupFanList.Opened += new System.EventHandler(this.cMenu_GroupFanList_Opened);
            // 
            // cMenu_AddTo
            // 
            this.cMenu_AddTo.Name = "cMenu_AddTo";
            this.cMenu_AddTo.Size = new System.Drawing.Size(157, 24);
            this.cMenu_AddTo.Text = "添加到分组...";
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.Color.Transparent;
            this.panel_toolbar.Controls.Add(this.btn_SetAlarmV);
            this.panel_toolbar.Controls.Add(this.num_alarmV);
            this.panel_toolbar.Controls.Add(this.skinLabel23);
            this.panel_toolbar.Controls.Add(this.skinLabel22);
            this.panel_toolbar.Controls.Add(this.btn_ACClose);
            this.panel_toolbar.Controls.Add(this.btn_ACOpen);
            this.panel_toolbar.Controls.Add(this.num_interval);
            this.panel_toolbar.Controls.Add(this.skinLabel21);
            this.panel_toolbar.Controls.Add(this.skinLabel20);
            this.panel_toolbar.Controls.Add(this.skinLabel18);
            this.panel_toolbar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_toolbar.DownBack = null;
            this.panel_toolbar.Location = new System.Drawing.Point(227, 464);
            this.panel_toolbar.MouseBack = null;
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.NormlBack = null;
            this.panel_toolbar.Size = new System.Drawing.Size(628, 82);
            this.panel_toolbar.TabIndex = 56;
            // 
            // btn_SetAlarmV
            // 
            this.btn_SetAlarmV.AutoSize = true;
            this.btn_SetAlarmV.BackColor = System.Drawing.Color.Transparent;
            this.btn_SetAlarmV.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_SetAlarmV.DownBack = null;
            this.btn_SetAlarmV.Location = new System.Drawing.Point(343, 3);
            this.btn_SetAlarmV.MouseBack = null;
            this.btn_SetAlarmV.Name = "btn_SetAlarmV";
            this.btn_SetAlarmV.NormlBack = null;
            this.btn_SetAlarmV.Size = new System.Drawing.Size(60, 35);
            this.btn_SetAlarmV.TabIndex = 65;
            this.btn_SetAlarmV.Text = "设置";
            this.btn_SetAlarmV.UseVisualStyleBackColor = false;
            this.btn_SetAlarmV.Click += new System.EventHandler(this.btn_SetAlarmV_Click);
            // 
            // num_alarmV
            // 
            this.num_alarmV.Location = new System.Drawing.Point(252, 4);
            this.num_alarmV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_alarmV.Name = "num_alarmV";
            this.num_alarmV.Size = new System.Drawing.Size(56, 33);
            this.num_alarmV.TabIndex = 63;
            this.num_alarmV.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // skinLabel23
            // 
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel23.Location = new System.Drawing.Point(307, 8);
            this.skinLabel23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(37, 25);
            this.skinLabel23.TabIndex = 64;
            this.skinLabel23.Text = "(V)";
            // 
            // skinLabel22
            // 
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.Location = new System.Drawing.Point(128, 8);
            this.skinLabel22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(107, 25);
            this.skinLabel22.TabIndex = 62;
            this.skinLabel22.Text = "报警电压：";
            // 
            // btn_ACClose
            // 
            this.btn_ACClose.AutoSize = true;
            this.btn_ACClose.BackColor = System.Drawing.Color.Transparent;
            this.btn_ACClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ACClose.DownBack = null;
            this.btn_ACClose.Location = new System.Drawing.Point(479, 45);
            this.btn_ACClose.MouseBack = null;
            this.btn_ACClose.Name = "btn_ACClose";
            this.btn_ACClose.NormlBack = null;
            this.btn_ACClose.Size = new System.Drawing.Size(60, 35);
            this.btn_ACClose.TabIndex = 61;
            this.btn_ACClose.Text = "关闭";
            this.btn_ACClose.UseVisualStyleBackColor = false;
            this.btn_ACClose.Click += new System.EventHandler(this.btn_ACClose_Click);
            // 
            // btn_ACOpen
            // 
            this.btn_ACOpen.AutoSize = true;
            this.btn_ACOpen.BackColor = System.Drawing.Color.Transparent;
            this.btn_ACOpen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ACOpen.DownBack = null;
            this.btn_ACOpen.Location = new System.Drawing.Point(408, 45);
            this.btn_ACOpen.MouseBack = null;
            this.btn_ACOpen.Name = "btn_ACOpen";
            this.btn_ACOpen.NormlBack = null;
            this.btn_ACOpen.Size = new System.Drawing.Size(60, 35);
            this.btn_ACOpen.TabIndex = 60;
            this.btn_ACOpen.Text = "开启";
            this.btn_ACOpen.UseVisualStyleBackColor = false;
            this.btn_ACOpen.Click += new System.EventHandler(this.btn_ACOpen_Click);
            // 
            // num_interval
            // 
            this.num_interval.Location = new System.Drawing.Point(294, 46);
            this.num_interval.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.num_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_interval.Name = "num_interval";
            this.num_interval.Size = new System.Drawing.Size(56, 33);
            this.num_interval.TabIndex = 56;
            this.num_interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // skinLabel21
            // 
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel21.Location = new System.Drawing.Point(353, 50);
            this.skinLabel21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(50, 25);
            this.skinLabel21.TabIndex = 59;
            this.skinLabel21.Text = "小时";
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.Location = new System.Drawing.Point(247, 50);
            this.skinLabel20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(50, 25);
            this.skinLabel20.TabIndex = 58;
            this.skinLabel20.Text = "每隔";
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.Location = new System.Drawing.Point(90, 50);
            this.skinLabel18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(145, 25);
            this.skinLabel18.TabIndex = 57;
            this.skinLabel18.Text = "自动清洁周期：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1300, 661);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.panel_gw_toolbar);
            this.Controls.Add(this.dgv_gwIP);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dgv_fanList);
            this.Controls.Add(this.panel_group);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Management System 1.1.1_20180615_Release";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gwIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList)).EndInit();
            this.cMenu_FanList.ResumeLayout(false);
            this.panel_gw_toolbar.ResumeLayout(false);
            this.panel_gw_toolbar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.panel_group.ResumeLayout(false);
            this.panel_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fanList_Group)).EndInit();
            this.cMenu_GroupFanList.ResumeLayout(false);
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alarmV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgv_gwIP;
        private CCWin.SkinControl.SkinDataGridView dgv_fanList;
        private CCWin.SkinControl.SkinPanel panel_gw_toolbar;
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cMenu_Group;
        private CCWin.SkinControl.SkinPanel panel_group;
        private CCWin.SkinControl.SkinTreeView tree_devices;
        private CCWin.SkinControl.SkinButton btn_back;
        private CCWin.SkinControl.SkinButton btn_new_group;
        private CCWin.SkinControl.SkinButton btn_del_group;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox lab_groupName;
        private CCWin.SkinControl.SkinButton btn_gn_save;
        private CCWin.SkinControl.SkinDataGridView dgv_fanList_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private CCWin.SkinControl.SkinPanel panel_toolbar;
        private CCWin.SkinControl.SkinButton btn_SetAlarmV;
        private CCWin.SkinControl.SkinNumericUpDown num_alarmV;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinButton btn_ACClose;
        private CCWin.SkinControl.SkinButton btn_ACOpen;
        private CCWin.SkinControl.SkinNumericUpDown num_interval;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel lab_previous;
        private CCWin.SkinControl.SkinContextMenuStrip cMenu_GroupFanList;
        private System.Windows.Forms.ToolStripMenuItem cMenu_AddTo;
    }
}

