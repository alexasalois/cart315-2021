using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

public Transform avatar;
public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = avatar.position.x.ToString("0");
    }
}
