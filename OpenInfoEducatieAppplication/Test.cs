using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenInfoEducatieAppplication
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            string fileName = "https://cmvro.ro/files/download/legislatie/legislatie-caini/ordonanta-55.pdf";
            axAcroPDF1.src = fileName;
        }
    }
}
