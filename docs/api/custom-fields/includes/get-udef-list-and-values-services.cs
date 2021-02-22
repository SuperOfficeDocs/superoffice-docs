using SuperOffice.CRM.Services;
using SuperOffice;

try
{
  using (SoSession newSession = SoSession.Authenticate("sal0", ""))
  {
    Console.Write("Please enter the contact id : ");

    // Read the contact id
    String contactId = Console.ReadLine();
    Console.WriteLine("");

    // Check if a contact id entered
    if (!(String.IsNullOrEmpty(contactId.Trim())))
    {
      // Create a Contact Agent
      IContactAgent agent = new ContactAgent();

      // Get a Contact Entity through the Contact Agent
      ContactEntity contactEntity = agent.GetContactEntity(int.Parse(contactId.Trim()));

      // Create a IUserDefinedFieldInfoAgent
      IUserDefinedFieldInfoAgent udefFieldInfoAgent = new UserDefinedFieldInfoAgent();

      // Get the User defined field list on 'Contact'
      UserDefinedFieldInfo[] udefFieldInfo= udefFieldInfoAgent.GetUserDefinedFieldList(7);

      // Print the contact member details
      Console.WriteLine("User defined field list for the contact " + contactEntity.Name);
      Console.WriteLine("");
      foreach (UserDefinedFieldInfo field in udefFieldInfo)
      {
        string labelName = field.FieldLabel;
        string fieldValue = contactEntity.UserDefinedFields[field.ProgId];
        Console.WriteLine("Field Name = " + labelName + "    Value = " + fieldValue);
      }
      Console.ReadKey();
    }
    else
    {
      Console.WriteLine("Please enter the contact id.");
      Console.ReadKey();
    }
  }
}
catch (Exception ss)
{
  Console.WriteLine(ss.Message);
  Console.ReadKey();
}