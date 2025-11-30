using UnityEngine;
using TMPro;

public class example_timer : MonoBehaviour
{
    public TMP_Text tex;
   
    float countdown=50;
    
    void Update()
    {
        if(countdown>0)
        {
            countdown-=Time.deltaTime;
        }
        tex.text=countdown.ToString();
        double b=System.Math.Round(countdown,2);
        tex.text=b.ToString();


    }

}