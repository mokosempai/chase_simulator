using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{

    [SerializeField] private Flag nextOne;
    private bool mustBeDeactivated;

    void Awake()
    {
        if(nextOne != null)
            nextOne.mustBeDeactivated = true;
    }

    void Start()
    {
        if (mustBeDeactivated) {
            gameObject.SetActive(false);
            mustBeDeactivated = false;
        }
    }


    void OnTriggerEnter(Collider other){
        Debug.Log($"{other.name} enter into {name}");

        if(other.CompareTag("Player")){
            if(nextOne != null){
                nextOne.gameObject.SetActive(true);
            } else {
                SceneManager.LoadScene("TitleScreen");
            }
            gameObject.SetActive(false);
        }
    }

}
