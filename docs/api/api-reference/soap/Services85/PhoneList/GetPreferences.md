---
uid: services85-phonelist-getpreferences
title: Services85.PhoneListAgent.GetPreferences SOAP
Generated: true
---

# Services85 PhoneList GetPreferences SOAP

SOAP request and response examples **Remote/Services85/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPhoneListAgent.GetPreferences">SuperOffice.Services85.IPhoneListAgent.GetPreferences</see> method.

## GetPreferences

Getting Phone List Preferences from the CRM 5 user preferences


**Returns:** The Phone List Preferences


[WSDL file for Services85/PhoneList](../Services85-PhoneList.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreferences Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <PhoneList:ApplicationToken>1234567-1234-9876</PhoneList:ApplicationToken>
  <PhoneList:Credentials>
    <PhoneList:Ticket>7T:1234abcxyzExample==</PhoneList:Ticket>
  </PhoneList:Credentials>
 <SOAP-ENV:Body>
   <PhoneList:GetPreferences>
   </PhoneList:GetPreferences>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreferences Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:PhoneList="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <PhoneList:GetPreferencesResponse>
   <PhoneList:Response xsi:type="PhoneList:PhoneListPreferences">
    <PhoneList:SearchCompany xsi:type="xsd:boolean">false</PhoneList:SearchCompany>
    <PhoneList:SearchFirstname xsi:type="xsd:boolean">false</PhoneList:SearchFirstname>
    <PhoneList:SearchLastname xsi:type="xsd:boolean">false</PhoneList:SearchLastname>
    <PhoneList:SearchDepartment xsi:type="xsd:boolean">false</PhoneList:SearchDepartment>
    <PhoneList:SearchModeCompany xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeCompany>
    <PhoneList:SearchModeDepartment xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeDepartment>
    <PhoneList:SearchModeFirstname xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeFirstname>
    <PhoneList:SearchModeLastname xsi:type="PhoneList:StringSearchType">Exact</PhoneList:SearchModeLastname>
   </PhoneList:Response>
  </PhoneList:GetPreferencesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

