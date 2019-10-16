using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }

        Vehicle vh = new Vehicle();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vh.VehicleName = vehicleNameTextBox.Text;
            vh.RegNo = regNoTextBox.Text;

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vh.SetList(Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vh.MinSpeed.ToString();
            maxSpeedTextBox.Text = vh.MaxSpeed.ToString();
            averageSpeedTextBox.Text = Math.Round(vh.AvgSpeed,3).ToString();
        }
    }
}
