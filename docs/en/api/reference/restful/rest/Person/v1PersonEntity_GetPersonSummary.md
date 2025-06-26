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
GET /api/v1/Person/{personId}/Summary?limit=401
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
      "TicketId": 57,
      "TicketStatus": 105,
      "Title": "et",
      "Registered": "2020-06-07T03:45:28.4828085+02:00",
      "IconHint": "omnis"
    },
    {
      "TicketId": 57,
      "TicketStatus": 105,
      "Title": "et",
      "Registered": "2020-06-07T03:45:28.4828085+02:00",
      "IconHint": "omnis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 989,
      "DocumentId": 829,
      "Date": "2023-02-24T03:45:28.4828085+01:00",
      "Description": "Sharable hybrid focus group",
      "Completed": "Completed",
      "Registered": "2015-05-11T03:45:28.4828085+02:00"
    },
    {
      "AppointmentId": 989,
      "DocumentId": 829,
      "Date": "2023-02-24T03:45:28.4828085+01:00",
      "Description": "Sharable hybrid focus group",
      "Completed": "Completed",
      "Registered": "2015-05-11T03:45:28.4828085+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 401,
      "DocumentId": 150,
      "Date": "2020-04-19T03:45:28.4828085+02:00",
      "Description": "Open-architected interactive instruction set",
      "Completed": "Completed",
      "Registered": "1999-10-14T03:45:28.4828085+02:00"
    },
    {
      "AppointmentId": 401,
      "DocumentId": 150,
      "Date": "2020-04-19T03:45:28.4828085+02:00",
      "Description": "Open-architected interactive instruction set",
      "Completed": "Completed",
      "Registered": "1999-10-14T03:45:28.4828085+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 54,
      "SaleDate": "2024-10-23T03:45:28.4828085+02:00",
      "Probability": 512,
      "Heading": "repellat",
      "Amount": 11884.127999999999,
      "Currency": "qui",
      "AmountInBaseCurrency": 27532.19,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-03-24T03:45:28.4828085+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 684,
      "Name": "Bahringer LLC",
      "CompanyName": "Cruickshank, Schamberger and Frami",
      "FirstMessage": "aut",
      "LastMessage": "ipsum",
      "WhenRequested": "2024-07-19T03:45:28.4828085+02:00",
      "WhenEnded": "2007-10-06T03:45:28.4828085+02:00"
    }
  ]
}
```