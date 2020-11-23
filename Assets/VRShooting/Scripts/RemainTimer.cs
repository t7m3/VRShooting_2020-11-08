using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainTimer : MonoBehaviour
{
    [SerializeField] float gameTime = 30.0f;  // ゲーム制限時間[s]
    Text uiText;  // UITEextコンポーネント
    float currenTime;  // 残り時間タイマー

    // Start is called before the first frame update
    void Start()
    {
        // Textコンポーネント取得
        uiText = GetComponent<Text>();
        // 残り時間を設定
        currenTime = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        // 残り時間を計算
        currenTime -= Time.deltaTime;

        // ０秒以下にはならない
        if (currenTime <= 0.0f)
        {
            currenTime = 0.0f;
        }

        // 残り時間テキスト更新
        uiText.text = string.Format("残り時間：{0:F} 秒", currenTime);
    }

    // カウントダウンを行っているか？
    public bool IsCountingDown()
    {
        // カウンターが０でなければ、カウント中
        return currenTime > 0.0f;
    }
}
