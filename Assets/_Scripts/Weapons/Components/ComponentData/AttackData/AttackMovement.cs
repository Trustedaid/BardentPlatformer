using System;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

namespace Trustedaid.Weapons.Components
{
    [Serializable]
    public class AttackMovement : AttackData
    {
        [field: SerializeField] public UnityEngine.Vector2 Direction { get; private set; }
        [field: SerializeField] public float Velocity { get; private set; }
    }
}