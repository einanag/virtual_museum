using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace virtual_museum_f
{
    public partial class FormDeviceSimulation : Form
    {
        private Dictionary<string, DeviceState> devices;

        public FormDeviceSimulation()
        {
            InitializeComponent();
            InitializeDevices();

        }

        private void InitializeDevices()
        {
            devices = new Dictionary<string, DeviceState>
            {
                { "Φωτισμός", new DeviceState() },
                { "Θέρμανση", new DeviceState(22, 15, 30) },
                { "Ήχος", new DeviceState(50, 0, 100) },
                { "Προβολή", new DeviceState() }
            };

            UpdateUIFromDeviceStates();
        }

        private void UpdateUIFromDeviceStates()
        {
            checkBoxLights.Checked = devices["Φωτισμός"].IsOn;
            checkBoxProjection.Checked = devices["Προβολή"].IsOn;
            trackBarTemperature.Value = devices["Θέρμανση"].Value;
            trackBarVolume.Value = devices["Ήχος"].Value;

            labelLights.Text = $"Φωτισμός: {(devices["Φωτισμός"].IsOn ? "Ενεργός" : "Ανενεργός")}";
            labelHeating.Text = $"Θερμοκρασία: {devices["Θέρμανση"].Value}°C";
            labelSound.Text = $"Ένταση: {devices["Ήχος"].Value}%";
            labelProjection.Text = $"Προβολή: {(devices["Προβολή"].IsOn ? "Ενεργή" : "Ανενεργή")}";
        }

        private void ToggleDevice(string deviceName)
        {
            devices[deviceName].Toggle();
            UpdateUIFromDeviceStates();
            LogDeviceStatus(deviceName);
        }

        private void AdjustDeviceValue(string deviceName, int newValue)
        {
            devices[deviceName].Value = newValue;
            UpdateUIFromDeviceStates();
            LogDeviceStatus(deviceName);
        }

        private void LogDeviceStatus(string deviceName)
        {
            var device = devices[deviceName];
            string status = device.IsOn ? "Ενεργό" : "Ανενεργό";
            string message = $"{deviceName}: {status}";
            if (device.HasValue)
            {
                message += $" - {device.Value}{(deviceName == "Θέρμανση" ? "°C" : "%")}";
            }
            listBoxStatus.Items.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}");
        }

        private void buttonControlLights_Click(object sender, EventArgs e) => ToggleDevice("Φωτισμός");
        private void buttonControlProjection_Click(object sender, EventArgs e) => ToggleDevice("Προβολή");
        private void trackBarTemperature_Scroll(object sender, EventArgs e) => AdjustDeviceValue("Θέρμανση", trackBarTemperature.Value);
        private void trackBarVolume_Scroll(object sender, EventArgs e) => AdjustDeviceValue("Ήχος", trackBarVolume.Value);

        private void buttonControlHeating_Click(object sender, EventArgs e)
        {
            var form = new TemperatureControlForm(devices["Θέρμανση"].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AdjustDeviceValue("Θέρμανση", form.SelectedTemperature);
            }
        }

        private void buttonControlSound_Click(object sender, EventArgs e)
        {
            var form = new VolumeControlForm(devices["Ήχος"].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                AdjustDeviceValue("Ήχος", form.SelectedVolume);
            }
        }



        private void checkBoxLights_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class DeviceState
    {
        public bool IsOn { get; private set; }
        public int Value { get; set; }
        public int MinValue { get; }
        public int MaxValue { get; }
        public bool HasValue => MinValue != MaxValue;

        public DeviceState(int initialValue = 0, int minValue = 0, int maxValue = 0)
        {
            IsOn = false;
            Value = initialValue;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public void Toggle() => IsOn = !IsOn;
    }

    public class TemperatureControlForm : Form
    {
        public int SelectedTemperature { get; private set; }
        private NumericUpDown numericUpDown;

        public TemperatureControlForm(int currentTemperature)
        {
            InitializeComponent();
            numericUpDown.Value = currentTemperature;
            SelectedTemperature = currentTemperature;
        }

        private void InitializeComponent()
        {
            this.numericUpDown = new NumericUpDown();
            this.numericUpDown.Minimum = 15;
            this.numericUpDown.Maximum = 30;
            this.numericUpDown.Location = new Point(10, 10);
            this.numericUpDown.Size = new Size(120, 25);
            this.numericUpDown.ValueChanged += NumericUpDown_ValueChanged;
            this.Controls.Add(this.numericUpDown);
            this.Text = "Temperature Control";
            this.Size = new Size(150, 100);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            // OK btn
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(10, 40);
            this.Controls.Add(okButton);
            this.AcceptButton = okButton;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SelectedTemperature = (int)numericUpDown.Value;
        }
    }

    public class VolumeControlForm : Form
    {
        public int SelectedVolume { get; private set; }
        private TrackBar trackBar;

        public VolumeControlForm(int currentVolume)
        {
            InitializeComponent();
            trackBar.Value = currentVolume;
            SelectedVolume = currentVolume;
        }

        private void InitializeComponent()
        {
            this.trackBar = new TrackBar();
            this.trackBar.Minimum = 0;
            this.trackBar.Maximum = 100;
            this.trackBar.TickFrequency = 10;
            this.trackBar.Location = new Point(10, 10);
            this.trackBar.Size = new Size(200, 45);
            this.trackBar.ValueChanged += TrackBar_ValueChanged;
            this.Controls.Add(this.trackBar);
            this.Text = "Volume Control";
            this.Size = new Size(230, 130);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            //OK btn
            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(70, 60);
            this.Controls.Add(okButton);

            this.AcceptButton = okButton;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            SelectedVolume = trackBar.Value;
        }
    }
}
