using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkButton : MonoBehaviour
{
    public ScrollRect scrollRect;
    public GameObject effectPrefab;
    public RectTransform work;

    public void onClick()
    {
        //Debug.Log("Push!3");
        if (effectPrefab != null)
        {
            Instantiate(
               effectPrefab,
               work.transform.position,
               Quaternion.identity
               );
        }
        scrollRect.verticalNormalizedPosition = 0.23f;
    }
}
