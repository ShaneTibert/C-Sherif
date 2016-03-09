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
            this.tableAdapterManager.UpdateAll(this.quizDataSet);

        }

        private void examineeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizDataSet);

        }

        private void QuizDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.quizDataSet.Quiz);
            // TODO: This line of code loads data into the 'quizDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.quizDataSet.Question);
            // TODO: This line of code loads data into the 'quizDataSet.Options' table. You can move, or remove it, as needed.
            this.optionsTableAdapter.Fill(this.quizDataSet.Options);
            // TODO: This line of code loads data into the 'quizDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.quizDataSet.Examinee);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
