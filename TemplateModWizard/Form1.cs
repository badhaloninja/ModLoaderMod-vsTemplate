using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateModWizard
{
    public partial class Form1 : Form
    {
        public static string modAuthor;
        public static string modDescription;
        public static string targetType;
        public static string targetMethod;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modAuthorTextBox.Text = Environment.UserName;
        }

        private void modAuthorField_TextChanged(object sender, EventArgs e)
        {
            modAuthor = modAuthorTextBox.Text;
        }

        private void modDescTextBox_TextChanged(object sender, EventArgs e)
        {
            modDescription = modDescTextBox.Text;
        }

        private void targetTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            targetType = targetTypeTextBox.Text;
        }

        private void targetMethodTextBox_TextChanged(object sender, EventArgs e)
        {
            targetMethod = targetMethodTextBox.Text;
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            modAuthor = modAuthorTextBox.Text;
            modDescription = modDescTextBox.Text;
            targetType = targetTypeTextBox.Text;
            targetMethod = targetMethodTextBox.Text;
            this.Close();
        }
    }
}
