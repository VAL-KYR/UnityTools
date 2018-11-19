using UnityEngine;
using System.Reflection;
using System;

public class ScriptExposer : MonoBehaviour
{
    // https://answers.unity.com/questions/252903/c-reflection-get-all-public-variables-from-custom.html
    // https://answers.unity.com/questions/1333022/how-to-get-every-public-variables-from-a-script-in.html

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
