usingSystem;
usingSystem.Collections.Generic;
usingSystem.Text;

using SuperOffice.CRM.Lists;
using SuperOffice.Factory;
using SuperOffice.Data;

namespace Plugin
{
  [MDOProviderPlugin("country")]
  public class DemoListPlugin : MDOProviderBase
  {
    // Initialize the class
    public DemoListPlugin()
    {
    }

    public override void Construct(string tableName, string additionalInfo, int[] historyIDs, bool onlyReadHistory, string searchValue, bool forceFlatList)
    {
      //here we specify from which table the list should be made
      base.Construct("country", additionalInfo, historyIDs,
      onlyReadHistory, searchValue, forceFlatList);
      //here we say we want a extra entry in the list. this is the
      //modification we are doing to the list.
      RootItems.Insert(0,new SoListItem(-1, "Default Country","Default Country", string.Empty));
    }

    public override HistoryInfo HistoryInfo
    {
      //specify where the history info should come from
      get { return new HistoryInfo("country", "country", 0);
    }
  }
}