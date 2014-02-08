﻿using System;

namespace DataModel.Football
{
    [Serializable]
    public class PlayerRanking
    {
        public string PlayerName { get; set; }
        public string Image { get; set; }
        public int Rank { get; set; }
        public string Goal { get; set; }
        public string Match { get; set; }
    }
}