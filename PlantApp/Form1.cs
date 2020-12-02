
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.NetworkInformation;
using NativeWifi;
using System.Collections.ObjectModel;

delegate void AddMessage(string sNewMessage);

namespace PlantApp
{
    /*sA GITOM*/
    public partial class FormMain : Form
    {
        public const int PORT = 8888;
        public const string LED_ON= "L_ON";
        public const string LED_OFF = "L_OFF";
        public int a = 0;
        private Socket m_sock;                      // Server connection
        private byte[] m_byBuff = new byte[256];    // Recieved data buffer
        private event AddMessage m_AddMessage;				// Add Message Event handler for Form
        Thread myUpdateThread;
        public delegate void delUpdateUITextBox(bool stat);
        delUpdateUITextBox DelUpdateUITextBox;
        public delegate void delUpdateLight(bool stat);
        delUpdateLight DelUpdateLight;
        ThreadStart threadStart;
        bool status_flag = false;
        bool stat_light = false;
        public FormMain()
        {
            InitializeComponent();
            m_AddMessage = new AddMessage(OnAddMessage);

              WlanClient client = new WlanClient();
              foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
              {
               
                  // Lists all available networks
                  Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                
                  foreach (Wlan.WlanAvailableNetwork network in networks)
                  {
                      Console.WriteLine("Found network with SSID {0}.", GetStringForSSID(network.dot11Ssid));
                    string ssid = GetStringForSSID(network.dot11Ssid);
                     
                    if (ssid.Contains("ESP"))
                        {
                      
                         }
                  }
                foreach (Wlan.WlanProfileInfo profileInfo in wlanIface.GetProfiles())
                {
                    if (profileInfo.profileName.Equals("ESPap"))
                    {
                        string name = profileInfo.profileName; // this is typically the network's SSID
                        string xml = wlanIface.GetProfileXml(profileInfo.profileName);
                    }
                }
                // Connects to a known network with WEP security
                string profileName = "ESPap"; // this is also the SSID
                string mac = "52544131303235572D454137443638";
                string key = "kristofer";
                string profileXml = string.Format("<?xml version=\"1.0\"?><WLANProfile xmlns=\"http://www.microsoft.com/networking/WLAN/profile/v1\"><name>{0}</name><SSIDConfig><SSID><hex>{1}</hex><name>{0}</name></SSID></SSIDConfig><connectionType>ESS</connectionType><MSM><security><authEncryption><authentication>open</authentication><encryption>WEP</encryption><useOneX>false</useOneX></authEncryption><sharedKey><keyType>networkKey</keyType><protected>false</protected><keyMaterial>{2}</keyMaterial></sharedKey><keyIndex>0</keyIndex></security></MSM></WLANProfile>", profileName, mac, key);
                wlanIface.Connect(Wlan.WlanConnectionMode.Profile, Wlan.Dot11BssType.Any, profileName);
                string hostName = Dns.GetHostName();
                Console.WriteLine("Host Name = " + hostName);
                IPHostEntry local = Dns.GetHostByName(hostName);
                foreach (IPAddress ipaddress in local.AddressList)
                {
                    Console.WriteLine("IPAddress = " + ipaddress.ToString());
                }
            }
           






        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_led_on_Click(object sender, EventArgs e)
        {
            status_light.BackColor = System.Drawing.Color.Green;
            status_light.Text = "ON";
            Send_data( convert_to_bytes(LED_ON));
           
        }

        private void btn_led_off_Click(object sender, EventArgs e)
        {
            status_light.BackColor = System.Drawing.Color.Red;
            status_light.Text = "OFF";
            Send_data(convert_to_bytes(LED_OFF));
        }

        private void timer_DateTime_Tick(object sender, EventArgs e)
        {
            txt_DateTime.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threadStart = new ThreadStart(GetTheThreadStarted);
            myUpdateThread = new Thread(threadStart);
            myUpdateThread.Start();
           
        }
        private void GetTheThreadStarted()
        {
            delUpdateUITextBox DelUpdateUITextBox = new delUpdateUITextBox(UpdateUITextBox);
                this.status_wifi.BeginInvoke(DelUpdateUITextBox, status_flag);
                    
        }
        private void ThreadLight()
        {
            delUpdateLight DelUpdateLight = new delUpdateLight(UpdateLight);
            this.status_light.BeginInvoke(DelUpdateLight, status_flag);

        }
        public void UpdateLight(bool status)
        {
            
            if (stat_light)
            {
                status_light.Text = "ON";
                status_light.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                status_light.Text = "OFF";
                status_light.BackColor = System.Drawing.Color.Red;
            }
        }
        public void UpdateUITextBox(bool status)
        {
            if (status)
            {
                status_wifi.Text = "Connected";
                status_wifi.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                status_wifi.Text = "Disconnected";
                status_wifi.BackColor = System.Drawing.Color.Red;
            }

        }
        private void calenda_rtc_offset_Validated(object sender, EventArgs e)
        {
            lbl_nxt_wakeup.Text = calendar_rtc.Text;
            lbl_nxtwakeup2.Text = calenda_rtc_offset.Text;
        }



        private void calenda_rtc_offset_KeyPress(object sender, KeyPressEventArgs e)
        {
            int min, hour, second, year, day, month;
            DateTimePicker dt1 = calendar_rtc;
            dt1.Value.AddSeconds(calenda_rtc_offset.Value.Second);
            dt1.Value.AddMinutes(calenda_rtc_offset.Value.Minute);
            dt1.Value.AddHours(calenda_rtc_offset.Value.Hour);
            
            lbl_nxt_wakeup.Text = calendar_rtc.Text;
            lbl_nxtwakeup2.Text = calenda_rtc_offset.Text;
        }
        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // Close the socket if it is still open
                if (m_sock != null && m_sock.Connected)
                {
                    m_sock.Shutdown(SocketShutdown.Both);
                    System.Threading.Thread.Sleep(10);
                    m_sock.Close();
                }

                // Create the socket object
                m_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
               // Define the Server address and port
                IPEndPoint epServer = new IPEndPoint(IPAddress.Parse(txtServerAddress.Text),PORT);
                m_sock.Blocking = false;
                AsyncCallback onconnect = new AsyncCallback(OnConnect);
                m_sock.BeginConnect(epServer, onconnect, m_sock);
                if (m_sock.Connected)
                {
                    status_flag = true;
                    GetTheThreadStarted();
                }

            }
            catch (Exception ex)
            {
                status_flag = false;

                GetTheThreadStarted();

                MessageBox.Show(this, ex.Message, "Server Connect failed!");
            }
            Cursor.Current = cursor;
        }

