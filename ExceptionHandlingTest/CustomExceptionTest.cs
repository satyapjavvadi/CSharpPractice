using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace ExceptionHandlingTest
{
    public class CustomExceptions
    {
        public void Test()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in. No duplicates allowed");
            }
            catch(UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {
        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {
        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {
        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
  
}