using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncuCarpismasi : MonoBehaviour
{
    private int toplamAnanasSayisi;
    public Vector3 baslangicPozisyonu;
    private void Start()
    {
        toplamAnanasSayisi = GameObject.Find("toplanabilirobjeler").transform.childCount;
        baslangicPozisyonu = gameObject.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("toplanabilirobje"))
        {
            Destroy(collision.gameObject);
            GameManager.instance.ananasSayisi++;
            print(GameManager.instance.ananasSayisi);
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            if(SceneManager.GetActiveScene().buildIndex + 1== SceneManager.sceneCountInBuildSettings)
            {
                UIManager.Instance.OpenQuitPanel();
            }

            else
            {
                if (toplamAnanasSayisi == GameManager.instance.ananasSayisi)
                {
                    UIManager.Instance.OpenLevelCompletedPanel();
                }
            }

            
        }
        else if(collision.gameObject.CompareTag("Respawn"))
        {
            gameObject.transform.position = baslangicPozisyonu;
        }
    }
}
