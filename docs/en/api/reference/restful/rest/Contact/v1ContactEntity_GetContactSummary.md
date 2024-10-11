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
GET /api/v1/Contact/{contactId}/Summary?limit=31
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 164,
      "TicketStatus": 893,
      "Title": "vero",
      "Registered": "2003-01-23T03:44:57.1715229+01:00",
      "IconHint": "consequatur"
    },
    {
      "TicketId": 164,
      "TicketStatus": 893,
      "Title": "vero",
      "Registered": "2003-01-23T03:44:57.1715229+01:00",
      "IconHint": "consequatur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 32,
      "DocumentId": 31,
      "Date": "2002-11-13T03:44:57.1715229+01:00",
      "Description": "Switchable explicit collaboration",
      "Completed": "Completed",
      "Registered": "2016-04-16T03:44:57.1715229+02:00"
    },
    {
      "AppointmentId": 32,
      "DocumentId": 31,
      "Date": "2002-11-13T03:44:57.1715229+01:00",
      "Description": "Switchable explicit collaboration",
      "Completed": "Completed",
      "Registered": "2016-04-16T03:44:57.1715229+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 195,
      "DocumentId": 867,
      "Date": "2012-10-16T03:44:57.1715229+02:00",
      "Description": "Optional impactful emulation",
      "Completed": "Completed",
      "Registered": "2007-02-25T03:44:57.1715229+01:00"
    },
    {
      "AppointmentId": 195,
      "DocumentId": 867,
      "Date": "2012-10-16T03:44:57.1715229+02:00",
      "Description": "Optional impactful emulation",
      "Completed": "Completed",
      "Registered": "2007-02-25T03:44:57.1715229+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 877,
      "SaleDate": "2000-09-21T03:44:57.1715229+02:00",
      "Probability": 493,
      "Heading": "eum",
      "Amount": 30343.388,
      "Currency": "ut",
      "AmountInBaseCurrency": 10342.199999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-04-11T03:44:57.1715229+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 280,
      "Name": "Wolff-Ruecker",
      "CompanyName": "Goodwin, Kerluke and Dare",
      "FirstMessage": "sequi",
      "LastMessage": "recusandae",
      "WhenRequested": "2020-03-04T03:44:57.1715229+01:00",
      "WhenEnded": "2010-11-15T03:44:57.1715229+01:00"
    }
  ]
}
```