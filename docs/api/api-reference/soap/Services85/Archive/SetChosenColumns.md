---
uid: services85-archive-setchosencolumns
title: Services85.ArchiveAgent.SetChosenColumns SOAP
Generated: true
---

# Services85 Archive SetChosenColumns SOAP

SOAP request and response examples **Remote/Services85/Archive.svc**
Implemented by the <see cref="M:SuperOffice.Services85.IArchiveAgent.SetChosenColumns">SuperOffice.Services85.IArchiveAgent.SetChosenColumns</see> method.

## SetChosenColumns

Set the currently chosen columns for the given gui name/provider name combination. This service corresponds to the SetSelected method of the SelectableMDOList service, for a list called archiveColumns: plus the archive provider name and gui name as its additionalInfo.

* **guiName:** String that identifies the archive in the GUI, must be the same when fetching and storing configurations, but does not otherwise have to match anything.
* **providerName:** Name of archive provider, must match one of the plugins known to the ArchiveProviderFactory.
* **chosenColumns:** Array of column names, where array order indicates left to right order in the archive.



[WSDL file for Services85/Archive](../Services85-Archive.md)

Obtain a ticket from the [Services85/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SetChosenColumns Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services85">
  <Archive:ApplicationToken>1234567-1234-9876</Archive:ApplicationToken>
  <Archive:Credentials>
    <Archive:Ticket>7T:1234abcxyzExample==</Archive:Ticket>
  </Archive:Credentials>
 <SOAP-ENV:Body>
   <Archive:SetChosenColumns>
    <Archive:GuiName xsi:type="xsd:string"></Archive:GuiName>
    <Archive:ProviderName xsi:type="xsd:string"></Archive:ProviderName>
    <Archive:ChosenColumns xsi:type="NetServerServices852:ArrayOfstring">
     <NetServerServices852:string xsi:type="xsd:string"></NetServerServices852:string>
    </Archive:ChosenColumns>
   </Archive:SetChosenColumns>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SetChosenColumns Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices852="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices851="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Archive="http://www.superoffice.net/ws/crm/NetServer/Services85">
 <SOAP-ENV:Body>
  <Archive:SetChosenColumnsResponse>
  </Archive:SetChosenColumnsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

