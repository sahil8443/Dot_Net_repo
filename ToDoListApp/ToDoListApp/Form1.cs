using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                string task = lstTasks.SelectedItem.ToString();
                lstTasks.Items[lstTasks.SelectedIndex] = "✔️ " + task; // Add a checkmark in front of the task
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem); // Remove the selected task
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTasks.Text;
            if (!string.IsNullOrEmpty(task))
            {
                lstTasks.Items.Add(task); // Add task to ListBox
                lstTasks.ClearSelected(); // Clear the TextBox
            }
            else
            {
                MessageBox.Show("Please enter a task.");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
