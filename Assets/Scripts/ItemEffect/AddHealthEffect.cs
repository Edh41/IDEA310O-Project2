using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HealthAdd;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HealthAdd);
        return true;
    }
}
