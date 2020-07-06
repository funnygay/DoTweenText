using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.DOText("DoTween Pro是一款untiy插件，是untiy中最好用的tween插件，实现脚本和视觉脚本的新功能，支持包括移动，淡出，颜色，旋转，缩放，打孔，摇动，文本，相机属性等，DoTween与其他动画插件相比，它的效率是最高的，支持可视化编程。", 10);//在10s内匀速显示这段文字
        StartCoroutine(ChangeColor());
    }

  
    //协程函数延迟10s执行颜色变化函数
    IEnumerator ChangeColor()
    {
        yield return new WaitForSeconds(10);
        text.DOColor(Color.blue, 5.0f);//字体颜色渐变成蓝色
    }

}
