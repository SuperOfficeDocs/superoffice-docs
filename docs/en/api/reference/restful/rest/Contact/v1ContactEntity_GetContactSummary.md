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
GET /api/v1/Contact/{contactId}/Summary?limit=39
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
      "TicketId": 792,
      "TicketStatus": 489,
      "Title": "illum",
      "Registered": "2016-06-23T03:24:51.52124+02:00",
      "IconHint": "sit"
    },
    {
      "TicketId": 792,
      "TicketStatus": 489,
      "Title": "illum",
      "Registered": "2016-06-23T03:24:51.52124+02:00",
      "IconHint": "sit"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 110,
      "DocumentId": 920,
      "Date": "2008-02-26T03:24:51.52124+01:00",
      "Description": "Profit-focused mission-critical array",
      "Completed": "Completed",
      "Registered": "2005-05-18T03:24:51.52124+02:00"
    },
    {
      "AppointmentId": 110,
      "DocumentId": 920,
      "Date": "2008-02-26T03:24:51.52124+01:00",
      "Description": "Profit-focused mission-critical array",
      "Completed": "Completed",
      "Registered": "2005-05-18T03:24:51.52124+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 13,
      "DocumentId": 1000,
      "Date": "2005-09-01T03:24:51.52124+02:00",
      "Description": "Cross-platform didactic knowledge user",
      "Completed": "Completed",
      "Registered": "2002-09-21T03:24:51.52124+02:00"
    },
    {
      "AppointmentId": 13,
      "DocumentId": 1000,
      "Date": "2005-09-01T03:24:51.52124+02:00",
      "Description": "Cross-platform didactic knowledge user",
      "Completed": "Completed",
      "Registered": "2002-09-21T03:24:51.52124+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 62,
      "SaleDate": "2000-04-22T03:24:51.52124+02:00",
      "Probability": 44,
      "Heading": "fugiat",
      "Amount": 24661.446,
      "Currency": "iure",
      "AmountInBaseCurrency": 488.904,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-08-10T03:24:51.52124+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 298,
      "Name": "Orn Inc and Sons",
      "CompanyName": "McCullough-Towne",
      "FirstMessage": "quo",
      "LastMessage": "est",
      "WhenRequested": "1996-05-31T03:24:51.52124+02:00",
      "WhenEnded": "2005-04-04T03:24:51.52124+02:00"
    }
  ]
}
```