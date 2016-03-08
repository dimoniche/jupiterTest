using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Controls
{
    public partial class ResultResponseView : UserControl
    {
        public ResultResponseView()
        {
            InitializeComponent();

            //tableUnits.column
        }

        public delegate void DataEventToObjectEventHandler(List<Units> listUnits);

        public void InsertUnitsRow(List<Units> listUnits)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DataEventToObjectEventHandler(InsertUnits),listUnits);
                return;
            }
            else
            {
                InsertUnits(listUnits);
            }
        }

        public void InsertUnits(List<Units> listUnits)
        {
            foreach (Units unit in listUnits)
            {
                String[] str = { unit.name , unit.value[0] };

                UnitsView.Rows.Add(str);
            }
        }
    }
}
