using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject prefab = null;

    [SerializeField] private int row = 8;
    [SerializeField] private int col = 8;

    // Start is called before the first frame update
    void Start()
    {
        BuildWall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BuildWall()
    {
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                GameObject go = Instantiate(prefab, new Vector3(j, i, 0), Quaternion.identity);
                go.SetActive(true);
            }

        }
    }
}
