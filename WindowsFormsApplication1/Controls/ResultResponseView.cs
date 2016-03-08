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

        public delegate void InsertUnitsRowHandler(List<Units> listUnits);
        public delegate void ClearAllHandler();

        public void clearAll()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ClearAllHandler(clear));
                return;
            }
            else
            {
                clear();
            }
        }
    
        void clear()
        {
            UnitsView.Rows.Clear();
        }
    
        public void InsertUnitsRow(List<Units> listUnits)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new InsertUnitsRowHandler(InsertUnits),listUnits);
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
