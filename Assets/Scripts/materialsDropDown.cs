using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class materialsDropDown : MonoBehaviour
{
    public Dropdown dropDown;
    public int WoodAmount = 0;
    public int StoneAmount = 0;
    public int IronAmount = 0;
    public int MaxAmount = 100; //can change when more storage is built

    void Start()
    {
        // Add options to the dropdown programmatically
        List<string> newOptions = new List<string> { $"Wood {WoodAmount}/{MaxAmount}", $"Stone {StoneAmount}/{MaxAmount}", $"Iron {StoneAmount}/{MaxAmount}" };
        dropDown.options.Clear();
        dropDown.AddOptions(newOptions);
    }
}
