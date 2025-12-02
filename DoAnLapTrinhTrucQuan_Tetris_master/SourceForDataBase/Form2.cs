using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SourceForDataBase
{
    public partial class Form2 : Form
    {
        private const int BOARD_WIDTH = 10;
        private const int BOARD_HEIGHT = 20;
        private const int BLOCK_SIZE = 20;
        private enum TileType
        {
            Empty,
            Green,
            Orange,
            Red,
            Blue,
            Yellow,
            Cyan,
            Purple
        }

        private TileType[,] gameGrid = new TileType[BOARD_WIDTH, BOARD_HEIGHT];
        private Image[] tileImages;

        private Timer gameTimer = new Timer();
        private int score = 0;

        bool isRunning = false;   // game đã từng start chưa
        bool isPaused = false;    // game đang tạm dừng

        public Form2()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember(
            "DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null,
            gameBoardPanel,
            new object[] { true });

            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            gameBoardPanel.Paint += new PaintEventHandler(GameBoardPanel_Paint);
            gameBoardPanel.Width = BOARD_WIDTH * BLOCK_SIZE;
            gameBoardPanel.Height = BOARD_HEIGHT * BLOCK_SIZE;

            LoadTileImages();
            InitializeTetrominoes();

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void LoadTileImages()
        {
            tileImages = new Image[]
            {
                Properties.Resources.TileEmpty,
                Properties.Resources.TileGreen,
                Properties.Resources.TileOrange,
                Properties.Resources.TileRed,
                Properties.Resources.TileBlue,
                Properties.Resources.TileYellow,
                Properties.Resources.TileCyan,
                Properties.Resources.TilePurple
            };
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            btnPause.Visible = false;
            btnPause.Enabled = false;
        }

        private void GameBoardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.DrawImage(Properties.Resources.Background, new Rectangle(0, 0, gameBoardPanel.Width, gameBoardPanel.Height));
            for (int y = 0; y < BOARD_HEIGHT; y++)
            {
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    Rectangle blockRect = new Rectangle(
                        x * BLOCK_SIZE,
                        y * BLOCK_SIZE,
                        BLOCK_SIZE,
                        BLOCK_SIZE
                    );

                    TileType type = gameGrid[x, y];

                    Image tileImage = tileImages[(int)type];

                    g.DrawImage(tileImage, blockRect);
                }
            }

            DrawCurrentPiece(g);
        }

        private List<(bool[,], TileType)> tetrominoes = new List<(bool[,], TileType)>();
        private void InitializeTetrominoes()
        {
            tetrominoes = new List<(bool[,], TileType)>
            {
                (new bool[,] { { true, true, true, true } }, TileType.Cyan),                        // I
                (new bool[,] { { true, true }, { true, true } }, TileType.Yellow),                  // O
                (new bool[,] { { false, true, false }, { true, true, true } }, TileType.Purple),    // T
                (new bool[,] { { false, true, true }, { true, true, false } }, TileType.Green),     // S
                (new bool[,] { { true, true, false }, { false, true, true } }, TileType.Red),       // Z
                (new bool[,] { { true, false, false }, { true, true, true } }, TileType.Blue),      // J
                (new bool[,] { { false, false, true }, { true, true, true } }, TileType.Orange)     // L
            };
        }


        private struct Piece
        {
            public bool[,] shape;
            public TileType type;
            public int x;
            public int y;
        }

        private Piece currentPiece;

        Random rand = new Random();
        private void InitializeNewPiece()
        {
            var (shape, type) = tetrominoes[rand.Next(tetrominoes.Count)];

            currentPiece = new Piece
            {
                shape = shape,
                type = type,
                x = BOARD_WIDTH / 2 - shape.GetLength(1) / 2,
                y = 0
            };

            if (!CoTheXuong(currentPiece, 0, 0))
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!");

            }
        }

        private void DrawCurrentPiece(Graphics g)
        {
            if (currentPiece.shape == null) return;

            Image pieceImage = tileImages[(int)currentPiece.type];

            int shapeRows = currentPiece.shape.GetLength(0);
            int shapeCols = currentPiece.shape.GetLength(1);

            for (int row = 0; row < shapeRows; row++)
            {
                for (int col = 0; col < shapeCols; col++)
                {
                    if (currentPiece.shape[row, col])
                    {
                        Rectangle blockRect = new Rectangle(
                            (currentPiece.x + col) * BLOCK_SIZE,
                            (currentPiece.y + row) * BLOCK_SIZE,
                            BLOCK_SIZE,
                            BLOCK_SIZE
                        );

                        g.DrawImage(pieceImage, blockRect);
                    }
                }
            }
        }

        //Overrived để WinForms xử lý mũi tên như bình thường
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Left || keyData == Keys.Right ||
                keyData == Keys.Up || keyData == Keys.Down)
                return true;

            return base.IsInputKey(keyData);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            DiXuong();
        }

        private bool CoTheXuong(Piece piece, int dx, int dy)
        {
            int rows = piece.shape.GetLength(0);
            int cols = piece.shape.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (!piece.shape[r, c]) continue;

                    int newX = piece.x + c + dx;
                    int newY = piece.y + r + dy;

                    if (newX < 0 || newX >= BOARD_WIDTH || newY >= BOARD_HEIGHT)
                        return false; // ra ngoài bảng

                    if (newY >= 0 && gameGrid[newX, newY] != TileType.Empty)
                        return false; // trùng gạch đã có
                }
            }

            return true;
        }

        private void DiXuong()
        {
            if (CoTheXuong(currentPiece, 0, 1))
            {
                currentPiece.y += 1;
            }
            else
            {
                KhoaKhoi(); // khối chạm đáy → chuyển vào lưới
                XoaHang(); // kiểm tra xóa hàng
                InitializeNewPiece(); // tạo khối mới
            }

            gameBoardPanel.Invalidate(); // vẽ lại
        }

        private void SangTrai()
        {
            if (CoTheXuong(currentPiece, -1, 0))
            {
                currentPiece.x -= 1;
                gameBoardPanel.Invalidate();
            }
        }

        private void SangPhai()
        {
            if (CoTheXuong(currentPiece, 1, 0))
            {
                currentPiece.x += 1;
                gameBoardPanel.Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("KeyDown: " + e.KeyCode); // mở Output window để xem
                                                      // hoặc tạm dùng: Console.WriteLine(...) hoặc MessageBox.Show(...) để test
                                                      // copy logic từ override OnKeyDown của bạn nếu muốn:
            if (currentPiece.shape == null) return;

            switch (e.KeyCode)
            {
                case Keys.Left: case Keys.A:
                    SangTrai();
                    break;
                case Keys.Right: case Keys.D:
                    SangPhai();
                    break;
                case Keys.Down: case Keys.S:
                    DiXuong();
                    break;
                case Keys.Up: case Keys.W:
                    QuayKhoi();
                    break;
            }
            e.Handled = true;
        }

        private void KhoaKhoi()
        {
            int rows = currentPiece.shape.GetLength(0);
            int cols = currentPiece.shape.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (currentPiece.shape[r, c])
                    {
                        int x = currentPiece.x + c;
                        int y = currentPiece.y + r;

                        if (y >= 0)
                            gameGrid[x, y] = currentPiece.type;
                    }
                }
            }
        }

        private void XoaHang()
        {
            for (int y = BOARD_HEIGHT - 1; y >= 0; y--)
            {
                bool fullLine = true;
                for (int x = 0; x < BOARD_WIDTH; x++)
                {
                    if (gameGrid[x, y] == TileType.Empty)
                    {
                        fullLine = false;
                        break;
                    }
                }

                if (fullLine)
                {
                    // Xóa hàng
                    for (int yy = y; yy > 0; yy--)
                    {
                        for (int x = 0; x < BOARD_WIDTH; x++)
                        {
                            gameGrid[x, yy] = gameGrid[x, yy - 1];
                        }
                    }

                    for (int x = 0; x < BOARD_WIDTH; x++)
                    {
                        gameGrid[x, 0] = TileType.Empty;
                    }

                    score += 100; // cộng điểm
                    scoreLabel.Text = "Score: " + score;

                    y++; // kiểm tra lại hàng vừa đẩy xuống
                }
            }
        }

        private void QuayKhoi()
        {
            int rows = currentPiece.shape.GetLength(0);
            int cols = currentPiece.shape.GetLength(1);
            bool[,] rotated = new bool[cols, rows];

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    rotated[c, rows - 1 - r] = currentPiece.shape[r, c];

            Piece rotatedPiece = currentPiece;
            rotatedPiece.shape = rotated;

            if (CoTheXuong(rotatedPiece, 0, 0))
            {
                currentPiece = rotatedPiece;
                gameBoardPanel.Invalidate();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < BOARD_WIDTH; x++)
            {
                for (int y = 0; y < BOARD_HEIGHT; y++)
                {
                    gameGrid[x, y] = TileType.Empty; // Xóa sạch lưới
                }
            }

            InitializeNewPiece();
            gameBoardPanel.Invalidate();

            btnStart.Enabled = false;
            scoreLabel.Text = "Score: 0";

            gameTimer.Start();

            this.KeyPreview = true;
            this.ActiveControl = null;
            this.Focus();

            btnPause.Visible = true;
            btnPause.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                gameTimer.Stop();
                isPaused = true;
                btnPause.BackColor = Color.Gray;
                btnPause.Text = "Resume";
            }
            else
            {
                gameTimer.Start();
                isPaused = false;
                btnPause.BackColor = Color.White;
                btnPause.Text = "Pause";
            }

            this.ActiveControl = null;
            this.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            btnPause_Click(sender, e);
            DialogResult result = MessageBox.Show("Bạn có muốn thoát trò chơi?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
