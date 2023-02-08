/*Code by Diego Salamanca for BIT technical test*/

using UnityEngine;

public class SoldierController : MonoBehaviour
{
    public CharacterController controlador;

    public Animator soldierAnimator;

    public float speed, rotateSpeed;  

    public float jump;

    private bool InJump;

    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var j = Input.GetAxis("Jump");
        

        Vector3 direction = new Vector3( 0, 0 , v);
        Vector3 rotacion = new Vector3(0,  h,0);        

        
        soldierAnimator.SetFloat("speed", v);


        if(v == 0)
        soldierAnimator.SetFloat("turn", h);
        else
        soldierAnimator.SetFloat("turn", 0);

        transform.Rotate(rotacion * rotateSpeed);

        if(Input.GetMouseButtonDown(1))
        {
            
            soldierAnimator.SetLayerWeight(1,1);
            soldierAnimator.SetTrigger("sword");

             if(GameObject.FindObjectOfType<WeaponManager>() is WeaponManager weapon)
            {            
                              
                var weaponcollider = weapon.gameObject.GetComponent<BoxCollider>();
                weaponcollider.enabled=true;
            }
        }

         if(Input.GetMouseButtonUp(1))
        {
            soldierAnimator.SetBool("ready",false);
            
        }
        
        controlador.Move(transform.forward * Time.deltaTime * speed* v);

        controlador.SimpleMove(Vector3.zero);
    }
   
}
