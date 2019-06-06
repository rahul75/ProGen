using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Microsoft.SqlServer.Management.Smo;


namespace ProcedureGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string ConnectionString = string.Empty;
            if (!chkWAuth.Checked)
            {
                 ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";User ID=" + tbxUserName.Text + ";password=" + tbxPassword.Text;
            }
            else
            {
                 ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";Integrated Security=True";
            } SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                if (rdosql2005.Checked)
                {
                    cmd.CommandText = "select name from sys.objects where type = 'U' order by name";
                }

                if (rdoSql2000.Checked)
                {
                    cmd.CommandText = "select name from sysobjects where xtype = 'U' order by name";
                }

                SqlDataAdapter ADP = new SqlDataAdapter(cmd.CommandText, con);
                DataSet DS = new DataSet();
                ADP.Fill(DS);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    cboTableNAme.DataSource = DS.Tables[0];
                    cboTableNAme.DisplayMember = "name";
                }
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection");
            }
        }

        private void BtnGenrateProcedure_Click(object sender, EventArgs e)
        {
            string ConnectionString = string.Empty;
            if (!chkWAuth.Checked)
            {
                 ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";User ID=" + tbxUserName.Text + ";password=" + tbxPassword.Text;
            }
            else
            {
                 ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";Integrated Security=True";
            }
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select '@'+ column_name+' '+Data_Type +case when CHARACTER_MAXIMUM_LENGTH is not null then '('+ cast(CHARACTER_MAXIMUM_LENGTH as varchar(20)) +')' else '' End,column_name from information_schema.COLUMNS where table_name ='" + cboTableNAme.Text + "'";
            SqlDataAdapter ADP = new SqlDataAdapter(cmd.CommandText, con);
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = @"select ku.Column_Name from information_schema.table_constraints as tc inner join
information_schema.key_column_usage as ku 
on tc.constraint_type = 'Primary key' and
tc.constraint_name =  ku.constraint_name
where tc.Table_Name ='"+ cboTableNAme.Text+"'";

            ADP.Fill(DS);
            ADP.SelectCommand = cmd2;
            ADP.Fill(DT);
            String primarykey = string.Empty;
            if (DT.Rows.Count > 1)
            {
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        primarykey = DT.Rows[i][0].ToString() + "= @" + DT.Rows[i][0].ToString();
                    }
                    else
                    {
                        primarykey += " AND" + DT.Rows[i][0].ToString() + "= @" + DT.Rows[i][0].ToString();
                    }
                }
            }
            else
            {
                primarykey = DT.Rows[0][0].ToString() + "= @" + DT.Rows[0][0].ToString();
            }
                String Parameter = string.Empty;
            String UpdateValue = string.Empty;
            String column = string.Empty;
            String columnValue = string.Empty;
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    
                    if (i != (DS.Tables[0].Rows.Count - 1))
                    {
                        Parameter += DS.Tables[0].Rows[i][0].ToString() + ",\r\n";
                        if (DS.Tables[0].Rows[i][1].ToString() != primarykey)
                            {
                                column += DS.Tables[0].Rows[i][1].ToString() + ",";
                                UpdateValue += DS.Tables[0].Rows[i][1].ToString() + "= @" + DS.Tables[0].Rows[i][1].ToString() + ",\r\n";
                                columnValue += "@" + DS.Tables[0].Rows[i][1].ToString() + ",";
                            }
                    }
                    else
                    {
                        Parameter += DS.Tables[0].Rows[i][0].ToString() + ",\r\n";
                        if (DS.Tables[0].Rows[i][1].ToString() != primarykey)
                        {
                            column += DS.Tables[0].Rows[i][1].ToString();
                            columnValue += "@" + DS.Tables[0].Rows[i][1].ToString();
                            UpdateValue += DS.Tables[0].Rows[i][1].ToString() + "= @" + DS.Tables[0].Rows[i][1].ToString() + "\r\n";
                        }
                    }
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();

            string Scheme = @"create procedure <name>
(
<Parameter>@Flag tinyint
)
as
begin
if @Flag = 1
begin
insert into <tableName>(<TableCOlumn>)VALUES(<cOLUMNvALUES>)
end

if @flag = 2
begin
update <tableName> set
<updateValue>
where
<primaryKeyValue>
end

                   
 IF(@Flag=3)                  
  BEGIN      
   DELETE FROM <tableName>  WHERE <primaryKeyValue>
  END  

end
";
            Scheme = Scheme.Replace("<Parameter>", Parameter);
            Scheme = Scheme.Replace("<tableName>",cboTableNAme.Text);
            Scheme = Scheme.Replace("<TableCOlumn>", column);
            Scheme = Scheme.Replace("<cOLUMNvALUES>", columnValue);
            Scheme = Scheme.Replace("<name>", tbxProcedureName.Text);
            Scheme = Scheme.Replace("<primaryKeyValue>", primarykey);
            Scheme = Scheme.Replace("<updateValue>", UpdateValue);
                tbxProcedure.Text = Scheme;
        }

        private void chkWAuth_CheckedChanged(object sender, EventArgs e)
        {
            if(chkWAuth.Checked)
            {
            tbxUserName.Enabled = false;
            tbxPassword.Enabled = false;
            }
            else
            {
                tbxUserName.Enabled = true;
                tbxPassword.Enabled = true;
            }
        }


        public static void ThreadProc()
        {

            Application.Run(new FormGenrator());

        }




        private void btnGNForm_Click(object sender, EventArgs e)
        {
           
            Form1.ActiveForm.Close();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

            t.Start();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboTableNAme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnectionString = string.Empty;
            if (!chkWAuth.Checked)
            {
                ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";User ID=" + tbxUserName.Text + ";password=" + tbxPassword.Text;
            }
            else
            {
                ConnectionString = "Data Source=" + tbxServerName.Text + ";Initial Catalog=" + tbxDataBasrName.Text + ";Integrated Security=True";
            }
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select column_name,Data_Type +case when CHARACTER_MAXIMUM_LENGTH is not null then '('+ cast(CHARACTER_MAXIMUM_LENGTH as varchar(20)) +')' else '' End from information_schema.COLUMNS where table_name ='" + cboTableNAme.Text + "'";
            SqlDataAdapter ADP = new SqlDataAdapter(cmd.CommandText, con);
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = @"select ku.Column_Name from information_schema.table_constraints as tc inner join
information_schema.key_column_usage as ku 
on tc.constraint_type = 'Primary key' and
tc.constraint_name =  ku.constraint_name
where tc.Table_Name ='" + cboTableNAme.Text + "'";

            ADP.Fill(DS);
            GVFormGenration.DataSource = DS.Tables[0];
           
        }

        private void GnForm_Click(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)GVFormGenration.DataSource;
            dt.Columns.Add(GVFormGenration.Columns[0].ToString());
         
        }

        
    
       
    }
}