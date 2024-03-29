using System;
using System.Diagnostics;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace ThystUnlocker
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeChart()
        {
            chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Web Roblox RAM Usage",

                    PointGeometrySize = 10,
                    Values = new ChartValues<ObservablePoint>()
                },
                new LineSeries
                {
                    Title = "App RAM Usage",

                    PointGeometrySize = 10,
                    Values = new ChartValues<ObservablePoint>()
                },
            };
        }

        private int timing = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            Process[] webRbx = Process.GetProcessesByName("RobloxPlayerBeta");
            Process[] mcRbx = Process.GetProcessesByName("ThystUnlocker");

            if (webRbx.Length > 0)
            {
                Process robloxProcess = webRbx[0];
                long ramUsageBytes = robloxProcess.WorkingSet64;
                double ramUsageMegabytes = (double)ramUsageBytes / (1024.0 * 1024.0);

                var ramUsageSeriesBlue = (LineSeries)chart.Series[0];

                if (ramUsageSeriesBlue.Values.Count >= 5)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        ramUsageSeriesBlue.Values[i] = ramUsageSeriesBlue.Values[i + 1];
                    }
                    ramUsageSeriesBlue.Values[4] = new ObservablePoint(timing, ramUsageMegabytes);
                }
                else
                {
                    ramUsageSeriesBlue.Values.Add(new ObservablePoint(timing, ramUsageMegabytes));
                }

                chart.Update();
            }

            if (mcRbx.Length > 0)
            {
                Process robloxProcess = mcRbx[0];
                long ramUsageBytes = robloxProcess.WorkingSet64;
                double ramUsageMegabytes = (double)ramUsageBytes / (1024.0 * 1024.0);

                if (chart.Series.Count >= 2)
                {
                    var ramUsageSeriesRed = (LineSeries)chart.Series[1];

                    if (ramUsageSeriesRed.Values.Count >= 5)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            ramUsageSeriesRed.Values[i] = ramUsageSeriesRed.Values[i + 1];
                        }
                        ramUsageSeriesRed.Values[4] = new ObservablePoint(timing, ramUsageMegabytes);
                    }
                    else
                    {
                        ramUsageSeriesRed.Values.Add(new ObservablePoint(timing, ramUsageMegabytes));
                    }

                    chart.Update();
                }
                else
                {
                    AppendTextToOutputTextBox("Something went wrong while trying to display the chart");
                }
            }

            timing++;
        }


    }
}

