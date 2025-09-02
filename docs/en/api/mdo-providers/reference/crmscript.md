---
uid: crmscript
title: crmscript
keywords: mdoprovider mdo provider crmscript
description: Archive of CRMScripts. Returns script id + name of script as hierarchy.
generated: true
content_type: reference
envir: onsite, online
---

# "crmscript" MDO List
Archive of CRMScripts. Returns script id + name of script as hierarchy.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.CRMScriptProvider">CRMScriptProvider</see> class.
The name of the MDO list is 'crmscript'.




## Sample Request

```http!
GET /api/v1/MDOList/crmscript
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("crmscript", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|16|Add project member||8682f6ad18a04b90b92ca26284d34a9a|
|15|Create appointment||04a46d0aaa364224a2b6108708f8aa8e|
|9|Create contact||a5d643cbcd324044832dde812127dd7e|
|7|Create person||3a5d75a1a20c443f87743d89ce1891a9|
|2|Create request||317e92b9556743efa130173d8d822a19|
|14|Create sale||1e418cea6ff141debb00a01457807a72|
|10|Edit contact||a364f9fb42ff48f7993a3a61c19dbe15|
|8|Edit person||0040f720f0ff46328799ea94c833af1b|
|3|Edit request||a0827b6b5dd547d3a6d340fb8d2d3a9c|
|11|Load contact||7b87ebb764ef401492e6068f66f0eaae|
|4|Load person||e53c0a0c0fac4e63aca1ad27b668436c|
|12|Load reply template||e12e2a42ee154b57809692ee535a206f|
|6|Load request||df9b784015354a6681dff8d227dd543a|
|5|Send email||9ba99700273d4342ba6ade76ab8c2576|
|13|Trigger response||a108036d08c547abb1433af8cf4b0e2f|
|1|Callback script for compact mode||1415c74f7d5c4d79ad98626c59069ee1|


## Related MDO Lists

* "crmscriptheadings"
* "crmscriptheadingswithallitem"
* "crmscriptheadingswithallitemwithnoselection"
* "crmscriptheadingswithnoselection"
* "crmscriptwithallitem"
* "crmscriptwithallitemwithnoselection"
* "crmscriptwithnoselection"
