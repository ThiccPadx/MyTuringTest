namespace Reader01
{
    partial class FormR
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormR));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.button_goHomePage = new System.Windows.Forms.Button();
            this.timerLoadPage = new System.Windows.Forms.Timer(this.components);
            this.VProgressBarLoadPage = new Reader01.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(736, 479);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // buttonTemp
            // 
            this.buttonTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTemp.Location = new System.Drawing.Point(836, 12);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(75, 23);
            this.buttonTemp.TabIndex = 1;
            this.buttonTemp.Text = "button temp";
            this.buttonTemp.UseVisualStyleBackColor = true;
            this.buttonTemp.Click += new System.EventHandler(this.buttonTemp_Click);
            // 
            // button_goHomePage
            // 
            this.button_goHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_goHomePage.BackColor = System.Drawing.Color.Transparent;
            this.button_goHomePage.BackgroundImage = global::Reader01.Properties.Resources.ic_menu_home;
            this.button_goHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_goHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_goHomePage.Location = new System.Drawing.Point(754, 0);
            this.button_goHomePage.Name = "button_goHomePage";
            this.button_goHomePage.Size = new System.Drawing.Size(50, 50);
            this.button_goHomePage.TabIndex = 2;
            this.button_goHomePage.UseVisualStyleBackColor = false;
            // 
            // timerLoadPage
            // 
            this.timerLoadPage.Tick += new System.EventHandler(this.timerLoadPage_Tick);
            // 
            // VProgressBarLoadPage
            // 
            this.VProgressBarLoadPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VProgressBarLoadPage.ForeColor = System.Drawing.Color.PaleGreen;
            this.VProgressBarLoadPage.Location = new System.Drawing.Point(738, 0);
            this.VProgressBarLoadPage.Name = "VProgressBarLoadPage";
            this.VProgressBarLoadPage.Size = new System.Drawing.Size(10, 479);
            this.VProgressBarLoadPage.Step = 1;
            this.VProgressBarLoadPage.TabIndex = 3;
            // 
            // FormR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 501);
            this.Controls.Add(this.VProgressBarLoadPage);
            this.Controls.Add(this.button_goHomePage);
            this.Controls.Add(this.buttonTemp);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(939, 540);
            this.Name = "FormR";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Button button_goHomePage;
        private System.Windows.Forms.Timer timerLoadPage;
        private VerticalProgressBar VProgressBarLoadPage;
    }
}

