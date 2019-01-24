using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveRand : MonoBehaviour {
    public float m_speed = 75.0f;
    public Sprite m_frontSprite;
    public Sprite m_backSprite;
    public Sprite m_sideSprite;
    public SpriteRenderer m_renderer;
    public Rigidbody2D m_rigidbody;
    public Vector2 velocity;
    // Use this for initialization
    void Start () {
        velocity = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    private void FixedUpdate()
    {
        int changedirectionchances = Random.Range(1, 100);
        if (changedirectionchances > 95)
        {
            int directionid = Random.Range(0, 3);

            if (directionid == 0)
            {
                Vector2 newvelocity = new Vector2(0, m_speed);
                m_renderer.sprite = m_backSprite;
                velocity = newvelocity;
            }

            if (directionid == 1)
            {
                Vector2 newvelocity = new Vector2(0, -m_speed);
                m_renderer.sprite = m_frontSprite;
                velocity = newvelocity;

            }

            if (directionid == 2)
            {
                Vector2 newvelocity = new Vector2(m_speed, 0);
                m_renderer.sprite = m_sideSprite;
                m_renderer.flipX = false;
                velocity = newvelocity;

            }

            if (directionid == 3)
            {
                Vector2 newvelocity = new Vector2(-m_speed, 0);
                m_renderer.sprite = m_sideSprite;
                m_renderer.flipX = true;
                velocity = newvelocity;

            }
        }
        m_rigidbody.MovePosition(m_rigidbody.position + velocity * Time.fixedDeltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "grass")
        {
            m_speed = m_speed / 2;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "grass")
        {
            m_speed = m_speed*2;

        }
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

