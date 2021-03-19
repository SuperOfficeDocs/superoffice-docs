---
uid: allpreferencekeys
title: allpreferencekeys
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "allpreferencekeys"
so.generated: true
so.date: 19.03.2021
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
|5533|AcademicTitle (Functions)|||
|5934|ActiveSound (Visual)|bold||
|5588|AddressSeparator (Mail)|bold||
|5498|AllDayEndTime (DiaryView)|bold||
|5499|AllDayStartTime (DiaryView)|bold||
|5589|ArchiveAppointments (Mail)|||
|5590|ArchiveDocuments (Mail)|||
|5591|ArchiveForwards (Mail)|||
|5534|ArchivePageSize (Functions)|||
|5592|ArchiveReplies (Mail)|||
|5593|ArchiveSentMsg (Mail)|bold||
|5594|ArchiveSentMsgFromMailClient (Mail)|||
|5595|ArchiveToAssocs (Mail)|||
|5535|AskToEditOrRead (Functions)|||
|5596|AttachiCal (Mail)|||
|5836|autoCreatePerson (serviceSettings)|||
|5536|AutoLoadLimitInArchive (Functions)|||
|5793|AutoLogoutTime (PocketTasks)|||
|5799|autoQuoteLastmessage (request)|||
|5500|AutoRefreshTime (DiaryView)|||
|5537|BackgroundDocumentCheckTimer (Functions)|||


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
