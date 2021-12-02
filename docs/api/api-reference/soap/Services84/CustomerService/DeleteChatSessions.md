---
title: Services84.CustomerServiceAgent.DeleteChatSessions SOAP
generated: 1
uid: Services84-CustomerService-DeleteChatSessions
---

# Services84 CustomerService DeleteChatSessions

SOAP request and response examples **Remote/Services84/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services84.ICustomerServiceAgent.DeleteChatSessions">SuperOffice.Services84.ICustomerServiceAgent.DeleteChatSessions</see> method.

## DeleteChatSessions

Deletes the specified chat sessions.

* **ids:** The ids of the chat sessions to delete

**Returns:** This method has no return value


[WSDL file for Services84/CustomerService](../Services84-CustomerService.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteChatSessions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:DeleteChatSessions>
    <CustomerService:Ids xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </CustomerService:Ids>
   </CustomerService:DeleteChatSessions>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteChatSessions Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <CustomerService:DeleteChatSessionsResponse>
  </CustomerService:DeleteChatSessionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

