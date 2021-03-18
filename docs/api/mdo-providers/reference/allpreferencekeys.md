---
uid: allpreferencekeys
title: allpreferencekeys
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
|11318|AcademicTitle (Functions)|||
|11720|ActiveSound (Visual)|bold||
|11373|AddressSeparator (Mail)|bold||
|11283|AllDayEndTime (DiaryView)|bold||
|11284|AllDayStartTime (DiaryView)|bold||
|11374|ArchiveAppointments (Mail)|||
|11375|ArchiveDocuments (Mail)|||
|11376|ArchiveForwards (Mail)|||
|11319|ArchivePageSize (Functions)|||
|11377|ArchiveReplies (Mail)|||
|11378|ArchiveSentMsg (Mail)|bold||
|11379|ArchiveSentMsgFromMailClient (Mail)|||
|11380|ArchiveToAssocs (Mail)|||
|11320|AskToEditOrRead (Functions)|||
|11381|AttachiCal (Mail)|||
|11622|autoCreatePerson (serviceSettings)|||
|11321|AutoLoadLimitInArchive (Functions)|||
|11579|AutoLogoutTime (PocketTasks)|||
|11585|autoQuoteLastmessage (request)|||
|11285|AutoRefreshTime (DiaryView)|||
|11322|BackgroundDocumentCheckTimer (Functions)|||


## Related MDO Lists

* "allpreferencekeysheadings"
* "allpreferencekeysheadingswithallitem"
* "allpreferencekeysheadingswithallitemwithnoselection"
* "allpreferencekeysheadingswithnoselection"
* "allpreferencekeyswithallitem"
* "allpreferencekeyswithallitemwithnoselection"
* "allpreferencekeyswithnoselection"
