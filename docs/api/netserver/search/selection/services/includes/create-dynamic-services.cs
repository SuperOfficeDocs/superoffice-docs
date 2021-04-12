using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Globalization;
using SuperOffice.Util;

using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Initializing the FindAgent
  using(FindAgent newFindAgt = new FindAgent())
  {
    //Declaration of the Local variable
    string storageType = "Criteria";
    string providerName = "ContactDynamicSelection";
    string storageKey = "selection=61";
    string[] staticColumns = new string[] { "name", "contactId" };

    //Making use of a method exposed in the IFindAgent
    //GetAvailableRestrictionColumns - which Gets a list of
    //the column names corresponding to available restrictions for
    //a certain archive provider and restriction storage provider.
    string[] handledColumns = newFindAgt.GetAvailableRestrictionColumns(storageType, providerName);

    //GetSpecifiedCriteriaInformationWithDefaults - Get criteria information from a
    //set of saved criteria, for a specific set of columns.
    CriteriaInformation criteria = newFindAgt.GetSpecifiedCriteriaInformationWithDefaults(storageType, providerName, storageKey, handledColumns, staticColumns);

    //Represents a list of keys and values i.e columns and the conditions.
    Dictionary<string, ArchiveRestrictionInfo> restrictions = ArchiveRestrictionInfo.ToNameDictionary(criteria.Restrictions);

    //Setting the restriction for specific columns
    //Udef fields may not run depending on the database.
    //string values
    //Restriction 1
    restrictions["associateId"].SetValue("103");
    restrictions["associateId"].IsActive = true;

    //Restriction 2
    restrictions["name"].SetValue("est");
    restrictions["name"].Operator = "contains";
    restrictions["name"].IsActive = true;

    //Save the restrictions so that it may be used later as search criteria
    newFindAgt.SaveRestrictions(storageType, providerName, storageKey, CollectionOps.DictionaryValuesToArray(restrictions));
  }
}