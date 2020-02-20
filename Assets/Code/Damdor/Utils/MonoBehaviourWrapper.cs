using System;
using System.Collections;
using UnityEngine;

namespace Damdor.Utils
{
    
    [Serializable]
    public class MonoBehaviourWrapper<T> : ComponentWrapper<T> where T : MonoBehaviour
    {
        public MonoBehaviourWrapper() { }
        public MonoBehaviourWrapper(T value) : base(value) { }

        public bool IsInvoking() => Value.IsInvoking();
        public void CancelInvoke() => Value.CancelInvoke();
        public void Invoke(string methodName, float time) => Value.Invoke(methodName, time);
        public void InvokeRepeating(string methodName, float time, float repeatRate) => Value.InvokeRepeating(methodName, time, repeatRate);
        public void CancelInvoke(string methodName) => Value.CancelInvoke(methodName);
        public bool IsInvoking(string methodName) => Value.IsInvoking(methodName);
        public Coroutine StartCoroutine(string methodName) => Value.StartCoroutine(methodName);
        public Coroutine StartCoroutine(string methodName, object value) => Value.StartCoroutine(methodName, value);
        public Coroutine StartCoroutine(IEnumerator routine) => Value.StartCoroutine(routine);
        public void StopCoroutine(IEnumerator routine) => Value.StopCoroutine(routine);
        public void StopCoroutine(Coroutine routine) => Value.StopCoroutine(routine);
        public void StopCoroutine(string methodName) => Value.StopCoroutine(methodName);
        public void StopAllCoroutines() => Value.StopAllCoroutines();

        public bool useGUILayout
        {
            get => Value.useGUILayout;
            set => Value.useGUILayout = value;
        }

        public bool runInEditMode
        {
            get => Value.runInEditMode;
            set => Value.runInEditMode = value;
        }
        
    }
    
    public class MonoBehaviourWrapper : MonoBehaviourWrapper<MonoBehaviour> { }

}