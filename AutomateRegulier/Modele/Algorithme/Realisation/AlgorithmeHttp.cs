using AutomateRegulier.Modele.Algorithme.Automates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateRegulier.Modele.Algorithme.Realisation
{
    internal class AlgorithmeHttp : Algorithme
    {
        public AlgorithmeHttp()
        {
            //Création des états
            Etat init = new Etat("Etat initial");
            Etat hLu = new Etat("H a été lu");
            Etat t1Lu = new Etat("T a été lu");
            Etat t2Lu = new Etat("T a été lu");
            Etat pLu = new Etat("P a été lu");
            Etat twoDotLu = new Etat(": a été lu");
            Etat slash1Lu = new Etat("/ a été lu");
            Etat slash2Lu = new Etat("/ a été lu");

            slash2Lu.EstTerminal = true;

            Automate = new Automate(init);

            //Création des règles
            init.AddTransition('h', hLu);
            hLu.AddTransition('t', t1Lu);
            t1Lu.AddTransition('t', t2Lu);
            t2Lu.AddTransition('p', pLu);
            pLu.AddTransition(':', twoDotLu);
            twoDotLu.AddTransition('/', slash1Lu);
            slash1Lu.AddTransition('/', slash2Lu);
            slash2Lu.EtatParDefaut = slash2Lu;
        }
    }
}
