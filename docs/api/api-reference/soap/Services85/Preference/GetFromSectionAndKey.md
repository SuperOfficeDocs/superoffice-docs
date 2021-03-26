---
uid: services85-preference-getfromsectionandkey
title: Services85.PreferenceAgent.GetFromSectionAndKey SOAP
Generated: true
---

# Services85 Preference GetFromSectionAndKey SOAP

SOAP request and response examples **Remote/Services85/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IPreferenceAgent.GetFromSectionAndKey">SuperOffice.Services85.IPreferenceAgent.GetFromSectionAndKey</see> method.

## GetFromSectionAndKey

Gets a PreferenceDescription based on the section and key

* **section:** The PreferenceDescription-section
* **key:** The PreferenceDescription-key

**Returns:** A PreferenceDescription or null


[WSDL file for Services85/Preference](../Services85-Preference.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetFromSectionAndKey Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetFromSectionAndKey>
    <Preference:Section xsi:type="xsd:string"></Preference:Section>
    <Preference:Key xsi:type="xsd:string"></Preference:Key>
   </Preference:GetFromSectionAndKey>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetFromSectionAndKey Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Preference:GetFromSectionAndKeyResponse>
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
   </Preference:Response>
  </Preference:GetFromSectionAndKeyResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

