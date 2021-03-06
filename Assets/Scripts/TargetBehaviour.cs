using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TargetBehaviour : MonoBehaviour
{
    public NavMeshAgent[] agents; 
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 location = new Vector3();
        float x, y, z;

        x = Random.Range(-108f, -70f);
        z = Random.Range(-15f, 11f);
        location.x = x;
        location.z = z;
        location.y = transform.position.y;
        transform.position = location;
	
	foreach(var item in agents)
	     item.SetDestination(transform.position);
    }
}
