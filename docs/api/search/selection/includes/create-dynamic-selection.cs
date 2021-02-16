using SuperOffice.CRM.Entities;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0",""))
{
//create a new selection
  Selection mySelection = Selection.CreateNew();
  mySelection.SetDefaults();

  //set the selection type to Dynamic
  mySelection.Seltype = 1;

  //we will include the first person from each company in our selection
  mySelection.IncludePerson = 1;

  //give it a name
  mySelection.Name = "Dynamic selection with couple of criteria";

  //save the selection
  mySelection.Save();

  //create a restriction array since we are going to give more than one
  // restriction to add members to our selection
  ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[2];

  //specify the first restriction
  restrictions[0] = new ArchiveRestrictionInfo("business", "is", "4");

  //specify the second restriction. Here we are restricting the contact
  //to the contacts that starts with “c”
  restrictions[1] = new ArchiveRestrictionInfo("name", "begins", "c");

  //to store our selection restriction we need a restriction storage
  IRestrictionStorage storage = RestrictionStorageFactory.GetProvider(RestrictionCriteriaStorage.StorageType);

  //save the restriction using the provider name and the selection ID
  //as the storage key
  storage.SaveRestrictions(SelectionDynamicProvider.ProviderName, "selection=" + mySelection.SelectionId.ToString(),restrictions);
}