using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Animations : MonoBehaviour
{
    public GameObject vbBtnObj;
    public Animator anim;
    public AudioSource Voicing;
    public AudioSource Typing;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        anim.GetComponent<Animator>();
        Voicing.GetComponent<AudioSource>();
 
    }

public void OnButtonPressed(VirtualButtonBehaviour vb)
{
         anim.SetTrigger("buttonPress");
         Voicing.Play();
         Typing.Stop();
         Debug.Log("Button pressed");
}
public void OnButtonReleased(VirtualButtonBehaviour vb)
{
         Debug.Log("Button released");
         Typing.Play();
         Voicing.Stop();
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
