﻿using System.Runtime.Serialization;

namespace ARKBreedingStats.species
{
    [DataContract]
    public class CreatureStat
    {
        public StatNames Stat;
        public double BaseValue;
        public double IncPerWildLevel;
        public double IncPerTamedLevel;
        public double AddWhenTamed;
        public double MultAffinity; // used with taming effectiveness

        public CreatureStat(StatNames s) { Stat = s; }

    }

    public enum StatNames
    {
        Health = 0,
        Stamina = 1,
        Torpidity = 2,
        Oxygen = 3,
        Food = 4,
        Water = 5,
        Temperature = 6,
        Weight = 7,
        MeleeDamageMultiplier = 8,
        SpeedMultiplier = 9,
        TemperatureFortitude = 10,
        CraftingSpeedMultiplier = 11
    }
}
