namespace AutoClicker
{
    public partial class FRM_AutoClicker : Form
    {
        // Properties
        bool clicked = false;
        Point point1;
        int nGroupbox = 1;
        int verticalDistanceBetweenGroupboxes = 27;
        List<Point> pointList = new List<Point>();
        Label lbl_x_temp;
        Label lbl_y_temp;
        int nTemp;
        

        // Constructor
        public FRM_AutoClicker()
        {
            InitializeComponent();
            pointList.Add(new Point(0, 0));
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

        // Methods
        void CreateGroupBox()
        {
            int y = GB_FirstPoint.Location.Y + verticalDistanceBetweenGroupboxes * nGroupbox;
            int x = GB_FirstPoint.Location.X;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(12, y);
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
            lbl_x.Text = "x: null";
            lbl_x.AutoSize = true;

            lbl_y.Location = new Point(119, 13);
            lbl_y.Text = "y: null";
            lbl_y.AutoSize = true;

            lbl_delay.Location = new Point(236, 13);
            lbl_delay.Text = "delay:";
            lbl_delay.AutoSize = true;

            nud_delay.Location = new Point(284, 10);
            nud_delay.Size = new Size(102, 27);

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            btn_SetLocation.Location = new Point(447, 9);
            btn_SetLocation.Text = "Set Location";
            btn_SetLocation.Size = new Size(114, 29);
            btn_SetLocation.Click += (sender, e) =>
            {
                MessageBox.Show("the button was clicked");
            };

            Controls.Add(groupBox);

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
    }
}