using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Orbit : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitAround();
    }
    
    void OrbitAround()
    {
        transform.RotateAround(cube.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
