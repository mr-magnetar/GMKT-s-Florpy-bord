using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject piller;
    public float spawnrate=2;
    private float timer=0;
    public float Yoffset;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            SpawnPipe();
        }
        
    }
    void SpawnPipe()
    {
        float lowerstOffSet = transform.position.y - Yoffset;
        float upperstOffSet = transform.position.y + Yoffset;
        Instantiate(piller, new Vector3(transform.position.x, Random.Range(lowerstOffSet,upperstOffSet),0),transform.rotation);
    }
}
