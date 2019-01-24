using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    public float m_speed = 100.0f;
    public Sprite m_frontSprite;
    public Sprite m_backSprite;
    public Sprite m_sideSprite;
    public SpriteRenderer m_renderer;
    public Rigidbody2D m_rigidbody;
    public Vector2 velocity;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity = new Vector2(0, m_speed);
            m_renderer.sprite = m_backSprite;
            m_rigidbody.MovePosition(m_rigidbody.position + velocity * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity = new Vector2(0, -m_speed);
            m_renderer.sprite = m_frontSprite;
            m_rigidbody.MovePosition(m_rigidbody.position + velocity * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity = new Vector2(m_speed, 0);
            m_renderer.sprite = m_sideSprite;
            m_renderer.flipX = false;
            m_rigidbody.MovePosition(m_rigidbody.position + velocity * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity = new Vector2(-m_speed, 0);
            m_renderer.sprite = m_sideSprite;
            m_renderer.flipX = true;
            m_rigidbody.MovePosition(m_rigidbody.position + velocity * Time.fixedDeltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
    }

    //void Oldmove()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        gameObject.transform.Translate(new Vector3(0, m_speed * Time.deltaTime, 0));
    //        m_renderer.sprite = m_backSprite;
    //    }

    //    if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        gameObject.transform.Translate(new Vector3(0, -m_speed * Time.deltaTime, 0));
    //        m_renderer.sprite = m_frontSprite;
    //    }

    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        gameObject.transform.Translate(new Vector3(m_speed * Time.deltaTime, 0, 0));
    //        m_renderer.sprite = m_sideSprite;
    //        m_renderer.flipX = false;
    //    }

    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        gameObject.transform.Translate(new Vector3(-m_speed * Time.deltaTime, 0, 0));
    //        m_renderer.sprite = m_sideSprite;
    //        m_renderer.flipX = true;
    //    }

}

