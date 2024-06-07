using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using HidLibrary;
using Microsoft.VisualBasic.PowerPacks;

namespace USB3_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // khai báo biến quản lý các thiết bị USB 
        private ManagementEventWatcher usbWatcher;
        // khai báo đối tượng HidDevice 
        private HidDevice myUsbDevice;
        private int VendorId;
        private int ProductId;
        // khai báo các biến truyền nhận dữ liệu 
        double[] AIValue = new double[3];

        // send buffer
        private byte[] send_buffer = new byte[65];
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            // Thiết lập sự kiện theo dõi sự kiện USB
            usbWatcher = new ManagementEventWatcher();
            usbWatcher.EventArrived += UsbWatcher_EventArrived;
            usbWatcher.Query = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3");
            usbWatcher.Start();

            // Hiển thị danh sách thiết bị USB ban đầu
            RefreshDeviceList();
            // 
            led_1.BackStyle = BackStyle.Opaque;
            led_2.BackStyle = BackStyle.Opaque;
            led_3.BackStyle = BackStyle.Opaque;
            led_4.BackStyle = BackStyle.Opaque;
            // first duty
            send_buffer[5] = 50;
            // first freq
            send_buffer[6] = 100;
        }

        private void UsbWatcher_EventArrived(object sender, EventArrivedEventArgs e)
        {
            // Sự kiện thiết bị USB đã xảy ra (cắm vào hoặc rút ra)
            RefreshDeviceList();
        }

        private void RefreshDeviceList()
        {
            // Xóa danh sách thiết bị hiện tại
            comboBox1.Items.Clear();
            foreach (ManagementObject usbDevice in GetUsbDevices())
            {
                //string deviceId = usbDevice.GetPropertyValue("DeviceID").ToString();
                string description = usbDevice.GetPropertyValue("Description").ToString();
                string pnpDeviceID = usbDevice.GetPropertyValue("PNPDeviceID").ToString();
                if (pnpDeviceID.IndexOf("VID") != -1)
                {
                    string vid = pnpDeviceID.Split(new[] { "VID_" }, StringSplitOptions.None)[1].Split('&')[0];
                    string pid = pnpDeviceID.Split(new[] { "PID_" }, StringSplitOptions.None)[1].Split('\\')[0];

                    string deviceInfo = $"Description: {description} VID: 0x{vid} PID: 0x{pid} ";
                    comboBox1.Items.Add(deviceInfo);
                }
                else comboBox1.Items.Add(pnpDeviceID);
            }
        }

        private ManagementObjectCollection GetUsbDevices()
        {
            // tìm tất cả thiết bị usb hiện có 
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");
            return searcher.Get();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string vid = comboBox1.SelectedItem.ToString().Split(new[] { "VID: 0x" }, StringSplitOptions.None)[1].Split(' ')[0];
                string pid = comboBox1.SelectedItem.ToString().Split(new[] { "PID: 0x" }, StringSplitOptions.None)[1].Split(' ')[0];
                VendorId = int.Parse(vid, System.Globalization.NumberStyles.HexNumber);
                ProductId = int.Parse(pid, System.Globalization.NumberStyles.HexNumber);
                myUsbDevice = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();
                if (myUsbDevice != null)
                {
                    progressBar1.Value = 100;
                    myUsbDevice.OpenDevice();
                    myUsbDevice.MonitorDeviceEvents = true;
                    timer1.Enabled = true;
                    myUsbDevice.ReadReport(OnReport);
                }
                else
                {
                    MessageBox.Show("Could not find the HID device.", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // hàm  đọc và xử lý dữ liệu 
        private void OnReport(HidReport report)
        {
            if (report.Data.Length > 0)
            {
                // dữ liệu nhận được từ Arduino 100 bytes 
                byte[] data = report.Data;

                // chỉ lấy một số byte cần dùng đầu tiên 
                byte[] sub_data = new byte[10];
                Array.Copy(data, 0, sub_data, 0, 10);

                // hiển thị raw data 
                string receivedData = BitConverter.ToString(sub_data);//.Replace("-", "");
                textBox1.Invoke((MethodInvoker)(() => textBox1.Text = receivedData));

                // DI byte 0  đến byte 3
                if (sub_data[0] == 1) led_1.BackColor = Color.Red;
                else led_1.BackColor = Color.White;
                if (sub_data[1] == 1) led_2.BackColor = Color.Red;
                else led_2.BackColor = Color.White;
                if (sub_data[2] == 1) led_3.BackColor = Color.Red;
                else led_3.BackColor = Color.White;
                if (sub_data[3] == 1) led_4.BackColor = Color.Red;
                else led_4.BackColor = Color.White;

                // AI 
                int AI0IntValue;
                byte[] AI0ByteValue = new byte[4];

                AI0ByteValue[3] = sub_data[4];
                AI0ByteValue[2] = sub_data[5];
                AI0ByteValue[1] = sub_data[6];
                AI0ByteValue[0] = sub_data[7];

                AI0IntValue = BitConverter.ToInt32(AI0ByteValue, 0);

                AIValue[0] = (Convert.ToDouble(AI0IntValue) / 1023) * 5;

                /* DISPLAY */
                txtAI0.Text = AIValue[0].ToString("0.000000");
            }
            // Tiếp tục đọc report tiếp theo
            if (myUsbDevice != null)
            myUsbDevice.ReadReport(OnReport);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you want to exit ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Dừng sự kiện theo dõi khi đóng form
                usbWatcher.Stop();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ngắt kết nối với USb device
            try
            {
                DisconnectUSBDevice();
            }
            catch { }
        }

        private void DisconnectUSBDevice()
        {
            if (myUsbDevice != null && myUsbDevice.IsConnected)
            {
                myUsbDevice.CloseDevice();
                myUsbDevice.Dispose();
                myUsbDevice = null;
            }
        }
        // hàm gửi dữ liệu xuống arduino 
        void USBWrite(byte[] buffer)
        {
            if (myUsbDevice != null && myUsbDevice.IsConnected)
            {
                myUsbDevice.Write(buffer);
            }
            else
            {
                MessageBox.Show("HID device is not connected.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // stop write
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DO_0.Checked) send_buffer[1] = 1;
            else send_buffer[1] = 0;
            if (DO_1.Checked) send_buffer[2] = 1;
            else send_buffer[2] = 0;
            if (DO_2.Checked) send_buffer[3] = 1;
            else send_buffer[3] = 0;
            if (DO_3.Checked) send_buffer[4] = 1;
            else send_buffer[4] = 0;


            USBWrite(send_buffer);
            byte[] sub_send_buff = new byte[6];
            Array.Copy(send_buffer, 1, sub_send_buff, 0, 6);
            textBox8.Text = BitConverter.ToString(sub_send_buff);
        }

        private void txtDuty_TextChanged(object sender, EventArgs e)
        {
            if (txtDuty.Text =="")
            {
                send_buffer[5] = 0;
            }
            else
            {
                Int16 DutyTmp = Convert.ToInt16(txtDuty.Text);
                
                if (DutyTmp >= 0 && DutyTmp <= 100)
                {
                    send_buffer[5] = (byte)(DutyTmp);
                }
                else MessageBox.Show("PWM is out of range.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Freq_TextChanged(object sender, EventArgs e)
        {
            if (txt_Freq.Text == "")
            {
                MessageBox.Show("Hãy nhập giá trị từ 1 đến 255", 
                    "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Int16 FreqTmp = Convert.ToInt16(txt_Freq.Text);
                if (FreqTmp < 1 || FreqTmp > 255)
                {
                    MessageBox.Show("Ngoài tầm, hãy nhập giá trị từ 1 đến 255",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    send_buffer[6] = (byte)FreqTmp;
                }
            }
        }
    }
}
