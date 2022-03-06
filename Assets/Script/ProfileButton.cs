using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileButton : MonoBehaviour
{
    public ScrollRect scrollRect;
    public GameObject effectPrefab;
    public RectTransform profile;

    public void onClick()
    {
        //Debug.Log("Push!");
        if (effectPrefab != null)
        {
            Instantiate(
               effectPrefab,
               profile.transform.position,
               Quaternion.identity
               );
        }      
        scrollRect.verticalNormalizedPosition = 0.72f;
    }
    
    
}
/*
 
    PROFILE 0.72
    SKILL 0.47
    WORK 0.23
    CONTACT 0   
*/