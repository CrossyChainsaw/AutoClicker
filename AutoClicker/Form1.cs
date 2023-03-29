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

        // Fields
        bool _clicked = false;
        int _nGroupbox = 1;
        int _verticalDistanceBetweenGroupboxes = 27;
        List<Point> _pointList = new List<Point>();
        List<int> _delayList = new List<int>();
        Label _lbl_x_temp;
        Label _lbl_y_temp;
        int _nTemp;
        List<Action> _actionList = new List<Action>();

        // input simulator?
        // Send keys?
        // https://github.com/School-Semester-Summaries/software-semester-2/blob/main/semester-2-repository/BrawlhallaBot%20v2.0/Spambot/Form1.cs


        // Methods
        public FRM_AutoClicker()
        {
            InitializeComponent();
            _actionList.Add(new MouseAction(new Point(0, 0), 0));
        }
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        void CreateGroupBox_MouseClick()
        {
            // GROUPBOX DESIGN STUFF    
            int yLocation = GB_FirstPoint.Location.Y + _verticalDistanceBetweenGroupboxes * _nGroupbox;
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
            lbl_point.Text = "Point " + (_nGroupbox + 1) + ":";
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

            nud_delay.Location = new Point(284, 11);
            nud_delay.Size = new Size(102, 27);
            nud_delay.Minimum = 0;
            nud_delay.Maximum = 1000000000;
            nud_delay.ValueChanged += (sender, e) =>
            {
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Point ", "").Replace(":", ""));
                int nDelay = nPoint - 1;
                int delay = Convert.ToInt32(nud_delay.Value);
                _actionList[nDelay].SetDelay(delay);
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
                _clicked = true;
                _lbl_x_temp = lbl_x;
                _lbl_y_temp = lbl_y;
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Point ", "").Replace(":", ""));
                _nTemp = nPoint - 1;
            };

            Controls.Add(groupBox);
            
            // //
            _actionList.Add(new MouseAction(new Point(0, 0), 0));

            _nGroupbox++;
        }
        void CreateGroupBox_ButtonPress()
        {
            // GROUPBOX DESIGN
            int yLocation = GB_FirstPoint.Location.Y + _verticalDistanceBetweenGroupboxes * _nGroupbox;
            int xLocation = GB_FirstPoint.Location.X;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(xLocation, yLocation);
            groupBox.Size = new Size(561, 38);
            groupBox.Text = "";

            Label lbl_point = new Label();
            ComboBox cmb_keys = new ComboBox();
            Label lbl_delay = new Label();
            NumericUpDown nud_delay = new NumericUpDown();
            Label lbl_ms = new Label();

            groupBox.Controls.Add(lbl_point);
            groupBox.Controls.Add(cmb_keys);
            groupBox.Controls.Add(lbl_delay);
            groupBox.Controls.Add(nud_delay);
            groupBox.Controls.Add(lbl_ms);

            lbl_point.Location = new Point(3, 13);
            lbl_point.Text = "Button " + (_nGroupbox + 1) + ":";
            lbl_point.Size = new Size(57, 20);

            cmb_keys.Location = new Point(66, 11);
            cmb_keys.Size = new Size(102, 27);
            cmb_keys.DataSource = new KeyAction(null, 0).AllKeyStrings;
            cmb_keys.SelectedIndexChanged += (sender, e) =>
            {
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Button ", "").Replace(":", ""));
                int nDelay = nPoint - 1;
                _actionList[nDelay].SetKey(cmb_keys.SelectedValue.ToString());
            };

            lbl_delay.Location = new Point(236, 13);
            lbl_delay.Text = "delay:";
            lbl_delay.AutoSize = true;

            nud_delay.Location = new Point(284, 11);
            nud_delay.Size = new Size(102, 27);
            nud_delay.Minimum = 0;
            nud_delay.Maximum = 1000000000;
            nud_delay.ValueChanged += (sender, e) =>
            {
                // how do i reach the correct slot?
                int nPoint = Convert.ToInt32(lbl_point.Text.Replace("Button ", "").Replace(":", ""));
                int nDelay = nPoint - 1;
                int delay = Convert.ToInt32(nud_delay.Value);
                _actionList[nDelay].SetDelay(delay);
            };

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            // //
            Controls.Add(groupBox);
            _actionList.Add(new KeyAction(null, 0));

            _nGroupbox++;
        }
        void SavePoint(Label lbl_x, Label lbl_y, int nGroupbox)
        {
            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y;
            lbl_x.Text = "x: " + cursorX;
            lbl_y.Text = "y: " + cursorY;

            _actionList[nGroupbox].SetPoint(new Point(cursorX, cursorY));
        }
        string CalculateEstimatedTime()
        {
            int oneLoopDuration = 0;
            foreach (int delay in _delayList)
            {
                oneLoopDuration += delay;
            }
            int repetitions = Convert.ToInt32(NUD_Repetitions.Value);
            int estimatedTimeInMilliseconds = oneLoopDuration * repetitions;


            if (estimatedTimeInMilliseconds >= 120000)
            {
                int estimatedTimeInMinutes = estimatedTimeInMilliseconds / 1000 / 60;
                return estimatedTimeInMinutes + "min";
            }
            else if (estimatedTimeInMilliseconds > 1000)
            {
                int estimatedTimeInSeconds = estimatedTimeInMilliseconds / 1000;
                return estimatedTimeInSeconds + "s";
            }
            else
            {
                return estimatedTimeInMilliseconds + "ms";
            }
        }

        // Events
        private void FRM_AutoClicker_Deactivate(object sender, EventArgs e)
        {
            if (_clicked)
            {
                SavePoint(_lbl_x_temp, _lbl_y_temp, _nTemp);
                _clicked = false;
            }
        }
        private void BTN_SetLocation_Click(object sender, EventArgs e)
        {
            _clicked = true;
            _lbl_x_temp = LBL_X1;
            _lbl_y_temp = LBL_Y1;
        }
        private void BTN_Add_Click(object sender, EventArgs e)
        {
            CreateGroupBox_MouseClick();
        }
        private void BTN_AddButtonPress_Click(object sender, EventArgs e)
        {
            CreateGroupBox_ButtonPress();
        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            int repetitions = Convert.ToInt32(NUD_Repetitions.Value);
            for (int i = 0; i < repetitions; i++)
            {
                for (int n = 0; n < _actionList.Count; n++)
                {
                    Thread.Sleep(_actionList[n].Delay);
                    if (_actionList[n] is KeyAction)
                    {
                        SendKeys.Send(_actionList[n].Key);
                    }
                    else if (_actionList[n] is MouseAction)
                    {
                        Cursor.Position = _actionList[n].Point;
                        DoMouseClick();
                    }
                }
            }
        }
        private void NUD_Delay_ValueChanged(object sender, EventArgs e)
        {
            int delay = Convert.ToInt32(NUD_Delay.Value);
            _actionList[0].SetDelay(delay);
        }
        private void NUD_Repetitions_ValueChanged(object sender, EventArgs e)
        {
            LBL_EstimatedTime.Text = "Estimated time: " + CalculateEstimatedTime();
        }
        async private void BTN_Save_Click(object sender, EventArgs e)
        {
            List<(int x, int y, int delay)> formattedList = new List<(int x, int y, int delay)>();
            for (int i = 0; i < _pointList.Count; i++)
            {
                formattedList.Add((_pointList[i].X, _pointList[i].Y, _delayList[i]));
            }
            await Data.Overwrite(formattedList);
            MessageBox.Show("DATA SAVED");
        }
        private void BTN_Load_Click(object sender, EventArgs e)
        {
            List<(int x, int y, int delay)> data;
            data = Data.LoadAsTupleList();
            _pointList.Clear();
            _delayList.Clear();
            foreach (var item in data)
            {
                _pointList.Add(new Point(item.x, item.y));
                _delayList.Add(item.delay);
            }
            MessageBox.Show("DATA LOADED");
        }
    }
}