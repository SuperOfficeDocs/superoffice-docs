---
title: Services87.ProjectAgent.GetProjectMembersById SOAP
generated: 1
uid: Services87-Project-GetProjectMembersById
---

# Services87 Project GetProjectMembersById

SOAP request and response examples **Remote/Services87/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IProjectAgent.GetProjectMembersById">SuperOffice.Services87.IProjectAgent.GetProjectMembersById</see> method.

## GetProjectMembersById

Returns an array of project members

* **projectMemberIds:** 

**Returns:** An array of project members


[WSDL file for Services87/Project](../Services87-Project.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetProjectMembersById Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:GetProjectMembersById>
    <Project:ProjectMemberIds xsi:type="NetServerServices872:ArrayOfint">
     <NetServerServices872:int xsi:type="xsd:int">0</NetServerServices872:int>
    </Project:ProjectMemberIds>
   </Project:GetProjectMembersById>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetProjectMembersById Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Project:GetProjectMembersByIdResponse>
   <Project:Response xsi:type="Project:ArrayOfProjectMember">
    <Project:ProjectMember xsi:type="Project:ProjectMember">
     <Project:ProjectmemberId xsi:type="xsd:int">0</Project:ProjectmemberId>
     <Project:ContactId xsi:type="xsd:int">0</Project:ContactId>
     <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
     <Project:ContactName xsi:type="xsd:string"></Project:ContactName>
     <Project:ContactDepartment xsi:type="xsd:string"></Project:ContactDepartment>
     <Project:ProjectName xsi:type="xsd:string"></Project:ProjectName>
     <Project:EmailId xsi:type="xsd:int">0</Project:EmailId>
     <Project:EmailAddress xsi:type="xsd:string"></Project:EmailAddress>
     <Project:CountryId xsi:type="xsd:int">0</Project:CountryId>
     <Project:Firstname xsi:type="xsd:string"></Project:Firstname>
     <Project:MiddleName xsi:type="xsd:string"></Project:MiddleName>
     <Project:Lastname xsi:type="xsd:string"></Project:Lastname>
     <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
     <Project:Mrmrs xsi:type="xsd:string"></Project:Mrmrs>
     <Project:ProjectMemberTypeName xsi:type="xsd:string"></Project:ProjectMemberTypeName>
     <Project:Phone xsi:type="xsd:string"></Project:Phone>
     <Project:PhoneId xsi:type="xsd:int">0</Project:PhoneId>
     <Project:ProjectMemberTypeId xsi:type="xsd:int">0</Project:ProjectMemberTypeId>
     <Project:EmailAddressName xsi:type="xsd:string"></Project:EmailAddressName>
     <Project:Comment xsi:type="xsd:string"></Project:Comment>
     <Project:FullName xsi:type="xsd:string"></Project:FullName>
    </Project:ProjectMember>
   </Project:Response>
  </Project:GetProjectMembersByIdResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

