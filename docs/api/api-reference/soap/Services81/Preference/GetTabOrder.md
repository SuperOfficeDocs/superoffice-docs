---
uid: services81-preference-gettaborder
title: Services81.PreferenceAgent.GetTabOrder SOAP
Generated: true
---

# Services81 Preference GetTabOrder SOAP

SOAP request and response examples **Remote/Services81/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services81.IPreferenceAgent.GetTabOrder">SuperOffice.Services81.IPreferenceAgent.GetTabOrder</see> method.

## GetTabOrder

Gets the tab order.

* **tabName:** Name of the tab control

**Returns:** Tab order. Array of strings. Each string represent a named tab.


[WSDL file for Services81/Preference](../Services81-Preference.md)

Obtain a ticket from the [Services81/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTabOrder Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services81">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:GetTabOrder>
    <Preference:TabName xsi:type="xsd:string"></Preference:TabName>
   </Preference:GetTabOrder>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetTabOrder Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices812="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices811="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services81">
 <SOAP-ENV:Body>
  <Preference:GetTabOrderResponse>
   <Preference:Response xsi:type="Preference:TabOrder">
    <Preference:TabOrderId xsi:type="xsd:int">0</Preference:TabOrderId>
    <Preference:TabName xsi:type="xsd:string"></Preference:TabName>
    <Preference:Order xsi:type="xsd:string"></Preference:Order>
    <Preference:AssociateId xsi:type="xsd:int">0</Preference:AssociateId>
   </Preference:Response>
  </Preference:GetTabOrderResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

