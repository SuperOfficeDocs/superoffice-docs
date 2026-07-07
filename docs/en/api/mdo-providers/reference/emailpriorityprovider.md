---
uid: emailpriorityprovider
title: emailpriorityprovider
keywords: mdoprovider mdo provider emailpriorityprovider
description: MDO List provider for email priority - Highest, High, Normal, Low, Lowest, No Priority. Enum value in the extrainfo field
generated: true
content_type: reference
envir: onsite, online
---

# "emailpriorityprovider" MDO List
MDO List provider for email priority: Highest, High, Normal, Low, Lowest, No Priority.
Enum value in the extrainfo field



Implemented by the <see cref="T:SuperOffice.CRM.Lists.EMailPriorityProvider">EMailPriorityProvider</see> class.
The name of the MDO list is 'emailpriorityprovider'.




## Sample Request

```http!
GET /api/v1/MDOList/emailpriorityprovider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("emailpriorityprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Highest||Highest|
|2|High||High|
|3|Normal||Normal|
|4|Low||Low|
|5|Lowest||Lowest|
|0|None||NoPriority|


## Related MDO Lists

* "emailpriorityproviderheadings"
* "emailpriorityproviderheadingswithallitem"
* "emailpriorityproviderheadingswithallitemwithnoselection"
* "emailpriorityproviderheadingswithnoselection"
* "emailpriorityproviderwithallitem"
* "emailpriorityproviderwithallitemwithnoselection"
* "emailpriorityproviderwithnoselection"
