
namespace BestPractices
{
	public class CodePractices
    {
        ///<summary>
        ///This is a C sharp class for Describing Best Coding practices with C#
        /// </summary>
        /// 
        /// <para>
        /// Here, I'll take you through the best coding practices I learnt 
        /// </para>
        /// 
        /// <list>
        /// <item>
        /// 
        /// 1. Use Descriptive variabe names to prevent confusion
        /// 
        /// <example>
        /// This is a good example
        /// <code>
        /// int Age = 3;
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// int a = 3;
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// <item>
        /// 
        /// 2. A function should have a sigle responsibility
        /// 
        /// <example>
        /// This is a good example
        /// <code>
        ///  public void UpdateAddress(Address address) {}  
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// public void SaveAddress(Address address) {  
        ///     if (address.AddressId == 0) {} else {}  
        ///         }
        ///
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// <item>
        /// 
        /// 3. Avoid using common type system. Use the language specific aliases
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// int age;  
        /// string firstName;
        /// object addressInfo;
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// System.Int32 age; String firstName;  
        /// Object addressInfo;  
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// <item>
        /// 
        /// 4. Use String.Empty instead of “ ”
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  if (firstName == String.Empty) {}
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  if (firstName == “”) {}   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        /// 
        ///  <item>
        /// 
        /// 5. Use enums wherever required. Don’t use numbers or strings to indicate discrete values.

        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  public enum LoggerType {  
        ///        Event,  
        ///    File,  
        ///    Database
        ///    }
        ///    public void LogException(string message, LoggerType loggerType)
        ///    {
        ///        switch (loggerType)
        ///        {
        ///            case LoggerType.Event:
        ///            // Do something break;  
        ///            case LoggerType.File:
        ///            // Do something break;  
        ///            case LoggerType.Database:
        ///            // Do something break;  
        ///            default:
        ///                // Do something break;  
        ///        }
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   public void LogException(string message, LoggerType loggerType) {  
        ///        switch (loggerType) {  
        ///            case "Event":  
        ///                // Do something break;  
        ///            case "File":  
        ///                // Do something break;  
        ///            case "Database":  
        ///                // Do something break;  
        ///            default:  
        ///                // Do something break;  
        ///        }
        ///    }   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        /// 
        ///  <item>
        /// 
        /// 6.Always do null check for objects and complex objects before accessing them
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///   public Contact GetContactDetails(Address address) {  
        ///        if (address != null && address.Contact != null) {  
        ///            return address.Contact;  
        ///        }
        ///    }  
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   public Contact GetContactDetails(Address address) {  
        ///             return address.Contact;  
        ///         }
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        ///  <item>
        /// 
        /// 
        /// 
        /// 7. Error message to end use should be user friendly and
        /// self-explanatory but log the actual exception details using logger.
        /// Create constants for this and use them in application.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///   “Your session has been expired. Please login again.”
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// " There is an error" 
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        /// 
        ///  8.Avoid passing many parameters to function.
        ///  If you have more than 4-5 parameters use class or structure to pass it.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// 
        ///  public void UpdateAddress(Address address) {}
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   public void UpdateAddress(int addressId, string country, string state, string phoneNumber, string pinCode, string address1, string address2) {}   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        ///  9. Use object initializers to simplify object creation
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  var employee = new Employee {  
        ///            FirstName = “ABC”, LastName = “PQR”, Manager = “XYZ”, Salary = 12346.25  
        ///    };
        /// </code>
        /// 
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///   var employee = new Employee();  
        ///             employee.FirstName = “ABC”;  
        ///     employee.LastName = “PQR”;  
        ///     employee.Manager = “XYZ”;  
        ///     employee.Salary = 12346.25;   
        /// </code>
        /// </example>
        /// 
        /// 
        /// 
        /// </item>
        /// 
        /// 
        ///  10.The using statements should be sort by framework namespaces first and
        ///  then application namespaces in ascending order
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// using System;  
        /// using System.Collections.Generic; 
        /// using System.IO;  
        /// using System.Text;  
        /// using Company.Product.BusinessLayer;  
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// 
        ///   using System.IO;  
        /// using System.Text;  
        /// using Company.Product.BusinessLayer; 
        ///  using System;  
        /// using System.Collections.Generic; 
        /// 
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        ///  <item>
        /// 
        /// 11. Simplify your code by using the C# using statement.
        /// If you have a try-finally statement in which the only code in the
        /// finally block is a call to the Dispose method, use a using statement instead
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// using(var fileToOpen = new FileInfo(fileName)) {  
        ///      // File operation  
        ///     }
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  if (firstName == “”) {}   
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        ///  12. Always catch only the specific exception instead of catching generic exception.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// void ReadFile(string fileName) {  
        ///  try {  
        ///      // read from file.  
        ///  } catch (System.IO.IOException fileException) {  
        ///      // log the error. Re-throw exception throw fileException;  
        ///  } finally {}
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  void ReadFile(string fileName) {  
        /// try {  
        ///     // read from file.  
        /// } catch (Exception ex) {  
        ///     // catching general exception  
        /// } finally {}  
        /// }    
        /// </code>
        /// 
        /// </example>
        /// 
        /// </item>
        /// 
        /// 
        ///  <item>
        /// 
        /// 13. use PascalCasing for class names and method names.
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// public class ClientActivity
        /// {
        ///     public void ClearStatistics()
        ///         {
        ///             //...
        ///         }
        ///         public void CalculateStatistics()
        ///         {
        ///             //...
        ///         }
        ///     }
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        /// public class clientActivity
        /// {
        ///     public void clearStatistics()
        ///         {
        ///             //...
        ///         }
        ///         public void calculateStatistics()
        ///         {
        ///             //...
        ///         }
        ///     }  
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        ///  <item>
        /// 
        /// 14. Don't use Screaming Caps for constants or readonly variables
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        ///  public static const string ShippingType = "DropShip";
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  public static const string SHIPPINGTYPE = "DropShip";
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        ///  15. use predefined type names instead of system type names like Int16, Single, UInt64, etc
        /// 
        /// <example>
        /// 
        /// This is a good example
        /// 
        /// <code>
        /// 
        /// string firstName;
        /// int lastIndex;
        /// bool isSaved;
        /// 
        /// </code>
        /// 
        /// This is a bad example
        /// 
        /// <code>
        ///  String firstName;
        ///    Int32 lastIndex;
        ///    Boolean isSaved;
        /// </code>
        /// </example>
        /// 
        /// </item>
        /// 
        /// </list>
        /// 
        /// 


    }
}
