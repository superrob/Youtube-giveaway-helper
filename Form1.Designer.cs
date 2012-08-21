namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.goButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.RichTextBox();
            this.youtubeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.debugInfo = new System.Windows.Forms.CheckBox();
            this.winnerNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.doubleComment = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.winnerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(218, 35);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(134, 23);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Begin";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 64);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(340, 269);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // youtubeID
            // 
            this.youtubeID.Location = new System.Drawing.Point(79, 9);
            this.youtubeID.Name = "youtubeID";
            this.youtubeID.Size = new System.Drawing.Size(109, 20);
            this.youtubeID.TabIndex = 2;
            this.youtubeID.TextChanged += new System.EventHandler(this.youtubeID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Youtube ID";
            // 
            // debugInfo
            // 
            this.debugInfo.AutoSize = true;
            this.debugInfo.Location = new System.Drawing.Point(147, 39);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(65, 17);
            this.debugInfo.TabIndex = 4;
            this.debugInfo.Text = "Verbose";
            this.debugInfo.UseVisualStyleBackColor = true;
            // 
            // winnerNum
            // 
            this.winnerNum.Location = new System.Drawing.Point(243, 9);
            this.winnerNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.winnerNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.winnerNum.Name = "winnerNum";
            this.winnerNum.Size = new System.Drawing.Size(109, 20);
            this.winnerNum.TabIndex = 5;
            this.winnerNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Winners";
            // 
            // doubleComment
            // 
            this.doubleComment.AutoSize = true;
            this.doubleComment.Location = new System.Drawing.Point(15, 39);
            this.doubleComment.Name = "doubleComment";
            this.doubleComment.Size = new System.Drawing.Size(126, 17);
            this.doubleComment.TabIndex = 7;
            this.doubleComment.Text = "No double comments";
            this.doubleComment.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(258, 342);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://robserob.dk";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(105, 342);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(147, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "http://youtube.com/robinkaja";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 364);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.doubleComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.winnerNum);
            this.Controls.Add(this.debugInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.youtubeID);
            this.Controls.Add(this.output);
            this.Controls.Add(this.goButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Youtube Giveaway Helper BETA";
            ((System.ComponentModel.ISupportInitialize)(this.winnerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox youtubeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox debugInfo;
        private System.Windows.Forms.NumericUpDown winnerNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox doubleComment;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

