using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD;

public class BallBehavior : MonoBehaviour
{


    public GameObject cubePos;

    FMODUnity.StudioEventEmitter emitter;

    float cubeDistance;

    // Start is called before the first frame update
    void Start()
    {
        emitter = gameObject.GetComponent<FMODUnity.StudioEventEmitter>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //cubeDistance = Vector3.Distance(transform.position, cubePos.transform.position);

        //emitter.SetParameter("Distance", cubeDistance);
        //UnityEngine.Debug.Log(cubeDistance);
        
    }
}
