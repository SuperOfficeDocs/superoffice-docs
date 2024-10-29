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
GET /api/v1/Person/{personId}/Summary?limit=160
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
      "TicketId": 193,
      "TicketStatus": 447,
      "Title": "velit",
      "Registered": "2023-01-05T13:14:10.8985434+01:00",
      "IconHint": "perferendis"
    },
    {
      "TicketId": 193,
      "TicketStatus": 447,
      "Title": "velit",
      "Registered": "2023-01-05T13:14:10.8985434+01:00",
      "IconHint": "perferendis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 58,
      "DocumentId": 225,
      "Date": "2020-05-18T13:14:10.8985434+02:00",
      "Description": "Polarised 24/7 database",
      "Completed": "Completed",
      "Registered": "2022-11-15T13:14:10.8985434+01:00"
    },
    {
      "AppointmentId": 58,
      "DocumentId": 225,
      "Date": "2020-05-18T13:14:10.8985434+02:00",
      "Description": "Polarised 24/7 database",
      "Completed": "Completed",
      "Registered": "2022-11-15T13:14:10.8985434+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 182,
      "DocumentId": 541,
      "Date": "2002-12-23T13:14:10.8985434+01:00",
      "Description": "Proactive upward-trending policy",
      "Completed": "Completed",
      "Registered": "2017-09-25T13:14:10.8985434+02:00"
    },
    {
      "AppointmentId": 182,
      "DocumentId": 541,
      "Date": "2002-12-23T13:14:10.8985434+01:00",
      "Description": "Proactive upward-trending policy",
      "Completed": "Completed",
      "Registered": "2017-09-25T13:14:10.8985434+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 447,
      "SaleDate": "2018-10-06T13:14:10.8985434+02:00",
      "Probability": 806,
      "Heading": "earum",
      "Amount": 18199.138,
      "Currency": "aliquid",
      "AmountInBaseCurrency": 21527.446,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-02-27T13:14:10.8985434+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 796,
      "Name": "Brown-Keebler",
      "CompanyName": "Champlin, Kris and Lesch",
      "FirstMessage": "dolore",
      "LastMessage": "blanditiis",
      "WhenRequested": "2007-10-25T13:14:10.8985434+02:00",
      "WhenEnded": "2009-12-18T13:14:10.8985434+01:00"
    }
  ]
}
```