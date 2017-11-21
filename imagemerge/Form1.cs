using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagemerge
{
    public partial class Form1 : Form
    {
        enum ENUM_CONF{
            LEFT,
            RIGHT,
            TOP,
            BOTTOM,
            GAP,
            GAP2,
            WIDTH,
            MAX
        }
        List<String> lst1 = new List<string>();
        List<String> lst2 = new List<string>();
        List<String> lst3 = new List<string>();
        List<String> lst4 = new List<string>();
        List<String> lst5 = new List<string>();

        string strConfPath = "";
        string [] lstConf = new string[(int)ENUM_CONF.MAX];

        public Form1()
        {  
            InitializeComponent();

            string strPath = Application.StartupPath;
            strConfPath = System.IO.Path.Combine(strPath, "config.txt");
            if (System.IO.File.Exists(strConfPath))
            {
                lstConf = System.IO.File.ReadAllText(strConfPath).Split(',');
                if(lstConf.Length < (int)ENUM_CONF.MAX)
                {
                    //SetDefaultUpDownValue();
                    if(lstConf.Length == (int)ENUM_CONF.WIDTH)
                    {
                        numericUpDown_canvasWidth.Value = 890;
                        string[] arr = new string[(int)ENUM_CONF.MAX];
                        for (int i = 0; i < lstConf.Length; i++)
                        {
                            arr[i] = lstConf[i];
                        }
                        arr[(int)ENUM_CONF.WIDTH] = numericUpDown_canvasWidth.Value.ToString();
                        lstConf = arr;
                    }
                    else
                    {
                        SetDefaultUpDownValue();
                    }
                    
                }
                SetMargin();
            }
            else
            {
                SetDefaultUpDownValue();
                SaveConf();
            }
        }

        private void SetDefaultUpDownValue()
        {
            numericUpDown_left.Value = 10;
            numericUpDown_right.Value = 10;
            numericUpDown_top.Value = 10;
            numericUpDown_bottom.Value = 10;

            numericUpDown_gap.Value = 10;
            numericUpDown_group.Value = 50;
            numericUpDown_canvasWidth.Value = 890;
        }

        private void SetMargin()
        {
            numericUpDown_left.Value = int.Parse(lstConf[(int)ENUM_CONF.LEFT]);
            numericUpDown_right.Value =  int.Parse(lstConf[(int)ENUM_CONF.RIGHT]);
            numericUpDown_top.Value = int.Parse(lstConf[(int)ENUM_CONF.TOP]);
            numericUpDown_bottom.Value = int.Parse(lstConf[(int)ENUM_CONF.BOTTOM]);

            numericUpDown_gap.Value = int.Parse(lstConf[(int)ENUM_CONF.GAP]);
            numericUpDown_group.Value = int.Parse(lstConf[(int)ENUM_CONF.GAP2]);
            numericUpDown_canvasWidth.Value = int.Parse(lstConf[(int)ENUM_CONF.WIDTH]);
        }

        private void SaveConf()
        {

            lstConf[(int)ENUM_CONF.LEFT] = numericUpDown_left.Value.ToString();
            lstConf[(int)ENUM_CONF.RIGHT] = numericUpDown_right.Value.ToString();
            lstConf[(int)ENUM_CONF.TOP] = numericUpDown_top.Value.ToString();
            lstConf[(int)ENUM_CONF.BOTTOM] = numericUpDown_bottom.Value.ToString();

            lstConf[(int)ENUM_CONF.GAP] = numericUpDown_gap.Value.ToString();
            lstConf[(int)ENUM_CONF.GAP2] = numericUpDown_group.Value.ToString();
            lstConf[(int)ENUM_CONF.WIDTH] = numericUpDown_canvasWidth.Value.ToString();

            string conf = String.Join(",", lstConf);
            System.IO.File.WriteAllText(strConfPath, conf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();

            lst1.Clear();
            if(dlg.FileNames.Length > 0)
            {
                foreach(String s in dlg.FileNames)
                {
                    lst1.Add(s);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();

            lst2.Clear();
            if (dlg.FileNames.Length > 0)
            {
                foreach (String s in dlg.FileNames)
                {
                    lst2.Add(s);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();

            lst3.Clear();
            if (dlg.FileNames.Length > 0)
            {
                foreach (String s in dlg.FileNames)
                {
                    lst3.Add(s);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();

            lst4.Clear();
            if (dlg.FileNames.Length > 0)
            {
                foreach (String s in dlg.FileNames)
                {
                    lst4.Add(s);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.ShowDialog();

            lst5.Clear();
            if (dlg.FileNames.Length > 0)
            {
                foreach (String s in dlg.FileNames)
                {
                    lst5.Add(s);
                }
            }
        }

        private int[] GetTopWidth(List<string> lst)
        {
            int height = 0;
            int width = 0;
            foreach (string s in lst)
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                if (img.Width > width)
                {
                    width = img.Width;
                }

                int resizeHeight = CalcResizeHeight(img.Width, (int)numericUpDown_canvasWidth.Value, img.Height);
                //height += img.Height;
                height += resizeHeight;

            }

            if(lst.Count > 0) {
                height += ((int)numericUpDown_gap.Value) * (lst.Count - 1);
            }
            

            int[] ret = new int[2];
            ret[0] = width;
            ret[1] = height;
            return ret;
        }

        public int CalcResizeHeight(int srcWidth, int targetWidth, int srcHeight)
        {
            //sw : sh = tw : th
            //sh*tw = sw*th
            //th = sh * tw / sw
            return (int)((srcHeight * targetWidth) / srcWidth);
        }
        public System.Drawing.Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        {
            //a holder for the result 
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap 
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality 
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap 
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap 
            return result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int width = 0;
            int height = 0;

            int topWidth = 0;

            int[] checkValue;
            int checkWidth = 0;
            int checkHeight = 0;
            
            height += (int)numericUpDown_top.Value;

            checkValue = GetTopWidth(lst1);
            checkWidth = checkValue[0];
            checkHeight = checkValue[1];
            topWidth = topWidth < checkWidth ? checkWidth : topWidth;
            //height += checkHeight + ((int)numericUpDown_gap.Value * lst1.Count);
            height += checkHeight;

            if(lst2.Count > 0)
            {
                height += (int)numericUpDown_group.Value;
            }

            checkValue = GetTopWidth(lst2);
            checkWidth = checkValue[0];
            checkHeight = checkValue[1];
            topWidth = topWidth < checkWidth ? checkWidth : topWidth;
            //height += checkHeight + ((int)numericUpDown_gap.Value * lst2.Count);
            height += checkHeight;

            if (lst3.Count > 0)
            {
                height += (int)numericUpDown_group.Value;
            }

            checkValue = GetTopWidth(lst3);
            checkWidth = checkValue[0];
            checkHeight = checkValue[1];
            topWidth = topWidth < checkWidth ? checkWidth : topWidth;
            //height += checkHeight + ((int)numericUpDown_gap.Value * lst3.Count);
            height += checkHeight;

            if (lst4.Count > 0)
            {
                height += (int)numericUpDown_group.Value;
            }

            checkValue = GetTopWidth(lst4);
            checkWidth = checkValue[0];
            checkHeight = checkValue[1];
            topWidth = topWidth < checkWidth ? checkWidth : topWidth;
            //height += checkHeight + ((int)numericUpDown_gap.Value * lst4.Count);
            height += checkHeight;

            if (lst5.Count > 0)
            {
                height += (int)numericUpDown_group.Value;
            }

            checkValue = GetTopWidth(lst5);
            checkWidth = checkValue[0];
            checkHeight = checkValue[1];
            topWidth = topWidth < checkWidth ? checkWidth : topWidth;
            //height += checkHeight + ((int)numericUpDown_gap.Value * lst5.Count);
            height += checkHeight;

            height += (int)numericUpDown_bottom.Value;

            //width = (int)numericUpDown_left.Value + topWidth + (int)numericUpDown_right.Value;
            int canvasWidth = (int)numericUpDown_canvasWidth.Value;
            width = canvasWidth - ((int)numericUpDown_right.Value + (int)numericUpDown_left.Value);


            Bitmap canvas = new Bitmap(canvasWidth, height);
            
            int nY = 0;
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(canvas);
            //g.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, canvasWidth, height);

            nY = (int)numericUpDown_top.Value;

            int nCount = 0;
            foreach(string s in lst1)
            {
                if(nCount++ > 0)
                {
                    nY += (int)numericUpDown_gap.Value;
                }
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                //g.DrawImage(img, (width - img.Width)/2, nY, img.Width, img.Height);
                //nY += img.Height;
                int calcHeight = CalcResizeHeight(img.Width, canvasWidth, img.Height);
                g.DrawImage(ResizeImage(img, width, calcHeight), (canvasWidth - width) / 2, nY, width, calcHeight);
                nY += calcHeight;
            }

            if(lst2.Count > 0)
            {
                nY += (int)numericUpDown_group.Value;
            }

            nCount = 0;
            foreach (string s in lst2)
            {
                if (nCount++ > 0)
                {
                    nY += (int)numericUpDown_gap.Value;
                }
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                /*
                g.DrawImage(img, (width - img.Width) / 2, nY, img.Width, img.Height);
                nY += img.Height;
                */
                int calcHeight = CalcResizeHeight(img.Width, canvasWidth, img.Height);
                g.DrawImage(ResizeImage(img, width, calcHeight), (canvasWidth - width) / 2, nY, width, calcHeight);
                nY += calcHeight;
            }

            if (lst3.Count > 0)
            {
                nY += (int)numericUpDown_group.Value;
            }

            nCount = 0;
            foreach (string s in lst3)
            {
                if (nCount++ > 0)
                {
                    nY += (int)numericUpDown_gap.Value;
                }
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                /*
                g.DrawImage(img, (width - img.Width) / 2, nY, img.Width, img.Height);
                nY += img.Height;
                */
                int calcHeight = CalcResizeHeight(img.Width, canvasWidth, img.Height);
                g.DrawImage(ResizeImage(img, width, calcHeight), (canvasWidth - width) / 2, nY, width, calcHeight);
                nY += calcHeight;
            }


            if (lst4.Count > 0)
            {
                nY += (int)numericUpDown_group.Value;
            }

            nCount = 0;
            foreach (string s in lst4)
            {
                if (nCount++ > 0)
                {
                    nY += (int)numericUpDown_gap.Value;
                }
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                /*
                g.DrawImage(img, (width - img.Width) / 2, nY, img.Width, img.Height);
                nY += img.Height;
                */
                int calcHeight = CalcResizeHeight(img.Width, canvasWidth, img.Height);
                g.DrawImage(ResizeImage(img, width, calcHeight), (canvasWidth - width) / 2, nY, width, calcHeight);
                nY += calcHeight;
            }
            
            if (lst5.Count > 0)
            {
                nY += (int)numericUpDown_group.Value;
            }

            nCount = 0;
            foreach (string s in lst5)
            {
                if (nCount++ > 0)
                {
                    nY += (int)numericUpDown_gap.Value;
                }
                System.Drawing.Image img = System.Drawing.Image.FromFile(s);
                /*
                g.DrawImage(img, (width - img.Width) / 2, nY, img.Width, img.Height);
                nY += img.Height;
                */
                int calcHeight = CalcResizeHeight(img.Width, canvasWidth, img.Height);
                g.DrawImage(ResizeImage(img, width, calcHeight), (canvasWidth - width) / 2, nY, width, calcHeight);
                nY += calcHeight;
            }
            string filename = textBox_filename.Text + ".jpg";
            canvas.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
            SaveConf();

            MessageBox.Show("완료");
        }

        
    }
}

