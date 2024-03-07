using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConversionToolsBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public void colorConversion(object sender, EventArgs e) /* 点击转换后触发 */ {

            string color_HEX, color_RGB="255,255,255", color_HSL;

            // 根据HEX转换
            if (textBox_HEX.Text != "") {
                color_HEX = textBox_HEX.Text.Trim().Replace("#", ""); // 去除#号
                if (color_HEX.Length == 6) {

                    // 转换为RGB色
                    color_RGB = string.Join(",", HEXtoRGB(color_HEX));
                    textBox_RGB.Text = color_RGB;

                    // 转换为HSL色
                    color_HSL = string.Join(",", RGBtoHSL(HEXtoRGB(color_HEX)));
                    textBox_HSL.Text = color_HSL;
                }
            }

            // 根据RGB转换
            else if (textBox_RGB.Text != "") {

                color_RGB = textBox_RGB.Text;
                string[] color_RGB_s = color_RGB.Split(',');

                int R = int.Parse(color_RGB_s[0]);
                int G = int.Parse(color_RGB_s[1]);
                int B = int.Parse(color_RGB_s[2]);
                int[] RGB = {R, G, B};

                // 转换为HEX色
                color_HEX = RGBtoHEX(RGB);
                textBox_HEX.Text = "#" + color_HEX;

                // 转换为HSL色
                color_HSL = string.Join(",", RGBtoHSL(HEXtoRGB(color_HEX)));
                textBox_HSL.Text = color_HSL;

            }

            // 根据HSL转换
            else if (textBox_HSL.Text != "") {

                color_HSL = textBox_HSL.Text;
                string[] color_HSL_s = color_HSL.Split(',');

                float H = float.Parse(color_HSL_s[0]);
                float S = float.Parse(color_HSL_s[1]);
                float L = float.Parse(color_HSL_s[2]);
                float[] HSL= {H, S, L};

                // 转换为RGB色
                color_RGB=string.Join(",", HSLtoRGB(HSL));
                textBox_RGB.Text = color_RGB;

                // 转换为HEX色
                color_HEX=RGBtoHEX(HSLtoRGB(HSL));
                textBox_HEX.Text= "#"+ color_HEX;
            }

            string[] color_RGBs = color_RGB.Split(',');
            int[] textBoxRGB = { int.Parse(color_RGBs[0]), int.Parse(color_RGBs[1]), int.Parse(color_RGBs[2]) };
            Color rgbColor = Color.FromArgb(textBoxRGB[0], textBoxRGB[1], textBoxRGB[2]);
            textBox_color.BackColor = rgbColor;

        }

        public void colorClear(object sender,EventArgs e) /* 点击清除后触发 */ {
            textBox_HEX.Text = "";
            textBox_RGB.Text = "";
            textBox_HSL.Text = "";
            Color rgbColor = Color.FromArgb(255, 255, 255);
            textBox_color.BackColor = rgbColor;
        }

        private void Form1_Load(object sender, EventArgs e) /* 窗体属性控制 */ {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // 设置窗口边框为固定大小
            this.MaximizeBox = false;  // 禁用最大化按钮
            this.MinimizeBox = false;  // 禁用最小化按钮
            textBox_color.ReadOnly = true;

            Color rgbColor = Color.FromArgb(255, 255, 255);
            textBox_color.BackColor = rgbColor;

        }

        public int[] HEXtoRGB (string color_HEX) /* 接收一个去除 # 的HEX色值，返回RGB数组 */ {
            int R = Convert.ToInt32(color_HEX.Substring(0, 2), 16);
            int G = Convert.ToInt32(color_HEX.Substring(2, 2), 16);
            int B = Convert.ToInt32(color_HEX.Substring(4, 2), 16);
            return new int[] { R, G, B };
        }

        public float[] RGBtoHSL(int[] nums_RGB) /* 接收一个0~255的RGB数组，返回规格为整形和两位小数的HSL数组 */ {
            float R = nums_RGB[0] / 255f;
            float G = nums_RGB[1] / 255f;
            float B = nums_RGB[2] / 255f;
            float max = Math.Max(R, Math.Max(G, B));
            float min = Math.Min(R, Math.Min(G, B));
            float H = 0;
            if (max == min)  H = 0;
            else if (max == R)  H = 60 * (G - B) / (max - min);
            else if (max == G)  H = 60 * (B - R) / (max - min) + 120;
            else if (max == B)  H = 60 * (R - G) / (max - min) + 240;
            if (H < 0)  H += 360;
            float L = (max + min) / 2;
            float S = 0;
            if (max == min)  S = 0;
            else if (0 < L && L < 0.5f)  S = (max - min) / (2 * L);
            else if (L >= 0.5f)  S = (max - min) / (2 - 2 * L);
            return new float[] { (float)Math.Round(H), (float)Math.Round(S, 2), (float)Math.Round(L, 2) };
        }

        public string RGBtoHEX(int[] nums_RGB) /* 接收一个0~255的RGB数组，返回不带#的六位HEX色值字符串 */ {
            string R = nums_RGB[0].ToString("X").PadLeft(2, '0');
            string G = nums_RGB[1].ToString("X").PadLeft(2, '0');
            string B = nums_RGB[2].ToString("X").PadLeft(2, '0');
            return R + G + B;
        }

        public int[] HSLtoRGB(float[] nums_HSL) /* 接收一个规格为整形和两位小数的HSL数组，返回一个0~255的RGB数组 */ {
            float precision = 0.00001f;
            float hue = nums_HSL[0];
            float sat = nums_HSL[1];
            float light = nums_HSL[2];
            int[] RGB = new int[3];

            if (sat < precision) // sat == 0
            {
                RGB[0] = (int)(light * 255);
                RGB[1] = (int)(light * 255);
                RGB[2] = (int)(light * 255);
            }
            else {
                float q, p, hk;

                if (light < 0.5f) { q = light * (1 + sat); }
                else { q = light + sat - (light * sat); }
                p = 2.0f * light - q;
                hk = hue / 360.0f;
                RGB[0] = (int)(ToColor_IN_HSLtoRGB(p, q, hk + 0.33333f) * 255);
                RGB[1] = (int)(ToColor_IN_HSLtoRGB(p, q, hk) * 255);
                RGB[2] = (int)(ToColor_IN_HSLtoRGB(p, q, hk - 0.33333f) * 255);
            }
            return RGB;
        }

        private static float ToColor_IN_HSLtoRGB(float p, float q, float t) /* 辅助HSLtoRGB函数 */ {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1.0f / 6.0f) return p + (q - p) * 6 * t;
            if (t < 0.5f) return q;
            if (t < 2.0f / 3.0f) return p + (q - p) * (2.0f / 3.0f - t) * 6;
            return p;
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}