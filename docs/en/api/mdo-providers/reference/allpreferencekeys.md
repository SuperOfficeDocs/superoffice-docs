---
uid: allpreferencekeys
title: allpreferencekeys
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "allpreferencekeys"
so.generated: true
so.date: 03.31.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "allpreferencekeys" MDO List
MDO Provider that retrieves all preference keys

All preferences that are not sections are returned, grouped alphabetically.
If addidionalInfo is OrderBySection, it is first grouped alphabetically by section.
Preferences that have list of values are bolded.

Implemented by the <see cref="T:SuperOffice.CRM.Lists.AllPreferenceKeysProvider">AllPreferenceKeysProvider</see> class.
The name of the MDO list is 'allpreferencekeys'.




## Sample Request

```http!
GET /api/v1/MDOList/allpreferencekeys
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("allpreferencekeys", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1000095|Use academic title||[SR_PD_Functions_NAME]|
|1000496|Enable sounds|bold|[SR_PD_Visual_NAME]|
|1000149|Address separator|bold|[SR_PD_Mail_NAME]|
|1000060|All-day end time|bold|[SR_PD_DiaryView_NAME]|
|1000061|All-day start time|bold|[SR_PD_DiaryView_NAME]|
|1000150|Archive sent appointments||[SR_PD_Mail_NAME]|
|1000151|Archive sent documents||[SR_PD_Mail_NAME]|
|1000152|Archive forwarded e-mail||[SR_PD_Mail_NAME]|
|1000096|Archive page size||[SR_PD_Functions_NAME]|
|1000153|Archive replies||[SR_PD_Mail_NAME]|
|1000154|Archive all e-mail|bold|[SR_PD_Mail_NAME]|
|1000155|Auto-archive e-mails sent from e-mail client.||[SR_PD_Mail_NAME]|
|1000156|Archive e-mail to associates||[SR_PD_Mail_NAME]|
|1000097|Ask to edit or read||[SR_PD_Functions_NAME]|
|1000157|Use iCalendar attachment||[SR_PD_Mail_NAME]|
|1000365|Automatically close tab when adding a message to request||[SR_PD_request_NAME]|
|1000398|Automatically create contact for new inbound request||[SR_PD_serviceSettings_NAME]|
|1000098|Limit for auto-loading||[SR_PD_Functions_NAME]|
|1000358|Autologout time||[SR_PD_PocketTasks_NAME]|
|1000367|Automatically quote the last message||[SR_PD_request_NAME]|
|1000062|Diary autorefresh interval||[SR_PD_DiaryView_NAME]|


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
