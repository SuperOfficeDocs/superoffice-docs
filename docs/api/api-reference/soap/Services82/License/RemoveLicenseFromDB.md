---
uid: services82-license-removelicensefromdb
title: Services82.LicenseAgent.RemoveLicenseFromDB SOAP
Generated: true
---

# Services82 License RemoveLicenseFromDB SOAP

SOAP request and response examples **Remote/Services82/License.svc**
Implemented by the <see cref="M:SuperOffice.Services82.ILicenseAgent.RemoveLicenseFromDB">SuperOffice.Services82.ILicenseAgent.RemoveLicenseFromDB</see> method.

## RemoveLicenseFromDB

Remove the license from a particular module owner from the database.  It is not permitted to remove licenses from SuperOffice

* **moduleOwner:** Name of the module owner to remove license from.



[WSDL file for Services82/License](../Services82-License.md)

Obtain a ticket from the [Services82/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## RemoveLicenseFromDB Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services82">
  <License:ApplicationToken>1234567-1234-9876</License:ApplicationToken>
  <License:Credentials>
    <License:Ticket>7T:1234abcxyzExample==</License:Ticket>
  </License:Credentials>
 <SOAP-ENV:Body>
   <License:RemoveLicenseFromDB>
    <License:ModuleOwner xsi:type="xsd:string"></License:ModuleOwner>
   </License:RemoveLicenseFromDB>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## RemoveLicenseFromDB Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices822="http://schemas.datacontract.org/2004/07/System.Security.Cryptography"
 xmlns:NetServerServices821="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:License="http://www.superoffice.net/ws/crm/NetServer/Services82">
 <SOAP-ENV:Body>
  <License:RemoveLicenseFromDBResponse>
   <License:Response xsi:type="License:LicenseResult">
    <License:Succeeded xsi:type="xsd:boolean">false</License:Succeeded>
    <License:Reason xsi:type="xsd:string"></License:Reason>
   </License:Response>
  </License:RemoveLicenseFromDBResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

