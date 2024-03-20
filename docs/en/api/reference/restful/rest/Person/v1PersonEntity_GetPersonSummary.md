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
GET /api/v1/Person/{personId}/Summary?limit=87
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 655,
      "TicketStatus": 689,
      "Title": "quos",
      "Registered": "2020-07-22T12:19:53.6961005+02:00",
      "IconHint": "et"
    },
    {
      "TicketId": 655,
      "TicketStatus": 689,
      "Title": "quos",
      "Registered": "2020-07-22T12:19:53.6961005+02:00",
      "IconHint": "et"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 242,
      "DocumentId": 87,
      "Date": "2022-08-25T12:19:53.6961005+02:00",
      "Description": "Profit-focused object-oriented orchestration",
      "Completed": "Completed",
      "Registered": "2003-05-08T12:19:53.6961005+02:00"
    },
    {
      "AppointmentId": 242,
      "DocumentId": 87,
      "Date": "2022-08-25T12:19:53.6961005+02:00",
      "Description": "Profit-focused object-oriented orchestration",
      "Completed": "Completed",
      "Registered": "2003-05-08T12:19:53.6961005+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 653,
      "DocumentId": 78,
      "Date": "2001-09-22T12:19:53.6961005+02:00",
      "Description": "Phased discrete software",
      "Completed": "Completed",
      "Registered": "2003-06-24T12:19:53.6961005+02:00"
    },
    {
      "AppointmentId": 653,
      "DocumentId": 78,
      "Date": "2001-09-22T12:19:53.6961005+02:00",
      "Description": "Phased discrete software",
      "Completed": "Completed",
      "Registered": "2003-06-24T12:19:53.6961005+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 908,
      "SaleDate": "2010-11-22T12:19:53.6961005+01:00",
      "Probability": 528,
      "Heading": "autem",
      "Amount": 13936.898,
      "Currency": "facilis",
      "AmountInBaseCurrency": 29306.034,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-04-22T12:19:53.6961005+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 909,
      "Name": "Hoppe, Schiller and Barton",
      "CompanyName": "Leannon, Douglas and Mertz",
      "FirstMessage": "vero",
      "LastMessage": "rerum",
      "WhenRequested": "2004-02-14T12:19:53.6961005+01:00",
      "WhenEnded": "2003-10-18T12:19:53.6961005+02:00"
    }
  ]
}
```