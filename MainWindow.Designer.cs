namespace ViTimer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            timerLabel = new Label();
            resetButton = new Button();
            startButton = new Button();
            pauseButton = new Button();
            SuspendLayout();
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Monofonto", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = SystemColors.ScrollBar;
            timerLabel.Location = new Point(12, 9);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(244, 65);
            timerLabel.TabIndex = 0;
            timerLabel.Text = "00:00:00";
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.FromArgb(51, 51, 51);
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(118, 78);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(60, 30);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ResetButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(51, 51, 51);
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(12, 78);
            startButton.Name = "startButton";
            startButton.Size = new Size(40, 30);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.FromArgb(51, 51, 51);
            pauseButton.FlatStyle = FlatStyle.Popup;
            pauseButton.ForeColor = Color.White;
            pauseButton.Location = new Point(58, 78);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(54, 30);
            pauseButton.TabIndex = 5;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += PauseButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(268, 120);
            Controls.Add(pauseButton);
            Controls.Add(startButton);
            Controls.Add(resetButton);
            Controls.Add(timerLabel);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Vi Timer";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label timerLabel;
        private Button resetButton;
        private Button startButton;
        private Button pauseButton;
    }
}
