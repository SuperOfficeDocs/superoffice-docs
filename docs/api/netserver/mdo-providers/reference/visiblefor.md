---
uid: visiblefor
title: visiblefor
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "visiblefor"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "visiblefor" MDO List
List provider for the VisibleFor dropdown control. Items are of type associate, usergroup or all, with
a separate id space for each type. The current associate, its primary and secondary groups, and 'all' are
the returned elements. MDO list sorting preferences for the UserGroup list are respected.

Associate items have positive ID's equal to the associate id, group items have negative id's equal to -usergroup id,
and the All item has the id value int.MinValue.

You can pass in an associate ID in the additionalInfo parameter, this will return a VisibleFor list customized to that
associate's view of the world. If additionalInfo is blank, not a number, or 0, the current associate is used.

You can also pass in a list of associate ids, as a string with space/comma delimiters.
Example: '1, 2, 45, 999,12'. In this case, you will get a VisibleFor populated with the All choice,
plus the intersection of all the groups of all the associates. I.e., something set as Visible For
one of these choices will be visible to all these associates.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.VisibleForListProvider">VisibleForListProvider</see> class.
The name of the MDO list is 'visiblefor'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Comma separated list of associate ids| |123,234,34|





## Sample Request

```http!
GET /api/v1/MDOList/visiblefor
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("visiblefor", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11|Adm0||11|
|-1|Administrasjon||1|
|-2147483648|All||-2147483648|


## Related MDO Lists

* "visibleforheadings"
* "visibleforheadingswithallitem"
* "visibleforheadingswithallitemwithnoselection"
* "visibleforheadingswithnoselection"
* "visibleforwithallitem"
* "visibleforwithallitemwithnoselection"
* "visibleforwithnoselection"
