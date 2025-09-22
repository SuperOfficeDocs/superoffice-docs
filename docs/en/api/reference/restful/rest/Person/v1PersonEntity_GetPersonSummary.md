---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
generated: true
content_type: reference
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
GET /api/v1/Person/{personId}/Summary?limit=149
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
      "TicketId": 558,
      "TicketStatus": 303,
      "Title": "modi",
      "Registered": "1999-09-23T11:24:53.4218153+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 558,
      "TicketStatus": 303,
      "Title": "modi",
      "Registered": "1999-09-23T11:24:53.4218153+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 714,
      "DocumentId": 138,
      "Date": "2011-06-16T11:24:53.4218153+02:00",
      "Description": "Fully-configurable full-range capacity",
      "Completed": "Completed",
      "Registered": "2007-03-19T11:24:53.4218153+01:00"
    },
    {
      "AppointmentId": 714,
      "DocumentId": 138,
      "Date": "2011-06-16T11:24:53.4218153+02:00",
      "Description": "Fully-configurable full-range capacity",
      "Completed": "Completed",
      "Registered": "2007-03-19T11:24:53.4218153+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 284,
      "DocumentId": 83,
      "Date": "2012-04-14T11:24:53.4218153+02:00",
      "Description": "Up-sized user-facing service-desk",
      "Completed": "Completed",
      "Registered": "2015-11-06T11:24:53.4218153+01:00"
    },
    {
      "AppointmentId": 284,
      "DocumentId": 83,
      "Date": "2012-04-14T11:24:53.4218153+02:00",
      "Description": "Up-sized user-facing service-desk",
      "Completed": "Completed",
      "Registered": "2015-11-06T11:24:53.4218153+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 782,
      "SaleDate": "2020-10-18T11:24:53.4218153+02:00",
      "Probability": 811,
      "Heading": "corporis",
      "Amount": 27685.755999999998,
      "Currency": "voluptates",
      "AmountInBaseCurrency": 16039.812,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1999-03-20T11:24:53.4218153+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 735,
      "Name": "Goyette, Farrell and Herman",
      "CompanyName": "Wunsch, Schroeder and Murphy",
      "FirstMessage": "placeat",
      "LastMessage": "ullam",
      "WhenRequested": "1999-01-28T11:24:53.4218153+01:00",
      "WhenEnded": "1999-07-22T11:24:53.4218153+02:00"
    }
  ]
}
```