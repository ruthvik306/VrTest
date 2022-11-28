using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Vrbutton : MonoBehaviour
{
    public Image img;
    public UnityEvent gclick;
    public float timer = 2;
    bool gvrstat;
    public float gvrtimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void gvron(){
        gvrstat = true;

    }
     public void gvroff(){
        gvrstat = false;
        gvrtimer=0;
        img.fillAmount = 0;
        
    }
    // Update is called once per frames
    void Update()
    {
        if (gvrstat)
        {
            gvrtimer+=Time.deltaTime;
            img.fillAmount =gvrtimer/timer; 
        }        

        if(gvrtimer> timer)
        {
            gclick.Invoke();
        }
    }
}
