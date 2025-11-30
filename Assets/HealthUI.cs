using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image HeartPrefab;
    public Sprite fullHeartSprite;
    public Sprite emptyHeartSprite;

    private List <Image> hearts = new List<Image>();

    void Start()
    {
        SetMaxHearts (3);
    }
    public void SetMaxHearts(int maxHearts)
    {
        foreach(Image heart in hearts)
        {
            Destroy(heart.gameObject);
        }

        hearts.Clear();
        for (int i = 0; i < maxHearts; i++)
        {
            Image newHeart = GameObject.Instantiate(HeartPrefab, transform);
            newHeart.sprite = fullHeartSprite;
            //newHeart.color = Color.red;
            newHeart.transform.localScale = new Vector3(80, 80);
            newHeart.transform.position = new Vector3(50, 500);
            hearts.Add(newHeart);
        }
    }

    public void UpdateHearts(int currentHealth)
    {
        // for (int i = 0; i < hearts.Count; i++)
        // {
        //     if(i < currentHealth)
        //     {
        //         hearts[i].sprite = fullHeartSprite;
        //         hearts[i].color = Color.red;
        //     }
        //     else
        //     {
        //         hearts[i].sprite = emptyHeartSprite;
        //         hearts[i].color = Color.white;
        //     }
        // }
        var current = hearts.Last();
        Destroy (current.gameObject);
        hearts.Remove(current);
    }
}
