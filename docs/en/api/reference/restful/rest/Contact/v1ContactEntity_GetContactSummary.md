---
title: GET Contact/{id}/Summary
uid: v1ContactEntity_GetContactSummary
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
      "TicketId": 449,
      "TicketStatus": 866,
      "Title": "ducimus",
      "Registered": "2007-11-05T17:37:38.4428597+01:00",
      "IconHint": "iure"
    },
    {
      "TicketId": 449,
      "TicketStatus": 866,
      "Title": "ducimus",
      "Registered": "2007-11-05T17:37:38.4428597+01:00",
      "IconHint": "iure"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 861,
      "DocumentId": 709,
      "Date": "2019-02-16T17:37:38.4438605+01:00",
      "Description": "Devolved 5th generation encryption",
      "Completed": "Completed",
      "Registered": "2011-03-20T17:37:38.4438605+01:00"
    },
    {
      "AppointmentId": 861,
      "DocumentId": 709,
      "Date": "2019-02-16T17:37:38.4438605+01:00",
      "Description": "Devolved 5th generation encryption",
      "Completed": "Completed",
      "Registered": "2011-03-20T17:37:38.4438605+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 686,
      "DocumentId": 198,
      "Date": "2003-07-03T17:37:38.4438605+02:00",
      "Description": "Optional context-sensitive policy",
      "Completed": "Completed",
      "Registered": "2017-06-13T17:37:38.4438605+02:00"
    },
    {
      "AppointmentId": 686,
      "DocumentId": 198,
      "Date": "2003-07-03T17:37:38.4438605+02:00",
      "Description": "Optional context-sensitive policy",
      "Completed": "Completed",
      "Registered": "2017-06-13T17:37:38.4438605+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 397,
      "SaleDate": "2011-01-20T17:37:38.4438605+01:00",
      "Probability": 264,
      "Heading": "quibusdam",
      "Amount": 15428.681999999999,
      "Currency": "iste",
      "AmountInBaseCurrency": 5932.6619999999994,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2005-03-06T17:37:38.4438605+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 442,
      "Name": "Weimann, Gusikowski and Sawayn",
      "CompanyName": "Mayer-Jenkins",
      "FirstMessage": "voluptatem",
      "LastMessage": "impedit",
      "WhenRequested": "2010-05-24T17:37:38.4438605+02:00",
      "WhenEnded": "2007-04-14T17:37:38.4438605+02:00"
    }
  ]
}
```