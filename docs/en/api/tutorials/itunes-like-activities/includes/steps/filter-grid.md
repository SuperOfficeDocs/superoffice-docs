<!-- markdownlint-disable-file MD041 -->
Once the data are retrieved we can filter the data according to the search text specified by the user.

[!code-csharp[CS](../itunes-searchtext.cs)]

The `DataGridViewRow` collection of the data grid view is iterated for each activity data row and the Description column is checked to see if the description contains the search text. If the activity description does not contain the specified text the row is made invisible. This method is invoked in the `TextChanged` event of the search text box as shown below.

```csharp
using (SoSession newSession = SoSession.Authenticate("p", "p"))
{
  // populate the grid with all the activities for the given period
  this.setDataGrid();

  // filter the records
  this.searchText();
}
```
