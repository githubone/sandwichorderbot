using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder.FormFlow;

namespace SandwichOrderBot.Models
{
    public class SandwichModels
    {
        public enum BreadOptions
        {
            NineGrainWheat,
            NineGrainHoneyOat,
            Italian,
            ItalianHerbsAndCheese,
            Flatbread
        };

        public enum CheeseOptions
        {
            American,
            MontereyCheddar,
            Pepperjack
        };

        public enum LengthOptions
        {
            SixInch,
            FootLong
        };

        public enum SandwichOptions
        {
            BLT,
            BlackForestHam,
            BuffaloChicken,
            ChickenAndBaconRanchMelt,
            ColdCutCombo,
            MeatballMarinara,
            OvenRoastedChicken,
            RoastBeef,
            RotisserieStyleChicken,
            SpicyItalian,
            SteakAndCheese,
            SweetOnionTeriyaki,
            Tuna,
            TurkeyBreast,
            Veggie
        };

        public enum SauceOptions
        {
            ChipotleSouthwest,
            HoneyMustard,
            LightMayonnaise,
            RegularMayonnaise,
            Mustard,
            Oil,
            Pepper,
            Ranch,
            SweetOnion,
            Vinegar
        };

        public enum ToppingOptions
        {
            Avocado,
            BananaPeppers,
            Cucumbers,
            GreenBellPeppers,
            Jalapenos,
            Lettuce,
            Olives,
            Pickles,
            RedOnion,
            Spinach,
            Tomatoes
        };

        [Serializable]
        public class SandwichOrder
        {
            public BreadOptions? Bread;
            public CheeseOptions? Cheese;
            public LengthOptions? Length;
            public SandwichOptions? Sandwich;
            public List<SauceOptions> Sauce;
            public List<ToppingOptions> Toppings;

            public static IForm<SandwichOrder> BuildForm()
            {
                return new FormBuilder<SandwichOrder>()
                    .Message("Welcome to the simple sandwich order bot!")
                    .Build();
            }
        };
    }
}