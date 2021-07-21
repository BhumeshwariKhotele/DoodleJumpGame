


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0f, 100f) < 5)
        {

            GameObject coin = Pool.Instance.Get("Coin");
            if (coin != null)
            {
                coin.transform.position = transform.position + new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-1.0f, 3.5f), 0);
                coin.SetActive(true);
            }


        }
    }


}