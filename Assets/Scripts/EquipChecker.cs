using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class EquipChecker : MonoBehaviour
{
    Inven inven;
    public EquipPanel panel;
    public TMP_Text[] epSign;
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
            }
            else { print("�̹� �������Դϴ�."); }
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
            }
            else { print("�������� �ʾҽ��ϴ�."); }
        }
    }
}
