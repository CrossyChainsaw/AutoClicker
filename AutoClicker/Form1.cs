using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace AutoClicker
{

    // last time i was working in cretegbbutton press, go to the bottom. make the del button work, del button cant reference the correct gb and aciton yet

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
        int gbx = 10;
        int gby = 47;
        bool _clicked = false;
        int _nGroupbox = 1; // might do shit
        Action _actionReference;
        int _nAction = 0; // might do shit
        int _verticalDistanceBetweenGroupboxes = 27;
        List<GroupBox> _groupBoxList = new List<GroupBox>();
        Label _lbl_x_temp;
        Label _lbl_y_temp;
        List<Action> _actionList = new List<Action>();
        InputSimulator _inputSim = new InputSimulator();

        // Methods
        public FRM_AutoClicker()
        {
            InitializeComponent();
        }
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        void CreateGroupBox_MouseAction(int x = 0, int y = 0, int delay = 100)
        {
            // Local Variables
            Action actionReference = new MouseAction(new Point(x, y), delay);

            // GROUPBOX DESIGN STUFF    
            int yLocation = gby + _verticalDistanceBetweenGroupboxes * _nGroupbox;
            int xLocation = gbx;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(xLocation, yLocation);
            groupBox.Size = new Size(610, 38);
            groupBox.Text = "";

            Label lbl_point = new Label();
            Label lbl_x = new Label();
            Label lbl_y = new Label();
            Label lbl_delay = new Label();
            NumericUpDown nud_delay = new NumericUpDown();
            Label lbl_ms = new Label();
            Button btn_SetLocation = new Button();
            Button btn_del = new Button();

            groupBox.Controls.Add(lbl_point);
            groupBox.Controls.Add(lbl_x);
            groupBox.Controls.Add(lbl_y);
            groupBox.Controls.Add(lbl_delay);
            groupBox.Controls.Add(nud_delay);
            groupBox.Controls.Add(lbl_ms);
            groupBox.Controls.Add(btn_SetLocation);
            groupBox.Controls.Add(btn_del);

            lbl_point.Location = new Point(3, 13);
            lbl_point.Text = "Point " + _nGroupbox + ":";
            lbl_point.Size = new Size(57, 20);

            lbl_x.Location = new Point(66, 13);
            lbl_x.Text = "x: " + x;
            lbl_x.AutoSize = true;

            lbl_y.Location = new Point(119, 13);
            lbl_y.Text = "y: " + y;
            lbl_y.AutoSize = true;

            CreateDelayLabel(lbl_delay);

            CreateDelayNumericUpDown(nud_delay, delay, actionReference);

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            btn_SetLocation.Location = new Point(447, 10);
            btn_SetLocation.Text = "Set Location";
            btn_SetLocation.Size = new Size(114, 24);
            btn_SetLocation.Cursor = Cursors.Hand;
            btn_SetLocation.Click += (sender, e) =>
            {
                _clicked = true;
                _lbl_x_temp = lbl_x;
                _lbl_y_temp = lbl_y;
                _actionReference = actionReference;
            };

            CreateDeleteButton(btn_del, groupBox, actionReference);

            // //
            Controls.Add(groupBox);
            _actionList.Add(actionReference);
            _groupBoxList.Add(groupBox);

            _nAction++;
            _nGroupbox++;
        }
        void CreateGroupBox_KeyAction(VirtualKeyCode key = VirtualKeyCode.CONTROL, int delay = 100)
        {
            // Variables
            Action actionReference = new KeyAction(key, delay);

            // GROUPBOX DESIGN
            int yLocation = gby + _verticalDistanceBetweenGroupboxes * _nGroupbox;
            int xLocation = gbx;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(xLocation, yLocation);
            groupBox.Size = new Size(610, 38); //561 38
            groupBox.Text = "";
            groupBox.Name = "GB" + _nAction;

            Label lbl_point = new Label();
            Label lbl_key = new Label();
            ComboBox cmb_keys = new ComboBox();
            Label lbl_delay = new Label();
            NumericUpDown nud_delay = new NumericUpDown();
            Label lbl_ms = new Label();
            Button btn_del = new Button();

            groupBox.Controls.Add(lbl_point);
            groupBox.Controls.Add(lbl_key);
            groupBox.Controls.Add(cmb_keys);
            groupBox.Controls.Add(lbl_delay);
            groupBox.Controls.Add(nud_delay);
            groupBox.Controls.Add(lbl_ms);
            groupBox.Controls.Add(btn_del);

            lbl_point.Location = new Point(3, 13);
            lbl_point.Text = "Key " + _nGroupbox + ":";
            lbl_point.Size = new Size(57, 20);

            lbl_key.Location = new Point(66, 13);
            lbl_key.Text = "key:";
            lbl_key.AutoSize = true;

            CreateDelayLabel(lbl_delay);

            CreateDelayNumericUpDown(nud_delay, delay, actionReference);

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            cmb_keys.Location = new Point(447, 11);
            cmb_keys.Size = new Size(114, 28);
            cmb_keys.DataSource = KeyAction.ALLKEYS;
            cmb_keys.SelectedIndexChanged += (sender, e) =>
            {
                actionReference.SetKey((VirtualKeyCode)cmb_keys.SelectedValue);
                lbl_key.Text = cmb_keys.SelectedValue.ToString();
            };

            CreateDeleteButton(btn_del, groupBox, actionReference);

            // other shit
            Controls.Add(groupBox);
            _groupBoxList.Add(groupBox);
            _actionList.Add(actionReference);

            // just ignore
            _nAction++;
            _nGroupbox++;
        }
        void CreateGroupBox_TextAction(int delay = 100)
        {
            // Variables
            Action actionReference = new TextAction(string.Empty, delay);

            // GROUPBOX DESIGN
            int yLocation = gby + _verticalDistanceBetweenGroupboxes * _nGroupbox;
            int xLocation = gbx;

            GroupBox groupBox = new GroupBox();
            groupBox.Location = new Point(xLocation, yLocation);
            groupBox.Size = new Size(610, 38); //561 38
            groupBox.Text = "";
            groupBox.Name = "GB" + _nAction;

            Label lbl_point = new Label();
            Label lbl_text = new Label();
            TextBox tb_text = new TextBox();
            Label lbl_delay = new Label();
            NumericUpDown nud_delay = new NumericUpDown();
            Label lbl_ms = new Label();
            Button btn_del = new Button();

            groupBox.Controls.Add(lbl_point);
            groupBox.Controls.Add(lbl_text);
            groupBox.Controls.Add(tb_text);
            groupBox.Controls.Add(lbl_delay);
            groupBox.Controls.Add(nud_delay);
            groupBox.Controls.Add(lbl_ms);
            groupBox.Controls.Add(btn_del);

            lbl_point.Location = new Point(3, 13);
            lbl_point.Text = "Text " + _nGroupbox + ":";
            lbl_point.Size = new Size(57, 20);

            lbl_text.Location = new Point(66, 13);
            lbl_text.Text = "text:";
            lbl_text.AutoSize = true;

            CreateDelayLabel(lbl_delay);

            CreateDelayNumericUpDown(nud_delay, delay, actionReference);

            lbl_ms.Location = new Point(387, 13);
            lbl_ms.Text = "ms";
            lbl_ms.AutoSize = true;

            tb_text.Location = new Point(447, 11);
            tb_text.Size = new Size(114, 28);
            tb_text.TextChanged += (sender, e) =>
            {
                actionReference.SetText(tb_text.Text);
                lbl_text.Text = "text: " + tb_text.Text;
            };

            CreateDeleteButton(btn_del, groupBox, actionReference);

            // other shit
            Controls.Add(groupBox);
            _groupBoxList.Add(groupBox);
            _actionList.Add(actionReference);

            // just ignore
            _nAction++;
            _nGroupbox++;
        }
        void CreateDelayLabel(Label lbl_delay)
        {
            lbl_delay.Location = new Point(236, 13);
            lbl_delay.Text = "delay:";
            lbl_delay.AutoSize = true;
        }
        void CreateDelayNumericUpDown(NumericUpDown nud_delay, int delay, Action actionReference)
        {
            nud_delay.Location = new Point(284, 11);
            nud_delay.Size = new Size(102, 27);
            nud_delay.Minimum = 0;
            nud_delay.Maximum = 1000000000;
            nud_delay.Value = delay; // Extra line
            nud_delay.ValueChanged += (sender, e) =>
            {
                int delay = Convert.ToInt32(nud_delay.Value);
                actionReference.SetDelay(delay);
            };
        }
        void CreateDeleteButton(Button btn_del, GroupBox groupBox, Action actionReference)
        {
            btn_del.Size = new Size(40, 27);
            btn_del.Location = new Point(569, 9);
            btn_del.Text = "DEL";
            btn_del.Click += (sender, e) =>
            {
                Controls.Remove(groupBox);
                _groupBoxList.Remove(groupBox);
                _actionList.Remove(actionReference);
                _nGroupbox -= 1; // makes it so that if you add a new action it will get ordered correctly

                // move down all groupboxes that are below this one
                List<GroupBox> groupboxes = GetAllGroupboxes();
                foreach (GroupBox groupbox in groupboxes)
                {
                    if (groupbox.Location.Y > groupBox.Location.Y)
                    {
                        groupbox.Location = new Point(groupbox.Location.X, groupbox.Location.Y - _verticalDistanceBetweenGroupboxes);
                    }
                }
            };
        }
        string CalculateEstimatedTime()
        {
            int oneLoopDuration = 0;
            foreach (Action action in _actionList)
            {
                oneLoopDuration += action.Delay;
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
        void LoadCoolSkin()
        {
            this.Opacity = 0.95;
            this.BackColor = Color.Black;
            this.BackgroundImage = Properties.Resources.autoclicker_skin;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            foreach (Control item in Controls)
            {
                item.BackColor = Color.Black;
                item.ForeColor = Color.Red;
                if (item is Button)
                {
                    ((Button)item).FlatStyle = FlatStyle.Flat;
                    ((Button)item).FlatAppearance.BorderColor = Color.Red;
                    ((Button)item).FlatAppearance.BorderSize = 1;
                }
            }
        }
        List<GroupBox> GetAllGroupboxes()
        {
            List<GroupBox> groupboxes = new List<GroupBox>();
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    groupboxes.Add((GroupBox)item);
                }
            }
            return groupboxes;
        }
        async void SaveToLocalSaveFile()
        {
            List<(Action a, VirtualKeyCode key, int delay, int x, int y)> formattedList = new List<(Action a, VirtualKeyCode key, int delay, int x, int y)>();
            for (int i = 0; i < _actionList.Count; i++)
            {
                formattedList.Add((_actionList[i], _actionList[i].Key, _actionList[i].Delay, _actionList[i].Point.X, _actionList[i].Point.Y));
            }
            await Data.Overwrite(formattedList);
        }

        // Events
        private void FRM_AutoClicker_Deactivate(object sender, EventArgs e)
        {
            if (_clicked)
            {
                SavePoint(_lbl_x_temp, _lbl_y_temp, _actionReference);
                _clicked = false;
            }
            void SavePoint(Label lbl_x, Label lbl_y, Action nAction)
            {
                int cursorX = Cursor.Position.X;
                int cursorY = Cursor.Position.Y;
                lbl_x.Text = "x: " + cursorX;
                lbl_y.Text = "y: " + cursorY;

                nAction.SetPoint(new Point(cursorX, cursorY));
            }
        }
        private void BTN_AddMouseAction_Click(object sender, EventArgs e)
        {
            CreateGroupBox_MouseAction();
        }
        private void BTN_AddButtonAction_Click(object sender, EventArgs e)
        {
            CreateGroupBox_KeyAction();
        }
        private void BTN_AddText_Click(object sender, EventArgs e)
        {
            CreateGroupBox_TextAction();
        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (NUD_Repetitions.Value == 0)
            {
                MessageBox.Show("Repetitions is 0");
            }
            int repetitions = Convert.ToInt32(NUD_Repetitions.Value);
            for (int i = 0; i < repetitions; i++)
            {
                for (int n = 0; n < _actionList.Count; n++)
                {
                    Thread.Sleep(_actionList[n].Delay);
                    if (_actionList[n] is KeyAction)
                    {
                        _inputSim.Keyboard.KeyPress(_actionList[n].Key);
                    }
                    else if (_actionList[n] is MouseAction)
                    {
                        Cursor.Position = _actionList[n].Point;
                        DoMouseClick();
                    }
                    else if (_actionList[n] is TextAction)
                    {
                        SendKeys.SendWait(_actionList[n].Text);
                    }
                }
            }
        }
        private void NUD_Repetitions_ValueChanged(object sender, EventArgs e)
        {
            LBL_EstimatedTime.Text = "Estimated time: " + CalculateEstimatedTime();
            if (NUD_Repetitions.Value == 69)
            {
                LoadCoolSkin();
            }
        }
        private void NUD_Repetitions_Leave(object sender, EventArgs e)
        {
            LBL_EstimatedTime.Text = "Estimated time: " + CalculateEstimatedTime();
        }
        async private void BTN_Save_Click(object sender, EventArgs e)
        {
            SaveToLocalSaveFile();
            MessageBox.Show("DATA SAVED");
        }
        private async void BTN_Save_As_Click(object sender, EventArgs e)
        {
            // first locally save to SaveFile.txt
            SaveToLocalSaveFile();

            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.Title = "Save an action chain";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                fs.Close();
            }
            // load data from savefile
            string[] data = Data.LoadDataAsStringArray(Data.DATA_FILE);
            // put data in newly named save
            File.WriteAllLines(saveFileDialog1.FileName, data);

        }
        private void BTN_Load_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            LoadData(filePath);

            void LoadData(string path)
            {
                List<(Action a, VirtualKeyCode k, int d, int x, int y)> data;
                data = Data.LoadAsTupleList(path);
                _actionList.Clear();
                foreach (var item in data)
                {
                    if (item.a is MouseAction)
                    {
                        CreateGroupBox_MouseAction(item.x, item.y, item.d);
                    }
                    else if (item.a is KeyAction)
                    {
                        CreateGroupBox_KeyAction(item.k, item.d);
                    }
                }
                MessageBox.Show("DATA LOADED");
            }
        }

        private void LBL_Repetitions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tf you clicking on some text 😭");
        }
        private void LBL_EstimatedTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tf you clicking on some text 😭");
        }


    }
}

/*
 * on action delete
 * check for every action
 * set btn name to current action
 */