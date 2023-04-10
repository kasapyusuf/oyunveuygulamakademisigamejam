using UnityEngine;
using UnityEngine.UI;

public class aboutUs : MonoBehaviour
{
    public GameObject panela;
    
    public void OpenPanel()
    {
       if(panela != null)
       {
        //isActive = panela.activeSelf;

        //panela.SetActive(!isActive);
        panela.SetActive(true);
       }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            panela.SetActive(false);
        }
    }
}
