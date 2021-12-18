using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour
{
    public InputField input;
    public Transform PlayerBox;
    public float MoveDisplace = 1f;
    public float SizeDisplace = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //command up
            if (input.text == "up")
            {
                Debug.Log("up");
                PlayerBox.Translate(Vector3.up * MoveDisplace, Space.World);
            }

            if (input.text == "down")
            {
                Debug.Log("down");
                PlayerBox.Translate(-Vector3.up * MoveDisplace, Space.World);
            }

            if (input.text == "right")
            {
                Debug.Log("right");
                PlayerBox.Translate(Vector3.right * MoveDisplace, Space.World);
            }

            if (input.text == "left")
            {
                Debug.Log("left");
                PlayerBox.Translate(-Vector3.right * MoveDisplace, Space.World);
            }

            if (input.text == "big")
            {
                Debug.Log("big");
                PlayerBox.localScale += new Vector3(PlayerBox.localScale.x + SizeDisplace, PlayerBox.localScale.y + SizeDisplace, PlayerBox.localScale.z + SizeDisplace);
            }

            if (input.text == "small")
            {
                Debug.Log("small");
                PlayerBox.localScale += new Vector3(PlayerBox.localScale.x - SizeDisplace, PlayerBox.localScale.y - SizeDisplace, PlayerBox.localScale.z - SizeDisplace);
            }

            input.Select();
            input.text = "";
        }
    }

    void OnSubmitEvent(string Message)
    {
        input.Select();
        input.text = "";
    }
}
