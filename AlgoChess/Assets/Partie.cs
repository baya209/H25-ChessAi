using System.Collections.Generic;


public class Partie 
{
    private Plateau plateau;




    public void creerPartie()
    {
        int[,] tableau = new int[8, 8];
        //Creation du plateau
        for (int i = 0; i < 8; i++)
        {
            tableau[0,i] = 1;
            tableau[1,i] = 1;

            tableau[2, i] = 0;
            tableau[3, i] = 0;
            tableau[4, i] = 0;
            tableau[5, i] = 0;

            tableau[6,i] = -1;
            tableau[7, i] = -1;
        }


        List<Piece> pieces = new List<Piece>();
        //Ajout pions 
        for (int i = 0; i < 8; i++) {
            
            Pion pion1 = new Pion(tableau, i, 1, 1);
            Pion pion3 = new Pion(tableau, i, 6, -1);
            
            pieces.Add(pion1);
            pieces.Add(pion3);
            
        }
        plateau = new Plateau(tableau,pieces);
    }
    public bool jouerCoup(int li, int ci, int lf,int cf)
    {
        if (plateau.getTableau()[li,ci] != 0)
        {
            Piece deplace = plateau.getPieces().Find(p => p.getLigne() == li && p.getColonne() == ci);
            if (deplace.deplacer(lf, cf))
            {
                deplace.setLigne(lf);
                deplace.setColonne(cf);
                plateau.getPieces().Remove(plateau.getPieces().Find(p => p.getLigne() == lf && p.getColonne() == cf));
                return true;
            }
        }
        return false;
    }

}
