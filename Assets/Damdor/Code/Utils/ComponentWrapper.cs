using System;
using System.Collections.Generic;
using UnityEngine;

namespace Damdor.Utils
{

    [Serializable]
    public class ComponentWrapper<T> : ObjectWrapper<T> where T : Component
    {
        public ComponentWrapper() { }
        public ComponentWrapper(T value) :base(value) { }

        public Transform transform => Value.transform;
        public GameObject gameObject => Value.gameObject;

        public string tag
        {
            get => Value.tag;
            set => Value.tag = value;
        }

        public Component GetComponent(Type type) => Value.GetComponent(type);
        public U GetComponent<U>() => Value.GetComponent<U>();
        public Component GetComponent(string type) => Value.GetComponent(type);
        public Component GetComponentInChildren(Type type, bool includeInactive) => Value.GetComponentInChildren(type, includeInactive);
        public Component GetComponentInChildren(Type type) => Value.GetComponentInChildren(type);
        public U GetComponentInChildren<U>(bool includeInactive) => Value.GetComponentInChildren<U>(includeInactive);
        public U GetComponentInChildren<U>() => Value.GetComponentInChildren<U>();
        public Component[] GetComponentsInChildren(Type type, bool includeInactive) => Value.GetComponentsInChildren(type, includeInactive);
        public Component[] GetComponentsInChildren(Type type) => Value.GetComponentsInChildren(type);
        public U[] GetComponentsInChildren<U>(bool includeInactive) => Value.GetComponentsInChildren<U>(includeInactive);
        public void GetComponentsInChildren<U>(bool includeInactive, List<U> result) => Value.GetComponentsInChildren(includeInactive, result);
        public U[] GetComponentsInChildren<U>() => Value.GetComponentsInChildren<U>();
        public void GetComponentsInChildren<U>(List<U> results) => Value.GetComponentsInChildren<U>(results);
        public Component GetComponentInParent(Type type) => Value.GetComponentInParent(type);
        public U GetComponentInParent<U>() => Value.GetComponentInParent<U>();
        public Component[] GetComponentsInParent(Type type, bool includeInactive) => Value.GetComponentsInParent(type, includeInactive);
        public Component[] GetComponentsInParent(Type type) => Value.GetComponentsInParent(type);
        public U[] GetComponentsInParent<U>(bool includeInactive) => Value.GetComponentsInParent<U>(includeInactive);
        public void GetComponentsInParent<U>(bool includeInactive, List<U> results) => Value.GetComponentsInParent(includeInactive, results);
        public U[] GetComponentsInParent<U>() => Value.GetComponentsInParent<U>();
        public Component[] GetComponents(Type type) => Value.GetComponents(type);
        public void GetComponents(Type type, List<Component> results) => Value.GetComponents(type, results);
        public void GetComponents<U>(List<U> results) => Value.GetComponents(results);
        public U[] GetComponents<U>() => Value.GetComponents<U>();

        public bool CompareTag(string tag) => Value.CompareTag(tag);

        public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) => Value.SendMessageUpwards(methodName, value, options);
        public void SendMessageUpwards(string methodName, object value) => Value.SendMessageUpwards(methodName, value);
        public void SendMessageUpwards(string methodName) => Value.SendMessageUpwards(methodName);
        public void SendMessageUpwards(string methodName, SendMessageOptions options) => Value.SendMessageUpwards(methodName, options);
        public void SendMessage(string methodName, object value) => Value.SendMessage(methodName, value);
        public void SendMessage(string methodName) => Value.SendMessage(methodName);
        public void SendMessage(string methodName, object value, SendMessageOptions options) => Value.SendMessage(methodName, value, options);
        public void SendMessage(string methodName, SendMessageOptions options) => Value.SendMessage(methodName, options);
        public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) => Value.BroadcastMessage(methodName, parameter, options);
        public void BroadcastMessage(string methodName, object parameter) => Value.BroadcastMessage(methodName, parameter);
        public void BroadcastMessage(string methodName) => Value.BroadcastMessage(methodName);
        public void BroadcastMessage(string methodName, SendMessageOptions options) => Value.BroadcastMessage(methodName, options);
    }
}