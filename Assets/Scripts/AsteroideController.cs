using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideController : MonoBehaviour
{
    public GestorAsteroides gestor;
    // Start is called before the first frame update
    void Start()
    {
        gestor.asteroides_actuales = gestor.asteroides_actuales + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Muerte()
    {
        if (transform.localScale.x > 0.5625f)
        {
            GameObject asteroide1 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
            asteroide1.GetComponent<AsteroideController>().gestor = gestor;
            asteroide1.transform.localScale = transform.localScale * 0.75f;

            GameObject asteroide2 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
            asteroide2.GetComponent<AsteroideController>().gestor = gestor;
            asteroide2.transform.localScale = transform.localScale * 0.75f;
        }
        gestor.asteroides_actuales = gestor.asteroides_actuales - 1;
        GameManager.instance.puntuacion = GameManager.instance.puntuacion + 100;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        { 
            collision.GetComponent<ship_cs>().Muerte();
        }
    }

    //void OnDestroy()
    //{
    //    GameObject asteroide1 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
    //    asteroide1.GetComponent<AsteroideController>().gestor = gestor;
    //    GameObject asteroide2 = Instantiate(gestor.asteroide_base, transform.position, transform.rotation);
    //    asteroide2.GetComponent<AsteroideController>().gestor = gestor;
    //}
}
