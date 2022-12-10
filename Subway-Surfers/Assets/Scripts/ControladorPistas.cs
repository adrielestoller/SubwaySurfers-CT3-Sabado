using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPistas : MonoBehaviour
{
    public List<GameObject> plataformas = new List<GameObject>();
    public int offset;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < plataformas.Count; i++)
        {
            Instantiate(plataformas[i], new Vector3(0, 0, i * 86), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
