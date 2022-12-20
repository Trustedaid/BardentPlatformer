using System;
using System.Collections;
using UnityEngine;

namespace Trustedaid.Weapons.Components
{
     [Serializable]
    public class AttackSprites : AttackData
    {
        [field: SerializeField] public Sprite[] Sprites { get; private set; }
    }
}