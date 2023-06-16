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
GET /api/v1/Person/{personId}/Summary?limit=137
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
      "TicketId": 544,
      "TicketStatus": 147,
      "Title": "ut",
      "Registered": "2001-10-13T16:00:48.0865608+02:00",
      "IconHint": "quia"
    },
    {
      "TicketId": 544,
      "TicketStatus": 147,
      "Title": "ut",
      "Registered": "2001-10-13T16:00:48.0865608+02:00",
      "IconHint": "quia"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 367,
      "DocumentId": 819,
      "Date": "2018-04-01T16:00:48.0865608+02:00",
      "Description": "Synchronised exuding process improvement",
      "Completed": "Completed",
      "Registered": "2006-10-26T16:00:48.0865608+02:00"
    },
    {
      "AppointmentId": 367,
      "DocumentId": 819,
      "Date": "2018-04-01T16:00:48.0865608+02:00",
      "Description": "Synchronised exuding process improvement",
      "Completed": "Completed",
      "Registered": "2006-10-26T16:00:48.0865608+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 33,
      "DocumentId": 379,
      "Date": "2002-09-18T16:00:48.0865608+02:00",
      "Description": "Cross-group directional framework",
      "Completed": "Completed",
      "Registered": "2003-03-19T16:00:48.0865608+01:00"
    },
    {
      "AppointmentId": 33,
      "DocumentId": 379,
      "Date": "2002-09-18T16:00:48.0865608+02:00",
      "Description": "Cross-group directional framework",
      "Completed": "Completed",
      "Registered": "2003-03-19T16:00:48.0865608+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 33,
      "SaleDate": "2010-04-14T16:00:48.0865608+02:00",
      "Probability": 74,
      "Heading": "autem",
      "Amount": 1639.0819999999999,
      "Currency": "similique",
      "AmountInBaseCurrency": 28901.748,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2023-05-29T16:00:48.0865608+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 889,
      "Name": "Langosh, Kshlerin and Lehner",
      "CompanyName": "Predovic-Nicolas",
      "FirstMessage": "enim",
      "LastMessage": "nesciunt",
      "WhenRequested": "2017-08-04T16:00:48.0865608+02:00",
      "WhenEnded": "2008-10-05T16:00:48.0865608+02:00"
    }
  ]
}
```