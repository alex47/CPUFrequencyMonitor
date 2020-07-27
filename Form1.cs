using System;
using System.Management;
using System.Windows.Forms;
using System.Windows.Threading;

namespace CPUFrequencyMonitor
{
    public partial class Form1 : Form
    {
        ManagementObjectSearcher WMIWin32_Processor;
        DispatcherTimer CpuFrequencyCollectionTimer;

        const int uiUpdateIntervalMs = 1000;
        const int cpuFrequencyCollectionIntervalMs = 10;
        const int accuracy = uiUpdateIntervalMs / cpuFrequencyCollectionIntervalMs;

        long cpuFrequencySum;
        int cpuFrequencyCollectionIterationCounter;

        public Form1()
        {
            InitializeComponent();

            WMIWin32_Processor = new ManagementObjectSearcher("select CurrentClockSpeed from Win32_Processor");

            CpuFrequencyCollectionTimer = new DispatcherTimer();
            CpuFrequencyCollectionTimer.Interval = new TimeSpan(0, 0, 0, 0, cpuFrequencyCollectionIntervalMs);
            CpuFrequencyCollectionTimer.Tick += CollectCPUFrequency;

            cpuFrequencySum = 0;
            cpuFrequencyCollectionIterationCounter = 0;

            CpuFrequencyCollectionTimer.Start();
        }

        private void CollectCPUFrequency(object sender, EventArgs e)
        {
            foreach (ManagementObject currentClockSpeedObject in WMIWin32_Processor.Get())
            {
                cpuFrequencySum += Convert.ToInt32(currentClockSpeedObject.GetPropertyValue("CurrentClockSpeed"));
            }

            cpuFrequencyCollectionIterationCounter++;

            if (cpuFrequencyCollectionIterationCounter == accuracy)
            {
                textBoxFrequency.Text = (cpuFrequencySum / accuracy).ToString();
                cpuFrequencyCollectionIterationCounter = 0;
                cpuFrequencySum = 0;
            }
        }
    }
}
