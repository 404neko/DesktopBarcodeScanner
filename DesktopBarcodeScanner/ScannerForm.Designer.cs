namespace DesktopBarcodeScanner
{
    partial class ScannerForm
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
            this.u_result = new System.Windows.Forms.TextBox();
            this.u_capture_area = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // u_result
            // 
            this.u_result.Location = new System.Drawing.Point(5, 320);
            this.u_result.Multiline = true;
            this.u_result.Name = "u_result";
            this.u_result.Size = new System.Drawing.Size(500, 106);
            this.u_result.TabIndex = 0;
            // 
            // u_capture_area
            // 
            this.u_capture_area.BackColor = System.Drawing.Color.Honeydew;
            this.u_capture_area.Location = new System.Drawing.Point(5, 5);
            this.u_capture_area.Name = "u_capture_area";
            this.u_capture_area.Size = new System.Drawing.Size(500, 309);
            this.u_capture_area.TabIndex = 1;
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 431);
            this.Controls.Add(this.u_capture_area);
            this.Controls.Add(this.u_result);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScannerForm";
            this.Text = "Scanner";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Honeydew;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox u_result;
        private System.Windows.Forms.Panel u_capture_area;
    }
}

