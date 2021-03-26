---
uid: services88-archive-setchosenentitiesv2
title: Services88.ArchiveAgent.SetChosenEntitiesV2 SOAP
Generated: true
---

# Services88 Archive SetChosenEntitiesV2 SOAP

SOAP request and response examples **Remote/Services88/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IArchiveAgent.SetChosenEntitiesV2">SuperOffice.Services88.IArchiveAgent.SetChosenEntitiesV2</see> method.

## SetChosenEntitiesV2

Set the currently chosen entities for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveEntities: plus the archive provider name and gui name as its additionalInfo.

* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **context:** Context parameter, url-encoded string context parameter for ArchiveProvider constructor. Optional, but required for archives that depend on a context - for instance Quote archives that need to know their QuoteConnectionId to be meaningful
* **ownerKeys:** Name/value string containing ownership binding information. The first should resolve to a table/primarykey, such as selection=123. Future functionality may allow multiple/extended keys
* **entities:** Array of entity names



[WSDL file for Services88/Archive](../Services88-Archive.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetChosenEntitiesV2 Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:SetChosenEntitiesV2>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:Context xsi:type="xsd:string"></Archive:Context>
    <Archive:OwnerKeys xsi:type="xsd:string"></Archive:OwnerKeys>
    <Archive:Entities xsi:type="NetServerServices882:ArrayOfstring">
     <NetServerServices882:string xsi:type="xsd:string"></NetServerServices882:string>
    </Archive:Entities>
   </Archive:SetChosenEntitiesV2>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetChosenEntitiesV2 Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices882="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Archive:SetChosenEntitiesV2Response>
  </Archive:SetChosenEntitiesV2Response>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

