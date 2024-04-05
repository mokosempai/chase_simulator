using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flag : MonoBehaviour
{

    [SerializeField] private Flag nextOne;


    // Start is called before the first frame update
    void Start()
    {
        if(nextOne != null)
            nextOne.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other){
        Debug.Log($"{other.name} enter into {name}");

        if(other.CompareTag("Player")){
            if(nextOne != null){
                nextOne.gameObject.SetActive(true);
            }
            gameObject.SetActive(false);
        }
    }

}
