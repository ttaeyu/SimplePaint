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
        Bitmap canvasBitmap;     // 진짜 그림이 영구적으로 저장될 도화지
        Graphics canvasGraphics; // 이 진짜 도화지에만 그림을 그리는 전담 화가
        public Form1()
        {
            InitializeComponent();
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height); 
    
    // 2. 이 도화지에 그림을 그릴 전담 화가를 부릅니다[cite: 1]
    canvasGraphics = Graphics.FromImage(canvasBitmap); 
    
    // 3. 도화지를 하얀색으로 싹 칠해줍니다[cite: 1]
    canvasGraphics.Clear(Color.White); 
    
    // 4. 이 진짜 도화지를 화면(픽쳐박스)에 끼워 넣어서 우리 눈에 보이게 해요[cite: 1]
    picCanvas.Image = canvasBitmap; 
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

            // 일회용 화가(g)를 지우고 연필만 준비해요
            Pen myPen = new Pen(penColor, penWidth);

            if (shapeNum == 1) // 직선
            {
                canvasGraphics.DrawLine(myPen, startP, endP); // g 대신 canvasGraphics로 바뀜![cite: 1]
            }
            else if (shapeNum == 2) // 사각형
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int width = Math.Abs(startP.X - endP.X);
                int height = Math.Abs(startP.Y - endP.Y);

                canvasGraphics.DrawRectangle(myPen, x, y, width, height); 
    }
            else if (shapeNum == 3) // 원
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int width = Math.Abs(startP.X - endP.X);
                int height = Math.Abs(startP.Y - endP.Y);

                canvasGraphics.DrawEllipse(myPen, x, y, width, height); 
    }

            // ★중요★ 진짜 도화지에 그림이 추가됐으니, 화면도 새로고침해서 보여달라고 명령해요![cite: 1]
            picCanvas.Invalidate(); 

    myPen.Dispose();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스를 왼쪽 버튼으로 누른 상태에서 움직일 때만 작동!
            if (e.Button == MouseButtons.Left)
            {
                endP = e.Location; // 움직이는 동안의 위치를 계속 끝점으로 업데이트

                // 이 부분이 핵심! 화면을 강제로 다시 그리게 해서 
                // 이전에 그렸던 가이드라인은 지우고 새 가이드라인을 보여줍니다.
                picCanvas.Invalidate(); 
    }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            // 마우스 왼쪽 버튼이 눌려있을 때만 (드래그 중일 때만) 작동해요
            if (Control.MouseButtons == MouseButtons.Left)
            {
                // 1. 연필 준비
                Pen myPen = new Pen(penColor, penWidth);

                // 2. Paint 전용 화가(e.Graphics)를 사용합니다!
                if (shapeNum == 1) // 직선
                {
                    e.Graphics.DrawLine(myPen, startP, endP);
                }
                else if (shapeNum == 2) // 사각형
                {
                    int x = Math.Min(startP.X, endP.X);
                    int y = Math.Min(startP.Y, endP.Y);
                    int width = Math.Abs(startP.X - endP.X);
                    int height = Math.Abs(startP.Y - endP.Y);

                    e.Graphics.DrawRectangle(myPen, x, y, width, height);
                }
                else if (shapeNum == 3) // 원
                {
                    int x = Math.Min(startP.X, endP.X);
                    int y = Math.Min(startP.Y, endP.Y);
                    int width = Math.Abs(startP.X - endP.X);
                    int height = Math.Abs(startP.Y - endP.Y);

                    e.Graphics.DrawEllipse(myPen, x, y, width, height);
                }

                // 3. 연필 정리
                myPen.Dispose();
            }
        }
    }
}
