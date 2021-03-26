---
uid: services83-preference-getpreference
title: Services83.PreferenceAgent.GetPreference SOAP
Generated: true
---

# Services83 Preference GetPreference SOAP

SOAP request and response examples **Remote/Services83/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IPreferenceAgent.GetPreference">SuperOffice.Services83.IPreferenceAgent.GetPreference</see> method.

## GetPreference

Get a preference by id

* **id:** The id of the preference to load

**Returns:** The preference loaded


[WSDL file for Services83/Preference](../Services83-Preference.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreference Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetPreference>
    <Preference:Id xsi:type="xsd:int">0</Preference:Id>
   </Preference:GetPreference>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPreference Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Preference:GetPreferenceResponse>
   <Preference:Response xsi:type="Preference:Preference">
    <Preference:Level xsi:type="Preference:PreferenceLevel">Undefined</Preference:Level>
    <Preference:RawValue xsi:type="xsd:string"></Preference:RawValue>
    <Preference:Specification xsi:type="Preference:PreferenceSpec">
     <Preference:Section xsi:type="xsd:string"></Preference:Section>
     <Preference:Key xsi:type="xsd:string"></Preference:Key>
    </Preference:Specification>
    <Preference:DisplayValue xsi:type="xsd:string"></Preference:DisplayValue>
    <Preference:DisplayTooltip xsi:type="xsd:string"></Preference:DisplayTooltip>
    <Preference:DisplayType xsi:type="Preference:PrefDescValueType">Unknown</Preference:DisplayType>
    <Preference:TabOrder xsi:type="Preference:TabOrder">
     <Preference:TabOrderId xsi:type="xsd:int">0</Preference:TabOrderId>
     <Preference:TabName xsi:type="xsd:string"></Preference:TabName>
     <Preference:Order xsi:type="xsd:string"></Preference:Order>
     <Preference:AssociateId xsi:type="xsd:int">0</Preference:AssociateId>
    </Preference:TabOrder>
    <Preference:TargetId xsi:type="xsd:int">0</Preference:TargetId>
    <Preference:PrefDescId xsi:type="xsd:int">0</Preference:PrefDescId>
    <Preference:TableName xsi:type="xsd:string"></Preference:TableName>
    <Preference:UserPreferenceId xsi:type="xsd:int">0</Preference:UserPreferenceId>
   </Preference:Response>
  </Preference:GetPreferenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

