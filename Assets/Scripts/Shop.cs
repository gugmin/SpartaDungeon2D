using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shop : MonoBehaviour
{
    public GameObject[] shopItem;

    public void BuyShopItem()
    {
        GameObject gameObject = EventSystem.current.currentSelectedGameObject;
        for (int i = 0; i < shopItem.Length; i++)
        {

        }
    }



}
