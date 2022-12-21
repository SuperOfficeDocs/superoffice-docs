---
uid: emailaddress
title: emailaddress
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "emailaddress"
so.generated: true
so.date: 08.26.2022
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
|11|Brede Bredesen <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|12|Cato Carlsson <qa.testbruker@SuperOffice.com>|nomail|qa.testbruker@SuperOffice.com|
|13|Donald Duck <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|14|Erik Eide <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|15|Frode Freestad <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|16|Geir Grønbeck <qa.testbruker@SuperOffice.com>|nomail|qa.testbruker@SuperOffice.com|
|17|Hans Hansen <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|18|Ingrid Istad <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|19|Arne Arnesen <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|20|Admin Adminson <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|23|Arne Arnesen <qa0@SuperOffice.com>||qa0@SuperOffice.com|
|24|Arnt Arntsen <qa5@SuperOffice.com>|nomail|qa5@SuperOffice.com|
|25|Arnhild Arvestad <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|26|Arjan Abelsen <qa.testbruker@SuperOffice.com>||qa.testbruker@SuperOffice.com|
|91|Britt Bærum <qa5@SuperOffice.com>||qa5@SuperOffice.com|
|92|Bente Båstad <qa5@SuperOffice.com>|nomail|qa5@SuperOffice.com|
|93|Bjørn Bjørnsen <qa5@SuperOffice.com>||qa5@SuperOffice.com|
|94|Bjørge Bastesen <qa5@SuperOffice.com>||qa5@SuperOffice.com|
|95|Carl-Oskar Cederström <qa5@SuperOffice.com>||qa5@SuperOffice.com|
|96|Cidrik Culien <qa5@SuperOffice.com>|nomail|qa5@SuperOffice.com|
|97|Cecilie Carlsen <qa5@SuperOffice.com>||qa5@SuperOffice.com|

## Related MDO Lists

* "emailaddressheadings"
* "emailaddressheadingswithallitem"
* "emailaddressheadingswithallitemwithnoselection"
* "emailaddressheadingswithnoselection"
* "emailaddresswithallitem"
* "emailaddresswithallitemwithnoselection"
* "emailaddresswithnoselection"
