using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSceneCanvas : MonoBehaviour
{
    public GameObject startGameCanvas;
    private CyclinderMovement cyclinderMovement;
    public Animator animator;

    private void Awake()
    {
        startGameCanvas.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isStarted", false);
        cyclinderMovement = FindObjectOfType<CyclinderMovement>();
        cyclinderMovement.rotateSpeed = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        cyclinderMovement.rotateSpeed = 1500;
        animator.SetBool("isStarted", true);

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }
}
