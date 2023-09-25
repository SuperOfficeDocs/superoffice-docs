---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
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
GET /api/v1/Person/{personId}/Summary?limit=348
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 644,
      "TicketStatus": 646,
      "Title": "quia",
      "Registered": "2008-06-30T03:24:51.6930999+02:00",
      "IconHint": "voluptas"
    },
    {
      "TicketId": 644,
      "TicketStatus": 646,
      "Title": "quia",
      "Registered": "2008-06-30T03:24:51.6930999+02:00",
      "IconHint": "voluptas"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 137,
      "DocumentId": 994,
      "Date": "2000-05-24T03:24:51.6930999+02:00",
      "Description": "Future-proofed optimizing service-desk",
      "Completed": "Completed",
      "Registered": "2018-11-20T03:24:51.6930999+01:00"
    },
    {
      "AppointmentId": 137,
      "DocumentId": 994,
      "Date": "2000-05-24T03:24:51.6930999+02:00",
      "Description": "Future-proofed optimizing service-desk",
      "Completed": "Completed",
      "Registered": "2018-11-20T03:24:51.6930999+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 226,
      "DocumentId": 851,
      "Date": "2012-07-17T03:24:51.6930999+02:00",
      "Description": "Function-based 24/7 core",
      "Completed": "Completed",
      "Registered": "1999-06-16T03:24:51.6930999+02:00"
    },
    {
      "AppointmentId": 226,
      "DocumentId": 851,
      "Date": "2012-07-17T03:24:51.6930999+02:00",
      "Description": "Function-based 24/7 core",
      "Completed": "Completed",
      "Registered": "1999-06-16T03:24:51.6930999+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 188,
      "SaleDate": "2023-03-20T03:24:51.6930999+01:00",
      "Probability": 24,
      "Heading": "quidem",
      "Amount": 18230.478,
      "Currency": "est",
      "AmountInBaseCurrency": 18500.002,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-03-16T03:24:51.6930999+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 821,
      "Name": "Weber-Yost",
      "CompanyName": "Yost Group",
      "FirstMessage": "est",
      "LastMessage": "amet",
      "WhenRequested": "2022-07-21T03:24:51.6930999+02:00",
      "WhenEnded": "1999-09-27T03:24:51.6930999+02:00"
    }
  ]
}
```