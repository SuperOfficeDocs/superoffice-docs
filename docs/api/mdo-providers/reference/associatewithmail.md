---
uid: associatewithmail
title: associatewithmail
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "associatewithmail"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "associatewithmail" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.AssociateWithMailProvider">AssociateWithMailProvider</see> class.
The name of the MDO list is 'associatewithmail'.




## Sample Request

```http!
GET /api/v1/MDOList/associatewithmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("associatewithmail", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0|||
|12|Adm1|||
|13|Adm2|||
|14|Adm3|||
|15|Adm4|||
|16|Adm5|||
|1|Admin Adminson <qa.testbruker@superoffice.com>|||
|63|AdmNS02 NetServer|||
|2|Arne Arnesen <qa.testbruker@superoffice.com>|||
|3|Brede Bredesen <qa.testbruker@superoffice.com>|||
|4|Cato Carlsson <qa.testbruker@superoffice.com>|||
|5|Donald Duck <qa.testbruker@superoffice.com>|||
|6|Erik Eide <qa.testbruker@superoffice.com>|||
|7|Frode Freestad <qa.testbruker@superoffice.com>|||
|8|Geir Grønbeck <qa.testbruker@superoffice.com>|||
|9|Hans Hansen <qa.testbruker@superoffice.com>|||
|10|Ingrid Istad <qa.testbruker@superoffice.com>|||
|86|Johan Jensen|||
|87|Kjell Jensen|||
|81|Listadm Listadm|||
|84|Localuser2 Localuser2|||


## Related MDO Lists

* "associatewithmailheadings"
* "associatewithmailheadingswithallitem"
* "associatewithmailheadingswithallitemwithnoselection"
* "associatewithmailheadingswithnoselection"
* "associatewithmailwithallitem"
* "associatewithmailwithallitemwithnoselection"
* "associatewithmailwithnoselection"
