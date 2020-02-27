using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class LevelController : MonoBehaviour
{
    int numOfTouches = 22;
    [SerializeField] Sprite[] sprites;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI count;
    [SerializeField] AudioSource AudioSource;
    [SerializeField] GameObject image;
    [SerializeField] AudioClip[] Audiofiles;
    private int[] touchcount;

    OrientationController controller;
    private bool isPlaying = false;




    //touchcount and audiofiles int he IENumerator functions are 1 behind due to starting at 0, sprites start at 1 due to heir being a default image in element 0

    AudioSource myAudioSource;
    void Start()
    {
        touchcount = new int[numOfTouches];
        text.text = " Please touch a body part";
        for (int i = 0; i < numOfTouches; i++)
        {
            touchcount[i] = 0;
        }

        controller = new OrientationController("COM4");
    }

    // Update is called once per frame
    void Update()
    {
        string keyPressed = controller.getKey();

        Debug.Log(keyPressed);

        //Debug.Log(controller.firstPressed);

        if (keyPressed != "EMPTY" && controller.firstPressed == true && isPlaying == false)
        {
            isPlaying = true;

            switch (keyPressed)
            {
                case "Q":
                    StartCoroutine(ForeHead1());
                    break;

                case "W":
                    StartCoroutine(NeckFront2());
                    break;

                case "E":
                    StartCoroutine(Neckside3());
                    break;

                case "R":
                    StartCoroutine(Shoulders4());
                    break;

                case "T":
                    StartCoroutine(Biceps5());
                    break;

                default:
                    isPlaying = false;
                    break;
            }

       
            ////Biceps
            //if (Input.GetButtonDown("KeyboardT")) { StartCoroutine(Biceps5()); }
            ////Lower Arms
            //if (Input.GetButtonDown("KeyboardY")) { StartCoroutine(LowerArm6()); }
            ////hands
            //if (Input.GetButtonDown("KeyboardU")) { StartCoroutine(Hands7()); }
            ////breasts
            //if (Input.GetButtonDown("KeyboardI")) { StartCoroutine(Breasts8()); }
            ////stomach
            //if (Input.GetButtonDown("KeyboardO")) { StartCoroutine(Stomach9()); }
            ////hips
            //if (Input.GetButtonDown("KeyboardP")) { StartCoroutine(Hips10()); }
            ////vagina
            //if (Input.GetButtonDown("KeyboardA")) { StartCoroutine(Vagina11()); }
            ////Quads
            //if (Input.GetButtonDown("KeyboardS")) { StartCoroutine(Quads12()); }
            ////knees
            //if (Input.GetButtonDown("KeyboardD")) { StartCoroutine(Knees13()); }
            ////shins
            //if (Input.GetButtonDown("KeyboardF")) { StartCoroutine(Shins14()); }
            ////backhead
            //// if (keypressed = "KeyboardG") { StartCoroutine(BackHead15()); }
            ////nape
            //if (Input.GetButtonDown("KeyboardH")) { StartCoroutine(Nape16()); }
            ////shoulderback
            //if (Input.GetButtonDown("KeyboardJ")) { StartCoroutine(ShoulderBack17()); }
            ////triceps
            //if (Input.GetButtonDown("KeyboardK")) { StartCoroutine(tripceps18()); }
            ////lowerarmback
            //if (Input.GetButtonDown("KeyboardL")) { StartCoroutine(LowerArmback19()); }
            ////lowerback
            //if (Input.GetButtonDown("KeyboardZ")) { StartCoroutine(LowerBack20()); }
            ////bottom
            //if (Input.GetButtonDown("KeyboardX")) { StartCoroutine(Bottom21()); }
            ////hamstring
            //if (Input.GetButtonDown("KeyboardC")) { StartCoroutine(Hamstring22()); }
            ////calves
            //if (Input.GetButtonDown("KeyboardV")) { StartCoroutine(Calves23()); }
        }
    }

    public void DefaultText()
    {
        text.text = " Please touch a part on skyes body";
        count.text = "";
        image.GetComponent<SpriteRenderer>().sprite = sprites[0];

    }


    IEnumerator ForeHead1()
    {
       image.GetComponent<SpriteRenderer>().sprite = sprites[1];
       text.text = " You touched her forehead";

        if (controller.firstPressed == true)
        {
            touchcount[0]++;
        }
 
        count.text = " Her forehead has been touched:" + touchcount[0] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[0], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }

    IEnumerator NeckFront2()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[2];
        text.text = " You touched her throat";
        touchcount[1]++;
        count.text = " Her throat has been touched:" + touchcount[1] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[1], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Neckside3()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[3];
        text.text = " You touched her neck";
        touchcount[2]++;
        count.text = " Her neck has been touched:" + touchcount[2] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[2], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Shoulders4()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[4];
        text.text = " You touched her shoulder";
        touchcount[3]++;
        count.text = " Her shoulders have been touched:" + touchcount[3] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[3], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Biceps5()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[5];
        text.text = " You touched her bicep";
        touchcount[4]++;
        count.text = " Her biceps has been touched:" + touchcount[4] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[4], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator LowerArm6()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[6];
        text.text = " You touched her arm";
        touchcount[5]++;
        count.text = " Her arms have been touched:" + touchcount[5] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[5], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Hands7()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[7];
        text.text = " You touched her hand";
        touchcount[6]++;
        count.text = " Her hands have been touched:" + touchcount[6] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[6], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Breasts8()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[8];
        text.text = " You touched her Breasts";
        touchcount[7]++;
        count.text = " Her breasts have been touched:" + touchcount[7] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[7], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Stomach9()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[9];
        text.text = " You touched her stomach";
        touchcount[8]++;
        count.text = " Her stomach has been touched:" + touchcount[8] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[8], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Hips10()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[10];
        text.text = " You touched her hips";
        touchcount[9]++;
        count.text = " Her hips have been touched:" + touchcount[9] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[9], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Vagina11()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[11];
        text.text = " You touched her Vagina";
        touchcount[10]++;
        count.text = " Her vagina has been touched:" + touchcount[10] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[10], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Quads12()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[12];
        text.text = " You touched her quads";
        touchcount[11]++;
        count.text = " Her quads have been touched:" + touchcount[11] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[11], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Knees13()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[13];
        text.text = " You touched her knees";
        touchcount[12]++;
        count.text = " Her knees have been touched:" + touchcount[12] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[12], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Shins14()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[14];
        text.text = " You touched her shins";
        touchcount[13]++;
        count.text = " Her shins have been touched:" + touchcount[13] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[13], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator BackHead15()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[15];
        text.text = " You touched the back of her head";
        touchcount[14]++;
        count.text = " Her head has been touched:" + touchcount[14] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[14], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Nape16()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[16];
        text.text = " You touched the nape of her neck";
        touchcount[15]++;
        count.text = " Her nape has been touched:" + touchcount[15] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[15], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator ShoulderBack17()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[17];
        text.text = " You touched the her trapezius";
        touchcount[16]++;
        count.text = " Her trapezius has been touched:" + touchcount[16] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[16], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator tripceps18()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[18];
        text.text = " You touched the her triceps";
        touchcount[17]++;
        count.text = " Her triceps have been touched:" + touchcount[17] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[17], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator LowerArmback19()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[19];
        text.text = " You touched the back of her arm";
        touchcount[18]++;
        count.text = " Her arms have been touched:" + touchcount[18] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[18], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator LowerBack20()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[20];
        text.text = " You touched her lower back";
        touchcount[19]++;
        count.text = " Her lower back has been touched:" + touchcount[19] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[19], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Bottom21()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[21];
        text.text = " You touched her bottom";
        touchcount[20]++;
        count.text = " Her bottom has been touched:" + touchcount[20] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[20], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Hamstring22()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[22];
        text.text = " You touched her hamstrings";
        touchcount[21]++;
        count.text = " Her hamstrings have been touched:" + touchcount[21] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[21], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }
    IEnumerator Calves23()
    {
        image.GetComponent<SpriteRenderer>().sprite = sprites[23];
        text.text = " You touched her calves";
        touchcount[22]++;
        count.text = " Her calves have been touched:" + touchcount[22] + " times.";
        AudioSource.PlayClipAtPoint(Audiofiles[22], Camera.main.transform.position, 1.0f);
        yield return new WaitForSeconds(5);
        DefaultText();

        isPlaying = false;
    }


}
