using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Projectile : MonoBehaviour
{
    bool throwing = false;
    Rigidbody _rb;
    

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
        throwing = true;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DespawnTime(10));

        
    }
    
    private void FixedUpdate()
    {
        if (throwing == true)
        {
            _rb.AddForce(transform.TransformVector(new Vector3(0, 0.75f, 1)) * GameBehavior.Instance.throwForce * _rb.mass, ForceMode.Impulse);
            _rb.AddTorque(new Vector3(Random.Range(0.5f , 10), Random.Range(0.5f , 10), Random.Range(0.5f, 10)) * GameBehavior.Instance.throwSpin);
            throwing = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private IEnumerator DespawnTime(float time)
    {
        yield return new WaitForSeconds(time);
        GameBehavior.Instance.projectileCount -= 1;
        Destroy(gameObject);
    }
}
