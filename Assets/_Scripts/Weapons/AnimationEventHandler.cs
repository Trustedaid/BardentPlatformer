using System;
using UnityEngine;

namespace Trustedaid.Weapons
{
    public class AnimationEventHandler : MonoBehaviour
    {
        public event Action OnFinish;
        public event Action OnStartMovement;
        public event Action OnStopMovement;

        private void AnimationFinishedTrigger() => OnFinish?.Invoke(); // ?  essentially doing null check
        private void StartMovementTrigger() => OnStartMovement?.Invoke();
        private void StopMovementTrigger() => OnStopMovement?.Invoke();
    }
}