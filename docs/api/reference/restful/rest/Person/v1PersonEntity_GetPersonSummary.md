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
GET /api/v1/Person/{personId}/Summary?limit=16
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 439,
      "TicketStatus": 646,
      "Title": "et",
      "Registered": "2013-05-03T11:10:53.0311791+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 439,
      "TicketStatus": 646,
      "Title": "et",
      "Registered": "2013-05-03T11:10:53.0311791+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 708,
      "DocumentId": 641,
      "Date": "2021-09-19T11:10:53.0311791+02:00",
      "Description": "Universal client-server methodology",
      "Completed": "Completed",
      "Registered": "2006-05-30T11:10:53.0311791+02:00"
    },
    {
      "AppointmentId": 708,
      "DocumentId": 641,
      "Date": "2021-09-19T11:10:53.0311791+02:00",
      "Description": "Universal client-server methodology",
      "Completed": "Completed",
      "Registered": "2006-05-30T11:10:53.0311791+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 623,
      "DocumentId": 447,
      "Date": "2005-07-24T11:10:53.0311791+02:00",
      "Description": "Streamlined analyzing infrastructure",
      "Completed": "Completed",
      "Registered": "2022-03-25T11:10:53.0311791+01:00"
    },
    {
      "AppointmentId": 623,
      "DocumentId": 447,
      "Date": "2005-07-24T11:10:53.0311791+02:00",
      "Description": "Streamlined analyzing infrastructure",
      "Completed": "Completed",
      "Registered": "2022-03-25T11:10:53.0311791+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 203,
      "SaleDate": "2000-12-27T11:10:53.0311791+01:00",
      "Probability": 712,
      "Heading": "iure",
      "Amount": 28190.329999999998,
      "Currency": "illo",
      "AmountInBaseCurrency": 24166.273999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2009-08-28T11:10:53.0321791+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 577,
      "Name": "Kiehn, Roob and Littel",
      "CompanyName": "Weimann Inc and Sons",
      "FirstMessage": "quia",
      "LastMessage": "consequuntur",
      "WhenRequested": "1998-02-05T11:10:53.0321791+01:00",
      "WhenEnded": "2008-04-09T11:10:53.0321791+02:00"
    }
  ]
}
```
