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
GET /api/v1/Contact/{contactId}/Summary?limit=172
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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 871,
      "TicketStatus": 519,
      "Title": "est",
      "Registered": "1999-07-08T10:18:00.3324502+02:00",
      "IconHint": "odio"
    },
    {
      "TicketId": 871,
      "TicketStatus": 519,
      "Title": "est",
      "Registered": "1999-07-08T10:18:00.3324502+02:00",
      "IconHint": "odio"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 316,
      "DocumentId": 933,
      "Date": "2024-02-13T10:18:00.3324502+01:00",
      "Description": "Right-sized explicit monitoring",
      "Completed": "Completed",
      "Registered": "2000-05-20T10:18:00.3324502+02:00"
    },
    {
      "AppointmentId": 316,
      "DocumentId": 933,
      "Date": "2024-02-13T10:18:00.3324502+01:00",
      "Description": "Right-sized explicit monitoring",
      "Completed": "Completed",
      "Registered": "2000-05-20T10:18:00.3324502+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 252,
      "DocumentId": 660,
      "Date": "2005-06-12T10:18:00.3324502+02:00",
      "Description": "Face to face 4th generation knowledge base",
      "Completed": "Completed",
      "Registered": "2015-07-12T10:18:00.3324502+02:00"
    },
    {
      "AppointmentId": 252,
      "DocumentId": 660,
      "Date": "2005-06-12T10:18:00.3324502+02:00",
      "Description": "Face to face 4th generation knowledge base",
      "Completed": "Completed",
      "Registered": "2015-07-12T10:18:00.3324502+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 709,
      "SaleDate": "1998-06-07T10:18:00.3324502+02:00",
      "Probability": 454,
      "Heading": "ipsum",
      "Amount": 4951.72,
      "Currency": "est",
      "AmountInBaseCurrency": 6531.2559999999994,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-04-11T10:18:00.3324502+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 778,
      "Name": "Dooley LLC",
      "CompanyName": "Aufderhar Inc and Sons",
      "FirstMessage": "dolores",
      "LastMessage": "minus",
      "WhenRequested": "2019-04-16T10:18:00.3324502+02:00",
      "WhenEnded": "2003-02-01T10:18:00.3324502+01:00"
    }
  ]
}
```