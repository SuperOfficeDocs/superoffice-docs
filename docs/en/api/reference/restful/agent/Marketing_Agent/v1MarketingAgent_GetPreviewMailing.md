---
title: POST Agents/Marketing/GetPreviewMailing
uid: v1MarketingAgent_GetPreviewMailing
---

# POST Agents/Marketing/GetPreviewMailing

```http
POST /api/v1/Agents/Marketing/GetPreviewMailing
```

Get a shipment message from its shipment address id







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Marketing/GetPreviewMailing?$select=name,department,category/id
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

ShipmentAddrId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ShipmentAddrId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PreviewMailing

| Property Name | Type |  Description |
|----------------|------|--------------|
| SendingTime | date-time | Estimated or actual sent time (depends on status) |
| Status | string | Status for sending to this particular recipient |
| ShipmentId | int32 | Primary key |
| ShipmentDescription | string | Describes the shipment |
| FromAddress | string | Email address to put in the From header of the messages |
| ContactId | int32 | Owning contact ID |
| ContactName | string | Contact name |
| PersonId | int32 | Primary key |
| PersonFullName | string | Get the persons full name (internal name used in clients for employees). |
| ShipmentType | string | The list item |
| MessageId | int32 | Primary key |
| MessageSubject | string | The mail subject field of the message |
| DocumentMessageId | int32 | If a document was used as the message this is the document ID. |
| Opened | date-time | Date/time the customer read the mailing. |
| LinkClicks | int32 | The number of links clicked in the mailing. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Marketing/GetPreviewMailing
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ShipmentAddrId": 510
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SendingTime": "2022-08-27T14:19:03.7176242+02:00",
  "Status": "Blocked",
  "ShipmentId": 920,
  "ShipmentDescription": "Pre-emptive next generation interface",
  "FromAddress": "ad",
  "ContactId": 591,
  "ContactName": "Borer-Doyle",
  "PersonId": 608,
  "PersonFullName": "Adrianna Rohan",
  "ShipmentType": "minus",
  "MessageId": 237,
  "MessageSubject": "ut",
  "DocumentMessageId": 858,
  "Opened": "2000-01-27T14:19:03.7176242+01:00",
  "LinkClicks": 910,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 101
    }
  }
}
```