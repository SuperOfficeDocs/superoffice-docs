---
uid: services80-list-getcustomerlanguagelist
title: Services80.ListAgent.GetCustomerLanguageList SOAP
Generated: true
---

# Services80 List GetCustomerLanguageList SOAP

SOAP request and response examples **Remote/Services80/List.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IListAgent.GetCustomerLanguageList">SuperOffice.Services80.IListAgent.GetCustomerLanguageList</see> method.

## GetCustomerLanguageList

Gets an array of CustomerLanguage objects.

* **customerLanguageIds:** The identifiers of the CustomerLanguage object

**Returns:** Array of CustomerLanguage objects


[WSDL file for Services80/List](../Services80-List.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCustomerLanguageList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetCustomerLanguageList>
    <List:CustomerLanguageIds xsi:type="NetServerServices802:ArrayOfint">
     <NetServerServices802:int xsi:type="xsd:int">0</NetServerServices802:int>
    </List:CustomerLanguageIds>
   </List:GetCustomerLanguageList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCustomerLanguageList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <List:GetCustomerLanguageListResponse>
   <List:Response xsi:type="List:ArrayOfCustomerLanguage">
    <List:CustomerLanguage xsi:type="List:CustomerLanguage">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:CustomerLanguage>
   </List:Response>
  </List:GetCustomerLanguageListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

