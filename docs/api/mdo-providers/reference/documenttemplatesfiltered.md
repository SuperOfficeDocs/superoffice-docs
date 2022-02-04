---
uid: documenttemplatesfiltered
title: documenttemplatesfiltered
keywords:
  - "mdo"
  - "provider"
  - "mdo provider"
  - "documenttemplatesfiltered"
so.generated: true
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "documenttemplatesfiltered" MDO List
MDO Provider for Document Templates, excluding Document details and quote mail templates, which are for system use rather than end-user choosing.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.DocumentTemplatesFiltered">DocumentTemplatesFiltered</see> class.
The name of the MDO list is 'documenttemplatesfiltered'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Set 'ExcludeEmailTemplates=true' if no templates of type Email should be returned | ExcludeEmailTemplates|true|





## Sample Request

```http!
GET /api/v1/MDOList/documenttemplatesfiltered
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("documenttemplatesfiltered", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|Brev|||
|4|Brev - Internasjonal|||
|6|E-post|||
|7|E-post SV:|||
|8|E-post VS:|||
|3|Faks|||
|5|Faks - Internasjonal|||
|12|Innk. dok.|||
|11|Innk. E-post|||
|2|Notat|||
|9|Send dok.pr E-post|||
|10|Send dok.pr Faks|||
|13|StateZero Word Simple|||
|14|StateZero Word Simple Czech|||
|15|Quote|||

