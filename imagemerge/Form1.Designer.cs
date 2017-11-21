namespace imagemerge
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown_left = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_right = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_top = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_bottom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_gap = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_group = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_canvasWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_canvasWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "이미지1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 103);
            this.button2.TabIndex = 1;
            this.button2.Text = "이미지2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 103);
            this.button3.TabIndex = 2;
            this.button3.Text = "이미지3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(815, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 103);
            this.button4.TabIndex = 3;
            this.button4.Text = "이미지4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(589, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(655, 146);
            this.button5.TabIndex = 4;
            this.button5.Text = "생성";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1057, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 103);
            this.button6.TabIndex = 5;
            this.button6.Text = "이미지5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // numericUpDown_left
            // 
            this.numericUpDown_left.Location = new System.Drawing.Point(243, 100);
            this.numericUpDown_left.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_left.Name = "numericUpDown_left";
            this.numericUpDown_left.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_left.TabIndex = 6;
            // 
            // numericUpDown_right
            // 
            this.numericUpDown_right.Location = new System.Drawing.Point(885, 100);
            this.numericUpDown_right.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_right.Name = "numericUpDown_right";
            this.numericUpDown_right.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_right.TabIndex = 7;
            // 
            // numericUpDown_top
            // 
            this.numericUpDown_top.Location = new System.Drawing.Point(572, 22);
            this.numericUpDown_top.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_top.Name = "numericUpDown_top";
            this.numericUpDown_top.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_top.TabIndex = 8;
            // 
            // numericUpDown_bottom
            // 
            this.numericUpDown_bottom.Location = new System.Drawing.Point(572, 195);
            this.numericUpDown_bottom.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_bottom.Name = "numericUpDown_bottom";
            this.numericUpDown_bottom.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_bottom.TabIndex = 9;
            // 
            // numericUpDown_gap
            // 
            this.numericUpDown_gap.Location = new System.Drawing.Point(572, 80);
            this.numericUpDown_gap.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_gap.Name = "numericUpDown_gap";
            this.numericUpDown_gap.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_gap.TabIndex = 10;
            // 
            // numericUpDown_group
            // 
            this.numericUpDown_group.Location = new System.Drawing.Point(572, 133);
            this.numericUpDown_group.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_group.Name = "numericUpDown_group";
            this.numericUpDown_group.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_group.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "좌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "우";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "위";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "아래";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "이미지간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 135);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "그룹간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "filename";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(217, 552);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(310, 35);
            this.textBox_filename.TabIndex = 20;
            this.textBox_filename.Text = "01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "가로사이즈";
            // 
            // numericUpDown_canvasWidth
            // 
            this.numericUpDown_canvasWidth.Location = new System.Drawing.Point(1150, 33);
            this.numericUpDown_canvasWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_canvasWidth.Name = "numericUpDown_canvasWidth";
            this.numericUpDown_canvasWidth.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown_canvasWidth.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 863);
            this.Controls.Add(this.numericUpDown_canvasWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_group);
            this.Controls.Add(this.numericUpDown_gap);
            this.Controls.Add(this.numericUpDown_bottom);
            this.Controls.Add(this.numericUpDown_top);
            this.Controls.Add(this.numericUpDown_right);
            this.Controls.Add(this.numericUpDown_left);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_canvasWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown_left;
        private System.Windows.Forms.NumericUpDown numericUpDown_right;
        private System.Windows.Forms.NumericUpDown numericUpDown_top;
        private System.Windows.Forms.NumericUpDown numericUpDown_bottom;
        private System.Windows.Forms.NumericUpDown numericUpDown_gap;
        private System.Windows.Forms.NumericUpDown numericUpDown_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_canvasWidth;
    }
}

