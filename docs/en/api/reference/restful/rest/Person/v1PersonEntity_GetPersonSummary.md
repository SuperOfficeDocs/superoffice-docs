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
GET /api/v1/Person/{personId}/Summary?limit=491
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
      "TicketId": 53,
      "TicketStatus": 955,
      "Title": "dolorum",
      "Registered": "2023-05-12T10:30:32.1668022+02:00",
      "IconHint": "velit"
    },
    {
      "TicketId": 53,
      "TicketStatus": 955,
      "Title": "dolorum",
      "Registered": "2023-05-12T10:30:32.1668022+02:00",
      "IconHint": "velit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 166,
      "DocumentId": 406,
      "Date": "2000-09-07T10:30:32.1668022+02:00",
      "Description": "Switchable zero administration middleware",
      "Completed": "Completed",
      "Registered": "2019-07-20T10:30:32.1668022+02:00"
    },
    {
      "AppointmentId": 166,
      "DocumentId": 406,
      "Date": "2000-09-07T10:30:32.1668022+02:00",
      "Description": "Switchable zero administration middleware",
      "Completed": "Completed",
      "Registered": "2019-07-20T10:30:32.1668022+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 998,
      "DocumentId": 586,
      "Date": "2006-09-23T10:30:32.1668022+02:00",
      "Description": "Down-sized systematic hub",
      "Completed": "Completed",
      "Registered": "2008-08-17T10:30:32.1668022+02:00"
    },
    {
      "AppointmentId": 998,
      "DocumentId": 586,
      "Date": "2006-09-23T10:30:32.1668022+02:00",
      "Description": "Down-sized systematic hub",
      "Completed": "Completed",
      "Registered": "2008-08-17T10:30:32.1668022+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 728,
      "SaleDate": "2017-03-02T10:30:32.1668022+01:00",
      "Probability": 442,
      "Heading": "ut",
      "Amount": 20681.266,
      "Currency": "saepe",
      "AmountInBaseCurrency": 15481.96,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-02-09T10:30:32.1668022+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 725,
      "Name": "Hahn-Stehr",
      "CompanyName": "Carroll, Schinner and Kris",
      "FirstMessage": "ut",
      "LastMessage": "suscipit",
      "WhenRequested": "2015-11-20T10:30:32.1668022+01:00",
      "WhenEnded": "2019-01-26T10:30:32.1668022+01:00"
    }
  ]
}
```