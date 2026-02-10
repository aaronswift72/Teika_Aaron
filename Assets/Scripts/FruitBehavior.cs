using System.Runtime.InteropServices;
using UnityEngine;

public class FruitBehavior : MonoBehaviour
{
    public float timeOut;
    public float timeStart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TB"))
        {
            timeStart = Time.time;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TB"))
        {
            float currentTime = Time.time;
            float timeThusFar = currentTime - timeStart;
            if(timeThusFar > timeOut)
            {
                print("Game over");
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TB"))
        {
            timeStart = 0.0f;
        }
    }
}
