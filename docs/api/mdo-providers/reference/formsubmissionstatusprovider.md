---
uid: formsubmissionstatusprovider
title: formsubmissionstatusprovider
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "formsubmissionstatusprovider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "formsubmissionstatusprovider" MDO List




Implemented by the <see cref="T:SuperOffice.CRM.Lists.FormSubmissionStatusProvider">FormSubmissionStatusProvider</see> class.
The name of the MDO list is 'formsubmissionstatusprovider'.




## Sample Request

```http!
GET /api/v1/MDOList/formsubmissionstatusprovider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("formsubmissionstatusprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|0|Unknown|||
|1|In progress|||
|2|E-mail verification|||
|3|Submitted|||
|4|Processed|||
|5|Failed|||


## Related MDO Lists

* "formsubmissionstatusproviderheadings"
* "formsubmissionstatusproviderheadingswithallitem"
* "formsubmissionstatusproviderheadingswithallitemwithnoselection"
* "formsubmissionstatusproviderheadingswithnoselection"
* "formsubmissionstatusproviderwithallitem"
* "formsubmissionstatusproviderwithallitemwithnoselection"
* "formsubmissionstatusproviderwithnoselection"
