using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmanager : MonoBehaviour
{
    public gamemanager gameMg;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameMg.coinAdd();
            Destroy(gameObject);
        }
    }




}






