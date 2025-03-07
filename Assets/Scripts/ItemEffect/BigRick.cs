using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;
using Unity.VisualScripting;
using UnityEditor;
using System.Drawing;
using CreatorKitCodeInternal;

public class BigRick : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier strengthMod = new StatSystem.StatModifier();
        strengthMod.Stats.strength = 20;
        return true;
    }
}
