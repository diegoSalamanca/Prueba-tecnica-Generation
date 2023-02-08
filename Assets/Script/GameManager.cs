using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MessageManager messageManager;
    // Start is called before the first frame update
    void Start()
    {
        messageManager.SetMessage("Encuentra la salida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
