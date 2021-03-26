---
uid: services87-person-merge
title: Services87.PersonAgent.Merge SOAP
Generated: true
---

# Services87 Person Merge SOAP

SOAP request and response examples **Remote/Services87/Person.svc**
Implemented by the <see cref="M:SuperOffice.Services87.IPersonAgent.Merge">SuperOffice.Services87.IPersonAgent.Merge</see> method.

## Merge

Merge two persons. The destination person will remain. You must specify the date after which activities will be moved along with the person.

* **sourcePersonId:** The identifier for the person which will be merged into the destination person. The source person is deleted/marked retired after the merge.
* **destinationPersonId:** The identifier for the person which will remain after the merge. The target person is updated.
* **moveAfterDate:** Merge activites after this date. Activities before this date are left alone.
* **deleteSource:** If true, the source person will be deleted after the merge. If false, it will have its retired flag set
* **replaceEmptyFieldsOnDestination:** If true, empty fields on destination will be replaced by values from source.



[WSDL file for Services87/Person](../Services87-Person.md)

Obtain a ticket from the [Services87/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## Merge Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
  <Person:ApplicationToken>1234567-1234-9876</Person:ApplicationToken>
  <Person:Credentials>
    <Person:Ticket>7T:1234abcxyzExample==</Person:Ticket>
  </Person:Credentials>
 <SOAP-ENV:Body>
   <Person:Merge>
    <Person:SourcePersonId xsi:type="xsd:int">0</Person:SourcePersonId>
    <Person:DestinationPersonId xsi:type="xsd:int">0</Person:DestinationPersonId>
    <Person:MoveAfterDate xsi:type="xsd:dateTime">2021-03-25T21:36:40Z</Person:MoveAfterDate>
    <Person:DeleteSource xsi:type="xsd:boolean">false</Person:DeleteSource>
    <Person:ReplaceEmptyFieldsOnDestination xsi:type="xsd:boolean">false</Person:ReplaceEmptyFieldsOnDestination>
   </Person:Merge>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## Merge Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices872="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices871="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Person="http://www.superoffice.net/ws/crm/NetServer/Services87">
 <SOAP-ENV:Body>
  <Person:MergeResponse>
  </Person:MergeResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

