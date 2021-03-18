---
uid: preferencesection
title: preferencesection
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

# "preferencesection" MDO List
MDO Provider that retrieves a list of preference sections

Preferences are described in the prefdesc table. This provider will retrieve descriptions for all sections.
<para />
Each item contains the programmatic section name in the extraInfo field.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.PreferenceSectionProvider">PreferenceSectionProvider</see> class.
The name of the MDO list is 'preferencesection'.




## Sample Request

```http!
GET /api/v1/MDOList/preferencesection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("preferencesection", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|11559|Contact||Person|
|11227|Customer Centre password policy||ccAuthentication|
|11248|Default values||Defaults|
|11282|Diary||DiaryView|
|11372|E-mail||Mail|
|11307|Filter Dialog||FilterDialog|
|11309|Freetext search||Freetext|
|11317|Functions||Functions|
|11437|Grouped lists||MDOList|
|11434|Mailing||Mailing|
|11535|Notifications via e-mail||notificationEmail|
|11527|Notifications via popup||notification|
|11543|Notifications via SMS||notificationSms|
|11578|Pocket CRM||PocketTasks|
|11584|Request||request|
|11602|Sale||Sale|
|11646|Service outbox||serviceSMTP|
|11652|SMS configuration||sms|
|11657|Sorting||Sorting|
|11237|Statistics||DataCollection|
|11621|SuperOffice Service system settings||serviceSettings|


## Related MDO Lists

* "preferencesectionheadings"
* "preferencesectionheadingswithallitem"
* "preferencesectionheadingswithallitemwithnoselection"
* "preferencesectionheadingswithnoselection"
* "preferencesectionwithallitem"
* "preferencesectionwithallitemwithnoselection"
* "preferencesectionwithnoselection"
