---
uid: services84-preference-createdefaultpreference
title: Services84.PreferenceAgent.CreateDefaultPreference SOAP
Generated: true
---

# Services84 Preference CreateDefaultPreference SOAP

SOAP request and response examples **Remote/Services84/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPreferenceAgent.CreateDefaultPreference">SuperOffice.Services84.IPreferenceAgent.CreateDefaultPreference</see> method.

## CreateDefaultPreference

Loading default values into a new Preference.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance


**Returns:** New Preference with default values


[WSDL file for Services84/Preference](../Services84-Preference.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## CreateDefaultPreference Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:CreateDefaultPreference>
   </Preference:CreateDefaultPreference>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## CreateDefaultPreference Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <Preference:CreateDefaultPreferenceResponse>
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
  </Preference:CreateDefaultPreferenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

