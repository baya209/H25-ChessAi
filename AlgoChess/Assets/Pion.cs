using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class Pion : Piece 
{
    public Pion(){
        int valeur = 0 ;     
    }
    protected override bool deplacer(int cI, int cF, int lI, int lF){// cI colonne initiale, cF colonne finale, lI ligne initiale, lF ligne finale
        if (cF == (cI + getCouleur()))
        {
            return true;
        }
        else if (cF == (cI + 2) && getCouleur() ==1 && lI == 1 ) { 
        }
        else if (cF == (cI -2) && getCouleur() == -1 && lI == 7)
        {
        }

        return false;
    }
}
