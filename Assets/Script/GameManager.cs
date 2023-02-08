/*Code by Diego Salamanca for Generation and BIT technical test
Contact Email:  Diegocolmayor@gmail.com*/
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MessageManager messageManager;
    // Start is called before the first frame update
    void Start()
    {
        messageManager.SetMessage("Encuentra la salida");
    }
}
