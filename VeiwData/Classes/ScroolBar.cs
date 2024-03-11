using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VeiwData.Classes
{
    public class ScroolBar
    {
        frmMain openForms = Application.OpenForms.Cast<frmMain>().FirstOrDefault();

        public ScroolBar()
        {
            openForms.sbChart.Visible = true;
            openForms.sbChart.Minimum = 0;
            openForms.sbChart.LargeChange = openForms.WithScreen * 2;
            openForms.sbChart.Maximum = openForms.MaximumValueScroll;
            openForms.sbChart.Value = openForms.ValueScroll;

            openForms.sbChart.ValueChanged += openForms.sbChart_ValueChanged;
        }
    }
}
