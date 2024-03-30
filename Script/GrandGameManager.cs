using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using UnityEngine;

public class GrandGameManager : MonoBehaviour
{
    public static bool talk = true;//トーク中のプレイヤーの移動制限
    public static bool battlejudge;//勝敗結果を伝える
    public static bool storyafter = false;//当該シーンにてバトル後のスクリプト
    public Fungus.Flowchart flowchart = null;
    public static int clearpoint;//クリア進行度
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*4.勝敗精査、InvokeでloadScene-3
     * 3.別のテキスト表示、話しかけられないようにする。既定ポイントでloadscene-2
     * 2.別のテキスト表示laodScene-3
     * 3.4ともに初期化して再度遊べるようにする
     * 
     * 
     * 戻った時に負けていたら再挑戦＆勝っていたら挑戦不可まで実装〇
     * バトルシーンで未だに勝敗不具合が生じている-解消◎
     * 量産するにあたりキーパーソンのスクリプトに現在このスクリプトについているStart()を移し替える必要あり〇
     * load2に移行する列車用スクリプト及びオブジェクト
     *
     *storybgmname
     *4Jardin Botanique
     *2abandoned Village
     *1紫翠の森
     *
     *あと4つ背景音楽素材を持ってくる
     *あと41体サイトからキャラクターを作る（メインあと6体
     *ストーリーを完成させる
     *アセットストアもしくはフリーで背景画像×6を探してくる
     *
     *
     *bgm:1〇,2,2a,(2b),3abcdefg,4adg〇,2last
     *SE:タップ音〇,カード捲る音〇
    /*48px<= =<72px
     * 間隔<=8px
     * ボタンデザイン無料餞別
     * 
     */
}
