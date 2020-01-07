using UnityEngine;
using UnityEngine.UI;               // 引用 介面 API
using UnityEngine.SceneManagement;  // 引用 場景管理 API

public class EatProp : MonoBehaviour
{
    [Header("錢的數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;       // 目前寶箱數量
    public int propTotal = 10;  // 寶箱總數

    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "錢")
        {
            Destroy(collision.gameObject);

            propCount++;                                            // 遞增
            textCount.text = "錢：" + propCount + " / 10";        // 更新介面

            // 如果 目前數量 等於 總數 顯示 勝利提示
            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }

    private void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (finish)
        {
            // 按下 ESC 離開
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();     // 應用程式.離開();
            }
            // 按下 R 重來
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Application.LoadLevel("遊戲場景");    // 舊版 API
                SceneManager.LoadScene("SampleScene");     // 新版 API
            }
        }
    }
}
