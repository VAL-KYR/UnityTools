using UnityEngine;
using System.Reflection;
using System;

public class ScriptExposer : MonoBehaviour
{
    public const BindingFlags flags =
        /*BindingFlags.NonPublic | */
        BindingFlags.Public |
        BindingFlags.Instance |
        BindingFlags.Static;

    public void Start()
    {
        //++ Run through Components next

        FieldInfo[] fields = this.GetType().GetFields(flags);
        foreach (FieldInfo fieldInfo in fields)
        {
            Debug.Log("Obj: " + this.name + ", Field: " + fieldInfo.Name);
        }

        PropertyInfo[] properties = this.GetType().GetProperties(flags);
        foreach (PropertyInfo propertyInfo in properties)
        {
            Debug.Log("Obj: " + this.name + ", Property: " + propertyInfo.Name);
        }
    }
}
