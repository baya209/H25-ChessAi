using System;
using UnityEngine;

public abstract class Piece 
{
    private int colonne; // exemple la reine blanche est a la position au depart (0,3)
    private int ligne;  
    private int valeur;
    private int couleur; // -1 noir 1 blanc
    private int[,] tableau = new int[8, 8]; // -1 = noir /// 0 = vide /// 1= blanc
    public Piece(int[,] tableau)
    {
        this.tableau = tableau;
    }

    protected abstract bool deplacer(int c, int l);
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
    public int getValeur() {
        return valeur;  
    }
    public void setValeur(int valeur)
    {
        this.valeur = valeur;    
    }
    public void setTableau(int[,] tableau)
    {
        this.tableau = tableau;
    }
    public int[,] getTableau() { 
    return tableau;
    }
}
