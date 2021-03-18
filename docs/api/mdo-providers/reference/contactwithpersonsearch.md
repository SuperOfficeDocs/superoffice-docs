---
uid: contactwithpersonsearch
title: contactwithpersonsearch
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
|92|"Dobbelfnutt, "Avdeling||92|
|95|#Hash, #Avdeling||95|
|94|%Prosent, %Avdeling||94|
|93|&And, &Avdeling||93|
|96|*Star Company, *Avdeling||96|
|115|:Afghanistan1, Afghanistan1||115|
|116|:Afghanistan2, Afghanistan2||116|
|117|:Afghanistan3, Afghanistan3||117|
|109|:Canada1, Canada1||109|
|110|:Canada2, Canada2||110|
|111|:Canada3, Canada3||111|
|112|:Japan1, Japan1||112|
|113|:Japan2, Japan2||113|
|114|:Japan3, Japan3||114|
|118|:Spania1, Spania1||118|
|119|:Spania2, Spania2||119|
|120|:Spania3, Spania3||120|
|103|:Storbritannia1, Storbritannia1||103|
|104|:Storbritannia2, Storbritannia2||104|
|105|:Storbritannia3, Storbritannia3||105|
|97|:Sverige1, Sverige1||97|


## Related MDO Lists

* "contactwithpersonsearchheadings"
* "contactwithpersonsearchheadingswithallitem"
* "contactwithpersonsearchheadingswithallitemwithnoselection"
* "contactwithpersonsearchheadingswithnoselection"
* "contactwithpersonsearchwithallitem"
* "contactwithpersonsearchwithallitemwithnoselection"
* "contactwithpersonsearchwithnoselection"
