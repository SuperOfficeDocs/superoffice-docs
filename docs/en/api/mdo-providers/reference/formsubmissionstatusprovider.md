---
uid: formsubmissionstatusprovider
title: formsubmissionstatusprovider
keywords: mdoprovider mdo provider formsubmissionstatusprovider
description: 
generated: true
content_type: reference
envir: onsite, online
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
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("formsubmissionstatusprovider", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|2|Awaiting confirmation|||
|3|Submitted|||
|4|Processed|||
|32767|Other|||


## Related MDO Lists

* "formsubmissionstatusproviderheadings"
* "formsubmissionstatusproviderheadingswithallitem"
* "formsubmissionstatusproviderheadingswithallitemwithnoselection"
* "formsubmissionstatusproviderheadingswithnoselection"
* "formsubmissionstatusproviderwithallitem"
* "formsubmissionstatusproviderwithallitemwithnoselection"
* "formsubmissionstatusproviderwithnoselection"
