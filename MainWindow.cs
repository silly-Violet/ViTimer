using System.Diagnostics;

namespace ViTimer
{
    public partial class MainWindow : Form
    {
        Stopwatch stopwatch = new();

        public MainWindow()
        {
            InitializeComponent();

            Task.Run(() => { BackgroundTask(); });
        }

        private void UpdateTimer()
        {
            var elapsedTime = stopwatch.Elapsed;

            timerLabel.Text = stopwatch.Elapsed.ToString().Substring(0, 8);
        }

        private void BackgroundTask()
        {
            while (true)
            {
                if (!IsHandleCreated) continue;
                try
                {
                    Invoke(UpdateTimer);
                    Thread.Sleep(100);
                }
                catch (ObjectDisposedException) { return; }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
    }
}
