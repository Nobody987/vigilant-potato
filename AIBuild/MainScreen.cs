using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AIBuild
{
    public partial class MainScreen : Form
    {

        static int POSITION_INITIAL_X = 12, POSITION_INITIAL_Y = 200;

        int _height, _width;
        int SPEED_VERTICAL = 0, SPEED_HORIZONTAL = 1, SPEED_MULTIPLIER = 1;

        List<PictureBox> listAllWalls;

        public MainScreen()
        {
            InitializeComponent();
            _height = Size.Height;
            _width = Size.Width;

            listAllWalls = new List<PictureBox>();
            foreach (PictureBox item in Controls)
            {
                if (item.Name != Square.Name)
                {
                    listAllWalls.Add(item);
                }
            }

        }

        private void timerMain_Tick(object sender, System.EventArgs e)
        {
            doMove(SPEED_HORIZONTAL, SPEED_VERTICAL, SPEED_MULTIPLIER);

            if (!ClientRectangle.Contains(Square.Bounds))
            {
                resetPosition();
                resetSpeed();
            }

            foreach (var item in listAllWalls)
            {
                if (item.Bounds.IntersectsWith(Square.Bounds))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        doMove(SPEED_HORIZONTAL * -1, SPEED_VERTICAL * -1, SPEED_MULTIPLIER);
                    }
                    doMoveUp();
                }
            }
        }

        private void doMoveUp()
        {
            SPEED_VERTICAL = SPEED_MULTIPLIER * -1;
            SPEED_HORIZONTAL = 0;
        }

        private void doMove(int speedHorizontal, int speedVertical, int multiplier)
        {
            int speedX = speedHorizontal * multiplier, speedY = speedVertical * multiplier;
            Square.Location = new Point(Square.Location.X + speedX, Square.Location.Y + speedY);
        }

        private void resetPosition()
        {
            Square.Location = new Point(POSITION_INITIAL_X, POSITION_INITIAL_Y);
        }
        private void resetSpeed()
        {
            SPEED_VERTICAL = 0;
            SPEED_HORIZONTAL = 1;
        }
    }
}
