---
uid: emailphone
title: emailphone
keywords: mdoprovider mdo provider emailphone
description: List of e-mail addresses and phone numbers matching the search value
Searches e-mail address, phone number, person name, company name.
<para />
E-mail address/phone number matches: return e-mail addresses/phone numbers + owner name (person or contact name)
<para />
Person name matches: return all e-mail addresses/phone numbers for matched persons
<para />
Company name matches. return all persons + first e-mail address/phone number for matched persons.
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "emailphone" MDO List
List of e-mail addresses and phone numbers matching the search value
Searches e-mail address, phone number, person name, company name.
<para />
E-mail address/phone number matches: return e-mail addresses/phone numbers + owner name (person or contact name)
<para />
Person name matches: return all e-mail addresses/phone numbers for matched persons
<para />
Company name matches. return all persons + first e-mail address/phone number for matched persons.

Returns: list item with
<para />
id = e-mail address/phone number id
<para />
Name = name + e-mail/phone
<para />
ExtraInfo = e-mail address/phone number
<para />
Type = "Email" or "Phone"
<para />

Implemented by the <see cref="T:SuperOffice.CRM.Lists.EmailPhoneProvider">EmailPhoneProvider</see> class.
The name of the MDO list is 'emailphone'.




## Sample Request

```http!
GET /api/v1/MDOList/emailphone
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *

```

## Sample Code
```cs
var listProvider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("emailphone", forceFlatList: true);
foreach (var item in listProvider.RootItems) {
    Console.WriteLine("{0} {1} {2} {3}", 
         item.Id, ResourceManager.ParseInlineResources(item.Name), item.StyleHint, item.ExtraInfo);
}
```

## Sample Output

|Id   | Name  |StyleHint|ExtraInfo |
| --- | ----- | ------- | -------- |
|147|Hiroshito Yokahama +8189898988|Person|+8189898988|
|194|Hiroshito Yokahama <qa0@superoffice.com>||qa0@superoffice.com|
|151|Steve Fishmann +447817913882|Person|+447817913882|
|198|Steve Fishmann <Fish.company.steve@mailinator.com>||Fish.company.steve@mailinator.com|
|154|Carol Fishmann +447817913882|Person|+447817913882|
|199|Carol Fishmann <carol.fish.company@mailinator.com>||carol.fish.company@mailinator.com|
|158|Mike Crab +447817913882|Person|+447817913882|
|200|Mike Crab <mike.fish.company@mailinator.com>||mike.fish.company@mailinator.com|
|161|Gary Dope +447817913882|Person|+447817913882|
|201|Gary Dope <gary.dope@mailinator.com>||gary.dope@mailinator.com|
|163|Bil Macher +447817913882|Person|+447817913882|
|202|Bil Macher <Bil.Macher@mailinator.com>||Bil.Macher@mailinator.com|
|169|Barbara Manyemails +447817913882|Person|+447817913882|
|205|Barbara Manyemails <Barabara.Fish@mailinator.com>||Barabara.Fish@mailinator.com|
|206|Barbara Manyemails <BarbaraAlt.Fish@mailinator.com>||BarbaraAlt.Fish@mailinator.com|
|207|Barbara Manyemails <BarbaraThir@mailinator.com>||BarbaraThir@mailinator.com|
|208|Barbara Manyemails <ContactBarbara@mailinator.com>||ContactBarbara@mailinator.com|
|209|Barbara Manyemails <Coffe.Fish@mailinator.com>||Coffe.Fish@mailinator.com|
|175|Great Cat +49367388608|Person|+49367388608|
|214|Great Cat <miau.miau.leader@mailinator.com>||miau.miau.leader@mailinator.com|
|215|Great Cat <miau.miau.me@gmail.com>||miau.miau.me@gmail.com|


## Related MDO Lists

* "emailphoneheadings"
* "emailphoneheadingswithallitem"
* "emailphoneheadingswithallitemwithnoselection"
* "emailphoneheadingswithnoselection"
* "emailphonewithallitem"
* "emailphonewithallitemwithnoselection"
* "emailphonewithnoselection"
