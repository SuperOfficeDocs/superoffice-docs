---
title: Services85.PhoneListAgent.SetPreferences SOAP
generated: 1
uid: Services85-PhoneList-SetPreferences
---

# Services85 PhoneList SetPreferences

SOAP request and response examples **Remote/Services85/PhoneList.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPhoneListAgent.SetPreferences">SuperOffice.Services85.IPhoneListAgent.SetPreferences</see> method.

## SetPreferences

Setting Phone List Preferences to the CRM 5 user preferences

* **preferences:** The preference that is set as user preferences



[WSDL file for Services85/PhoneList](../Services85-PhoneList.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetPreferences Request

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
   <PhoneList:SetPreferences>
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
   </PhoneList:SetPreferences>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetPreferences Response

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
  <PhoneList:SetPreferencesResponse>
  </PhoneList:SetPreferencesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

