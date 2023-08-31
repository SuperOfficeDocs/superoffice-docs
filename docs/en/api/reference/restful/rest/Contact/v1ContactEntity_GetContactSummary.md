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
GET /api/v1/Contact/{contactId}/Summary?limit=267
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
      "TicketId": 603,
      "TicketStatus": 657,
      "Title": "aliquid",
      "Registered": "2013-02-27T03:31:32.4726896+01:00",
      "IconHint": "aut"
    },
    {
      "TicketId": 603,
      "TicketStatus": 657,
      "Title": "aliquid",
      "Registered": "2013-02-27T03:31:32.4726896+01:00",
      "IconHint": "aut"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 352,
      "DocumentId": 413,
      "Date": "2010-05-25T03:31:32.4726896+02:00",
      "Description": "Integrated client-driven conglomeration",
      "Completed": "Completed",
      "Registered": "2002-04-24T03:31:32.4726896+02:00"
    },
    {
      "AppointmentId": 352,
      "DocumentId": 413,
      "Date": "2010-05-25T03:31:32.4726896+02:00",
      "Description": "Integrated client-driven conglomeration",
      "Completed": "Completed",
      "Registered": "2002-04-24T03:31:32.4726896+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 731,
      "DocumentId": 442,
      "Date": "2005-12-17T03:31:32.4726896+01:00",
      "Description": "Object-based intermediate matrix",
      "Completed": "Completed",
      "Registered": "2000-03-21T03:31:32.4726896+01:00"
    },
    {
      "AppointmentId": 731,
      "DocumentId": 442,
      "Date": "2005-12-17T03:31:32.4726896+01:00",
      "Description": "Object-based intermediate matrix",
      "Completed": "Completed",
      "Registered": "2000-03-21T03:31:32.4726896+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 249,
      "SaleDate": "2006-08-16T03:31:32.4726896+02:00",
      "Probability": 119,
      "Heading": "minima",
      "Amount": 15243.776,
      "Currency": "nam",
      "AmountInBaseCurrency": 9082.332,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-02-08T03:31:32.4726896+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 805,
      "Name": "Thompson LLC",
      "CompanyName": "Haag Group",
      "FirstMessage": "et",
      "LastMessage": "debitis",
      "WhenRequested": "2007-07-21T03:31:32.4726896+02:00",
      "WhenEnded": "2011-11-13T03:31:32.4726896+01:00"
    }
  ]
}
```