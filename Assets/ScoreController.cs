using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    //スコアをいれる変数を宣言する
    private GameObject scoreText;
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        SetScore();
    }

    // Update is called once per frame
    void Update()
    {
    }

    //スコア表示の関数
    public void SetScore()
    {
        this.scoreText.GetComponent<Text>().text = score.ToString();
    }

    //スコアが加算時の関数
    public void AddScore(int point)
    {
        this.score = score + point;
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        // タグによって獲得ポイントを変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            AddScore(10);
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            AddScore(20);
        }
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            AddScore(5);
        }

        //  ポイント加算時にスコア表示の更新
        SetScore();

    }
}
