---
uid: services85-customerservice-deletechatsessions
title: Services85.CustomerServiceAgent.DeleteChatSessions SOAP
Generated: true
---

# Services85 CustomerService DeleteChatSessions SOAP

SOAP request and response examples **Remote/Services85/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ICustomerServiceAgent.DeleteChatSessions">SuperOffice.Services85.ICustomerServiceAgent.DeleteChatSessions</see> method.

## DeleteChatSessions

Deletes the specified chat sessions.

* **ids:** The ids of the chat sessions to delete

**Returns:** This method has no return value


[WSDL file for Services85/CustomerService](../Services85-CustomerService.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteChatSessions Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <CustomerService:ApplicationToken>1234567-1234-9876</CustomerService:ApplicationToken>
  <CustomerService:Credentials>
    <CustomerService:Ticket>7T:1234abcxyzExample==</CustomerService:Ticket>
  </CustomerService:Credentials>
 <SOAP-ENV:Body>
   <CustomerService:DeleteChatSessions>
    <CustomerService:Ids xsi:type="NetServerServices852:ArrayOfint">
     <NetServerServices852:int xsi:type="xsd:int">0</NetServerServices852:int>
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
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <CustomerService:DeleteChatSessionsResponse>
  </CustomerService:DeleteChatSessionsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

