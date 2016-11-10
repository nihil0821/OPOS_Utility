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

        int device_num = 1;
        String track1, track2, track3;
        String defualtReciptText =
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
                "감사합니다.                          \n" +
            "잘 지내고 있어요. 당신은요?挺好的。您呢？  반복Tǐng hǎo de.Nín ne？팅 하오 더.닌 너?저도 잘 지내고 있어요.我也很好。  반복Wǒ yě hěn hǎo워 예 헌 하오만나서 반가웠어요.다음에 또 만나요.见到您很高兴，再见。  반복Jiàndào nín hěn gāoxìng，zàijiàn젠따오 닌 헌 까오싱, 짜이젠네, 그럼 안녕히 가세요.好的，再见。  반복Hǎo de，zàijiàn하오 더, 짜이젠==================J===================안녕하세요. (점심)こんにちは。  반복곤니찌와안녕하세요. (점심)こんにちは。  반복곤니찌와어떻게 지내세요?どうお過すごしですか。  반복도- 오스고시데스카?잘 지내고 있어요.당신은요?元気げんきです。あなたは？  반복겐키데스. 아나타와?저도 잘 지내고 있어요.私わたしも元気げんきです。  반복와타시모 겐키데스만나서 반가웠어요.다음에 또 만나요.お会あいできて、うれしかったです。また、会あいましょう。  반복오아이데키테 우레시캇타데스.마타 아이마쇼-네, 그럼 안녕히 가세요.はい、お気きをつけて。  반복하이, 오키오츠케테=====================V==================안녕하세요.Xin chào.  반복씬 짜오안녕하세요. 만나서 반가워요.Chào chị, rất vui được gặp chị.반복짜오 찌, 젓 부이 드억 갑 찌어떻게 지내세요?Dạo này anh thế nào?  반복자오 나이 아잉 테 나오?잘 지내고 있어요.당신은요?Tôi bình thường. Còn anh?  반복또이 빙 트엉. 꼰 아잉?저도 잘 지내고 있어요.Tôi cũng khỏe.반복또이 꿍 쾌만나서 반가웠어요. 다음에 또 만나요.Rất vui được gặp chị.Hẹn gặp lại nhé.  반복젓 부이 드억 갑 찌. 헨 갑 라이 녜네, 그럼 안녕히 가세요.Vâng, anh đi ạ.반복벙, 아잉 디 아===========================================";

        String printText = "";

        Boolean isDefaultText = true;


        public Form1()
        {
            InitializeComponent();
            init_visible();
            StringToUTF8();
        }

        private void StringToUTF8()
        {
            string sample = "테스트";
            //인코딩 방식을 지정
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            //변환하고자 하는 문자열을 UTF8 방식으로 변환하여 byte 배열로 반환
            byte[] utf8Bytes = utf8.GetBytes(defualtReciptText);

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

            defualtReciptText = Unicode;
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
            repeatNum_tb.Text = "1";
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
                        int repeatNum = int.Parse(repeatNum_tb.Text);
                        if(isDefaultText)
                        {
                            printText = defualtReciptText;
                        }
                        for (int i = 0; i < repeatNum; i++)
                        {
                            int ret = axOPOSPOSPrinter1.PrintNormal(PTR_S_RECEIPT, printText);
                        }

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
            isDefaultText = false;
            test_btn.Text = "OPEN FILE TEXT TEST";
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

        private void defualtTxt_btn_Click(object sender, EventArgs e)
        {
            isDefaultText = true;
            test_btn.Text = "DEFAULT TEST";
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
