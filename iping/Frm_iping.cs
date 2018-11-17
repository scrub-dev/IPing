using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Timers;

namespace iping
{
    public partial class Frm_iping : Form
    {
        List<decimal> DelayList = new List<decimal>();
        int NumberOfAttempts;
        int SuccessfulAttempts; 
        System.Timers.Timer Timer;

        public Frm_iping()
        {
            InitializeComponent();
        }

        private void SetTimer(int triggertime) {
            Timer = new System.Timers.Timer(triggertime); // Sets a new timer with the set Trigger time
            Timer.Elapsed += OnTimedEvent; // Add the OnTimedEvent to when the timer has elaped the trigger time
            Timer.Enabled = true; // Enable the timer on click
            Timer.AutoReset = true; // Reset the timer automatically
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            CheckPing(Txt_Host.Text, Convert.ToInt16(Txt_Timeout.Text)); // Timed event for the Timer Contol
        }

        public decimal ListSum(List<decimal> list) // Sums all Decimal values in a list
        {
            decimal sum = 0;
            for(int i  = 0; i < list.Count; i++)
            {
                sum += DelayList[i];
            }
            return sum;
        }
        public decimal ListAverage(List<decimal> list) // Averages Decimal Values in a list
        {
            decimal sum = ListSum(list);
            decimal Average = (decimal)sum / list.Count;
            return Average;
        }
        public double PercentageCalculator(int current, int total) // Calculates the percentage based on two numbers
        {
            double sum;
            if (current == 0) return 0;
            else sum = (current / total) * 100;
            return sum;
        }

        //Thread Safe Operations for setting the Outputs on the UI from the Timer Functions and anything else I add in the future
        delegate void SetTextCallback(string text);
        private void OutputText(string text)
        {
            if (this.Rtb_Output.InvokeRequired)
            {
                SetTextCallback a = new SetTextCallback(OutputText);
                this.Invoke(a, new Object[] { text });
            }
            else
            {
                this.Rtb_Output.AppendText(text);
            }
        }
        private void AverageOutput(string text)
        {
            if (this.Txt_AverageTime.InvokeRequired)
            {
                SetTextCallback b = new SetTextCallback(AverageOutput);
                this.Invoke(b, new Object[] { text });
            }
            else
            {
                this.Txt_AverageTime.Text = text;
            }
        }
        private void SuccessOutput(string text)
        {
            if (this.Txt_SuccessRate.InvokeRequired)
            {
                SetTextCallback c = new SetTextCallback(SuccessOutput);
                this.Invoke(c, new Object[] { text });
            }
            else
            {
                this.Txt_SuccessRate.Text = text;
            }
        }
        // Main Function that does the pining and error protection and detection
        public void CheckPing(string host, int timeout) {
            try
            {
                Ping Ping = new Ping(); // Declares the Ping
                PingReply PingReply; // Declares the ping reply
                PingReply = Ping.Send(host, timeout); // Sets the ping with the host and the timeout

                if (PingReply.Status == IPStatus.Success) // Checks to makes sure the Ping was a success before posting the information to output box
                {
                    DelayList.Add((int)PingReply.RoundtripTime); // Add the Ping time to the Ping Delay List
                    ++NumberOfAttempts; // Increase Number of attempts
                    ++SuccessfulAttempts; // Increase Successful attempts
                    String DebugText = ""; // Declares the extra debug text
                    if (Chk_Debug.Checked) DebugText = PercentageCalculator(SuccessfulAttempts, NumberOfAttempts).ToString("###.##") + "% | Delay Avg:" + ListAverage(DelayList).ToString("##.##"); // Give more info if the debug box is chekced
                    OutputText("Ping to " + host + " Successful | Delay = " + PingReply.RoundtripTime + " ms | TTL = " + PingReply.Options.Ttl + " | " + DebugText + "\n"); // Main Ping output
                    AverageOutput(ListAverage(DelayList).ToString("###.##") + " ms"); // Average the List of Delays to an output
                }
                else
                {
                    ++NumberOfAttempts; // Increase the number of attempts
                    OutputText("Ping to " + host + " Unsuccessful | Timeout Reached"); // If its unabled to ping, send this Error
                }
                SuccessOutput(PercentageCalculator(SuccessfulAttempts, NumberOfAttempts).ToString("###.##") + "%"); // Sets the Success percentage to the Percentage Text Box

            } catch(Exception Ex)
            {
                OutputText("Error : " + Ex.Message + "\n"); // Error information sent to Output Text Box
                if (Chk_Debug.Checked) OutputText("Debug : " + Ex.StackTrace +"\n"); // When debug is enabled it gives more Error Information
            }
        }

        private void Rtb_Output_TextChanged(object sender, EventArgs e)
        {
            Rtb_Output.ScrollToCaret(); // When Output updates it keeps it scrolled down to the bottom
        }

        private void Btn_Ping_Click(object sender, EventArgs e)
        {
            CheckPing(Txt_Host.Text, Convert.ToInt16(Txt_Timeout.Text));
            if (DelayList.Count == 11) DelayList.RemoveAt(0); // Keeps the list at 10 Length
        }

        private void Btn_ClearOutput_Click(object sender, EventArgs e)
        {
            Rtb_Output.Text = ""; // Clears all Text from the output
        }

        private void Btn_StartLoop_Click(object sender, EventArgs e)
        {
            SetTimer(Convert.ToInt16(Txt_TriggerTime.Text)); // Sets the Timer to start the auto mode
        }

        private void Btn_StopLoop_Click(object sender, EventArgs e)
        {
            Timer.Stop(); //Stops the timer
            Timer.Dispose(); // Releases the timers resources
        }
    }
}
