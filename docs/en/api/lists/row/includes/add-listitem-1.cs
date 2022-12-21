using SuperOffice;
using SuperOffice.CRM.Rows;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //create a category row
  CategoryRow myCategory = CategoryRow.CreateNew();
  myCategory.SetDefaults();

  //give it a name
  myCategory.Name = "This is a category test";

  //set the rank
  myCategory.Rank = 5;

  //give a tool tip
  myCategory.Tooltip = "This is test tooltip";

  //save the row
  myCategory.Save();

  //create a category group link row
  CategoryGroupLinkRow myGroupLinkRow = CategoryGroupLinkRow.CreateNew();

  //set the group ID that you want
  myGroupLinkRow.GroupId = 2;

  //set the category ID
  myGroupLinkRow.CategoryId = myCategory.CategoryId;

  //save the category row
  myGroupLinkRow.Save();
}