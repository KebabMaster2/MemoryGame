using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        List<string> icons = new List<string>()
        {
            "e","e","d","d","k","k","b","b","N","N","!","!","v","v","$","$"
        };
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            RandomIcons();

        }
        private void InitializeGrid()
        {
            Label label;
            Grid.BackColor = Color.LightSteelBlue;
            Grid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            //webdings e, d, k, b, N, !, &, $

            for (int c = 0; c < 4; c++)
            {
                for(int r = 0; r < 4; r++)
                {
                    label = new Label
                    {
                        Dock = DockStyle.Fill,
                        ForeColor = Color.Black,
                        AutoSize = false,
                        TextAlign=ContentAlignment.MiddleCenter,
                        Font = new Font("Webdings", 72, FontStyle.Bold),
                        Text = "e"
                    };
                    Grid.Controls.Add(label, c, r);
                }
            }

            //Grid.Controls.Add(new Label { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);


        }
        private void RandomIcons()
        {

            Label label;
            for(int i = 0; i < 16; i++)
            {
                int randomIndex = rand.Next(0, icons.Count);
                label = (Label)Grid.Controls[i];
                label.Text = icons[randomIndex];
                icons.RemoveAt(randomIndex);
            }
        }
    }
}
