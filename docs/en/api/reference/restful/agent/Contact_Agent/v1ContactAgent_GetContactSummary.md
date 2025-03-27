---
title: POST Agents/Contact/GetContactSummary
uid: v1ContactAgent_GetContactSummary
generated: true
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
| Limit | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 704,
  "Limit": 793
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": null,
  "Tickets": [
    {
      "TicketId": 215,
      "TicketStatus": 486,
      "Title": "voluptas",
      "Registered": "2011-04-01T02:38:21.1514374+02:00",
      "IconHint": "qui"
    },
    {
      "TicketId": 215,
      "TicketStatus": 486,
      "Title": "voluptas",
      "Registered": "2011-04-01T02:38:21.1514374+02:00",
      "IconHint": "qui"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 30,
      "DocumentId": 637,
      "Date": "2010-11-14T02:38:21.1514374+01:00",
      "Description": "Digitized clear-thinking local area network",
      "Completed": "Completed",
      "Registered": "2022-03-13T02:38:21.1514374+01:00"
    },
    {
      "AppointmentId": 30,
      "DocumentId": 637,
      "Date": "2010-11-14T02:38:21.1514374+01:00",
      "Description": "Digitized clear-thinking local area network",
      "Completed": "Completed",
      "Registered": "2022-03-13T02:38:21.1514374+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 274,
      "DocumentId": 808,
      "Date": "2018-10-10T02:38:21.1514374+02:00",
      "Description": "Future-proofed disintermediate open architecture",
      "Completed": "Completed",
      "Registered": "2002-03-23T02:38:21.1514374+01:00"
    },
    {
      "AppointmentId": 274,
      "DocumentId": 808,
      "Date": "2018-10-10T02:38:21.1514374+02:00",
      "Description": "Future-proofed disintermediate open architecture",
      "Completed": "Completed",
      "Registered": "2002-03-23T02:38:21.1514374+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 954,
      "SaleDate": "2014-11-10T02:38:21.1514374+01:00",
      "Probability": 658,
      "Heading": "illo",
      "Amount": 9430.206,
      "Currency": "omnis",
      "AmountInBaseCurrency": 7844.402,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2011-03-23T02:38:21.1514374+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 178,
      "Name": "Fisher LLC",
      "CompanyName": "Crona-Kunde",
      "FirstMessage": "suscipit",
      "LastMessage": "cumque",
      "WhenRequested": "2012-03-11T02:38:21.1514374+01:00",
      "WhenEnded": "1997-12-10T02:38:21.1514374+01:00"
    }
  ]
}
```