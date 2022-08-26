---
title: Services88.NumberAllocationAgent.SaveDefaultNumbering SOAP
generated: 1
uid: Services88-NumberAllocation-SaveDefaultNumbering
---

# Services88 NumberAllocation SaveDefaultNumbering

SOAP request and response examples **Remote/Services88/NumberAllocation.svc**
Implemented by the <see cref="M:SuperOffice.Services88.INumberAllocationAgent.SaveDefaultNumbering">SuperOffice.Services88.INumberAllocationAgent.SaveDefaultNumbering</see> method.

## SaveDefaultNumbering

Saves default numbering values in preferences

* **refCountEntity:** The refCountEntity that holds the values that will be saved

**Returns:** void


[WSDL file for Services88/NumberAllocation](../Services88-NumberAllocation.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveDefaultNumbering Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <NumberAllocation:ApplicationToken>1234567-1234-9876</NumberAllocation:ApplicationToken>
  <NumberAllocation:Credentials>
    <NumberAllocation:Ticket>7T:1234abcxyzExample==</NumberAllocation:Ticket>
  </NumberAllocation:Credentials>
 <SOAP-ENV:Body>
   <NumberAllocation:SaveDefaultNumbering>
    <NumberAllocation:RefCountEntity xsi:type="NumberAllocation:RefCountEntity">
     <NumberAllocation:RefCountsId xsi:type="xsd:int">0</NumberAllocation:RefCountsId>
     <NumberAllocation:Field xsi:type="xsd:string"></NumberAllocation:Field>
     <NumberAllocation:RecordId xsi:type="xsd:int">0</NumberAllocation:RecordId>
     <NumberAllocation:SuggestedRecords xsi:type="NumberAllocation:ArrayOfMDOListItem">
      <NumberAllocation:MDOListItem xsi:type="NumberAllocation:MDOListItem">
       <NumberAllocation:Id xsi:type="xsd:int">0</NumberAllocation:Id>
       <NumberAllocation:Name xsi:type="xsd:string"></NumberAllocation:Name>
       <NumberAllocation:ToolTip xsi:type="xsd:string"></NumberAllocation:ToolTip>
       <NumberAllocation:Deleted xsi:type="xsd:boolean">false</NumberAllocation:Deleted>
       <NumberAllocation:Rank xsi:type="xsd:int">0</NumberAllocation:Rank>
       <NumberAllocation:Type xsi:type="xsd:string"></NumberAllocation:Type>
       <NumberAllocation:ChildItems xsi:type="NumberAllocation:ArrayOfMDOListItem">
        <NumberAllocation:MDOListItem xsi:type="NumberAllocation:MDOListItem">
         <NumberAllocation:Id xsi:type="xsd:int">0</NumberAllocation:Id>
         <NumberAllocation:Name xsi:type="xsd:string"></NumberAllocation:Name>
         <NumberAllocation:ToolTip xsi:type="xsd:string"></NumberAllocation:ToolTip>
         <NumberAllocation:Deleted xsi:type="xsd:boolean">false</NumberAllocation:Deleted>
         <NumberAllocation:Rank xsi:type="xsd:int">0</NumberAllocation:Rank>
         <NumberAllocation:Type xsi:type="xsd:string"></NumberAllocation:Type>
         <NumberAllocation:ChildItems xsi:type="NumberAllocation:ArrayOfMDOListItem">
          <NumberAllocation:MDOListItem xsi:nil="true"></NumberAllocation:MDOListItem>
         </NumberAllocation:ChildItems>
         <NumberAllocation:IconHint xsi:type="xsd:string"></NumberAllocation:IconHint>
         <NumberAllocation:ColorBlock xsi:type="xsd:int">0</NumberAllocation:ColorBlock>
         <NumberAllocation:ExtraInfo xsi:type="xsd:string"></NumberAllocation:ExtraInfo>
         <NumberAllocation:StyleHint xsi:type="xsd:string"></NumberAllocation:StyleHint>
         <NumberAllocation:FullName xsi:type="xsd:string"></NumberAllocation:FullName>
        </NumberAllocation:MDOListItem>
       </NumberAllocation:ChildItems>
       <NumberAllocation:IconHint xsi:type="xsd:string"></NumberAllocation:IconHint>
       <NumberAllocation:ColorBlock xsi:type="xsd:int">0</NumberAllocation:ColorBlock>
       <NumberAllocation:ExtraInfo xsi:type="xsd:string"></NumberAllocation:ExtraInfo>
       <NumberAllocation:StyleHint xsi:type="xsd:string"></NumberAllocation:StyleHint>
       <NumberAllocation:FullName xsi:type="xsd:string"></NumberAllocation:FullName>
      </NumberAllocation:MDOListItem>
     </NumberAllocation:SuggestedRecords>
     <NumberAllocation:CurrentValue xsi:type="xsd:int">0</NumberAllocation:CurrentValue>
     <NumberAllocation:TravelPrefix xsi:type="xsd:unsignedInt">0</NumberAllocation:TravelPrefix>
     <NumberAllocation:SatPrefix xsi:type="xsd:unsignedInt">0</NumberAllocation:SatPrefix>
     <NumberAllocation:Allocate xsi:type="xsd:boolean">false</NumberAllocation:Allocate>
     <NumberAllocation:Unique xsi:type="xsd:boolean">false</NumberAllocation:Unique>
     <NumberAllocation:ReadOnly xsi:type="xsd:boolean">false</NumberAllocation:ReadOnly>
     <NumberAllocation:AllowBlank xsi:type="xsd:boolean">false</NumberAllocation:AllowBlank>
    </NumberAllocation:RefCountEntity>
   </NumberAllocation:SaveDefaultNumbering>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveDefaultNumbering Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:NumberAllocation="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <NumberAllocation:SaveDefaultNumberingResponse>
  </NumberAllocation:SaveDefaultNumberingResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

