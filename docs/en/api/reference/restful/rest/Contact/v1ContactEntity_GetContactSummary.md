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
GET /api/v1/Contact/{contactId}/Summary?limit=452
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 543,
      "TicketStatus": 728,
      "Title": "exercitationem",
      "Registered": "2017-02-27T14:23:55.0083878+01:00",
      "IconHint": "ut"
    },
    {
      "TicketId": 543,
      "TicketStatus": 728,
      "Title": "exercitationem",
      "Registered": "2017-02-27T14:23:55.0083878+01:00",
      "IconHint": "ut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 596,
      "DocumentId": 337,
      "Date": "2017-09-11T14:23:55.0083878+02:00",
      "Description": "Visionary eco-centric methodology",
      "Completed": "Completed",
      "Registered": "2015-12-12T14:23:55.0083878+01:00"
    },
    {
      "AppointmentId": 596,
      "DocumentId": 337,
      "Date": "2017-09-11T14:23:55.0083878+02:00",
      "Description": "Visionary eco-centric methodology",
      "Completed": "Completed",
      "Registered": "2015-12-12T14:23:55.0083878+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 527,
      "DocumentId": 56,
      "Date": "2023-10-30T14:23:55.0083878+01:00",
      "Description": "Cross-platform holistic project",
      "Completed": "Completed",
      "Registered": "2007-09-16T14:23:55.0083878+02:00"
    },
    {
      "AppointmentId": 527,
      "DocumentId": 56,
      "Date": "2023-10-30T14:23:55.0083878+01:00",
      "Description": "Cross-platform holistic project",
      "Completed": "Completed",
      "Registered": "2007-09-16T14:23:55.0083878+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 340,
      "SaleDate": "2013-07-18T14:23:55.0083878+02:00",
      "Probability": 549,
      "Heading": "eum",
      "Amount": 26372.61,
      "Currency": "officia",
      "AmountInBaseCurrency": 23627.226,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-04-24T14:23:55.0083878+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 582,
      "Name": "Wilderman, Pacocha and Lynch",
      "CompanyName": "Bosco, O'Kon and Bode",
      "FirstMessage": "qui",
      "LastMessage": "non",
      "WhenRequested": "1997-01-22T14:23:55.0083878+01:00",
      "WhenEnded": "2023-04-27T14:23:55.0083878+02:00"
    }
  ]
}
```