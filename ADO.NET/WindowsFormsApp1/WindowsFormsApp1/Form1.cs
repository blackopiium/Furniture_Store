using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private DBRequest UserReq;
        private DataTable RequestTab;
        private DataTable StructTab;
        private string LastTabName;
        public MainForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


       private void MainForm_Load(object sender, EventArgs e)
        {
            UserReq = new DBRequest();
            StructTab = new DataTable();
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            DatGridDBTables.DataSource = StructTab;
            DatGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;
            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);

        }
       private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool Connected = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                UserReq.Disconnect();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
                Connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connected = false;
            }
            if (Connected)
            {
                tbRequest.Enabled = true;
                btnRequest.Enabled = true;
                datGridSQLResult.Enabled = true;
                DatGridDBTables.Enabled = true;
            }
            else
            {
                tbRequest.Enabled = false;
                btnRequest.Enabled = false;
                datGridSQLResult.Enabled = false;
                DatGridDBTables.Enabled = false;
            }
            Cursor = Cursors.Arrow;
            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text);
                datGridSQLResult.DataSource = RequestTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }
       
       

    }
}
