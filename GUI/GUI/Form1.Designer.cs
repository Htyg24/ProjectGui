namespace GUI
{
    partial class form1
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
            this.filesListBoxFirst = new System.Windows.Forms.ListBox();
            this.pathBoxFirst = new System.Windows.Forms.TextBox();
            this.goButtonFirst = new System.Windows.Forms.Button();
            this.backButtonFirst = new System.Windows.Forms.Button();
            this.filesListBoxSecond = new System.Windows.Forms.ListBox();
            this.pathBoxSecond = new System.Windows.Forms.TextBox();
            this.goButtonSecond = new System.Windows.Forms.Button();
            this.backButtonSecond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesListBoxFirst
            // 
            this.filesListBoxFirst.FormattingEnabled = true;
            this.filesListBoxFirst.ItemHeight = 15;
            this.filesListBoxFirst.Location = new System.Drawing.Point(12, 66);
            this.filesListBoxFirst.Name = "filesListBoxFirst";
            this.filesListBoxFirst.Size = new System.Drawing.Size(482, 469);
            this.filesListBoxFirst.TabIndex = 0;
            this.filesListBoxFirst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // pathBoxFirst
            // 
            this.pathBoxFirst.Location = new System.Drawing.Point(12, 8);
            this.pathBoxFirst.Name = "pathBoxFirst";
            this.pathBoxFirst.Size = new System.Drawing.Size(401, 23);
            this.pathBoxFirst.TabIndex = 1;
            // 
            // goButtonFirst
            // 
            this.goButtonFirst.Location = new System.Drawing.Point(419, 7);
            this.goButtonFirst.Name = "goButtonFirst";
            this.goButtonFirst.Size = new System.Drawing.Size(75, 23);
            this.goButtonFirst.TabIndex = 2;
            this.goButtonFirst.Text = "Перейти";
            this.goButtonFirst.UseVisualStyleBackColor = true;
            this.goButtonFirst.Click += new System.EventHandler(this.GoClickFirst);
            // 
            // backButtonFirst
            // 
            this.backButtonFirst.Location = new System.Drawing.Point(419, 37);
            this.backButtonFirst.Name = "backButtonFirst";
            this.backButtonFirst.Size = new System.Drawing.Size(75, 23);
            this.backButtonFirst.TabIndex = 3;
            this.backButtonFirst.Text = "Назад";
            this.backButtonFirst.UseVisualStyleBackColor = true;
            this.backButtonFirst.Click += new System.EventHandler(this.backFirst);
            // 
            // filesListBoxSecond
            // 
            this.filesListBoxSecond.FormattingEnabled = true;
            this.filesListBoxSecond.ItemHeight = 15;
            this.filesListBoxSecond.Location = new System.Drawing.Point(500, 66);
            this.filesListBoxSecond.Name = "filesListBoxSecond";
            this.filesListBoxSecond.Size = new System.Drawing.Size(482, 469);
            this.filesListBoxSecond.TabIndex = 0;
            this.filesListBoxSecond.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClickSecond);
            // 
            // pathBoxSecond
            // 
            this.pathBoxSecond.Location = new System.Drawing.Point(500, 8);
            this.pathBoxSecond.Name = "pathBoxSecond";
            this.pathBoxSecond.Size = new System.Drawing.Size(401, 23);
            this.pathBoxSecond.TabIndex = 1;
            // 
            // goButtonSecond
            // 
            this.goButtonSecond.Location = new System.Drawing.Point(907, 7);
            this.goButtonSecond.Name = "goButtonSecond";
            this.goButtonSecond.Size = new System.Drawing.Size(75, 23);
            this.goButtonSecond.TabIndex = 2;
            this.goButtonSecond.Text = "Перейти";
            this.goButtonSecond.UseVisualStyleBackColor = true;
            this.goButtonSecond.Click += new System.EventHandler(this.GoClickSecond);
            // 
            // backButtonSecond
            // 
            this.backButtonSecond.Location = new System.Drawing.Point(907, 37);
            this.backButtonSecond.Name = "backButtonSecond";
            this.backButtonSecond.Size = new System.Drawing.Size(75, 23);
            this.backButtonSecond.TabIndex = 3;
            this.backButtonSecond.Text = "Назад";
            this.backButtonSecond.UseVisualStyleBackColor = true;
            this.backButtonSecond.Click += new System.EventHandler(this.backSecond);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 563);
            this.Controls.Add(this.backButtonSecond);
            this.Controls.Add(this.backButtonFirst);
            this.Controls.Add(this.goButtonSecond);
            this.Controls.Add(this.goButtonFirst);
            this.Controls.Add(this.pathBoxSecond);
            this.Controls.Add(this.pathBoxFirst);
            this.Controls.Add(this.filesListBoxSecond);
            this.Controls.Add(this.filesListBoxFirst);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "form1";
            this.Text = "MoonLightShadow";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox filesListBoxFirst;
        private TextBox pathBoxFirst;
        private Button goButtonFirst;
        private Button backButtonFirst;
        private ListBox filesListBoxSecond;
        private TextBox pathBoxSecond;
        private Button goButtonSecond;
        private Button backButtonSecond;
    }
}