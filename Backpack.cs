using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Backpack : MonoBehaviour
{
    public List<ItemSO> backpack;

    public void AddItem(ItemSO itemToAdd)
    {
        backpack.Add(itemToAdd);

    }

    public void RemoveItem(ItemSO itemToRemove)
    {
        backpack.Remove(itemToRemove);

    }

    public bool IsInBag(ItemSO item)
    {
        return backpack.Contains(item);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}