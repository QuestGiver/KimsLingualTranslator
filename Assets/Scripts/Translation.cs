using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Translation : MonoBehaviour
{
    public InputField inputString;
    public Text outputString;

    // Use this for initialization
    void Start()
    {

        inputString.onEndEdit.AddListener(delegate { TranslaitonFunction(inputString); });
        //if (typingStart == null)
        //{
        //    typingStart += TranslaitonFunction;
        //}
    }



    //Everything for the translation is handled here
    void TranslaitonFunction(InputField input)
    {
        if (input.text.Length > 0)
        {
            Debug.Log("Text has been entered");

            char[] inputCharArray = inputString.text.ToCharArray();
            //c = d,
            //e = s,
            //g = f,
            //j = k,
            //l = m,
            //o = n,
            //p = z,
            //r = t,
            //s = e,
            //t = r,
            //z = p

            for (int i = 0; i < inputString.text.Length; i++)
            {
                switch (inputString.text[i])
                {
                    case 'c':
                        inputCharArray[i] = 'd';
                        Debug.Log("d");
                        break;
                    case 'C':
                        inputCharArray[i] = 'D';
                        break;
                    case 'd':
                        inputCharArray[i] = 'c';
                        break;
                    case 'D':
                        inputCharArray[i] = 'C';
                        break;
                    case 'e':
                        inputCharArray[i] = 's';
                        break;
                    case 'E':
                        inputCharArray[i] = 'S';
                        break;
                    case 'f':
                        inputCharArray[i] = 'g';
                        break;
                    case 'F':
                        inputCharArray[i] = 'G';
                        break;
                    case 'g':
                        inputCharArray[i] = 'f';
                        break;
                    case 'G':
                        inputCharArray[i] = 'F';
                        break;
                    case 'j':
                        inputCharArray[i] = 'k';
                        break;
                    case 'J':
                        inputCharArray[i] = 'K';
                        break;
                    case 'k':
                        inputCharArray[i] = 'j';
                        break;
                    case 'K':
                        inputCharArray[i] = 'J';
                        break;
                    case 'l':
                        inputCharArray[i] = 'm';
                        break;
                    case 'L':
                        inputCharArray[i] = 'M';
                        break;
                    case 'm':
                        inputCharArray[i] = 'l';
                        break;
                    case 'M':
                        inputCharArray[i] = 'M';
                        break;
                    case 'n':
                        inputCharArray[i] = 'o';
                        break;
                    case 'N':
                        inputCharArray[i] = 'O';
                        break;
                    case 'o':
                        inputCharArray[i] = 'n';
                        break;
                    case 'O':
                        inputCharArray[i] = 'N';
                        break;
                    case 'p':
                        inputCharArray[i] = 'z';
                        break;
                    case 'P':
                        inputCharArray[i] = 'Z';
                        break;
                    case 'r':
                        inputCharArray[i] = 't';
                        break;
                    case 'R':
                        inputCharArray[i] = 'T';
                        break;
                    case 't':
                        inputCharArray[i] = 'r';
                        break;
                    case 'T':
                        inputCharArray[i] = 'R';
                        break;
                    case 's':
                        inputCharArray[i] = 'e';
                        break;
                    case 'S':
                        inputCharArray[i] = 'E';
                        break;
                    case 'z':
                        inputCharArray[i] = 'P';
                        break;
                    case 'Z':
                        inputCharArray[i] = 'P';
                        break;
                }
            }
            //string output = inputCharArray.ToString();


            outputString.text = new string(inputCharArray);
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("Main Input Empty");
        }
    }
}
