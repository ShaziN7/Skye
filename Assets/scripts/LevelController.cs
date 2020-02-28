using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class LevelController : MonoBehaviour
{
    int numOfTouches = 10;
    int[] touchcount;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject image;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI count;
   // [SerializeField] AudioSource AudioSource;
   // [SerializeField] AudioClip[] Audiofiles;
    
    
    private bool isPlaying = false;
    private bool isCounted = false;

    OrientationController controller;


    //touchcount and audiofiles int he IENumerator functions are 1 behind due to starting at 0, sprites start at 1 due to heir being a default image in element 0

    AudioSource myAudioSource;
    void Start()
    {
        
        isPlaying = false;
        isCounted = false;
        touchcount = new int[numOfTouches];
        text.text = " Please touch a body part";
        for (int i = 0; i < numOfTouches; i++)
        {
            touchcount[i] = 0;
        }

        controller = new OrientationController("COM5");
    }

    // Update is called once per frame
    void Update()
    {

        //////////////////// teensy code below ////////////////////////
        //string keyPressed = controller.getKey();

        //Debug.Log(keyPressed);

        //Debug.Log(controller.firstPressed);

        //if (keyPressed != "EMPTY" && controller.firstPressed == true && isPlaying == false)
        //{
        //    isPlaying = true;

        //    switch (keyPressed)
        //    {
        //        case "Q":
        //            StartCoroutine(ForeHead1());
        //            break;

        //        case "W":
        //            StartCoroutine(NeckFront2());
        //            break;

        //        case "E":
        //            StartCoroutine(Neckside3());
        //            break;

        //        case "R":
        //            StartCoroutine(Shoulders4());
        //            break;

        //        case "T":
        //            StartCoroutine(Biceps5());
        //            break;

        //        default:
        //            isPlaying = false;
        //            break;
        //    }


        
        if (Input.GetButtonDown("KeyboardQ") && isPlaying == false) { StartCoroutine(Cheek1()); }
        
        if (Input.GetButtonDown("KeyboardW") && isPlaying == false) { StartCoroutine(Head2()); }
     
        if (Input.GetButtonDown("KeyboardE") && isPlaying == false) { StartCoroutine(LBreast3()); }
      
        if (Input.GetButtonDown("KeyboardR") && isPlaying == false) { StartCoroutine(LVagina4()); }
        
        if (Input.GetButtonDown("KeyboardT") && isPlaying == false) { StartCoroutine(MVagina5()); }

        if (Input.GetButtonDown("KeyboardY") && isPlaying == false) { StartCoroutine(Neck6()); }
        
        if (Input.GetButtonDown("KeyboardU") && isPlaying == false) { StartCoroutine(RBreast7()); }
        
        if (Input.GetButtonDown("KeyboardI") && isPlaying == false) { StartCoroutine(Ribs8()); }
     
        if (Input.GetButtonDown("KeyboardO") && isPlaying == false) { StartCoroutine(Tummy9()); }
    
        if (Input.GetButtonDown("KeyboardP") && isPlaying == false) { StartCoroutine(RVagina10()); }
            }


    public void DefaultText()
    {
        isPlaying = false;
        isCounted = false;
        text.text = " Please touch a part on skyes body";
        count.text = "";
        image.GetComponent<SpriteRenderer>().sprite = sprites[0];

    }
    IEnumerator Cheek1()
    {
       isPlaying = true;
       image.GetComponent<SpriteRenderer>().sprite = sprites[1];
       
       text.text = "You touched Skye's cheek, I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";

        if (!isCounted)
        {
            touchcount[0]++;
            isCounted = true;
        }

        count.text = " Skye's cheek has been touched:" + touchcount[0] + " times.";
        //AudioSource.PlayClipAtPoint(Audiofiles[0], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }
    IEnumerator Head2()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[2];
        text.text = " You touched Skye's Head/hair,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background ";

        if (!isCounted)
        {
            touchcount[1]++;
            isCounted = true;
        }

        count.text = " Skye's head has been touched:" + touchcount[1] + " times.";
        // AudioSource.PlayClipAtPoint(Audiofiles[1], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

    }
    IEnumerator LBreast3()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[3];
        text.text = " You touched her Left breast,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[2]++;
            isCounted = true;
        }
        count.text = " Skye's left breast has been touched:" + touchcount[2] + " times.";
        // AudioSource.PlayClipAtPoint(Audiofiles[2], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }

    IEnumerator LVagina4()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[4];
        text.text = " You touched the left side of skye's Vagina,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[3]++;
            isCounted = true;
        }
        count.text = " The left side of Skye's vagina has been touched:" + touchcount[3] + " times.";
        // AudioSource.PlayClipAtPoint(Audiofiles[3], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }

    IEnumerator MVagina5()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[5];
        text.text = " You touched the middle of Skye's vagina,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[4]++;
            isCounted = true;
        }
        count.text = " The middle of Skye's vagina has been touched:" + touchcount[4] + " times.";
        //AudioSource.PlayClipAtPoint(Audiofiles[4], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }
    IEnumerator Neck6()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[1];
        text.text = " You touched Skye's neck,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[5]++;
            isCounted = true;
        }
        count.text = " Skye's Neck has been touched:" + touchcount[5] + " times.";
        //  AudioSource.PlayClipAtPoint(Audiofiles[5], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

    }
    IEnumerator RBreast7()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[2];
        text.text = " You touched Skye's right breast,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[6]++;
            isCounted = true;
        }
        count.text = " Skye's right breast has been touched:" + touchcount[6] + " times.";
        //AudioSource.PlayClipAtPoint(Audiofiles[6], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }

    IEnumerator Ribs8()
    {
        isPlaying = true;
        image.GetComponent<SpriteRenderer>().sprite = sprites[3];
        text.text = " You touched Skye's Ribs,  I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[7]++;
            isCounted = true;
        }
        count.text = " Skye's breasts have been touched:" + touchcount[7] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[7], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }
    IEnumerator Tummy9()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[4];
        text.text = " You touched her stomach";
        if (!isCounted)
        {
            touchcount[8]++;
            isCounted = true;
        }
        count.text = " Her stomach has been touched:" + touchcount[8] + " times.";
        // AudioSource.PlayClipAtPoint(Audiofiles[8], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }
    IEnumerator RVagina10()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[5];
        text.text = " You touched her Vagina, I dont really know what to write here, but i need it long enough that it looks like a paragraph of important text, probably some story background";
        if (!isCounted)
        {
            touchcount[9]++;
            isCounted = true;
        }
        count.text = " Her hips have been touched:" + touchcount[9] + " times.";
        //  AudioSource.PlayClipAtPoint(Audiofiles[9], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();
    }
   



}
