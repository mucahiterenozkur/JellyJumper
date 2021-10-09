using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public static bool youPlayed = false;
    public Rigidbody rb;
    public float jumpForce;
    public GameObject splashEffectPrefab;
    public GameObject gameOverCanvas;
    public GameObject winCanvas;
    public GameObject startGameCanvas;
    public GameObject endGameCanvas;
    private CyclinderMovement cyclinderMovement;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name.Equals("EndOfGame"))
        {
            endGameCanvas.SetActive(true);
        }

        if (youPlayed.Equals(true))
        {
            startGameCanvas.SetActive(false);
        }
        else
        {
            startGameCanvas.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cyclinderMovement = FindObjectOfType<CyclinderMovement>();
        gameOverCanvas.SetActive(false);
        winCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //rb.AddForce(Vector3.up * jumpForce);
        rb.velocity = Vector3.up * jumpForce;
        GameObject splashEffect = Instantiate(splashEffectPrefab, transform.position + new Vector3(0f,-0.19f,0f), transform.rotation);
        splashEffect.transform.SetParent(other.gameObject.transform);
        Destroy(splashEffect, 1f);

        //string tagName = other.gameObject.tag;
        //Debug.Log(tagName);

        if(other.gameObject.CompareTag("Unsafe"))
        {
            //Debug.Log("dead");
            youPlayed = true;
            gameOverCanvas.SetActive(true);
            cyclinderMovement.rotateSpeed = 0;
            jumpForce = 0;
        }

        if (other.gameObject.CompareTag("Last"))
        {
            //Debug.Log("win");
            youPlayed = true;
            winCanvas.SetActive(true);
            cyclinderMovement.rotateSpeed = 0;
            
        }

    }

    public void TryAgain()
    {
        int repeatScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(repeatScene);
    }

    public void NextLevel()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        youPlayed = false;
    }

    
}
