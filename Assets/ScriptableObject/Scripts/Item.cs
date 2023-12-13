using UnityEngine;

public class Item : MonoBehaviour
{
    public Inven inven;

    public Items mic;
    public Items coconut;
    public Items axe;
    public Items pickaxe;
    public Items qltwkfn;


    void Awake()
    {
        inven.AddItem(mic);
        inven.AddItem(coconut);
        inven.AddItem(axe);
        inven.AddItem(pickaxe);
        inven.AddItem(qltwkfn);
    }

}
