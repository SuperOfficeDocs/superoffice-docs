---
uid: projectassociate
title: projectassociate
keywords: mdoprovider mdo provider projectassociate
description: MDO provider for associates that are members of a project
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "projectassociate" MDO List
MDO provider for associates that are members of a project



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ProjectAssociateMDOProvider">ProjectAssociateMDOProvider</see> class.
The name of the MDO list is 'projectassociate'.




## Sample Request

```http!
GET /api/v1/MDOList/projectassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("projectassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|15|Adm4||person_id=151&contact_id=2|
|2|Arne Arnesen||person_id=10&contact_id=2|
|3|Brede Bredesen||person_id=11&contact_id=2|
|4|Cato Carlsson||person_id=12&contact_id=2|
|5|Donald Duck||person_id=13&contact_id=2|
|7|Frode Freestad||person_id=15&contact_id=2|
|8|Geir Grønbeck||person_id=16&contact_id=2|
|9|Hans Hansen||person_id=17&contact_id=2|
|10|Ingrid Istad||person_id=18&contact_id=2|
|81|Listadm Listadm||person_id=190&contact_id=2|
|96|Niels Jensen||person_id=55&contact_id=21|


## Related MDO Lists

* "projectassociateheadings"
* "projectassociateheadingswithallitem"
* "projectassociateheadingswithallitemwithnoselection"
* "projectassociateheadingswithnoselection"
* "projectassociatewithallitem"
* "projectassociatewithallitemwithnoselection"
* "projectassociatewithnoselection"
