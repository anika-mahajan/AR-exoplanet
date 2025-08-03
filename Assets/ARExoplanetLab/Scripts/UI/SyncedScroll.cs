using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyncedScroll : MonoBehaviour
{
    [SerializeField]
    public ScrollRect headerScroll;
    [SerializeField]
    public ScrollRect bodyScroll;

    void Start()
    {
        bodyScroll.onValueChanged.AddListener(OnBodyScroll);
    }

    void OnBodyScroll(Vector2 pos)
    {
        Vector2 headerPos = headerScroll.normalizedPosition;
        headerPos.x = pos.x;
        headerScroll.normalizedPosition = headerPos;
    }
}
