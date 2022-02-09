---
title: Services88.PreferenceAgent.GetPreferenceDescriptionLinesByPrefDescId SOAP
generated: 1
uid: Services88-Preference-GetPreferenceDescriptionLinesByPrefDescId
---

# Services88 Preference GetPreferenceDescriptionLinesByPrefDescId

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.GetPreferenceDescriptionLinesByPrefDescId">SuperOffice.Services88.IPreferenceAgent.GetPreferenceDescriptionLinesByPrefDescId</see> method.

## GetPreferenceDescriptionLinesByPrefDescId

Get all preference description lines from a prefDesc\_id

* **prefDescId:** The id of the preference description this line is connected to

**Returns:** The preference description lines matching the id


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreferenceDescriptionLinesByPrefDescId Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetPreferenceDescriptionLinesByPrefDescId>
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
   </Preference:GetPreferenceDescriptionLinesByPrefDescId>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreferenceDescriptionLinesByPrefDescId Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Preference:GetPreferenceDescriptionLinesByPrefDescIdResponse>
   <Preference:Response xsi:type="Preference:ArrayOfPreferenceDescriptionLine">
    <Preference:PreferenceDescriptionLine xsi:type="Preference:PreferenceDescriptionLine">
     <Preference:PrefDescLineId xsi:type="xsd:int">0</Preference:PrefDescLineId>
     <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
     <Preference:PrefValue xsi:type="xsd:string"></Preference:PrefValue>
     <Preference:PrefShowValue xsi:type="xsd:string"></Preference:PrefShowValue>
     <Preference:Description xsi:type="xsd:string"></Preference:Description>
     <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
    </Preference:PreferenceDescriptionLine>
   </Preference:Response>
  </Preference:GetPreferenceDescriptionLinesByPrefDescIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

