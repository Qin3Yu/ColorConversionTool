namespace ConversionToolsBox {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_HEX = new System.Windows.Forms.TextBox();
            this.button_conversion = new System.Windows.Forms.Button();
            this.textBox_RGB = new System.Windows.Forms.TextBox();
            this.textBox_HSL = new System.Windows.Forms.TextBox();
            this.label_HEX = new System.Windows.Forms.Label();
            this.label_RGB = new System.Windows.Forms.Label();
            this.label_HSL = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_HEX
            // 
            this.textBox_HEX.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textBox_HEX.Location = new System.Drawing.Point(97, 20);
            this.textBox_HEX.Name = "textBox_HEX";
            this.textBox_HEX.Size = new System.Drawing.Size(126, 30);
            this.textBox_HEX.TabIndex = 0;
            // 
            // button_conversion
            // 
            this.button_conversion.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_conversion.Location = new System.Drawing.Point(97, 204);
            this.button_conversion.Name = "button_conversion";
            this.button_conversion.Size = new System.Drawing.Size(83, 37);
            this.button_conversion.TabIndex = 1;
            this.button_conversion.Text = "转换";
            this.button_conversion.UseVisualStyleBackColor = true;
            this.button_conversion.Click += new System.EventHandler(this.colorConversion);
            // 
            // textBox_RGB
            // 
            this.textBox_RGB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RGB.Location = new System.Drawing.Point(57, 67);
            this.textBox_RGB.Name = "textBox_RGB";
            this.textBox_RGB.Size = new System.Drawing.Size(166, 30);
            this.textBox_RGB.TabIndex = 2;
            // 
            // textBox_HSL
            // 
            this.textBox_HSL.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.textBox_HSL.Location = new System.Drawing.Point(57, 115);
            this.textBox_HSL.Name = "textBox_HSL";
            this.textBox_HSL.Size = new System.Drawing.Size(166, 30);
            this.textBox_HSL.TabIndex = 3;
            // 
            // label_HEX
            // 
            this.label_HEX.AutoSize = true;
            this.label_HEX.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HEX.Location = new System.Drawing.Point(11, 23);
            this.label_HEX.Name = "label_HEX";
            this.label_HEX.Size = new System.Drawing.Size(80, 22);
            this.label_HEX.TabIndex = 4;
            this.label_HEX.Text = "16#/HEX";
            // 
            // label_RGB
            // 
            this.label_RGB.AutoSize = true;
            this.label_RGB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RGB.Location = new System.Drawing.Point(11, 70);
            this.label_RGB.Name = "label_RGB";
            this.label_RGB.Size = new System.Drawing.Size(40, 22);
            this.label_RGB.TabIndex = 5;
            this.label_RGB.Text = "RGB";
            // 
            // label_HSL
            // 
            this.label_HSL.AutoSize = true;
            this.label_HSL.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HSL.Location = new System.Drawing.Point(11, 118);
            this.label_HSL.Name = "label_HSL";
            this.label_HSL.Size = new System.Drawing.Size(40, 22);
            this.label_HSL.TabIndex = 6;
            this.label_HSL.Text = "HSL";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.button_clear.Location = new System.Drawing.Point(244, 204);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(83, 37);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "清除";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.colorClear);
            // 
            // textBox_color
            // 
            this.textBox_color.Font = new System.Drawing.Font("宋体", 80F);
            this.textBox_color.Location = new System.Drawing.Point(256, 18);
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(128, 129);
            this.textBox_color.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "PS.多次输入前请先点击清除";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_color);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_HSL);
            this.Controls.Add(this.label_RGB);
            this.Controls.Add(this.label_HEX);
            this.Controls.Add(this.textBox_HSL);
            this.Controls.Add(this.textBox_RGB);
            this.Controls.Add(this.button_conversion);
            this.Controls.Add(this.textBox_HEX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "颜色转换器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox_HEX;
        private System.Windows.Forms.Button button_conversion;
        private System.Windows.Forms.TextBox textBox_RGB;
        private System.Windows.Forms.TextBox textBox_HSL;
        private System.Windows.Forms.Label label_HEX;
        private System.Windows.Forms.Label label_RGB;
        private System.Windows.Forms.Label label_HSL;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Label label1;
    }
}

