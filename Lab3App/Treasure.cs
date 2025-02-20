﻿using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }
        protected Treasure(string description, int score) : base(description)
        {
            Score += score;
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            Board.UpdateTotalScore(Score);


        }

    }
}

