using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jogo jogo1 = new Jogo();
            jogo1.GameCode=int.Parse(CodeTextBox.Text);
            jogo1.GameName=NameTextBox.Text;
            jogo1.GameCategory=CategoryTextBox.Text;
            jogo1.GameReleaseDate=DateTime.Parse(dateTimePicker1.Text);
            
        }
    }
}
