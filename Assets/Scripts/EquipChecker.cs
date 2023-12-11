using UnityEngine;
using UnityEngine.EventSystems;

public class EquipChecker : MonoBehaviour
{
    public GameObject[] EquipCheck;
    public string[] Items;

    private void Awake()
    {
        Equipche();
    }

    public void Equip()
    {
        GameObject gameObject = EventSystem.current.currentSelectedGameObject;
        PlayerPrefs.SetString(gameObject.name, gameObject.name);
    }
    public void Unequip()
    {
        GameObject gameObject = EventSystem.current.currentSelectedGameObject;
        if (PlayerPrefs.HasKey(gameObject.name))
        {
            PlayerPrefs.DeleteKey(gameObject.name);
        }
    }

    public void Equipche()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (PlayerPrefs.HasKey(Items[i]))
            {
                EquipCheck[i].SetActive(true);
            }
            else
            {
                EquipCheck[i].SetActive(false);
            }
        }
    }
    

}
