using UnityEngine;
using TMPro;

public class JabuszkoCounter : MonoBehaviour
{
   public int totalJabuszka;
public TMP_Text jabuszkoText;

void Start()
    {
        jabuszkoText.text = "Liczba jabuszek: " + totalJabuszka;
    }

   public void ChangeCoins(int amount) 
     {
        totalJabuszka += amount;
         jabuszkoText.text = "Liczba jabuszek: " + totalJabuszka;
     }   
    

}
