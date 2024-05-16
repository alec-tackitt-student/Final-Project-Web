using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Text))]
public static class License 
{
    public static UnityEvent<object> OnValueChange = new UnityEvent<object>();
    public static Progressbar progressbar;

    public static int points = 0;

    public static Text displayText;

    public static int level = 1;
}