        public void OnConnect(IAsyncResult ar)
        {
            // Socket was the passed in object
            Socket sock = (Socket)ar.AsyncState;

            // Check if we were sucessfull
            try
            {
                //sock.EndConnect( ar );
                if (sock.Connected)
                {
                    SetupRecieveCallback(sock);
                    status_flag = true;
                    GetTheThreadStarted();

                }
                else
                {
                    MessageBox.Show(this, "Unable to connect to remote machine", "Connect Failed!");
                    status_flag = false;
                    GetTheThreadStarted();

                }
            }
            catch (Exception ex)
            {
                status_flag = false;
                GetTheThreadStarted();
               // MessageBox.Show(this, ex.Message, "Unusual error during Connect!");
            }
        }

        /// <summary>
        /// Get the new data and send it out to all other connections. 
        /// Note: If not data was recieved the connection has probably 
        /// died.
        /// </summary>
        /// <param name="ar"></param>
        public void OnRecievedData(IAsyncResult ar)
        {
            // Socket was the passed in object
            Socket sock = (Socket)ar.AsyncState;

            // Check if we got any data
            try
            {
                int nBytesRec = sock.EndReceive(ar);
                if (nBytesRec > 0)
                {
                    // Wrote the data to the List
                    string sRecieved = Encoding.ASCII.GetString(m_byBuff, 0, nBytesRec);

                    // WARNING : The following line is NOT thread safe. Invoke is
                    // m_lbRecievedData.Items.Add( sRecieved );
                    Invoke(m_AddMessage, new string[] { sRecieved });

                    // If the connection is still usable restablish the callback
                    SetupRecieveCallback(sock);
                }
                else
                {
                    // If no data was recieved then the connection is probably dead
                    Console.WriteLine("Client {0}, disconnected", sock.RemoteEndPoint);
                    sock.Shutdown(SocketShutdown.Both);
                    sock.Close();
                    status_flag = false;
                    GetTheThreadStarted();
                }
            }
            catch (Exception ex)
            {
                status_flag = false;
                GetTheThreadStarted();
               // MessageBox.Show(this, ex.Message, "Unusual error druing Recieve!");
            }
        }

