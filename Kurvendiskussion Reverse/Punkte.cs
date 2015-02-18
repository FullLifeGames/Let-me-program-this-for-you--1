using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kurvendiskussion_Reverse
{
    public class Punkte
    {
        // Nicht der beste Weg eine Klasse zu bauen, aber wir müssen nur irgendwie die Daten speichern
        public Form1.Type type;
        public long x;
        public long y;

        public Punkte(Form1.Type type, long x, long y)
        {
            this.type = type;
            this.x = x;
            this.y = y;
        }
    }
}
