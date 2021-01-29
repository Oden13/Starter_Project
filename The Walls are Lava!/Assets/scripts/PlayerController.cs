using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
  public Text pointText;
    public float speed;
    private Rigidbody2D rb2d;
    private int point;
    AudioSource audio;
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        point = 0 ;
        SetPointText ();
         audio = GetComponent<AudioSource>();
    }
  void FixedUpdate ()
  {
float moveHorizontal = Input.GetAxis ("Horizontal");
float moveVertical = Input.GetAxis ("Vertical");
Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
rb2d.AddForce (movement * speed);
  }
 
 void Update ()
 {
   if (Input.GetKeyDown (KeyCode.Escape)){
     Application.Quit ();
   }
 }
  void OnTriggerEnter2D(Collider2D other)
  {
if (other.gameObject.CompareTag ("PickUp"))
{
  other.gameObject.SetActive (false);
  point = point + 1;
  SetPointText ();
  audio.Play();
}
if (other.gameObject.CompareTag ("Lava"))
{
    
  gameObject.SetActive (false);
    Application.LoadLevel(2);

}
  }
  
  void SetPointText()
  {
pointText.text =  point.ToString () + "/1";

if (point >= 1)
{
  Application.LoadLevel(1);
}
   }
  }
