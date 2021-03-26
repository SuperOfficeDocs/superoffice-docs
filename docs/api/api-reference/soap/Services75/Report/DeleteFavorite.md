---
uid: services75-report-deletefavorite
title: Services75.ReportAgent.DeleteFavorite SOAP
Generated: true
---

# Services75 Report DeleteFavorite SOAP

SOAP request and response examples **Remote/Services75/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services75.IReportAgent.DeleteFavorite">SuperOffice.Services75.IReportAgent.DeleteFavorite</see> method.

## DeleteFavorite

Deletes the report favorite.

* **reportEntityId:** The id of the report favorite to delete.



[WSDL file for Services75/Report](../Services75-Report.md)

Obtain a ticket from the [Services75/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## DeleteFavorite Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services75">
  <Report:ApplicationToken>1234567-1234-9876</Report:ApplicationToken>
  <Report:Credentials>
    <Report:Ticket>7T:1234abcxyzExample==</Report:Ticket>
  </Report:Credentials>
 <SOAP-ENV:Body>
   <Report:DeleteFavorite>
    <Report:ReportEntityId xsi:type="xsd:int">0</Report:ReportEntityId>
   </Report:DeleteFavorite>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## DeleteFavorite Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices752="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices751="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services75">
 <SOAP-ENV:Body>
  <Report:DeleteFavoriteResponse>
  </Report:DeleteFavoriteResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

