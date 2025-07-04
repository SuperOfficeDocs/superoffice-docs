---
uid: contactrelationdefinition
title: contactrelationdefinition
keywords: mdoprovider mdo provider contactrelationdefinition
description: MDO list provider for contact/person relation definitions. This provider is a takes a mandatory additionalInfo parameter, that specifies what kind of relation should be fetched.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "contactrelationdefinition" MDO List
MDO list provider for contact/person relation definitions. This provider is a takes a mandatory
additionalInfo parameter, that specifies what kind of relation should be fetched.

AdditionalInfo can be one of 'CC', 'CP', 'PC', 'PP', specifying contact or person on the source and destination sides
of the relation. A join is made to the relationTarget table to pick out the correct relation definitions to show.
The <see cref="T:SuperOffice.CRM.Lists.RelationListProvider.RelationType" /> enum can be used to avoid strings when specifying the relation type.


The extraInfo field in the items contains the passive (reverse) text, useful for display.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.RelationListProvider">RelationListProvider</see> class.
The name of the MDO list is 'contactrelationdefinition'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|RelationType enum value. CC=Contact-Contact relations| |CC|





## Sample Request

```http!
GET /api/v1/MDOList/contactrelationdefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("contactrelationdefinition", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|eier||eies av|
|7|kjenner||kjenner|


## Related MDO Lists

* "contactrelationdefinitionheadings"
* "contactrelationdefinitionheadingswithallitem"
* "contactrelationdefinitionheadingswithallitemwithnoselection"
* "contactrelationdefinitionheadingswithnoselection"
* "contactrelationdefinitionwithallitem"
* "contactrelationdefinitionwithallitemwithnoselection"
* "contactrelationdefinitionwithnoselection"
