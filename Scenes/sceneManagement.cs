using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public void WaitMuseum()
    {
        Invoke("Museum",2);

    }

    // Update is called once per frame
    public void Museum()
    {
        SceneManager.LoadScene("1");
    }

     public void WaitSwordLake()
    {
        Invoke("SwordLake",2);
    }

    // Update is called once per frame
    public void SwordLake()
    {
        SceneManager.LoadScene("2");
    }

     public void WaitHome()
    {
        Invoke("Home",2);
    }

    // Update is called once per frame
    public void Home()
    {
        SceneManager.LoadScene("1");
    }

         public void WaitTrangTien()
    {
        Invoke("TrangTien",2);
    }

    // Update is called once per frame
    public void TrangTien()
    {
        SceneManager.LoadScene("1");
    }
         public void WaitHCMMausoleum()
    {
        Invoke("HCMMausoleum",2);
    }

    // Update is called once per frame
    public void HCMMausoleum()
    {
        SceneManager.LoadScene("1");
    }
         public void WaitPillarPaagoda()
    {
        Invoke("PillarPaagoda",2);
    }

    // Update is called once per frame
    public void PillarPaagoda()
    {
        SceneManager.LoadScene("1");
    }
}
