namespace ChessApi.Pieces
{
    public class Pawn
    {
        private int Color { get; set; } // 1 for white, -1 for black
        private int Position { get; set; } // 0-63, where 0 is a1, 1 is b1, ..., 7 is h1, 8 is a2, ..., 63 is h8
    
        public int SetColor(int TeamColor)
        {
            Color = (int)Color;
            return Color;
        }
        public int SetPosition(int NewPosition)
        {
            Position = (int)Position;
            return Position;
        }
    }
}
