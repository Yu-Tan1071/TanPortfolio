using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContactButton : MonoBehaviour
{
    public ScrollRect scrollRect;
    public GameObject effectPrefab;
    public RectTransform contact;

    public void onClick()
    {
        //Debug.Log("Push!4");
        if (effectPrefab != null)
        {
            Instantiate(
               effectPrefab,
               contact.transform.position,
               Quaternion.identity
               );
        }
        scrollRect.verticalNormalizedPosition = 0.0f;
    }
}
