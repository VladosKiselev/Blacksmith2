using UnityEngine;

public abstract class ValueView : MonoBehaviour
{
    public virtual void Init() { }
    public abstract void Display(int score);
}