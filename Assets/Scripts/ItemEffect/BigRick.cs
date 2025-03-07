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
        return true;
    }
}
