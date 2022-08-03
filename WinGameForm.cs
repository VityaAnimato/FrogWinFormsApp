using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogWinFormsApp
{
    public partial class WinGameForm : Form
    {
        public int score;
        public WinGameForm()
        {
            InitializeComponent();
        }

        private void WinGameForm_Load(object sender, EventArgs e)
        {
            if (score == 24)
            {

                winGameLabel.Text = "WIN! ВЫ ВЫИГРАЛИ ЗА MIN QTY ШАГОВ";
            }
            else
            {
                winGameLabel.Text = "WIN! ВЫ ВЫИГРАЛИ, НО НЕ ЗА MIN QTY ШАГОВ";
            }
        }
    }
}
