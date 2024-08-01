using System.Resources;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TypingCom3
{
    partial class Form1
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            controls = new Panel();
            discord = new Button();
            accuracySlider_L = new Label();
            accuracySlider_V_L = new Label();
            typingRateSlider_L = new Label();
            typingRateSlider_V_L = new Label();
            accuracySlider = new TrackBar();
            accuracySlider_V = new TrackBar();
            typingRateSlider = new TrackBar();
            typingRateSlider_V = new TrackBar();
            startButton = new Button();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accuracySlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accuracySlider_V).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typingRateSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typingRateSlider_V).BeginInit();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AccessibleName = "webView";
            webView.AllowExternalDrop = true;
            webView.BackColor = Color.Black;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.Black;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 0);
            webView.Margin = new Padding(0);
            webView.Name = "webView";
            webView.Size = new Size(1100, 800);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // controls
            // 
            controls.BackColor = Color.FromArgb(46, 49, 65);
            controls.Controls.Add(discord);
            controls.Controls.Add(accuracySlider_L);
            controls.Controls.Add(accuracySlider_V_L);
            controls.Controls.Add(typingRateSlider_L);
            controls.Controls.Add(typingRateSlider_V_L);
            controls.Controls.Add(accuracySlider);
            controls.Controls.Add(accuracySlider_V);
            controls.Controls.Add(typingRateSlider);
            controls.Controls.Add(typingRateSlider_V);
            controls.Controls.Add(startButton);
            controls.Dock = DockStyle.Right;
            controls.Location = new Point(1100, 0);
            controls.Name = "controls";
            controls.Size = new Size(200, 800);
            controls.TabIndex = 1;
            // 
            // discord
            // 
            discord.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            discord.BackColor = Color.FromArgb(24, 85, 133);
            discord.Cursor = Cursors.Hand;
            discord.FlatAppearance.BorderColor = Color.FromArgb(24, 85, 133);
            discord.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 85, 133);
            discord.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 85, 133);
            discord.FlatStyle = FlatStyle.Flat;
            discord.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            discord.ForeColor = Color.White;
            discord.Location = new Point(5, 765);
            discord.Margin = new Padding(5);
            discord.Name = "discord";
            discord.Size = new Size(190, 30);
            discord.TabIndex = 0;
            discord.Text = "Join Discord";
            discord.UseVisualStyleBackColor = false;
            discord.Click += UI_Click_Discord;
            // 
            // accuracySlider_L
            // 
            accuracySlider_L.Font = new Font("Segoe UI", 10F);
            accuracySlider_L.ForeColor = Color.White;
            accuracySlider_L.Location = new Point(5, 130);
            accuracySlider_L.Name = "accuracySlider_L";
            accuracySlider_L.Size = new Size(190, 23);
            accuracySlider_L.TabIndex = 0;
            accuracySlider_L.Text = "Accuracy: 100%";
            accuracySlider_L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accuracySlider_V_L
            // 
            accuracySlider_V_L.Font = new Font("Segoe UI", 10F);
            accuracySlider_V_L.ForeColor = Color.White;
            accuracySlider_V_L.Location = new Point(5, 175);
            accuracySlider_V_L.Name = "accuracySlider_V_L";
            accuracySlider_V_L.Size = new Size(190, 23);
            accuracySlider_V_L.TabIndex = 6;
            accuracySlider_V_L.Text = "Accuracy Variance: ±0";
            accuracySlider_V_L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typingRateSlider_L
            // 
            typingRateSlider_L.Font = new Font("Segoe UI", 10F);
            typingRateSlider_L.ForeColor = Color.White;
            typingRateSlider_L.Location = new Point(5, 40);
            typingRateSlider_L.Name = "typingRateSlider_L";
            typingRateSlider_L.Size = new Size(190, 23);
            typingRateSlider_L.TabIndex = 0;
            typingRateSlider_L.Text = "Typing Rate: ~45";
            typingRateSlider_L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typingRateSlider_V_L
            // 
            typingRateSlider_V_L.Font = new Font("Segoe UI", 10F);
            typingRateSlider_V_L.ForeColor = Color.White;
            typingRateSlider_V_L.Location = new Point(5, 85);
            typingRateSlider_V_L.Name = "typingRateSlider_V_L";
            typingRateSlider_V_L.Size = new Size(190, 23);
            typingRateSlider_V_L.TabIndex = 2;
            typingRateSlider_V_L.Text = "Typing Rate Variance: ±0";
            typingRateSlider_V_L.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accuracySlider
            // 
            accuracySlider.BackColor = Color.FromArgb(46, 49, 65);
            accuracySlider.Cursor = Cursors.SizeWE;
            accuracySlider.Location = new Point(0, 153);
            accuracySlider.Margin = new Padding(0);
            accuracySlider.Maximum = 100;
            accuracySlider.Name = "accuracySlider";
            accuracySlider.Size = new Size(200, 45);
            accuracySlider.TabIndex = 4;
            accuracySlider.TickStyle = TickStyle.None;
            accuracySlider.Value = 100;
            accuracySlider.ValueChanged += UI_Slider_Accuracy;
            // 
            // accuracySlider_V
            // 
            accuracySlider_V.BackColor = Color.FromArgb(46, 49, 65);
            accuracySlider_V.Cursor = Cursors.SizeWE;
            accuracySlider_V.Location = new Point(0, 198);
            accuracySlider_V.Margin = new Padding(0);
            accuracySlider_V.Maximum = 15;
            accuracySlider_V.Name = "accuracySlider_V";
            accuracySlider_V.Size = new Size(200, 45);
            accuracySlider_V.TabIndex = 5;
            accuracySlider_V.TickStyle = TickStyle.None;
            accuracySlider_V.ValueChanged += UI_Slider_Accuracy_V;
            // 
            // typingRateSlider
            // 
            typingRateSlider.BackColor = Color.FromArgb(46, 49, 65);
            typingRateSlider.Cursor = Cursors.SizeWE;
            typingRateSlider.Location = new Point(0, 63);
            typingRateSlider.Margin = new Padding(0);
            typingRateSlider.Maximum = 350;
            typingRateSlider.Minimum = 10;
            typingRateSlider.Name = "typingRateSlider";
            typingRateSlider.Size = new Size(200, 45);
            typingRateSlider.TabIndex = 1;
            typingRateSlider.TickStyle = TickStyle.None;
            typingRateSlider.Value = 100;
            typingRateSlider.ValueChanged += UI_Slider_TypingRate;
            // 
            // typingRateSlider_V
            // 
            typingRateSlider_V.BackColor = Color.FromArgb(46, 49, 65);
            typingRateSlider_V.Cursor = Cursors.SizeWE;
            typingRateSlider_V.Location = new Point(0, 108);
            typingRateSlider_V.Margin = new Padding(0);
            typingRateSlider_V.Maximum = 15;
            typingRateSlider_V.Name = "typingRateSlider_V";
            typingRateSlider_V.Size = new Size(200, 45);
            typingRateSlider_V.TabIndex = 3;
            typingRateSlider_V.TickStyle = TickStyle.None;
            typingRateSlider_V.ValueChanged += UI_Slider_TypingRate_V;
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(24, 85, 133);
            startButton.Cursor = Cursors.Hand;
            startButton.FlatAppearance.BorderColor = Color.FromArgb(24, 85, 133);
            startButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 85, 133);
            startButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 85, 133);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(5, 5);
            startButton.Margin = new Padding(5);
            startButton.Name = "startButton";
            startButton.Size = new Size(190, 30);
            startButton.TabIndex = 0;
            startButton.Text = "Start Cheat";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += UI_Click_Start;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 800);
            Controls.Add(webView);
            Controls.Add(controls);
            ForeColor = SystemColors.ControlText;
            MinimumSize = new Size(1300, 800);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            controls.ResumeLayout(false);
            controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accuracySlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)accuracySlider_V).EndInit();
            ((System.ComponentModel.ISupportInitialize)typingRateSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)typingRateSlider_V).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel controls;
        private Button startButton;
        private Button discord;
        private TrackBar typingRateSlider;
        private Label typingRateSlider_L;
        private TrackBar typingRateSlider_V;
        private Label typingRateSlider_V_L;
        private TrackBar accuracySlider;
        private Label accuracySlider_L;
        private TrackBar accuracySlider_V;
        private Label accuracySlider_V_L;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
