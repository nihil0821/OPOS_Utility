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
            this.returnCodeEnable_tb = new System.Windows.Forms.TextBox();
            this.returnCodeClm_tb = new System.Windows.Forms.TextBox();
            this.returnCodeOpn_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ldn_cb = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.result_tb = new System.Windows.Forms.TextBox();
            this.track1_tb = new System.Windows.Forms.TextBox();
            this.track2_tb = new System.Windows.Forms.TextBox();
            this.track3_tb = new System.Windows.Forms.TextBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.ptr_gb = new System.Windows.Forms.GroupBox();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.scn_gb = new System.Windows.Forms.GroupBox();
            this.msr_gb = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.repeatNum_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.axOPOSMSR1 = new AxOposMSR_CCO.AxOPOSMSR();
            this.axOPOSLineDisplay1 = new AxOposLineDisplay_1_11_Lib.AxOPOSLineDisplay();
            this.axOPOSScanner1 = new AxOposScanner_CCO.AxOPOSScanner();
            this.axOPOSPOSPrinter1 = new AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter();
            this.groupBox1.SuspendLayout();
            this.ptr_gb.SuspendLayout();
            this.scn_gb.SuspendLayout();
            this.msr_gb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.returnCodeEnable_tb);
            this.groupBox1.Controls.Add(this.returnCodeClm_tb);
            this.groupBox1.Controls.Add(this.returnCodeOpn_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ldn_cb);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 404);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // returnCodeEnable_tb
            // 
            this.returnCodeEnable_tb.Location = new System.Drawing.Point(108, 189);
            this.returnCodeEnable_tb.Name = "returnCodeEnable_tb";
            this.returnCodeEnable_tb.Size = new System.Drawing.Size(138, 21);
            this.returnCodeEnable_tb.TabIndex = 22;
            // 
            // returnCodeClm_tb
            // 
            this.returnCodeClm_tb.Location = new System.Drawing.Point(108, 126);
            this.returnCodeClm_tb.Name = "returnCodeClm_tb";
            this.returnCodeClm_tb.Size = new System.Drawing.Size(138, 21);
            this.returnCodeClm_tb.TabIndex = 21;
            // 
            // returnCodeOpn_tb
            // 
            this.returnCodeOpn_tb.Location = new System.Drawing.Point(108, 62);
            this.returnCodeOpn_tb.Name = "returnCodeOpn_tb";
            this.returnCodeOpn_tb.Size = new System.Drawing.Size(138, 21);
            this.returnCodeOpn_tb.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "LDN";
            // 
            // ldn_cb
            // 
            this.ldn_cb.FormattingEnabled = true;
            this.ldn_cb.Location = new System.Drawing.Point(55, 36);
            this.ldn_cb.Name = "ldn_cb";
            this.ldn_cb.Size = new System.Drawing.Size(188, 20);
            this.ldn_cb.TabIndex = 15;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(6, 242);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(72, 156);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(76, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(76, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(76, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "E";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // result_tb
            // 
            this.result_tb.Location = new System.Drawing.Point(6, 35);
            this.result_tb.Name = "result_tb";
            this.result_tb.Size = new System.Drawing.Size(214, 21);
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
            this.test_btn.Location = new System.Drawing.Point(60, 139);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(99, 119);
            this.test_btn.TabIndex = 7;
            this.test_btn.Text = "TEST";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // ptr_gb
            // 
            this.ptr_gb.Controls.Add(this.label2);
            this.ptr_gb.Controls.Add(this.repeatNum_tb);
            this.ptr_gb.Controls.Add(this.openfile_btn);
            this.ptr_gb.Controls.Add(this.test_btn);
            this.ptr_gb.Location = new System.Drawing.Point(267, 86);
            this.ptr_gb.Name = "ptr_gb";
            this.ptr_gb.Size = new System.Drawing.Size(232, 404);
            this.ptr_gb.TabIndex = 7;
            this.ptr_gb.TabStop = false;
            // 
            // openfile_btn
            // 
            this.openfile_btn.Location = new System.Drawing.Point(6, 12);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(220, 44);
            this.openfile_btn.TabIndex = 8;
            this.openfile_btn.Text = "OPEN FILE";
            this.openfile_btn.UseVisualStyleBackColor = true;
            this.openfile_btn.Click += new System.EventHandler(this.openfile_btn_Click);
            // 
            // scn_gb
            // 
            this.scn_gb.Controls.Add(this.result_tb);
            this.scn_gb.Location = new System.Drawing.Point(267, 86);
            this.scn_gb.Name = "scn_gb";
            this.scn_gb.Size = new System.Drawing.Size(232, 404);
            this.scn_gb.TabIndex = 13;
            this.scn_gb.TabStop = false;
            // 
            // msr_gb
            // 
            this.msr_gb.Controls.Add(this.track1_tb);
            this.msr_gb.Controls.Add(this.track2_tb);
            this.msr_gb.Controls.Add(this.track3_tb);
            this.msr_gb.Location = new System.Drawing.Point(267, 86);
            this.msr_gb.Name = "msr_gb";
            this.msr_gb.Size = new System.Drawing.Size(232, 404);
            this.msr_gb.TabIndex = 14;
            this.msr_gb.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
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
            // repeatNum_tb
            // 
            this.repeatNum_tb.Location = new System.Drawing.Point(131, 92);
            this.repeatNum_tb.Name = "repeatNum_tb";
            this.repeatNum_tb.Size = new System.Drawing.Size(38, 21);
            this.repeatNum_tb.TabIndex = 23;
            this.repeatNum_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repeatNum_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Repeat Num";
            // 
            // axOPOSMSR1
            // 
            this.axOPOSMSR1.Enabled = true;
            this.axOPOSMSR1.Location = new System.Drawing.Point(24, 559);
            this.axOPOSMSR1.Name = "axOPOSMSR1";
            this.axOPOSMSR1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSMSR1.OcxState")));
            this.axOPOSMSR1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSMSR1.TabIndex = 8;
            this.axOPOSMSR1.DataEvent += new AxOposMSR_CCO._IOPOSMSREvents_DataEventEventHandler(this.axOPOSMSR1_DataEvent);
            // 
            // axOPOSLineDisplay1
            // 
            this.axOPOSLineDisplay1.Enabled = true;
            this.axOPOSLineDisplay1.Location = new System.Drawing.Point(0, 0);
            this.axOPOSLineDisplay1.Name = "axOPOSLineDisplay1";
            this.axOPOSLineDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSLineDisplay1.OcxState")));
            this.axOPOSLineDisplay1.Size = new System.Drawing.Size(0, 0);
            this.axOPOSLineDisplay1.TabIndex = 7;
            // 
            // axOPOSScanner1
            // 
            this.axOPOSScanner1.Enabled = true;
            this.axOPOSScanner1.Location = new System.Drawing.Point(222, 559);
            this.axOPOSScanner1.Name = "axOPOSScanner1";
            this.axOPOSScanner1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSScanner1.OcxState")));
            this.axOPOSScanner1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSScanner1.TabIndex = 6;
            this.axOPOSScanner1.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.axOPOSScanner1_DataEvent);
            // 
            // axOPOSPOSPrinter1
            // 
            this.axOPOSPOSPrinter1.Enabled = true;
            this.axOPOSPOSPrinter1.Location = new System.Drawing.Point(0, 0);
            this.axOPOSPOSPrinter1.Name = "axOPOSPOSPrinter1";
            this.axOPOSPOSPrinter1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSPOSPrinter1.OcxState")));
            this.axOPOSPOSPrinter1.Size = new System.Drawing.Size(0, 0);
            this.axOPOSPOSPrinter1.TabIndex = 0;
            this.axOPOSPOSPrinter1.ErrorEvent += new AxOposPOSPrinter_1_5_Lib._IOPOSPOSPrinterEvents_ErrorEventEventHandler(this.axOPOSPOSPrinter1_ErrorEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axOPOSMSR1);
            this.Controls.Add(this.axOPOSLineDisplay1);
            this.Controls.Add(this.axOPOSScanner1);
            this.Controls.Add(this.cdp_btn);
            this.Controls.Add(this.msr_btn);
            this.Controls.Add(this.scn_btn);
            this.Controls.Add(this.ptr_btn);
            this.Controls.Add(this.axOPOSPOSPrinter1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ptr_gb);
            this.Controls.Add(this.msr_gb);
            this.Controls.Add(this.scn_gb);
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
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSLineDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSPOSPrinter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxOposPOSPrinter_1_5_Lib.AxOPOSPOSPrinter axOPOSPOSPrinter1;
        private System.Windows.Forms.Button ptr_btn;
        private System.Windows.Forms.Button scn_btn;
        private System.Windows.Forms.Button msr_btn;
        private System.Windows.Forms.Button cdp_btn;
        private System.Windows.Forms.Button open_btn;
        private AxOposScanner_CCO.AxOPOSScanner axOPOSScanner1;
        private AxOposLineDisplay_1_11_Lib.AxOPOSLineDisplay axOPOSLineDisplay1;
        private AxOposMSR_CCO.AxOPOSMSR axOPOSMSR1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repeatNum_tb;
    }
}

