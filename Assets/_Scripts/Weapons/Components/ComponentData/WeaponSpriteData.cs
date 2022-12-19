using Trustedaid.Assets._Scripts.Weapons.Components.ComponentData.AttackData;

using UnityEngine;

namespace Trustedaid.Weapons.Components.ComponentData
{
    public class WeaponSpriteData : ComponentData

    {
        [field: SerializeField] public AttackSprites [] AttackData { get; private set; }


    }

}