---
uid: emailphone
title: emailphone
keywords: mdoprovider mdo provider emailphone
description: List of e-mail addresses and phone numbers matching the search value Searches e-mail address, phone number, person name, company name. E-mail address/phone number matches - return e-mail addresses/phone numbers + owner name (person or contact name) Person name matches - return all e-mail addresses/phone numbers for matched persons Company name matches. return all persons + first e-mail address/phone number for matched persons. 
generated: true
content_type: reference
envir: onsite, online
---

# "emailphone" MDO List
List of e-mail addresses and phone numbers matching the search value
Searches e-mail address, phone number, person name, company name.



E-mail address/phone number matches: return e-mail addresses/phone numbers + owner name (person or contact name)





Person name matches: return all e-mail addresses/phone numbers for matched persons





Company name matches. return all persons + first e-mail address/phone number for matched persons.




Returns: list item with



Id = e-mail address/phone number id





Name = name + e-mail/phone





ExtraInfo = e-mail address/phone number





Type = "Email" or "Phone"




Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailPhoneProvider">EmailPhoneProvider</see> class.
The name of the MDO list is 'emailphone'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Only phone numbers are searched| phoneOnly|False|
|Operator used for search. Available values: 'contains', 'startsWith'. Default value is 'contains'.| operator|contains|





## Sample Request

```http!
GET /api/v1/MDOList/emailphone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("emailphone", forceFlatList: true);
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

* "emailphoneheadings"
* "emailphoneheadingswithallitem"
* "emailphoneheadingswithallitemwithnoselection"
* "emailphoneheadingswithnoselection"
* "emailphonewithallitem"
* "emailphonewithallitemwithnoselection"
* "emailphonewithnoselection"
