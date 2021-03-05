using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            CategoryBuilder.Create("Mod", "A mod by JustAMeanie", ModAPI.LoadSprite("CategoryThumb.png"));
            //Put your code Here :)
        }
    }
}