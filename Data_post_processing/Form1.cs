using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Data_post_processing
{
    public partial class Form1 : Form
    {
        DataTable InputDT = new DataTable();
        DataTable OutputDT = new DataTable();
        OpenFileDialog input_path = new OpenFileDialog();
        //FolderBrowserDialog input_path = new FolderBrowserDialog();
        //SaveFileDialog input_path = new SaveFileDialog();
        FolderBrowserDialog output_path = new FolderBrowserDialog();

        List<double> InputAverage = new List<double>();
        List<double> InputSD = new List<double>();
        List<double> OutputAverage = new List<double>();
        List<double> OutputSD = new List<double>();
        List<double> ratio = new List<double>();
        List<double> InPower = new List<double>();
        List<double> OutPower = new List<double>();
        List<double> eff = new List<double>();
        List<double> sumation = new List<double>
                {
                    0.00,
                    0.00,
                    0.00,
                    0.00
                };
        List<double> SD_add = new List<double>
                {
                    0.00,
                    0.00,
                    0.00,
                    0.00
                };
        List<int> Column_Amount = new List<int>();
        int col = 0;
        int row = 0;
        int mutiple = 0;
        int sigB = 0;
        int avrB = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void IBrowse_Click(object sender, EventArgs e)
        {
            input_path.Filter = "逗號分隔值 (*.csv*)|*.csv";
            input_path.ShowDialog();
            IPath.Text = input_path.FileName;
        }

        private void OBrowse_Click(object sender, EventArgs e)
        {
            
            output_path.ShowDialog();
            OPath.Text = output_path.SelectedPath;
        }

        private void ReadCSV_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            StreamReader s = new StreamReader(input_path.FileName, Encoding.Default);
            //string ss = s.ReadLine();//skip the first line
            string[] columns = s.ReadLine().Split(',');
            ds.Tables.Add();
            foreach (string col in columns)
            {
                bool added = false;
                string next = "";
                int i = 0;
                while (!added)
                {
                    string columnname = col + next;
                    columnname = columnname.Replace("#", "");
                    columnname = columnname.Replace("'", "");
                    columnname = columnname.Replace("&", "");

                    if (!ds.Tables[0].Columns.Contains(columnname))
                    {
                        ds.Tables[0].Columns.Add(columnname.ToUpper());
                        added = true;
                    }
                    else
                    {
                        i++;
                        next = "_" + i.ToString();
                    }
                }
            }

            string AllData = s.ReadToEnd();
            string[] rows = AllData.Split('\n');

            foreach (string r in rows)
            {
                string[] items = r.Split(',');
                ds.Tables[0].Rows.Add(items);
            }

            s.Close();
            InputDT = ds.Tables[0];
            dataGridView1.DataSource = InputDT;
            dataGridView1.Update();
            dataGridView2.DataSource = OutputDT;
            dataGridView2.Update();
            textBox1.AppendText((InputDT.Rows.Count).ToString()+"\n");
            Calculas.Enabled = true;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Calculas_Click(object sender, EventArgs e)
        {
            Column_Amount.Clear();
            OutputDT.Clear();
            OutputDT = InputDT.Copy();
            col = 0;
            col = InputDT.Columns.Count;
            row = 0;
            row = InputDT.Rows.Count;
            mutiple = 0;
            mutiple = int.Parse(txt_multi.Text);
            sigB = 0;
            sigB = int.Parse(txt_sigB.Text);
            avrB = 0;
            avrB = int.Parse(txt_avrB.Text);
            InputAverage.Clear();
            InputSD.Clear();
            OutputAverage.Clear();
            OutputSD.Clear();

            if (checkBox1.Checked)
            {
                avrB = sigB;
            }

            for (int i = 0; i < InputDT.Columns.Count; i++)
            {
                int temp = 0;
                for(int j = 0; j < InputDT.Rows.Count; j++)
                {
                    if(OutputDT.Rows[j][i].ToString() != "")
                    {
                        temp += 1;
                    }
                }
                Column_Amount.Add(temp);
                textBox1.AppendText("col[" + i + "]=" + Column_Amount[i] + "\n");
            }
            List<double> sum = new List<double>();
            
            //int target_col = 1;

            for (int target_col = 0; target_col < col; target_col++)
            {
                
                int amount = 2 * sigB;
                int test_row = 0;
                textBox1.AppendText(test_row + "\n");
                for (int i = sigB; i < Column_Amount[target_col] - sigB; i++)
                {
                    
                    double sumation = 0.00;

                    for (int j = -sigB; j <= sigB; j++)
                    {
                        sumation += double.Parse(OutputDT.Rows[i + j][target_col].ToString());
                    }
                    double mu = sumation / (amount+1);
                    double sigma = 0.00;
                    for (int j = -sigB; j <= sigB; j++)
                    {
                        double temp = double.Parse(OutputDT.Rows[i + j][target_col].ToString()) - mu;
                        temp = temp * temp;
                        sigma += temp;
                    }
                    sigma = Math.Sqrt(sigma / amount);
                    if (Math.Abs(double.Parse(OutputDT.Rows[i][target_col].ToString()) - mu) > mutiple * sigma)
                    {
                        if (checkBox3.Checked)
                        {
                            textBox1.AppendText(OutputDT.Rows[i][target_col].ToString() + ">>");
                            OutputDT.Rows[i][target_col] = mu;
                            textBox1.AppendText(OutputDT.Rows[i][target_col].ToString() + "\n");
                        }
                        else
                        {
                            OutputDT.Rows[i][target_col] = mu;
                        }
                        
                    }
                    //textBox1.AppendText(sigma.ToString() + "\n");
                }
                textBox1.AppendText("Switch" + target_col.ToString() + "\n");
            }



            //均值化==============================
            int amount_B = 2 * avrB + 1;
            for (int target_col = 0; target_col < col; target_col++)
            {
                for (int i = Math.Max(avrB, sigB); i < Column_Amount[target_col] - avrB; i++)
                {
                    double sumation = 0.00;

                    for (int j = -avrB; j <= avrB; j++)
                    {
                        sumation += double.Parse(OutputDT.Rows[i + j][target_col].ToString());
                    }
                    double mu = sumation / amount_B;

                    //textBox2.AppendText(OutputDT.Rows[i][target_col].ToString() + ">>");
                    OutputDT.Rows[i][target_col] = mu;
                    //textBox2.AppendText(OutputDT.Rows[i][target_col].ToString() + "\n");
                    //textBox1.AppendText(sigma.ToString() + "\n");
                }
                //textBox1.AppendText("Switch" + target_col.ToString() + "\n");
            }


            if (checkBox2.Checked)
            {
                OutputDT.Columns.Add("減速比");
                OutputDT.Columns.Add("輸入端功率(W)");
                OutputDT.Columns.Add("輸出端功率(W)");
                OutputDT.Columns.Add("效率");
                int block = Math.Max(avrB, sigB);
                int count = 0;
                for(int i = 0; i < 4; i++)
                {
                    sumation[i] = 0.00;
                    SD_add[i] = 0.00;
                }

                for (int i = block; i < row- block-1; i++)
                {
                    count++;
                    OutputDT.Rows[i]["減速比"] = double.Parse(OutputDT.Rows[i][0].ToString()) / double.Parse(OutputDT.Rows[i][2].ToString());
                    sumation[0] += double.Parse(OutputDT.Rows[i]["減速比"].ToString());
                    OutputDT.Rows[i]["輸入端功率(W)"] = double.Parse(OutputDT.Rows[i][0].ToString()) * double.Parse(OutputDT.Rows[i][1].ToString())/9545.2*1000;  //9545.2=(100/9.8)/97400
                    sumation[1] += double.Parse(OutputDT.Rows[i]["輸入端功率(W)"].ToString());
                    OutputDT.Rows[i]["輸出端功率(W)"] = double.Parse(OutputDT.Rows[i][2].ToString()) * double.Parse(OutputDT.Rows[i][3].ToString())/9545.2*1000;
                    sumation[2] += double.Parse(OutputDT.Rows[i]["輸出端功率(W)"].ToString());
                    OutputDT.Rows[i]["效率"] = double.Parse(OutputDT.Rows[i]["輸出端功率(W)"].ToString()) / double.Parse(OutputDT.Rows[i]["輸入端功率(W)"].ToString())*100.00;
                    sumation[3] += double.Parse(OutputDT.Rows[i]["效率"].ToString());
                }
                for (int i = 0; i < 4; i++)
                {
                    sumation[i] = sumation[i] / count;
                }
                for (int i = block; i < row - block-1; i++)
                {
                    double temp = 0.00;
                    temp = double.Parse(OutputDT.Rows[i]["減速比"].ToString())- sumation[0];
                    SD_add[0] += temp * temp;
                    temp = double.Parse(OutputDT.Rows[i]["輸入端功率(W)"].ToString()) - sumation[1];
                    SD_add[1] += temp * temp;
                    temp = double.Parse(OutputDT.Rows[i]["輸出端功率(W)"].ToString()) - sumation[2];
                    SD_add[2] += temp * temp;
                    temp = double.Parse(OutputDT.Rows[i]["效率"].ToString()) - sumation[3];
                    SD_add[3] += temp * temp;
                }
                for (int i = 0; i < 4; i++)
                {
                    SD_add[i] = Math.Sqrt(SD_add[i] / count);
                }

            }

            //計算Resault.txt 資料

            int outputcol = OutputDT.Columns.Count;
            for (int target_col = 0; target_col < col; target_col++)
            {
                double sumation_out = 0.00;
                double sumation_in = 0.00;
                
                int block = Math.Max(avrB, sigB);
                int total = Column_Amount[target_col] - 2 * block;

                for (int i = block; i < Column_Amount[target_col] - block; i++)
                {
                    if (ABS_Mode.Checked)
                    {
                        sumation_out += Math.Abs(double.Parse(OutputDT.Rows[i][target_col].ToString()));
                        sumation_in  += Math.Abs(double.Parse(InputDT.Rows[i][target_col].ToString()));
                    }
                    else
                    {
                        sumation_out += double.Parse(OutputDT.Rows[i][target_col].ToString());
                        sumation_in  += double.Parse(InputDT.Rows[i][target_col].ToString());
                    }
                    
                    //total++;
                }
                double avr_out = sumation_out / total;
                double avr_in = sumation_in / total;
                double sigma_out = 0.00;
                double sigma_in = 0.00;
                for (int i = block; i < Column_Amount[target_col] - block; i++)
                {
                    double temp_out = 0.00;
                    double temp_in = 0.00;

                    if (ABS_Mode.Checked)
                    {
                        temp_out = Math.Abs(double.Parse(OutputDT.Rows[i][target_col].ToString())) - avr_out;
                        temp_in  = Math.Abs(double.Parse(InputDT.Rows[i][target_col].ToString())) - avr_in;
                    }
                    else
                    {
                        temp_out = double.Parse(OutputDT.Rows[i][target_col].ToString()) - avr_out;
                        temp_in = double.Parse(InputDT.Rows[i][target_col].ToString()) - avr_in;
                    }
                    
                    temp_out = temp_out * temp_out;
                     temp_in =  temp_in * temp_in;
                     sigma_in += temp_in;
                    sigma_out += temp_out;
                }
                sigma_in = Math.Sqrt(sigma_in / total);
                sigma_out = Math.Sqrt(sigma_out/ total);
                
                InputAverage.Add(avr_in);
                InputSD.Add(sigma_in);
                
                OutputAverage.Add(avr_out);
                OutputSD.Add(sigma_out);

                double IO_avr = (avr_out-avr_in) / avr_in ;
                //textBox1.AppendText("I_RES_" + target_col.ToString() + ":(" + avr_in.ToString("F3") + "/" + sigma_in.ToString("F3") + ")\n");
                //textBox1.AppendText("O_RES_" + target_col.ToString() + ":(" + avr_out.ToString("F3") + "/" + sigma_out.ToString("F3") + ")\n");
                //textBox1.AppendText("(AVR = " + IO_avr.ToString("P3") + ")\n");
            }


            dataGridView1.DataSource = InputDT;
            dataGridView1.Update();
            dataGridView2.DataSource = OutputDT;
            dataGridView2.Update();

            SaveDT.Enabled = true;
            //textBox1.AppendText(sum.ToString() + "\n");
        }

        private void SaveDT_Click(object sender, EventArgs e)
        {
            string data = "";
            string FileStr = output_path.SelectedPath;
            string RESFileStr = output_path.SelectedPath;
            RESFileStr += "Resault_" + input_path.SafeFileName;
            RESFileStr = RESFileStr.Substring(0, RESFileStr.Length - 4);
            RESFileStr += ".txt";

            FileStr += "Posted_" + input_path.SafeFileName;
            textBox1.AppendText(FileStr+"\n");
            textBox1.AppendText(RESFileStr + "\n");

            StreamWriter wr = new StreamWriter(FileStr, false, Encoding.Default);
            foreach (DataColumn column in OutputDT.Columns)
            {
                data += column.ColumnName + ",";
            }
            data += "\n";
            wr.Write(data);
            data = "";


                int block = Math.Max(sigB, avrB);
            for (int i = block; i < row-block-1;i++)
            {
                foreach (DataColumn column in OutputDT.Columns)
                {
                    data += OutputDT.Rows[i][column].ToString().Trim() + ",";
                }
                data += "\n";
                wr.Write(data);
                data = "";
            }
            wr.Dispose();
            wr.Close();

            StreamWriter resault = new StreamWriter(RESFileStr, false, Encoding.Default);
            string res_output =
                "=============資料後處理結果============\r\n" +
                "全域設定：\n" +
                "篩選倍率：" + mutiple + "\r\n" +
                "標準化區間值：" + sigB + "\r\n" +
                "均質化區間值：" + avrB + "\r\n" +
                "Resault.txt 絕對值模式："+ABS_Mode.Checked + "\r\n" +
                "******************************************\r\n";
            resault.Write(res_output);
            for(int i = 0; i < col; i++)
            {
                resault.Write(columnRes(i, InputAverage[i], InputSD[i], OutputAverage[i], OutputSD[i]));
            }
            if (checkBox2.Checked)
            {
                for (int i = 0; i < 4; i++)
                {
                    resault.Write(AddcolumnRes(i + 6, sumation[i], SD_add[i]));
                }
            }
            
            resault.Dispose();
            resault.Close();
        }

        public string columnRes(int targetcolumn, double before_avr, double before_SD, double average, double SD)
        {
            string s =
                OutputDT.Columns[targetcolumn].ColumnName + "\t欄位[" + targetcolumn + "]\r\n" +
                "資料筆數："+Column_Amount[targetcolumn] + "\r\n" +
                "處理前平均值：" + before_avr.ToString("F4") + "\r\n" +
                "處理前標準差：" + before_SD.ToString("F4") + "\r\n" +
                "標準差/平均值 = " + (before_SD / before_avr).ToString("P3") + "\r\n" +
                "------------------------------\r\n" +
                "處理後平均值：" + average.ToString("F4") + "\r\n" +
                "處理後標準差：" + SD.ToString("F4") + "\r\n" +
                "標準差/平均值 = " + (SD / average).ToString("P3") + "\r\n" +
                "*******************************************************\r\n";
            return s;
        }

        public string AddcolumnRes(int targetcolumn, double before_avr, double before_SD)
        {
            string s =
                "欄位[" + targetcolumn + "]>>>" + OutputDT.Columns[targetcolumn].ColumnName + "\r\n" +
                "平均值：" + before_avr.ToString("F4") + "\r\n" +
                "標準差：" + before_SD.ToString("F4") + "\r\n" +
                "標準差/平均值 = " + (before_SD / before_avr).ToString("P3") + "\r\n" +
                "*******************************************************\r\n";
            return s;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_avrB.Enabled = !checkBox1.Checked;
        }
    }
}
