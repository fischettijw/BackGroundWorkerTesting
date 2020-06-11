﻿namespace BackGroundWorkerTesting
{
    partial class FrmTesting
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
            this.LbxOutput = new System.Windows.Forms.ListBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.PgbWorker = new System.Windows.Forms.ProgressBar();
            this.LblProgress = new System.Windows.Forms.Label();
            this.LblProgress2 = new System.Windows.Forms.Label();
            this.PgbNoWorker = new System.Windows.Forms.ProgressBar();
            this.BtnStop2 = new System.Windows.Forms.Button();
            this.BtnStart2 = new System.Windows.Forms.Button();
            this.CbxDoEvents = new System.Windows.Forms.CheckBox();
            this.CbxAllowXthread = new System.Windows.Forms.CheckBox();
            this.CbxAllowXthreadBW = new System.Windows.Forms.CheckBox();
            this.CbxDoEventsBW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LbxOutput
            // 
            this.LbxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbxOutput.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxOutput.FormattingEnabled = true;
            this.LbxOutput.ItemHeight = 21;
            this.LbxOutput.Location = new System.Drawing.Point(0, 0);
            this.LbxOutput.Name = "LbxOutput";
            this.LbxOutput.Size = new System.Drawing.Size(642, 193);
            this.LbxOutput.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(12, 367);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(115, 34);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(515, 367);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(115, 34);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // PgbWorker
            // 
            this.PgbWorker.Location = new System.Drawing.Point(163, 367);
            this.PgbWorker.Name = "PgbWorker";
            this.PgbWorker.Size = new System.Drawing.Size(312, 33);
            this.PgbWorker.TabIndex = 6;
            // 
            // LblProgress
            // 
            this.LblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgress.Location = new System.Drawing.Point(163, 407);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(311, 24);
            this.LblProgress.TabIndex = 7;
            this.LblProgress.Text = "Processing ... 0%";
            this.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblProgress2
            // 
            this.LblProgress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgress2.Location = new System.Drawing.Point(163, 296);
            this.LblProgress2.Name = "LblProgress2";
            this.LblProgress2.Size = new System.Drawing.Size(311, 24);
            this.LblProgress2.TabIndex = 11;
            this.LblProgress2.Text = "Processing ... 0%";
            this.LblProgress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PgbNoWorker
            // 
            this.PgbNoWorker.Location = new System.Drawing.Point(163, 256);
            this.PgbNoWorker.Name = "PgbNoWorker";
            this.PgbNoWorker.Size = new System.Drawing.Size(312, 33);
            this.PgbNoWorker.TabIndex = 10;
            // 
            // BtnStop2
            // 
            this.BtnStop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop2.Location = new System.Drawing.Point(515, 256);
            this.BtnStop2.Name = "BtnStop2";
            this.BtnStop2.Size = new System.Drawing.Size(115, 34);
            this.BtnStop2.TabIndex = 9;
            this.BtnStop2.Text = "Stop";
            this.BtnStop2.UseVisualStyleBackColor = true;
            this.BtnStop2.Click += new System.EventHandler(this.BtnStop2_Click);
            // 
            // BtnStart2
            // 
            this.BtnStart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart2.Location = new System.Drawing.Point(12, 256);
            this.BtnStart2.Name = "BtnStart2";
            this.BtnStart2.Size = new System.Drawing.Size(115, 34);
            this.BtnStart2.TabIndex = 8;
            this.BtnStart2.Text = "Start";
            this.BtnStart2.UseVisualStyleBackColor = true;
            this.BtnStart2.Click += new System.EventHandler(this.BtnStart2_Click);
            // 
            // CbxDoEvents
            // 
            this.CbxDoEvents.AutoSize = true;
            this.CbxDoEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDoEvents.Location = new System.Drawing.Point(12, 307);
            this.CbxDoEvents.Name = "CbxDoEvents";
            this.CbxDoEvents.Size = new System.Drawing.Size(122, 28);
            this.CbxDoEvents.TabIndex = 12;
            this.CbxDoEvents.Text = "DoEvents()";
            this.CbxDoEvents.UseVisualStyleBackColor = true;
            // 
            // CbxAllowXthread
            // 
            this.CbxAllowXthread.AutoSize = true;
            this.CbxAllowXthread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAllowXthread.Location = new System.Drawing.Point(469, 307);
            this.CbxAllowXthread.Name = "CbxAllowXthread";
            this.CbxAllowXthread.Size = new System.Drawing.Size(161, 28);
            this.CbxAllowXthread.TabIndex = 13;
            this.CbxAllowXthread.Text = "Allow X-Thread";
            this.CbxAllowXthread.UseVisualStyleBackColor = true;
            // 
            // CbxAllowXthreadBW
            // 
            this.CbxAllowXthreadBW.AutoSize = true;
            this.CbxAllowXthreadBW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAllowXthreadBW.Location = new System.Drawing.Point(469, 413);
            this.CbxAllowXthreadBW.Name = "CbxAllowXthreadBW";
            this.CbxAllowXthreadBW.Size = new System.Drawing.Size(161, 28);
            this.CbxAllowXthreadBW.TabIndex = 15;
            this.CbxAllowXthreadBW.Text = "Allow X-Thread";
            this.CbxAllowXthreadBW.UseVisualStyleBackColor = true;
            // 
            // CbxDoEventsBW
            // 
            this.CbxDoEventsBW.AutoSize = true;
            this.CbxDoEventsBW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxDoEventsBW.Location = new System.Drawing.Point(12, 413);
            this.CbxDoEventsBW.Name = "CbxDoEventsBW";
            this.CbxDoEventsBW.Size = new System.Drawing.Size(122, 28);
            this.CbxDoEventsBW.TabIndex = 14;
            this.CbxDoEventsBW.Text = "DoEvents()";
            this.CbxDoEventsBW.UseVisualStyleBackColor = true;
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.CbxAllowXthreadBW);
            this.Controls.Add(this.CbxDoEventsBW);
            this.Controls.Add(this.CbxAllowXthread);
            this.Controls.Add(this.CbxDoEvents);
            this.Controls.Add(this.LblProgress2);
            this.Controls.Add(this.PgbNoWorker);
            this.Controls.Add(this.BtnStop2);
            this.Controls.Add(this.BtnStart2);
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.PgbWorker);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LbxOutput);
            this.Name = "FrmTesting";
            this.Text = "Listbox Output";
            this.Load += new System.EventHandler(this.FrmTesting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbxOutput;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ProgressBar PgbWorker;
        private System.Windows.Forms.Label LblProgress;
        private System.Windows.Forms.Label LblProgress2;
        private System.Windows.Forms.ProgressBar PgbNoWorker;
        private System.Windows.Forms.Button BtnStop2;
        private System.Windows.Forms.Button BtnStart2;
        private System.Windows.Forms.CheckBox CbxDoEvents;
        private System.Windows.Forms.CheckBox CbxAllowXthread;
        private System.Windows.Forms.CheckBox CbxAllowXthreadBW;
        private System.Windows.Forms.CheckBox CbxDoEventsBW;
    }
}

