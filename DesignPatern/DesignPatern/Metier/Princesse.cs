﻿#region ---------------- Princesse.cs ----------------------
/*
    Namespaces      WpfAventure.Metier
    Classes         Princesse
 
    Date              day
    Modif             day
                    
 * 
    Auteur          Vincent LE CERF 
    Copyright       METAGENIA, 1999 - 2013
    URL             http://www.metagenia.net
    Email           codesource@metagenia.net
*/
#endregion --------------------------------------------------


namespace MaraudersAdventure
{
    public class Princesse : Personnage
    {
        public Princesse(EtatMajor em, string unNom, TypeEquipe e) : 
            base(em, unNom, TypePersonnage.Princesse, e)
        {
            Image = Properties.Resources.princesse; 
            ComportementEmettreUnSon = new ComportementParlerPrincesse();
            seDeplacer = new SeDeplacerApiedAvecHache();
            //em.Notify(string.Format("La princesse {0} à été créée", unNom));

            PointsDeVie = 95;
            PointsDAttaque = 5;
            Vitesse = 1;
        }

    }
}
