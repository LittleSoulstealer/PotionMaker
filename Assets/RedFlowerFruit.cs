﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFlowerFruit : PickableFruit
{
   public RedFlowerFruit()
    {
        name = "Red Flower";
        price = 50;
    }
    public override void AddMyselfToInventory()
    {
        Inventory.instance.flowers.amount += 1;
        base.AddMyselfToInventory();
    }
}
