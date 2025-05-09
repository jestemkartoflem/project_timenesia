using System.Collections.Generic;
using _2_Scripts.Model;
using _2_Scripts.Player;

namespace _2_Scripts.Global.SaveSystem.Player
{
    public class PlayerAbilitiesAndStats
    {
        #region ABILITIES
        public Dictionary<AbilityName, bool> abilities = new();
        #endregion

        #region BASE_STATS
        public int MaxHealth { get; set; }
        //public int CurrentConcentrationSlots { get; set; }
        //public int MaxConcentrationSlots { get; set; } //unused for now.
        public int MaxEffort { get; set; }
        public int SpellCapacity { get; set; }
        #endregion

        #region CURRENCIES
        //might get moved to some other class. There is no need to provide this to classes like movementController.
        public int Coins { get; set; }
        #endregion

        public void UnlockAbility(AbilityName abilityName)
        {
            abilities.Add(abilityName, true);
        }

        public bool GetAbilityFlag(AbilityName abilityName)
        {
            return abilities.GetValueOrDefault(abilityName, false);
        }
    }
}
