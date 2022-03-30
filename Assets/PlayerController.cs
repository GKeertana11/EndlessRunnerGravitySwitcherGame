using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
   // public float startspeed;
    public float jumpforce;
    Rigidbody rb;
    public Text gameover;
    public bool isTrue;
    public float score;
    public Text scoreText;
    public Transform Rotation;
    Animation animator;
    public  float trackedDistance;
    public float maxDistance;
    public string Myname="Keertana";


    // bool isgrounded=true;
    // Start is called before the first frame update
    void Start()
    {
        maxDistance = 50f;
        rb = GetComponent<Rigidbody>();
        isTrue = false;
        Debug.Log(PlayerPrefs.GetInt("score"));
        PlayerPrefs.SetString("name", Myname);
        Debug.Log(PlayerPrefs.GetString("name"));


        // rotation = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Space)&&isTrue==false)
            {
                Physics.gravity *= -1;
           
             //  transform.Rotate(-180f, 0f, 0f, Space.World);

                



                rb.AddForce(Vector3.up * jumpforce);

            }

            score = Mathf.Floor(transform.position.x);
          //  Mathf.Floor(score);
            Debug.Log(score);
        PlayerPrefs.SetFloat("Score",score);
        
       // PlayerPrefs.GetFloat("score");

            scoreText.text= score.ToString();

           /* while(tempscore<=20*n)
           {
                tempscore++;
                if(tempscore==20*n)
                {
                    tempscore = 20*n;
                    speed=speed * 2;
                    n++;
                }

            }*/
           
         
        
          
       
    }
    private void FixedUpdate()
    {
        if (isTrue == false)
        {
            trackedDistance += speed*Time.fixedDeltaTime;

           //speed = startspeed + Mathf.Floor(trackedDistance / 1000);
           
            if (trackedDistance>maxDistance)
            {
                speed = speed * 2;
                maxDistance += 50;
            }
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
            
               
            
           
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gameover.GetComponent<Text>().enabled = true;
            isTrue = true;
           // animator.GetComponent<Animation>().enabled = false;
        }
    }
}
