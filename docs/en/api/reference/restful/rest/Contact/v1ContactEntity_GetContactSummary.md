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
GET /api/v1/Contact/{contactId}/Summary?limit=812
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
      "TicketId": 826,
      "TicketStatus": 182,
      "Title": "illo",
      "Registered": "2016-02-14T16:55:29.4958341+01:00",
      "IconHint": "natus"
    },
    {
      "TicketId": 826,
      "TicketStatus": 182,
      "Title": "illo",
      "Registered": "2016-02-14T16:55:29.4958341+01:00",
      "IconHint": "natus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 352,
      "DocumentId": 163,
      "Date": "2009-12-05T16:55:29.4958341+01:00",
      "Description": "Proactive local Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2021-12-28T16:55:29.4958341+01:00"
    },
    {
      "AppointmentId": 352,
      "DocumentId": 163,
      "Date": "2009-12-05T16:55:29.4958341+01:00",
      "Description": "Proactive local Graphical User Interface",
      "Completed": "Completed",
      "Registered": "2021-12-28T16:55:29.4958341+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 96,
      "DocumentId": 683,
      "Date": "2016-11-29T16:55:29.4958341+01:00",
      "Description": "Programmable context-sensitive knowledge user",
      "Completed": "Completed",
      "Registered": "2009-11-30T16:55:29.4958341+01:00"
    },
    {
      "AppointmentId": 96,
      "DocumentId": 683,
      "Date": "2016-11-29T16:55:29.4958341+01:00",
      "Description": "Programmable context-sensitive knowledge user",
      "Completed": "Completed",
      "Registered": "2009-11-30T16:55:29.4958341+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 385,
      "SaleDate": "2004-08-14T16:55:29.4958341+02:00",
      "Probability": 343,
      "Heading": "qui",
      "Amount": 21806.372,
      "Currency": "ullam",
      "AmountInBaseCurrency": 1576.402,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-11-25T16:55:29.4958341+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 568,
      "Name": "Homenick, Larkin and Fay",
      "CompanyName": "Kshlerin Group",
      "FirstMessage": "delectus",
      "LastMessage": "numquam",
      "WhenRequested": "2017-11-26T16:55:29.4958341+01:00",
      "WhenEnded": "2000-01-03T16:55:29.4958341+01:00"
    }
  ]
}
```