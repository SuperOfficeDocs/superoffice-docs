---
uid: services86-preference-getpreferencedescriptionline
title: Services86.PreferenceAgent.GetPreferenceDescriptionLine SOAP
Generated: true
---

# Services86 Preference GetPreferenceDescriptionLine SOAP

SOAP request and response examples **Remote/Services86/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreferenceAgent.GetPreferenceDescriptionLine">SuperOffice.Services86.IPreferenceAgent.GetPreferenceDescriptionLine</see> method.

## GetPreferenceDescriptionLine

Gets a PreferenceDescriptionLine object.

* **preferenceDescriptionLineId:** The identifier of the PreferenceDescriptionLine object

**Returns:** PreferenceDescriptionLine


[WSDL file for Services86/Preference](../Services86-Preference.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreferenceDescriptionLine Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetPreferenceDescriptionLine>
    <Preference:PreferenceDescriptionLineId xsi:type="xsd:int">0</Preference:PreferenceDescriptionLineId>
   </Preference:GetPreferenceDescriptionLine>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreferenceDescriptionLine Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Preference:GetPreferenceDescriptionLineResponse>
   <Preference:Response xsi:type="Preference:PreferenceDescriptionLine">
    <Preference:PrefDescLineId xsi:type="xsd:int">0</Preference:PrefDescLineId>
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
    <Preference:PrefValue xsi:type="xsd:string"></Preference:PrefValue>
    <Preference:PrefShowValue xsi:type="xsd:string"></Preference:PrefShowValue>
    <Preference:Description xsi:type="xsd:string"></Preference:Description>
    <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
   </Preference:Response>
  </Preference:GetPreferenceDescriptionLineResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

