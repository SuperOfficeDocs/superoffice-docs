---
title: Services84.ListAgent.GetCompetitorList SOAP
generated: 1
uid: Services84-List-GetCompetitorList
---

# Services84 List GetCompetitorList

SOAP request and response examples **Remote/Services84/List.svc**
Implemented by the <see cref="M:SuperOffice.Services84.IListAgent.GetCompetitorList">SuperOffice.Services84.IListAgent.GetCompetitorList</see> method.

## GetCompetitorList

Gets an array of Competitor objects.

* **competitorIds:** The identifiers of the Competitor object

**Returns:** Array of Competitor objects


[WSDL file for Services84/List](../Services84-List.md)

Obtain a ticket from the [Services84/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetCompetitorList Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
  <List:ApplicationToken>1234567-1234-9876</List:ApplicationToken>
  <List:Credentials>
    <List:Ticket>7T:1234abcxyzExample==</List:Ticket>
  </List:Credentials>
 <SOAP-ENV:Body>
   <List:GetCompetitorList>
    <List:CompetitorIds xsi:type="NetServerServices842:ArrayOfint">
     <NetServerServices842:int xsi:type="xsd:int">0</NetServerServices842:int>
    </List:CompetitorIds>
   </List:GetCompetitorList>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetCompetitorList Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices842="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices841="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:List="http://www.superoffice.net/ws/crm/NetServer/Services84">
 <SOAP-ENV:Body>
  <List:GetCompetitorListResponse>
   <List:Response xsi:type="List:ArrayOfCompetitor">
    <List:Competitor xsi:type="List:Competitor">
     <List:Id xsi:type="xsd:int">0</List:Id>
     <List:Value xsi:type="xsd:string"></List:Value>
     <List:Tooltip xsi:type="xsd:string"></List:Tooltip>
    </List:Competitor>
   </List:Response>
  </List:GetCompetitorListResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

