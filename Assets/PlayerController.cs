using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    Rigidbody rb;
    public Text gameover;
    public bool isTrue=false;
    public float score;
    public Text scoreText;
    public float tempscore;
    public int n=1;
   
    // bool isgrounded=true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTrue == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Physics.gravity *= -1;



                //rb.AddForce(Vector3.up * jumpforce);

            }

            score = transform.position.x;
            Mathf.Floor(score);
            Debug.Log(score);
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
          
       
    }
    private void FixedUpdate()
    {
        if (isTrue == false)
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gameover.GetComponent<Text>().enabled = true;
            isTrue = true;
        }
    }
}
