using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Model;

namespace ViewWin
{
    public partial class MainForm : Form
    {
        BusinessLogical businessLogical = new BusinessLogical();
        public MainForm()
        {
            
            InitializeComponent();

            GridEmp.ColumnCount = 4;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Name";
            GridEmp.Columns[1].Name = "Age";
            GridEmp.Columns[2].Name = "Salary";
            GridEmp.Columns[3].Name = "Position";
            UpdateTable();
        }

        private void ListEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEmployee(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            int id = GridEmp.CurrentRow.Index;
            businessLogical.DeleteEmpForm(id);
            UpdateTable();
        }

        private void UpdateTable()
        {
            GridEmp.Rows.Clear();
            foreach (var emp in businessLogical.Employees)
            {
                string[] Row = new string[] { emp.Name, (emp.Age).ToString(), (emp.Salary).ToString(), emp.Position };
                GridEmp.Rows.Add(Row);
            }
        }

        private void ChangePosition_Click(object sender, EventArgs e)
        {
            var form = new ChangePos();
            form.PositionBox.Text = "Pidr";

            int id = GridEmp.CurrentRow.Index;

            form.NameBox.Text = businessLogical.Employees.ElementAt(id).Name.ToString();
            form.AgeBox.Text = businessLogical.Employees.ElementAt(id).Age.ToString();
            form.SalaryBox.Text = businessLogical.Employees.ElementAt(id).Salary.ToString();
            form.PositionBox.Text = businessLogical.Employees.ElementAt(id).Position.ToString();

            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.Employees.ElementAt(id).Name = form.NameBox.Text;
                businessLogical.Employees.ElementAt(id).Age = int.Parse(form.AgeBox.Text);
                businessLogical.Employees.ElementAt(id).Salary = int.Parse(form.SalaryBox.Text);
                businessLogical.Employees.ElementAt(id).Position = form.PositionBox.Text;
            }
            UpdateTable();
        }

        private void AvgAge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(businessLogical.GetAvgAge().ToString());
        }
    }
}
