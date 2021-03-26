---
uid: services80-freetext-getsuggestedstopwords
title: Services80.FreeTextAgent.GetSuggestedStopWords SOAP
Generated: true
---

# Services80 FreeText GetSuggestedStopWords SOAP

SOAP request and response examples **Remote/Services80/FreeText.svc**
Implemented by the <see cref="M:SuperOffice.Services80.IFreeTextAgent.GetSuggestedStopWords">SuperOffice.Services80.IFreeTextAgent.GetSuggestedStopWords</see> method.

## GetSuggestedStopWords

Returns the top used words in the freetext index table, sorted as most used first

* **countWords:** The count of words that will be returned

**Returns:** The most used words


[WSDL file for Services80/FreeText](../Services80-FreeText.md)

Obtain a ticket from the [Services80/SoPrincipal.svc](../SoPrincipal/SoPrincipal.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## GetSuggestedStopWords Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services80">
  <FreeText:ApplicationToken>1234567-1234-9876</FreeText:ApplicationToken>
  <FreeText:Credentials>
    <FreeText:Ticket>7T:1234abcxyzExample==</FreeText:Ticket>
  </FreeText:Credentials>
 <SOAP-ENV:Body>
   <FreeText:GetSuggestedStopWords>
    <FreeText:CountWords xsi:type="xsd:int">0</FreeText:CountWords>
   </FreeText:GetSuggestedStopWords>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## GetSuggestedStopWords Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices802="http://schemas.microsoft.com/2003/10/Serialization/Arrays"
 xmlns:NetServerServices801="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:FreeText="http://www.superoffice.net/ws/crm/NetServer/Services80">
 <SOAP-ENV:Body>
  <FreeText:GetSuggestedStopWordsResponse>
   <FreeText:Response xsi:type="FreeText:ArrayOfMDOListItem">
    <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
     <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
     <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
     <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
     <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
     <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
     <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
     <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
      <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
       <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
       <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
       <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
       <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
       <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
       <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
       <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
        <FreeText:MDOListItem xsi:type="FreeText:MDOListItem">
         <FreeText:Id xsi:type="xsd:int">0</FreeText:Id>
         <FreeText:Name xsi:type="xsd:string"></FreeText:Name>
         <FreeText:ToolTip xsi:type="xsd:string"></FreeText:ToolTip>
         <FreeText:Deleted xsi:type="xsd:boolean">false</FreeText:Deleted>
         <FreeText:Rank xsi:type="xsd:int">0</FreeText:Rank>
         <FreeText:Type xsi:type="xsd:string"></FreeText:Type>
         <FreeText:ChildItems xsi:type="FreeText:ArrayOfMDOListItem">
          <FreeText:MDOListItem xsi:nil="true"></FreeText:MDOListItem>
         </FreeText:ChildItems>
         <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
         <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
         <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
         <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
        </FreeText:MDOListItem>
       </FreeText:ChildItems>
       <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
       <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
       <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
       <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
      </FreeText:MDOListItem>
     </FreeText:ChildItems>
     <FreeText:IconHint xsi:type="xsd:string"></FreeText:IconHint>
     <FreeText:ColorBlock xsi:type="xsd:int">0</FreeText:ColorBlock>
     <FreeText:ExtraInfo xsi:type="xsd:string"></FreeText:ExtraInfo>
     <FreeText:StyleHint xsi:type="xsd:string"></FreeText:StyleHint>
    </FreeText:MDOListItem>
   </FreeText:Response>
  </FreeText:GetSuggestedStopWordsResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

