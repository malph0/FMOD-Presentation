using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject Throw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            GameObject projectile = Instantiate(Throw, this.transform.TransformPoint(new Vector3(0, -0.5f, 1)) , this.transform.rotation);
            GameBehavior.Instance.projectileCount += 1;
        }
    }
}
