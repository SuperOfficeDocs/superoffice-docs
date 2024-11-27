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
GET /api/v1/Contact/{contactId}/Summary?limit=847
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
      "TicketId": 877,
      "TicketStatus": 726,
      "Title": "voluptatem",
      "Registered": "2023-04-26T14:45:12.6932234+02:00",
      "IconHint": "atque"
    },
    {
      "TicketId": 877,
      "TicketStatus": 726,
      "Title": "voluptatem",
      "Registered": "2023-04-26T14:45:12.6932234+02:00",
      "IconHint": "atque"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 630,
      "DocumentId": 587,
      "Date": "2002-06-05T14:45:12.6932234+02:00",
      "Description": "Synergized static methodology",
      "Completed": "Completed",
      "Registered": "2017-10-27T14:45:12.6932234+02:00"
    },
    {
      "AppointmentId": 630,
      "DocumentId": 587,
      "Date": "2002-06-05T14:45:12.6932234+02:00",
      "Description": "Synergized static methodology",
      "Completed": "Completed",
      "Registered": "2017-10-27T14:45:12.6932234+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 923,
      "DocumentId": 609,
      "Date": "2009-07-09T14:45:12.6932234+02:00",
      "Description": "Universal dynamic forecast",
      "Completed": "Completed",
      "Registered": "2006-03-19T14:45:12.6932234+01:00"
    },
    {
      "AppointmentId": 923,
      "DocumentId": 609,
      "Date": "2009-07-09T14:45:12.6932234+02:00",
      "Description": "Universal dynamic forecast",
      "Completed": "Completed",
      "Registered": "2006-03-19T14:45:12.6932234+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 506,
      "SaleDate": "1998-02-26T14:45:12.6932234+01:00",
      "Probability": 191,
      "Heading": "tenetur",
      "Amount": 7211.334,
      "Currency": "nulla",
      "AmountInBaseCurrency": 24081.656,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2012-05-04T14:45:12.6932234+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 893,
      "Name": "Kiehn-Towne",
      "CompanyName": "Prohaska, Langworth and Mraz",
      "FirstMessage": "cumque",
      "LastMessage": "praesentium",
      "WhenRequested": "1999-11-01T14:45:12.6932234+01:00",
      "WhenEnded": "2014-05-26T14:45:12.6932234+02:00"
    }
  ]
}
```