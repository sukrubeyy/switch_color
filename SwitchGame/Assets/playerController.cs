using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public float jumpForce = 30f;
    public Rigidbody2D rb;
    public SpriteRenderer spr;
    public string currentColor;
    public Color colorKirmizi;
    public Color colorMavi;
    public Color colorPembe;
    public Color colorYesil;
    
    void Start()
    {
       
        setRandomColor();
    }

    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag!=currentColor)
        {
            Debug.Log("Game OVer");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        if(col.tag=="changeColor")
        {
            setRandomColor();
            Destroy(col.gameObject);
            return;
        }
        if(col.tag=="win")
        {
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name)+1);
        }
    }
    void setRandomColor()
    {
        int index = Random.Range(0, 4);
        switch(index)
        {
            case 0:
                currentColor = "Kirmizi";
                spr.color = colorKirmizi;
                break;
            case 1:
                currentColor = "Pembe";
                spr.color = colorPembe;
                break;
            case 2:
                currentColor = "Yesil";
                spr.color = colorYesil;
                break;
            case 3:
                currentColor = "Mavi";
                spr.color = colorMavi;
                break;
        }
    }
}
