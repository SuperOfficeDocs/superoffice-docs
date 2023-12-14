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
GET /api/v1/Person/{personId}/Summary?limit=721
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
      "TicketId": 897,
      "TicketStatus": 657,
      "Title": "quia",
      "Registered": "2018-12-01T13:57:18.9371904+01:00",
      "IconHint": "consequatur"
    },
    {
      "TicketId": 897,
      "TicketStatus": 657,
      "Title": "quia",
      "Registered": "2018-12-01T13:57:18.9371904+01:00",
      "IconHint": "consequatur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 24,
      "DocumentId": 182,
      "Date": "2020-08-07T13:57:18.9371904+02:00",
      "Description": "Multi-channelled web-enabled pricing structure",
      "Completed": "Completed",
      "Registered": "2022-04-08T13:57:18.9371904+02:00"
    },
    {
      "AppointmentId": 24,
      "DocumentId": 182,
      "Date": "2020-08-07T13:57:18.9371904+02:00",
      "Description": "Multi-channelled web-enabled pricing structure",
      "Completed": "Completed",
      "Registered": "2022-04-08T13:57:18.9371904+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 571,
      "DocumentId": 548,
      "Date": "1996-11-18T13:57:18.9371904+01:00",
      "Description": "Pre-emptive reciprocal open architecture",
      "Completed": "Completed",
      "Registered": "2004-11-18T13:57:18.9371904+01:00"
    },
    {
      "AppointmentId": 571,
      "DocumentId": 548,
      "Date": "1996-11-18T13:57:18.9371904+01:00",
      "Description": "Pre-emptive reciprocal open architecture",
      "Completed": "Completed",
      "Registered": "2004-11-18T13:57:18.9371904+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 691,
      "SaleDate": "2002-02-13T13:57:18.9371904+01:00",
      "Probability": 668,
      "Heading": "dolor",
      "Amount": 15447.485999999999,
      "Currency": "sunt",
      "AmountInBaseCurrency": 27181.182,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2014-06-21T13:57:18.9371904+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 702,
      "Name": "Windler Inc and Sons",
      "CompanyName": "Schultz, Bahringer and Williamson",
      "FirstMessage": "laudantium",
      "LastMessage": "ut",
      "WhenRequested": "2020-06-13T13:57:18.9371904+02:00",
      "WhenEnded": "2005-10-11T13:57:18.9371904+02:00"
    }
  ]
}
```