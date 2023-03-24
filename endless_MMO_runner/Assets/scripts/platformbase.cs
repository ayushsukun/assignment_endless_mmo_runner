using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformbase : MonoBehaviour
{

    public GameObject platform2;
    public GameObject end_pnt1;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platform2, end_pnt1.transform.position, Quaternion.identity);
       // Destroy(platform2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
