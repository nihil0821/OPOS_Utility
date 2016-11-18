using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OPOS_TestProject1._0
{
    public partial class Form1 : Form
    {
        //OPOS Constant
        public const int PTR_S_RECEIPT = 2;
        public const int PTR_CP_FULLCUT = 100;
        public const Int32 DISP_DT_NORMAL = 0;

        //** "Width" Parameter
        //     Either bitmap width or:

        public const int PTR_BM_ASIS = -11;  // One pixel per printer dot

        //** "Alignment" Parameter
        //     Either the distance from the left-most print column to the start
        //     of the bitmap, or one of the following:

        public const int PTR_BM_LEFT = -1;
        public const int PTR_BM_CENTER = -2;
        public const int PTR_BM_RIGHT = -3;

        public const string ESC = "\x1B";
        public const int LF = 10;

        //OPOS Error Constant 
        public const int OPOSERR           = 100;
        public const int OPOSERREXT        = 200;
        public const int OPOS_SUCCESS      = 0;
        public const int OPOS_E_CLOSED     = 101;
        public const int OPOS_E_CLAIMED    = 102;
        public const int OPOS_E_NOTCLAIMED = 103;
        public const int OPOS_E_NOSERVICE  = 104;
        public const int OPOS_E_DISABLED   = 105;
        public const int OPOS_E_ILLEGAL    = 106;
        public const int OPOS_E_NOHARDWARE = 107;
        public const int OPOS_E_OFFLINE    = 108;
        public const int OPOS_E_NOEXIST    = 109;
        public const int OPOS_E_EXISTS     = 110;
        public const int OPOS_E_FAILURE    = 111;
        public const int OPOS_E_TIMEOUT    = 112;
        public const int OPOS_E_BUSY       = 113;
        public const int OPOS_E_EXTENDED   = 114;

        //Device Number
        public const int PTR_NUM = 1;
        public const int SCN_NUM = 2;
        public const int MSR_NUM = 3;
        public const int CDP_NUM = 4;
        public const int CASH_NUM = 5;

        //Registry value store String[]
        string[] rkey_ptr;
        string[] rkey_ptrSub;
        string[] rkey_scn;
        string[] rkey_scnSub;
        string[] rkey_msr;
        string[] rkey_msrSub;
        string[] rkey_cdp;
        string[] rkey_cdpSub;
        string[] rkey_cash;
        string[] rkey_cashSub;
        int returnCode_open;
        int returnCode_claim;
        int returnCode_release;
        int returnCode_close;

        String resultCodeString;
        String returnCodeString;

        int device_num = 1;
        String track1, track2, track3;
        String defaultReciptText =
                "매출전표(고객용)\n" +
                "우리 체크                    신용승인\n" +
                "거래일시               16-11-10 10:56\n" +
                "카드 번호      6275-****-****-****(S)\n" +
                "가맹점 번호                 123456789\n" +
                "승인번호                         9876\n" +
                "매입사:비씨  (전자서명전표)          \n" +
                "-------------------------------------\n" +
                "판매금액                     92,728원\n" +
                "부가가치세                    9,272원\n" +
                "봉사료                            0원\n" +
                "합  계                      102,000원\n" +
                "-------------------------------------\n" +
                "가맹점명                 OPOS프로젝트\n" +
                "사업자번호               201611101056\n" +
                "대표자명:홍길동     TEL:010-1234-5678\n" +
                "주소:서울시 동대문구                 \n" +
                "-------------------------------------\n" +
                "CATID:20161110    전표No:201611101056\n" +
                "감사합니다.                          \n";

        String printText = "";

        Boolean isDefaultText = true;

        //CashDrawer Test var
        int intervalNum=1000;
        int repeatNum=0;
        int currentRepeatNum=0;


        public Form1()
        {
            InitializeComponent();
            init();
            StringToUTF8();
        }

        private void StringToUTF8()
        {
            //string sample = "테스트";
            //인코딩 방식을 지정
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            //변환하고자 하는 문자열을 UTF8 방식으로 변환하여 byte 배열로 반환
            byte[] utf8Bytes = utf8.GetBytes(defaultReciptText);

            //UTF-8을 string으로 변한
            string utf8String = "";
            //Console.Write(" - Encode: ");
            foreach (byte b in utf8Bytes)
            {
                utf8String += "%" + String.Format("{0:X}", b);
            }
            //Console.WriteLine(utf8String);


            // 인코된 문자열 디코딩
            string Unicode = utf8.GetString(utf8Bytes);
            //Console.WriteLine(" - Decode: " + Unicode);

            defaultReciptText = Unicode;

        }

        private void init()
        {
            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;
            disp_gb.Visible = false;
            cash_gb.Visible = false;


            //Registry init
            rkey_ptr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetValueNames();
            rkey_ptrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetSubKeyNames();
            rkey_scn = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\Scanner").GetValueNames();
            rkey_scnSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\Scanner").GetSubKeyNames();
            rkey_msr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetValueNames();
            rkey_msrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetSubKeyNames();
            rkey_cdp = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetValueNames();
            rkey_cdpSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetSubKeyNames();
            rkey_cash = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\CashDrawer").GetValueNames();
            rkey_cashSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\CashDrawer").GetSubKeyNames();

            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;

            repeatNum_tb.MaxLength = 4;
            repeatNum_tb.Text = "1";

            simpleMode_chkb.Checked = true;

            timer_gb.Enabled = false;

            ldn_rtb.SelectionAlignment = HorizontalAlignment.Center;
            currentDevice_rtb.SelectionAlignment = HorizontalAlignment.Center;

            currentInterval_rtb.SelectionAlignment = HorizontalAlignment.Center;
            currentRepeat_rtb.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void printerMenuItem_Click(object sender, EventArgs e)
        {
            device_num = PTR_NUM;
            currentDevice_rtb.Text = "POS Printer";

            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;
            disp_gb.Visible = false;
            cash_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;


        }

        private void scannerMenuItem_Click(object sender, EventArgs e)
        {
            device_num = SCN_NUM;
            currentDevice_rtb.Text = "Scanner";

            ptr_gb.Visible = false;
            scn_gb.Visible = true;
            msr_gb.Visible = false;
            disp_gb.Visible = false;
            cash_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_scn);
            ldn_cb.Items.AddRange(rkey_scnSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void msrMenuItem_Click(object sender, EventArgs e)
        {
            device_num = MSR_NUM;
            currentDevice_rtb.Text = "MSR";

            ptr_gb.Visible = false;
            scn_gb.Visible = false;
            msr_gb.Visible = true;
            disp_gb.Visible = false;
            cash_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_msr);
            ldn_cb.Items.AddRange(rkey_msrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void cdpMenuItem_Click(object sender, EventArgs e)
        {
            device_num = CDP_NUM;
            currentDevice_rtb.Text = "Line Display";

            ptr_gb.Visible = false;
            scn_gb.Visible = false;
            msr_gb.Visible = false;
            disp_gb.Visible = true;
            cash_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_cdp);
            ldn_cb.Items.AddRange(rkey_cdpSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void cashMenuItem_Click(object sender, EventArgs e)
        {            
            device_num = CASH_NUM;
            currentDevice_rtb.Text = "Cash Drawer";

            ptr_gb.Visible = false;
            scn_gb.Visible = false;
            msr_gb.Visible = false;
            disp_gb.Visible = false;
            cash_gb.Visible = true;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_cash);
            ldn_cb.Items.AddRange(rkey_cashSub);
            ldn_cb.SelectedIndex = 0;

        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            int repeatNum = int.Parse(repeatNum_tb.Text);
            if (isDefaultText)
            {
                printText = defaultReciptText;
            }
            for (int i = 0; i < repeatNum; i++)
            {
                int ret = axOPOSPOSPrinter1.PrintNormal(PTR_S_RECEIPT,
                    ESC + "|cA" + printText + ESC + "|100fP");

                int ret2 = axOPOSPOSPrinter1.PrintNormal(PTR_S_RECEIPT,
                    ESC + "|1B" + "|100fP");
            }

            
        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            isDefaultText = false;
            //test_btn.Text = "OPEN FILE TEXT TEST";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.UTF8, true);
                //MessageBox.Show(sr.ReadToEnd());
                printText = sr.ReadToEnd();
                printTxt_rtb.Text = printText;
                sr.Close();
            }
        }

        private void repeatNum_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BackSpace allowable
            if (e.KeyChar == '\b') return;
            //Don't allow a value other than number  
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void defualtTxt_btn_Click(object sender, EventArgs e)
        {
            isDefaultText = true;
            printTxt_rtb.Text = defaultReciptText;
            string filePath = "C:\\Users\\Administrator\\Documents\\Visual Studio 2015\\Projects\\OPOS_TestProject1.0\\OPOS_TestProject1.0\resource\vip.bmp";

            axOPOSPOSPrinter1.SetBitmap(1, PTR_S_RECEIPT, filePath, PTR_BM_ASIS, PTR_BM_CENTER);
            int res = axOPOSPOSPrinter1.PrintBitmap(PTR_S_RECEIPT, filePath, PTR_BM_ASIS, PTR_BM_CENTER);
            printTxt_rtb.Text += res;
        }

        private void papercut_btn_Click(object sender, EventArgs e)
        {
            axOPOSPOSPrinter1.CutPaper(PTR_CP_FULLCUT);
        }

        private void simpleMode_chkb_CheckStateChanged(object sender, EventArgs e)
        {

            dClaim_btn.Enabled = false;
            dEnable_btn.Enabled = false;
            dDisable_btn.Enabled = false;
            dRelease_btn.Enabled = false;
            dClose_btn.Enabled = false;
            if (simpleMode_chkb.Checked)
            {
                open_btn.Visible = true;
                close_btn.Visible = true;
                dOpen_btn.Enabled = false;
                

                dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dOpen_btn.Text = "O";
                dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dClaim_btn.Text = "C";
                dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dEnable_btn.Text = "E";
                dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dDisable_btn.Text = "D";
                dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dRelease_btn.Text = "R";
                dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dClose_btn.Text = "C";
            }
            else
            {
                open_btn.Visible = false;
                close_btn.Visible = false;
                dOpen_btn.Enabled = true;

                dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dOpen_btn.Text = "Open";
                dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dClaim_btn.Text = "Claim";
                dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dEnable_btn.Text = "Enable";
                dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dDisable_btn.Text = "Disable";
                dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dRelease_btn.Text = "Release";
                dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dClose_btn.Text = "Close";
            }
        }

        private void scandata_rtb_MouseClick(object sender, MouseEventArgs e)
        {
            scandata_rtb.Clear();            
        }        

        private void track_tb_MouseClick(object sender, MouseEventArgs e)
        {
            track1_rtb.Clear();
            track2_rtb.Clear();
            track3_rtb.Clear();
        }

        private void axOPOSScanner1_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            scandata_rtb.Text = axOPOSScanner1.ScanData;
            axOPOSScanner1.DataEventEnabled = true;
        }

        private void axOPOSMSR1_DataEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_DataEventEvent e)
        {
            track1 = axOPOSMSR1.Track1Data;
            track2 = axOPOSMSR1.Track2Data;
            track3 = axOPOSMSR1.Track3Data;

            track1_rtb.Text = track1;
            track2_rtb.Text = track2;
            track3_rtb.Text = track3;

            cardNum_rtb.Text = axOPOSMSR1.AccountNumber;
            surName_rtb.Text = axOPOSMSR1.Surname;
            firstName_rtb.Text = axOPOSMSR1.FirstName;
            expirationDate_rtb.Text = axOPOSMSR1.ExpirationDate;


            test_rtb.Text =
                "CardAuthenticationData: " + axOPOSMSR1.CardAuthenticationData + "\n" +
                "CapCardAuthentication: " + axOPOSMSR1.CapCardAuthentication + "\n" +
                "CapDataEncryption: " + axOPOSMSR1.CapDataEncryption + "\n" +
                "AccountNumber: " + axOPOSMSR1.AccountNumber + "\n" +
                "CheckHealthText: " + axOPOSMSR1.CheckHealthText + "\n" +
                "DataCount: " + axOPOSMSR1.DataCount + "\n" +
                "PowerNotify: " + axOPOSMSR1.PowerNotify + "\n" +
                "PowerState: " + axOPOSMSR1.PowerState + "\n" +
                "Track1DiscretionaryData: " + axOPOSMSR1.Track1DiscretionaryData + "\n" +
                "Track1EncryptedData: " + axOPOSMSR1.Track1EncryptedData + "\n" +
                "Track1EncryptedDataLength: " + axOPOSMSR1.Track1EncryptedDataLength + "\n" +
                "TracksToRead: " + axOPOSMSR1.TracksToRead + "\n" +
                "TracksToWrite: " + axOPOSMSR1.TracksToWrite + "\n" +
                "WriteCardType: " + axOPOSMSR1.WriteCardType + "\n";

            axOPOSMSR1.DataEventEnabled = true;
        }

        private void dataEventEnabled_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(dataEventEnabled_btn))
            {
                axOPOSScanner1.DataEventEnabled = true;
            }
            else
            {
                axOPOSMSR1.DataEventEnabled = true;
            }

        }

        private void DispTest_btn_Click(object sender, EventArgs e)
        {
            string errorMessage;
            int returnCode;

            if (sender.Equals(oneLineTest_btn))
            {
                string displayText = defaultLineText_rtb.Text;                          
                returnCode = axOPOSLineDisplay1.DisplayText(displayText, DISP_DT_NORMAL);
            }
            else if(sender.Equals(twoLineTest_btn))
            {
                string displayText1 = firstLineText_rtb.Text;
                string displayText2 = secondLineText_rtb.Text;
                //returnCode = axOPOSLineDisplay1.DisplayText(displayText1 + displayText2, DISP_DT_NORMAL);
                Int32 row, column;
                row = 0; column = 0;
                returnCode = axOPOSLineDisplay1.DisplayTextAt(row, column, displayText1, DISP_DT_NORMAL);
                returnCode = axOPOSLineDisplay1.DisplayTextAt(row + 1, column, displayText2, DISP_DT_NORMAL);
            }
            else if(sender.Equals(clearText_btn))
            {
                returnCode = axOPOSLineDisplay1.ClearText();               
            }
            else
            {
                returnCode = -1;
            }

            errorMessage = return_ErrorCode(returnCode);

            if (sender.Equals(oneLineTest_btn)) { returnCode_disp_rtb.Text = errorMessage; }
            else if (sender.Equals(twoLineTest_btn)) { returnCode2_disp_rtb.Text = errorMessage; }
            else if (sender.Equals(clearText_btn)){ returnCode3_disp_rtb.Text = errorMessage; }
            else { returnCode = -1; }

        }

        /*  
         * Open, Claim, Enable Botton Click Event 
         */
        private void OCE_btn_Click(object sender, EventArgs e)
        {

            if (sender.Equals(clearResult_btn))
            {
                returnCodeOpn_rtb.Text = "Return Code ( )";
                returnCodeClm_rtb.Text = "Return Code ( )";
                returnCodeEnable_rtb.Text = "Return Code ( )";
                returnCodeDis_rtb.Text = "Return Code ( )";
                returnCodeRel_rtb.Text = "Return Code ( )";
                returnCodeCls_rtb.Text = "Return Code ( )";
            }  

            switch (device_num)
            {
                case PTR_NUM:
                    {
                        if (sender.Equals(dOpen_btn) || sender.Equals(open_btn))
                        {   
                            returnCode_open = axOPOSPOSPrinter1.Open(ldn_cb.Text);
                            close_btn.Enabled = true;

                            if (simpleMode_chkb.Checked)
                            {
                                dClaim_btn.Enabled = false;
                                dClose_btn.Enabled = false;
                                returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
                                axOPOSPOSPrinter1.DeviceEnabled = true;

                                returnCodeString = return_ErrorCode(returnCode_claim);
                                returnCodeClm_rtb.Text = returnCodeString;
                            }
                            else
                            {                                
                                dClose_btn.Enabled = true;
                                dClaim_btn.Enabled = true;
                            }   
                            returnCodeString = return_ErrorCode(returnCode_open);
                            returnCodeOpn_rtb.Text = returnCodeString;
                            break;
                        }
                        if(sender.Equals(dClaim_btn))
                        {
                            returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);

                            dEnable_btn.Enabled = true;
                            dDisable_btn.Enabled = true;
                            dRelease_btn.Enabled = true;
                            dClose_btn.Enabled = true;

                            returnCodeString = return_ErrorCode(returnCode_claim);
                            returnCodeClm_rtb.Text = returnCodeString;
                            break;
                        }
                        if(sender.Equals(dEnable_btn))
                        {
                            axOPOSPOSPrinter1.DeviceEnabled = true;
                            break;
                        }
                    }
                    break;
                case SCN_NUM:
                    {
                        if (sender.Equals(dOpen_btn) || sender.Equals(open_btn))
                        {
                            returnCode_open = axOPOSScanner1.Open(ldn_cb.Text);
                            close_btn.Enabled = true;

                            if (simpleMode_chkb.Checked)
                            {
                                dClaim_btn.Enabled = false;
                                dClose_btn.Enabled = false;
                                returnCode_claim = axOPOSScanner1.ClaimDevice(1000);
                                axOPOSScanner1.DeviceEnabled = true;
                                scandata_rtb.Clear();

                                returnCodeString = return_ErrorCode(returnCode_claim);
                                returnCodeClm_rtb.Text = returnCodeString;
                            }
                            else
                            {                                
                                dClose_btn.Enabled = true;
                                dClaim_btn.Enabled = true;
                            }

                            returnCodeString = return_ErrorCode(returnCode_open);
                            returnCodeOpn_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dClaim_btn))
                        {
                            returnCode_claim = axOPOSScanner1.ClaimDevice(1000);

                            dEnable_btn.Enabled = true;
                            dDisable_btn.Enabled = true;
                            dRelease_btn.Enabled = true;
                            dClose_btn.Enabled = true;

                            returnCodeString = return_ErrorCode(returnCode_claim);
                            returnCodeClm_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dEnable_btn))
                        {
                            axOPOSScanner1.DeviceEnabled = true;
                            scandata_rtb.Clear();
                            break;
                        }
                    }
                    break;
                case MSR_NUM:
                    {
                        if (sender.Equals(dOpen_btn) || sender.Equals(open_btn))
                        {                            
                            returnCode_open = axOPOSMSR1.Open(ldn_cb.Text);
                            close_btn.Enabled = true;

                            if (simpleMode_chkb.Checked)
                            {
                                dClaim_btn.Enabled = false;
                                dClose_btn.Enabled = false;
                                returnCode_claim = axOPOSMSR1.ClaimDevice(1000);
                                axOPOSMSR1.DeviceEnabled = true;
                                track1_rtb.Clear();
                                track2_rtb.Clear();
                                track3_rtb.Clear();

                                returnCodeString = return_ErrorCode(returnCode_claim);
                                returnCodeClm_rtb.Text = returnCodeString;
                            }

                            else
                            {
                                dClose_btn.Enabled = true;
                                dClaim_btn.Enabled = true;
                            }

                            returnCodeString = return_ErrorCode(returnCode_open);
                            returnCodeOpn_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dClaim_btn))
                        {
                            returnCode_claim = axOPOSMSR1.ClaimDevice(1000);

                            dEnable_btn.Enabled = true;
                            dDisable_btn.Enabled = true;
                            dRelease_btn.Enabled = true;
                            dClose_btn.Enabled = true;

                            returnCodeString = return_ErrorCode(returnCode_claim);
                            returnCodeClm_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dEnable_btn))
                        {
                            axOPOSMSR1.DeviceEnabled = true;
                            track1_rtb.Clear();
                            track2_rtb.Clear();
                            track3_rtb.Clear();
                            break;
                        }
                    }
                    break;
                case CDP_NUM:
                    {
                        if (sender.Equals(dOpen_btn) || sender.Equals(open_btn))
                        {
                            returnCode_open = axOPOSLineDisplay1.Open(ldn_cb.Text);
                            close_btn.Enabled = true;
                            if (simpleMode_chkb.Checked)
                            {
                                dClaim_btn.Enabled = false;
                                dClose_btn.Enabled = false;
                                returnCode_claim = axOPOSLineDisplay1.ClaimDevice(500);
                                axOPOSLineDisplay1.DeviceEnabled = true;
                            }
                            else
                            {
                                dClose_btn.Enabled = true;
                                dClaim_btn.Enabled = true;
                            }
                            break;
                        }
                        if (sender.Equals(dClaim_btn))
                        {
                            returnCode_claim = axOPOSLineDisplay1.ClaimDevice(500);

                            dEnable_btn.Enabled = true;
                            dDisable_btn.Enabled = true;
                            dRelease_btn.Enabled = true;
                            dClose_btn.Enabled = true;

                            returnCodeString = return_ErrorCode(returnCode_claim);
                            returnCodeClm_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dEnable_btn))
                        {
                            axOPOSLineDisplay1.DeviceEnabled = true;
                            break;
                        }
                    }
                    break;
                case CASH_NUM:
                    {
                        if (sender.Equals(dOpen_btn) || sender.Equals(open_btn))
                        {
                            returnCode_open = axOPOSCashDrawer1.Open(ldn_cb.Text);
                            close_btn.Enabled = true;
                            if (simpleMode_chkb.Checked)
                            {
                                dClaim_btn.Enabled = false;
                                dClose_btn.Enabled = false;
                                returnCode_claim = axOPOSCashDrawer1.ClaimDevice(500);
                                axOPOSCashDrawer1.DeviceEnabled = true;
                            }
                            else
                            {
                                dClose_btn.Enabled = true;
                                dClaim_btn.Enabled = true;
                            }
                            break;
                        }
                        if (sender.Equals(dClaim_btn))
                        {
                            returnCode_claim = axOPOSCashDrawer1.ClaimDevice(500);

                            dEnable_btn.Enabled = true;
                            dDisable_btn.Enabled = true;
                            dRelease_btn.Enabled = true;
                            dClose_btn.Enabled = true;

                            returnCodeString = return_ErrorCode(returnCode_claim);
                            returnCodeClm_rtb.Text = returnCodeString;
                            break;
                        }
                        if (sender.Equals(dEnable_btn))
                        {
                            axOPOSCashDrawer1.DeviceEnabled = true;
                            break;
                        }
                    }
                    break;
                default: break;
            }
        }

        /*
         * Disable, Release, Close Botton Click Event
         */
        private void DRC_btn_Click(object sender, EventArgs e)
        {
            //Disable Button Click
            if (sender.Equals(dDisable_btn))
            {
                switch (device_num)
                {
                    case PTR_NUM:
                        {
                            axOPOSPOSPrinter1.DeviceEnabled = false;
                        }
                        break;
                    case SCN_NUM:
                        {
                            axOPOSScanner1.DeviceEnabled = false;
                        }
                        break;
                    case MSR_NUM:
                        {
                            axOPOSMSR1.DeviceEnabled = false;
                        }
                        break;
                    case CDP_NUM:
                        {
                            axOPOSLineDisplay1.ClearText();
                            axOPOSLineDisplay1.DeviceEnabled = false;
                        }
                        break;
                    case CASH_NUM:
                        {
                            axOPOSCashDrawer1.DeviceEnabled = false;
                        }
                        break;
                    default: break;
                }
            }
            //Release Button Click
            else if (sender.Equals(dRelease_btn))
            {
                switch (device_num)
                {
                    case PTR_NUM:
                        {
                            returnCode_release = axOPOSPOSPrinter1.ReleaseDevice();
                        }
                        break;
                    case SCN_NUM:
                        {
                            returnCode_release = axOPOSScanner1.ReleaseDevice();
                        }
                        break;
                    case MSR_NUM:
                        {
                            returnCode_release = axOPOSMSR1.ReleaseDevice();
                        }
                        break;
                    case CDP_NUM:
                        {
                            returnCode_release = axOPOSLineDisplay1.ReleaseDevice();
                        }
                        break;
                    default: break;
                }
            }
            //Release Button Click
            else if (sender.Equals(dClose_btn) || sender.Equals(close_btn))
            {
                close_btn.Enabled = false;
                switch (device_num)
                {
                    case PTR_NUM:
                        {
                            returnCode_close = axOPOSPOSPrinter1.Close();
                        }
                        break;
                    case SCN_NUM:
                        {
                            returnCode_close = axOPOSScanner1.Close();
                            scandata_rtb.Clear();
                        }
                        break;
                    case MSR_NUM:
                        {
                            returnCode_close = axOPOSMSR1.Close();
                            track1_rtb.Clear();
                            track2_rtb.Clear();
                            track3_rtb.Clear();
                        }
                        break;
                    case CDP_NUM:
                        {
                            returnCode_close = axOPOSLineDisplay1.Close();
                        }
                        break;
                    default: break;
                }                
                dClaim_btn.Enabled = false;
                dEnable_btn.Enabled = false;
                dDisable_btn.Enabled = false;
                dRelease_btn.Enabled = false;
                dClose_btn.Enabled = false;
            }
        }

        private void axOPOSMSR1_ErrorEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_ErrorEventEvent e)
        {
            int res;
            int resCE;
            int errL;
            string resStr;
            string resCEStr;
            string errLStr;


            res = e.resultCode;
            resCE = e.resultCodeExtended;
            errL = e.errorLocus;

            resStr = return_ErrorCode(res);
            resCEStr = return_ErrorCode(resCE);
            errLStr = return_ErrorCode(errL);


            msrResultCode_rtb.Text = resStr;
            msrRCExtended_rtb.Text = resCEStr;
            msrErrorLocus_rtb.Text = errLStr;

            MessageBox.Show("Error Event!!");
        }

        private void axOPOSScanner1_ErrorEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_ErrorEventEvent e)
        {
            int res = e.resultCode;
            string resultCode;
            resultCode = return_ErrorCode(res);

            
        }

        private void openDrawer_btn_Click(object sender, EventArgs e)
        {
            if (timerMode_cb.Checked)
            {
                if (currentRepeatNum > 0)
                {

                    int res = axOPOSCashDrawer1.OpenDrawer();
                    currentRepeatNum--;
                    currentRepeat_rtb.Text = currentRepeatNum + "";

                }
                else
                {
                    timerStop_btn.Enabled = false;
                    timerMode_cb.Enabled = true;
                    currentRepeatNum = repeatNum;
                    cashTimer.Enabled = false;
                }
            }
            else
            {
                int res = axOPOSCashDrawer1.OpenDrawer();
            }
        }

        private void interRepet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BackSpace allowable
            if (e.KeyChar == '\b') return;
            //Don't allow a value other than number  
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            if (Convert.ToInt32(e.KeyChar) == 13)                
            {
                if (sender.Equals(interval_rtb))
                {
                    MessageBox.Show("Enter Key pressed1");
                    if(!interval_rtb.Text.Equals("")) // 공백이 아닐 때만
                    {
                        intervalNum = int.Parse(interval_rtb.Text);
                        currentInterval_rtb.Text = interval_rtb.Text;
                        interval_rtb.Clear();
                    }
                    else //공백일 시 디폴트로 설정
                    {
                        intervalNum = 1000;
                        currentInterval_rtb.Text = 1000 + "";
                    }                    
                }
                else
                {
                    MessageBox.Show("Enter Key pressed2");
                    
                    if (!repeatNum_rtb.Text.Equals("")) // 공백이 아닐 때만
                    {
                        repeatNum = int.Parse(repeatNum_rtb.Text);
                        currentRepeat_rtb.Text = repeatNum_rtb.Text;
                        currentRepeatNum = repeatNum;
                    }
                    else //공백일 시 디폴트로 설정
                    {
                        repeatNum = 1;
                        currentRepeat_rtb.Text = 1 + "";
                    }
                }
            }
        }        

        private void timerMode_cb_CheckedChanged(object sender, EventArgs e)
        {
            if(timerMode_cb.Checked)
            {
                timer_gb.Enabled = true;
            }
            else
            {
                timer_gb.Enabled = false;
            }
        }

        private void timerStart_btn_Click(object sender, EventArgs e)
        {
            cashTimer.Enabled = true;
            cashTimer.Interval = intervalNum;
            timerStop_btn.Enabled = true;
            timerMode_cb.Enabled = false;
        }

        private void timerStop_btn_Click(object sender, EventArgs e)
        {
            cashTimer.Enabled = false;
            timerStop_btn.Enabled = false;
            timerMode_cb.Enabled = true;
        }

        private void axOPOSPOSPrinter1_ErrorEvent(object sender, AxOposPOSPrinter_1_5_Lib._IOPOSPOSPrinterEvents_ErrorEventEvent e)
        {

        }

        private string return_ErrorCode(int returnCode)
        {
            string return_errorcode="";
            switch (returnCode)
            {
                case OPOSERR:           return_errorcode = "OPOSERR (" + OPOSERR + ")";                     break;
                case OPOS_SUCCESS:      return_errorcode = "OPOS_SUCCESS (" + OPOS_SUCCESS + ")";           break;
                case OPOS_E_CLOSED:     return_errorcode = "OPOS_E_CLOSED (" + OPOS_E_CLOSED + ")";         break;
                case OPOS_E_CLAIMED:    return_errorcode = "OPOS_E_CLAIMED (" + OPOS_E_CLAIMED + ")";       break;
                case OPOS_E_NOTCLAIMED: return_errorcode = "OPOS_E_NOTCLAIMED (" + OPOS_E_NOTCLAIMED + ")"; break;
                case OPOS_E_NOSERVICE:  return_errorcode = "OPOS_E_NOSERVICE (" + OPOS_E_NOSERVICE + ")";   break;
                case OPOS_E_DISABLED:   return_errorcode = "OPOS_E_DISABLED (" + OPOS_E_DISABLED + ")";     break;
                case OPOS_E_NOHARDWARE: return_errorcode = "OPOS_E_NOHARDWARE (" + OPOS_E_NOHARDWARE + ")"; break;
                case OPOS_E_OFFLINE:    return_errorcode = "OPOS_E_OFFLINE (" + OPOS_E_OFFLINE + ")";       break;
                case OPOS_E_ILLEGAL:    return_errorcode = "OPOS_E_ILLEGAL (" + OPOS_E_ILLEGAL + ")";       break;
                case OPOS_E_NOEXIST:    return_errorcode = "OPOS_E_NOEXIST (" + OPOS_E_NOEXIST + ")";       break;
                case OPOS_E_EXISTS:     return_errorcode = "OPOS_E_EXISTS (" + OPOS_E_EXISTS + ")";         break;
                case OPOS_E_FAILURE:    return_errorcode = "OPOS_E_FAILURE (" + OPOS_E_FAILURE + ")";       break;
                case OPOS_E_TIMEOUT:    return_errorcode = "OPOS_E_TIMEOUT (" + OPOS_E_TIMEOUT + ")";       break;
                case OPOS_E_BUSY:       return_errorcode = "OPOS_E_BUSY (" + OPOS_E_BUSY + ")";             break;
                case OPOS_E_EXTENDED:   return_errorcode = "OPOS_E_EXTENDED (" + OPOS_E_EXTENDED + ")";     break;
                default:                return_errorcode = "ERROR";                                         break;
            }
            return return_errorcode;
        }
    }
}
