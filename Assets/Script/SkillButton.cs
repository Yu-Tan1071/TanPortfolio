using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    public ScrollRect scrollRect;
    public GameObject effectPrefab;
    public RectTransform skill;

    public void onClick()
    {
        //Debug.Log("Push!2");
        if (effectPrefab != null)
        {
            Instantiate(
               effectPrefab,
               skill.transform.position,
               Quaternion.identity
               );
        }
        scrollRect.verticalNormalizedPosition = 0.47f;
    }
}
