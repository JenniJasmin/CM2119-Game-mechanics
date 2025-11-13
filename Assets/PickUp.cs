using UnityEngine;

public class PickUp : MonoBehaviour
{

    public bool PickUpArea = false;
    private Rigidbody2D myRigid;
    public KeyCode pickUp = KeyCode.P;
   
    // Use this for initialization
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        PickUpArea = false;  
    }


   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickUpArea = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PickUpArea = false;
    }
    */
    void Update()
    {
        //if (PickUpArea == true)
        //{
                if (Input.GetKey(pickUp))
                {
                    Destroy(gameObject);
                }
           
        //}
       
    }
}

