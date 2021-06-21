using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaterController : MonoBehaviour
{
    public Transform Pos1;
    public Transform Pos2;
    public Transform Pos3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void createGun()
    {
        Instantiate(Resources.Load("GUN1"), Pos1.position, Quaternion.identity);
    }
    public void createTurret()
    {
        Instantiate(Resources.Load("GUN1"), Pos2.position, Quaternion.identity);
    }
    public void createCannon()
    {
        Instantiate(Resources.Load("GUN1"), Pos3.position, Quaternion.identity);
    }
}
