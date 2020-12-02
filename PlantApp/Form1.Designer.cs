using System.Windows.Forms;

namespace PlantApp
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_flash_schedule = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calendar_turn_off = new System.Windows.Forms.DateTimePicker();
            this.calendar_turn_on = new System.Windows.Forms.DateTimePicker();
            this.btn_led_off = new System.Windows.Forms.Button();
            this.btn_led_on = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_status = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.status_wifi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.status_light = new System.Windows.Forms.Button();
            this.txt_light = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_moisture = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_humidity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_temperature = new System.Windows.Forms.TextBox();
            this.timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txt_DateTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_nxtwakeup2 = new System.Windows.Forms.Label();
            this.lbl_nxt_wakeup = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calenda_rtc_offset = new System.Windows.Forms.DateTimePicker();
            this.calendar_rtc = new System.Windows.Forms.DateTimePicker();
            this.m_lbRecievedData = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.m_tbMessage = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_flash_schedule);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.calendar_turn_off);
            this.groupBox1.Controls.Add(this.calendar_turn_on);
            this.groupBox1.Controls.Add(this.btn_led_off);
            this.groupBox1.Controls.Add(this.btn_led_on);
            this.groupBox1.Location = new System.Drawing.Point(319, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control LED";
            // 
            // btn_flash_schedule
            // 
            this.btn_flash_schedule.Location = new System.Drawing.Point(109, 124);
            this.btn_flash_schedule.Name = "btn_flash_schedule";
            this.btn_flash_schedule.Size = new System.Drawing.Size(75, 23);
            this.btn_flash_schedule.TabIndex = 8;
            this.btn_flash_schedule.Text = "Upload schedule";
            this.btn_flash_schedule.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schedule turn off event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Schedule turn on event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turn off:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turn on:";
            // 
            // calendar_turn_off
            // 
            this.calendar_turn_off.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.calendar_turn_off.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendar_turn_off.Location = new System.Drawing.Point(153, 90);
            this.calendar_turn_off.Name = "calendar_turn_off";
            this.calendar_turn_off.ShowUpDown = true;
            this.calendar_turn_off.Size = new System.Drawing.Size(131, 20);
            this.calendar_turn_off.TabIndex = 3;
            this.calendar_turn_off.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // calendar_turn_on
            // 
            this.calendar_turn_on.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.calendar_turn_on.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendar_turn_on.Location = new System.Drawing.Point(9, 90);
            this.calendar_turn_on.Name = "calendar_turn_on";
            this.calendar_turn_on.ShowUpDown = true;
            this.calendar_turn_on.Size = new System.Drawing.Size(131, 20);
            this.calendar_turn_on.TabIndex = 2;
            this.calendar_turn_on.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_led_off
            // 
            this.btn_led_off.BackColor = System.Drawing.Color.Red;
            this.btn_led_off.Location = new System.Drawing.Point(197, 48);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(38, 23);
            this.btn_led_off.TabIndex = 1;
            this.btn_led_off.Text = "OFF";
            this.btn_led_off.UseVisualStyleBackColor = false;
            this.btn_led_off.Click += new System.EventHandler(this.btn_led_off_Click);
            // 
            // btn_led_on
            // 
            this.btn_led_on.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_led_on.Location = new System.Drawing.Point(49, 48);
            this.btn_led_on.Name = "btn_led_on";
            this.btn_led_on.Size = new System.Drawing.Size(38, 23);
            this.btn_led_on.TabIndex = 0;
            this.btn_led_on.Text = "ON";
            this.btn_led_on.UseVisualStyleBackColor = false;
            this.btn_led_on.Click += new System.EventHandler(this.btn_led_on_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_status);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtServerAddress);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.status_wifi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.status_light);
            this.groupBox2.Controls.Add(this.txt_light);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_moisture);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_humidity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_temperature);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monitoring";
            // 
            // btn_status
            // 
            this.btn_status.Location = new System.Drawing.Point(96, 178);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(75, 23);
            this.btn_status.TabIndex = 18;
            this.btn_status.Text = "Status";
            this.btn_status.UseVisualStyleBackColor = true;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "IP;";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(55, 330);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(100, 20);
            this.txtServerAddress.TabIndex = 15;
            this.txtServerAddress.Text = "192.168.4.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(180, 330);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // status_wifi
            // 
            this.status_wifi.BackColor = System.Drawing.Color.Red;
            this.status_wifi.Enabled = false;
            this.status_wifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_wifi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_wifi.Location = new System.Drawing.Point(161, 267);
            this.status_wifi.Name = "status_wifi";
            this.status_wifi.Size = new System.Drawing.Size(94, 28);
            this.status_wifi.TabIndex = 13;
            this.status_wifi.Text = "Not connected";
            this.status_wifi.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(8, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Connection with device:";
            // 
            // status_light
            // 
            this.status_light.BackColor = System.Drawing.Color.Red;
            this.status_light.Enabled = false;
            this.status_light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_light.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status_light.Location = new System.Drawing.Point(198, 229);
            this.status_light.Name = "status_light";
            this.status_light.Size = new System.Drawing.Size(41, 28);
            this.status_light.TabIndex = 11;
            this.status_light.Text = "OFF";
            this.status_light.UseVisualStyleBackColor = false;
            // 
            // txt_light
            // 
            this.txt_light.Location = new System.Drawing.Point(84, 145);
            this.txt_light.Name = "txt_light";
            this.txt_light.Size = new System.Drawing.Size(100, 20);
            this.txt_light.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(8, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "LED lights are currently turned: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Light:";
            // 
            // txt_moisture
            // 
            this.txt_moisture.Location = new System.Drawing.Point(84, 111);
            this.txt_moisture.Name = "txt_moisture";
            this.txt_moisture.Size = new System.Drawing.Size(100, 20);
            this.txt_moisture.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Soil moisture:";
            // 
            // txt_humidity
            // 
            this.txt_humidity.Location = new System.Drawing.Point(84, 78);
            this.txt_humidity.Name = "txt_humidity";
            this.txt_humidity.Size = new System.Drawing.Size(100, 20);
            this.txt_humidity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Humidity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Temperature:";
            // 
            // txt_temperature
            // 
            this.txt_temperature.Location = new System.Drawing.Point(84, 43);
            this.txt_temperature.Name = "txt_temperature";
            this.txt_temperature.Size = new System.Drawing.Size(100, 20);
            this.txt_temperature.TabIndex = 0;
            // 
            // timer_DateTime
            // 
            this.timer_DateTime.Enabled = true;
            this.timer_DateTime.Interval = 1000;
            this.timer_DateTime.Tick += new System.EventHandler(this.timer_DateTime_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Date and Time:";
            // 
            // txt_DateTime
            // 
            this.txt_DateTime.AutoSize = true;
            this.txt_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_DateTime.Location = new System.Drawing.Point(135, 511);
            this.txt_DateTime.Name = "txt_DateTime";
            this.txt_DateTime.Size = new System.Drawing.Size(0, 20);
            this.txt_DateTime.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_nxtwakeup2);
            this.groupBox3.Controls.Add(this.lbl_nxt_wakeup);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.calenda_rtc_offset);
            this.groupBox3.Controls.Add(this.calendar_rtc);
            this.groupBox3.Location = new System.Drawing.Point(319, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 140);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RTC Wake Up";
            // 
            // lbl_nxtwakeup2
            // 
            this.lbl_nxtwakeup2.AutoSize = true;
            this.lbl_nxtwakeup2.Location = new System.Drawing.Point(153, 111);
            this.lbl_nxtwakeup2.Name = "lbl_nxtwakeup2";
            this.lbl_nxtwakeup2.Size = new System.Drawing.Size(0, 13);
            this.lbl_nxtwakeup2.TabIndex = 15;
            // 
            // lbl_nxt_wakeup
            // 
            this.lbl_nxt_wakeup.AutoSize = true;
            this.lbl_nxt_wakeup.Location = new System.Drawing.Point(150, 94);
            this.lbl_nxt_wakeup.Name = "lbl_nxt_wakeup";
            this.lbl_nxt_wakeup.Size = new System.Drawing.Size(0, 13);
            this.lbl_nxt_wakeup.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Next wake up:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "After that wake up every:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Wake up at:";
            // 
            // calenda_rtc_offset
            // 
            this.calenda_rtc_offset.CustomFormat = "hh:mm:ss";
            this.calenda_rtc_offset.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calenda_rtc_offset.Location = new System.Drawing.Point(166, 63);
            this.calenda_rtc_offset.Name = "calenda_rtc_offset";
            this.calenda_rtc_offset.ShowUpDown = true;
            this.calenda_rtc_offset.Size = new System.Drawing.Size(75, 20);
            this.calenda_rtc_offset.TabIndex = 10;
            this.calenda_rtc_offset.Value = new System.DateTime(2020, 10, 12, 0, 0, 0, 0);
            this.calenda_rtc_offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calenda_rtc_offset_KeyPress);
            this.calenda_rtc_offset.Validated += new System.EventHandler(this.calenda_rtc_offset_Validated);
            // 
            // calendar_rtc
            // 
            this.calendar_rtc.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.calendar_rtc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.calendar_rtc.Location = new System.Drawing.Point(110, 33);
            this.calendar_rtc.Name = "calendar_rtc";
            this.calendar_rtc.ShowUpDown = true;
            this.calendar_rtc.Size = new System.Drawing.Size(131, 20);
            this.calendar_rtc.TabIndex = 9;
            // 
            // m_lbRecievedData
            // 
            this.m_lbRecievedData.Location = new System.Drawing.Point(341, 374);
            this.m_lbRecievedData.Name = "m_lbRecievedData";
            this.m_lbRecievedData.Size = new System.Drawing.Size(287, 66);
            this.m_lbRecievedData.TabIndex = 6;
            this.m_lbRecievedData.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Receive:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(338, 455);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Transmit:";
            // 
            // m_tbMessage
            // 
            this.m_tbMessage.Location = new System.Drawing.Point(341, 471);
            this.m_tbMessage.Name = "m_tbMessage";
            this.m_tbMessage.Size = new System.Drawing.Size(287, 20);
            this.m_tbMessage.TabIndex = 9;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(635, 469);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 540);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.m_tbMessage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.m_lbRecievedData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_DateTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "PlantApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker calendar_turn_on;
        private System.Windows.Forms.Button btn_led_off;
        private System.Windows.Forms.Button btn_led_on;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calendar_turn_off;
        private Button status_light;
        private Label label9;
        private Button btn_flash_schedule;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txt_light;
        private Label label8;
        private TextBox txt_moisture;
        private Label label7;
        private TextBox txt_humidity;
        private Label label6;
        private Label label5;
        private TextBox txt_temperature;
        private Button status_wifi;
        private Label label10;
        private Timer timer_DateTime;
        private Label label11;
        private Label txt_DateTime;
        private GroupBox groupBox3;
        private DateTimePicker calendar_rtc;
        private Label label13;
        private Label label12;
        private DateTimePicker calenda_rtc_offset;
        private Label lbl_nxtwakeup2;
        private Label lbl_nxt_wakeup;
        private Label label14;
        private Button btnConnect;
        private Label label15;
        private TextBox txtServerAddress;
        private RichTextBox m_lbRecievedData;
        private Label label16;
        private Label label17;
        private TextBox m_tbMessage;
        private Button btn_Send;
        private Button btn_status;
    }
}