        public void OnAddMessage(string sMessage)
        {
            // m_lbRecievedData.Items.Add(sMessage);
            decode_message(sMessage);
            m_lbRecievedData.Text += "\n";
            m_lbRecievedData.Text += sMessage;
        }



        /// <summary>
        /// Setup the callback for recieved data and loss of conneciton
        /// </summary>
        public void SetupRecieveCallback(Socket sock)
        {
            try
            {
                AsyncCallback recieveData = new AsyncCallback(OnRecievedData);
                sock.BeginReceive(m_byBuff, 0, m_byBuff.Length, SocketFlags.None, recieveData, sock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Setup Recieve Callback failed!");
            }
        }

        /// <summary>
        /// Close the Socket connection bofore going home
        /// </summary>
        private void FormMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (m_sock != null && m_sock.Connected)
            {
                m_sock.Shutdown(SocketShutdown.Both);
                m_sock.Close();
            }
        }

        /// <summary>
        /// Send the Message in the Message area. Only do this if we are connected
        /// </summary>
        private void btn_Send_Click(object sender, System.EventArgs e)
        {
            
            // Check we are connected
            if (m_sock == null || !m_sock.Connected)
            {
                MessageBox.Show(this, "Must be connected to Send a message");
                return;
            }

            // Read the message from the text box and send it
            try
            {
                // Convert to byte array and send.
                Byte[] byteDateLine = Encoding.ASCII.GetBytes(m_tbMessage.Text.ToCharArray());
                m_sock.Send(byteDateLine, byteDateLine.Length, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Send Message Failed!");
            }
        }
        private Byte[] convert_to_bytes(string text)
        {
            Byte[] byteDateLine = Encoding.ASCII.GetBytes(text);
            return byteDateLine;
        }
        private void Send_data(byte[] byteDateLine)
        {
            m_sock.Send(byteDateLine, byteDateLine.Length, 0);
        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            Send_data(convert_to_bytes("status"));
        }
        private void decode_message(String status)
        {
            string temp = "";
            if (status.Contains('L') && status.Contains('H') && status.Contains('T'))
            {
                /* TURN ON/OFF LED*/
                if (status.Contains("lof"))              
                    stat_light = false;
                else if (status.Contains("lon"))
                    stat_light = true;
                ThreadLight();
                /********************/

                /* LIGHT STATUS*/
                int i = status.IndexOf('L');
                while (status.ElementAt(i + 1) != ';')
                {
                    temp += status.ElementAt(i + 1);
                    i++;
                }
                i = 0;
                txt_light.Text = temp;
                temp = "";
                /***************/
                /* Humidity */
                i = status.IndexOf('H');
                while (status.ElementAt(i + 1) != ';')
                {
                    temp += status.ElementAt(i + 1);
                    i++;
                }
                i = 0;
                txt_humidity.Text = temp;
                temp = "";
                /***************/
                /*Temperature*/
                i = status.IndexOf('T');
                while (status.ElementAt(i + 1) != ';')
                {
                    temp += status.ElementAt(i + 1);
                    i++;
                }
                i = 0;
                txt_temperature.Text = temp;
                temp = "";
            }

        }
    }
}


