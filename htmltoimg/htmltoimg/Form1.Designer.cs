namespace htmltoimg
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowserWidth = new System.Windows.Forms.TextBox();
            this.BrowserHeight = new System.Windows.Forms.TextBox();
            this.ThumbnailWidth = new System.Windows.Forms.TextBox();
            this.ThumbnailHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BrowserWidth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BrowserHeight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ThumbnailWidth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ThumbnailHeight";
            // 
            // BrowserWidth
            // 
            this.BrowserWidth.Location = new System.Drawing.Point(129, 28);
            this.BrowserWidth.Name = "BrowserWidth";
            this.BrowserWidth.Size = new System.Drawing.Size(100, 25);
            this.BrowserWidth.TabIndex = 2;
            this.BrowserWidth.Text = "1000";
            // 
            // BrowserHeight
            // 
            this.BrowserHeight.Location = new System.Drawing.Point(129, 62);
            this.BrowserHeight.Name = "BrowserHeight";
            this.BrowserHeight.Size = new System.Drawing.Size(100, 25);
            this.BrowserHeight.TabIndex = 2;
            this.BrowserHeight.Text = "292";
            // 
            // ThumbnailWidth
            // 
            this.ThumbnailWidth.Location = new System.Drawing.Point(129, 100);
            this.ThumbnailWidth.Name = "ThumbnailWidth";
            this.ThumbnailWidth.Size = new System.Drawing.Size(100, 25);
            this.ThumbnailWidth.TabIndex = 2;
            this.ThumbnailWidth.Text = "1000";
            // 
            // ThumbnailHeight
            // 
            this.ThumbnailHeight.Location = new System.Drawing.Point(129, 133);
            this.ThumbnailHeight.Name = "ThumbnailHeight";
            this.ThumbnailHeight.Size = new System.Drawing.Size(100, 25);
            this.ThumbnailHeight.TabIndex = 2;
            this.ThumbnailHeight.Text = "292";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.ThumbnailHeight);
            this.Controls.Add(this.ThumbnailWidth);
            this.Controls.Add(this.BrowserHeight);
            this.Controls.Add(this.BrowserWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BrowserWidth;
        private System.Windows.Forms.TextBox BrowserHeight;
        private System.Windows.Forms.TextBox ThumbnailWidth;
        private System.Windows.Forms.TextBox ThumbnailHeight;
    }
}

