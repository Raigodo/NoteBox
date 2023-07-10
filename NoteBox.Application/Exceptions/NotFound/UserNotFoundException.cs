using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBox.Application.Exceptions.NotFound;

public class userNotFoundException : NotFoundExcpetion
{
    public userNotFoundException(string userId) : base($"User with Id:{userId} was not found.")
    {
    }
}
