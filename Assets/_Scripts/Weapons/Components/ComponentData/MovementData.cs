using Trustedaid.Assets._Scripts.Weapons.Components.ComponentData.AttackData;
using UnityEngine;

namespace Trustedaid.Weapons.Components.ComponentData
{
    public class MovementData : ComponentData
    {
        [field: SerializeField] public AttackMovement[] AttackData { get; private set; }
    }
}