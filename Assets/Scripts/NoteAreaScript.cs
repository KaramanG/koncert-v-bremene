using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NoteAreaScript : MonoBehaviour
{
    public int track;
    public KeyCode key;
    private KeyCode[] keys = new KeyCode[] { KeyCode.D, KeyCode.F, KeyCode.Space, KeyCode.J, KeyCode.K };

    [SerializeField] GameObject noteExample;
    [SerializeField] SphereCollider circleCollider;
    bool isTouching;
    GameObject overlayingNote;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(track);
        isTouching = true;

        overlayingNote = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(-track);
        isTouching = false;
        overlayingNote = null;
    }

    private void pressNote(GameObject note)
    {
        Transform notePos = note.transform;
        GameObject hitNote = Instantiate(noteExample, notePos);
        Destroy(note);
        hitNote.transform.DOScale(new Vector3(6.5f, 6.5f, 6.5f), 0.33f);
        
        SpriteRenderer spriteRenderer = hitNote.GetComponent<SpriteRenderer>();
        spriteRenderer.DOColor(new Color(
                spriteRenderer.color.r,
                spriteRenderer.color.g,
                spriteRenderer.color.b,
                0f), 0.33f);
        Destroy(hitNote);
    }

    private void Update()
    {
        if (!isTouching)
            return;

        if (Input.GetKeyDown(key))
        {
            Debug.Log(key);
            pressNote(overlayingNote);
        }
    }
}
