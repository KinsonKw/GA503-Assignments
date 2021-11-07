using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private GameObject prefab = null;

    [SerializeField] private int row = 8;

    [SerializeField] private float rotateSpeed = 180f;

    [SerializeField] private List<GameObject> cubes;

    // Start is called before the first frame update
    void Start()
    {
         for (int i = 0; i < row; i++)
        {
            GameObject go = Instantiate(prefab, new Vector3(0, i, 0), Quaternion.Euler(0, i * 15, 0));
            go.SetActive(true);
            cubes.Add(go);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CubeRotate();
    }

    private void CubeRotate()
    {
       foreach(GameObject cube in cubes)
        {
            cube.transform.Rotate(new Vector3(0, rotateSpeed * Time.deltaTime, 0));
        }
    }         

}
