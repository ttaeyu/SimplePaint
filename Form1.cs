namespace SimplePaint
{
    public partial class Form1 : Form
    {
        int shapeNum = 1;
        // 마우스를 누른 시작점과 뗀 끝점
        Point startP, endP;
        // 선의 색상과 굵기
        Color penColor = Color.Black;
        int penWidth = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            penColor = Color.FromName(cmbColor.Text);
        }

        private void trbLineWidth_Scroll(object sender, EventArgs e)
        {
            penWidth = trbLineWidth.Value;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            startP = e.Location; // 마우스를 누른 그 지점을 '시작점'으로 저장!
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            endP = e.Location;

            Graphics g = picCanvas.CreateGraphics();
            Pen myPen = new Pen(penColor, penWidth);

            if (shapeNum == 1) // 직선
            {
                g.DrawLine(myPen, startP, endP);
            }
            else if (shapeNum == 2) // 사각형
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int width = Math.Abs(startP.X - endP.X);
                int height = Math.Abs(startP.Y - endP.Y);

                g.DrawRectangle(myPen, x, y, width, height);
            }
            else if (shapeNum == 3) // 원
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int width = Math.Abs(startP.X - endP.X);
                int height = Math.Abs(startP.Y - endP.Y);

                g.DrawEllipse(myPen, x, y, width, height);
            }

            myPen.Dispose();
            g.Dispose();
        }
    }
}
