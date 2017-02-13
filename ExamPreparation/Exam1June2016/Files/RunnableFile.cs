using System;
using System.Collections.Generic;
using System.Linq;

public class RunnableFile
{
    public string Name { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }

    public static implicit operator List<object>(RunnableFile v)
    {
        throw new NotImplementedException();
    }
}
