---
title: Services88.ListAgent.SaveCategoryEntity SOAP
generated: true
uid: Services88-List-SaveCategoryEntity
content_type: reference
---

# Services88 List SaveCategoryEntity

SOAP request and response examples **Remote/Services88/List.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IListAgent.SaveCategoryEntity">SuperOffice.Services88.IListAgent.SaveCategoryEntity</see> method.

## SaveCategoryEntity





[WSDL file for Services88/List](../Services88-List.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveCategoryEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:SaveCategoryEntity>
    <List:CategoryEntity xsi:type="List:CategoryEntity">
     <List:CategoryId xsi:type="xsd:int">0</List:CategoryId>
     <List:Name xsi:type="xsd:string"></List:Name>
     <List:CategoryGroup xsi:type="List:CategoryGroup">Unknown</List:CategoryGroup>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
     <List:Rank xsi:type="xsd:short">0</List:Rank>
     <List:EnableLeadStatus xsi:type="xsd:boolean">false</List:EnableLeadStatus>
     <List:CategoryFamilyId xsi:type="xsd:int">0</List:CategoryFamilyId>
     <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
    </List:CategoryEntity>
   </List:SaveCategoryEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveCategoryEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <List:SaveCategoryEntityResponse>
   <List:Response xsi:type="List:CategoryEntity">
    <List:CategoryId xsi:type="xsd:int">0</List:CategoryId>
    <List:Name xsi:type="xsd:string"></List:Name>
    <List:CategoryGroup xsi:type="List:CategoryGroup">Unknown</List:CategoryGroup>
    <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    <List:Rank xsi:type="xsd:short">0</List:Rank>
    <List:EnableLeadStatus xsi:type="xsd:boolean">false</List:EnableLeadStatus>
    <List:CategoryFamilyId xsi:type="xsd:int">0</List:CategoryFamilyId>
    <List:Deleted xsi:type="xsd:boolean">false</List:Deleted>
   </List:Response>
  </List:SaveCategoryEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

