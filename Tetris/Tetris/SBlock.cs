﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class SBlock:Block
    {
        //SBlock
        //(0,2), (1,1), (1,2), (2,1)
        //(1,1), (1,2), (2,2), (2,3)
        //(0,3), (1,2), (1,3), (2,2)
        //(0,1), (0,2), (1,2), (1,3)

        public SBlock()
        {
            klocek = new bool[4, 4]
            {
                {false, false, false, false},
                {false, true, true, false},
                {true, true, false, false},
                {false, false, false, false},
            };

            AddColisionPoint(CreateColisionPoint(0, 0, 3));
            AddColisionPoint(CreateColisionPoint(0, 1, 3));
            AddColisionPoint(CreateColisionPoint(0, 2, 2));

            AddColisionPoint(CreateColisionPoint(1, 1, 3));
            AddColisionPoint(CreateColisionPoint(1, 2, 4));

            AddColisionPoint(CreateColisionPoint(2, 1, 3));
            AddColisionPoint(CreateColisionPoint(2, 2, 3));
            AddColisionPoint(CreateColisionPoint(2, 3, 2));

            AddColisionPoint(CreateColisionPoint(3, 1, 2));
            AddColisionPoint(CreateColisionPoint(3, 2, 3));

        }

    }
}
