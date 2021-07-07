using System;
using LuaInterface;
using UnityEngine;

namespace CSharp
{
    public class GameRoot : MonoBehaviour
    {
        private LuaState lua = null;

        void Start()
        {
            new LuaResLoader();
            lua = new LuaState();
            lua.Start();
            string fulPath = Application.dataPath + "\\Scripts/Lua";
            lua.AddSearchPath(fulPath);
            LuaBinder.Bind(lua);
            lua.DoFile("OutputString.lua");
        }
    }
}