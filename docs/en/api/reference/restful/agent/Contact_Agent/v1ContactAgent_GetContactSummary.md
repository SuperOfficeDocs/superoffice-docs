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
  "ContactId": 692,
  "Limit": 522
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
      "TicketId": 264,
      "TicketStatus": 60,
      "Title": "earum",
      "Registered": "2020-05-10T03:31:25.9478205+02:00",
      "IconHint": "voluptatem"
    },
    {
      "TicketId": 264,
      "TicketStatus": 60,
      "Title": "earum",
      "Registered": "2020-05-10T03:31:25.9478205+02:00",
      "IconHint": "voluptatem"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 498,
      "DocumentId": 613,
      "Date": "2003-01-31T03:31:25.9478205+01:00",
      "Description": "Optional contextually-based data-warehouse",
      "Completed": "Completed",
      "Registered": "2018-11-15T03:31:25.9478205+01:00"
    },
    {
      "AppointmentId": 498,
      "DocumentId": 613,
      "Date": "2003-01-31T03:31:25.9478205+01:00",
      "Description": "Optional contextually-based data-warehouse",
      "Completed": "Completed",
      "Registered": "2018-11-15T03:31:25.9478205+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 194,
      "DocumentId": 517,
      "Date": "2018-11-23T03:31:25.9478205+01:00",
      "Description": "Networked disintermediate core",
      "Completed": "Completed",
      "Registered": "2014-11-30T03:31:25.9478205+01:00"
    },
    {
      "AppointmentId": 194,
      "DocumentId": 517,
      "Date": "2018-11-23T03:31:25.9478205+01:00",
      "Description": "Networked disintermediate core",
      "Completed": "Completed",
      "Registered": "2014-11-30T03:31:25.9478205+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 328,
      "SaleDate": "2011-09-16T03:31:25.9478205+02:00",
      "Probability": 912,
      "Heading": "pariatur",
      "Amount": 12003.22,
      "Currency": "doloribus",
      "AmountInBaseCurrency": 3256.226,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1998-05-23T03:31:25.9478205+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 149,
      "Name": "Olson-Fay",
      "CompanyName": "Boyer-Franecki",
      "FirstMessage": "odit",
      "LastMessage": "explicabo",
      "WhenRequested": "2003-08-24T03:31:25.9478205+02:00",
      "WhenEnded": "2007-04-09T03:31:25.9478205+02:00"
    }
  ]
}
```