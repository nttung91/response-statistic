namespace ResponeTimeStatistic
{
    partial class Demo
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnResponseTimeAvg = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblNumberOfRequest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tctMain = new System.Windows.Forms.TabControl();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudMaxThread = new System.Windows.Forms.NumericUpDown();
            this.nudFirstDelay = new System.Windows.Forms.NumericUpDown();
            this.nudRamupTime = new System.Windows.Forms.NumericUpDown();
            this.nudLevelDuration = new System.Windows.Forms.NumericUpDown();
            this.nudThreadIncrement = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tpGraph = new System.Windows.Forms.TabPage();
            this.cboRequestTag = new System.Windows.Forms.ComboBox();
            this.fad = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnErrorPercent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tctMain.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRamupTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadIncrement)).BeginInit();
            this.tpGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(432, 43);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(87, 29);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Nạp Dữ Liệu";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(28, 46);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(395, 23);
            this.txtPath.TabIndex = 1;
            // 
            // btnResponseTimeAvg
            // 
            this.btnResponseTimeAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponseTimeAvg.Location = new System.Drawing.Point(24, 553);
            this.btnResponseTimeAvg.Name = "btnResponseTimeAvg";
            this.btnResponseTimeAvg.Size = new System.Drawing.Size(156, 38);
            this.btnResponseTimeAvg.TabIndex = 5;
            this.btnResponseTimeAvg.Text = "Thời gian đáp ứng";
            this.btnResponseTimeAvg.UseVisualStyleBackColor = true;
            this.btnResponseTimeAvg.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsEnableHPan = false;
            this.zedGraphControl1.IsEnableHZoom = false;
            this.zedGraphControl1.IsEnableVZoom = false;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(18, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "0.000";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(755, 277);
            this.zedGraphControl1.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(721, 555);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 37);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Xoá  Đồ Thị";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đánh giá khả năng đáp ứng của ứng dụng web";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.46474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.53526F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTenFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNumberOfRequest, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStartTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEndTime, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 115);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên Tập tin";
            // 
            // lblTenFile
            // 
            this.lblTenFile.AutoSize = true;
            this.lblTenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenFile.Location = new System.Drawing.Point(178, 1);
            this.lblTenFile.Name = "lblTenFile";
            this.lblTenFile.Size = new System.Drawing.Size(86, 17);
            this.lblTenFile.TabIndex = 10;
            this.lblTenFile.Text = "(Không rõ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Request";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dung Lượng";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(178, 21);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(17, 17);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "0";
            // 
            // lblNumberOfRequest
            // 
            this.lblNumberOfRequest.AutoSize = true;
            this.lblNumberOfRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRequest.Location = new System.Drawing.Point(178, 46);
            this.lblNumberOfRequest.Name = "lblNumberOfRequest";
            this.lblNumberOfRequest.Size = new System.Drawing.Size(17, 17);
            this.lblNumberOfRequest.TabIndex = 10;
            this.lblNumberOfRequest.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời gian bắt đầu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thời gian thực hiện";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(178, 69);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(17, 17);
            this.lblStartTime.TabIndex = 10;
            this.lblStartTime.Text = "0";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(178, 94);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(17, 17);
            this.lblEndTime.TabIndex = 10;
            this.lblEndTime.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông tin File";
            // 
            // tctMain
            // 
            this.tctMain.Controls.Add(this.tpSetting);
            this.tctMain.Controls.Add(this.tpGraph);
            this.tctMain.Location = new System.Drawing.Point(28, 227);
            this.tctMain.Name = "tctMain";
            this.tctMain.SelectedIndex = 0;
            this.tctMain.Size = new System.Drawing.Size(797, 317);
            this.tctMain.TabIndex = 11;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.label9);
            this.tpSetting.Controls.Add(this.tableLayoutPanel2);
            this.tpSetting.Location = new System.Drawing.Point(4, 22);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(789, 291);
            this.tpSetting.TabIndex = 0;
            this.tpSetting.Text = "Thiết lập";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Thông số Test";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.08829F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.91171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudMaxThread, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudFirstDelay, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudRamupTime, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.nudLevelDuration, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudThreadIncrement, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(570, 135);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số Người dùng tối đa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 32);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label10.Size = new System.Drawing.Size(127, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Thời gian Delay ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 57);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label11.Size = new System.Drawing.Size(218, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số lượng luồng tăng mỗi mức";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 82);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label12.Size = new System.Drawing.Size(250, 22);
            this.label12.TabIndex = 10;
            this.label12.Text = "Thời gian tăng tối đa ND mỗi mức";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 107);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label13.Size = new System.Drawing.Size(224, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "Thời gian mỗi mức Test (giây)";
            // 
            // nudMaxThread
            // 
            this.nudMaxThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxThread.Location = new System.Drawing.Point(373, 10);
            this.nudMaxThread.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMaxThread.Name = "nudMaxThread";
            this.nudMaxThread.Size = new System.Drawing.Size(120, 23);
            this.nudMaxThread.TabIndex = 11;
            this.nudMaxThread.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudFirstDelay
            // 
            this.nudFirstDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFirstDelay.Location = new System.Drawing.Point(373, 35);
            this.nudFirstDelay.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFirstDelay.Name = "nudFirstDelay";
            this.nudFirstDelay.Size = new System.Drawing.Size(120, 23);
            this.nudFirstDelay.TabIndex = 12;
            // 
            // nudRamupTime
            // 
            this.nudRamupTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRamupTime.Location = new System.Drawing.Point(373, 85);
            this.nudRamupTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudRamupTime.Name = "nudRamupTime";
            this.nudRamupTime.Size = new System.Drawing.Size(120, 23);
            this.nudRamupTime.TabIndex = 14;
            this.nudRamupTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudLevelDuration
            // 
            this.nudLevelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevelDuration.Location = new System.Drawing.Point(373, 110);
            this.nudLevelDuration.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudLevelDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevelDuration.Name = "nudLevelDuration";
            this.nudLevelDuration.Size = new System.Drawing.Size(120, 23);
            this.nudLevelDuration.TabIndex = 15;
            this.nudLevelDuration.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // nudThreadIncrement
            // 
            this.nudThreadIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThreadIncrement.Location = new System.Drawing.Point(373, 60);
            this.nudThreadIncrement.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudThreadIncrement.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreadIncrement.Name = "nudThreadIncrement";
            this.nudThreadIncrement.Size = new System.Drawing.Size(120, 23);
            this.nudThreadIncrement.TabIndex = 13;
            this.nudThreadIncrement.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(503, 32);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label14.Size = new System.Drawing.Size(53, 22);
            this.label14.TabIndex = 10;
            this.label14.Text = "(Giây)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(503, 107);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label15.Size = new System.Drawing.Size(50, 22);
            this.label15.TabIndex = 10;
            this.label15.Text = "(giây)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(503, 82);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label16.Size = new System.Drawing.Size(53, 22);
            this.label16.TabIndex = 10;
            this.label16.Text = "(Giây)";
            // 
            // tpGraph
            // 
            this.tpGraph.Controls.Add(this.zedGraphControl1);
            this.tpGraph.Location = new System.Drawing.Point(4, 22);
            this.tpGraph.Name = "tpGraph";
            this.tpGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tpGraph.Size = new System.Drawing.Size(789, 291);
            this.tpGraph.TabIndex = 1;
            this.tpGraph.Text = "-- Đồ Thị --";
            this.tpGraph.UseVisualStyleBackColor = true;
            // 
            // cboRequestTag
            // 
            this.cboRequestTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRequestTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRequestTag.FormattingEnabled = true;
            this.cboRequestTag.Location = new System.Drawing.Point(634, 45);
            this.cboRequestTag.Name = "cboRequestTag";
            this.cboRequestTag.Size = new System.Drawing.Size(129, 24);
            this.cboRequestTag.TabIndex = 12;
            // 
            // fad
            // 
            this.fad.AutoSize = true;
            this.fad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fad.Location = new System.Drawing.Point(527, 49);
            this.fad.Name = "fad";
            this.fad.Size = new System.Drawing.Size(101, 17);
            this.fad.TabIndex = 13;
            this.fad.Text = "Thẻ Request";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(779, 46);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 26);
            this.btnLoc.TabIndex = 14;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnErrorPercent
            // 
            this.btnErrorPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorPercent.Location = new System.Drawing.Point(192, 554);
            this.btnErrorPercent.Name = "btnErrorPercent";
            this.btnErrorPercent.Size = new System.Drawing.Size(100, 38);
            this.btnErrorPercent.TabIndex = 5;
            this.btnErrorPercent.Text = "Tỉ lệ lỗi";
            this.btnErrorPercent.UseVisualStyleBackColor = true;
            this.btnErrorPercent.Click += new System.EventHandler(this.btnErrorPercent_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 603);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.fad);
            this.Controls.Add(this.cboRequestTag);
            this.Controls.Add(this.tctMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnErrorPercent);
            this.Controls.Add(this.btnResponseTimeAvg);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Demo";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tctMain.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRamupTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevelDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadIncrement)).EndInit();
            this.tpGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnResponseTimeAvg;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblNumberOfRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tctMain;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.TabPage tpGraph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudMaxThread;
        private System.Windows.Forms.NumericUpDown nudFirstDelay;
        private System.Windows.Forms.NumericUpDown nudThreadIncrement;
        private System.Windows.Forms.NumericUpDown nudRamupTime;
        private System.Windows.Forms.NumericUpDown nudLevelDuration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboRequestTag;
        private System.Windows.Forms.Label fad;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnErrorPercent;
    }
}

