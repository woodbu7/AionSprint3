﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    public static partial class UniverseObjects
    {
        public static List<GameObject> gameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Bag of Gold",
                SpaceTimeLocationId = 2,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "Ruby of Saron",
                SpaceTimeLocationId = 3,
                Description = "A bright red jewel, roughly the size of a robin's egg.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },
            new TravelerObject
            {
                Id = 3,
                Name = "Rotogenic Medicine",
                SpaceTimeLocationId = 3,
                Description = "A wooden box containing a small vial filled with a blue liquid.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = false,
                IsConsumable = true,
                IsVisible = true
            },
            new TravelerObject
            {
                Id = 4,
                Name = "Norlan Document ND-3075",
                SpaceTimeLocationId = 3,
                Description =
                    "Memo: Origin Errata" + "\n" +
                    "Universal Date: 378597" + "\n" +
                    "\n" +
                    "It appears a potential origin for the technology is based on Plenatia 5 in the Star Reach Galaxy.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

        };
    }
}
