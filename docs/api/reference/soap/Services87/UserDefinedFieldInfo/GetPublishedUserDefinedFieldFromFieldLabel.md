---
title: Services87.UserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel SOAP
generated: 1
uid: Services87-UserDefinedFieldInfo-GetPublishedUserDefinedFieldFromFieldLabel
---

# Services87 UserDefinedFieldInfo GetPublishedUserDefinedFieldFromFieldLabel

SOAP request and response examples **Remote/Services87/UserDefinedFieldInfo.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel">SuperOffice.Services87.IUserDefinedFieldInfoAgent.GetPublishedUserDefinedFieldFromFieldLabel</see> method.

## GetPublishedUserDefinedFieldFromFieldLabel

Return information about the given user defined field identified by the owner and the field label. Note that field labels are fuzzy. Leading and trailing spaces and punctuation are ignored.

* **fieldLabel:** The field label - the text label shown in the user interface. Trailing spaces and punctuation (":" and ".") are ignored when searching.
* **ownerType:** The user-defined field owner-entity id.

**Returns:** Returns the user-defined field info carrier, or null if no matching field is found.


[WSDL file for Services87/UserDefinedFieldInfo](../Services87-UserDefinedFieldInfo.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetPublishedUserDefinedFieldFromFieldLabel Request

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
   <UserDefinedFieldInfo:GetPublishedUserDefinedFieldFromFieldLabel>
    <UserDefinedFieldInfo:FieldLabel xsi:type="xsd:string"></UserDefinedFieldInfo:FieldLabel>
    <UserDefinedFieldInfo:OwnerType xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:OwnerType>
   </UserDefinedFieldInfo:GetPublishedUserDefinedFieldFromFieldLabel>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetPublishedUserDefinedFieldFromFieldLabel Response

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
  <UserDefinedFieldInfo:GetPublishedUserDefinedFieldFromFieldLabelResponse>
   <UserDefinedFieldInfo:Response xsi:type="UserDefinedFieldInfo:UserDefinedFieldInfo">
    <UserDefinedFieldInfo:UDefFieldId xsi:type="xsd:int">0</UserDefinedFieldInfo:UDefFieldId>
    <UserDefinedFieldInfo:ColumnId xsi:type="xsd:int">0</UserDefinedFieldInfo:ColumnId>
    <UserDefinedFieldInfo:FieldDefault xsi:type="xsd:string"></UserDefinedFieldInfo:FieldDefault>
    <UserDefinedFieldInfo:FieldHeight xsi:type="xsd:short">0</UserDefinedFieldInfo:FieldHeight>
    <UserDefinedFieldInfo:FieldLabel xsi:type="xsd:string"></UserDefinedFieldInfo:FieldLabel>
    <UserDefinedFieldInfo:FieldLeft xsi:type="xsd:short">0</UserDefinedFieldInfo:FieldLeft>
    <UserDefinedFieldInfo:FieldTop xsi:type="xsd:short">0</UserDefinedFieldInfo:FieldTop>
    <UserDefinedFieldInfo:FieldType xsi:type="UserDefinedFieldInfo:UDefFieldType">Number</UserDefinedFieldInfo:FieldType>
    <UserDefinedFieldInfo:FieldWidth xsi:type="xsd:short">0</UserDefinedFieldInfo:FieldWidth>
    <UserDefinedFieldInfo:FormatMask xsi:type="xsd:string"></UserDefinedFieldInfo:FormatMask>
    <UserDefinedFieldInfo:HideLabel xsi:type="xsd:boolean">false</UserDefinedFieldInfo:HideLabel>
    <UserDefinedFieldInfo:IsIndexed xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsIndexed>
    <UserDefinedFieldInfo:LabelHeight xsi:type="xsd:short">0</UserDefinedFieldInfo:LabelHeight>
    <UserDefinedFieldInfo:LabelLeft xsi:type="xsd:short">0</UserDefinedFieldInfo:LabelLeft>
    <UserDefinedFieldInfo:LabelTop xsi:type="xsd:short">0</UserDefinedFieldInfo:LabelTop>
    <UserDefinedFieldInfo:LabelWidth xsi:type="xsd:short">0</UserDefinedFieldInfo:LabelWidth>
    <UserDefinedFieldInfo:LastVersionId xsi:type="xsd:int">0</UserDefinedFieldInfo:LastVersionId>
    <UserDefinedFieldInfo:ListTableId xsi:type="xsd:short">0</UserDefinedFieldInfo:ListTableId>
    <UserDefinedFieldInfo:IsMandatory xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsMandatory>
    <UserDefinedFieldInfo:Type xsi:type="UserDefinedFieldInfo:UDefType">Invalid</UserDefinedFieldInfo:Type>
    <UserDefinedFieldInfo:Page1LineNo xsi:type="xsd:short">0</UserDefinedFieldInfo:Page1LineNo>
    <UserDefinedFieldInfo:ProgId xsi:type="xsd:string"></UserDefinedFieldInfo:ProgId>
    <UserDefinedFieldInfo:IsReadOnly xsi:type="xsd:boolean">false</UserDefinedFieldInfo:IsReadOnly>
    <UserDefinedFieldInfo:ShortLabel xsi:type="xsd:string"></UserDefinedFieldInfo:ShortLabel>
    <UserDefinedFieldInfo:TabOrder xsi:type="xsd:short">0</UserDefinedFieldInfo:TabOrder>
    <UserDefinedFieldInfo:TextLength xsi:type="xsd:short">0</UserDefinedFieldInfo:TextLength>
    <UserDefinedFieldInfo:Tooltip xsi:type="xsd:string"></UserDefinedFieldInfo:Tooltip>
    <UserDefinedFieldInfo:UdefIdentity xsi:type="xsd:int">0</UserDefinedFieldInfo:UdefIdentity>
    <UserDefinedFieldInfo:UDListDefinitionId xsi:type="xsd:int">0</UserDefinedFieldInfo:UDListDefinitionId>
    <UserDefinedFieldInfo:Justification xsi:type="UserDefinedFieldInfo:UdefJustification">Default</UserDefinedFieldInfo:Justification>
    <UserDefinedFieldInfo:Version xsi:type="xsd:short">0</UserDefinedFieldInfo:Version>
    <UserDefinedFieldInfo:TemplateVariableName xsi:type="xsd:string"></UserDefinedFieldInfo:TemplateVariableName>
    <UserDefinedFieldInfo:HasBeenPublished xsi:type="xsd:boolean">false</UserDefinedFieldInfo:HasBeenPublished>
    <UserDefinedFieldInfo:MdoListName xsi:type="xsd:string"></UserDefinedFieldInfo:MdoListName>
   </UserDefinedFieldInfo:Response>
  </UserDefinedFieldInfo:GetPublishedUserDefinedFieldFromFieldLabelResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

