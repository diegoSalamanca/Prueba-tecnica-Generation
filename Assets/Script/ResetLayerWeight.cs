/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using UnityEngine;

public class ResetLayerWeight : StateMachineBehaviour
{

    GameObject weapon;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {      
        if(GameObject.FindObjectOfType<WeaponManager>() is WeaponManager weapon)
            {              
                var weaponcollider = weapon.gameObject.GetComponent<BoxCollider>();
                weaponcollider.enabled=false;
            }
        animator.SetLayerWeight(1,0);
        animator.SetBool("ready",true);
    }
    
}
