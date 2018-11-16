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

namespace iping
{
    public partial class Frm_iping : Form
    {
        List<decimal> DelayList = new List<decimal>();
        int NumberOfAttempts;
        int SuccessfulAttempts;
        public Frm_iping()
        {
            InitializeComponent();
        }

        public decimal ListSum(List<decimal> list)
        {
            decimal sum = 0;
            for(int i  = 0; i < list.Count; i++)
            {
                sum += DelayList[i];
            }
            return sum;
        }
        public decimal ListAverage(List<decimal> list)
        {
            decimal sum = ListSum(list);
            decimal Average = (decimal)sum / list.Count;
            return Average;
        }
        public double PercentageCalculator(int current, int total)
        {
            double sum;
            if (current == 0) return 0;
            else sum = (current / total) * 100;
            return sum;
        }
        public void CheckPing(string host, int timeout) {
            Ping Ping = new Ping();
            PingReply PingReply;
            PingReply = Ping.Send(host, timeout);

            if(PingReply.Status == IPStatus.Success)
            {
                DelayList.Add((int)PingReply.RoundtripTime);
                ++NumberOfAttempts;
                ++SuccessfulAttempts;
                Rtb_Output.AppendText("Ping to " + host + " Successful | Delay = " + PingReply.RoundtripTime +" ms | TTL = "+ PingReply.Options.Ttl +"\n");
                Txt_AverageTime.Text = ListAverage(DelayList).ToString("#.##")+" ms";
            }
            else
            {
                ++NumberOfAttempts;
                Rtb_Output.AppendText("Ping to " + host + " Unsuccessful | Timeout Reached");
            }
            Txt_SuccessRate.Text = PercentageCalculator(SuccessfulAttempts, NumberOfAttempts).ToString("#.#") + "%";

        }

        private void Rtb_Output_TextChanged(object sender, EventArgs e)
        {
            Rtb_Output.ScrollToCaret();
            
        }

        private void Btn_Ping_Click(object sender, EventArgs e)
        {
            CheckPing(Txt_Host.Text, Convert.ToInt16(Txt_Timeout.Text));
            if (DelayList.Count == 11) DelayList.RemoveAt(0);
        }

        private void Btn_ClearOutput_Click(object sender, EventArgs e)
        {
            Rtb_Output.Text = "";
        }
    }
}
