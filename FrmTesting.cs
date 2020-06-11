using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWorkerTesting
{
    public partial class FrmTesting : Form
    {
        struct BkGdWkData
        {
            public int Process;
            public int Delay;
        }

        BackgroundWorker bkGdWk;

        BkGdWkData bkGdWkData;

        public FrmTesting()
        {
            InitializeComponent();
        }

        private void FrmTesting_Load(object sender, EventArgs e)
        {
            bkGdWk = new BackgroundWorker();
            bkGdWk.WorkerReportsProgress = true;
            bkGdWk.WorkerSupportsCancellation = true;
            bkGdWk.DoWork += BkGdWk_DoWork;
            bkGdWk.ProgressChanged += BkGdWk_ProgressChanged;
            bkGdWk.RunWorkerCompleted += BkGdWk_RunWorkerCompleted;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!bkGdWk.IsBusy)
            {
                bkGdWkData.Delay = 100;
                bkGdWkData.Process = 200;
                bkGdWk.RunWorkerAsync(bkGdWkData);
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (bkGdWk.IsBusy)
            {
                bkGdWk.CancelAsync();
            }
        }

        private void BkGdWk_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((BkGdWkData)e.Argument).Process;
            int delay = ((BkGdWkData)e.Argument).Delay;
            int index = 1;

            if (CbxAllowXthreadBW.Checked)
            {
                CheckForIllegalCrossThreadCalls = false;
            }
            else
            {
                CheckForIllegalCrossThreadCalls = true;
            }

            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!bkGdWk.CancellationPending)
                    {
                        bkGdWk.ReportProgress(index++ * 100 / process);
                        LbxOutput.Items.Add(i);
                        LbxOutput.TopIndex = LbxOutput.Items.Count - 1;
                        if (CbxDoEventsBW.Checked) Application.DoEvents();
                        Thread.Sleep(delay);
                    }
                }
            }
            catch (Exception ex)
            {

                bkGdWk.CancelAsync();
                MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BkGdWk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PgbWorker.Value = e.ProgressPercentage;
            LblProgress.Text = $"Processing ... {e.ProgressPercentage} %";
        }

        private void BkGdWk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process has been completed", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            if (CbxAllowXthread.Checked)
            {
                CheckForIllegalCrossThreadCalls = false;
            }
            else
            {
                CheckForIllegalCrossThreadCalls = true;
            }

            for (int i = 1; i < 202; i++)
            {
                PgbNoWorker.Value = (i / 2);
                LblProgress2.Text = $"Processing ... {i / 2}%";
                LbxOutput.Items.Add(i);
                LbxOutput.TopIndex = LbxOutput.Items.Count - 1;
                if (CbxDoEvents.Checked) Application.DoEvents();
                Thread.Sleep(200);
            }
        }

        private void BtnStop2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    class Tester
    {
        public static int count = 0;
        public int Index { get; set; }
        public string Name { get; set; }

        public Tester(int index, string name)
        {
            Index = index;
            Name = name;
            count += 1;
        }



    }



}

//Calling the DoEvents() method causes the current thread to be suspended while all waiting window messages are processed. If a message causes an event to be triggered, then other areas of your application code may execute.This can cause your application to exhibit unexpected behaviors that are difficult to debug. If you perform operations or computations that take a long time, it is often preferable to perform those operations on a new thread.
