---
title: Services88.ReportAgent.SaveReportLabelLayoutEntity SOAP
generated: true
uid: Services88-Report-SaveReportLabelLayoutEntity
---

# Services88 Report SaveReportLabelLayoutEntity

SOAP request and response examples **Remote/Services88/Report.svc**
Implemented by the <see cref="M:SuperOffice.Services88.IReportAgent.SaveReportLabelLayoutEntity">SuperOffice.Services88.IReportAgent.SaveReportLabelLayoutEntity</see> method.

## SaveReportLabelLayoutEntity





[WSDL file for Services88/Report](../Services88-Report.md)

Obtain a ticket from the [Services88/SoPrincipal.svc](../SoPrincipal/index.md)

Application tokens must be specified if calling an Online installation. ApplicationTokens are not checked for on-site installations.

## SaveReportLabelLayoutEntity Request

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services88">
  <Report:ApplicationToken>1234567-1234-9876</Report:ApplicationToken>
  <Report:Credentials>
    <Report:Ticket>7T:1234abcxyzExample==</Report:Ticket>
  </Report:Credentials>
 <SOAP-ENV:Body>
   <Report:SaveReportLabelLayoutEntity>
    <Report:ReportLabelLayoutEntity xsi:type="Report:ReportLabelLayoutEntity">
     <Report:ReportLabelLayoutId xsi:type="xsd:int">0</Report:ReportLabelLayoutId>
     <Report:Name xsi:type="xsd:string"></Report:Name>
     <Report:Description xsi:type="xsd:string"></Report:Description>
     <Report:Orientation xsi:type="Report:ReportPaperOrientation">None</Report:Orientation>
     <Report:PaperWidth xsi:type="xsd:unsignedInt">0</Report:PaperWidth>
     <Report:PaperHeight xsi:type="xsd:unsignedInt">0</Report:PaperHeight>
     <Report:LeftMargin xsi:type="xsd:unsignedInt">0</Report:LeftMargin>
     <Report:RightMargin xsi:type="xsd:unsignedInt">0</Report:RightMargin>
     <Report:TopMargin xsi:type="xsd:unsignedInt">0</Report:TopMargin>
     <Report:BottomMargin xsi:type="xsd:unsignedInt">0</Report:BottomMargin>
     <Report:CountColumns xsi:type="xsd:short">0</Report:CountColumns>
     <Report:CountRows xsi:type="xsd:short">0</Report:CountRows>
    </Report:ReportLabelLayoutEntity>
   </Report:SaveReportLabelLayoutEntity>

 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```


## SaveReportLabelLayoutEntity Response

```xml
<?xml version="1.0" encoding="UTF-8"?>
<SOAP-ENV:Envelope
 xmlns:SOAP-ENV="http://www.w3.org/2003/05/soap-envelope"
 xmlns:SOAP-ENC="http://www.w3.org/2003/05/soap-encoding"
 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
 xmlns:xsd="http://www.w3.org/2001/XMLSchema"
 xmlns:NetServerServices881="http://schemas.microsoft.com/2003/10/Serialization/"
 xmlns:Report="http://www.superoffice.net/ws/crm/NetServer/Services88">
 <SOAP-ENV:Body>
  <Report:SaveReportLabelLayoutEntityResponse>
   <Report:Response xsi:type="Report:ReportLabelLayoutEntity">
    <Report:ReportLabelLayoutId xsi:type="xsd:int">0</Report:ReportLabelLayoutId>
    <Report:Name xsi:type="xsd:string"></Report:Name>
    <Report:Description xsi:type="xsd:string"></Report:Description>
    <Report:Orientation xsi:type="Report:ReportPaperOrientation">None</Report:Orientation>
    <Report:PaperWidth xsi:type="xsd:unsignedInt">0</Report:PaperWidth>
    <Report:PaperHeight xsi:type="xsd:unsignedInt">0</Report:PaperHeight>
    <Report:LeftMargin xsi:type="xsd:unsignedInt">0</Report:LeftMargin>
    <Report:RightMargin xsi:type="xsd:unsignedInt">0</Report:RightMargin>
    <Report:TopMargin xsi:type="xsd:unsignedInt">0</Report:TopMargin>
    <Report:BottomMargin xsi:type="xsd:unsignedInt">0</Report:BottomMargin>
    <Report:CountColumns xsi:type="xsd:short">0</Report:CountColumns>
    <Report:CountRows xsi:type="xsd:short">0</Report:CountRows>
   </Report:Response>
  </Report:SaveReportLabelLayoutEntityResponse>
 </SOAP-ENV:Body>
</SOAP-ENV:Envelope>

```

