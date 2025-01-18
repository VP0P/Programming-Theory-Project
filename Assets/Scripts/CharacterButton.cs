using UnityEngine;
using UnityEngine.UI;

public class AnimalButton : MonoBehaviour
{
    private Button _button;
    private GameManager _gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _button = gameObject.GetComponent<Button>();

        _button.onClick.AddListener(SetCharacter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetCharacter()
    {
        _gameManager.SetCharacter(1);
    }
}
