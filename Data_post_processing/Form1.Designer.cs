﻿namespace Data_post_processing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.IPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OPath = new System.Windows.Forms.TextBox();
            this.IBrowse = new System.Windows.Forms.Button();
            this.OBrowse = new System.Windows.Forms.Button();
            this.ReadCSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveDT = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Calculas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_multi = new System.Windows.Forms.TextBox();
            this.txt_sigB = new System.Windows.Forms.TextBox();
            this.txt_avrB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ABS_Mode = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pack_path = new System.Windows.Forms.TextBox();
            this.pack_process = new System.Windows.Forms.Button();
            this.pack_folderpick = new System.Windows.Forms.Button();
            this.pack_floder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.packProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(915, 795);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IPath
            // 
            this.IPath.Location = new System.Drawing.Point(82, 15);
            this.IPath.Name = "IPath";
            this.IPath.Size = new System.Drawing.Size(258, 22);
            this.IPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入檔案：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "輸出檔案：";
            // 
            // OPath
            // 
            this.OPath.Location = new System.Drawing.Point(82, 38);
            this.OPath.Name = "OPath";
            this.OPath.Size = new System.Drawing.Size(258, 22);
            this.OPath.TabIndex = 4;
            // 
            // IBrowse
            // 
            this.IBrowse.Location = new System.Drawing.Point(346, 15);
            this.IBrowse.Name = "IBrowse";
            this.IBrowse.Size = new System.Drawing.Size(75, 23);
            this.IBrowse.TabIndex = 5;
            this.IBrowse.Text = "瀏覽";
            this.IBrowse.UseVisualStyleBackColor = true;
            this.IBrowse.Click += new System.EventHandler(this.IBrowse_Click);
            // 
            // OBrowse
            // 
            this.OBrowse.Location = new System.Drawing.Point(346, 38);
            this.OBrowse.Name = "OBrowse";
            this.OBrowse.Size = new System.Drawing.Size(75, 23);
            this.OBrowse.TabIndex = 6;
            this.OBrowse.Text = "瀏覽";
            this.OBrowse.UseVisualStyleBackColor = true;
            this.OBrowse.Click += new System.EventHandler(this.OBrowse_Click);
            // 
            // ReadCSV
            // 
            this.ReadCSV.Location = new System.Drawing.Point(427, 14);
            this.ReadCSV.Name = "ReadCSV";
            this.ReadCSV.Size = new System.Drawing.Size(75, 23);
            this.ReadCSV.TabIndex = 7;
            this.ReadCSV.Text = "讀取";
            this.ReadCSV.UseVisualStyleBackColor = true;
            this.ReadCSV.Click += new System.EventHandler(this.ReadCSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_pack_path);
            this.groupBox1.Controls.Add(this.pack_process);
            this.groupBox1.Controls.Add(this.pack_folderpick);
            this.groupBox1.Controls.Add(this.SaveDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPath);
            this.groupBox1.Controls.Add(this.ReadCSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OBrowse);
            this.groupBox1.Controls.Add(this.OPath);
            this.groupBox1.Controls.Add(this.IBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 94);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "檔案設定";
            // 
            // SaveDT
            // 
            this.SaveDT.Enabled = false;
            this.SaveDT.Location = new System.Drawing.Point(427, 38);
            this.SaveDT.Name = "SaveDT";
            this.SaveDT.Size = new System.Drawing.Size(75, 22);
            this.SaveDT.TabIndex = 14;
            this.SaveDT.Text = "儲存";
            this.SaveDT.UseVisualStyleBackColor = true;
            this.SaveDT.Click += new System.EventHandler(this.SaveDT_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Calculas
            // 
            this.Calculas.Enabled = false;
            this.Calculas.Location = new System.Drawing.Point(333, 112);
            this.Calculas.Name = "Calculas";
            this.Calculas.Size = new System.Drawing.Size(100, 93);
            this.Calculas.TabIndex = 10;
            this.Calculas.Text = "計算";
            this.Calculas.UseVisualStyleBackColor = true;
            this.Calculas.Click += new System.EventHandler(this.Calculas_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(1157, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(462, 189);
            this.textBox1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(915, 795);
            this.dataGridView2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "篩選倍數：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "標準化區間值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "均值化區間值：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(154, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "與標準化區間值相同";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_multi
            // 
            this.txt_multi.Location = new System.Drawing.Point(102, 14);
            this.txt_multi.Name = "txt_multi";
            this.txt_multi.Size = new System.Drawing.Size(46, 22);
            this.txt_multi.TabIndex = 18;
            this.txt_multi.Text = "3";
            // 
            // txt_sigB
            // 
            this.txt_sigB.Location = new System.Drawing.Point(102, 39);
            this.txt_sigB.Name = "txt_sigB";
            this.txt_sigB.Size = new System.Drawing.Size(46, 22);
            this.txt_sigB.TabIndex = 19;
            this.txt_sigB.Text = "50";
            // 
            // txt_avrB
            // 
            this.txt_avrB.Enabled = false;
            this.txt_avrB.Location = new System.Drawing.Point(102, 63);
            this.txt_avrB.Name = "txt_avrB";
            this.txt_avrB.Size = new System.Drawing.Size(46, 22);
            this.txt_avrB.TabIndex = 20;
            this.txt_avrB.Text = "50";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ABS_Mode);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_avrB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_sigB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_multi);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 93);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "全域設定";
            // 
            // ABS_Mode
            // 
            this.ABS_Mode.AutoSize = true;
            this.ABS_Mode.Location = new System.Drawing.Point(154, 51);
            this.ABS_Mode.Name = "ABS_Mode";
            this.ABS_Mode.Size = new System.Drawing.Size(133, 16);
            this.ABS_Mode.TabIndex = 23;
            this.ABS_Mode.Text = "Resualt.txt絕對值模式";
            this.ABS_Mode.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(154, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 16);
            this.checkBox3.TabIndex = 22;
            this.checkBox3.Text = "顯示資料替代過程";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(154, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "計算效率";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(930, 822);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "InputData";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(965, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(930, 822);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OutputData";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(601, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 42);
            this.label6.TabIndex = 23;
            this.label6.Text = "資料讀入前\r\n請手動刪除極值";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "批量輸入：";
            // 
            // txt_pack_path
            // 
            this.txt_pack_path.Location = new System.Drawing.Point(82, 66);
            this.txt_pack_path.Name = "txt_pack_path";
            this.txt_pack_path.Size = new System.Drawing.Size(258, 22);
            this.txt_pack_path.TabIndex = 15;
            // 
            // pack_process
            // 
            this.pack_process.Location = new System.Drawing.Point(427, 65);
            this.pack_process.Name = "pack_process";
            this.pack_process.Size = new System.Drawing.Size(75, 23);
            this.pack_process.TabIndex = 18;
            this.pack_process.Text = "讀取";
            this.pack_process.UseVisualStyleBackColor = true;
            this.pack_process.Click += new System.EventHandler(this.pack_process_Click);
            // 
            // pack_folderpick
            // 
            this.pack_folderpick.Location = new System.Drawing.Point(346, 66);
            this.pack_folderpick.Name = "pack_folderpick";
            this.pack_folderpick.Size = new System.Drawing.Size(75, 23);
            this.pack_folderpick.TabIndex = 17;
            this.pack_folderpick.Text = "瀏覽";
            this.pack_folderpick.UseVisualStyleBackColor = true;
            this.pack_folderpick.Click += new System.EventHandler(this.pack_folderpick_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(775, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 184);
            this.listBox1.TabIndex = 24;
            // 
            // packProcess
            // 
            this.packProcess.Enabled = false;
            this.packProcess.Location = new System.Drawing.Point(701, 144);
            this.packProcess.Name = "packProcess";
            this.packProcess.Size = new System.Drawing.Size(68, 64);
            this.packProcess.TabIndex = 25;
            this.packProcess.Text = "批量計算";
            this.packProcess.UseVisualStyleBackColor = true;
            this.packProcess.Click += new System.EventHandler(this.packProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.packProcess);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Calculas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "資料後處理 Ver1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox IPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OPath;
        private System.Windows.Forms.Button IBrowse;
        private System.Windows.Forms.Button OBrowse;
        private System.Windows.Forms.Button ReadCSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button Calculas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SaveDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_avrB;
        private System.Windows.Forms.TextBox txt_sigB;
        private System.Windows.Forms.TextBox txt_multi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ABS_Mode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pack_path;
        private System.Windows.Forms.Button pack_process;
        private System.Windows.Forms.Button pack_folderpick;
        private System.Windows.Forms.FolderBrowserDialog pack_floder_dialog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button packProcess;
    }
}

