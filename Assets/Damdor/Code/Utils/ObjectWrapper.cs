using System;

namespace Damdor.Utils
{
    
    [Serializable]
    public class ObjectWrapper<T> : Wrapper<T> where T : UnityEngine.Object
    {
        public ObjectWrapper() { }
        public ObjectWrapper(T value) : base(value) { }


        public string name
        {
            get => Value.name;
            set => Value.name = value;
        }


        public int GetInstanceID() => Value.GetInstanceID();
        public override int GetHashCode() => Value.GetHashCode();
        public override string ToString() => Value.ToString();
        
        public static implicit operator bool(ObjectWrapper<T> exists) => exists.HasValue;

    }

}