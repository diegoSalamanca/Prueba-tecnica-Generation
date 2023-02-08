/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using UnityEngine;

public class InventoryObject : MonoBehaviour
{
    public InventoryScriptable inventoryScriptable;

    bool avaible = true;

    private void Start() {
        
        Instantiate(inventoryScriptable.model3D, transform);
    }   

    private void FixedUpdate() {
        
        transform.Rotate(Vector3.up*1.2f, Space.Self);
    } 

    public void AddToInventory()
    {
        if(avaible)
        {
            FindObjectOfType<GameManager>().messageManager.SetMessage("Has Obtenido "+inventoryScriptable.objectName);
            avaible = false;
            FindObjectOfType<InventoryManager>().AddIventoryObject(inventoryScriptable);
            Destroy(gameObject);
        }
        
    }
    
}
