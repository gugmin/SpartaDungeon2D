using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class EquipPanel : MonoBehaviour
{
    public TMP_Text eqText;

    public void EquipText()
    {
        GameObject gameObject = EventSystem.current.currentSelectedGameObject;
        if (PlayerPrefs.HasKey(gameObject.name))
        {
            eqText.text = "���� ���� �Ͻðڽ��ϱ�?";
        }
        else
        {
            eqText.text = "���� �Ͻðڽ��ϱ�?";
        }
        
    }
}
