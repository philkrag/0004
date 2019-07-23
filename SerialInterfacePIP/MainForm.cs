using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using SerialInterfacePIP;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        //static SerialPort _serialPort;

        string Connection_Status = "Disconnected";



        string[] Baud_Rates = new string[] { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000" };
        string[] Data_Bits = new string[] { "5", "6", "7", "8", "9" };
        string[] Discard_Null = new string[] { "True", "False" };
        string[] DTR_Enable = new string[] { "True", "False" };
        string[] Handshake = new string[] { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOFf" };
        string[] Parity = new string[] { "None", "Odd", "Even", "Mark", "Space" };
        string[] Port_Name = null;
        string[] RTS_Enable = new string[] { "True", "False" };
        string[] Stop_Bits = new string[] { "One", "Two", "OnePointFive" };
        


        string[] Port_Names;
        string Data_Buffer = null; // receive serial data



        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
            Refresh_Connection_Properties();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh_Connection_Properties();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Send_Data(textBox2.Text);
        }
        
        private void Status_Timer_Tick(object sender, EventArgs e)
        {
            Update_GUI();
        }


        private void arduinoFreetronicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox_BaudRate.Text = "9600";
            ComboBox_DataBits.Text = "8";
            ComboBox_DiscardNull.Text = "False";
            ComboBox_DTREnable.Text = "False";
            ComboBox_Handshake.Text = "None";
            ComboBox_Parity.Text = "None";
            ComboBox_RTSEnable.Text = "False";
            ComboBox_StopBits.Text = "One";
        }

        private void refreshConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh_Connection_Properties();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutForm = new AboutBox();
            AboutForm.Show();
        }






        public void Refresh_Connection_Properties()
        {

            ComboBox_BaudRate.Items.Clear();
            ComboBox_BaudRate.Items.AddRange(Baud_Rates);

            ComboBox_DataBits.Items.Clear();
            ComboBox_DataBits.Items.AddRange(Data_Bits);

            ComboBox_DiscardNull.Items.Clear();
            ComboBox_DiscardNull.Items.AddRange(Discard_Null);

            ComboBox_DTREnable.Items.Clear();
            ComboBox_DTREnable.Items.AddRange(DTR_Enable);
            
            ComboBox_Handshake.Items.Clear();
            ComboBox_Handshake.Items.AddRange(Handshake);

            ComboBox_Parity.Items.Clear();
            ComboBox_Parity.Items.AddRange(Parity);

            ComboBox_PortName.Items.Clear();
            Port_Names = System.IO.Ports.SerialPort.GetPortNames();
            ComboBox_PortName.Items.AddRange(Port_Names);

            ComboBox_RTSEnable.Items.Clear();
            ComboBox_RTSEnable.Items.AddRange(RTS_Enable);

            ComboBox_StopBits.Items.Clear();
            ComboBox_StopBits.Items.AddRange(Stop_Bits);
        }


        public void Update_GUI()
        {
            switch (Connection_Status)
            {
                case "Disconnected":
                    Status_Indicator.BackColor = Color.Yellow;
                    break;

                case "Connecting":
                    Status_Indicator.BackColor = Color.Orange;
                    if (Serial_Port.IsOpen) { Connection_Status = "Connected"; }
                    break;
                case "Connected":
                    Status_Indicator.BackColor = Color.Green;
                    break;
                case "Error":
                    Status_Indicator.BackColor = Color.Red;
                    break;
            }
        }



        public void Connection()
        {
            switch (Connection_Status)
            {
                case "Disconnected":
                    Connection_Status = "Connecting";
                    Open_Connection();
                    break;

                case "Connecting":
                    Connection_Status = "Disconnected";
                    break;

                case "Connected":
                    Connection_Status = "Disconnected";
                    Close_Connection();
                    break;


                case "Error":
                    Connection_Status = "Connecting";
                    //Open_Connection();
                    break;


            }
        }



        public void Open_Connection()
        {
            try
            {
                Serial_Port.BaudRate = Convert.ToInt32(ComboBox_BaudRate.Text);
                Serial_Port.DataBits = Convert.ToInt32(ComboBox_DataBits.Text);
                Serial_Port.DiscardNull = Convert.ToBoolean(ComboBox_DiscardNull.Text);
                Serial_Port.DtrEnable = Convert.ToBoolean(ComboBox_DTREnable.Text);
                Serial_Port.Handshake = (Handshake)Enum.Parse(typeof(Handshake), ComboBox_Handshake.Text, true);
                Serial_Port.Parity = (Parity)Enum.Parse(typeof(Parity), ComboBox_Parity.Text.ToString(), true);
                Serial_Port.PortName = ComboBox_PortName.Text.ToString();
                Serial_Port.RtsEnable = Convert.ToBoolean(ComboBox_RTSEnable.Text);
                Serial_Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ComboBox_StopBits.Text, true);
                Serial_Port.Open();
            }
            catch
            {
                Connection_Status = "Error";
                MessageBox.Show("A error has occurred with the connection.",
                "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

        }


        public void Close_Connection()
        {
            Serial_Port.Close();

        }


        public void Send_Data(string String_To_Send)
        {
            byte[] Message = System.Text.Encoding.UTF8.GetBytes(String_To_Send+ Environment.NewLine);
            Serial_Port.Write(Message, 0, Message.Length);

        }












        

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            Serial_Port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


            





        }



        
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Data_Buffer = Data_Buffer + Serial_Port.ReadExisting();                
                Console.WriteLine("Data Received:");
                Console.Write(Data_Buffer);
                GlobVar.Message_Received = GlobVar.Message_Received + Data_Buffer;
                GlobVar.Message_Received_Flag = true;
            Data_Buffer = null;
        }











        private void Message_Recieved_Timer_Tick(object sender, EventArgs e)
        {

            if (GlobVar.Message_Received_Flag == true)
            {
                textBox3.Text = GlobVar.Message_Received + textBox3.Text;                
                GlobVar.Message_Received = null;
                GlobVar.Message_Received_Flag = false;
            }


        }

        
    }
}
