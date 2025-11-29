admin
admin@local.com
admin


{
    "Result": false,
    "Message": "Server Error - {this.HttpStatusInternalServerError}",
    "Data": "System.Data.SqlClient.SqlException (0x80131904): Must declare the scalar variable \"@Emai\".\r\n   at System.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)\r\n   at System.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)\r\n   at System.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)\r\n   at System.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)\r\n   at System.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean async, Int32 timeout, Task& task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)\r\n   at System.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method, TaskCompletionSource`1 completion, Int32 timeout, Task& task, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry)\r\n   at System.Data.SqlClient.SqlCommand.InternalExecuteNonQuery(TaskCompletionSource`1 completion, String methodName, Boolean sendToPipe, Int32 timeout, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry)\r\n   at System.Data.SqlClient.SqlCommand.ExecuteNonQuery()\r\n   at vipel.Services.SQLServer.UserInsert(User user) in C:\\Users\\user\\source\\ault_git\\ds4\\vipel\\vipel\\Services\\SQLServer.cs:line 146\r\nClientConnectionId:2935c77e-51e0-417a-b75b-a1ae2648252a\r\nError Number:137,State:2,Class:15"
}



CREATE PROCEDURE [dbo].CheckLogin
    @Username NVARCHAR(256),
    @Email NVARCHAR(256),
    @Password VARCHAR(600)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Result BIT = 0;
    SELECT CustomerID, CustomerName FROM Customers;
    IF EXISTS (
        SELECT 1
        FROM [dbo].[User]
        WHERE [Username] = @Username AND [Email] = @Email AND [Password] = @Password
    )
    SET @Result = 1;

    RETURN @Result;
END
GO





/login

{
    "Result": false,
    "Message": "Server Error - HttpStatusInternalServerError",
    "Data": "System.InvalidOperationException: Invalid attempt to read when no data is present.\r\n   at Microsoft.Data.SqlClient.SqlDataReader.CheckDataIsReady(Int32 columnIndex, Boolean allowPartiallyReadColumn, Boolean permitAsync, String methodName)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.TryReadColumn(Int32 i, Boolean setTimeout, Boolean allowPartiallyReadColumn, Boolean forStreaming)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.GetValueInternal(Int32 i)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.GetValue(Int32 i)\r\n   at vipel.Services.SQLServer.UserLogin(User user) in C:\\Users\\user\\source\\ault_git\\ds4\\vipel\\vipel\\Services\\SQLServer.cs:line 131"
}

"System.InvalidOperationException: Invalid attempt to read when no data is present.\r\n   at Microsoft.Data.SqlClient.SqlDataReader.CheckDataIsReady(Int32 columnIndex, Boolean allowPartiallyReadColumn, Boolean permitAsync, String methodName)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.TryReadColumn(Int32 i, Boolean setTimeout, Boolean allowPartiallyReadColumn, Boolean forStreaming)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.GetValueInternal(Int32 i)\r\n   at Microsoft.Data.SqlClient.SqlDataReader.GetValue(Int32 i)\r\n   at vipel.Services.SQLServer.UserLogin(User user) in C:\\Users\\user\\source\\ault_git\\ds4\\vipel\\vipel\\Services\\SQLServer.cs:line 133"

"System.InvalidOperationException: Invalid attempt to read when no data is present.
   at Microsoft.Data.SqlClient.SqlDataReader.CheckDataIsReady(Int32 columnIndex, Boolean allowPartiallyReadColumn, Boolean permitAsync, String methodName)
   at Microsoft.Data.SqlClient.SqlDataReader.TryReadColumn(Int32 i, Boolean setTimeout, Boolean allowPartiallyReadColumn, Boolean forStreaming)
   at Microsoft.Data.SqlClient.SqlDataReader.GetValueInternal(Int32 i)
   at Microsoft.Data.SqlClient.SqlDataReader.GetValue(Int32 i)
   at vipel.Services.SQLServer.UserLogin(User user) in C:\Users\user\source\ault_git\ds4\vipel\vipel\Services\SQLServer.cs:line 133"
   
   
https://stackoverflow.com/questions/20621950/asp-net-identitys-default-password-hasher-how-does-it-work-and-is-it-secure

https://medium.com/@startfromlocalhost/storing-passwords-securely-in-net-a-beginner-friendly-guide-to-hashing-and-salting-992be9088129


https://learn.microsoft.com/en-us/dotnet/standard/security/cross-platform-cryptography

https://stackoverflow.com/questions/20621950/asp-net-identitys-default-password-hasher-how-does-it-work-and-is-it-secure

https://stackoverflow.com/questions/14242789/how-to-compare-two-base64-string


https://www.youtube.com/watch?v=ydUxs-1HHB8


https://stackoverflow.com/questions/63769243/checking-if-hashed-values-are-the-same
https://crackstation.net/hashing-security.htm


https://stackoverflow.com/questions/78441140/rfc2898derivebytes-is-very-slow-in-c-sharp-net-framework-version-4-8


https://www.youtube.com/watch?v=1xOS8lCVtoA
---------------------------------------------------

You code works, but it could be improved. If I understood it correctly an attacker could steal an open session of a user, if he would be able to guess the hashed user token.

Your current comparison returns false, as soon as the first byte is not equal. So an unequality on an earlier position returns faster than a difference on a later position. An attacker could use a timing attack on the response time to reverse engineer the current token. Therefore you should use a slow equals method, that always compare all bytes in the array and always spends the same time to compare the values.

java

private static boolean slowEquals(byte[] a, byte[] b) {
    int diff = a.length ^ b.length;
    for(int i = 0; i < a.length && i < b.length; i++) {
        diff |= a[i] ^ b[i];
    }
    return diff == 0;
}

here is a good ready about hasing and security: https://crackstation.net/hashing-security.htm also explaining the timing attack problem.


Simulant

https://stackoverflow.com/questions/63769243/checking-if-hashed-values-are-the-same
https://crackstation.net/hashing-security.htm
