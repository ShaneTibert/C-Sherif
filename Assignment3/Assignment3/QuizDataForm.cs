using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class QuizDataForm : Form
    {
        public QuizDataForm()
        {
            InitializeComponent();
        }

        private void examineeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizDataSet1);

        }

        private void QuizDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet1.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.quizDataSet1.Question);
            // TODO: This line of code loads data into the 'quizDataSet1.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.quizDataSet1.Quiz);
            // TODO: This line of code loads data into the 'quizDataSet1.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.quizDataSet1.Examinee);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
