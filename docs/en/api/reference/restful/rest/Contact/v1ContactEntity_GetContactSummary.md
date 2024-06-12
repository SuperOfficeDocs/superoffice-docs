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
GET /api/v1/Contact/{contactId}/Summary?limit=575
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
      "TicketId": 92,
      "TicketStatus": 711,
      "Title": "quae",
      "Registered": "2001-07-31T04:22:34.8433753+02:00",
      "IconHint": "ea"
    },
    {
      "TicketId": 92,
      "TicketStatus": 711,
      "Title": "quae",
      "Registered": "2001-07-31T04:22:34.8433753+02:00",
      "IconHint": "ea"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 280,
      "DocumentId": 492,
      "Date": "2024-01-16T04:22:34.8433753+01:00",
      "Description": "Multi-lateral value-added interface",
      "Completed": "Completed",
      "Registered": "2007-10-09T04:22:34.8433753+02:00"
    },
    {
      "AppointmentId": 280,
      "DocumentId": 492,
      "Date": "2024-01-16T04:22:34.8433753+01:00",
      "Description": "Multi-lateral value-added interface",
      "Completed": "Completed",
      "Registered": "2007-10-09T04:22:34.8433753+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 912,
      "DocumentId": 6,
      "Date": "2002-06-08T04:22:34.8433753+02:00",
      "Description": "Diverse secondary instruction set",
      "Completed": "Completed",
      "Registered": "1999-03-14T04:22:34.8433753+01:00"
    },
    {
      "AppointmentId": 912,
      "DocumentId": 6,
      "Date": "2002-06-08T04:22:34.8433753+02:00",
      "Description": "Diverse secondary instruction set",
      "Completed": "Completed",
      "Registered": "1999-03-14T04:22:34.8433753+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 450,
      "SaleDate": "2000-10-02T04:22:34.8433753+02:00",
      "Probability": 342,
      "Heading": "voluptatem",
      "Amount": 10163.562,
      "Currency": "possimus",
      "AmountInBaseCurrency": 26980.606,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2003-11-29T04:22:34.8433753+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 14,
      "Name": "Bergnaum LLC",
      "CompanyName": "Smith Group",
      "FirstMessage": "dolorem",
      "LastMessage": "dolores",
      "WhenRequested": "2012-07-04T04:22:34.8433753+02:00",
      "WhenEnded": "2019-11-29T04:22:34.8433753+01:00"
    }
  ]
}
```