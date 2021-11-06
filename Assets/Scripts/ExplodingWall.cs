using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingWall : MonoBehaviour
{
    [SerializeField] private Rigidbody prefab = null;

    [SerializeField] private int row = 8;
    [SerializeField] private int col = 8;

    [SerializeField] private List<Rigidbody> rigidBodies = new List<Rigidbody>();

    [SerializeField] private float explosiveForce = 1000;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Rigidbody rb = Instantiate(prefab, new Vector3(j, i, 0), Quaternion.identity);
                rb.gameObject.SetActive(true);

                rigidBodies.Add(rb);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //for(int i = 0; i < rigidBodies.Count; i++)
            foreach(Rigidbody elem in rigidBodies)
            {
                elem.AddExplosionForce(explosiveForce, new Vector3(col / 2f, 0, 0), col);
            }
        }
    }
}
