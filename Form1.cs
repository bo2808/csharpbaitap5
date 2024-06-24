using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpbaitap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RadioButton r=(RadioButton)sender;
            switch (r.Name)
            {
                case "radRed";
                    lbllaptrinh.ForeColor = Color.Red;
                    txtnhapten.ForeColor = Color.Red;
                    break;
                case "radGreen";
                    lbllaptrinh.ForeColor = Color.Green;
                    txtnhapten.ForeColor = Color.Green;
                    break;
                case "radBlue";
                    lbllaptrinh.ForeColor = Color.Blue;
                    txtnhapten.ForeColor = Color.Blue;
                    break;
                case "radBlack";
                    lbllaptrinh.ForeColor = Color.Black;
                    txtnhapten.ForeColor = Color.Black;
                    break;




            }    
        }

        private void chkdambold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r=(CheckBox)sender;
            switch (r.Name)
            {
                case "chkBold";
                    lbllaptrinh.Font = new Font(lbllaptrinh.Font. Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Bold);
                    break;
                    case "chkNghienItalic";
                    lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
                    break;
                case "chkUnderline";
                    lbllaptrinh
            }
        }
    }
}
