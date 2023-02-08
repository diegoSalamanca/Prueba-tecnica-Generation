
using UnityEngine;

[CreateAssetMenu(fileName = "InventoryObject", menuName = "ScriptableObjects/InventoryObject", order = 1)]

public class InventoryScriptable : ScriptableObject
{
   public string objectName;

   public Sprite objectIcon;

   public GameObject model3D;
}
