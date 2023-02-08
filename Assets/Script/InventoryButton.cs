/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{

    Button button;
    TMPro.TextMeshProUGUI textMesh;

    InventoryScriptable inventoryScriptable;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(AddWeapontoPlayer);
    }

    public void SetProperties(InventoryScriptable item)
    {
        button = GetComponent<Button>();
        textMesh = GetComponentInChildren<TMPro.TextMeshProUGUI>();
        inventoryScriptable = item;
        button.image.sprite = inventoryScriptable.objectIcon;
        textMesh.text = inventoryScriptable.objectName;
    }

    void AddWeapontoPlayer()
    {
        var container = FindObjectOfType<WeaponContainer>();

        if(container.transform.childCount > 0 )
        {
            Destroy(container.transform.GetChild(0).gameObject);
            
        }

        var weapon = Instantiate(inventoryScriptable.model3D, container.transform);

    }
    
}
