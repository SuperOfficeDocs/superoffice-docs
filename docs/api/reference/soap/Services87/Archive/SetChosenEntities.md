---
title: Services87.ArchiveAgent.SetChosenEntities SOAP
generated: 1
uid: Services87-Archive-SetChosenEntities
---

# Services87 Archive SetChosenEntities

SOAP request and response examples **Remote/Services87/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IArchiveAgent.SetChosenEntities">SuperOffice.Services87.IArchiveAgent.SetChosenEntities</see> method.

## SetChosenEntities

Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.

* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **entities:** Array of entity names



[WSDL file for Services87/Archive](../Services87-Archive.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetChosenEntities Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:SetChosenEntities>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Entities xsi:type="NetServerServices872:ArrayOfstring">
     <NetServerServices872:string xsi:type="xsd:string"></NetServerServices872:string>
    </Archive:Entities>
   </Archive:SetChosenEntities>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetChosenEntities Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Archive:SetChosenEntitiesResponse>
  </Archive:SetChosenEntitiesResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

