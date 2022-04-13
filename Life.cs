using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI text;

    public int life;
    //private int trueLife = Score.score;
    void Start()
    {
        life = Score.score;
    }

    // Update is called once per frame
    void Update()
    {
        if (life < 1)
            Destroy(gameObject);
        text.text = life.ToString();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        if (life < 1)
            Destroy(gameObject);
    }
}
