using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(AudioSource))]
public class Wait : MonoBehaviour
{


    Animator anim;
    // Start is called before the first frame update

    
    public AudioClip Para1;
    public AudioClip Para2;
    public AudioClip Para3;
    public AudioClip Para4;
    public AudioClip Para5;
    public AudioClip Para6;
    public AudioClip Para7;
    public AudioClip Para8;
    public AudioClip Para9;
    public AudioClip Para10;

    public AudioSource audioSource; 
    public GameObject collisionObject;


    void Start()
    {
         anim = gameObject.GetComponent<Animator>();
        StartCoroutine(Beginning());
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Meat")
        {
            StartCoroutine(Middle());
        }


    }


    IEnumerator Beginning()
    {
        audioSource.clip = Para1;
        audioSource.Play(0);
        yield return new WaitForSeconds(24);
        audioSource.clip = Para2;
        audioSource.Play(0);
        yield return new WaitForSeconds(4);
        anim.SetTrigger("ManPraying");
        yield return new WaitForSeconds(15);
        anim.SetTrigger("ManPrayingR");

        yield return new WaitForSeconds(3);
        audioSource.clip = Para3;
        audioSource.Play(0);
        anim.SetTrigger("ManOnHill");
        yield return new WaitForSeconds(7);
        anim.SetTrigger("ChildOnHill");
        yield return new WaitForSeconds(6);
        anim.SetTrigger("ChildOnHillR");

        yield return new WaitForSeconds(3);
        audioSource.clip = Para4;
        audioSource.Play(0);
        yield return new WaitForSeconds(16);
        anim.SetTrigger("ManOnHillR");
        yield return new WaitForSeconds(3);
        audioSource.clip = Para5;
        audioSource.Play(0);
        yield return new WaitForSeconds(5);
        anim.SetTrigger("CaveFire");
        yield return new WaitForSeconds(20);
        // indsæt collision trigger


        


     

    }


    IEnumerator Middle(){


        anim.SetTrigger("CaveFireR");
        yield return new WaitForSeconds(3);
        audioSource.clip = Para6;
        audioSource.Play(0);
        yield return new WaitForSeconds(6);
        anim.SetTrigger("ChildBegging");
        anim.SetTrigger("ManStanding");
        yield return new WaitForSeconds(14);
        anim.SetTrigger("ChildBeggingR");
        anim.SetTrigger("ManStandingR");

        yield return new WaitForSeconds(3);
        anim.SetTrigger("ChildTelling");
        anim.SetTrigger("Elder");
        yield return new WaitForSeconds(13);
        anim.SetTrigger("ChildTellingR");
        anim.SetTrigger("ElderR");

        yield return new WaitForSeconds(3);
        audioSource.clip = Para7;
        audioSource.Play(0);
        yield return new WaitForSeconds(6);
        anim.SetTrigger("Cave");
        anim.SetTrigger("Man1Running");
        anim.SetTrigger("Man2Running");


        yield return new WaitForSeconds(4);
        anim.SetTrigger("TheManRunning");
        //Cave, Man1Running, Man2Running måske 3-4 sekunder før manden
        yield return new WaitForSeconds(14);
        anim.SetTrigger("TheManRunningR");
        anim.SetTrigger("CaveR");
        anim.SetTrigger("Man1RunningR");
        anim.SetTrigger("Man2RunningR");
        //Cave, Man1Running, Man2Running

        yield return new WaitForSeconds(3);
        audioSource.clip = Para8;
        audioSource.Play(0);
        yield return new WaitForSeconds(8);
        anim.SetTrigger("ManWithPouch");
        yield return new WaitForSeconds(12);
        anim.SetTrigger("ManInPouch");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManInPouchR");
        //Set Second Trigger
        
        
    }
    
    IEnumerator End(){

        yield return new WaitForSeconds(3);
        anim.SetTrigger("ManWithPouchR");
        yield return new WaitForSeconds(3);
        audioSource.clip = Para9;
        audioSource.Play(0);
        anim.SetTrigger("ManFire");
        anim.SetTrigger("ChildFire");
        yield return new WaitForSeconds(16);
        anim.SetTrigger("Fire");
        yield return new WaitForSeconds(11);
        anim.SetTrigger("ManFireR");
        anim.SetTrigger("ChildFireR");
        anim.SetTrigger("FireR");

        yield return new WaitForSeconds(3);
        audioSource.clip = Para10;
        audioSource.Play(0);
        yield return new WaitForSeconds(6);
        anim.SetTrigger("ManEnd");
        anim.SetTrigger("ChildEnd");
        yield return new WaitForSeconds(18);
        anim.SetTrigger("ManEndR");
        anim.SetTrigger("ChildEndR");
        

    }
}
