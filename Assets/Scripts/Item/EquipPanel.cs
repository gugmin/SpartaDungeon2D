using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;
using static UnityEditor.Progress;

public class EquipPanel : MonoBehaviour
{
    public Items itema;
    public Item _item;
    public GameObject choiceItem;
    public GameObject itemPanel;
    public Image itemImage;
    public TMP_Text ItemName;
    public TMP_Text info;
    public Image statImage;
    public TMP_Text itemStatName;
    public TMP_Text itemStat;
    public TMP_Text addItemstat;
    public TMP_Text eqText;

    public void SelectItem()
    {
        itemPanel.SetActive(true);

        choiceItem = EventSystem.current.currentSelectedGameObject;

        foreach (var item in _item.inven.items)
        {
            if (choiceItem.name == item.name)
            {
                itema = item;
            }
        }

        itemImage.sprite = itema.itemImage;
        ItemName.text = itema.Name;
        statImage.sprite = itema.itemStatImage;
        itemStatName.text = itema.statName;
        info.text = itema.info;
        //임시세팅
        if (itema.itemManpower > 0)
        {
            addItemstat.text = itema.itemManpower.ToString();
        }
        else if (itema.itemImprovisation > 0)
        {
            addItemstat.text = itema.itemImprovisation.ToString();
        }
        else if (itema.itemHealth > 0)
        {
            addItemstat.text = itema.itemHealth.ToString();
        }
        else
        {
            addItemstat.text = itema.itemSpeech.ToString();
        }

        if (itema.IsEquip == true)
        {
            eqText.text = "장착 해제 하시겠습니까?";
        }
        else
        {
            eqText.text = "장착 하시겠습니까?";
        }
    }
}
