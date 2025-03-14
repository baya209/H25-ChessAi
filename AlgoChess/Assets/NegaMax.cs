using UnityEngine;

public class NewMonoBehaviourScript
{
    /* 
    * place vide  = 0
    * pions = 100
    * cavalier = 300
    * fou = 350
    * tour = 500
    * dame = 1000
    * roi = 10 000
    * pour piece noir -> mettre valeur en negatif
    * */
    /*
     *  public int EvaluerEchiquier(Plateau plateau, Couleur joueurActuel)
    {
        int score = 0;
        //score materiel
        foreach(Piece piece in plateau.pieces)//parcourir le tableau de piece
        {
            int valeur = GetValeurPieces(piece); 
            // si couleur cest la meme que le joueur actuel alors on ajoute au score 

            score += (piece.getCouleur == joueurActuel) ? valeur : -valeur; 

        }
        score += EvaluerControleCentre(Plateau plateau,joueurActuel);


        return score;
    }


    */


    /*
     *   //tableau
    int[,] bonusCentre = {
    { 0, 0, 1, 2, 2, 1, 0, 0 },
    { 0, 1, 2, 3, 3, 2, 1, 0 },
    { 1, 2, 3, 4, 4, 3, 2, 1 },
    { 2, 3, 4, 5, 5, 4, 3, 2 },
    { 2, 3, 4, 5, 5, 4, 3, 2 },
    { 1, 2, 3, 4, 4, 3, 2, 1 },
    { 0, 1, 2, 3, 3, 2, 1, 0 },
    { 0, 0, 1, 2, 2, 1, 0, 0 }
    };
    */
    public int EvaluerControleCentre(Plateau plateau, Couleur joueurActuel)
    {
        int score = 0;
        foreach (Piece piece in plateau.pieces)
        {
            int bonus = bonusCentre[piece.Position.x, piece.Position.y];
            int valeurPiece = GetValeurPieces(piece);


            //si la piece est un roi on enleve le bonus 
            if (piece is Roi)
            {

                //TODO: ajout de la variante dependemment de la phase de la partie
                //fin de phase le bonus reste positif
                bonus = -bonus;
            }

            // Appliquer le bonus en fonction de la piece
            //ne pas etre applique aux pions
            score += (piece.getCouleur == joueurActuel) ? bonus * (valeurPiece > 100 ? 1 : 0) : -bonus * (valeurPiece > 100 ? 1 : 0);

        }

        return score;

    }






}



