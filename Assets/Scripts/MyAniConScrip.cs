using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAniConScrip : MonoBehaviour
{
    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        Debug.Log("MyAniConScript: start => Animator");
    }

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("Vertical");
        vert = (vert + 1f)/2f;
        float vertRecup;
        if(vert < 0.1)
            vertRecup = 0f;
        else if(vert > 0.8f)
            vertRecup = 1f;
        else
            vertRecup = 0.5f;

        float hor = Input.GetAxis("Horizontal");
        hor = (hor + 1f)/2f;
        float horRecup;
        if(hor < 0.1)
            horRecup = 0f;
        else if(hor > 0.8f)
            horRecup = 1f;
        else
            horRecup = 0.5f;

        myAnimator.SetFloat("vSpeed", vertRecup);
        Debug.Log("vSpeed = " + vertRecup);
        myAnimator.SetFloat("hSpeed", horRecup);
        Debug.Log("hSpeed = " + horRecup);


        if (Input.GetKeyDown(KeyCode.R)) // Si le bouton R est enfoncé
        {
            if (myAnimator != null)
            {
                myAnimator.SetBool("run", true); // Activer le booléen "run"
                Debug.Log("run = true");
            }
            else
            {
                Debug.LogError("MyAniConScript: Animator is not assigned!");
            }
        }
        else if (Input.GetKeyUp(KeyCode.R)) // Si le bouton R est relâché
        {
            if (myAnimator != null)
            {
                myAnimator.SetBool("run", false); // Désactiver le booléen "run"
                Debug.Log("run = false");
            }
            else
            {
                Debug.LogError("MyAniConScript: Animator is not assigned!");
            }
        }


        if (Input.GetKeyDown(KeyCode.J)) // Si le bouton R est enfoncé
        {
            if (myAnimator != null)
            {
                myAnimator.SetBool("jump", true); // Activer le booléen "run"
                Debug.Log("jump = true");
            }
            else
            {
                Debug.LogError("MyAniConScript: Animator is not assigned!");
            }
        }
        else if (Input.GetKeyUp(KeyCode.J)) // Si le bouton R est relâché
        {
            if (myAnimator != null)
            {
                myAnimator.SetBool("jump", false); // Désactiver le booléen "run"
                Debug.Log("jump = false");
            }
            else
            {
                Debug.LogError("MyAniConScript: Animator is not assigned!");
            }
        }

    }
}
