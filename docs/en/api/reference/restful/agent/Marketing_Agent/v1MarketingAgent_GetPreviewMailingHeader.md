---
title: POST Agents/Marketing/GetPreviewMailingHeader
uid: v1MarketingAgent_GetPreviewMailingHeader
generated: true
---

# POST Agents/Marketing/GetPreviewMailingHeader

```http
POST /api/v1/Agents/Marketing/GetPreviewMailingHeader
```

Get a shipment from its shipment id







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Marketing/GetPreviewMailingHeader?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ShipmentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewMailingHeader

| Property Name | Type |  Description |
|----------------|------|--------------|
| StartDate | date-time | The date and time when to start this shipment |
| Status | string | Sending/stopped/failed etc. |
| ShipmentId | int32 | Primary key |
| ShipmentDescription | string | Describes the shipment |
| FromAddress | string | Email address to put in the From header of the messages |
| Configuration | int32 | This field indicates what kind of shipment this is. |
| PersonId | int32 | Primary key |
| PersonFullName | string | Get the persons full name (internal name used in clients for employees). |
| ShipmentType | string | The list item |
| MessageId | int32 | Primary key |
| MessageSubject | string | The mail subject field of the message |
| DocumentMessageId | int32 | If a document was used as the message this is the document ID. |
| NumSent | int32 | Number of emails sent at the current time. |
| NumOpened | int32 | Number of recipients that opened the email. |
| NumBounced | int32 | Number of recipients that resulted in a bounce. |
| NumClicks | int32 | Number of recipients that clicked at least 1 link in the mailing. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Marketing/GetPreviewMailingHeader
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ShipmentId": 202
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2009-05-26T03:45:23.6391999+02:00",
  "Status": "AwaitPopulate",
  "ShipmentId": 144,
  "ShipmentDescription": "Ameliorated object-oriented synergy",
  "FromAddress": "et",
  "Configuration": 817,
  "PersonId": 490,
  "PersonFullName": "Friedrich Renner",
  "ShipmentType": "cumque",
  "MessageId": 712,
  "MessageSubject": "deleniti",
  "DocumentMessageId": 783,
  "NumSent": 937,
  "NumOpened": 817,
  "NumBounced": 739,
  "NumClicks": 366,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 117
    }
  }
}
```