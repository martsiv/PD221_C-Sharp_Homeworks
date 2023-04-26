using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Homework__Generic_collections_
{
    internal class PlayingDeck : IEnumerable
    {
        private Queue<PlayingСard> cards;
        public PlayingDeck()
        {
            cards = new Queue<PlayingСard>();
            for (RankOfCard i = RankOfCard._6; i <= RankOfCard.A; i++)
            {
                for (SuitOfCard j = SuitOfCard.Hearts; j <= SuitOfCard.Pikes; j++)
                    cards.Enqueue(new PlayingСard(rank: i, suit: j));
            }
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)cards).GetEnumerator();
        }
        public PlayingСard GetOneCard()
        {
            PlayingСard result = cards.Peek();
            cards.Dequeue();
            return result;
        }
        public void Shuffle()
        {
            PlayingСard[] array = cards.ToArray();
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                PlayingСard temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            cards = new Queue<PlayingСard>(array);
        }
        public PlayingСard[] GetCards()
        {
            PlayingСard[] result = new PlayingСard[6];
            for (int i = 0; i < result.Count(); i++)
            {
                result[i] = cards.Peek();
                cards.Dequeue();
            }
            return result;
        }
    }
}
