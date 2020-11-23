using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int point = 1;  // 倒したときのスコアポイント
    Score score;                     // スコア

    // Start is called before the first frame update
    void Start()
    {
        // ゲームオブジェクトを検索
        var gameObj = GameObject.FindWithTag("Score");
        // gameObj に含まれる Scoreコンポーネントを取得
        score = gameObj.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnHitBulletメッセージから呼び出されること想定
    void OnHitBullet()
    {
        // 自身のゲームオブジェクトを破棄
        //stroy(gameObject);

        // 死亡時処理
        GoDown();
    }

    // 死亡時処理
    void GoDown()
    {
        //スコアを加算
        score.AddScore(point);

        // 自身のゲームオブジェクトを一定時間後に破棄
        //Destroy(gameObject, 1f);
        Destroy(gameObject);
    }
}
