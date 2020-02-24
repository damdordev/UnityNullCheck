using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Damdor.Utils
{
    [Serializable]
    public class GameObjectWrapper : ObjectWrapper<GameObject>
    {
        public GameObjectWrapper() { }

        public GameObjectWrapper(GameObject value) : base(value) { }

        public bool activeSelf => Value.activeSelf;
        public bool activeInHierarchy => Value.activeInHierarchy;
        public Transform transform => Value.transform;
        public Scene scene => Value.scene;
        public GameObject gameObject => Value.gameObject;
        
        public int layer
        {
            get => Value.layer;
            set => Value.layer = value;
        }

        public bool isStatic
        {
            get => Value.isStatic;
            set => Value.isStatic = value;
        }

        public string tag
        {
            get => Value.tag;
            set => Value.tag = value;
        }

        
        public T GetComponent<T>() => Value.GetComponent<T>();
        public Component GetComponent(System.Type type) => Value.GetComponent(type);
        public Component GetComponent(string type) => Value.GetComponent(type);
        public Component GetComponentInChildren(System.Type type, bool includeInactive) => Value.GetComponentInChildren(type, includeInactive);
        public Component GetComponentInChildren(System.Type type) => Value.GetComponentInChildren(type);
        public T GetComponentInChildren<T>() => Value.GetComponentInChildren<T>();
        public T GetComponentInChildren<T>(bool includeInactive) => Value.GetComponentInChildren<T>(includeInactive);
        public Component GetComponentInParent(System.Type type) => Value.GetComponentInParent(type);
        public T GetComponentInParent<T>() => Value.GetComponentInParent<T>();
        public Component[] GetComponents(System.Type type) => Value.GetComponents(type);
        public T[] GetComponents<T>() => Value.GetComponents<T>();
        public void GetComponents(System.Type type, List<Component> results) => Value.GetComponents(type, results);
        public void GetComponents<T>(List<T> results) => Value.GetComponents<T>(results);
        public Component[] GetComponentsInChildren(System.Type type) => Value.GetComponentsInChildren(type);
        public Component[] GetComponentsInChildren(System.Type type, bool includeInactive) => Value.GetComponentsInChildren(type, includeInactive);
        public T[] GetComponentsInChildren<T>(bool includeInactive) => Value.GetComponentsInChildren<T>(includeInactive);
        public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) => Value.GetComponentsInChildren<T>(includeInactive, results);
        public T[] GetComponentsInChildren<T>() => Value.GetComponentsInChildren<T>();
        public void GetComponentsInChildren<T>(List<T> results) => Value.GetComponentsInChildren(results);
        public Component[] GetComponentsInParent(System.Type type) => Value.GetComponentsInParent(type);
        public Component[] GetComponentsInParent(System.Type type, bool includeInactive) => Value.GetComponentsInParent(type, includeInactive);
        public void GetComponentsInParent<T>(bool includeInactive, List<T> results) => Value.GetComponentsInParent<T>(includeInactive, results);
        public T[] GetComponentsInParent<T>(bool includeInactive) => Value.GetComponentsInParent<T>(includeInactive);
        public T[] GetComponentsInParent<T>() => Value.GetComponentsInParent<T>();
        public void SendMessageUpwards(string methodName, SendMessageOptions options) => Value.SendMessageUpwards(methodName, options);
        public void SendMessage(string methodName, SendMessageOptions options) => Value.SendMessage(methodName, options);
        public void BroadcastMessage(string methodName, SendMessageOptions options) => Value.BroadcastMessage(methodName, options);
        public Component AddComponent(System.Type componentType) => Value.AddComponent(componentType);
        public T AddComponent<T>() where T : Component => Value.AddComponent<T>();
        public void SetActive(bool value) => Value.SetActive(value);
        public bool CompareTag(string tag) => Value.CompareTag(tag);
        public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) => Value.SendMessageUpwards(methodName, value, options);
        public void SendMessageUpwards(string methodName, object value) => Value.SendMessageUpwards(methodName, value);
        public void SendMessageUpwards(string methodName) => Value.SendMessageUpwards(methodName);
        public void SendMessage(string methodName, object value, SendMessageOptions options) => Value.SendMessage(methodName, value, options);
        public void SendMessage(string methodName, object value) => Value.SendMessage(methodName, value);
        public void SendMessage(string methodName) => Value.SendMessage(methodName);
        public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) => Value.BroadcastMessage(methodName, parameter, options);
        public void BroadcastMessage(string methodName, object parameter) => Value.BroadcastMessage(methodName, parameter);
        public void BroadcastMessage(string methodName) => Value.BroadcastMessage(methodName);

        public void WithComponent<T>(Action<T> action)
        {
            if (!HasValue || action == null)
            {
                return;
            }

            var component = Value.GetComponent<T>();
            if (component != null)
            {
                action(component);
            }
        }

    }
}