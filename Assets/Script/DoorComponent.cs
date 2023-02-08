using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorComponent : MonoBehaviour
{
    Rigidbody rigidbody;

    bool hitted = false;

    public WeaponManager.WeaponType doorType;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("weapon"))
        {
            if(FindObjectOfType<WeaponManager>().weaponType == doorType)
            {
                 rigidbody.isKinematic=false;            

                rigidbody.AddRelativeForce(transform.forward *50 , ForceMode.Force );

                rigidbody.AddRelativeTorque(transform.forward *10 , ForceMode.Force );

                if(!hitted)
                {
                    hitted = true;
                    Invoke("StartDestroy",3f);
                }
            }
            
        }  
              
    }

    void StartDestroy()
    {
        Destroy(gameObject);
    }
}
