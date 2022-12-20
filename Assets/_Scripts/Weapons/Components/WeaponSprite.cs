using System;
using Trustedaid.Weapons.Components;
using UnityEngine;

namespace Trustedaid.Weapons.Components
{
    public class WeaponSprite : WeaponComponent<WeaponSpriteData, AttackSprites>
    {
        private SpriteRenderer baseSpriteRenderer;
        private SpriteRenderer weaponSpriteRenderer;


        private int currentWeaponSpriteIndex;


        protected override void HandleEnter()
        {
            base.HandleEnter();
            currentWeaponSpriteIndex = 0;
        }


        private void HandleBaseSpriteChange(SpriteRenderer sr)
        {
            if (!isAttackActive)
            {
                weaponSpriteRenderer.sprite = null;

                return;
            }

            var currentAttackSprites = currentAttackData.Sprites;

            if (currentWeaponSpriteIndex >= currentAttackSprites.Length)
            {
                Debug.LogWarning($"{weapon.name} weapon sprites length mismatch");
                return; // 24.09
            }

            weaponSpriteRenderer.sprite = currentAttackSprites[currentWeaponSpriteIndex];

            currentWeaponSpriteIndex++;
        }


        protected override void Awake()
        {
            base.Awake();
            baseSpriteRenderer = transform.Find("Base").GetComponent<SpriteRenderer>();
            weaponSpriteRenderer = transform.Find("WeaponSprite").GetComponent<SpriteRenderer>();

            data = weapon.Data.GetData<WeaponSpriteData>();

            // TODO: Fix this when we create weapon data! 
            //baseSpriteRenderer = weapon.BaseGameObject.GetComponent<SpriteRenderer>();
            //weaponSpriretRenderer = weapon.WeaponSpriteGameObject.GetComponent<SpriteRenderer>();
        }


        protected override void OnEnable()
        {
            base.OnEnable();
            baseSpriteRenderer.RegisterSpriteChangeCallback(HandleBaseSpriteChange);

            weapon.OnEnter += HandleEnter;
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            baseSpriteRenderer.UnregisterSpriteChangeCallback(HandleBaseSpriteChange);

            weapon.OnEnter -= HandleEnter;
        }
    }
}