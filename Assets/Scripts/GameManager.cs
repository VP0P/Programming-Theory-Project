using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Animal> _animalPrefabs;

    private List<string> _instantiatedAnimals = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void SetCharacter(int index)
    {
        GameObject animal = GameObject.FindGameObjectWithTag(_animalPrefabs[index].tag);

        if(animal == null)
        {
            Instantiate(_animalPrefabs[index]);
        }
    }
}
