using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemInteractor : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        
        
        if(hit.gameObject.CompareTag("item"))
        {
            hit.gameObject.GetComponent<InventoryObject>().AddToInventory();            
        }

        if(hit.gameObject.CompareTag("Respawn"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = Vector3.zero;                
            GetComponent<CharacterController>().enabled = true;
        }

        if(hit.gameObject.CompareTag("Finish"))
        {
            GetComponent<CharacterController>().enabled = false;
            FindObjectOfType<GameManager>().messageManager.SetMessage("Victoria");
           
        }

    }
}
