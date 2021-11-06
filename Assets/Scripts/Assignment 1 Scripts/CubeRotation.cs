using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private GameObject prefab = null;

    [SerializeField] private int row = 8;

    [SerializeField] private float speed = 180f;

    // Start is called before the first frame update
    void Start()
    {
        CubeRotate();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    private void CubeRotate()
    {
        for (int i = 0; i < row; i++)
        {
            GameObject go = Instantiate(prefab, new Vector3(0, i, 0), Quaternion.Euler(0, i * 15, 0));
            go.SetActive(true);
        }
        
    }
}
