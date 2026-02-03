using UnityEngine;
using UnityEngine.InputSystem;

    //Merge Order: Cherry > Strawberry > Grape > Lemon > Orange > Apple > Pear > Banana > Watermelon > Pineapple

public class NewMonoBehaviourScript : MonoBehaviour{
    
    public float speed;
    private GameObject currentFruit;
    public GameObject[] fruits;
    //public int[] numbers;
    
    public float offY = -0.6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < numbers.Length; i++)
        //{
        //    print(numbers[i]); 
        //}
    }

    // Update is called once per frame
    void Update(){

        //int choice = Random.Range(27, 60);
        //print (choice);

    

        //fruit position below player
        if (currentFruit != null)
         {
            Vector3 playerPos = transform.position;
            Vector3 fruitOffset = new Vector3(0.0f, offY, 0.0f);
            currentFruit.transform.position = playerPos + fruitOffset;
        }
        else
        {
            int choice = Random.Range(0, fruits.Length);
            currentFruit = Instantiate(fruits[choice], new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
        //drop fruit
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Rigidbody2D body = currentFruit.GetComponent<Rigidbody2D>();
            body.gravityScale = 1.0f;

            Collider2D collider = currentFruit.GetComponent<Collider2D>();
            collider.enabled = true;

            currentFruit = null;
        }
        
        if (Keyboard.current.aKey.isPressed){
            Vector3 newPos = transform.position;
            newPos.x = newPos.x - speed;
            transform.position = newPos;
        }
        if (Keyboard.current.dKey.isPressed){
            Vector3 newPos = transform.position;
            newPos.x = newPos.x + speed;
            transform.position = newPos;
        }
        if (Keyboard.current.wKey.isPressed){
            Vector3 newPos = transform.position;
            newPos.y = newPos.y + speed;
            transform.position = newPos;
        }
        if (Keyboard.current.sKey.isPressed){
            Vector3 newPos = transform.position;
            newPos.y = newPos.y - speed;
            transform.position = newPos;
        }
    }
}
