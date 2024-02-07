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
GET /api/v1/Person/{personId}/Summary?limit=457
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
      "TicketId": 777,
      "TicketStatus": 164,
      "Title": "hic",
      "Registered": "2011-11-14T16:55:29.8965212+01:00",
      "IconHint": "autem"
    },
    {
      "TicketId": 777,
      "TicketStatus": 164,
      "Title": "hic",
      "Registered": "2011-11-14T16:55:29.8965212+01:00",
      "IconHint": "autem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 20,
      "DocumentId": 87,
      "Date": "1997-08-25T16:55:29.8965212+02:00",
      "Description": "Multi-channelled client-server attitude",
      "Completed": "Completed",
      "Registered": "2017-12-15T16:55:29.8965212+01:00"
    },
    {
      "AppointmentId": 20,
      "DocumentId": 87,
      "Date": "1997-08-25T16:55:29.8965212+02:00",
      "Description": "Multi-channelled client-server attitude",
      "Completed": "Completed",
      "Registered": "2017-12-15T16:55:29.8965212+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 949,
      "DocumentId": 788,
      "Date": "2005-07-30T16:55:29.8965212+02:00",
      "Description": "Pre-emptive executive standardization",
      "Completed": "Completed",
      "Registered": "2017-07-11T16:55:29.8965212+02:00"
    },
    {
      "AppointmentId": 949,
      "DocumentId": 788,
      "Date": "2005-07-30T16:55:29.8965212+02:00",
      "Description": "Pre-emptive executive standardization",
      "Completed": "Completed",
      "Registered": "2017-07-11T16:55:29.8965212+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 600,
      "SaleDate": "2015-05-07T16:55:29.8965212+02:00",
      "Probability": 990,
      "Heading": "nihil",
      "Amount": 28904.881999999998,
      "Currency": "ut",
      "AmountInBaseCurrency": 21054.212,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2002-04-09T16:55:29.8965212+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 373,
      "Name": "Schmeler-Zulauf",
      "CompanyName": "Brekke Group",
      "FirstMessage": "ducimus",
      "LastMessage": "aperiam",
      "WhenRequested": "2017-01-19T16:55:29.8965212+01:00",
      "WhenEnded": "2002-11-22T16:55:29.8965212+01:00"
    }
  ]
}
```