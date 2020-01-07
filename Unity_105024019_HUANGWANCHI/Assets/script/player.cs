
using UnityEngine;

public class player : MonoBehaviour
{
    #region 欄位區域
    [Header("動畫參數名稱")]
    public string parRun = "跑步開關";
    [Header("道具")]
    public int countNeed = 10;
    public int countCurrent;
    public Animator ani;
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        //print("水平 " + Input.GetAxis("Horizontal")); // Horizontal A 左 -1、D 右 1、沒按 0
        //print("垂直 " + Input.GetAxis("Vertical"));   // Vertical   S 下 -1、W 上 1、沒按 0

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);  // 水平 不等於 0 或者 垂直 不等於 0 就跑步
    }

    

   
    
    /// <summary>
    /// 吃道具
    /// </summary>
    private void EatProp()
    {

    }

    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {

    }
    #endregion

    private void Update()
    {
        Run();
    }
}
