using DG.Tweening;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
    private void OnMouseDown()
    {
        //transform.DOScale(Vector3.one * 2, 0.5f).SetEase(Ease.OutBounce).OnComplete(() => 
        //{
        //    transform.DOScale(new Vector3(5, 1, 5), 0.5f).SetEase(Ease.OutBounce);
        //});
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver");
    }




}
