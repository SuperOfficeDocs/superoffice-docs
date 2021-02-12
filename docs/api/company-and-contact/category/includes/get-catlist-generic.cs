using SuperOffice;
using SuperOffice.CRM.Lists;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
    ISoListProvider categoryList = SoListProviderFactory.Create("category");
    //Retrieving the History items of the AssociateList
    if (categoryList.HistoryItems.Count > 0)
    {
        foreach (ISoListItem item in categoryList.HistoryItems)
        {
            string historyString;
            historyString = item.Id + " " + item.Name;
            HistoryListView.Items.Add(historyString);
        }
    }
    //Retrieving the HeadingItems of the AssociateList
    if (categoryList.HeadingItems.Count > 0)
    {
       foreach (ISoListHeading item in categoryList.HeadingItems)
       {
           string headingString;
           headingString = item.Heading.Id + " " + item.Heading.Name;
           HeadingListView.Items.Add(headingString);
       }
    }
    //Retrieving the RootItm
    if (categoryList.RootItems.Count > 0)
    {
       foreach (ISoListItem item in categoryList.RootItems)
       {
           string rootString;
           rootString = item.Id + " " + item.Name;
           RootListView.Items.Add(rootString);
       }
    }
}