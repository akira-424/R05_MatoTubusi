using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTarget : MonoBehaviour
{

    int score = 0; // �X�R�A

    public void PushButton()
    {
        // target���N���b�N��10pt
        score += 10;
        Debug.Log(score);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
