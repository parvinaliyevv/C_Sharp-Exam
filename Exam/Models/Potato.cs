﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Exam.Models
{
    [Serializable]
    public sealed class Potato : Vegetable
    {
        [NonSerialized]
        public const string name = nameof(Potato);

        [NonSerialized]
        public const double price = 0.40;
        public override double Price { get { return price; } }

        private static List<int> _ratings = new();
        public static int AverageRating
        {
            get { return (_ratings.Sum() / ((_ratings.Count != 0) ? _ratings.Count : 1)); }
            set
            {
                if (value > 2 & value < 11) _ratings.Add(value);
                else throw new ArgumentOutOfRangeException(nameof(value), "The rating of vegetables cannot be less than two and more than ten!");
            }
        }

        public Potato() { }
        public Potato(VegetableStatus status) : base(status) { }
    }
}
