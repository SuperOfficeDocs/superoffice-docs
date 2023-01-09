---
title: GET Person/{id}/Summary
uid: v1PersonEntity_GetPersonSummary
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
GET /api/v1/Person/{personId}/Summary?limit=536
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
      "TicketId": 895,
      "TicketStatus": 420,
      "Title": "voluptatibus",
      "Registered": "1995-08-31T17:37:38.9388599+02:00",
      "IconHint": "vitae"
    },
    {
      "TicketId": 895,
      "TicketStatus": 420,
      "Title": "voluptatibus",
      "Registered": "1995-08-31T17:37:38.9388599+02:00",
      "IconHint": "vitae"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 160,
      "DocumentId": 514,
      "Date": "1995-10-08T17:37:38.9388599+02:00",
      "Description": "Robust multi-tasking time-frame",
      "Completed": "Completed",
      "Registered": "2003-08-15T17:37:38.9388599+02:00"
    },
    {
      "AppointmentId": 160,
      "DocumentId": 514,
      "Date": "1995-10-08T17:37:38.9388599+02:00",
      "Description": "Robust multi-tasking time-frame",
      "Completed": "Completed",
      "Registered": "2003-08-15T17:37:38.9388599+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 518,
      "DocumentId": 3,
      "Date": "2020-04-21T17:37:38.9388599+02:00",
      "Description": "Monitored homogeneous info-mediaries",
      "Completed": "Completed",
      "Registered": "2001-06-03T17:37:38.9388599+02:00"
    },
    {
      "AppointmentId": 518,
      "DocumentId": 3,
      "Date": "2020-04-21T17:37:38.9388599+02:00",
      "Description": "Monitored homogeneous info-mediaries",
      "Completed": "Completed",
      "Registered": "2001-06-03T17:37:38.9388599+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 23,
      "SaleDate": "2001-10-15T17:37:38.9388599+02:00",
      "Probability": 811,
      "Heading": "temporibus",
      "Amount": 12119.178,
      "Currency": "ex",
      "AmountInBaseCurrency": 17832.46,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-04-20T17:37:38.9388599+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 590,
      "Name": "Veum-McLaughlin",
      "CompanyName": "Prohaska-Fritsch",
      "FirstMessage": "illum",
      "LastMessage": "aut",
      "WhenRequested": "2009-11-09T17:37:38.9388599+01:00",
      "WhenEnded": "2006-07-10T17:37:38.9388599+02:00"
    }
  ]
}
```