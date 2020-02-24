using System;
using UnityEngine;

namespace Damdor.Utils
{

    public class Wrapper { }

    [Serializable]
    public class Wrapper<T> : Wrapper, ISerializationCallbackReceiver where T : class
    {
        public Wrapper() { }
        public Wrapper(T value) { Value = value; }
        
        public T Value
        {
            get => value;
            set { this.value = value; UpdateHasValue(); }
        }

        public bool HasValue => hasValue;
        
        [SerializeField] 
        private T value;
       
        [SerializeField]
        [HideInInspector]
        private bool hasValue;

        public void Run(Action<T> action)
        {
            if (HasValue)
            {
                action?.Invoke(Value);
            }
        }

        public void Run<U>(Action<U> action) where U : class
        {
            if (HasValue && Value is U)
            {
                action?.Invoke(Value as U);
            }
        }

        public void OnBeforeSerialize() => UpdateHasValue();
        public void OnAfterDeserialize() { }

        private void UpdateHasValue()
        {
            hasValue = value != null;
        }
        
    }

}