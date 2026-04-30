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
            switch (cmbColor.SelectedIndex)
            {
                case 0: // 첫 번째(Black 검정)를 골랐다면
                    penColor = Color.Black; 
            break;
                case 1: // 두 번째(Red 빨강)를 골랐다면
                    penColor = Color.Red; 
            break;
                case 2: // 세 번째(Blue 파랑)를 골랐다면[cite: 1]
                    penColor = Color.Blue;
            break;
                case 3: // 네 번째(Green 녹색)를 골랐다면[cite: 1]
                    penColor = Color.Green; 
            break;
                default:
                   
            penColor = Color.Black; // 혹시 몰라서 기본은 검정으로![cite: 1]
                    break;
            }
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

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // 1. "어디에 저장할까?" 물어보는 창을 준비합니다.
            SaveFileDialog saveDlg = new SaveFileDialog();

            // 2. 저장할 파일의 종류를 정해줘요 (PNG, JPG, BMP 세 가지로요!)
            saveDlg.Filter = "PNG 파일 (*.png)|*.png|JPG 파일 (*.jpg)|*.jpg|BMP 파일 (*.bmp)|*.bmp";
            saveDlg.Title = "내 그림 저장하기"; // 창의 맨 위 제목

            // 3. 창을 띄우고, 만약 사용자가 '저장' 버튼을 꾹 눌렀다면?
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                // 아까 만들어둔 '진짜 도화지(canvasBitmap)'를 선택한 경로에 진짜 파일로 저장합니다!
                canvasBitmap.Save(saveDlg.FileName);

                // 잘 저장됐다고 안내창을 하나 띄워줘요. (이건 센스!)
                MessageBox.Show("그림이 성공적으로 저장되었습니다!", "저장 완료");
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapeNum = 1;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shapeNum = 2;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapeNum = 3;
        }
    }
}
