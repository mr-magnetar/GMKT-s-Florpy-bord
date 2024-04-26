using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScrip : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float upscalerMultiplyer;
    public LogicScript LogicScript;
    public bool BirdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && BirdIsAlive) {
            myrigidbody.velocity = Vector2.up * upscalerMultiplyer;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LogicScript.GameOver();
        BirdIsAlive = false;
    }


}
