using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Kasa : MonoBehaviour
{
    public string dogruSifre = "139";  
    public InputField sifreGirdisi;     
    public Canvas kasaAcildiPaneli;     

    void Start()
    {
        // Input field'a klavye etkileşimini açar
        sifreGirdisi.interactable = true;

        // Password karakterleri gösterir
        sifreGirdisi.inputType = InputField.InputType.Password;
       
    }

    public void SifreKontrolEt()
    {
        if (sifreGirdisi.text == dogruSifre)  
        {
            kasaAcildiPaneli.gameObject.SetActive(true);
            Debug.Log("Oldu");
            SceneManager.LoadScene("GameOver"); 
        }
        
    }
}
