---
uid: services87-userdefinedfieldinfo-getcustomfieldinfolist
title: Services87.UserDefinedFieldInfoAgent.GetCustomFieldInfoList SOAP
Generated: true
---

# Services87 UserDefinedFieldInfo GetCustomFieldInfoList SOAP

SOAP request and response examples **Remote/Services87/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetCustomFieldInfoList">SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetCustomFieldInfoList</see> method.

## GetCustomFieldInfoList

Return information about all the custom fields (user-defined + extra) on a particular table

* **tableName:** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
* **includeStandard:** Include standard fields in result. Default false.

**Returns:** Array of user-defined and extra field info in rank order. Describes default values, mandatory, visiblity, labels and choices.


[WSDL file for Services87/UserDefinedFieldInfo](../Services87-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomFieldInfoList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <UserDefinedFieldInfo:ApplicationToken>1234567-1234-9876</UserDefinedFieldInfo:ApplicationToken>
  <UserDefinedFieldInfo:Credentials>
    <UserDefinedFieldInfo:Ticket>7T:1234abcxyzExample==</UserDefinedFieldInfo:Ticket>
  </UserDefinedFieldInfo:Credentials>
 <SOAP-ENV:Body>
   <UserDefinedFieldInfo:GetCustomFieldInfoList>
    <UserDefinedFieldInfo:TableName xsi:type="xsd:string"></UserDefinedFieldInfo:TableName>
    <UserDefinedFieldInfo:IncludeStandard xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IncludeStandard>
   </UserDefinedFieldInfo:GetCustomFieldInfoList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomFieldInfoList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:UserDefinedFieldInfo="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <UserDefinedFieldInfo:GetCustomFieldInfoListResponse>
   <UserDefinedFieldInfo:Response xsi:type="UserDefinedFieldInfo:ArrayOfFieldInfoBase">
    <UserDefinedFieldInfo:FieldInfoBase xsi:type="UserDefinedFieldInfo:FieldInfoBase">
     <UserDefinedFieldInfo:FieldType xsi:type="UserDefinedFieldInfo:CustomFieldType">Unknown</UserDefinedFieldInfo:FieldType>
     <UserDefinedFieldInfo:FieldName xsi:type="xsd:string"></UserDefinedFieldInfo:FieldName>
     <UserDefinedFieldInfo:DisplayName xsi:type="xsd:string"></UserDefinedFieldInfo:DisplayName>
     <UserDefinedFieldInfo:Description xsi:type="xsd:string"></UserDefinedFieldInfo:Description>
     <UserDefinedFieldInfo:ShortLabel xsi:type="xsd:string"></UserDefinedFieldInfo:ShortLabel>
     <UserDefinedFieldInfo:HideLabel xsi:type="xsd:boolean">false</UserDefinedFieldInfo:HideLabel>
     <UserDefinedFieldInfo:HideField xsi:type="xsd:boolean">false</UserDefinedFieldInfo:HideField>
     <UserDefinedFieldInfo:IsIndexed xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsIndexed>
     <UserDefinedFieldInfo:IsMandatory xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsMandatory>
     <UserDefinedFieldInfo:IsReadOnly xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsReadOnly>
     <UserDefinedFieldInfo:IsExternal xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsExternal>
     <UserDefinedFieldInfo:Rank xsi:type="xsd:int">0</UserDefinedFieldInfo:Rank>
     <UserDefinedFieldInfo:TemplateVariableName xsi:type="xsd:string"></UserDefinedFieldInfo:TemplateVariableName>
    </UserDefinedFieldInfo:FieldInfoBase>
   </UserDefinedFieldInfo:Response>
  </UserDefinedFieldInfo:GetCustomFieldInfoListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

