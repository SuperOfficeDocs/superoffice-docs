---
uid: services86-preference-savetaborders
title: Services86.PreferenceAgent.SaveTabOrders SOAP
Generated: true
---

# Services86 Preference SaveTabOrders SOAP

SOAP request and response examples **Remote/Services86/Preference.svc**
Implemented by the <see cref="M:SuperOffice.Services86.IPreferenceAgent.SaveTabOrders">SuperOffice.Services86.IPreferenceAgent.SaveTabOrders</see> method.

## SaveTabOrders



* **tabOrders:** 



[WSDL file for Services86/Preference](../Services86-Preference.md)

Obtain a ticket from the [Services86/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveTabOrders Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
  <Preference:ApplicationToken>1234567-1234-9876</Preference:ApplicationToken>
  <Preference:Credentials>
    <Preference:Ticket>7T:1234abcxyzExample==</Preference:Ticket>
  </Preference:Credentials>
 <SOAP-ENV:Body>
   <Preference:SaveTabOrders>
    <Preference:TabOrders xsi:type="Preference:ArrayOfTabOrder">
     <Preference:TabOrder xsi:type="Preference:TabOrder">
      <Preference:TabOrderId xsi:type="xsd:int">0</Preference:TabOrderId>
      <Preference:TabName xsi:type="xsd:string"></Preference:TabName>
      <Preference:Order xsi:type="xsd:string"></Preference:Order>
      <Preference:AssociateId xsi:type="xsd:int">0</Preference:AssociateId>
     </Preference:TabOrder>
    </Preference:TabOrders>
   </Preference:SaveTabOrders>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveTabOrders Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices862="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices861="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Preference="http://www.superoffice.net/ws/crm/NetServer/Services86">
 <SOAP-ENV:Body>
  <Preference:SaveTabOrdersResponse>
  </Preference:SaveTabOrdersResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

