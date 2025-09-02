---
uid: associaterestrictions
title: associaterestrictions
keywords: mdoprovider mdo provider associaterestrictions
description: Public MDO provider based on the AssociateRestrictionsMDOProviderBase.
generated: true
content_type: reference
envir: onsite, online
---

# "associaterestrictions" MDO List
Public MDO provider based on the AssociateRestrictionsMDOProviderBase.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.AssociateRestrictionsMDOProvider">AssociateRestrictionsMDOProvider</see> class.
The name of the MDO list is 'associaterestrictions'.




## Sample Request

```http!
GET /api/v1/MDOList/associaterestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("associaterestrictions", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0||person_id=147&contact_id=0|
|12|Adm1||person_id=148&contact_id=0|
|13|Adm2||person_id=149&contact_id=0|
|14|Adm3||person_id=150&contact_id=0|
|15|Adm4||person_id=151&contact_id=0|
|16|Adm5||person_id=152&contact_id=0|
|106|Adm6||person_id=223&contact_id=0|
|1|Admin Adminson||person_id=9&contact_id=0|
|63|AdmNS02 NetServer||person_id=183&contact_id=0|
|2|Arne Arnesen||person_id=10&contact_id=0|
|3|Brede Bredesen||person_id=11&contact_id=0|
|4|Cato Carlsson||person_id=12&contact_id=0|
|5|Donald Duck||person_id=13&contact_id=0|
|6|Erik Eide||person_id=14&contact_id=0|
|7|Frode Freestad||person_id=15&contact_id=0|
|8|Geir Grønbeck||person_id=16&contact_id=0|
|9|Hans Hansen||person_id=17&contact_id=0|
|10|Ingrid Istad||person_id=18&contact_id=0|
|86|Johan Jensen||person_id=198&contact_id=0|
|87|Kjell Jensen||person_id=199&contact_id=0|
|81|Listadm Listadm||person_id=190&contact_id=0|


## Related MDO Lists

* "associaterestrictionsheadings"
* "associaterestrictionsheadingswithallitem"
* "associaterestrictionsheadingswithallitemwithnoselection"
* "associaterestrictionsheadingswithnoselection"
* "associaterestrictionswithallitem"
* "associaterestrictionswithallitemwithnoselection"
* "associaterestrictionswithnoselection"
