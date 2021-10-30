using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PryamidGenerator : MonoBehaviour
{
    [SerializeField] private GameObject prefab = null;

    [SerializeField] private int row = 8;
    [SerializeField] private int col = 8;
    [SerializeField] private float moveBlock = .5F;
    // Start is called before the first frame update
    void Start()
    {
        BuildPyramid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void BuildPyramid()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                GameObject go = Instantiate(prefab, new Vector3(j + moveBlock, i, 0), Quaternion.identity);
                go.SetActive(true);
            }
            col -= 1;
            moveBlock += .5F;
        }
    }
}

