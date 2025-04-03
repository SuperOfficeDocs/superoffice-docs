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
GET /api/v1/Contact/{contactId}/Summary?limit=94
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
      "TicketId": 736,
      "TicketStatus": 924,
      "Title": "itaque",
      "Registered": "2007-08-02T14:28:26.8520728+02:00",
      "IconHint": "quam"
    },
    {
      "TicketId": 736,
      "TicketStatus": 924,
      "Title": "itaque",
      "Registered": "2007-08-02T14:28:26.8520728+02:00",
      "IconHint": "quam"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 706,
      "DocumentId": 195,
      "Date": "2003-12-24T14:28:26.8520728+01:00",
      "Description": "Realigned 3rd generation superstructure",
      "Completed": "Completed",
      "Registered": "2018-05-31T14:28:26.8520728+02:00"
    },
    {
      "AppointmentId": 706,
      "DocumentId": 195,
      "Date": "2003-12-24T14:28:26.8520728+01:00",
      "Description": "Realigned 3rd generation superstructure",
      "Completed": "Completed",
      "Registered": "2018-05-31T14:28:26.8520728+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 314,
      "DocumentId": 750,
      "Date": "2007-06-22T14:28:26.8520728+02:00",
      "Description": "Operative tertiary knowledge base",
      "Completed": "Completed",
      "Registered": "2002-01-13T14:28:26.8520728+01:00"
    },
    {
      "AppointmentId": 314,
      "DocumentId": 750,
      "Date": "2007-06-22T14:28:26.8520728+02:00",
      "Description": "Operative tertiary knowledge base",
      "Completed": "Completed",
      "Registered": "2002-01-13T14:28:26.8520728+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 630,
      "SaleDate": "2000-06-18T14:28:26.8520728+02:00",
      "Probability": 407,
      "Heading": "tempora",
      "Amount": 20543.37,
      "Currency": "voluptates",
      "AmountInBaseCurrency": 31333.732,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-07-18T14:28:26.8520728+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 714,
      "Name": "Ratke-Stoltenberg",
      "CompanyName": "Kuhn LLC",
      "FirstMessage": "accusantium",
      "LastMessage": "eligendi",
      "WhenRequested": "2021-10-27T14:28:26.8520728+02:00",
      "WhenEnded": "2010-11-28T14:28:26.8520728+01:00"
    }
  ]
}
```