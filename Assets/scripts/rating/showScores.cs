using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class showScores : MonoBehaviour
{
    private List<string> scores = new List<string>();
    public Text textScore; 
    void Start()
    {
        print(File.Exists(rating.path));
        if (!File.Exists(rating.path))
        {
            File.Create(rating.path);
            using (var sr = File.OpenText(rating.path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    scores.Add(s);
                    scores.Sort();
                    scores.Reverse();
                }
            }
        } else
        {
            using (var sr = File.OpenText(rating.path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    scores.Add(s);
                    scores.Sort();
                    scores.Reverse();
                }
            }
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (scores.Count == 0 || ConfirmOk.del)
        {
            textScore.text = "Здесь будут ваши рекорды!";
        } else
        {
            textScore.text = "";
            int i = 1;
            foreach(string item in scores)
            {
                textScore.text += i + ". " + item + "\n";
                i++;
            }
        }
    }
}
