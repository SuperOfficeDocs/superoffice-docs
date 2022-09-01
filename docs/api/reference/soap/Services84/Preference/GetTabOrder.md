---
title: Services84.PreferenceAgent.GetTabOrder SOAP
generated: 1
uid: Services84-Preference-GetTabOrder
---

# Services84 Preference GetTabOrder

SOAP request and response examples **Remote/Services84/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IPreferenceAgent.GetTabOrder">SuperOffice.Services84.IPreferenceAgent.GetTabOrder</see> method.

## GetTabOrder

Gets the tab order.

* **tabName:** Name of the tab control

**Returns:** Tab order. Array of strings. Each string represent a named tab.


[WSDL file for Services84/Preference](../Services84-Preference.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetTabOrder Request

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
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services84">
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

