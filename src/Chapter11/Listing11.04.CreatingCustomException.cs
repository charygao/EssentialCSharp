using System.Runtime.Serialization;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_04
{
    #region INCLUDE
    class DatabaseException : Exception
    {
        public DatabaseException(
            string? message,
            System.Data.SqlClient.SQLException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException(
            string? message,
            System.Data.OracleClient.OracleException? exception)
            : base(message, innerException: exception)
        {
            // ...
        }

        public DatabaseException()
        {
            // ...
        }

        public DatabaseException(string? message)
            : base(message)
        {
            // ...
        }

        public DatabaseException(
            string? message, Exception? exception)
            : base(message, innerException: exception)
        {
            // ...
        }
        #region EXCLUDE
        // ���ڷ����л��쳣
        public DatabaseException(
            SerializationInfo serializationInfo,
            StreamingContext context)
            : base(serializationInfo, context)
        {
            //...
        }
        #endregion EXCLUDE
    }
    #endregion INCLUDE

    // �������ݿ��쳣���ģ��汾��������������ʵ�Ŀ�
#pragma warning disable CA1032 // Implement standard exception constructors
    namespace System.Data
    {
        namespace SqlClient
        {
            class SQLException : Exception
            {
            }
        }
        namespace OracleClient
        {
            class OracleException : Exception
            {
            }
        }
    }
#pragma warning restore CA1032 // Implement standard exception constructors
}

