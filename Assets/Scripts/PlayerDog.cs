using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDog : MonoBehaviour
{
    bool isAsleep; // dog is only asleep right in beginning, remember to switch this value to false eventually
    bool isFacingRight;
    bool isRunning;

    Rigidbody2D rb;
    public float playerSpeed = 20f;


    public Animator animator;
    public Transform overlapPoint;
    public GameObject bed;
    public GameObject smallHamster;
    public GameObject bigHamster;
    public GameObject trashCan;
    public GameObject cat;
    public GameObject bird;
    public List<GameObject> humans;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        isAsleep = true; // dog is asleep at beginning of game
        isFacingRight = true;
        isRunning = false;
    }
    
    
    // Update is called once per frame
    void Update()
    {
        // float horizontalMovement = Input.GetAxisRaw("Horizontal"); // might delete this
    }

    private void FixedUpdate()
    {
        HandleMovement();
        HandleInteraction();
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isFacingRight)
            {
                isFacingRight = false;
            }
            if (!isRunning)
            {
                isRunning = true;
            }
            transform.position -= transform.TransformDirection(Vector3.right) * Time.deltaTime * playerSpeed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {   
            if (!isFacingRight)
            {
                isFacingRight = true;
            }
            if (!isRunning)
            {
                isRunning = true;
            }
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * playerSpeed;
        }
        else
        {
            isRunning = false;
        } 
    }

    private void HandleInteraction()
    {
        if (Input.GetKey (KeyCode.Space))
        {

            // TODO: check for collision, check what object dog has collided with in order to tell what action happens
        }
    }
}

// TODO: add different types of interactions for different collisions
