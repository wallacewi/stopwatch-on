namespace StopwatchON
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPoints1 = new System.Windows.Forms.Label();
            this.lblPoints2 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Button();
            this.lblStop = new System.Windows.Forms.Button();
            this.lblReset = new System.Windows.Forms.Button();
            this.lblHR = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPoints1
            // 
            this.lblPoints1.AutoSize = true;
            this.lblPoints1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints1.Location = new System.Drawing.Point(105, 9);
            this.lblPoints1.Name = "lblPoints1";
            this.lblPoints1.Size = new System.Drawing.Size(50, 56);
            this.lblPoints1.TabIndex = 0;
            this.lblPoints1.Text = ":";
            // 
            // lblPoints2
            // 
            this.lblPoints2.AutoSize = true;
            this.lblPoints2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints2.Location = new System.Drawing.Point(195, 9);
            this.lblPoints2.Name = "lblPoints2";
            this.lblPoints2.Size = new System.Drawing.Size(50, 56);
            this.lblPoints2.TabIndex = 1;
            this.lblPoints2.Text = ":";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(45, 9);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(76, 56);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(135, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(76, 56);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(225, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(76, 56);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "00";
            // 
            // lblStart
            // 
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(28, 89);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(93, 40);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "START";
            this.lblStart.UseVisualStyleBackColor = true;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblStop
            // 
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(127, 89);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(93, 40);
            this.lblStop.TabIndex = 10;
            this.lblStop.Text = "STOP";
            this.lblStop.UseVisualStyleBackColor = true;
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(226, 89);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(93, 40);
            this.lblReset.TabIndex = 11;
            this.lblReset.Text = "RESET";
            this.lblReset.UseVisualStyleBackColor = true;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // lblHR
            // 
            this.lblHR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHR.Location = new System.Drawing.Point(22, 75);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(304, 2);
            this.lblHR.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Window
            // 
            this.AcceptButton = this.lblStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 143);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblPoints2);
            this.Controls.Add(this.lblPoints1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StopwatchON";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints1;
        private System.Windows.Forms.Label lblPoints2;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button lblStart;
        private System.Windows.Forms.Button lblStop;
        private System.Windows.Forms.Button lblReset;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Timer timer;
    }
}

