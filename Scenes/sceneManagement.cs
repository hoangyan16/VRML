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

     public void WaitMall()
    {
        Invoke("Mall",2);
    }

    // Update is called once per frame
    public void Mall()
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

         public void WaitPark()
    {
        Invoke("Park",2);
    }

    // Update is called once per frame
    public void Park()
    {
        SceneManager.LoadScene("1");
    }
         public void WaitCompany()
    {
        Invoke("Company",2);
    }

    // Update is called once per frame
    public void Company()
    {
        SceneManager.LoadScene("1");
    }
         public void WaitFactory()
    {
        Invoke("Factory",2);
    }

    // Update is called once per frame
    public void Factory()
    {
        SceneManager.LoadScene("1");
    }
}
