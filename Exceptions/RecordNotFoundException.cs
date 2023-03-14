using System;

namespace Exceptions
{
    //we should inherit our new exception from Exception class
    public class RecordNotFoundException : Exception
    {
        //we use base class to write the exception message that we created
        //code goes to the base Exception class and uses the message method assigned in the class
        public RecordNotFoundException(string message):base(message)
        {
        }
    }
}
