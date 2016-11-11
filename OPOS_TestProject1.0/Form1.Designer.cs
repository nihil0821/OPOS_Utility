namespace OPOS_TestProject1._0
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptr_btn = new System.Windows.Forms.Button();
            this.scn_btn = new System.Windows.Forms.Button();
            this.msr_btn = new System.Windows.Forms.Button();
            this.cdp_btn = new System.Windows.Forms.Button();
            this.open_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleMode_chkb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ldn_cb = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.dOpen_btn = new System.Windows.Forms.Button();
            this.dClaim_btn = new System.Windows.Forms.Button();
            this.dEnable_btn = new System.Windows.Forms.Button();
            this.returnCodeEnable_tb = new System.Windows.Forms.TextBox();
            this.returnCodeClm_tb = new System.Windows.Forms.TextBox();
            this.returnCodeOpn_tb = new System.Windows.Forms.TextBox();
            this.result_tb = new System.Windows.Forms.TextBox();
            this.track1_tb = new System.Windows.Forms.TextBox();
            this.track2_tb = new System.Windows.Forms.TextBox();
            this.track3_tb = new System.Windows.Forms.TextBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.ptr_gb = new System.Windows.Forms.GroupBox();
            this.defualtTxt_btn = new System.Windows.Forms.Button();
            this.repeatNum_lb = new System.Windows.Forms.Label();
            this.repeatNum_tb = new System.Windows.Forms.TextBox();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.scn_gb = new System.Windows.Forms.GroupBox();
            this.scandata_rtb = new System.Windows.Forms.RichTextBox();
            this.msr_gb = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axOPOSLineDisplay1 = new AxOposLineDisplay_1_5_Lib.AxOPOSLineDisplay();
            this.axOPOSPOSPrinter1 = new AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter();
            this.axOPOSScanner1 = new AxOposScanner_CCO.AxOPOSScanner();
            this.axOPOSMSR1 = new AxOposMSR_CCO.AxOPOSMSR();
            this.groupBox1.SuspendLayout();
            this.ptr_gb.SuspendLayout();
            this.scn_gb.SuspendLayout();
            this.msr_gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptr_btn
            // 
            this.ptr_btn.Location = new System.Drawing.Point(12, 35);
            this.ptr_btn.Name = "ptr_btn";
            this.ptr_btn.Size = new System.Drawing.Size(99, 45);
            this.ptr_btn.TabIndex = 1;
            this.ptr_btn.Text = "PRINTER";
            this.ptr_btn.UseVisualStyleBackColor = true;
            this.ptr_btn.Click += new System.EventHandler(this.ptr_btn_Click);
            // 
            // scn_btn
            // 
            this.scn_btn.Location = new System.Drawing.Point(117, 35);
            this.scn_btn.Name = "scn_btn";
            this.scn_btn.Size = new System.Drawing.Size(99, 45);
            this.scn_btn.TabIndex = 2;
            this.scn_btn.Text = "SCANNER";
            this.scn_btn.UseVisualStyleBackColor = true;
            this.scn_btn.Click += new System.EventHandler(this.scn_btn_Click);
            // 
            // msr_btn
            // 
            this.msr_btn.Location = new System.Drawing.Point(222, 35);
            this.msr_btn.Name = "msr_btn";
            this.msr_btn.Size = new System.Drawing.Size(99, 45);
            this.msr_btn.TabIndex = 3;
            this.msr_btn.Text = "MSR";
            this.msr_btn.UseVisualStyleBackColor = true;
            this.msr_btn.Click += new System.EventHandler(this.msr_btn_Click);
            // 
            // cdp_btn
            // 
            this.cdp_btn.Location = new System.Drawing.Point(327, 35);
            this.cdp_btn.Name = "cdp_btn";
            this.cdp_btn.Size = new System.Drawing.Size(99, 45);
            this.cdp_btn.TabIndex = 4;
            this.cdp_btn.Text = "CDP";
            this.cdp_btn.UseVisualStyleBackColor = true;
            this.cdp_btn.Click += new System.EventHandler(this.cdp_btn_Click);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(6, 62);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(72, 156);
            this.open_btn.TabIndex = 5;
            this.open_btn.Text = "OPEN";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.simpleMode_chkb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ldn_cb);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.dOpen_btn);
            this.groupBox1.Controls.Add(this.dClaim_btn);
            this.groupBox1.Controls.Add(this.dEnable_btn);
            this.groupBox1.Controls.Add(this.returnCodeEnable_tb);
            this.groupBox1.Controls.Add(this.returnCodeClm_tb);
            this.groupBox1.Controls.Add(this.returnCodeOpn_tb);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 425);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // simpleMode_chkb
            // 
            this.simpleMode_chkb.AutoSize = true;
            this.simpleMode_chkb.Location = new System.Drawing.Point(12, 396);
            this.simpleMode_chkb.Name = "simpleMode_chkb";
            this.simpleMode_chkb.Size = new System.Drawing.Size(99, 16);
            this.simpleMode_chkb.TabIndex = 23;
            this.simpleMode_chkb.Text = "Simple Mode";
            this.simpleMode_chkb.UseVisualStyleBackColor = true;
            this.simpleMode_chkb.CheckStateChanged += new System.EventHandler(this.simpleMode_chkb_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "LDN";
            // 
            // ldn_cb
            // 
            this.ldn_cb.FormattingEnabled = true;
            this.ldn_cb.Location = new System.Drawing.Point(55, 19);
            this.ldn_cb.Name = "ldn_cb";
            this.ldn_cb.Size = new System.Drawing.Size(188, 20);
            this.ldn_cb.TabIndex = 15;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(6, 224);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(72, 156);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dOpen_btn
            // 
            this.dOpen_btn.Enabled = false;
            this.dOpen_btn.Location = new System.Drawing.Point(6, 62);
            this.dOpen_btn.Name = "dOpen_btn";
            this.dOpen_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dOpen_btn.Size = new System.Drawing.Size(93, 46);
            this.dOpen_btn.TabIndex = 18;
            this.dOpen_btn.Text = "O";
            this.dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dOpen_btn.UseVisualStyleBackColor = true;
            // 
            // dClaim_btn
            // 
            this.dClaim_btn.Enabled = false;
            this.dClaim_btn.Location = new System.Drawing.Point(6, 117);
            this.dClaim_btn.Name = "dClaim_btn";
            this.dClaim_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dClaim_btn.Size = new System.Drawing.Size(93, 46);
            this.dClaim_btn.TabIndex = 19;
            this.dClaim_btn.Text = "C";
            this.dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClaim_btn.UseVisualStyleBackColor = true;
            // 
            // dEnable_btn
            // 
            this.dEnable_btn.Enabled = false;
            this.dEnable_btn.Location = new System.Drawing.Point(6, 172);
            this.dEnable_btn.Name = "dEnable_btn";
            this.dEnable_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dEnable_btn.Size = new System.Drawing.Size(93, 46);
            this.dEnable_btn.TabIndex = 20;
            this.dEnable_btn.Text = "E";
            this.dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dEnable_btn.UseVisualStyleBackColor = true;
            // 
            // returnCodeEnable_tb
            // 
            this.returnCodeEnable_tb.Location = new System.Drawing.Point(97, 172);
            this.returnCodeEnable_tb.Name = "returnCodeEnable_tb";
            this.returnCodeEnable_tb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeEnable_tb.TabIndex = 22;
            // 
            // returnCodeClm_tb
            // 
            this.returnCodeClm_tb.Location = new System.Drawing.Point(97, 117);
            this.returnCodeClm_tb.Name = "returnCodeClm_tb";
            this.returnCodeClm_tb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeClm_tb.TabIndex = 21;
            // 
            // returnCodeOpn_tb
            // 
            this.returnCodeOpn_tb.Location = new System.Drawing.Point(97, 62);
            this.returnCodeOpn_tb.Name = "returnCodeOpn_tb";
            this.returnCodeOpn_tb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeOpn_tb.TabIndex = 17;
            // 
            // result_tb
            // 
            this.result_tb.Location = new System.Drawing.Point(6, 35);
            this.result_tb.Name = "result_tb";
            this.result_tb.Size = new System.Drawing.Size(351, 21);
            this.result_tb.TabIndex = 7;
            // 
            // track1_tb
            // 
            this.track1_tb.Location = new System.Drawing.Point(6, 35);
            this.track1_tb.Name = "track1_tb";
            this.track1_tb.Size = new System.Drawing.Size(220, 21);
            this.track1_tb.TabIndex = 10;
            // 
            // track2_tb
            // 
            this.track2_tb.Location = new System.Drawing.Point(6, 62);
            this.track2_tb.Name = "track2_tb";
            this.track2_tb.Size = new System.Drawing.Size(220, 21);
            this.track2_tb.TabIndex = 11;
            // 
            // track3_tb
            // 
            this.track3_tb.Location = new System.Drawing.Point(6, 89);
            this.track3_tb.Name = "track3_tb";
            this.track3_tb.Size = new System.Drawing.Size(220, 21);
            this.track3_tb.TabIndex = 12;
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(132, 156);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(99, 119);
            this.test_btn.TabIndex = 7;
            this.test_btn.Text = "DEFAULT  TEST";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // ptr_gb
            // 
            this.ptr_gb.Controls.Add(this.defualtTxt_btn);
            this.ptr_gb.Controls.Add(this.repeatNum_lb);
            this.ptr_gb.Controls.Add(this.repeatNum_tb);
            this.ptr_gb.Controls.Add(this.openfile_btn);
            this.ptr_gb.Controls.Add(this.test_btn);
            this.ptr_gb.Location = new System.Drawing.Point(267, 86);
            this.ptr_gb.Name = "ptr_gb";
            this.ptr_gb.Size = new System.Drawing.Size(363, 404);
            this.ptr_gb.TabIndex = 7;
            this.ptr_gb.TabStop = false;
            // 
            // defualtTxt_btn
            // 
            this.defualtTxt_btn.Location = new System.Drawing.Point(6, 72);
            this.defualtTxt_btn.Name = "defualtTxt_btn";
            this.defualtTxt_btn.Size = new System.Drawing.Size(351, 44);
            this.defualtTxt_btn.TabIndex = 24;
            this.defualtTxt_btn.Text = "DEFAULT TEXT";
            this.defualtTxt_btn.UseVisualStyleBackColor = true;
            this.defualtTxt_btn.Click += new System.EventHandler(this.defualtTxt_btn_Click);
            // 
            // repeatNum_lb
            // 
            this.repeatNum_lb.AutoSize = true;
            this.repeatNum_lb.Font = new System.Drawing.Font("굴림", 10F);
            this.repeatNum_lb.Location = new System.Drawing.Point(109, 133);
            this.repeatNum_lb.Name = "repeatNum_lb";
            this.repeatNum_lb.Size = new System.Drawing.Size(86, 14);
            this.repeatNum_lb.TabIndex = 23;
            this.repeatNum_lb.Text = "Repeat Num";
            // 
            // repeatNum_tb
            // 
            this.repeatNum_tb.Location = new System.Drawing.Point(201, 129);
            this.repeatNum_tb.Name = "repeatNum_tb";
            this.repeatNum_tb.Size = new System.Drawing.Size(38, 21);
            this.repeatNum_tb.TabIndex = 23;
            this.repeatNum_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repeatNum_tb_KeyPress);
            // 
            // openfile_btn
            // 
            this.openfile_btn.Location = new System.Drawing.Point(6, 12);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(351, 44);
            this.openfile_btn.TabIndex = 8;
            this.openfile_btn.Text = "OPEN FILE";
            this.openfile_btn.UseVisualStyleBackColor = true;
            this.openfile_btn.Click += new System.EventHandler(this.openfile_btn_Click);
            // 
            // scn_gb
            // 
            this.scn_gb.Controls.Add(this.scandata_rtb);
            this.scn_gb.Controls.Add(this.result_tb);
            this.scn_gb.Location = new System.Drawing.Point(267, 86);
            this.scn_gb.Name = "scn_gb";
            this.scn_gb.Size = new System.Drawing.Size(363, 425);
            this.scn_gb.TabIndex = 13;
            this.scn_gb.TabStop = false;
            // 
            // scandata_rtb
            // 
            this.scandata_rtb.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scandata_rtb.Location = new System.Drawing.Point(6, 62);
            this.scandata_rtb.MaxLength = 30;
            this.scandata_rtb.Name = "scandata_rtb";
            this.scandata_rtb.Size = new System.Drawing.Size(351, 54);
            this.scandata_rtb.TabIndex = 8;
            this.scandata_rtb.Text = "Scanning Barcode";
            this.scandata_rtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scandata_rtb_MouseClick);
            // 
            // msr_gb
            // 
            this.msr_gb.Controls.Add(this.track1_tb);
            this.msr_gb.Controls.Add(this.track2_tb);
            this.msr_gb.Controls.Add(this.track3_tb);
            this.msr_gb.Location = new System.Drawing.Point(267, 86);
            this.msr_gb.Name = "msr_gb";
            this.msr_gb.Size = new System.Drawing.Size(363, 404);
            this.msr_gb.TabIndex = 14;
            this.msr_gb.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printerToolStripMenuItem,
            this.scannerToolStripMenuItem,
            this.mSRToolStripMenuItem,
            this.lineDisplayToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // printerToolStripMenuItem
            // 
            this.printerToolStripMenuItem.Name = "printerToolStripMenuItem";
            this.printerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.printerToolStripMenuItem.Text = "Printer";
            this.printerToolStripMenuItem.Click += new System.EventHandler(this.printerToolStripMenuItem_Click);
            // 
            // scannerToolStripMenuItem
            // 
            this.scannerToolStripMenuItem.Name = "scannerToolStripMenuItem";
            this.scannerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.scannerToolStripMenuItem.Text = "Scanner";
            this.scannerToolStripMenuItem.Click += new System.EventHandler(this.scannerToolStripMenuItem_Click);
            // 
            // mSRToolStripMenuItem
            // 
            this.mSRToolStripMenuItem.Name = "mSRToolStripMenuItem";
            this.mSRToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mSRToolStripMenuItem.Text = "MSR";
            this.mSRToolStripMenuItem.Click += new System.EventHandler(this.mSRToolStripMenuItem_Click);
            // 
            // lineDisplayToolStripMenuItem
            // 
            this.lineDisplayToolStripMenuItem.Name = "lineDisplayToolStripMenuItem";
            this.lineDisplayToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.lineDisplayToolStripMenuItem.Text = "LineDisplay";
            this.lineDisplayToolStripMenuItem.Click += new System.EventHandler(this.lineDisplayToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axOPOSLineDisplay1
            // 
            this.axOPOSLineDisplay1.Enabled = true;
            this.axOPOSLineDisplay1.Location = new System.Drawing.Point(0, 0);
            this.axOPOSLineDisplay1.Name = "axOPOSLineDisplay1";
            this.axOPOSLineDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSLineDisplay1.OcxState")));
            this.axOPOSLineDisplay1.Size = new System.Drawing.Size(0, 0);
            this.axOPOSLineDisplay1.TabIndex = 20;
            // 
            // axOPOSPOSPrinter1
            // 
            this.axOPOSPOSPrinter1.Enabled = true;
            this.axOPOSPOSPrinter1.Location = new System.Drawing.Point(0, 0);
            this.axOPOSPOSPrinter1.Name = "axOPOSPOSPrinter1";
            this.axOPOSPOSPrinter1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSPOSPrinter1.OcxState")));
            this.axOPOSPOSPrinter1.Size = new System.Drawing.Size(0, 0);
            this.axOPOSPOSPrinter1.TabIndex = 19;
            // 
            // axOPOSScanner1
            // 
            this.axOPOSScanner1.Enabled = true;
            this.axOPOSScanner1.Location = new System.Drawing.Point(210, 529);
            this.axOPOSScanner1.Name = "axOPOSScanner1";
            this.axOPOSScanner1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSScanner1.OcxState")));
            this.axOPOSScanner1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSScanner1.TabIndex = 18;
            this.axOPOSScanner1.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.axOPOSScanner1_DataEvent);
            // 
            // axOPOSMSR1
            // 
            this.axOPOSMSR1.Enabled = true;
            this.axOPOSMSR1.Location = new System.Drawing.Point(12, 529);
            this.axOPOSMSR1.Name = "axOPOSMSR1";
            this.axOPOSMSR1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSMSR1.OcxState")));
            this.axOPOSMSR1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSMSR1.TabIndex = 17;
            this.axOPOSMSR1.DataEvent += new AxOposMSR_CCO._IOPOSMSREvents_DataEventEventHandler(this.axOPOSMSR1_DataEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 601);
            this.Controls.Add(this.axOPOSLineDisplay1);
            this.Controls.Add(this.axOPOSPOSPrinter1);
            this.Controls.Add(this.axOPOSScanner1);
            this.Controls.Add(this.axOPOSMSR1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cdp_btn);
            this.Controls.Add(this.msr_btn);
            this.Controls.Add(this.scn_btn);
            this.Controls.Add(this.ptr_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.scn_gb);
            this.Controls.Add(this.ptr_gb);
            this.Controls.Add(this.msr_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ptr_gb.ResumeLayout(false);
            this.ptr_gb.PerformLayout();
            this.scn_gb.ResumeLayout(false);
            this.scn_gb.PerformLayout();
            this.msr_gb.ResumeLayout(false);
            this.msr_gb.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button ptr_btn;
        private System.Windows.Forms.Button scn_btn;
        private System.Windows.Forms.Button msr_btn;
        private System.Windows.Forms.Button cdp_btn;
        private System.Windows.Forms.Button open_btn;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox result_tb;
        private System.Windows.Forms.TextBox track1_tb;
        private System.Windows.Forms.TextBox track2_tb;
        private System.Windows.Forms.TextBox track3_tb;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.GroupBox ptr_gb;
        private System.Windows.Forms.GroupBox scn_gb;
        private System.Windows.Forms.GroupBox msr_gb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ldn_cb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineDisplayToolStripMenuItem;
        private System.Windows.Forms.TextBox returnCodeEnable_tb;
        private System.Windows.Forms.TextBox returnCodeClm_tb;
        private System.Windows.Forms.TextBox returnCodeOpn_tb;
        private System.Windows.Forms.Button dOpen_btn;
        private System.Windows.Forms.Button dClaim_btn;
        private System.Windows.Forms.Button dEnable_btn;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label repeatNum_lb;
        private System.Windows.Forms.TextBox repeatNum_tb;
        private System.Windows.Forms.Button defualtTxt_btn;
        private AxOposMSR_CCO.AxOPOSMSR axOPOSMSR1;
        private AxOposScanner_CCO.AxOPOSScanner axOPOSScanner1;
        private AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter axOPOSPOSPrinter1;
        private AxOposLineDisplay_1_5_Lib.AxOPOSLineDisplay axOPOSLineDisplay1;
        private System.Windows.Forms.RichTextBox scandata_rtb;
        private System.Windows.Forms.CheckBox simpleMode_chkb;
    }
}

