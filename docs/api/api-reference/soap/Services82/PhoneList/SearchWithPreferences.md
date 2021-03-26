---
uid: services82-phonelist-searchwithpreferences
title: Services82.PhoneListAgent.SearchWithPreferences SOAP
Generated: true
---

# Services82 PhoneList SearchWithPreferences SOAP

SOAP request and response examples **Remote/Services82/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services82.IPhoneListAgent.SearchWithPreferences">SuperOffice.Services82.IPhoneListAgent.SearchWithPreferences</see> method.

## SearchWithPreferences

Searching the phone list. Search is based on the supplied preferences.

* **searchString:** The search string.
* **preferences:** The search preferences

**Returns:** The resulting phone list.


[WSDL file for Services82/PhoneList](../Services82-PhoneList.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SearchWithPreferences Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:SearchWithPreferences>
    <PhoneList:SearchString xsi:type="xsd:string"></PhoneList:SearchString>
    <PhoneList:Preferences xsi:type="PhoneList:PhoneListPreferences">
     <PhoneList:SearchCompany xsi:type="xsd:boolean">false</PhoneList:SearchCompany>
     <PhoneList:SearchFirstname xsi:type="xsd:boolean">false</PhoneList:SearchFirstname>
     <PhoneList:SearchLastname xsi:type="xsd:boolean">false</PhoneList:SearchLastname>
     <PhoneList:SearchDepartment xsi:type="xsd:boolean">false</PhoneList:SearchDepartment>
     <PhoneList:SearchModeCompany xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeCompany>
     <PhoneList:SearchModeDepartment xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeDepartment>
     <PhoneList:SearchModeFirstname xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeFirstname>
     <PhoneList:SearchModeLastname xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeLastname>
    </PhoneList:Preferences>
   </PhoneList:SearchWithPreferences>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SearchWithPreferences Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <PhoneList:SearchWithPreferencesResponse>
   <PhoneList:Response xsi:type="PhoneList:ArrayOfPhoneListItem">
    <PhoneList:PhoneListItem xsi:type="PhoneList:PhoneListItem">
     <PhoneList:PersonDirectPhone xsi:type="xsd:string"></PhoneList:PersonDirectPhone>
     <PhoneList:PersonCellPhone xsi:type="xsd:string"></PhoneList:PersonCellPhone>
     <PhoneList:PersonPrivatePhone xsi:type="xsd:string"></PhoneList:PersonPrivatePhone>
     <PhoneList:PersonFaxNumber xsi:type="xsd:string"></PhoneList:PersonFaxNumber>
     <PhoneList:PersonPagerNumber xsi:type="xsd:string"></PhoneList:PersonPagerNumber>
     <PhoneList:PersonEmail xsi:type="xsd:string"></PhoneList:PersonEmail>
     <PhoneList:Id xsi:type="xsd:int">0</PhoneList:Id>
     <PhoneList:Name xsi:type="xsd:string"></PhoneList:Name>
     <PhoneList:Tooltip xsi:type="xsd:string"></PhoneList:Tooltip>
     <PhoneList:UniqueId xsi:type="xsd:string"></PhoneList:UniqueId>
    </PhoneList:PhoneListItem>
   </PhoneList:Response>
  </PhoneList:SearchWithPreferencesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

