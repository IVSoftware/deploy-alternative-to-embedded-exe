
namespace read_stream_embedded_exe_onclick
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.btScreenshot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btScreenshot
            // 
            this.btScreenshot.Location = new System.Drawing.Point(39, 79);
            this.btScreenshot.Name = "btScreenshot";
            this.btScreenshot.Size = new System.Drawing.Size(112, 34);
            this.btScreenshot.TabIndex = 0;
            this.btScreenshot.Text = "Screenshot";
            this.btScreenshot.UseVisualStyleBackColor = true;
            this.btScreenshot.Click += new System.EventHandler(this.btScreenshot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.btScreenshot);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btScreenshot;
    }
}

