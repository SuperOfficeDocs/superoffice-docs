---
title: Services84.PreferenceAgent.SavePreferenceEntity SOAP
generated: 1
uid: Services84-Preference-SavePreferenceEntity
---

# Services84 Preference SavePreferenceEntity

SOAP request and response examples **Remote/Services84/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPreferenceAgent.SavePreferenceEntity">SuperOffice.Services84.IPreferenceAgent.SavePreferenceEntity</see> method.

## SavePreferenceEntity

Saves a complete preference object. Preference administrator rights are required to use this

* **preference:** The preference object to be saved
* **removeLowerLevels:** If this is true, all user preferences on lower levels will be deleted

**Returns:** Returns the saved preference


[WSDL file for Services84/Preference](../Services84-Preference.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePreferenceEntity Request

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
   <Preference:SavePreferenceEntity>
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
    <Preference:RemoveLowerLevels xsi:type="xsd:boolean">false</Preference:RemoveLowerLevels>
   </Preference:SavePreferenceEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePreferenceEntity Response

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
  <Preference:SavePreferenceEntityResponse>
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
  </Preference:SavePreferenceEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

