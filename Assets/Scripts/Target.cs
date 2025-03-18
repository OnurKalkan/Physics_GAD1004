using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreText;
    public Projectile.ColorType colorType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            if(colorType == other.GetComponent<Projectile>().colorType)
            {
                score += other.GetComponent<Projectile>().scoreValue;
            }
            else
            {
                score -= other.GetComponent<Projectile>().scoreValue;
            }            
            scoreText.text = "Score: " + score.ToString();
            Destroy(other.gameObject);
        }            
    }
}
