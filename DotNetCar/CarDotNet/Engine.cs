using System;
using System.Collections.Generic;
using System.Text;

namespace CarDotNet
{
    #region Partial Class
    /*
     * Multiple file can use this partial class to add features
     * 
     * one file can be locked from writing and you need a partial class in an other file to further implementations
     * developer may not want to edit part of this code, so with a partial class you can add more features without editing the original
     */
    partial class Engine
    {
        public string Type { get; set; }
    }

    #endregion
}
