using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Rotate(Random.Range(50, 150) * Time.deltaTime, Random.Range(50, 150) * Time.deltaTime, Random.Range(50, 150) * Time.deltaTime, Space.Self);
    }

    public void ButtonHandlerPlay(){
        SceneManager.LoadSceneAsync(1);

    }

    public void DirectDesktop(){
        Application.Quit();
    }
}
