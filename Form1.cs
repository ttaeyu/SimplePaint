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
        Graphics canvasGraphics;// 이 진짜 도화지에만 그림을 그리는 전담 화가
        Point startPScreen, endPScreen; // 화면 미리보기용 좌표 추가!

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
            float zoomRatio = trbZoom.Value / 10.0f;
            startP = new Point((int)(e.X / zoomRatio), (int)(e.Y / zoomRatio));
            startPScreen = e.Location;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            float zoomRatio = trbZoom.Value / 10.0f;
            endP = new Point((int)(e.X / zoomRatio), (int)(e.Y / zoomRatio));

            Pen myPen = new Pen(penColor, penWidth);

            if (shapeNum == 1) canvasGraphics.DrawLine(myPen, startP, endP);
            else if (shapeNum == 2)
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int w = Math.Abs(startP.X - endP.X);
                int h = Math.Abs(startP.Y - endP.Y);
                canvasGraphics.DrawRectangle(myPen, x, y, w, h);
            }
            else if (shapeNum == 3)
            {
                int x = Math.Min(startP.X, endP.X);
                int y = Math.Min(startP.Y, endP.Y);
                int w = Math.Abs(startP.X - endP.X);
                int h = Math.Abs(startP.Y - endP.Y);
                canvasGraphics.DrawEllipse(myPen, x, y, w, h);
            }

            picCanvas.Invalidate();
            myPen.Dispose();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                float zoomRatio = trbZoom.Value / 10.0f;
                endP = new Point((int)(e.X / zoomRatio), (int)(e.Y / zoomRatio));
                endPScreen = e.Location;
                picCanvas.Invalidate();
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                float zoomRatio = trbZoom.Value / 10.0f;
                Pen myPen = new Pen(penColor, penWidth * zoomRatio); // 확대된 만큼 연필도 두껍게 보이게!
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                if (shapeNum == 1) e.Graphics.DrawLine(myPen, startPScreen, endPScreen);
                else if (shapeNum == 2)
                {
                    int x = Math.Min(startPScreen.X, endPScreen.X);
                    int y = Math.Min(startPScreen.Y, endPScreen.Y);
                    int w = Math.Abs(startPScreen.X - endPScreen.X);
                    int h = Math.Abs(startPScreen.Y - endPScreen.Y);
                    e.Graphics.DrawRectangle(myPen, x, y, w, h);
                }
                else if (shapeNum == 3)
                {
                    int x = Math.Min(startPScreen.X, endPScreen.X);
                    int y = Math.Min(startPScreen.Y, endPScreen.Y);
                    int w = Math.Abs(startPScreen.X - endPScreen.X);
                    int h = Math.Abs(startPScreen.Y - endPScreen.Y);
                    e.Graphics.DrawEllipse(myPen, x, y, w, h);
                }
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

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "배경 그림 불러오기";
            openDlg.Filter = "이미지 파일(*.png, *.jpg, *.bmp)|*.png;*.jpg;*.bmp";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                Image loadedImage = Image.FromFile(openDlg.FileName);

                // 1. 진짜 도화지를 불러온 사진 크기에 맞춰서 새로 만듭니다.
                canvasBitmap = new Bitmap(loadedImage.Width, loadedImage.Height);
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                canvasGraphics.DrawImage(loadedImage, 0, 0, loadedImage.Width, loadedImage.Height);
                picCanvas.Image = canvasBitmap;

                // 👇 여기가 기존과 확 바뀐 마법의 3줄입니다! 👇

                // 2. 픽쳐박스를 꽁꽁 얼려두던 AutoSize 대신, '고무줄'처럼 늘어나는 StretchImage를 씁니다.
                picCanvas.SizeMode = PictureBoxSizeMode.StretchImage;

                float zoomRatio = trbZoom.Value / 10.0f; // 여기서도 나누기 10 적용!
                picCanvas.Width = (int)(canvasBitmap.Width * zoomRatio);
                picCanvas.Height = (int)(canvasBitmap.Height * zoomRatio);

                loadedImage.Dispose();
            }
        }

        private void trbZoom_Scroll(object sender, EventArgs e)
        {
            if (canvasBitmap != null)
            {
                float zoomRatio = trbZoom.Value / 10.0f; // 마법의 나누기 10! (예: 15 / 10 = 1.5배)
                picCanvas.Width = (int)(canvasBitmap.Width * zoomRatio);
                picCanvas.Height = (int)(canvasBitmap.Height * zoomRatio);
            }
        }
    }
}
