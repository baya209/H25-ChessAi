using System;
using UnityEngine;

public abstract class Piece 
{
    private int colonne; // exemple la reine est a la position au depart (0,3)
    private int ligne;  
    int valeur;
    int couleur; // -1 noir 1 blanc

    protected abstract bool deplacer(int cI, int cF, int lI, int lF);
    public  int getColonne() {
        return colonne;
    }
    public int getLigne()
    {
        return colonne;
    }
    public int getCouleur()
    {
        return couleur;
    }
    public void setColonne( int colonne) { this.colonne = colonne; }
    public void setLigne(int ligne) { this.ligne = ligne; }
    
}
