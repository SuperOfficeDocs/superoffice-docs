using System;
using System.Collections.Generic;
using System.Text;
using SuperOffice.COM.DictionarySDK;

namespace CustomTableWithSentry
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        // Create a new dictionary
        Dictionary dictionary = new Dictionary();
        // set the database
        dictionary.SetDatabase("ODBC:SuperOffice", "TJE0", "tje0", "CRM5");

        // Create the table
        Table table;
        table = dictionary.CreateTable("SuperOfficeTrainingTable");
        table.Description = "Detailed information about the new table";
        table.NetServerName = "SuperOfficeTrainingTable";
        table.ReplicateDown = false;
        table.ReplicateToPrototype = false;
        table.ReplicateUp = false;
       
        // Create foreign keys
        Field fkField = table.CreateForeignKey("Associate", ERelationCardinality.enOneToMany);
        fkField.Description = "This is the key of the Associate table.";
        fkField.AddImportName(1034, "ImportNameOfASSForeignKey");
        fkField.NetServerName = "Associate";

        // Create foreign keys
        Field fkField2 = table.CreateForeignKey("Business", ERelationCardinality.enOneToMany);
        fkField2.Description = "This is the key of the Business table.";
        fkField2.AddImportName(1033, "ImportNameOfBusinessForeignKey");
        fkField2.NetServerName = "Business";

        dictionary.CommitChanges();
        Console.WriteLine("Done.");
      }
        catch (Exception exp) { Console.WriteLine(exp.Message);
      }
    }
  }
}