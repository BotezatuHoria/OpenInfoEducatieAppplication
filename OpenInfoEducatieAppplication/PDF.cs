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
    public partial class PDF : Form
    {
        public PDF(string _file)
        {
            InitializeComponent();
            string fileName = "https://lumenpublishing.com/journals/index.php/po/article/download/2277/pdf/6101";
            axAcroPDF1.src = _file;
        }
    }
}
