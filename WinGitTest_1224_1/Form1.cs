using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGitTest_1224_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "버튼클릭";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "ㅁㄴㅇㄻㄴㄴㅇㄹㅇ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "우짤";
        }
    }
}
