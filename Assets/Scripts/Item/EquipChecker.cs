using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class EquipChecker : MonoBehaviour
{
    Inven inven;
    public EquipPanel panel;
    public TMP_Text[] epSign;

    public Status status;

    public TMP_Text manPowerTxt;
    public TMP_Text improvisationTxt;
    public TMP_Text healthTxt;
    public TMP_Text speechTxt;

    private void Awake()
    {
        inven = GetComponent<Inven>();
    }
    public void Equip()
    {
        for (int i = 0; i < inven.items.Count; i++)
        {
            if (panel.itema.Name == inven.items[i].Name && inven.items[i].IsEquip == false)
            {
                inven.items[i].IsEquip = true;
                epSign[i].text = "[E]";
                StatUpdate();
                break;
            }
            else { print("이미 장착중입니다."); }
        }
    }

    public void Unequip()
    {
        for (int i = 0; i < inven.items.Count; i++)
        {
            if (panel.itema.Name == inven.items[i].Name && inven.items[i].IsEquip == true)
            {
                inven.items[i].IsEquip = false;
                epSign[i].text = " ";
                StatUpdate();
                break;
            }
            else { print("장착하지 않았습니다."); }
        }
    }

    public void StatUpdate()
    {
        if (panel.itema.IsEquip == true)
        {
            if (panel.itema.itemManpower > 0)
            {
                status.manPower += panel.itema.itemManpower;
                manPowerTxt.text = status.manPower.ToString();
            }
            else if (panel.itema.itemImprovisation > 0)
            {
                status.improvisation += panel.itema.itemImprovisation;
                improvisationTxt.text = status.improvisation.ToString();
            }
            else if (panel.itema.itemHealth > 0)
            {
                status.health += panel.itema.itemHealth;
                healthTxt.text = status.health.ToString();
            }
            else
            {
                status.speech += panel.itema.itemSpeech;
                speechTxt.text = status.speech.ToString();
            }
        }
        else
        {
            if (panel.itema.itemManpower > 0)
            {
                status.manPower -= panel.itema.itemManpower;
                manPowerTxt.text = status.manPower.ToString();
            }
            else if (panel.itema.itemImprovisation > 0)
            {
                status.improvisation -= panel.itema.itemImprovisation;
                improvisationTxt.text = status.improvisation.ToString();
            }
            else if (panel.itema.itemHealth > 0)
            {
                status.health -= panel.itema.itemHealth;
                healthTxt.text = status.health.ToString();
            }
            else
            {
                status.speech -= panel.itema.itemSpeech;
                speechTxt.text = status.speech.ToString();
            }
        }
    }
}
