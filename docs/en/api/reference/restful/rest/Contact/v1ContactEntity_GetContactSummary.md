---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
generated: true
---

# GET Contact/{id}/Summary

```http
GET /api/v1/Contact/{contactId}/Summary
```

Get summary of contact and its recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | The contact id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Contact/{contactId}/Summary?limit=779
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

### Response body: ContactSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact | Contact | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample request

```http!
GET /api/v1/Contact/{contactId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 121,
      "TicketStatus": 722,
      "Title": "iste",
      "Registered": "2019-07-27T13:14:08.5866221+02:00",
      "IconHint": "explicabo"
    },
    {
      "TicketId": 121,
      "TicketStatus": 722,
      "Title": "iste",
      "Registered": "2019-07-27T13:14:08.5866221+02:00",
      "IconHint": "explicabo"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 872,
      "DocumentId": 71,
      "Date": "2000-07-03T13:14:08.5866221+02:00",
      "Description": "Digitized real-time matrices",
      "Completed": "Completed",
      "Registered": "2017-04-11T13:14:08.5866221+02:00"
    },
    {
      "AppointmentId": 872,
      "DocumentId": 71,
      "Date": "2000-07-03T13:14:08.5866221+02:00",
      "Description": "Digitized real-time matrices",
      "Completed": "Completed",
      "Registered": "2017-04-11T13:14:08.5866221+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 392,
      "DocumentId": 334,
      "Date": "2015-05-03T13:14:08.5866221+02:00",
      "Description": "Upgradable human-resource secured line",
      "Completed": "Completed",
      "Registered": "2013-07-14T13:14:08.5866221+02:00"
    },
    {
      "AppointmentId": 392,
      "DocumentId": 334,
      "Date": "2015-05-03T13:14:08.5866221+02:00",
      "Description": "Upgradable human-resource secured line",
      "Completed": "Completed",
      "Registered": "2013-07-14T13:14:08.5866221+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 875,
      "SaleDate": "2021-01-10T13:14:08.5866221+01:00",
      "Probability": 519,
      "Heading": "voluptas",
      "Amount": 24605.034,
      "Currency": "rerum",
      "AmountInBaseCurrency": 12394.97,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-01-06T13:14:08.5866221+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 653,
      "Name": "O'Keefe-Schneider",
      "CompanyName": "Green-Upton",
      "FirstMessage": "est",
      "LastMessage": "neque",
      "WhenRequested": "2023-02-24T13:14:08.5866221+01:00",
      "WhenEnded": "2012-09-09T13:14:08.5866221+02:00"
    }
  ]
}
```