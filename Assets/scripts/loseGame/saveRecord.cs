using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class saveRecord : MonoBehaviour
{
    public InputField input;
    public string standartNick = "Безымянный";
    private void Start()
    {
    }
    public void ClickSave()
    {
        if (!File.Exists(rating.path))
        {
            File.Create(rating.path);
            if (input.text == "")
            {
                File.AppendAllText(rating.path, standartNick + " " + Move.results + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(rating.path, input.text + " " + Move.results + Environment.NewLine);
            }
            input.gameObject.SetActive(false);
            gameObject.SetActive(false);
            print("saved");
            ConfirmOk.del = false;
        } else
        {
            if (input.text == "")
            {
                File.AppendAllText(rating.path, standartNick + " " + Move.results + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(rating.path, input.text + " " + Move.results + Environment.NewLine);
            }
            input.gameObject.SetActive(false);
            gameObject.SetActive(false);
            print("saved");
            ConfirmOk.del = false;
        }
    }
}
