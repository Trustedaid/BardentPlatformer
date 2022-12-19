using System;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Trustedaid.Assets._Scripts.Weapons.Components.ComponentData.AttackData
{
    [Serializable]
    public class AttackMovement
    {
        [field: SerializeField] public UnityEngine.Vector2 Direction { get; private set; }
        [field: SerializeField] public float Velocity { get; private set; }
    }
}