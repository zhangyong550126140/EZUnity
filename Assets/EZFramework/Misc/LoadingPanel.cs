/*
 * Author:      熊哲
 * CreateTime:  11/1/2016 5:21:11 PM
 * Description:
 * 
*/
using UnityEngine;
using UnityEngine.UI;

namespace EZFramework
{
    public class LoadingPanel : MonoBehaviour
    {
        public Text text_Process;
        public Image image_ProcessFill;

        void Awake()
        {
            gameObject.SetActive(true);
            ShowProgress();
        }

        public void ShowProgress(string str = "", float progress = 0)
        {
            gameObject.SetActive(true);
            text_Process.text = str;
            image_ProcessFill.fillAmount = progress;
        }

        public void LoadComplete()
        {
            gameObject.SetActive(false);
        }
    }
}