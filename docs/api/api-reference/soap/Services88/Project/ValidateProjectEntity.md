---
uid: services88-project-validateprojectentity
title: Services88.ProjectAgent.ValidateProjectEntity SOAP
Generated: true
---

# Services88 Project ValidateProjectEntity SOAP

SOAP request and response examples **Remote/Services88/Project.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IProjectAgent.ValidateProjectEntity">SuperOffice.Services88.IProjectAgent.ValidateProjectEntity</see> method.

## ValidateProjectEntity

Check that entity is ready for saving, return error messages by field.

* **projectEntity:** Entity to be checked for errors.

**Returns:** Error messages tagged by field.


[WSDL file for Services88/Project](../Services88-Project.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## ValidateProjectEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Project:ApplicationToken>1234567-1234-9876</Project:ApplicationToken>
  <Project:Credentials>
    <Project:Ticket>7T:1234abcxyzExample==</Project:Ticket>
  </Project:Credentials>
 <SOAP-ENV:Body>
   <Project:ValidateProjectEntity>
    <Project:ProjectEntity xsi:type="Project:ProjectEntity">
     <Project:ProjectId xsi:type="xsd:int">0</Project:ProjectId>
     <Project:Name xsi:type="xsd:string"></Project:Name>
     <Project:ProjectNumber xsi:type="xsd:string"></Project:ProjectNumber>
     <Project:ProjectMembers xsi:type="Project:ArrayOfProjectMember">
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
     </Project:ProjectMembers>
     <Project:Urls xsi:type="Project:ArrayOfEntityElement">
      <Project:EntityElement xsi:type="Project:EntityElement">
       <Project:Value xsi:type="xsd:string"></Project:Value>
       <Project:StrippedValue xsi:type="xsd:string"></Project:StrippedValue>
       <Project:Description xsi:type="xsd:string"></Project:Description>
      </Project:EntityElement>
     </Project:Urls>
     <Project:CreatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:CreatedDate>
     <Project:UpdatedDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:UpdatedDate>
     <Project:Description xsi:type="xsd:string"></Project:Description>
     <Project:Postit xsi:type="xsd:string"></Project:Postit>
     <Project:CreatedBy xsi:type="Project:Associate">
      <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
      <Project:Name xsi:type="xsd:string"></Project:Name>
      <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
      <Project:Rank xsi:type="xsd:short">0</Project:Rank>
      <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
      <Project:Type xsi:type="Project:UserType">Unknown</Project:Type>
      <Project:GroupIdx xsi:type="xsd:int">0</Project:GroupIdx>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
      <Project:FormalName xsi:type="xsd:string"></Project:FormalName>
      <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
      <Project:EjUserId xsi:type="xsd:int">0</Project:EjUserId>
      <Project:UserName xsi:type="xsd:string"></Project:UserName>
     </Project:CreatedBy>
     <Project:UpdatedBy xsi:type="Project:Associate">
      <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
      <Project:Name xsi:type="xsd:string"></Project:Name>
      <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
      <Project:Rank xsi:type="xsd:short">0</Project:Rank>
      <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
      <Project:Type xsi:type="Project:UserType">Unknown</Project:Type>
      <Project:GroupIdx xsi:type="xsd:int">0</Project:GroupIdx>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
      <Project:FormalName xsi:type="xsd:string"></Project:FormalName>
      <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
      <Project:EjUserId xsi:type="xsd:int">0</Project:EjUserId>
      <Project:UserName xsi:type="xsd:string"></Project:UserName>
     </Project:UpdatedBy>
     <Project:Associate xsi:type="Project:Associate">
      <Project:AssociateId xsi:type="xsd:int">0</Project:AssociateId>
      <Project:Name xsi:type="xsd:string"></Project:Name>
      <Project:PersonId xsi:type="xsd:int">0</Project:PersonId>
      <Project:Rank xsi:type="xsd:short">0</Project:Rank>
      <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
      <Project:Type xsi:type="Project:UserType">Unknown</Project:Type>
      <Project:GroupIdx xsi:type="xsd:int">0</Project:GroupIdx>
      <Project:FullName xsi:type="xsd:string"></Project:FullName>
      <Project:FormalName xsi:type="xsd:string"></Project:FormalName>
      <Project:Deleted xsi:type="xsd:boolean">false</Project:Deleted>
      <Project:EjUserId xsi:type="xsd:int">0</Project:EjUserId>
      <Project:UserName xsi:type="xsd:string"></Project:UserName>
     </Project:Associate>
     <Project:ProjectStatus xsi:type="Project:ProjectStatus">
      <Project:Id xsi:type="xsd:int">0</Project:Id>
      <Project:Value xsi:type="xsd:string"></Project:Value>
      <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
     </Project:ProjectStatus>
     <Project:ProjectType xsi:type="Project:ProjectType">
      <Project:Id xsi:type="xsd:int">0</Project:Id>
      <Project:Value xsi:type="xsd:string"></Project:Value>
      <Project:Tooltip xsi:type="xsd:string"></Project:Tooltip>
     </Project:ProjectType>
     <Project:HasImage xsi:type="xsd:boolean">false</Project:HasImage>
     <Project:ImageDescription xsi:type="xsd:string"></Project:ImageDescription>
     <Project:ActiveStatusMonitorId xsi:type="xsd:int">0</Project:ActiveStatusMonitorId>
     <Project:Links xsi:type="Project:ArrayOfLink">
      <Project:Link xsi:type="Project:Link">
       <Project:EntityName xsi:type="xsd:string"></Project:EntityName>
       <Project:Id xsi:type="xsd:int">0</Project:Id>
       <Project:Description xsi:type="xsd:string"></Project:Description>
       <Project:ExtraInfo xsi:type="xsd:string"></Project:ExtraInfo>
       <Project:LinkId xsi:type="xsd:int">0</Project:LinkId>
      </Project:Link>
     </Project:Links>
     <Project:ActiveLinks xsi:type="xsd:unsignedInt">0</Project:ActiveLinks>
     <Project:Completed xsi:type="xsd:boolean">false</Project:Completed>
     <Project:NextMilestoneDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:NextMilestoneDate>
     <Project:NmdAppointmentId xsi:type="xsd:int">0</Project:NmdAppointmentId>
     <Project:EndDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:EndDate>
     <Project:ActiveErpLinks xsi:type="xsd:int">0</Project:ActiveErpLinks>
     <Project:UserDefinedFields xsi:type="Project:StringDictionary">
      <Project:StringKeyValuePair>
       <Project:Key xsi:type="xsd:string"></Project:Key>
       <Project:Value xsi:type="xsd:string"></Project:Value>
      </Project:StringKeyValuePair>
     </Project:UserDefinedFields>
     <Project:ExtraFields xsi:type="Project:StringDictionary">
      <Project:StringKeyValuePair>
       <Project:Key xsi:type="xsd:string"></Project:Key>
       <Project:Value xsi:type="xsd:string"></Project:Value>
      </Project:StringKeyValuePair>
     </Project:ExtraFields>
     <Project:CustomFields xsi:type="Project:StringDictionary">
      <Project:StringKeyValuePair>
       <Project:Key xsi:type="xsd:string"></Project:Key>
       <Project:Value xsi:type="xsd:string"></Project:Value>
      </Project:StringKeyValuePair>
     </Project:CustomFields>
     <Project:PublishEventDate xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:PublishEventDate>
     <Project:PublishTo xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:PublishTo>
     <Project:PublishFrom xsi:type="xsd:dateTime">2021-03-25T21:37:07Z</Project:PublishFrom>
     <Project:IsPublished xsi:type="xsd:boolean">false</Project:IsPublished>
    </Project:ProjectEntity>
   </Project:ValidateProjectEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## ValidateProjectEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Project="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Project:ValidateProjectEntityResponse>
   <Project:Response xsi:type="Project:StringDictionary">
    <Project:StringKeyValuePair>
     <Project:Key xsi:type="xsd:string"></Project:Key>
     <Project:Value xsi:type="xsd:string"></Project:Value>
    </Project:StringKeyValuePair>
   </Project:Response>
  </Project:ValidateProjectEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

