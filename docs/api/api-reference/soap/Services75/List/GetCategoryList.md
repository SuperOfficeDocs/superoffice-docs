---
uid: services75-list-getcategorylist
title: Services75.ListAgent.GetCategoryList SOAP
Generated: true
---

# Services75 List GetCategoryList SOAP

SOAP request and response examples **Remote/Services75/List.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IListAgent.GetCategoryList">SuperOffice.Services75.IListAgent.GetCategoryList</see> method.

## GetCategoryList

Gets an array of Category objects.

* **categoryIds:** The identifiers of the Category object

**Returns:** Array of Category objects


[WSDL file for Services75/List](../Services75-List.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCategoryList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetCategoryList>
    <List:CategoryIds xsi:type="NetServerServices752:ArrayOfint">
     <NetServerServices752:int xsi:type="xsd:int">0</NetServerServices752:int>
    </List:CategoryIds>
   </List:GetCategoryList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCategoryList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <List:GetCategoryListResponse>
   <List:Response xsi:type="List:ArrayOfCategory">
    <List:Category xsi:type="List:Category">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Category>
   </List:Response>
  </List:GetCategoryListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

