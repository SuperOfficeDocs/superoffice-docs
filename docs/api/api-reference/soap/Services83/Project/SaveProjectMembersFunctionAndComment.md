---
uid: services83-project-saveprojectmembersfunctionandcomment
title: Services83.ProjectAgent.SaveProjectMembersFunctionAndComment SOAP
Generated: true
---

# Services83 Project SaveProjectMembersFunctionAndComment SOAP

SOAP request and response examples **Remote/Services83/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services83.IProjectAgent.SaveProjectMembersFunctionAndComment">SuperOffice.Services83.IProjectAgent.SaveProjectMembersFunctionAndComment</see> method.

## SaveProjectMembersFunctionAndComment

Saves role and comment on an array of projectmembers represented by ids

* **projectMemberIds:** 
* **roleId:** 
* **comment:** 



[WSDL file for Services83/Project](../Services83-Project.md)

Obtain a ticket from the [Services83/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveProjectMembersFunctionAndComment Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services83">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:SaveProjectMembersFunctionAndComment>
    <Project:ProjectMemberIds xsi:type="NetServerServices832:ArrayOfint">
     <NetServerServices832:int xsi:type="xsd:int">0</NetServerServices832:int>
    </Project:ProjectMemberIds>
    <Project:RoleId xsi:type="xsd:int">0</Project:RoleId>
    <Project:Comment xsi:type="xsd:string"></Project:Comment>
   </Project:SaveProjectMembersFunctionAndComment>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveProjectMembersFunctionAndComment Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices832="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices831="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services83">
 <SOAP-ENV:Body>
  <Project:SaveProjectMembersFunctionAndCommentResponse>
  </Project:SaveProjectMembersFunctionAndCommentResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

