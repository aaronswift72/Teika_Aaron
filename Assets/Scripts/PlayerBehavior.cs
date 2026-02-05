using UnityEngine;
using UnityEngine.InputSystem;

    //Merge Order: Cherry > Strawberry > Grape > Lemon > Orange > Apple > Pear > Banana > Watermelon > Pineapple

public class NewMonoBehaviourScript : MonoBehaviour{
    
    public float speed;
    private GameObject currentFruit;
    public GameObject[] fruits;
    public float min;
    public float max;
    //public int[] numbers;
    
    public float offY = -0.6f;
    public float offset = 0f;
    public float currentTime = 0.0f;
    public float dropTime = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //Debug.Log(currentTime);

    }
    // Update is called once per frame
    void Update(){

        currentTime = Time.time;
        offset = 0f;
        //int choice = Random.Range(27, 60);
        //print (choice);
        
        //fruit position below player
        if (currentFruit != null)
        {
            Vector3 playerPos = transform.position;
            Vector3 fruitOffset = new Vector3(0.0f, offY, 0.0f);
            currentFruit.transform.position = playerPos + fruitOffset * Time.deltaTime;
        }
        else
        {
            int choice = Random.Range(0, fruits.Length);
            currentFruit = Instantiate(fruits[choice], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        //drop fruit
        if (Keyboard.current.spaceKey.wasPressedThisFrame && currentTime >= dropTime + 1f)
        {
            dropTime = currentTime;

            Rigidbody2D body = currentFruit.GetComponent<Rigidbody2D>();
            body.gravityScale = 1.0f;

            Collider2D collider = currentFruit.GetComponent<Collider2D>();
            collider.enabled = true;

            currentFruit = null;
        }
        
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            offset = - speed;
        }
        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            offset = speed;
        }

        Vector3 newPos = transform.position;
        newPos.x = newPos.x + offset;

        if (newPos.x > max)
        {
            newPos.x = max;
        }

        if (newPos.x < min)
        {
            newPos.x = min;
        }
        transform.position = newPos;
    }
}