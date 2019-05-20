using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        BackgroundWorker worker = new BackgroundWorker();
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int key);
        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
            this.Left = 0;
            this.Top = 0;
        }


        private void Colorize(string name, bool durum)
        {
            Grid_Main.Dispatcher.Invoke(() =>
            {
                foreach (Grid item in Grid_Main.Children)
                {
                    if (item.Name == name)
                    {
                        if (durum == true)
                            item.Background = Brushes.Orange;
                        else
                            item.Background = Brushes.Transparent;
                    }
                }
            });
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                // 1
                int state = Convert.ToInt32(GetAsyncKeyState(49).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_1", false);
                        break;
                    case 1:
                        Colorize("Grid_1", false);
                        break;
                    case -32767:
                        Colorize("Grid_1", true);
                        break;
                }

                // 2
                state = Convert.ToInt32(GetAsyncKeyState(50).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_2", false);
                        break;
                    case 1:
                        Colorize("Grid_2", false);
                        break;
                    case -32767:
                        Colorize("Grid_2", true);
                        break;
                }

                // 3
                state = Convert.ToInt32(GetAsyncKeyState(51).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_3", false);
                        break;
                    case 1:
                        Colorize("Grid_3", false);
                        break;
                    case -32767:
                        Colorize("Grid_3", true);
                        break;
                }

                // 4
                state = Convert.ToInt32(GetAsyncKeyState(52).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_4", false);
                        break;
                    case 1:
                        Colorize("Grid_4", false);
                        break;
                    case -32767:
                        Colorize("Grid_4", true);
                        break;
                }

                // Q
                state = Convert.ToInt32(GetAsyncKeyState(81).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_Q", false);
                        break;
                    case 1:
                        Colorize("Grid_Q", false);
                        break;
                    case -32767:
                        Colorize("Grid_Q", true);
                        break;
                }

                // W
                state = Convert.ToInt32(GetAsyncKeyState(87).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_W", false);
                        break;
                    case 1:
                        Colorize("Grid_W", false);
                        break;
                    case -32767:
                        Colorize("Grid_W", true);
                        break;
                }

                // E
                state = Convert.ToInt32(GetAsyncKeyState(69).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_E", false);
                        break;
                    case 1:
                        Colorize("Grid_E", false);
                        break;
                    case -32767:
                        Colorize("Grid_E", true);
                        break;
                }

                // R
                state = Convert.ToInt32(GetAsyncKeyState(82).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_R", false);
                        break;
                    case 1:
                        Colorize("Grid_R", false);
                        break;
                    case -32767:
                        Colorize("Grid_R", true);
                        break;
                }


                // A
                state = Convert.ToInt32(GetAsyncKeyState(65).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_A", false);
                        break;
                    case 1:
                        Colorize("Grid_A", false);
                        break;
                    case -32767:
                        Colorize("Grid_A" +
                            "", true);
                        break;
                }

                // S
                state = Convert.ToInt32(GetAsyncKeyState(83).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_S", false);
                        break;
                    case 1:
                        Colorize("Grid_S", false);
                        break;
                    case -32767:
                        Colorize("Grid_S", true);
                        break;
                }

                // D
                state = Convert.ToInt32(GetAsyncKeyState(68).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_D", false);
                        break;
                    case 1:
                        Colorize("Grid_D", false);
                        break;
                    case -32767:
                        Colorize("Grid_D", true);
                        break;
                }

                // F
                state = Convert.ToInt32(GetAsyncKeyState(70).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_F", false);
                        break;
                    case 1:
                        Colorize("Grid_F", false);
                        break;
                    case -32767:
                        Colorize("Grid_F", true);
                        break;
                }

                // SPACE
                state = Convert.ToInt32(GetAsyncKeyState(32).ToString());
                switch (state)
                {
                    case 0:
                        Colorize("Grid_Space", false);
                        break;
                    case 1:
                        Colorize("Grid_Space", false);
                        break;
                    case -32767:
                        Colorize("Grid_Space", true);
                        break;
                }



            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F4)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
