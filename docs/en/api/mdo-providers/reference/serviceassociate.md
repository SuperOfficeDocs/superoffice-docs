---
uid: serviceassociate
title: serviceassociate
keywords: mdoprovider mdo provider serviceassociate
description: MDO provider for associates that are allowed to approve a quote.
generated: true
content_type: reference
envir: onsite, online
---

# "serviceassociate" MDO List
MDO provider for associates that are allowed to approve a quote.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.ServiceAssociateMDOProvider">ServiceAssociateMDOProvider</see> class.
The name of the MDO list is 'serviceassociate'.

## Additional Attributes

| Description | Name | Example Value |
|-----|-----|------|
|Flag to include defaul values (currentUser, autoAssign = int.maxValue, unAssigned = 0)| IncludeDefaultItems|False|
|Flag to add related user's 'not present' status message to fullname| AddNotPresentStatus|False|





## Sample Request

```http!
GET /api/v1/MDOList/serviceassociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("serviceassociate", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|106|Adm6||person_id=223&contact_id=0|
|17|Sal0||person_id=153&contact_id=0|
|29|Ser0||person_id=165&contact_id=0|
|30|Ser1||person_id=166&contact_id=0|
|31|Ser2||person_id=167&contact_id=0|
|32|Ser3||person_id=168&contact_id=0|
|33|Ser4||person_id=169&contact_id=0|
|34|Ser5||person_id=170&contact_id=0|
|64|SerNS03 NetServer||person_id=184&contact_id=0|
|23|Tje0||person_id=159&contact_id=0|
|24|Tje1||person_id=160&contact_id=0|
|25|Tje2||person_id=161&contact_id=0|
|26|Tje3||person_id=162&contact_id=0|
|27|Tje4||person_id=163&contact_id=0|
|28|Tje5||person_id=164&contact_id=0|
|99|Tjeneste Sjef||person_id=205&contact_id=0|
|65|TjeNS04 NetServer||person_id=185&contact_id=0|


## Related MDO Lists

* "serviceassociateheadings"
* "serviceassociateheadingswithallitem"
* "serviceassociateheadingswithallitemwithnoselection"
* "serviceassociateheadingswithnoselection"
* "serviceassociatewithallitem"
* "serviceassociatewithallitemwithnoselection"
* "serviceassociatewithnoselection"
