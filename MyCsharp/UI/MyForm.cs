using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCsharp.UI
{
    public class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.blueNum = new System.Windows.Forms.Label();
            this.n6 = new System.Windows.Forms.Label();
            this.n5 = new System.Windows.Forms.Label();
            this.n4 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.Toptitile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blueNum);
            this.panel1.Controls.Add(this.n6);
            this.panel1.Controls.Add(this.n5);
            this.panel1.Controls.Add(this.n4);
            this.panel1.Controls.Add(this.n3);
            this.panel1.Controls.Add(this.n2);
            this.panel1.Controls.Add(this.n1);
            this.panel1.Location = new System.Drawing.Point(2, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 366);
            this.panel1.TabIndex = 0;
            // 
            // blueNum
            // 
            this.blueNum.BackColor = System.Drawing.Color.Coral;
            this.blueNum.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.blueNum.ForeColor = System.Drawing.Color.Blue;
            this.blueNum.Location = new System.Drawing.Point(848, 174);
            this.blueNum.Name = "blueNum";
            this.blueNum.Size = new System.Drawing.Size(50, 48);
            this.blueNum.TabIndex = 0;
            this.blueNum.Text = "0";
            this.blueNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n6
            // 
            this.n6.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n6.ForeColor = System.Drawing.Color.Red;
            this.n6.Location = new System.Drawing.Point(443, 174);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 48);
            this.n6.TabIndex = 0;
            this.n6.Text = "0";
            this.n6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n5
            // 
            this.n5.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n5.ForeColor = System.Drawing.Color.Red;
            this.n5.Location = new System.Drawing.Point(359, 174);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(50, 48);
            this.n5.TabIndex = 0;
            this.n5.Text = "0";
            this.n5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n4
            // 
            this.n4.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n4.ForeColor = System.Drawing.Color.Red;
            this.n4.Location = new System.Drawing.Point(277, 174);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(50, 48);
            this.n4.TabIndex = 0;
            this.n4.Text = "0";
            this.n4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n3
            // 
            this.n3.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n3.ForeColor = System.Drawing.Color.Red;
            this.n3.Location = new System.Drawing.Point(193, 174);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 48);
            this.n3.TabIndex = 0;
            this.n3.Text = "0";
            this.n3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n2
            // 
            this.n2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n2.ForeColor = System.Drawing.Color.Red;
            this.n2.Location = new System.Drawing.Point(109, 174);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(50, 48);
            this.n2.TabIndex = 0;
            this.n2.Text = "0";
            this.n2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // n1
            // 
            this.n1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.n1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n1.ForeColor = System.Drawing.Color.Red;
            this.n1.Location = new System.Drawing.Point(27, 174);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(50, 48);
            this.n1.TabIndex = 0;
            this.n1.Text = "0";
            this.n1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Location = new System.Drawing.Point(12, 538);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 45);
            this.start.TabIndex = 1;
            this.start.Text = "启动";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            end.Click += CancleAction;
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.end.Location = new System.Drawing.Point(804, 539);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(164, 44);
            this.end.TabIndex = 2;
            this.end.Text = "退出";
            this.end.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.end.UseVisualStyleBackColor = false;
            // 
            // Toptitile
            // 
            this.Toptitile.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Toptitile.Location = new System.Drawing.Point(2, 13);
            this.Toptitile.Name = "Toptitile";
            this.Toptitile.Size = new System.Drawing.Size(457, 65);
            this.Toptitile.TabIndex = 3;
            this.Toptitile.Text = "双色球6+1";
            this.Toptitile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.Toptitile);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Name = "MyForm";
            this.Text = "双色球";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void CancleAction(object sender, EventArgs e)
        {
            turnOFF = false;
        }

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label Toptitile;

        private System.Windows.Forms.Label n1;

        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n6;

        private System.Windows.Forms.Label blueNum;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button end;
        private bool turnOFF;

        private string[] num =
        {
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
            "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"
        };

        private string[] blue = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"};

        private void button1_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            turnOFF = true;
            Task.Run(PrintNum);
        }

        public void PrintNum()
        {
            string temp = "0";
            List<string> tempList = new List<string>();
            while (turnOFF)
            {
                foreach (var control in panel1.Controls)
                {
                    if (control is Label)
                    {
                        Thread.Sleep(1);
                        if (control.Equals(blueNum))
                        {
                            blueNum.Text = blue[GetRandomNum(0, 16)];
                        }
                        else
                        {
                            Label label = (Label) control;
                            string s = num[GetRandomNum(0, num.Length)];
                            if ( temp.Equals(s) && tempList.Contains(s))
                            {
                                continue;
                            }
                            tempList.Add(s);
                            label.Text = s;
                            temp = s;
                        }
                    }
                }
            }
            start.Enabled = true;
        }

        public int GetRandomNum(int min, int max)
        {
            Guid guid = Guid.NewGuid();
            string sGuid = guid.ToString();
            int seed = DateTime.Now.Millisecond;
            for (int i = 0; i < sGuid.Length; i++)
            {
                switch (sGuid[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                        seed += 1;
                        break;
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                        seed += 2;
                        break;
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                        seed += 3;
                        break;
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        seed += 4;
                        break;
                    default:
                        seed += 5;
                        break;
                }
            }
            Random random = new Random(seed);
            return random.Next(min, max);
        }
    }
}