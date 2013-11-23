﻿/*
 *   Nitrogen - Halo Content API
 *   Copyright (c) 2013 Matt Saville and Aaron Dierking
 * 
 *   This file is part of Nitrogen.
 *
 *   Nitrogen is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   Nitrogen is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with Nitrogen.  If not, see <http://www.gnu.org/licenses/>.
 */

using Nitrogen.Core.IO;
using System;

namespace Nitrogen.Halo4.ContentData.GameVariants.BaseVariant
{
    public class MapOverrides
        : ISerializable<BitStream>
    {


        #region ISerializable<BitStream>

        public void Serialize(BitStream stream)
        {
            /*Register<bool>("IndestructibleVehicles");
             Register<bool>("TurretsOnMap");
             Register<bool>("PowerupsOnMap");
             Register<bool>("ArmorAbilitiesOnMap");
             Register<bool>("ShortcutsOnMap");
             Register<bool>("GrenadesOnMap");
             Group("BasePlayerTraits", () => Import<Halo4.Shared.Halo4TraitSet>());
             Register<sbyte>("WeaponSet");
             Register<sbyte>("VehicleSet");
             Register<sbyte>("ArmorAbilitySet");
            
            
             Action<string> powerup = (string name) =>
             {
                 Group(name, () =>
                 {
                     Group("AlphaPhaseTraits", () => {
                         Import<Halo4.Shared.Halo4TraitSet>();
                         Register<byte>("Duration", n: 7);
                     });
                     Group("BetaPhaseTraits", () =>
                     {
                         Import<Halo4.Shared.Halo4TraitSet>();
                         Register<byte>("Duration", n: 7);
                     });
                 });
             };

             powerup("DamageBoost");
             powerup("SpeedBoost");
             powerup("Overshield");
             powerup("Custom");*/
        }

        #endregion
    }
}