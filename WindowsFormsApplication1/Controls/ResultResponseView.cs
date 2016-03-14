using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Controls
{
    public partial class ResultResponseView : UserControl
    {
        public bool columnLoaded = false;

        public ResultResponseView()
        {
            InitializeComponent();

            columnLoaded = false;
        }

        public delegate void InsertUnitsRowHandler(List<Units> listUnits);
		public delegate void InsertArchiveRowHandler(List<Row> rows);
		public delegate void InsertArchiveColumnHandler(List<HeaderColumn> column);
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
            //UnitsView.Rows.Clear();
            //ArchiveView.Rows.Clear();
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
            UnitsView.Rows.Clear();

            foreach (Units unit in listUnits)
            {
                String[] str = { unit.name , unit.value };

                UnitsView.Rows.Add(str);
            }
        }

		public void InsertArchiveRow(List<Row> listRow)
        {
            if (InvokeRequired)
            {
				BeginInvoke(new InsertArchiveRowHandler(InsertArchive), listRow);
                return;
            }
            else
            {
				InsertArchive(listRow);
            }
        }

		public void InsertArchive(List<Row> listRow)
        {
            ArchiveView.Rows.Clear();

            foreach (Row row in listRow)
            {
				String[] str = new string[row.value.Count];
	            int i = 0;

				foreach (String val in row.value)
				{
					str[i] = val;
					i++;
				}

                foreach (String val in str)
                {
                    if(val == "" || val == null)
                    {
                        str[i] = " ";
                    }
                    i++;
                }

                ArchiveView.Rows.Add(str);
            }
        }

		public void InsertArchiveColumn(List<HeaderColumn> column)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new InsertArchiveColumnHandler(ArchiveColumn), column);
				return;
			}
			else
			{
				ArchiveColumn(column);
			}
		}

		public void ArchiveColumn(List<HeaderColumn> column)
		{
            ArchiveView.Columns.Clear();

            foreach (HeaderColumn col in column)
			{
				ArchiveView.Columns.Add(col.column, col.column);
			}

            columnLoaded = true;
        }
    }
}
