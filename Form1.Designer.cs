namespace SimplePaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            picCanvas = new PictureBox();
            groupBox1 = new GroupBox();
            btnRectangle = new Button();
            btnLine = new Button();
            btnCircle = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(17, 9);
            lblAppName.Margin = new Padding(2, 0, 2, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(190, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SimplePaint";
            lblAppName.Click += lblAppName_Click;
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(17, 166);
            picCanvas.Margin = new Padding(2);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(625, 332);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Controls.Add(btnCircle);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(17, 64);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(190, 98);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형선택";
            // 
            // btnRectangle
            // 
            btnRectangle.ForeColor = SystemColors.ActiveCaptionText;
            btnRectangle.Image = (Image)resources.GetObject("btnRectangle.Image");
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(60, 20);
            btnRectangle.Margin = new Padding(2);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(53, 67);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnLine
            // 
            btnLine.ForeColor = SystemColors.ActiveCaptionText;
            btnLine.Image = (Image)resources.GetObject("btnLine.Image");
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(4, 20);
            btnLine.Margin = new Padding(2);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(52, 67);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnCircle
            // 
            btnCircle.ForeColor = SystemColors.ActiveCaptionText;
            btnCircle.Image = (Image)resources.GetObject("btnCircle.Image");
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(117, 20);
            btnCircle.Margin = new Padding(2);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(53, 67);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.ForeColor = Color.Blue;
            groupBox2.Location = new Point(219, 64);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(106, 59);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(5, 27);
            cmbColor.Margin = new Padding(2);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(97, 23);
            cmbColor.TabIndex = 0;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(330, 64);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(148, 59);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(12, 17);
            trbLineWidth.Margin = new Padding(2);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(124, 45);
            trbLineWidth.TabIndex = 0;
            trbLineWidth.Scroll += trbLineWidth_Scroll;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("궁서체", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOpenFile.ForeColor = Color.Blue;
            btnOpenFile.Location = new Point(492, 88);
            btnOpenFile.Margin = new Padding(2);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(56, 36);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("궁서체", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSaveFile.ForeColor = Color.Red;
            btnSaveFile.Location = new Point(553, 88);
            btnSaveFile.Margin = new Padding(2);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(56, 36);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 523);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(picCanvas);
            Controls.Add(lblAppName);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private PictureBox picCanvas;
        private GroupBox groupBox1;
        private Button btnRectangle;
        private Button btnLine;
        private Button btnCircle;
        private GroupBox groupBox2;
        private ComboBox cmbColor;
        private GroupBox groupBox3;
        private TrackBar trbLineWidth;
        private Button btnOpenFile;
        private Button btnSaveFile;
    }
}
