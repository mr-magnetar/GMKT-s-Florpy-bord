using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlePillarScript : MonoBehaviour

{
    public LogicScript LogicScript;
    // Start is called before the first frame update
    void Start()
    {
        LogicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3)
        {
            LogicScript.ScoreCal(1);
        }
        
    }
}
