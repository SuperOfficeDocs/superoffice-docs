---
uid: services85-customerservice-chatsessionsforuser
title: Services85.CustomerServiceAgent.ChatSessionsForUser SOAP
Generated: true
---

# Services85 CustomerService ChatSessionsForUser SOAP

SOAP request and response examples **Remote/Services85/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services85.ICustomerServiceAgent.ChatSessionsForUser">SuperOffice.Services85.ICustomerServiceAgent.ChatSessionsForUser</see> method.

## ChatSessionsForUser

Get all chat sessions which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat sessions


[WSDL file for Services85/CustomerService](../Services85-CustomerService.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChatSessionsForUser Request

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
   <CustomerService:ChatSessionsForUser>
   </CustomerService:ChatSessionsForUser>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ChatSessionsForUser Response

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
  <CustomerService:ChatSessionsForUserResponse>
   <CustomerService:Response xsi:type="CustomerService:ArrayOfChatSession">
    <CustomerService:ChatSession xsi:type="CustomerService:ChatSession">
     <CustomerService:ChatSessionId xsi:type="xsd:int">0</CustomerService:ChatSessionId>
    </CustomerService:ChatSession>
   </CustomerService:Response>
  </CustomerService:ChatSessionsForUserResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

