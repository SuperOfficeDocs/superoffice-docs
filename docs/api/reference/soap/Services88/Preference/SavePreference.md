---
title: Services88.PreferenceAgent.SavePreference SOAP
generated: 1
uid: Services88-Preference-SavePreference
---

# Services88 Preference SavePreference

SOAP request and response examples **Remote/Services88/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IPreferenceAgent.SavePreference">SuperOffice.Services88.IPreferenceAgent.SavePreference</see> method.

## SavePreference

Save this preference

* **preference:** Preference to be saved. All fields must be filled in, and the preference will be saved on the Associate level only. Setting for other levels is an administrative task and not available through this service.

**Returns:** This method has no return value


[WSDL file for Services88/Preference](../Services88-Preference.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SavePreference Request

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
   <Preference:SavePreference>
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
   </Preference:SavePreference>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SavePreference Response

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
  <Preference:SavePreferenceResponse>
  </Preference:SavePreferenceResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

