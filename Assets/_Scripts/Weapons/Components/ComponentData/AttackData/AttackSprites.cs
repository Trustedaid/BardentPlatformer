using System;
using System.Collections;
using UnityEngine;

namespace Trustedaid.Assets._Scripts.Weapons.Components.ComponentData.AttackData
{
     [Serializable]
    public class AttackSprites
    {
        [field: SerializeField] public Sprite[] Sprites { get; private set; }
    }
}