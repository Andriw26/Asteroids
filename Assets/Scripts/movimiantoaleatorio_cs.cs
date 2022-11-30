using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiantoaleatorio_cs : MonoBehaviour
{
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public float vel_min;
    public float vel_max;
    public List<Sprite> opcionesSprite;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        int escogido = Random.Range(0, opcionesSprite.Count);
        sr.sprite = opcionesSprite[escogido];

        rb = GetComponent<Rigidbody2D>();
        Vector2 direccion = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        float velocidad = Random.Range(vel_min, vel_max);
        rb.AddForce(direccion * velocidad);
    }
}
