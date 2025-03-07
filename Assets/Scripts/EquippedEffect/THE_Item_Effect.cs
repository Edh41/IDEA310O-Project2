using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class THE_Item_Effect : EquipmentItem.EquippedEffect
{
     public override void Equipped(CharacterData user)
     {
          StatSystem.StatModifier defenseMod = new StatSystem.StatModifier();
          defenseMod.Stats.defense = 80;
     }
     
     public override void Removed(CharacterData user)
     {
     
     }
}
