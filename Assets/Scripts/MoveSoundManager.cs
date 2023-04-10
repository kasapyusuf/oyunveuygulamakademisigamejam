using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource footstepsSound, sprintSound, jumpStartSound;

    bool isGrounded = true;
    public GameObject panelb;
    public GameObject panelc;
    public GameObject paneld;
    public GameObject kasa;
    public GameObject Keys;
    public GameObject Keys1;
    public GameObject Keys2;


    void Update()
    {

        if (isGrounded && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }

        if(isGrounded && Input.GetKey(KeyCode.Space))
        {
            isGrounded = false;
            jumpStartSound.enabled = true;
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }   
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            panelb.SetActive(false);
            panelc.SetActive(false);
            paneld.SetActive(false);
            kasa.SetActive(false);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
            jumpStartSound.enabled = false;
        }
         

        if (hit.gameObject.CompareTag("clue"))
        {
            panelb.SetActive(true);
            Keys.SetActive(true);
        }

        if (hit.gameObject.CompareTag("clue2"))
        {
            panelc.SetActive(true);
            Keys1.SetActive(true);
        }

        if (hit.gameObject.CompareTag("clue3"))
        {
            paneld.SetActive(true);
            Keys2.SetActive(true);
        }

        if (hit.gameObject.CompareTag("kasa"))
        {
            kasa.SetActive(true);
            Invoke("SwitchScene", 2f);
        }
    }
    void SwitchScene()
     {
        SceneManager.LoadScene("GameOver");
     }

    
    

}
