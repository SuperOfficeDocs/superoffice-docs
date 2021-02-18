using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Globalization;
using SuperOffice.Util;

using (SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Initializing the FindAgent
  using(FindAgent newFindAgt = new FindAgent())
  {
    //Declaration of the Local variable
    string storageType = "Criteria";
    string providerName = "findcontact";
    string storageKey = "associate=1236";
    string[] staticColumns = new string[] { "name", "firstName", "lastName" };

    //Making use of a method exposed in the FindAgent
    //GetAvailableRestrictionColumns - which Gets a list of
    //the column names corresponding to available restrictions for
    //a certain archive provider and restriction storage provider.
    string[] handledColumns = newFindAgt.GetAvailableRestrictionColumns(storageType, providerName);

    //GetSpecifiedCriteriaInformationWithDefaults - Get criteria information from a
    //set of saved criteria, for a specific set of columns.
    CriteriaInformation criteria = newFindAgt.GetSpecifiedCriteriaInformationWithDefaults(storageType, providerName, storageKey, handledColumns, staticColumns);

    //Represents a list of keys and values i.e columns and the conditions.
    Dictionary<string, ArchiveRestrictionInfo> restrictions = ArchiveRestrictionInfo.ToNameDictionary( criteria.Restrictions );

    //Setting the restriction for specific columns
    //Udef fields may not run depending on the database.
    //string values
    restrictions["lastName"].SetValue("Tester 5");
    restrictions["lastName"].IsActive = true;
    restrictions["firstName"].SetValue("Tester 5");
    restrictions["firstName"].Operator = "contains";
    restrictions["firstName"].IsActive = true;

    //int values
    restrictions["personId"].SetValue( "215" );
    restrictions["contactId"].SetValue( "100", "143" );
    restrictions["contactId"].Operator = "between";

    //list
    restrictions["position"].SetValue( "1" );
    restrictions["category"].SetValue( "1", "2", "3", "4" );

    //bool
    restrictions["nomailings"].SetValue(true.ToString()); 
    restrictions["contactUdef/SuperOffice:6"].SetValue("1");

    //decimal
    restrictions["contactUdef/SuperOffice:8"].SetValue(CultureDataFormatter.EncodeDouble(1.4));
    restrictions["personUdef/SuperOffice:8"].SetValue(CultureDataFormatter.EncodeDouble(1.8), CultureDataFormatter.EncodeDouble(2.6));
    restrictions["personUdef/SuperOffice:8"].Operator = "between";
    restrictions["personUdef/SuperOffice:8"].IsActive = true;

    //datetime
    restrictions["contactUdef/SuperOffice:4"].SetValue(CultureDataFormatter.EncodeDate(DateTime.Now));

    //Save the restrictions so that it may be used later as search criteria
    newFindAgt.SaveRestrictions(storageType, providerName, storageKey, CollectionOps.DictionaryValuesToArray(restrictions));
  }
}