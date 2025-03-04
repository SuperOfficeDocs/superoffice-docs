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
GET /api/v1/Person/{personId}/Summary?limit=638
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
      "TicketId": 409,
      "TicketStatus": 681,
      "Title": "aspernatur",
      "Registered": "2004-07-10T14:13:49.0087767+02:00",
      "IconHint": "adipisci"
    },
    {
      "TicketId": 409,
      "TicketStatus": 681,
      "Title": "aspernatur",
      "Registered": "2004-07-10T14:13:49.0087767+02:00",
      "IconHint": "adipisci"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 43,
      "DocumentId": 265,
      "Date": "2011-02-12T14:13:49.0087767+01:00",
      "Description": "Multi-tiered reciprocal initiative",
      "Completed": "Completed",
      "Registered": "2011-06-20T14:13:49.0087767+02:00"
    },
    {
      "AppointmentId": 43,
      "DocumentId": 265,
      "Date": "2011-02-12T14:13:49.0087767+01:00",
      "Description": "Multi-tiered reciprocal initiative",
      "Completed": "Completed",
      "Registered": "2011-06-20T14:13:49.0087767+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 594,
      "DocumentId": 617,
      "Date": "1998-07-10T14:13:49.0087767+02:00",
      "Description": "Distributed client-driven matrices",
      "Completed": "Completed",
      "Registered": "2007-11-15T14:13:49.0087767+01:00"
    },
    {
      "AppointmentId": 594,
      "DocumentId": 617,
      "Date": "1998-07-10T14:13:49.0087767+02:00",
      "Description": "Distributed client-driven matrices",
      "Completed": "Completed",
      "Registered": "2007-11-15T14:13:49.0087767+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 988,
      "SaleDate": "2024-04-29T14:13:49.0087767+02:00",
      "Probability": 916,
      "Heading": "accusantium",
      "Amount": 29628.836,
      "Currency": "eos",
      "AmountInBaseCurrency": 30130.275999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2017-04-29T14:13:49.0087767+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 993,
      "Name": "Metz-Gerlach",
      "CompanyName": "Jaskolski LLC",
      "FirstMessage": "impedit",
      "LastMessage": "tempora",
      "WhenRequested": "1997-11-11T14:13:49.0087767+01:00",
      "WhenEnded": "2011-04-11T14:13:49.0087767+02:00"
    }
  ]
}
```