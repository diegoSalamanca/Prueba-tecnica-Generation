/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public List<InventoryScriptable> inventory = new List<InventoryScriptable>();

    public GameObject ButtonModel;

    public Transform UiLayaoutParent;
    

    public void AddIventoryObject(InventoryScriptable item)
    {

        inventory.Add(item);

        var btn = Instantiate(ButtonModel,UiLayaoutParent);

        btn.GetComponent<InventoryButton>().SetProperties(item);
    }
}
