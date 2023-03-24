using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_gen : MonoBehaviour
{
   
    //public GameObject start_pnt2;
   
    public GameObject end_pnt2;
    
    public GameObject platform2;
    private float timegen=3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timegen -= 1 * Time.deltaTime;
       if (timegen<=0)
        {
            Instantiate(platform2, end_pnt2.transform.position, Quaternion.identity);
            timegen = 3;
           
        }
        Destroy(platform2, 4f);

    }

    
    

}
