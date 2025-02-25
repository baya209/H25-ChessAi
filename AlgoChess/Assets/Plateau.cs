
using System.Collections.Generic;


public class Plateau 
{

    private int[,] tableau = new int[8, 8]; // -1 = noir /// 0 = vide /// 1= blanc
    List<Piece> pieces = new List<Piece>();
    
    public Plateau(int[,] tableau, List<Piece> pieces)
    {
        this.pieces = pieces;
        this.tableau = tableau; 
    }
    public int[,] getTableau() {  return tableau; }
    public void setTableau(in int[,] tableau)
    {
        this.tableau = tableau;
    }
    public void setPieces(List<Piece> pieces) {  this.pieces = pieces; }
    public List<Piece> getPieces() { return pieces; }

    // ecrire deplacement speciaux dans jeu

}
