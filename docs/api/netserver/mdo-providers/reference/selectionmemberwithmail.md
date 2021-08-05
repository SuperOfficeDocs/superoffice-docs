---
uid: selectionmemberwithmail
title: selectionmemberwithmail
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "selectionmemberwithmail"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "selectionmemberwithmail" MDO List
List of selection members fetched based on provided criteria
Output is in format: "[ContactName, Department/PersonFullName] &lt;registered@email.com&gt;"
Ex:
"Contact, Department &lt;registered@email.com&gt;"
"Person Name &lt;registered@email.com&gt;"



Implemented by the <see cref="T:SuperOffice.CRM.Lists.SelectionMemberWithMailListProvider">SelectionMemberWithMailListProvider</see> class.
The name of the MDO list is 'selectionmemberwithmail'.




## Sample Request

```http!
GET /api/v1/MDOList/selectionmemberwithmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("selectionmemberwithmail", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
| 2 | Example | | |


## Related MDO Lists

* "selectionmemberwithmailheadings"
* "selectionmemberwithmailheadingswithallitem"
* "selectionmemberwithmailheadingswithallitemwithnoselection"
* "selectionmemberwithmailheadingswithnoselection"
* "selectionmemberwithmailwithallitem"
* "selectionmemberwithmailwithallitemwithnoselection"
* "selectionmemberwithmailwithnoselection"
