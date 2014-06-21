using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace LeadershipManager
{
   public partial class frmInfoViewer : Form
   {
      
      
      public frmInfoViewer()
      {
         InitializeComponent();
      }

      public void frmInfoViewer_Load(object sender, EventArgs e)
      {
         

      }

      private void btnConnect_Click(object sender, EventArgs e)
      {
         try
         {
            var excel = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Derek\\Documents\\Visual Studio 2013\\Projects\\Deitel\\LeadershipManager\\LeadershipManager\\student_info.xls;Extended Properties=Excel 8.0;HDR=Yes;IMEX=1;");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [student_info$]",excel);

            //Declare new dataset
            DataSet myDataSet = new DataSet();

            dataAdapter.Fill(myDataSet); //load myDataSet into dataAdapter

            dgvStudentInfo.DataSource = myDataSet;
         }
         catch
         {
            MessageBox.Show("Error.");
         }
      }
   }
}
