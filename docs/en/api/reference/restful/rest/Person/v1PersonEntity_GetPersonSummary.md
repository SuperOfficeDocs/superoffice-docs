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
GET /api/v1/Person/{personId}/Summary?limit=115
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
      "TicketId": 993,
      "TicketStatus": 497,
      "Title": "tempore",
      "Registered": "2000-03-05T23:04:04.3600152+01:00",
      "IconHint": "error"
    },
    {
      "TicketId": 993,
      "TicketStatus": 497,
      "Title": "tempore",
      "Registered": "2000-03-05T23:04:04.3600152+01:00",
      "IconHint": "error"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 302,
      "DocumentId": 281,
      "Date": "2004-03-22T23:04:04.3600152+01:00",
      "Description": "Profit-focused coherent forecast",
      "Completed": "Completed",
      "Registered": "2019-09-13T23:04:04.3600152+02:00"
    },
    {
      "AppointmentId": 302,
      "DocumentId": 281,
      "Date": "2004-03-22T23:04:04.3600152+01:00",
      "Description": "Profit-focused coherent forecast",
      "Completed": "Completed",
      "Registered": "2019-09-13T23:04:04.3600152+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 203,
      "DocumentId": 135,
      "Date": "2021-06-08T23:04:04.3600152+02:00",
      "Description": "Right-sized content-based portal",
      "Completed": "Completed",
      "Registered": "1997-10-31T23:04:04.3605163+01:00"
    },
    {
      "AppointmentId": 203,
      "DocumentId": 135,
      "Date": "2021-06-08T23:04:04.3600152+02:00",
      "Description": "Right-sized content-based portal",
      "Completed": "Completed",
      "Registered": "1997-10-31T23:04:04.3605163+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 490,
      "SaleDate": "2009-03-06T23:04:04.3605163+01:00",
      "Probability": 853,
      "Heading": "molestiae",
      "Amount": 15431.815999999999,
      "Currency": "reprehenderit",
      "AmountInBaseCurrency": 3146.536,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-12-27T23:04:04.3605163+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 751,
      "Name": "Boehm Inc and Sons",
      "CompanyName": "Cole Inc and Sons",
      "FirstMessage": "et",
      "LastMessage": "dolores",
      "WhenRequested": "2014-12-19T23:04:04.3605163+01:00",
      "WhenEnded": "2001-12-21T23:04:04.3605163+01:00"
    }
  ]
}
```