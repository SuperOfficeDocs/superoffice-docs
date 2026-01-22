---
uid: onlinefontlibrary
title: onlinefontlibrary
keywords: mdoprovider mdo provider onlinefontlibrary
description: MDO provider for the available fonts from the Online Template Library.
generated: true
content_type: reference
envir: onsite, online
---

# "onlinefontlibrary" MDO List
MDO provider for the available fonts from the Online Template Library.



Implemented by the <see cref="T:SuperOffice.CRM.Lists.OnlineFontLibraryProvider">OnlineFontLibraryProvider</see> class.
The name of the MDO list is 'onlinefontlibrary'.




## Sample Request

```http!
GET /api/v1/MDOList/onlinefontlibrary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = ClassFactory.CreateRequired<SuperOffice.CRM.Lists.ISoListProviderFactory>().Create("onlinefontlibrary", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|1|42dot Sans||/fonts/42dotsans/42dotsans.css|
|2|A Bee Zee||/fonts/abeezee/abeezee.css|
|3|Abel||/fonts/abel/abel.css|
|4|Abhaya Libre||/fonts/abhayalibre/abhayalibre.css|
|5|Aboreto||/fonts/aboreto/aboreto.css|
|6|Abril Fatface||/fonts/abrilfatface/abrilfatface.css|
|7|Abyssinica SIL||/fonts/abyssinicasil/abyssinicasil.css|
|8|Aclonica||/fonts/aclonica/aclonica.css|
|9|Acme||/fonts/acme/acme.css|
|10|Actor||/fonts/actor/actor.css|
|11|AD La M Display||/fonts/adlamdisplay/adlamdisplay.css|
|12|Adamina||/fonts/adamina/adamina.css|
|13|Adobe Blank||/fonts/adobeblank/adobeblank.css|
|14|Advent Pro||/fonts/adventpro/adventpro.css|
|15|Afacad Flux||/fonts/afacadflux/afacadflux.css|
|16|Afacad||/fonts/afacad/afacad.css|
|17|Agbalumo||/fonts/agbalumo/agbalumo.css|
|18|Agdasima||/fonts/agdasima/agdasima.css|
|19|Agu Display||/fonts/agudisplay/agudisplay.css|
|20|Aguafina Script||/fonts/aguafinascript/aguafinascript.css|
|21|Akatab||/fonts/akatab/akatab.css|


## Related MDO Lists

* "onlinefontlibraryheadings"
* "onlinefontlibraryheadingswithallitem"
* "onlinefontlibraryheadingswithallitemwithnoselection"
* "onlinefontlibraryheadingswithnoselection"
* "onlinefontlibrarywithallitem"
* "onlinefontlibrarywithallitemwithnoselection"
* "onlinefontlibrarywithnoselection"
