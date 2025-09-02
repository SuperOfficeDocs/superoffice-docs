---
uid: visibleforassociate
title: visibleforassociate
keywords: mdoprovider mdo provider visibleforassociate
description: List provider that returns a list suitable for VisibleFor and PinTo (with groups and possibly some other special items like All).
generated: true
content_type: reference
envir: onsite, online
---

# "visibleforassociate" MDO List
List provider that returns a list suitable for VisibleFor and PinTo (with groups and possibly some other special items like All).



Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleForAssociateMDOProvider">VisibleForAssociateMDOProvider</see> class.
The name of the MDO list is 'visibleforassociate'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Add the company name in parenthesis.| ContactName|False|
|Include has_email in extrainfo| includeHasEmail|False|





## Sample Request

```http!
GET /api/v1/MDOList/visibleforassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("visibleforassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0||person_id=147&contact_id=2|
|12|Adm1||person_id=148&contact_id=2|
|13|Adm2||person_id=149&contact_id=2|
|14|Adm3||person_id=150&contact_id=2|
|15|Adm4||person_id=151&contact_id=2|
|16|Adm5||person_id=152&contact_id=2|
|106|Adm6||person_id=223&contact_id=2|
|1|Admin Adminson||person_id=9&contact_id=2|
|63|AdmNS02 NetServer||person_id=183&contact_id=2|
|2|Arne Arnesen||person_id=10&contact_id=2|
|3|Brede Bredesen||person_id=11&contact_id=2|
|4|Cato Carlsson||person_id=12&contact_id=2|
|5|Donald Duck||person_id=13&contact_id=2|
|6|Erik Eide||person_id=14&contact_id=2|
|7|Frode Freestad||person_id=15&contact_id=2|
|8|Geir Grønbeck||person_id=16&contact_id=2|
|9|Hans Hansen||person_id=17&contact_id=2|
|10|Ingrid Istad||person_id=18&contact_id=2|
|86|Johan Jensen||person_id=198&contact_id=21|
|87|Kjell Jensen||person_id=199&contact_id=21|
|81|Listadm Listadm||person_id=190&contact_id=2|


## Related MDO Lists

* "visibleforassociateheadings"
* "visibleforassociateheadingswithallitem"
* "visibleforassociateheadingswithallitemwithnoselection"
* "visibleforassociateheadingswithnoselection"
* "visibleforassociatewithallitem"
* "visibleforassociatewithallitemwithnoselection"
* "visibleforassociatewithnoselection"
