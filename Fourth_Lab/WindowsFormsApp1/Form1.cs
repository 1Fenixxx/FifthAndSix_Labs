using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<ObjectLib.Computer> DataList = new List<ObjectLib.Computer>();
        public Form1()
        {
            InitializeComponent();

            B_Edit.Enabled = false;

        }
        private void UpdateDGVData()
        {
            DGV_Data.Rows.Clear();
            int rowCount = DataList.Count;
            for (int row = 0; row < rowCount; row++)
            {
                DGV_Data.Rows.Add();
                DGV_Data.Rows[row].Cells[0].Value = row + 1;
                DGV_Data.Rows[row].Cells[1].Value = DataList[row].GetDataForDataGridView()[0].Replace("Price: ", "");
                DGV_Data.Rows[row].Cells[2].Value = DataList[row].GetDataForDataGridView()[1].Replace("MotherBoard: ", "");
                DGV_Data.Rows[row].Cells[3].Value = DataList[row].GetDataForDataGridView()[2].Replace("CPU: ", "");
                DGV_Data.Rows[row].Cells[4].Value = DataList[row].GetDataForDataGridView()[3].Replace("GPU: ", "");
                DGV_Data.Rows[row].Cells[5].Value = DataList[row].GetDataForDataGridView()[4].Replace("Drives: ", "").Replace("Count: ", "");
                DGV_Data.Rows[row].Cells[6].Value = DataList[row].GetDataForDataGridView()[5].Replace("Power Supply: ", "");
            }
        }
        private void B_NewObject_Click(object sender, EventArgs e)
        {
            ComputerObjectBuffer.BufferObject = new ObjectLib.Computer();
            ObjectAddForm newWindow = new ObjectAddForm();
            newWindow.ShowDialog();
            this.DataList.Add(ComputerObjectBuffer.BufferObject);
            UpdateDGVData();
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            //if (LB_Objects.SelectedItem != null)
            //    ComputerObjectBuffer.BufferObject = (ObjectLib.Computer)LB_Objects.SelectedItem;
            //ObjectAddForm newWindow = new ObjectAddForm();
            //this.DataList.RemoveAt(this.DataList.IndexOf(ComputerObjectBuffer.BufferObject));
            //TB_ParamData.Text = string.Empty;
            //newWindow.ShowDialog();
            //this.DataList.Add(ComputerObjectBuffer.BufferObject);
        }

        private void B_DeleteObject_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Data.SelectedRows != null)
                {
                    this.DataList.RemoveAt(Convert.ToInt32(DGV_Data.SelectedRows[0].Cells[0].Value) - 1);
                    UpdateDGVData();
                }
            }
            catch
            {

            }
        }

        private void B_ClearList_Click(object sender, EventArgs e)
        {
            this.DataList.Clear();
            UpdateDGVData();
        }

        private void B_Export_Click(object sender, EventArgs e)
        {
            string data = string.Empty;
            foreach (ObjectLib.Computer comp in DataList)
            {
                data += (comp) + "\n";
            }

            if (!System.IO.Directory.Exists("Exported"))
            {
                System.IO.Directory.CreateDirectory("Exported");
            }
            System.IO.File.WriteAllText($@"Exported/ExportedData.txt", data);
        }
    }
}
