---
title: Services87.PreferenceAgent.CreateDefaultPreferenceDescriptionLine SOAP
generated: 1
uid: Services87-Preference-CreateDefaultPreferenceDescriptionLine
---

# Services87 Preference CreateDefaultPreferenceDescriptionLine

SOAP request and response examples **Remote/Services87/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPreferenceAgent.CreateDefaultPreferenceDescriptionLine">SuperOffice.Services87.IPreferenceAgent.CreateDefaultPreferenceDescriptionLine</see> method.

## CreateDefaultPreferenceDescriptionLine

Loading default values into a new PreferenceDescriptionLine.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New PreferenceDescriptionLine with default values


[WSDL file for Services87/Preference](../Services87-Preference.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultPreferenceDescriptionLine Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:CreateDefaultPreferenceDescriptionLine>
   </Preference:CreateDefaultPreferenceDescriptionLine>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultPreferenceDescriptionLine Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Preference:CreateDefaultPreferenceDescriptionLineResponse>
   <Preference:Response xsi:type="Preference:PreferenceDescriptionLine">
    <Preference:PrefDescLineId xsi:type="xsd:int">0</Preference:PrefDescLineId>
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
    <Preference:PrefValue xsi:type="xsd:string"></Preference:PrefValue>
    <Preference:PrefShowValue xsi:type="xsd:string"></Preference:PrefShowValue>
    <Preference:Description xsi:type="xsd:string"></Preference:Description>
    <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
   </Preference:Response>
  </Preference:CreateDefaultPreferenceDescriptionLineResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

