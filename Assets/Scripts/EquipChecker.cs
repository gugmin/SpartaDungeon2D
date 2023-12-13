using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class EquipChecker : MonoBehaviour
{
    Inven Inven;
    public TMP_Text[] epSign;
    public void Equip()
    {
        for (int i = 0; i < Inven.items.Count; i++)
        {
            if (Inven.items[i].IsEquip == false)
            {
                Inven.items[i].IsEquip = true;
                epSign[i].text = "[E]";
            }
            else { print("이미 장착중입니다."); }
        }
    }

    public void Unequip()
    {
        for (int i = 0; i < Inven.items.Count; i++)
        {
            if (Inven.items[i].IsEquip == true)
            {
                Inven.items[i].IsEquip = false;
                epSign[i].text = " ";
            }
            else { print("장착하지 않았습니다."); }
        }
    }



}
