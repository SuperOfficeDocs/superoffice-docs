using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a category table and a categoryheading table
  CategoryTableInfo categoryTable = TablesInfo.GetCategoryTableInfo();
  CategoryHeadingLinkTableInfo categoryHeading = TablesInfo.GetCategoryHeadingLinkTableInfo();

  //Writing the Query to retrieve the Items coming under each heading in the categoryheadinglink table
  Select selectCategory = S.NewSelect();
  selectCategory.ReturnFields.Add(categoryTable.CategoryId, categoryTable.Name, categoryHeading.HeadingId);
  selectCategory.JoinRestriction.LeftOuterJoin(categoryTable.CategoryId.Equal(categoryHeading.CategoryId));
  selectCategory.GroupBy.Grouping.Add(categoryHeading.HeadingId, categoryTable.CategoryId, categoryTable.Name);
  SoConnection con = ConnectionFactory.GetConnection();
  SoCommand cmd = con.CreateCommand();
  cmd.SqlCommand = selectCategory;
  con.Open();

  //Execute the Query
  SoDataReader reader = cmd.ExecuteReader();

  //Write the category ID, category name, and heading ID on the list view
  while (reader.Read())
  {
    ListView.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
  }
}