﻿// -------------------------------------------------------------------------------------------------
// MathGame.Models.Game
// -------------------------------------------------------------------------------------------------
// Represents both a Game object and a Game database entity.
// -------------------------------------------------------------------------------------------------
using MathGame.Enums;
using SQLite;

namespace MathGame.Models
{
    [Table("Game")]
    public class Game
    {
        #region Properties

        [PrimaryKey, AutoIncrement, Column("Id")]
        public int Id { get; set; }

        public GameType Type { get; set; }

        public int Score { get; set; }

        public DateTime DatePlayed { get; set; }

        public GameDifficulty Difficulty { get; set; }

        public double TimeTakenInSeconds { get; set; }

        #endregion
    }
}
