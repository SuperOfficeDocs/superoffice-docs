---
uid: services87-userdefinedfieldinfo-getcustomfieldinfo
title: Services87.UserDefinedFieldInfoAgent.GetCustomFieldInfo SOAP
Generated: true
---

# Services87 UserDefinedFieldInfo GetCustomFieldInfo SOAP

SOAP request and response examples **Remote/Services87/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetCustomFieldInfo">SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetCustomFieldInfo</see> method.

## GetCustomFieldInfo

Return information about a particular custom field (user-defined + extra) on a particular table

* **tableName:** The name of table that owns the custom fields. e.g. 'contact', 'person', 'project' etc.
* **fieldName:** The name of the field: prog:id or field name. e.g. 'SuperOffice:21' or 'x\_foobar'

**Returns:** user-defined or extra field info. Describes default values, mandatory, visiblity, labels and choices.


[WSDL file for Services87/UserDefinedFieldInfo](../Services87-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomFieldInfo Request

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
   <UserDefinedFieldInfo:GetCustomFieldInfo>
    <UserDefinedFieldInfo:TableName xsi:type="xsd:string"></UserDefinedFieldInfo:TableName>
    <UserDefinedFieldInfo:FieldName xsi:type="xsd:string"></UserDefinedFieldInfo:FieldName>
   </UserDefinedFieldInfo:GetCustomFieldInfo>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomFieldInfo Response

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
  <UserDefinedFieldInfo:GetCustomFieldInfoResponse>
   <UserDefinedFieldInfo:Response xsi:type="UserDefinedFieldInfo:FieldInfoBase">
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
   </UserDefinedFieldInfo:Response>
  </UserDefinedFieldInfo:GetCustomFieldInfoResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

