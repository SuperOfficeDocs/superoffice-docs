---
uid: services88-preference-getpreferences
title: Services88.PreferenceAgent.GetPreferences SOAP
Generated: true
---

# Services88 Preference GetPreferences SOAP

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.GetPreferences">SuperOffice.Services88.IPreferenceAgent.GetPreferences</see> method.

## GetPreferences

Get one or more preferences based on a set of specifications.&lt;br/&gt;The prefDisplayvalue and prefDisplaytooltip are blank (faster processing relative to GetPreferencesWithDisplayValues)

* **specifications:** Array of preference specifications. The key value may be * (asterisk), which means 'all keys within section'.

Note that the semantics of this are more strictly 'all keys actually set at any accessible level for this associate'; you will NOT get entries for preferences that might exist, but have no set value anywhere.

You can also have askerisk as the section name. In that case the specification array must contain exactly one entry and the key must also be asterisk. This will return all known preferences in all sections for your associate. It might be a lot, tests have shown that a heavily used database can accumulate up to 500 preferences on a single associate. If the Sentry table/field right preferences have been used, the number could be a lot greater!

**Returns:** Array of preference values for your given specification(s). More strictly:
'all keys actually set at any accessible level for this associate'; you will NOT get entries for preferences that might exist, but have no set value anywhere.


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPreferences Request

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
   <Preference:GetPreferences>
    <Preference:Specifications xsi:type="Preference:ArrayOfPreferenceSpec">
     <Preference:PreferenceSpec xsi:type="Preference:PreferenceSpec">
      <Preference:Section xsi:type="xsd:string"></Preference:Section>
      <Preference:Key xsi:type="xsd:string"></Preference:Key>
     </Preference:PreferenceSpec>
    </Preference:Specifications>
   </Preference:GetPreferences>

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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Preference:GetPreferencesResponse>
   <Preference:Response xsi:type="Preference:ArrayOfPreference">
    <Preference:Preference xsi:type="Preference:Preference">
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
    </Preference:Preference>
   </Preference:Response>
  </Preference:GetPreferencesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

