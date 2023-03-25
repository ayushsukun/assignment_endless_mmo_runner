using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _obstacle;
    public GameObject[] holes;
    public float timelapse = 1.5f;
     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timelapse -= 1 * Time.deltaTime;
        if (timelapse <= 0)
        {
            int hole_no = Random.RandomRange(0, 6);
            var clone_obs=Instantiate(_obstacle, holes[hole_no].transform.position, Quaternion.Euler(Random.RandomRange(1,6), 6, Random.RandomRange(1,6)));
            timelapse = 1.5f;
             Destroy(clone_obs, 1.25f);
        }
        
       
        
    }
    

}
