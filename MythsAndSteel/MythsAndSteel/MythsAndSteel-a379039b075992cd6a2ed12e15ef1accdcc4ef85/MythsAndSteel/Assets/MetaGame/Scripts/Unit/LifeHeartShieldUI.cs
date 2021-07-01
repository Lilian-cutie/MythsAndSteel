using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Ce Script g�re l'affichage des points de vie et des point de bouclier sur les unit�s
 */

public class LifeHeartShieldUI : MonoSingleton<LifeHeartShieldUI>
{
    
    public GameObject ShieldPrefab;
   
 
    public GameObject LifeHeartPrefab;
   
    public   Sprite[] ShieldSprite;
 
    public Sprite[] LifeHeartSprite;
    /// <summary>
    /// Cette fonction va permettre de mettre un sprite d'une liste trouv� � partir d'un index � un objet. C'est la fonction qui met � jour l'affichage des boucliers et des points de vie. 
    /// </summary>
    public void UpdateLifeHeartShieldUI(Sprite[] listSprite, int LifeHeartShield, SpriteRenderer currentSprite)

    {
        currentSprite.sprite = listSprite[LifeHeartShield];
    }
}
