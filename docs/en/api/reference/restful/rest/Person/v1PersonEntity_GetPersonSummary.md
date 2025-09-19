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
GET /api/v1/Person/{personId}/Summary?limit=782
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 762,
      "TicketStatus": 564,
      "Title": "maiores",
      "Registered": "2017-01-23T03:41:58.8242618+01:00",
      "IconHint": "non"
    },
    {
      "TicketId": 762,
      "TicketStatus": 564,
      "Title": "maiores",
      "Registered": "2017-01-23T03:41:58.8242618+01:00",
      "IconHint": "non"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 492,
      "DocumentId": 196,
      "Date": "2004-01-06T03:41:58.8242618+01:00",
      "Description": "Operative background analyzer",
      "Completed": "Completed",
      "Registered": "2015-07-29T03:41:58.8242618+02:00"
    },
    {
      "AppointmentId": 492,
      "DocumentId": 196,
      "Date": "2004-01-06T03:41:58.8242618+01:00",
      "Description": "Operative background analyzer",
      "Completed": "Completed",
      "Registered": "2015-07-29T03:41:58.8242618+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 223,
      "DocumentId": 124,
      "Date": "2022-11-26T03:41:58.8242618+01:00",
      "Description": "Fully-configurable attitude-oriented middleware",
      "Completed": "Completed",
      "Registered": "2012-07-20T03:41:58.8242618+02:00"
    },
    {
      "AppointmentId": 223,
      "DocumentId": 124,
      "Date": "2022-11-26T03:41:58.8242618+01:00",
      "Description": "Fully-configurable attitude-oriented middleware",
      "Completed": "Completed",
      "Registered": "2012-07-20T03:41:58.8242618+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 574,
      "SaleDate": "2016-03-22T03:41:58.8242618+01:00",
      "Probability": 192,
      "Heading": "magnam",
      "Amount": 31330.597999999998,
      "Currency": "odit",
      "AmountInBaseCurrency": 6888.532,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-10-11T03:41:58.8242618+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 134,
      "Name": "Berge-Green",
      "CompanyName": "Deckow-Tromp",
      "FirstMessage": "fugiat",
      "LastMessage": "dignissimos",
      "WhenRequested": "2013-04-04T03:41:58.8242618+02:00",
      "WhenEnded": "2002-11-18T03:41:58.8242618+01:00"
    }
  ]
}
```