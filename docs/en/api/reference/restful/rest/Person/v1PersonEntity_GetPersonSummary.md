---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
---

# GET Person/{id}/Summary

```http
GET /api/v1/Person/{personId}/Summary
```

Get summary of person and recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| personId | int32 | The person id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Person/{personId}/Summary?limit=817
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
GET /api/v1/Person/{personId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 677,
      "TicketStatus": 102,
      "Title": "sapiente",
      "Registered": "2014-09-01T03:51:33.7865602+02:00",
      "IconHint": "quo"
    },
    {
      "TicketId": 677,
      "TicketStatus": 102,
      "Title": "sapiente",
      "Registered": "2014-09-01T03:51:33.7865602+02:00",
      "IconHint": "quo"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 536,
      "DocumentId": 533,
      "Date": "1996-08-03T03:51:33.7865602+02:00",
      "Description": "Open-source multimedia pricing structure",
      "Completed": "Completed",
      "Registered": "2009-09-10T03:51:33.7865602+02:00"
    },
    {
      "AppointmentId": 536,
      "DocumentId": 533,
      "Date": "1996-08-03T03:51:33.7865602+02:00",
      "Description": "Open-source multimedia pricing structure",
      "Completed": "Completed",
      "Registered": "2009-09-10T03:51:33.7865602+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 709,
      "DocumentId": 559,
      "Date": "2016-12-03T03:51:33.7865602+01:00",
      "Description": "Enterprise-wide optimizing hub",
      "Completed": "Completed",
      "Registered": "2021-06-26T03:51:33.7865602+02:00"
    },
    {
      "AppointmentId": 709,
      "DocumentId": 559,
      "Date": "2016-12-03T03:51:33.7865602+01:00",
      "Description": "Enterprise-wide optimizing hub",
      "Completed": "Completed",
      "Registered": "2021-06-26T03:51:33.7865602+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 52,
      "SaleDate": "2005-11-13T03:51:33.7865602+01:00",
      "Probability": 483,
      "Heading": "modi",
      "Amount": 495.17199999999997,
      "Currency": "deleniti",
      "AmountInBaseCurrency": 15099.612,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-12-27T03:51:33.7865602+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 376,
      "Name": "Harris Inc and Sons",
      "CompanyName": "Stanton, Champlin and Kihn",
      "FirstMessage": "quibusdam",
      "LastMessage": "odio",
      "WhenRequested": "1997-05-26T03:51:33.7865602+02:00",
      "WhenEnded": "2020-06-03T03:51:33.7865602+02:00"
    }
  ]
}
```