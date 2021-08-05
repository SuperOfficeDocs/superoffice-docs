---
uid: contactwithpersonsearch
title: contactwithpersonsearch
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "contactwithpersonsearch"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "contactwithpersonsearch" MDO List
Provider for selecting a Contact, including search on persons that match as well as contacts. this provider will
return a mix of contact and person records. The type is indicated in the Type property of the item, and the contact
ID is always in the extraInfo.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ContactListWithPersonSearchProviderOrg">ContactListWithPersonSearchProviderOrg</see> class.
The name of the MDO list is 'contactwithpersonsearch'.




## Sample Request

```http!
GET /api/v1/MDOList/contactwithpersonsearch
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("contactwithpersonsearch", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|8639| Aaron James & Partners||8639|
|8026| Adam Johnston & Partners, Human Resources||8026|
|8133| Amanda Morgan & Partners, Product Management||8133|
|8107| Amy Elliott & Partners, Product Management||8107|
|8693| Amy Payne & Partners, Services||8693|
|8489| Amy Ray & Partners||8489|
|8599| Angela Morris & Partners||8599|
|8025| Ann Fox & Partners||8025|
|8550| Ann Rose & Partners, Engineering||8550|
|8225| Anna Alexander & Partners||8225|
|8981| Anna Evans & Partners, Services||8981|
|8731| Anne Frazier & Partners, Accounting||8731|
|8270| Anne Morgan & Partners||8270|
|8185| Annie Adams & Partners||8185|
|8319| Anthony Richardson & Partners, Services||8319|
|8778| Antonio Alvarez & Partners||8778|
|8340| Ashley Lynch & Partners||8340|
|8229| Benjamin Bradley & Partners||8229|
|8358| Benjamin Rose & Partners||8358|
|8527| Betty Henderson & Partners, Legal||8527|
|8657| Beverly Alvarez & Partners, Accounting||8657|


## Related MDO Lists

* "contactwithpersonsearchheadings"
* "contactwithpersonsearchheadingswithallitem"
* "contactwithpersonsearchheadingswithallitemwithnoselection"
* "contactwithpersonsearchheadingswithnoselection"
* "contactwithpersonsearchwithallitem"
* "contactwithpersonsearchwithallitemwithnoselection"
* "contactwithpersonsearchwithnoselection"
