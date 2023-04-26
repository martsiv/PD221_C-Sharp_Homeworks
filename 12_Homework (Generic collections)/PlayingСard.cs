using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Homework__Generic_collections_
{
    enum RankOfCard { _6 = 6, _7, _8, _9, _10, J, Q, K, A }
    enum SuitOfCard { Hearts, Tiles, Clovers, Pikes }
    internal readonly struct PlayingСard : IComparable<PlayingСard>
    {
        public RankOfCard Rank { get; init; }
        public SuitOfCard Suit { get; init; }
        public PlayingСard(RankOfCard rank, SuitOfCard suit)
        {
            Rank = rank;
            Suit = suit;
        }
        public override string ToString() =>
            (((int)Rank) <= 10 ? ((int)Rank).ToString() : Rank.ToString()) + $" {Suit}";
        public int CompareTo(PlayingСard other) => Rank.CompareTo(other.Rank) * -1;
    }

}
