using System;
using System.Collections.Generic;

namespace FCManager.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly DateOfBirth { get; private set; }
        public List<Position> Positions { get; private set; }
        public int ShirtNumber { get; private set; }
        public string Nationality { get; private set; }

        public List<Contract> Contracts { get; private set; }
        public List<Card> Cards { get; private set; }
        public PlayerStatistics Statistics { get; private set; }

        // EF Core constructor
        private Player() { }

        public Player(
            string firstName,
            string lastName,
            DateOnly dateOfBirth,
            IEnumerable<Position> positions,
            int shirtNumber,
            string nationality)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Positions = new List<Position>(positions);
            ShirtNumber = shirtNumber;
            Nationality = nationality;
            Contracts = new List<Contract>();
            Cards = new List<Card>();
            Statistics = new PlayerStatistics();
        }

        public void AddPosition(Position position)
        {
            if (!Positions.Contains(position))
                Positions.Add(position);
        }

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void UpdateStatistics(int goals, int assists, int minutesPlayed)
        {
            Statistics.Goals += goals;
            Statistics.Assists += assists;
            Statistics.MinutesPlayed += minutesPlayed;
        }
    }

    public record Position(string Name);

    public class PlayerStatistics
    {
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int MinutesPlayed { get; set; }
        // Mo¿esz dodaæ inne statystyki wed³ug potrzeb
    }

    // Przyk³adowe szkielety powi¹zanych encji:
    public class Contract
    {
        public Guid Id { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public decimal Salary { get; private set; }
        public ContractStatus Status { get; private set; }
        // ...
    }

    public enum ContractStatus
    {
        Active,
        Ended,
        Archived
    }

    public class Card
    {
        public Guid Id { get; private set; }
        public CardType Type { get; private set; }
        public DateOnly Date { get; private set; }
        public string Reason { get; private set; }
        public CardStatus Status { get; private set; }
        // ...
    }

    public enum CardType
    {
        Yellow,
        Red
    }

    public enum CardStatus
    {
        Served,
        NotServed
    }
}
