using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatalogManager : MonoBehaviour
{
    public TableRowManager tableRowManager;

    public TMP_InputField periodField;
    public TMP_InputField massField;
    public TMP_InputField distanceField;

    public TMP_Dropdown planetDropdown;
    public TMP_Dropdown habitableDropdown;

    public string starName;
    public bool transit;
    public bool rv;


    public void OnSubmitButtonClicked()
    {
        bool habitable = habitableDropdown.value == 0;

        // Parse float values safely
        float period = float.TryParse(periodField.text, out float p) ? p : 0f;
        float mass = float.TryParse(massField.text, out float m) ? m : 0f;
        float distance = float.TryParse(distanceField.text, out float r) ? r : 0f;

        if (planetDropdown.value == 0)
        {
            tableRowManager.AddRow(starName + " b", transit, rv, period, mass, distance, habitable);
        }

        
    }
}
