using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TableRowManager : MonoBehaviour
{
    public GameObject rowPrefab;       // Your RowPrefab
    public Transform bodyContent;      // Assign the "Content" GameObject inside BodyScroll

    public void AddRow(string planetName, bool transit, bool radialVelocity, float period, float mass, float radius, bool habitable)
    {
        GameObject newRow = Instantiate(rowPrefab, bodyContent);

        TMP_Text[] columns = newRow.GetComponentsInChildren<TMP_Text>();

        if (columns.Length >= 7)
        {
            columns[0].text = planetName;
            columns[1].text = transit ? "Yes" : "No";
            columns[2].text = radialVelocity ? "Yes" : "No";
            columns[3].text = period.ToString("F2");
            columns[4].text = mass.ToString("F2");
            columns[5].text = radius.ToString("F2");
            columns[6].text = habitable ? "Yes" : "No";
        }
    }
}