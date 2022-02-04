using SuperOffice;
using SuperOffice.CRM.Rows;
using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Retrieve a Contact
  Contact newContact = Contact.GetFromIdxContactId(10);

  //Create a new ContIntRow. Each row represents one row in the ContInt table.
  ContIntRow newConInt = ContIntRow.CreateNew();
  newConInt.SetDefaults();
  newConInt.ElementType = MDOListElementType.SubNode;
  newConInt.Name = "Sam's Interest";
  newConInt.Tooltip = "Sam's Interests";
  newConInt.Save();

  //Create a New ContactInterestRow. Each row represents one row in the ContactInterest table.
  ContactInterestRow newconIntRw = ContactInterestRow.CreateNew();
  newconIntRw.SetDefaults();
  newconIntRw.CinterestIdx = newConInt.ContIntId;
  newconIntRw.ContactId = newContact.ContactId;
  newconIntRw.EndDate = DateTime.MaxValue;
  newconIntRw.StartDate = DateTime.MinValue;
  newconIntRw.Save();

  //Create a new ContIntGroupLinkRow. Each row represents one row in the ContIntGroupLink table.
  // You would need to create a new row for each group that you require the interest to be visible for.
  ContIntGroupLinkRow newContGrpLink = ContIntGroupLinkRow.CreateNew();
  newContGrpLink.SetDefaults();
  newContGrpLink.ContIntId = newConInt.ContIntId;
  newContGrpLink.GroupId = SoContext.CurrentPrincipal.GroupId;
  newContGrpLink.Save();

  //Since the ContInt is defined as a SubItem, we need to give a header to fall under.
  //For this we create a new ContIntHeadingLinkRow. Each row represents one row in the ContIntHeadingLink table.
  ContIntHeadingLinkRow newContHeadingRow = ContIntHeadingLinkRow.CreateNew();
  newContHeadingRow.SetDefaults();
  newContHeadingRow.ContIntId = newConInt.ContIntId;

  //looking up and assigning the heading Id.                  
  newContHeadingRow.HeadingId = newContact.InterestHelper.HeadingItems[0].Heading.Id;
  newContHeadingRow.Save();
}