using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    public GameObject OriginButton;
    public GameObject ToggleButton;

    public GameObject MainPanel;
    public GameObject TransitPanel;
    public GameObject RVPanel;
    public GameObject CatalogPanel;

    public GameObject MainStarMainPanel;
    public GameObject RedStarMainPanel;

    public GameObject MainStarTransitPanel;
    public GameObject RedStarTransitPanel;

    public GameObject MainStarRVPanel;
    public GameObject RedStarRVPanel;

    public GameObject MainStarCatalogPanel;
    public GameObject RedStarCatalogPanel;

    public bool isMainSequence;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleButtons(bool state) {
        OriginButton.SetActive(!state);
        ToggleButton.SetActive(!state);
    }

    public void ToggleMainPanel(bool state) {
        // Debug.Log(state);
        MainPanel.SetActive(true);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);

        if(isMainSequence) {
            MainStarMainPanel.SetActive(true);
            RedStarMainPanel.SetActive(false);
        } else {
            MainStarMainPanel.SetActive(false);
            RedStarMainPanel.SetActive(true);
        }
    }
    public void ToggleTransitPanel(bool state) {
        // Debug.Log(state);
        MainPanel.SetActive(false);
        TransitPanel.SetActive(true);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);

        if(isMainSequence) {
            MainStarTransitPanel.SetActive(true);
            RedStarTransitPanel.SetActive(false);
        } else {
            MainStarTransitPanel.SetActive(false);
            RedStarTransitPanel.SetActive(true);
        }
    }
    public void ToggleRVPanel(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(true);
        CatalogPanel.SetActive(false);

        if(isMainSequence) {
            MainStarRVPanel.SetActive(true);
            RedStarRVPanel.SetActive(false);
        } else {
            MainStarRVPanel.SetActive(false);
            RedStarRVPanel.SetActive(true);
        }
    }
    public void ToggleCatalogPanel(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(true);

        if(isMainSequence) {
            MainStarCatalogPanel.SetActive(true);
            RedStarCatalogPanel.SetActive(false);
        } else {
            MainStarCatalogPanel.SetActive(false);
            RedStarCatalogPanel.SetActive(true);
        }
    }
    public void TogglePanels(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);
    }
}
