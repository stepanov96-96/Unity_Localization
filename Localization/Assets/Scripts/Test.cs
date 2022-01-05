using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private LocalizedDropDown dropDown;
    [SerializeField]
    private LocalizedText text;

    public void LocalizedText()
    {
        text.Localize("Text2_key");
    }

    public void LocalizedDropdown() 
    {
        var options = new List<string>() { "Blue_key", "Green_key", "Green_key", "Black_key" };
        dropDown.Localize(options);
    }
}
