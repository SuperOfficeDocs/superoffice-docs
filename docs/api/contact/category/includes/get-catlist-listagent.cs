using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the list agent
  using(ListAgent listAgent = new ListAgent())
  {
    //retrieve the category list using the methods of the agent
    Category[] catList =  listAgent.GetCategories();

    //loop through the list and output the value to the console
    foreach (Category item in catList)
    {
      if (item != null)
      {
        Console.WriteLine(item.Value);
      }
    }
  }
}