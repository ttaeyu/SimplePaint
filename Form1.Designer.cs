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
            lblAppName.Location = new Point(22, 29);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(236, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SimplePaint";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(12, 186);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(766, 252);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseUp += picCanvas_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(22, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 79);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(80, 26);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(68, 38);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "사각형";
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(6, 26);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(68, 38);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.Location = new Point(176, 112);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(68, 38);
            btnCircle.TabIndex = 2;
            btnCircle.Text = "원";
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(282, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(136, 79);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(6, 36);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(124, 28);
            cmbColor.TabIndex = 0;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(424, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(190, 79);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(15, 23);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(160, 56);
            trbLineWidth.TabIndex = 0;
            trbLineWidth.Scroll += trbLineWidth_Scroll;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(633, 117);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(72, 48);
            btnOpenFile.TabIndex = 5;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(711, 117);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(72, 48);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnCircle);
            Controls.Add(groupBox1);
            Controls.Add(picCanvas);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
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
