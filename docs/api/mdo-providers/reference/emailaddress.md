---
uid: emailaddress
title: emailaddress
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "emailaddress" MDO List
List of e-mail addresses matching the search value
Searches e-mail address, person name, company name.
<para />
E-mail address matches: return e-mail addresses + owner name (person or contact name)
<para />
Person name matches: return all e-mail addresses for matched persons
<para />
Company name matches. return all persons + first e-mail address for matched persons.

Returns: list item with
<para />
id = e-mail address id
<para />
Name = name + e-mail
<para />
ExtraInfo = e-mail address
<para />
Type = "Person" or "Contact"
<para />

Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailAddressProvider">EmailAddressProvider</see> class.
The name of the MDO list is 'emailaddress'.




## Sample Request

```http!
GET /api/v1/MDOList/emailaddress
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailaddress", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Brede Bredesen <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|12|Cato Carlsson <qa.testbruker@superoffice.com>|nomail|qa.testbruker@superoffice.com|
|13|Donald Duck <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|14|Erik Eide <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|15|Frode Freestad <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|16|Geir Grønbeck <qa.testbruker@superoffice.com>|nomail|qa.testbruker@superoffice.com|
|17|Hans Hansen <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|18|Ingrid Istad <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|19|Arne Arnesen <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|20|Admin Adminson <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|23|Arne Arnesen <qa0@superoffice.com>||qa0@superoffice.com|
|24|Arnt Arntsen <qa5@superoffice.com>|nomail|qa5@superoffice.com|
|25|Arnhild Arvestad <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|26|Arjan Abelsen <qa.testbruker@superoffice.com>||qa.testbruker@superoffice.com|
|91|Britt Bærum <qa5@superoffice.com>||qa5@superoffice.com|
|92|Bente Båstad <qa5@superoffice.com>|nomail|qa5@superoffice.com|
|93|Bjørn Bjørnsen <qa5@superoffice.com>||qa5@superoffice.com|
|94|Bjørge Bastesen <qa5@superoffice.com>||qa5@superoffice.com|
|95|Carl-Oskar Cederström <qa5@superoffice.com>||qa5@superoffice.com|
|96|Cidrik Culien <qa5@superoffice.com>|nomail|qa5@superoffice.com|
|97|Cecilie Carlsen <qa5@superoffice.com>||qa5@superoffice.com|


## Related MDO Lists

* "emailaddressheadings"
* "emailaddressheadingswithallitem"
* "emailaddressheadingswithallitemwithnoselection"
* "emailaddressheadingswithnoselection"
* "emailaddresswithallitem"
* "emailaddresswithallitemwithnoselection"
* "emailaddresswithnoselection"
