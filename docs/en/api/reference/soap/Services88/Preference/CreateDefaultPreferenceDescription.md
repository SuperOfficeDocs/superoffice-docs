---
title: Services88.PreferenceAgent.CreateDefaultPreferenceDescription SOAP
generated: true
uid: Services88-Preference-CreateDefaultPreferenceDescription
---

# Services88 Preference CreateDefaultPreferenceDescription

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.CreateDefaultPreferenceDescription">SuperOffice.Services88.IPreferenceAgent.CreateDefaultPreferenceDescription</see> method.

## CreateDefaultPreferenceDescription





[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultPreferenceDescription Request

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
   <Preference:CreateDefaultPreferenceDescription>
   </Preference:CreateDefaultPreferenceDescription>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultPreferenceDescription Response

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
  <Preference:CreateDefaultPreferenceDescriptionResponse>
   <Preference:Response xsi:type="Preference:PreferenceDescription">
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
    <Preference:Section xsi:type="xsd:string"></Preference:Section>
    <Preference:Key xsi:type="xsd:string"></Preference:Key>
    <Preference:Name xsi:type="xsd:string"></Preference:Name>
    <Preference:ValueType xsi:type="Preference:PrefDescValueType">Unknown</Preference:ValueType>
    <Preference:MaxLevel xsi:type="Preference:PreferenceLevel">Undefined</Preference:MaxLevel>
    <Preference:SysMaxLevel xsi:type="Preference:PreferenceLevel">Undefined</Preference:SysMaxLevel>
    <Preference:AccessFlags xsi:type="Preference:PrefDescAccessFlags">WizardMode</Preference:AccessFlags>
    <Preference:Description xsi:type="xsd:string"></Preference:Description>
    <Preference:IsBuiltin xsi:type="xsd:boolean">false</Preference:IsBuiltin>
    <Preference:TableName xsi:type="xsd:string"></Preference:TableName>
    <Preference:UserDefinedListId xsi:type="xsd:int">0</Preference:UserDefinedListId>
    <Preference:Rank xsi:type="xsd:int">0</Preference:Rank>
    <Preference:SubGroup xsi:type="xsd:string"></Preference:SubGroup>
    <Preference:MinLevel xsi:type="xsd:int">0</Preference:MinLevel>
    <Preference:MaxValue xsi:type="xsd:int">0</Preference:MaxValue>
    <Preference:MinValue xsi:type="xsd:int">0</Preference:MinValue>
    <Preference:RequiredLicense xsi:type="xsd:string"></Preference:RequiredLicense>
   </Preference:Response>
  </Preference:CreateDefaultPreferenceDescriptionResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

