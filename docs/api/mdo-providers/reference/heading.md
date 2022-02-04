---
uid: heading
title: heading
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "heading"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "heading" MDO List
List provider for the Heading table. While this table looks like an MDO table,
it lacks the standardized grouplink and headinglink companion tables for good reason,
since it is the heading table itself.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.HeadingListProvider">HeadingListProvider</see> class.
The name of the MDO list is 'heading'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Order by rank instead of name| orderByRank|True|
|udListDefinitionId| Get a custom list|123|
|listtableid| Table id|123|
|Include deleted items| showDeleted|True|

Separator: ;





## Sample Request

```http!
GET /api/v1/MDOList/heading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("heading", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|20|Annet|||
|12|Bachelor|||
|1|Brev|||
|13|Cand.|||
|24|Contact interest heading one|||
|25|Contact interest heading two|||
|14|Dr.|||
|3|E-post|||
|2|Faks|||
|8|Heading 1, synlig for alle|||
|9|Heading 2, synlig for salg|||
|10|Heading 3, synlig for administrasjon|||
|4|Interne maler|||
|17|Large|||
|6|Marketing|||
|15|Master|||
|18|Møte|||
|21|Oppgave|||
|16|Other|||
|7|Sales|||
|11|StateZero|||


## Related MDO Lists

* "headingheadings"
* "headingheadingswithallitem"
* "headingheadingswithallitemwithnoselection"
* "headingheadingswithnoselection"
* "headingwithallitem"
* "headingwithallitemwithnoselection"
* "headingwithnoselection"
