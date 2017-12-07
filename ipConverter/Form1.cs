using System;
using System.Net;
using System.Windows.Forms;

namespace ipConverter
{
    public partial class frmMain : Form
    {
        private Status _status { get; set; }

        //private string input;
        public frmMain()
        {
            InitializeComponent();
        }
     
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            _status = CheckStatus();
            string input = string.Empty;

            switch (_status)
            {
                case Status.IP:
                    StartIPConverter(textBoxIP.Text);
                    break;



                case Status.Hex:
                    StartHexConverter(textBoxHex.Text);
                    break;





                case Status.Number:
                    StartNumberConverter(textBoxNumber.Text);
                    break;
                default:
                    break;
            };
        }



        private Status CheckStatus()
        {
            if (textBoxIP.Enabled)
                return Status.IP;
            if (textBoxHex.Enabled)
                return Status.Hex;
            if (textBoxNumber.Enabled)
                return Status.Number;
            return Status.Hex;
        }



        private void StartHexConverter(string inputHex)
        {
            try
            {
                //Convert To IP
                textBoxIP.Text = CommonMethods.Hex2IP(inputHex);

                //Convert To Decimal Address
                if (!string.IsNullOrEmpty(textBoxIP.Text))
                    textBoxNumber.Text = CommonMethods.IP2Number(textBoxIP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void StartIPConverter(string inputIP)
        {
            try
            {
                var ip = IPAddress.Parse(inputIP);

                //Convert To Hex
                textBoxHex.Text = BitConverter.ToString(ip.GetAddressBytes()).Replace("-", "");

                //Convert To Decimal Address
                textBoxNumber.Text = CommonMethods.IP2Number(inputIP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void StartNumberConverter(string inputNumber)
        {
            try
            {
                //Convert To IP
                textBoxIP.Text = CommonMethods.Number2IP(inputNumber);

                //Convert To Hex

                if (!string.IsNullOrEmpty(textBoxIP.Text))
                    textBoxHex.Text = BitConverter.ToString(IPAddress.Parse(textBoxIP.Text).GetAddressBytes()).Replace("-", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }






        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            EnableButton(true, false, false);
        }

        private void radioButtonIP_CheckedChanged(object sender, EventArgs e)
        {
            EnableButton(false, true, false);
        }
        private void radioButtonDecimal_CheckedChanged(object sender, EventArgs e)
        {
            EnableButton(false, false, true);
        }
        private void EnableButton(bool hex, bool ip, bool num)
        {
            textBoxHex.Enabled = hex;
            textBoxIP.Enabled = ip;
            textBoxNumber.Enabled = num;
        }


        private enum Status
        {
            IP, Hex, Number
        }

      
    }
}
