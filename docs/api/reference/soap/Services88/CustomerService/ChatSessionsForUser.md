---
title: Services88.CustomerServiceAgent.ChatSessionsForUser SOAP
generated: 1
uid: Services88-CustomerService-ChatSessionsForUser
---

# Services88 CustomerService ChatSessionsForUser

SOAP request and response examples **Remote/Services88/CustomerService.svc**
Implemented by the <see cref="M:SuperOffice.Services88.ICustomerServiceAgent.ChatSessionsForUser">SuperOffice.Services88.ICustomerServiceAgent.ChatSessionsForUser</see> method.

## ChatSessionsForUser

Get all chat TOPICS which this user is a member of. Members means that you have at least one of: Can Respond, Notifications, Listen or Manager


**Returns:** Array of chat TOPIC ids the current user can access. NOT chat sessions.


[WSDL file for Services88/CustomerService](../Services88-CustomerService.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ChatSessionsForUser Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
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
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:CustomerService="http://www.superoffice.net/ws/crm/NetServer/Services88">
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

