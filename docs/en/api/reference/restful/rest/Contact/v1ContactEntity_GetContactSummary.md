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
GET /api/v1/Contact/{contactId}/Summary?limit=592
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
      "TicketId": 140,
      "TicketStatus": 461,
      "Title": "nesciunt",
      "Registered": "2004-02-17T03:51:33.5366222+01:00",
      "IconHint": "maiores"
    },
    {
      "TicketId": 140,
      "TicketStatus": 461,
      "Title": "nesciunt",
      "Registered": "2004-02-17T03:51:33.5366222+01:00",
      "IconHint": "maiores"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 393,
      "DocumentId": 331,
      "Date": "2018-02-28T03:51:33.5366222+01:00",
      "Description": "Pre-emptive user-facing circuit",
      "Completed": "Completed",
      "Registered": "2007-01-02T03:51:33.5366222+01:00"
    },
    {
      "AppointmentId": 393,
      "DocumentId": 331,
      "Date": "2018-02-28T03:51:33.5366222+01:00",
      "Description": "Pre-emptive user-facing circuit",
      "Completed": "Completed",
      "Registered": "2007-01-02T03:51:33.5366222+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 757,
      "DocumentId": 960,
      "Date": "2009-10-02T03:51:33.5366222+02:00",
      "Description": "Optional encompassing support",
      "Completed": "Completed",
      "Registered": "2008-08-02T03:51:33.5366222+02:00"
    },
    {
      "AppointmentId": 757,
      "DocumentId": 960,
      "Date": "2009-10-02T03:51:33.5366222+02:00",
      "Description": "Optional encompassing support",
      "Completed": "Completed",
      "Registered": "2008-08-02T03:51:33.5366222+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 517,
      "SaleDate": "1999-09-30T03:51:33.5366222+02:00",
      "Probability": 140,
      "Heading": "asperiores",
      "Amount": 13162.8,
      "Currency": "qui",
      "AmountInBaseCurrency": 24946.64,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2021-04-29T03:51:33.5366222+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 69,
      "Name": "Kunze Group",
      "CompanyName": "Stanton Inc and Sons",
      "FirstMessage": "qui",
      "LastMessage": "voluptate",
      "WhenRequested": "2019-04-01T03:51:33.5366222+02:00",
      "WhenEnded": "2005-04-23T03:51:33.5366222+02:00"
    }
  ]
}
```