using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class SpellManager
    {
        public SpellManager()
        {

        }

        public List<Spell> GetAllSpells()
        {
            return SpellDA.GetAllSpells();
        }

        public List<Spell> GetSpellsByLevel(int lvl)
        {
            return SpellDA.GetSpellByLevel(lvl);
        }

        public void AddSpell(Spell s)
        {
            SpellDA.AddSpell(s);
        }

        public void UpdateSpell(Spell s)
        {
            SpellDA.UpdateSpell(s);
        }

        public void DeleteSpell(Spell s)
        {
            SpellDA.DeleteSpell(s);
        }
    }
}
