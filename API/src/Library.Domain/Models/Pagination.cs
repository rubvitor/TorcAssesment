using System.Collections.Generic;

namespace Library.Domain.Models;

public class Pagination<T>
{
    public int Total { get; set; }
    public List<T> Result { get; set; }
}