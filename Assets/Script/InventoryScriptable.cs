
/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryObject", menuName = "ScriptableObjects/InventoryObject", order = 1)]

public class InventoryScriptable : ScriptableObject
{
   public string objectName;

   public Sprite objectIcon;

   public GameObject model3D;
}
