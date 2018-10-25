using System;
using Microsoft.ML.Runtime.Api;

namespace CarApp
{
    public class CarsTrainingDataModel
    {
        // Input attribute
        [Column("0")]
        public string BuyingPriceLevel;

        // Input attribute
        [Column("1")]
        public string MaintenancePriceLevel;

        // Input attribute
        [Column("2")]
        public string NumberOfDoor;

        // Input attribute
        [Column("3")]
        public string NumberOfPeople;

        // Input attribute
        [Column("4")]
        public string LuggageSize;

        // Input attribute
        [Column("5")]
        public string SafetyLevel;

        // Output
        [Column("6")]
        [ColumnName("Label")]
        public string Label;
    }
}
