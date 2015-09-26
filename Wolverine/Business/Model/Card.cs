// <copyright file="Card.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Wolverine
{
    using System;

    public class Card
    {
        private int cardNumber;

        public Card(int number)
        {
            if (number < 0 || number >= 52)
            {
                throw new ArgumentException("Wrong card number");
            }

            cardNumber = number;
        }
    }
}
