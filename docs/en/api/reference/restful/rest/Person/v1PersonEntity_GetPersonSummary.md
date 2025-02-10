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
GET /api/v1/Person/{personId}/Summary?limit=881
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
      "TicketId": 585,
      "TicketStatus": 983,
      "Title": "dolor",
      "Registered": "2007-06-18T12:01:32.9800661+02:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 585,
      "TicketStatus": 983,
      "Title": "dolor",
      "Registered": "2007-06-18T12:01:32.9800661+02:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 395,
      "DocumentId": 469,
      "Date": "2010-11-11T12:01:32.9800661+01:00",
      "Description": "Re-engineered responsive open architecture",
      "Completed": "Completed",
      "Registered": "1998-04-09T12:01:32.9800661+02:00"
    },
    {
      "AppointmentId": 395,
      "DocumentId": 469,
      "Date": "2010-11-11T12:01:32.9800661+01:00",
      "Description": "Re-engineered responsive open architecture",
      "Completed": "Completed",
      "Registered": "1998-04-09T12:01:32.9800661+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 422,
      "DocumentId": 358,
      "Date": "2014-02-17T12:01:32.9800661+01:00",
      "Description": "Public-key dedicated orchestration",
      "Completed": "Completed",
      "Registered": "2021-05-02T12:01:32.9800661+02:00"
    },
    {
      "AppointmentId": 422,
      "DocumentId": 358,
      "Date": "2014-02-17T12:01:32.9800661+01:00",
      "Description": "Public-key dedicated orchestration",
      "Completed": "Completed",
      "Registered": "2021-05-02T12:01:32.9800661+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 407,
      "SaleDate": "2003-04-24T12:01:32.9800661+02:00",
      "Probability": 138,
      "Heading": "explicabo",
      "Amount": 16945.538,
      "Currency": "non",
      "AmountInBaseCurrency": 31318.061999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2005-09-01T12:01:32.9800661+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 503,
      "Name": "Barrows, Rodriguez and McDermott",
      "CompanyName": "Ward, Pollich and Lebsack",
      "FirstMessage": "quasi",
      "LastMessage": "soluta",
      "WhenRequested": "2018-06-27T12:01:32.9800661+02:00",
      "WhenEnded": "2023-06-08T12:01:32.9800661+02:00"
    }
  ]
}
```