using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
 
   
    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0f, 100f) < 5)
        {
           
            GameObject et = Pool.Instance.Get("Tile");
            if (et != null)
            {
                et.transform.position = transform.position + new Vector3(Random.Range(3f, 10.0f), Random.Range(-3.0f, -4.0f), 0);
                et.SetActive(true);
            }
        }
    }

 
}