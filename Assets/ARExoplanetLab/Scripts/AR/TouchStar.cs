using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace extOSC.Examples
{
    public class TouchStar : MonoBehaviour
    {
        private int starLayer;

        public string Address;

        [Header("OSC Settings")]
        public OSCTransmitter Transmitter;


        public GameObject MainPanel;

        public TMP_Text StarNameText;
        public TMP_Text SizeText;
        public TMP_Text TypeText;
        public TMP_Text LumonisityText;
        public TMP_Text DistanceText;

        public TMP_Text TransitTitleText;
        public TMP_Text RVTitleText;
        public TMP_Text CatalogTitleText;

        public UIHandler uiHandler;
        private string currentStarName = "";

        public GenerateStars generateStars;


        void Start()
        {
            starLayer = LayerMask.GetMask("Stars");
            Address = "/Star";
        }


        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000000, starLayer) && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Found an object - distance: " + hit.distance);
                if (hit.transform.GetComponent<StarComp>() != null)
                {
                    Debug.Log(hit.transform.GetComponent<StarComp>().starName);
                    currentStarName = hit.transform.GetComponent<StarComp>().starName;
                    StarNameText.text = hit.transform.GetComponent<StarComp>().starName;
                    SizeText.text = "Radius: " + hit.transform.GetComponent<StarComp>().radius + " R Sun";
                    TypeText.text = "Type: " + hit.transform.GetComponent<StarComp>().type;
                    LumonisityText.text = "Luminosity: " + hit.transform.GetComponent<StarComp>().luminosity + " L Sun";
                    DistanceText.text = "Distance from Earth: " + hit.transform.GetComponent<StarComp>().distance + " pc";

                    TransitTitleText.text = hit.transform.GetComponent<StarComp>().starName + " LIGHT CURVE";
                    RVTitleText.text = hit.transform.GetComponent<StarComp>().starName + " RADIAL VELOCITY CURVE";
                    CatalogTitleText.text = hit.transform.GetComponent<StarComp>().starName + " PLANET CATALOG";

                    // change to switch case
                    if (string.Equals(hit.transform.GetComponent<StarComp>().type, "Main Sequence"))
                    {
                        uiHandler.isMainSequence = true;
                    }
                    else
                    {
                        uiHandler.isMainSequence = false;
                    }

                    uiHandler.ToggleMainPanel(true);
                }
                Debug.Log("Hit something!");

            }

            // if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
            //     Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
            //     RaycastHit hit;
            //     if (Physics.Raycast (ray, out hit, 10000, starLayer)) {
            //         Debug.Log("Found an object - distance: " + hit.distance);
            //         if(hit.transform.GetComponent<StarComp>() != null)
            //         {
            //             Debug.Log(hit.transform.GetComponent<StarComp>().starName);
            //             StarNameText.text = hit.transform.GetComponent<StarComp>().starName;
            //         }
            //         Debug.Log("Hit something!");
            //     }
            // }
        }

        public void HitSubmit()
        {
            Debug.Log("Sending OSC for: " + currentStarName);
            var message = new OSCMessage(Address);
            message.AddValue(OSCValue.String(currentStarName));
            Transmitter.Send(message);

            generateStars.changeColor(currentStarName);
        }
    }
    
}

