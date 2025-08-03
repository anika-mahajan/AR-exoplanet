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

    public GameObject TablePanel;

    public GameObject MainStarMainPanelImg;
    public GameObject RedStarMainPanelImg;

    public GameObject MainStarTransitPanelImg;
    public GameObject RedStarTransitPanelImg;

    public GameObject MainStarRVPanelImg;
    public GameObject RedStarRVPanelImg;

    public GameObject MainStarCatalogPanelImg;
    public GameObject RedStarCatalogPanelImg;

    public bool isMainSequence;

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
        TablePanel.SetActive(false);

        if (isMainSequence)
        {
            MainStarMainPanelImg.SetActive(true);
            RedStarMainPanelImg.SetActive(false);
        }
        else
        {
            MainStarMainPanelImg.SetActive(false);
            RedStarMainPanelImg.SetActive(true);
        }
    }
    public void ToggleTransitPanel(bool state) {
        // Debug.Log(state);
        MainPanel.SetActive(false);
        TransitPanel.SetActive(true);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);
        TablePanel.SetActive(false);

        if (isMainSequence)
        {
            MainStarTransitPanelImg.SetActive(true);
            RedStarTransitPanelImg.SetActive(false);
        }
        else
        {
            MainStarTransitPanelImg.SetActive(false);
            RedStarTransitPanelImg.SetActive(true);
        }
    }
    public void ToggleRVPanel(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(true);
        CatalogPanel.SetActive(false);
        TablePanel.SetActive(false);

        if (isMainSequence)
        {
            MainStarRVPanelImg.SetActive(true);
            RedStarRVPanelImg.SetActive(false);
        }
        else
        {
            MainStarRVPanelImg.SetActive(false);
            RedStarRVPanelImg.SetActive(true);
        }
    }
    public void ToggleCatalogPanel(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(true);
        TablePanel.SetActive(false);

        if (isMainSequence)
        {
            MainStarCatalogPanelImg.SetActive(true);
            RedStarCatalogPanelImg.SetActive(false);
        }
        else
        {
            MainStarCatalogPanelImg.SetActive(false);
            RedStarCatalogPanelImg.SetActive(true);
        }
    }

    public void ToggleTablePanel(bool state) {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);
        TablePanel.SetActive(true);

        // if (isMainSequence)
        // {
            MainStarCatalogPanelImg.SetActive(false);
            RedStarCatalogPanelImg.SetActive(false);
        // }
        // else
        // {
        //     MainStarCatalogPanelImg.SetActive(false);
        //     RedStarCatalogPanelImg.SetActive(true);
        // }
    }

    public void TogglePanels(bool state)
    {
        MainPanel.SetActive(false);
        TransitPanel.SetActive(false);
        RVPanel.SetActive(false);
        CatalogPanel.SetActive(false);
        TablePanel.SetActive(false);
    }
}
