using AutomateRegulier.Modele.Algorithme.Automates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomateRegulier.Modele.Algorithme.Realisation
{
    internal class AlgorithmeHttpOuWww : Algorithme
    {
        public AlgorithmeHttpOuWww()
        {
            //Création des états pour http
            Etat init = new Etat("Etat initial");
            Etat hLu = new Etat("H a été lu");
            Etat t1Lu = new Etat("T a été lu");
            Etat t2Lu = new Etat("T a été lu");
            Etat pLu = new Etat("P a été lu");
            Etat twoDotLu = new Etat(": a été lu");
            Etat slash1Lu = new Etat("/ a été lu");
            Etat etatTerminal = new Etat("terminé");

            //Création des états pour www
            Etat w1Lu = new Etat("W a été lu");
            Etat w2Lu = new Etat("W a été lu");

            etatTerminal.EstTerminal = true;

            Automate = new Automate(init);

            //Création des règles pour http
            init.AddTransition('h', hLu);
            hLu.AddTransition('t', t1Lu);
            t1Lu.AddTransition('t', t2Lu);
            t2Lu.AddTransition('p', pLu);
            pLu.AddTransition(':', twoDotLu);
            twoDotLu.AddTransition('/', slash1Lu);
            slash1Lu.AddTransition('/', etatTerminal);
            etatTerminal.EtatParDefaut = etatTerminal;

            //Création des règles pour www
            init.AddTransition('w', w1Lu);
            w1Lu.AddTransition('w', w2Lu);
            w2Lu.AddTransition('w', etatTerminal);
        }
    }
}
