using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class WeaponManager
    {
        public WeaponManager()
        {

        }

        public List<Weapon> GetAllWeapons()
        {
            return WeaponDA.GetsAllWeapons();
        }

        public List<Weapon> GetsWeaponsByLevel(int lvl)
        {
            return WeaponDA.GetWeaponByLevel(lvl);
        }

        public void AddsWeapon(Weapon w)
        {
            WeaponDA.AddsWeapon(w);
        }

        public void UpdateWeapon(Weapon w)
        {
            WeaponDA.UpdatesWeapon(w);
        }

        public void DeleteWeapon(Weapon w)
        {
            WeaponDA.DeletesWeapon(w);
        }
    }
}
