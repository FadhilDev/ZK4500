using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
using AxZKFPEngXControl;
using DevExpress.XtraEditors;
namespace fingerPrint
{
    public partial class Form1 : XtraForm
    {


        public AxZKFPEngX ZkFprint = new AxZKFPEngX();
        public static SpeechSynthesizer Synth = new SpeechSynthesizer();
        public bool Check;

        public Form1()
        {
            InitializeComponent();
            Controls.Add(ZkFprint);
            InitialAxZkfp();
        }

        //Methodes to intialis the object by raising event
        private void InitialAxZkfp()
        {
            
            ZkFprint.OnImageReceived += zkFprint_OnImageReceived;
            ZkFprint.OnFeatureInfo += zkFprint_OnFeatureInfo;
            //zkFprint.OnFingerTouching += (sender, e) =>
            //{
            //    ShowHintInfo("...ضع الاصبع");
            //};
            //zkFprint.OnFingerLeaving += (sender, e) =>
            //{

            //    ShowHintInfo("...الاصبع غير موجود");
            //};
            ZkFprint.OnEnroll += zkFprint_OnEnroll;



        }



        //Speake avoice
        private static void play_voice(string str)
        {
            Synth.SpeakAsyncCancelAll();
            //_synth.Speak(str);
            Synth.SpeakAsync(str);
        }
        //Show hint information
        private void ShowHintInfo(String s)
        {
            if (s != "")
            {
                txtMemoHint.AppendText(s + Environment.NewLine);
            }
        }
        //show error and correct images
        private void ShowHintImage(int iType)
        {
            if (iType == 0)
            {
                imgNO.Visible = false;
                imgOK.Visible = false;
            }
            else if (iType == 1)
            {
                imgNO.Visible = false;
                imgOK.Visible = true;
            }
            else if (iType == 2)
            {
                imgNO.Visible = true;
                imgOK.Visible = false;
            }
        }

        //Operation
        private void btnInitial_Click_1(object sender, EventArgs e)
        {

            if (ZkFprint.InitEngine() == 0)
            {
                ZkFprint.FPEngineVersion = "9";
                ZkFprint.EnrollCount = 3;
                play_voice(" sensor⁯ initialization succeeds");
                txtSerial.Text = ZkFprint.SensorSN;
                txtCount.Text = ZkFprint.SensorCount.ToString();
                txtIndex.Text = ZkFprint.SensorIndex.ToString();
                btnInitial.Enabled = false;
                btnEndReg.Enabled = true;
                btnRegister.Enabled = true;
                btnVerify.Enabled = true;
                txtName.Enabled = true;
                txtAge.Enabled = true;
                ShowHintInfo("تم ربط الجهاز بنجاح ...");

            }

            else
            {

                ShowHintInfo("فشل ربط الجهاز تاكد من توصيل الجهاز");
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtAge.Text == string.Empty)
            {
                XtraMessageBox.Show("الرجاء ملىء الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
                return;
            }
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo(" جار عملية التسجيل ...ضع اصبعك من فضلك");
            ShowHintImage(0);
        }


        private void zkFprint_OnImageReceived(object sender, IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = picEdite1.CreateGraphics();
            Bitmap bmp = new Bitmap(picEdite1.Width, picEdite1.Height);
            g = Graphics.FromImage(bmp);
            int dc = g.GetHdc().ToInt32();
            ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            picEdite1.Image = bmp;
        }

        private void zkFprint_OnFeatureInfo(object sender, IZKFPEngXEvents_OnFeatureInfoEvent e)
        {

            //String strTemp = "جودة البصمة ";
            //if (e.aQuality != 0)
            //{

            //    strTemp = strTemp + " ضعيفة";
            //}
            //else
            //{

            //    strTemp = strTemp + "جيدة";
            //}
            String strTemp = string.Empty;
            if (ZkFprint.EnrollIndex != 1)
            {
                if (ZkFprint.IsRegister)
                {
                    if (ZkFprint.EnrollIndex - 1 > 0)
                    {
                        strTemp = $"ضع اصبعك مجدداً ({ZkFprint.EnrollIndex - 1}) مرة...";
                    }
                }
            }
            ShowHintInfo(strTemp);
        }
        private void zkFprint_OnEnroll(object sender, IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (e.actionResult)
            {
                var dt = SqliteDbAccess.ReturnDataTable("SELECT * FROM Users", null);
                var dt2 = dt.Clone();
                foreach (DataRow dr in dt.Rows)
                {
                    string regTmp = ZkFprint.EncodeTemplate1(e.aTemplate);
                    if (ZkFprint.VerFingerFromStr(ref regTmp, dr["FingerPrintTemplate"].ToString(), false, ref Check))
                    {
                        XtraMessageBox.Show("البصمة موجوده مسبقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowHintInfo("البصمة موجوده مسبقا");
                        ShowHintImage(1);
                        int id = Convert.ToInt32(dr["Id"]);
                        dt2.Rows.Add(dr.ItemArray);
                        gvc.DataSource = dt2;

                        return;
                    }
                }
                SQLiteParameter[] prm = new SQLiteParameter[3];
                prm[0] = new SQLiteParameter("@Name", txtName.Text);
                prm[1] = new SQLiteParameter("@Age", txtAge.Text);
                prm[2] = new SQLiteParameter("@FingerPrintTemplate", ZkFprint.EncodeTemplate1(e.aTemplate));
                SqliteDbAccess.ExcuteData("INSERT INTO Users(Name,Age,FingerPrintTemplate) VALUES (@Name,@Age,@FingerPrintTemplate)", prm);
                XtraMessageBox.Show("تمت عملية التسجيل بنجاح ", "تسجيل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowHintInfo("فشل عملية التسجيل");
                XtraMessageBox.Show("فشل عملية التسجيل ", "تسجيل ", MessageBoxButtons.OK);

            }
        }
        private void zkFprint_OnCapture(object sender, IZKFPEngXEvents_OnCaptureEvent e)
        {
            DataTable dt;
            DataTable dt2;
            dt = SqliteDbAccess.ReturnDataTable("SELECT * FROM Users", null);
            dt2 = dt.Clone();
            foreach (DataRow dr in dt.Rows)
            {
                string regTmp = ZkFprint.EncodeTemplate1(e.aTemplate);
                if (ZkFprint.VerFingerFromStr(ref regTmp, dr["FingerPrintTemplate"].ToString(), false, ref Check))
                {
                    ShowHintInfo("نجاح عمليةالتحقق");
                    ShowHintImage(1);
                    dt2.Rows.Add(dr.ItemArray);
                    gvc.DataSource = dt2;

                    return;
                }

                ShowHintImage(2);
                gvc.DataSource = null;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ZkFprint.EndEngine();
            btnInitial.Enabled = true;
            btnEndReg.Enabled = false;
            txtSerial.Text = string.Empty;
            txtCount.Text = string.Empty;
            txtIndex.Text = string.Empty;
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
            }
            ZkFprint.OnCapture += zkFprint_OnCapture;
            ZkFprint.BeginCapture();
            ShowHintInfo("جار عملية التحقق ضع اصبعك من فضلك ...");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEndReg.Enabled = false;
            ShowHintImage(0);
        }

    }

}







