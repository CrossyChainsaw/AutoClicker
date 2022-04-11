using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class FRM_AutoClicker : Form
    {
        // No idea wtf this is but it works
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }


        // Fields
        bool clicked = false;
        Point point1;
        int nGroupbox = 1;
        int verticalDistanceBetweenGroupboxes = 27;
        List<Point> pointList = new List<Point>();
        List<int> delayList = new List<int>();
        Label lbl_x_temp;
        Label lbl_y_temp;
        int nTemp;
        int delayTemp;


        // Methods
        public FRM_AutoClicker()
        {
            InitializeComponent();
            pointList.Add(new Point(0, 0));
            delayList.Add(0);
        }

        void CreateGroupBox()
        {
            int yLocation = GB_FirstPoint.Location.Y + verticalDistanceBetweenGroupboxes * nGroupbox;
            int xLocation = GB_FirstPoint.Location.X;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(xLocation, yLocation);
            groupBox.Size = new Size(561, 38);
            groupBox.Text = "";

            Label lbl_point = new Label();
            Label lbl_x = new Label();
            Label lbl_y = new Label();
            Label lbl_delay = new Label();
            NumericUpDown nud_delay = new NumericUpDown();
            Label lbl_ms = new Label();
            Button btn_SetLocation = new Button();

            groupBox.Controls.Add(lbl_point);
            groupBox.Controls.Add(lbl_x);
            groupBox.Controls.Add(lbl_y);
            groupBox.Controls.Add(lbl_delay);
            groupBox.Controls.Add(nud_delay);
            groupBox.Controls.Add(lbl_ms);
            groupBox.Controls.Add(btn_SetLocation);

            lbl_point.Location = new Point(3, 13);
            lbl_point.Text = "Point " + (nGroupbox + 1) + ":";
            lbl_point.Size = new Size(57, 20);

            lbl_x.Location = new Point(66, 13);
            lbl_x.Text = "x: 0";
            lbl_x.AutoSize = true;

            lbl_y.Location = new Point(119, 13);
            lbl_y.Text = "y: 0";
            lbl_y.AutoSize = true;

            lbl_delay.Location = new Point(236, 13);
            lbl_delay.Text = "delay:";
            lbl_delay.AutoSize = true;

            nud_delay.Location = new Point(284, 10);
            nud_delay.Size = new Size(102, 27);
            nud_delay.Minimum = 0;
            nud_delay.Maximum = 1000000000;
            nud_delay.ValueChanged += (sender, e) =>
            {
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Point ", "").Replace(":", ""));
                int nDelay = nPoint - 1;
                int delay = Convert.ToInt32(nud_delay.Value);
                delayList[nDelay] = delay;
            };

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            btn_SetLocation.Location = new Point(447, 9);
            btn_SetLocation.Text = "Set Location";
            btn_SetLocation.Size = new Size(114, 29);
            btn_SetLocation.Cursor = Cursors.Hand;
            btn_SetLocation.Click += (sender, e) =>
            {
                clicked = true;
                lbl_x_temp = lbl_x;
                lbl_y_temp = lbl_y;
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Point ", "").Replace(":", ""));
                nTemp = nPoint - 1;
            };

            Controls.Add(groupBox);
            pointList.Add(new Point(0, 0));
            delayList.Add(0);

            nGroupbox++;
        }

        void SavePoint(Label lbl_x, Label lbl_y, int nGroupbox)
        {
            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y;
            lbl_x.Text = "x: " + cursorX;
            lbl_y.Text = "y: " + cursorY;
            pointList[nGroupbox] = new Point(cursorX, cursorY);
        }

        // Events
        private void FRM_AutoClicker_Deactivate(object sender, EventArgs e)
        {
            if (clicked)
            {
                SavePoint(lbl_x_temp, lbl_y_temp, nTemp);
                clicked = false;
            }
        }

        private void BTN_SetLocation_Click(object sender, EventArgs e)
        {
            clicked = true;
            lbl_x_temp = LBL_X1;
            lbl_y_temp = LBL_Y1;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            CreateGroupBox();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            int repetitions = Convert.ToInt32(NUD_Repetitions.Value);
            for (int i = 0; i < repetitions; i++)
            {
                for (int n = 0; n < delayList.Count; n++)
                {
                    Thread.Sleep(delayList[n]);
                    Cursor.Position = pointList[n];
                    DoMouseClick();
                }
            }
        }

        private void NUD_Delay_ValueChanged(object sender, EventArgs e)
        {
            int delay = Convert.ToInt32(NUD_Delay.Value);
            delayList[0] = delay;
        }
    }
}