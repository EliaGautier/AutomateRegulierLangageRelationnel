using AutomateRegulier.Modele.Algorithme.Realisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateRegulier.Modele.Algorithme.Fabrique.Makers.Realisation
{
    internal class MakerAlgorithmeHttpOuWww : IMakerAlgorithme
    {
        public string NomAlgorithme => "Commence par http:// ou www";

        public Algorithme Creer()
        {
            return new AlgorithmeHttpOuWww();
        }
    }
}
