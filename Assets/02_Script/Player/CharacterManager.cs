using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instacne;
    public static CharacterManager Instance
    {
        get
        {
            if (_instacne == null)
            {
                _instacne = new GameObject("CharacterManager").AddComponent<CharacterManager>();
            }
            return _instacne;
        }
    }

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }
    private void Awake()
    {
        if (_instacne == null)
        {
            _instacne = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instacne == this)
            {
                Destroy(gameObject);
            }
        }
    }
}
