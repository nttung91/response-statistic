using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace ResponeTimeStatistic
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }
        List<Request> l = new List<Request>();
        XDocument doc;
        private void LoadDataFromFile(XDocument doc,string RequestTag) {
            try
            {
                //lấy dữ liệu theo thẻ được chọn từ người dùng
                var data = from d in doc.Descendants(cboRequestTag.SelectedValue.ToString().Trim())
                           select new Request(long.Parse(d.Attribute("ts").Value), long.Parse(d.Attribute("t").Value), d.Attribute("rm").Value);
                //chuyển thành kiểu list
                l = data.ToList();
                //tính thời gian bắt đầu và kết thúc trong file test
                long timestart = data.FirstOrDefault().StartTime;
                long endtime = data.Max(x => x.StartTime + x.ResponeTime);
                //đếm số lượng request thành công vs tổng số request
                int SuccessCount = 0;
                SuccessCount = (from r in l
                                where r.ResponeStatus.Equals("OK")
                                select r).Count();

                int Count = l.Count;
                Console.WriteLine("Request sent:" + Count);
                //hiển thị các thông số của file ra màn hình.
                DateTime date1170 = DateTime.Parse("1/1/1970");
                DateTime date = new DateTime(timestart * 10000 + date1170.Ticks);
                lblStartTime.Text = date.ToShortDateString() + " " + date.ToShortTimeString();

                TimeSpan duration = (new DateTime(endtime * 10000 + date1170.Ticks)).Subtract(date);
                lblEndTime.Text = duration.ToString();
                lblTenFile.Text = openFileDialog1.SafeFileName;
                lblSize.Text = openFileDialog1.OpenFile().Length / 1024 + " KB";
                lblNumberOfRequest.Text = Count + "";
            }
            catch (Exception ex) {
                MessageBox.Show("Dữ liệu không đúng. Vui lòng kiểm tra lại.");
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {


            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.

            if (userClickedOK == DialogResult.OK)
            {

                this.Enabled = false;
               
                // Open the selected file to read.
                //bool isvalid = XElement.
                try
                {
                    doc = XDocument.Load(openFileDialog1.FileName);
                } catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    this.Enabled = true;
                    return;
                    }
                txtPath.Text = openFileDialog1.FileName;
                //cac request
                var allElementNames = (from ex in doc.Descendants()
                                       select ex.Name).Distinct();
                List<string> Tags = new List<string>();
                int maxVal = 0 ;
                int max = 0;
                int i=0;
                foreach (XName item in allElementNames)
                {
                    int count = (from d in doc.Descendants(item) select d).Count();
                    if (count > max)
                    {
                        max = count;
                        maxVal = i;
                    }
                    Tags.Add(item.LocalName);
                    i++;
                }
                cboRequestTag.DataSource = Tags;
                cboRequestTag.SelectedIndex = maxVal;

                this.Enabled = true;

            }
        }

        private void DrawGraph()
        {
            //lay thong so test
            int MaxThread = (int)nudMaxThread.Value;
            int FirstDelayTime = (int)nudFirstDelay.Value;
            int ThreadIncrement = (int)nudThreadIncrement.Value;
            int RamupTime = (int)nudRamupTime.Value;
            int LevelDuration = (int)nudLevelDuration.Value;
            List<double> listPositon = StatisticReport.StatisticByLevel(l, (LevelDuration + RamupTime) * 1000, MaxThread / ThreadIncrement);
            if (listPositon == null || listPositon.Count == 0)
            {
                MessageBox.Show("Nothing to draw");
                return;
            }
            //thiet lap cac thong so cho do thi
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.PointValueFormat = "0.000";
            zedGraphControl1.PointDateFormat = "d";
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Respone time Avg";
            myPane.XAxis.Title.Text = "Level 1 - 7";
            myPane.YAxis.Title.Text = "Respone time in sec";
            //////////////////////////

            //chieu x
            myPane.XAxis.Scale.Min = 0;  //
            myPane.XAxis.Scale.Max = MaxThread/10+10; //
            myPane.XAxis.Scale.MinorStep = 5;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5
            //chieu y
            double maxY = listPositon.Max();
            myPane.YAxis.Scale.Min = 0;  // Min  = 0;
            myPane.YAxis.Scale.Max = (int)(maxY * 1.2); // Mã  = 30;
            myPane.YAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.YAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5

            myPane.AxisChange();
            //khoi tao do hoa
            //////////////////////////////////////////////////////
            myPane.Title.Text = "Respone time Avg";
            myPane.XAxis.Title.Text = "Level 1 - " + MaxThread / ThreadIncrement;
            myPane.YAxis.Title.Text = "Respone time in sec";

            RollingPointPairList list = new RollingPointPairList(1200);
            LineItem curve = myPane.AddCurve("Thời gian đáp ứng trung bình", list, Color.Red, SymbolType.None);

            myPane.AxisChange();


            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            // Kiểm tra việc khởi tạo các đường curve
            // Đưa về điểm xuất phát
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            if (curve1 == null)
                return;
            // list chứa các điểm. 
            // Get the PointPairList
            IPointListEdit list1 = curve1.Points as IPointListEdit;

            
            
            zedGraphControl1.GraphPane.YAxis.Scale.Max = (int)(listPositon.Max() * 1.1) / 1000;
            zedGraphControl1.AxisChange();
            listPositon.Insert(0, 0);
            for (int i = 0; i < listPositon.Count; i++)
            {
                TextObj text = new TextObj(String.Format("{0}", Math.Round(listPositon.ElementAt(i) / 1000.0, 1)), i * 10, listPositon.ElementAt(i) / 1000.0);
                list1.Add(i * 10, listPositon.ElementAt(i) / 1000.0);
                zedGraphControl1.GraphPane.GraphObjList.Add(text);
            }

            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();
            tctMain.SelectedTab = tpGraph;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.PointValueFormat = "0.000";
            zedGraphControl1.PointDateFormat = "d";
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Respone time Avg";
            myPane.XAxis.Title.Text = "Level 1 - 7";
            myPane.YAxis.Title.Text = "Respone time in sec";
            //////////////////////////


            RollingPointPairList list = new RollingPointPairList(1200);
            LineItem curve = myPane.AddCurve("Line 1", list, Color.Red, SymbolType.None);
            //chieu x
            myPane.XAxis.Scale.Min = 0;  // Min  = 0;
            myPane.XAxis.Scale.Max = 100; // Mã  = 30;
            myPane.XAxis.Scale.MinorStep = 5;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5
            //chieu y
            myPane.YAxis.Scale.Min = 0;  // Min  = 0;
            myPane.YAxis.Scale.Max = 50; // Mã  = 30;
            myPane.YAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.YAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5

            myPane.AxisChange();
            

        }
        private void ClearGraph() {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
        private void btnVe_Click(object sender, EventArgs e)
        {
            ClearGraph();
            DrawGraph();
            
            //MessageBox.Show("Xong");
            //long l = 1350482072131;
            //long l1 = (new DateTime(1970, 1, 1)).AddHours(7).Ticks;
            //DateTime d = new DateTime(l1 + l * 10000);
            //MessageBox.Show(d.ToLongTimeString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // MainForm_Load(sender, e);
            //zedGraphControl1.RestoreScale(DefaultPan);
            ClearGraph();

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (doc == null)
            {
                MessageBox.Show("Không tìm thấy dữ liệu. Vui lòng nạp dữ liệu để lọc.");
                return;
            }
            if (cboRequestTag.SelectedValue!=null){
                LoadDataFromFile(doc, cboRequestTag.SelectedValue.ToString().Trim());
            }
        }

        private void btnErrorPercent_Click(object sender, EventArgs e)
        {
            ClearGraph();
            int MaxThread = (int)nudMaxThread.Value;
            int FirstDelayTime = (int)nudFirstDelay.Value;
            int ThreadIncrement = (int)nudThreadIncrement.Value;
            int RamupTime = (int)nudRamupTime.Value;
            int LevelDuration = (int)nudLevelDuration.Value;
            List<double> listPositon = StatisticReport.ErrorPercentByLevel(l, (LevelDuration + RamupTime) * 1000, MaxThread / ThreadIncrement);
            if (listPositon == null || listPositon.Count == 0)
            {
                MessageBox.Show("Nothing to draw");
                return;
            }
            //thiet lap cac thong so cho do thi
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.PointValueFormat = "0.000";
            zedGraphControl1.PointDateFormat = "d";
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Tỉ lệ lỗi theo mức";
            myPane.XAxis.Title.Text = " Mức 1 - " + MaxThread / ThreadIncrement;
            myPane.YAxis.Title.Text = "Tỉ lệ lỗi (%)";
            //////////////////////////

            //chieu x
            myPane.XAxis.Scale.Min = 0;  //
            myPane.XAxis.Scale.Max = MaxThread / 10 + 10; //
            myPane.XAxis.Scale.MinorStep = 5;  // Đơn vị chia nhỏ nhất 1
            myPane.XAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5
            //chieu y
            double maxY = listPositon.Max();
            myPane.YAxis.Scale.Min = 0;  // Min  = 0;
            myPane.YAxis.Scale.Max = (int)(maxY * 1.2); // Mã  = 30;
            myPane.YAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            myPane.YAxis.Scale.MajorStep = 10; // Đơn vị chia lớn 5

            myPane.AxisChange();
            //khoi tao do hoa
            //////////////////////////////////////////////////////
         
            RollingPointPairList list = new RollingPointPairList(1200);
            LineItem curve = myPane.AddCurve("Tỉ lệ lỗi", list, Color.Red, SymbolType.None);

            myPane.AxisChange();


            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;
            // Kiểm tra việc khởi tạo các đường curve
            // Đưa về điểm xuất phát
            LineItem curve1 = zedGraphControl1.GraphPane.CurveList[0] as LineItem;

            if (curve1 == null)
                return;
            // list chứa các điểm. 
            // Get the PointPairList
            IPointListEdit list1 = curve1.Points as IPointListEdit;



            //zedGraphControl1.GraphPane.YAxis.Scale.Max = (int)(listPositon.Max() * 1.1) / 1000;
            //zedGraphControl1.AxisChange();
            listPositon.Insert(0, 0);
            for (int i = 0; i < listPositon.Count; i++)
            {
                TextObj text = new TextObj(String.Format("{0}", Math.Round(listPositon.ElementAt(i), 1)), i * 10, listPositon.ElementAt(i));
                list1.Add(i * 10, listPositon.ElementAt(i));
                zedGraphControl1.GraphPane.GraphObjList.Add(text);
            }
            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();
            tctMain.SelectedTab = tpGraph;
        }

        
    }
}
