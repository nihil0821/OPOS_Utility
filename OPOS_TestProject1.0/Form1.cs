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

        string[] rkey_ptr;
        string[] rkey_ptrSub;
        string[] rkey_scn;
        string[] rkey_scnSub;
        string[] rkey_msr;
        string[] rkey_msrSub;
        string[] rkey_cdp;
        string[] rkey_cdpSub;

        int returnCode_open;
        int returnCode_claim;
        int returnCode_enable;
        int returnCode_disenable;
        int returnCode_release;
        int returnCode_close;

        String resultCodeString, returnCodeString;
        String printText;

        int device_num = 1;
        String track1, track2, track3;

        

        public Form1()
        {
            InitializeComponent();
            init_visible();
        }

        private void init_visible()
        {
            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;

            rkey_ptr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetValueNames();
            rkey_ptrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetSubKeyNames();
            rkey_scn = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\Scanner").GetValueNames();
            rkey_scnSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\Scanner").GetSubKeyNames();
            rkey_msr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetValueNames();
            rkey_msrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetSubKeyNames();
            rkey_cdp = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetValueNames();
            rkey_cdpSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetSubKeyNames();

            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;

            repeatNum_tb.MaxLength = 4;
        }

        private void ptr_btn_Click(object sender, EventArgs e)
        {
            device_num = PTR_NUM;

            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void scn_btn_Click(object sender, EventArgs e)
        {
            device_num = SCN_NUM;

            ptr_gb.Visible = false;
            scn_gb.Visible = true;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_scn);
            ldn_cb.Items.AddRange(rkey_scnSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void axOPOSScanner1_DataEvent(object sender, AxOposScanner_CCO._IOPOSScannerEvents_DataEventEvent e)
        {
            result_tb.Text = axOPOSScanner1.ScanData;
        }

        private void msr_btn_Click(object sender, EventArgs e)
        {
            device_num = MSR_NUM;

            ptr_gb.Visible = false;
            scn_gb.Visible = false;
            msr_gb.Visible = true;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_msr);
            ldn_cb.Items.AddRange(rkey_msrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void axOPOSMSR1_DataEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_DataEventEvent e)
        {
            track1 = axOPOSMSR1.Track1Data;
            track2 = axOPOSMSR1.Track2Data;
            track3 = axOPOSMSR1.Track3Data;

            track1_tb.Text = track1;
            track2_tb.Text = track2;
            track3_tb.Text = track3;
        }

        private void cdp_btn_Click(object sender, EventArgs e)
        {
            device_num = CDP_NUM;

            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_cdp);
            ldn_cb.Items.AddRange(rkey_cdpSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            switch (device_num)
            {
                case PTR_NUM:
                    {
                        //for(int i=0;i<repeatNum_tb.Text)
                        int ret = axOPOSPOSPrinter1.PrintNormal(PTR_S_RECEIPT, printText);

                        axOPOSPOSPrinter1.CutPaper(PTR_CP_FULLCUT);
                    }
                    break;
                case SCN_NUM: { } break;
                case MSR_NUM: { } break;
                case CDP_NUM:
                    {
                        axOPOSLineDisplay1.DisplayText("Valcretec NOHDAEGEON", DISP_DT_NORMAL);

                    }
                    break;
                default: break;
            }
        }

        private void printerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device_num = PTR_NUM;

            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void scannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device_num = SCN_NUM;

            ptr_gb.Visible = false;
            scn_gb.Visible = true;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_scn);
            ldn_cb.Items.AddRange(rkey_scnSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void mSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device_num = MSR_NUM;

            ptr_gb.Visible = false;
            scn_gb.Visible = false;
            msr_gb.Visible = true;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_msr);
            ldn_cb.Items.AddRange(rkey_msrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void lineDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device_num = CDP_NUM;

            ptr_gb.Visible = true;
            scn_gb.Visible = false;
            msr_gb.Visible = false;

            ldn_cb.Items.Clear();
            ldn_cb.Items.AddRange(rkey_cdp);
            ldn_cb.Items.AddRange(rkey_cdpSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void axOPOSPOSPrinter1_ErrorEvent(object sender, AxOposPOSPrinter_1_5_Lib._IOPOSPOSPrinterEvents_ErrorEventEvent e)
        {

        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, System.Text.Encoding.UTF8, true);
                //MessageBox.Show(sr.ReadToEnd());
                printText = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void repeatNum_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //백스페이스 허용
            if (e.KeyChar == '\b') return;
            //숫자 이외의 값 허용 안함
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            switch (device_num)
            {
                case PTR_NUM:
                    {
                        axOPOSPOSPrinter1.DeviceEnabled = false;
                        axOPOSPOSPrinter1.ReleaseDevice();
                        axOPOSPOSPrinter1.Close();
                    }
                    break;
                case SCN_NUM:
                    {
                        axOPOSScanner1.DeviceEnabled = false;
                        axOPOSScanner1.ReleaseDevice();
                        axOPOSScanner1.Close();
                        result_tb.Clear();
                    }
                    break;
                case MSR_NUM:
                    {
                        axOPOSMSR1.DeviceEnabled = false;
                        axOPOSMSR1.ReleaseDevice();
                        axOPOSMSR1.Close();
                        track1_tb.Clear();
                        track2_tb.Clear();
                        track3_tb.Clear();
                    }
                    break;
                case CDP_NUM:
                    {
                        axOPOSLineDisplay1.ClearText();
                        axOPOSLineDisplay1.DeviceEnabled = false;
                        axOPOSLineDisplay1.ReleaseDevice();
                        axOPOSLineDisplay1.Close();
                    }
                    break;
                default: break;
            }
        }        

        private void open_btn_Click(object sender, EventArgs e)
        {
            switch (device_num)
            {
                case PTR_NUM:
                    {
                        returnCode_open = axOPOSPOSPrinter1.Open(ldn_cb.Text);
                        returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
                        axOPOSPOSPrinter1.DeviceEnabled = true;
                        returnCodeString = return_ErrorCode(returnCode_open);
                        returnCodeOpn_tb.Text = returnCodeString + "(" + returnCode_open + ")";

                        returnCodeClm_tb.Text = returnCode_claim + "";
                    }
                    break;
                case SCN_NUM:
                    {
                        axOPOSScanner1.Open(ldn_cb.Text);
                        axOPOSScanner1.ClaimDevice(1000);
                        axOPOSScanner1.DeviceEnabled = true;
                        result_tb.Clear();
                    }
                    break;
                case MSR_NUM:
                    {
                        axOPOSMSR1.Open(ldn_cb.Text);
                        axOPOSMSR1.ClaimDevice(1000);
                        axOPOSMSR1.DeviceEnabled = true;
                        track1_tb.Clear();
                        track2_tb.Clear();
                        track3_tb.Clear();
                    }
                    break;
                case CDP_NUM:
                    {
                        axOPOSLineDisplay1.Open(ldn_cb.Text);
                        axOPOSLineDisplay1.ClaimDevice(10000);
                        axOPOSLineDisplay1.DeviceEnabled = true;
                    }
                    break;
                default: break;
            }
        }

        private string return_ErrorCode(int returnCode)
        {
            string return_errorcode="";
            switch (returnCode)
            {
                case OPOSERR:           return_errorcode = "OPOSERR";           break;
                case OPOS_SUCCESS:      return_errorcode = "OPOS_SUCCESS";      break;
                case OPOS_E_CLOSED:     return_errorcode = "OPOS_E_CLOSED";     break;
                case OPOS_E_CLAIMED:    return_errorcode = "OPOS_E_CLAIMED";    break;
                case OPOS_E_NOTCLAIMED: return_errorcode = "OPOS_E_NOTCLAIMED"; break;
                case OPOS_E_NOSERVICE:  return_errorcode = "OPOS_E_NOSERVICE";  break;
                case OPOS_E_DISABLED:   return_errorcode = "OPOS_E_DISABLED";   break;
                case OPOS_E_NOHARDWARE: return_errorcode = "OPOS_E_NOHARDWARE"; break;
                case OPOS_E_OFFLINE:    return_errorcode = "OPOS_E_OFFLINE";    break;
                case OPOS_E_ILLEGAL:    return_errorcode = "OPOS_E_ILLEGAL";    break;
                case OPOS_E_NOEXIST:    return_errorcode = "OPOS_E_NOEXIST";    break;
                case OPOS_E_EXISTS:     return_errorcode = "OPOS_E_EXISTS";     break;
                case OPOS_E_FAILURE:    return_errorcode = "OPOS_E_FAILURE";    break;
                case OPOS_E_TIMEOUT:    return_errorcode = "OPOS_E_TIMEOUT";    break;
                case OPOS_E_BUSY:       return_errorcode = "OPOS_E_BUSY";       break;
                case OPOS_E_EXTENDED:   return_errorcode = "OPOS_E_EXTENDED";   break;
                default:                return_errorcode = "ERROR";             break;
            }
            return return_errorcode;
        }
    }
}
