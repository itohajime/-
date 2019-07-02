using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class OrbManager : MonoBehaviour
{
    //オブジェクト参照
    private GameObject gameManager;        //ゲームマネージャー

    public Sprite[] orbPicture = new Sprite[3]; //オーブの絵

    public enum ORB_KIND        //オーブの種類の定義
    {
        BLUE,
        GREEN,
        PURPLE,
    }

    private ORB_KIND orbkind;   //オーブの種類

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// オーブ取得
    /// </summary>
    public void TouchOrb()
    {
        if(Input.GetMouseButton(0) == false)
        {
            return;
        }

        switch (orbkind)
        {
            case ORB_KIND.BLUE:
                gameManager.GetComponent<GameManager>().GetOrb(1);
                break;
            case ORB_KIND.GREEN:
                gameManager.GetComponent<GameManager>().GetOrb(5);
                break;
            case ORB_KIND.PURPLE:
                gameManager.GetComponent<GameManager>().GetOrb(10);
                break;
        }

        Destroy(this.gameObject);
    }

    /// <summary>
    /// オーブの種類を設定
    /// </summary>
    /// <param name="kind"></param>
    public void SetKind(ORB_KIND kind)
    {
        orbkind = kind;

        switch (orbkind)
        {
            case ORB_KIND.BLUE:
                GetComponent<Image>().sprite = orbPicture[0];
                break;
            case ORB_KIND.GREEN:
                GetComponent<Image>().sprite = orbPicture[1];
                break;
            case ORB_KIND.PURPLE:
                GetComponent<Image>().sprite = orbPicture[2];
                break;
        }
    }
}
