using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kurvendiskussion_Reverse
{
    class Funktion
    {
        private double[] koeffizienten;
        private Gleichungen gleichungen; // Unschön, aber eine Möglichkeit
        private Label resultat;

        public Funktion(){}

        public Funktion(double[] koeffizienten, Label resultat)
        {
            // koeffizienten Übergabe irrelevant 0.o
            this.koeffizienten = koeffizienten;
            this.gleichungen = new Gleichungen();
            this.resultat = resultat;
            string s = "y = ";
            for (int i = 0; i < koeffizienten.Length; i++)
            {
                if (i + 1 == koeffizienten.Length)
                {
                    s = s + "" + (char)((int)'a' + i); 
                }
                else
                {
                    s = s + "" + (char)((int)'a' + i) + "x^" + (koeffizienten.Length - 1 - i) + " + ";
                }
            }
            resultat.Text = "Resultat: " + s;
            //Lets see
        }

        public void berechneFunktion(Form1.Type type, long x, long y)
        {
            // Beispiel ax^2 + bx + c
            // Faulheit
            List<Parameter> par = null;
            Parameter p = null;
            double[] koeff = null;
            double[] koefftemp = null;
            switch (type)
            {
                // Case 1 => Closed (Zu viele aber noch zu erledigen, aber sollte machbar sein!)
                case Form1.Type.Punkt:
                    #region Punkt
                    // ax^2 + bx + c = y kann hilfreich sein, Speicherungsmöglichkeit .... ax^2 + bx + c = y
                    gleichungen.parameter.Add(new List<Parameter>());
                    par = gleichungen.parameter[gleichungen.parameter.Count - 1];
                    for (int i = 0; i < koeffizienten.Length; i++)
                    {                        
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = Math.Pow(x,koeffizienten.Length - 1 - i);
                        p.x = koeffizienten.Length - 1 - i;
                        par.Add(p);
                    }                   
                    p = new Parameter();
                    p.gesetzt = true;
                    p.koeff = y;
                    p.x = 0;
                    par.Add(p);

                    // Nochmal checken, ob das hier korrekt ist
                    if (gleichungen.parameter.Count == koeffizienten.Length)
                    {
                        gaussVerfahren();
                        showResult();
                    }
                    #endregion
                    break;
                case Form1.Type.Nullstelle:
                    #region Nullstelle
                    // Copy und paste von da oben, da Nullstelle theoretisch nichts anderes ist
                    gleichungen.parameter.Add(new List<Parameter>());
                    par = gleichungen.parameter[gleichungen.parameter.Count - 1];
                    for (int i = 0; i < koeffizienten.Length; i++)
                    {                        
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = Math.Pow(x,koeffizienten.Length - 1 - i);
                        p.x = koeffizienten.Length - 1 - i;
                        par.Add(p);
                    }                   
                    p = new Parameter();
                    p.gesetzt = true;
                    p.koeff = 0;
                    p.x = 0;
                    par.Add(p);

                    // Nochmal checken, ob das hier korrekt ist
                    if (gleichungen.parameter.Count == koeffizienten.Length)
                    {
                        gaussVerfahren();
                        showResult();
                    }
                    // Informationen, die ich hab y = 0 => ax^2 + bx + c = y => c = y - ax^2 - bx 
                    #endregion
                    break;
                case Form1.Type.Extrempunkt:
                    #region Extrempunkt
                    // Informationen, die ich hab 2ax + b = 0 => b = -2ax => c = y + ax^2
                    // Oh boy, na dann implementieren wir doch mal Ableitungen!
                    koefftemp = new double[koeffizienten.Length];
                    for (int i = 0; i < koefftemp.Length; i++)
                    {
                        koefftemp[i] = 1;
                    }
                    koeff = ableitung(koefftemp);
                    // Für Wendepunkte (nächster Schritt)
//                    koeff = ableitung(koefftemp);
                    // länge 3, 2 .... dammit
                    gleichungen.parameter.Add(new List<Parameter>());
                    par = gleichungen.parameter[gleichungen.parameter.Count - 1];
                    for (int i = 0; i < koeff.Length; i++)
                    {
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = koeff[koeff.Length - 1 - i] * Math.Pow(x, koeff.Length - 1 - i);
                        //Stimmt nicht, ist aber sowieso irrelevant
                        p.x = koeff.Length - 1 - i;
                        par.Add(p);                        
                    }
                    for (int i = 0 - (koeffizienten.Length - koeff.Length); i < 0; i++)
                    {
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = 0;
                        par.Add(p);
                    }
                    p = new Parameter();
                    p.gesetzt = true;
                    p.koeff = 0;
                    p.x = 0;
                    par.Add(p);

                    // Nochmal checken, ob das hier korrekt ist
                    if (gleichungen.parameter.Count == koeffizienten.Length)
                    {
                        gaussVerfahren();
                        showResult();
                    }
                    #endregion
                    break;
                case Form1.Type.Wendepunkt:
                    #region Wendepunkt
                    // Infos => 2a = 0 => a = 0 => c = y - bx
                    // Informationen, die ich hab 2ax + b = 0 => b = -2ax => c = y + ax^2
                    // Oh boy, na dann implementieren wir doch mal Ableitungen!
                    koefftemp = new double[koeffizienten.Length];
                    for (int i = 0; i < koefftemp.Length; i++)
                    {
                        koefftemp[i] = 1;
                    }
                    koeff = ableitung(koefftemp);
                    koeff = ableitung(koeff);
                    // länge 3, 2 .... dammit
                    gleichungen.parameter.Add(new List<Parameter>());
                    par = gleichungen.parameter[gleichungen.parameter.Count - 1];
                    for (int i = 0; i < koeff.Length; i++)
                    {
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = koeff[koeff.Length - 1 - i] * Math.Pow(x, koeff.Length - 1 - i);
                        //Stimmt nicht, ist aber sowieso irrelevant
                        p.x = koeff.Length - 1 - i;
                        par.Add(p);                        
                    }
                    for (int i = 0 - (koeffizienten.Length - koeff.Length); i < 0; i++)
                    {
                        p = new Parameter();
                        p.gesetzt = true;
                        p.koeff = 0;
                        par.Add(p);
                    }
                    p = new Parameter();
                    p.gesetzt = true;
                    p.koeff = 0;
                    p.x = 0;
                    par.Add(p);


                    // Nochmal checken, ob das hier korrekt ist
                    if (gleichungen.parameter.Count == koeffizienten.Length)
                    {
                        gaussVerfahren();
                        showResult();
                    }
                    break;
                    #endregion
            }
        }

        private double[] ableitung(double[] koeffizienten)
        {
            // letzten kann man ignorieren da x^0er wegfallen
            double[] abl = new double[koeffizienten.Length - 1];
            for (int i = koeffizienten.Length - 1; i > 0; i--)
            {               
                abl[i-1] = koeffizienten[i] * i;
            }
            return abl;
        }

        private void showResult()
        {
            string s = "y = ";
            for (int i = 0; i < koeffizienten.Length; i++)
            {
                if (i + 1 == koeffizienten.Length)
                {
                    s = s + "" + koeffizienten[i];
                }
                else
                {
                    s = s + "" + koeffizienten[i] + "x^" + (koeffizienten.Length - 1 - i) + " + ";
                }
            }
            resultat.Text = "Resultat: " + s;
        }

        private void gaussVerfahren()
        {
            List<List<Parameter>> gl = gleichungen.parameter;
            for (int i = 1; i < koeffizienten.Length; i++)
            {
                // I    ax^2 + bx + c = d    
                // II   ax^2 + bx + c = d    | -I
                // III  ax^2 + bx + c = d    | -I | -II 
                // Wohin ist das c verschwunden
                // Theoretisch
                // i = 1,2,3,4
                // j = 0,0,1,0,2 ...
                for (int j = 0; j < i; j++)
                {
                    gl[i] = subtrahiere(gl[i], gl[j]);
                }
            }
            //HALLELUJA!
            for (int i = koeffizienten.Length - 1; i >= 0; i--)
            {
                //gl[i] sollte jetzt aus dx (was auch immer) = Zahl bestehen x gesetzt
                for(int j = koeffizienten.Length - 1 ; j>i;j--){
                    gl[i][koeffizienten.Length].koeff = gl[i][koeffizienten.Length].koeff - (gl[i][j].koeff * koeffizienten[j]);
                    // This will never work (please do)
                }
                koeffizienten[i] = gl[i][koeffizienten.Length].koeff / gl[i][i].koeff;
            }
        }

        private List<Parameter> subtrahiere(List<Parameter> list1, List<Parameter> list2)
        {
            List<Parameter> parameter = new List<Parameter>();
            double faktor = 0;
            bool setfaktor = true;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].koeff == 0 && list2[i].koeff == 0)
                {
                    //Um keinen falschen Faktor zu berechnen
                    Parameter p = new Parameter();
                    p.gesetzt = true;
                    p.x = list1[i].x;
                    p.koeff = 0;
                    parameter.Add(p);
                }
                else
                {
                    if (setfaktor)
                    {
                        //3 - 5; => 0
                        //3 - 3/5 * 5 = 0
                        faktor = list1[i].koeff / list2[i].koeff;                   // Need to fix, really
                        setfaktor = false;
                    }
                    Parameter p = new Parameter();
                    p.gesetzt = true;
                    p.x = list1[i].x;
                    p.koeff = list1[i].koeff - faktor * list2[i].koeff;
                    parameter.Add(p);
                }
            }
            return parameter;
        }
    }
}
