using UnityEditor;
using UnityEngine;

namespace Damdor.Utils.Editor
{
    [CustomPropertyDrawer(typeof(Wrapper), true)]
    public class WrapperPropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(GetValueProperty(property));
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, GetValueProperty(property), GUIContent.none);
            
        }
        
        private SerializedProperty GetValueProperty(SerializedProperty property) => property.FindPropertyRelative("value");
        
    }
}