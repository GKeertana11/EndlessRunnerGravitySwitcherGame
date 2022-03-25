using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject platform;
    public GameObject[] platformprefabs;
    public float spawnpoint;
    public float safeMargin;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int k;
        k = Random.Range(0, platformprefabs.Length);
       

            if (spawnpoint < 5)
        {
            k = 0;
        }
        while (player != null && spawnpoint < player.transform.position.x + safeMargin)
        {



            GameObject temp = Instantiate(platformprefabs[k]);
            PlatformController platform1 = temp.GetComponent<PlatformController>();
            temp.transform.position = new Vector3((spawnpoint + platform1.size / 2), 0, 0);
            spawnpoint = spawnpoint + platform1.size;
        }
        



            
            
        

    }
}
