using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour{
    
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
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
