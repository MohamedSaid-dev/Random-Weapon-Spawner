using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject[] weapons;
    public GameObject spawner;
    private Vector3 transformpos;
    private Quaternion transformrot;
    // Start is called before the first frame update
    void Start()
    {
        transformpos = spawner.transform.localPosition;
        transformrot = spawner.transform.localRotation;
        spawnweapons();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
     public void spawnweapons ()
    {
        int randomweapon = Random.Range(0, weapons.Length);
        Debug.Log(randomweapon);
        Instantiate(weapons[randomweapon],transformpos,transformrot);

    }
}
