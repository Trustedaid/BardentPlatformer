using System;
using UnityEngine;

namespace Trustedaid.Weapons
{
    public class AnimationEventHandler : MonoBehaviour
    {
        public event Action OnFinish;
        private void AnimationFinishedTrigger() => OnFinish?.Invoke(); // ?  essentially doing null check

    }
}