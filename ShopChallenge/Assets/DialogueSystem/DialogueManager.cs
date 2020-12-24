using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    //Declare public and private variables
    public Text nameText;
    public Text dialogueText;
    public Image displaySprite;
    public Animator anim;

    private Queue<string> scentences;
    private Queue<string> names;
    private Queue<Sprite> displayPic;
    public GameObject choicesObject;

	// Use this for initialization
	void Start () {
        scentences = new Queue<string>();
        names = new Queue<string>();
        displayPic = new Queue<Sprite>();

    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextScentence();
        }        
    }

    //Begin showing dialogue
    public void StartDialogue(Dialogue dialogue)
    {
        scentences.Clear();
        names.Clear();
        displayPic.Clear();

        anim.SetBool("IsOpen", true);

        foreach (string scentence in dialogue.scentences)
        {
            scentences.Enqueue(scentence);
        }

        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }

        foreach (Sprite pic in dialogue.displayImage)
        {
            displayPic.Enqueue(pic);
        }
        DisplayNextScentence();
    }

    //Next scentence
    public void DisplayNextScentence()
    {
        if (scentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string scentence = scentences.Dequeue();

        if (scentence.Contains("##"))
        {
            scentence = scentence.Replace("##", "");
            ShowOptions();
        }

        string name = names.Dequeue();
    
        Sprite pic = displayPic.Dequeue();
        StopAllCoroutines();
        StartCoroutine(Type(scentence,name,pic));
    }


    //Typing effect for the letters
    IEnumerator Type(string scentence,string name,Sprite pic)
    {

        dialogueText.text ="";
        nameText.text = name;
        displaySprite.sprite = pic;

        foreach(char letter in scentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        scentences.Clear();
        names.Clear();
        displayPic.Clear();
        anim.SetBool("IsOpen", false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerActions>().DoneTalking();



        //deactivate all choices
        choicesObject.transform.GetChild(0).gameObject.SetActive(false);
        choicesObject.transform.GetChild(1).gameObject.SetActive(false);
    }

    void ShowOptions()
    {
        choicesObject.transform.GetChild(0).gameObject.SetActive(true);
        choicesObject.transform.GetChild(1).gameObject.SetActive(true);
        return;
    }
    
}
