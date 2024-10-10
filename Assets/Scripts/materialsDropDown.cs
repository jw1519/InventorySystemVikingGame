using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class materialsDropDown : MonoBehaviour
{
    public Dropdown dropDown;
    // Start is called before the first frame update
    void Start()
    {
        // Add options to the dropdown programmatically
        List<string> newOptions = new List<string> { "Option A", "Option B", "Option C" };
        dropDown.options.Clear();
        dropDown.AddOptions(newOptions);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
