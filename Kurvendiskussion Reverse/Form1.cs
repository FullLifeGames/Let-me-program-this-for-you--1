using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurvendiskussion_Reverse
{
    public partial class Form1 : Form
    {
        public enum Type { Punkt, Nullstelle, Extrempunkt, Wendepunkt };

        #region Variablen
        private List<Punkte> punkte = new List<Punkte>();
        private Funktion f = new Funktion();
        #endregion

        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Typ", 150); //works
            listView1.Columns.Add("X");
            listView1.Columns.Add("Y");
        }

        private void updateResultat()
        {
            Punkte p = punkte[punkte.Count - 1];
            if (minusX.Checked)
            {
                p.x = -p.x;
            }
            if (minusY.Checked)
            {
                p.y = -p.y;
            }


            string[] arguments = new string[3];
            //Typ
            arguments[0] = p.type.ToString(); // Zufriedenstellend :)
            arguments[1] = p.x + "";
            if (p.type == Type.Punkt)
            {
                arguments[2] = p.y + "";
            }
            else if(p.type == Type.Nullstelle)
            {
                arguments[2] = 0 + "";
            }
            else
            {
                arguments[2] = "";
            }
            listView1.Items.Add(new ListViewItem(arguments));
            if (TB_Grad.Text.Equals("") || punkte.Count-1 > int.Parse(TB_Grad.Text))
            {
                TB_Grad.Text = (punkte.Count-1) + "";
            }
            f.berechneFunktion(p.type, p.x, p.y);
        }

        // Fehler werden erstmal einfach nicht behandelt ...... das ist ne doofe Entscheidung!

        private void punkt_Click(object sender, EventArgs e)
        {
            if (!TB_X.Text.Equals("") && !TB_Y.Text.Equals(""))
            {
                punkte.Add(new Punkte(Type.Punkt, long.Parse(TB_X.Text), long.Parse(TB_Y.Text)));
                updateResultat();
            }  
        }

        private void wendepunkt_Click(object sender, EventArgs e)
        {
            //Überprüfung ob die Textfelder leer sind
            if(!TB_X.Text.Equals("") && !TB_Y.Text.Equals("")){
                punkte.Add(new Punkte(Type.Wendepunkt, long.Parse(TB_X.Text), long.Parse(TB_Y.Text)));
                updateResultat();
            }           
        }

        private void extrempunkt_Click(object sender, EventArgs e)
        {
            //Überprüfung ob die Textfelder leer sind
            if (!TB_X.Text.Equals("") && !TB_Y.Text.Equals(""))
            {
                punkte.Add(new Punkte(Type.Extrempunkt, long.Parse(TB_X.Text), long.Parse(TB_Y.Text)));
                updateResultat();
            }    
        }

        private void nullstelle_Click(object sender, EventArgs e)
        {
            //Überprüfung ob die Textfelder leer sind
            if (!TB_X.Text.Equals("") && !TB_Y.Text.Equals(""))
            {
                punkte.Add(new Punkte(Type.Nullstelle, long.Parse(TB_X.Text), long.Parse(TB_Y.Text)));
                updateResultat();
            }    
        }

        private void TB_Grad_TextChanged(object sender, EventArgs e)
        {
            if (!TB_Grad.Text.Equals(""))
            {
                f = new Funktion(new double[int.Parse(TB_Grad.Text)+1],resultat);
                foreach (Punkte punkt in punkte)
                {
                    f.berechneFunktion(punkt.type, punkt.x, punkt.y);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            punkte = new List<Punkte>();
            f = new Funktion();
            listView1.Items.Clear();
        }

    }
}
