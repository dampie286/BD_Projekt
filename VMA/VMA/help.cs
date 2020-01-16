using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMA
{
    public partial class helppdf : Form
    {
        public helppdf(int n)
        {
            InitializeComponent();
            fillPDF(n);
        }

        void fillPDF(int numberpage)
        {
            axAcroPDF1.src= AppDomain.CurrentDomain.BaseDirectory + "VMA_help_user.pdf";
            axAcroPDF1.setCurrentPage(numberpage);
            axAcroPDF1.setZoom(68);
        }
    }
}
