using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype
{
    class Model
    {
        class Block
        {
            public char letter;
        }
        Block [,]board;
        
        public Model()
        {
            board = new Block[4,4];
            RandomLetters();
        }
        public void RandomLetters()
        {
            //Naive version
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int number = rnd.Next(0, 26);
                    board[i, j].letter = (char)(number + 'a');
                }
            }
        }
    }
}
