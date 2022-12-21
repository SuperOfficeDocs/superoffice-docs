using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.Rows;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Creating a Category Row
  CategoryRow newCategoryRw = CategoryRow.CreateNew();

  //Assigning default values to the created Category Row
  newCategoryRw.SetDefaults();

  //Assinging values to the Properties of the Country Row
  newCategoryRw.Name = "Cat-Dush";
  newCategoryRw.Rank = 11;

  //Saving the Category Row
  newCategoryRw.Save();

  //Adding GroupLInk Table Values
  CategoryGroupLinkRow newCategoryGrLiRw1 = CategoryGroupLinkRow.CreateNew();
  newCategoryGrLiRw1.SetDefaults();
  newCategoryGrLiRw1.CategoryId = newCategoryRw.CategoryId;
  newCategoryGrLiRw1.GroupId = 3;
  newCategoryGrLiRw1.Save();

  CategoryGroupLinkRow newCategoryGrLiRw2 = CategoryGroupLinkRow.CreateNew();
  newCategoryGrLiRw2.SetDefaults();
  newCategoryGrLiRw2.CategoryId = newCategoryRw.CategoryId;
  newCategoryGrLiRw2.GroupId = 2;
  newCategoryGrLiRw2.Save();

  //Adding HeadingLInk Table Values
  CategoryHeadingLinkRow newCategoryHeLiRw1 = CategoryHeadingLinkRow.CreateNew();
  newCategoryHeLiRw1.SetDefaults();
  newCategoryHeLiRw1.CategoryId = newCategoryRw.CategoryId;
  newCategoryHeLiRw1.HeadingId = 6;
  newCategoryHeLiRw1.Save();
}