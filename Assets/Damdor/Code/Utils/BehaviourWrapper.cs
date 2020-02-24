using System;
using System.Collections.Generic;
using UnityEngine;

namespace Damdor.Utils
{

    [Serializable]
    public class BehaviourWrapper<T> : ComponentWrapper<T> where T : Behaviour
    {
        public BehaviourWrapper() {}
        public BehaviourWrapper(T value) : base(value) {}
        
        public bool enabled
        {
            get => Value.enabled;
            set => Value.enabled = value;
        }

        public bool isActiveAndEnabled => Value.isActiveAndEnabled;
    }
}