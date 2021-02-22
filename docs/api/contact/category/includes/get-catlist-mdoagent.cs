using SuperOffice;
using SuperOffice.CRM.Services;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //get the MDO agent
  using(MDOAgent mdoAgent = new MDOAgent())
  {
    MDOListItem[] categoryList =
    mdoAgent.GetSimpleList("category");

    //loop through the retrived list and output them on the console
    foreach (MDOListItem item in categoryList)
    {
      Console.WriteLine(item.Name);
    }
  }
}