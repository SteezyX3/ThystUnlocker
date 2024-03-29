using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf;
using LiveCharts;
using Series = LiveCharts.Wpf.Series;


namespace ThystUnlocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fpsValueText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(162, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "FPS Cap Applied:\r\n";
            // 
            // Status
            // 
            this.Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Status.Location = new System.Drawing.Point(14, 227);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(129, 15);
            this.Status.TabIndex = 5;
            this.Status.Text = "N/A";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.outputTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.outputTextBox.Location = new System.Drawing.Point(168, 184);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(511, 198);
            this.outputTextBox.TabIndex = 6;
            this.outputTextBox.Text = "CONSOLE START:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(165, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "CONSOLE";
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(661, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 21);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exitBttn);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize.Location = new System.Drawing.Point(631, -1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(24, 21);
            this.minimize.TabIndex = 9;
            this.minimize.Text = "_";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimizeBttn);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 31);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.holding);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMoved);
            // 
            // Chat
            // 
            this.Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.Chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chat.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Chat.Location = new System.Drawing.Point(165, 45);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(182, 13);
            this.Chat.TabIndex = 12;
            this.Chat.Text = "Insert fps amount default one is 60...";
            this.Chat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placeholder_Handler);
            this.Chat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gotham Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(353, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "APPLY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Apply);
            // 
            // fpsValueText
            // 
            this.fpsValueText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fpsValueText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.fpsValueText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpsValueText.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fpsValueText.Location = new System.Drawing.Point(17, 257);
            this.fpsValueText.Name = "fpsValueText";
            this.fpsValueText.Size = new System.Drawing.Size(121, 15);
            this.fpsValueText.TabIndex = 15;
            this.fpsValueText.Text = "N/A";
            this.fpsValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Current FPS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gotham Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(483, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Roblox RAM Usage Chart";
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(165, 75);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(509, 87);
            this.chart.TabIndex = 17;
            this.chart.Text = "cartesianChart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fpsValueText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += Form1_Load;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roblox FPS Unlocker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        bool notFirstLine = false;
        private void AppendTextToOutputTextBox(string text)
        {
            if (outputTextBox.InvokeRequired)
            {
                outputTextBox.Invoke(new Action<string>(AppendTextToOutputTextBox), text);
            }
            else
            {
                if (!notFirstLine)
                {
                    outputTextBox.AppendText(text + Environment.NewLine);
                    notFirstLine = true;
                }
                else
                {
                    outputTextBox.AppendText(text + Environment.NewLine);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome: " + Environment.MachineName;

            var filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "settings.json");

            if (filePaths.Length > 0)
            {
                var filePath = filePaths[0];
                JObject settingsObject;

                using (StreamReader file = File.OpenText(filePath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    settingsObject = (JObject)JToken.ReadFrom(reader);
                }

                string fpsValue = (string)settingsObject["fpsTarget"]["DFIntTaskSchedulerTargetFps"];

                fpsValueText.Text = fpsValue;
            }
            else
            {
                MessageBox.Show("No settings.json file found in the current directory.");
            }
        }
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string command = Chat.Text.Trim();
                Chat.Clear();
            }
        }
        bool isPlaced = true;
        private void placeholder_Handler(object sender, MouseEventArgs e)
        {
            isPlaced = true;
            Chat.Clear();
        }
        private void placeholder_Placer(object sender, EventArgs e)
        {
            isPlaced = true;
            Chat.Text = "Inser fps amount default one is 144...";
        }
        private void changeColorEnter(object sender, EventArgs e)
        {
            exit.BackColor = Color.DarkRed;
        }
        private void onlyNums(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



    private void Apply(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Chat.Text.Trim()) || !int.TryParse(Chat.Text.Trim(), out int fps) || fps <= 0 || Chat.Text.StartsWith("0"))
            {
                AppendTextToOutputTextBox("Value is: Too big, empty or 0, Please input a valid one. Example: 144" + Environment.NewLine);
            }
            else
            {
                var filePath = @"C:\Users\mrste\OneDrive\Desktop\ThystUnlocker\settings.json";
                JObject jsonObject;
                using (StreamReader file = File.OpenText(filePath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    jsonObject = (JObject)JToken.ReadFrom(reader);
                }

                jsonObject["fpsTarget"]["DFIntTaskSchedulerTargetFps"] = Chat.Text.Trim();
                using (StreamWriter file = File.CreateText(filePath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    jsonObject.WriteTo(writer);
                }
                startUp();
            }
        }







        private void startUp()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            var script = @"C:\Users\mrste\OneDrive\Desktop\ThystUnlocker\adder.py";
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\mrste\AppData\Local\Programs\Python\Python311\python.exe";

            psi.Arguments = $"\"{script}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardInput = true;
            string errors = "";
            string results = "";

            fpsLauncher = new Process();
            fpsLauncher.StartInfo = psi;
            fpsLauncher.ErrorDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    errors += args.Data + Environment.NewLine;
                    AppendTextToOutputTextBox(args.Data + Environment.NewLine);
                }
            };
            fpsLauncher.OutputDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    results += args.Data + Environment.NewLine;
                    AppendTextToOutputTextBox(args.Data + Environment.NewLine);
                }
            };

            try
            {
                fpsLauncher.Start();
                fpsLauncher.BeginOutputReadLine();
                fpsLauncher.BeginErrorReadLine();
                AppendTextToOutputTextBox("Applied new fps value");
                Status.Text = Chat.Text.Trim();
                fpsValueText.Text = Chat.Text.Trim();
                MessageBox.Show("To apply the effects you will need to restart roblox otherwise it won't work as intended", "Please Read", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Chat.Clear();
                Chat.Text = "Insert fps amount default one is 60...";
            }
            catch (Exception ex)
            {
                AppendTextToOutputTextBox($"Error starting Python process: {ex.Message}");
            }
        }


        private void mouseMoved(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLock.X, mouseLock.Y);
                Location = mousePose;
            }
        }
        private void exitBttn(object sender, EventArgs e)
        {
            this.Close();
        }
        private void changeColorLeave(object sender, EventArgs e)
        {
            exit.BackColor = Color.FromArgb(37, 37, 37);
        }
        private void minimizeBttn(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public Point mouseLock = Point.Empty;
        private void holding(object sender, MouseEventArgs e)
        {
            mouseLock = new Point(-e.X, -e.Y);
        }
        private Process fpsLauncher;
        bool minecraftIsOn = false;


        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label Status;
        private TextBox outputTextBox;
        private Label label5;
        private Button exit;
        private Button minimize;
        private Panel panel1;
        private TextBox Chat;
        private Button button1;
        private Label fpsValueText;
        private Label label6;
        private Label label4;
        private LiveCharts.WinForms.CartesianChart chart;
    }
}
