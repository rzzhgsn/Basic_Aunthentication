using BasicAunthentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicAuthentication;

public abstract class Data
{
    public string First { get; set; }
    public string Last { get; set; }
    public string Pass { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    //public int id { get; set; }

    
}