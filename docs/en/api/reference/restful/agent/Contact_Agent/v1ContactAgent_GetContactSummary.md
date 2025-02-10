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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 935,
  "Limit": 703
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
      "TicketId": 365,
      "TicketStatus": 716,
      "Title": "dolorem",
      "Registered": "2001-01-27T12:01:27.5252641+01:00",
      "IconHint": "ducimus"
    },
    {
      "TicketId": 365,
      "TicketStatus": 716,
      "Title": "dolorem",
      "Registered": "2001-01-27T12:01:27.5252641+01:00",
      "IconHint": "ducimus"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 441,
      "DocumentId": 803,
      "Date": "2006-08-29T12:01:27.5252641+02:00",
      "Description": "Public-key neutral data-warehouse",
      "Completed": "Completed",
      "Registered": "2022-10-18T12:01:27.5252641+02:00"
    },
    {
      "AppointmentId": 441,
      "DocumentId": 803,
      "Date": "2006-08-29T12:01:27.5252641+02:00",
      "Description": "Public-key neutral data-warehouse",
      "Completed": "Completed",
      "Registered": "2022-10-18T12:01:27.5252641+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 899,
      "DocumentId": 626,
      "Date": "2012-11-19T12:01:27.5252641+01:00",
      "Description": "Adaptive responsive secured line",
      "Completed": "Completed",
      "Registered": "2010-08-17T12:01:27.5252641+02:00"
    },
    {
      "AppointmentId": 899,
      "DocumentId": 626,
      "Date": "2012-11-19T12:01:27.5252641+01:00",
      "Description": "Adaptive responsive secured line",
      "Completed": "Completed",
      "Registered": "2010-08-17T12:01:27.5252641+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 792,
      "SaleDate": "2017-03-12T12:01:27.5252641+01:00",
      "Probability": 62,
      "Heading": "suscipit",
      "Amount": 2563.612,
      "Currency": "quia",
      "AmountInBaseCurrency": 10909.454,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2011-01-18T12:01:27.5252641+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 142,
      "Name": "Mills-Stamm",
      "CompanyName": "Kohler Inc and Sons",
      "FirstMessage": "voluptatum",
      "LastMessage": "necessitatibus",
      "WhenRequested": "2016-02-23T12:01:27.5252641+01:00",
      "WhenEnded": "2009-08-08T12:01:27.5252641+02:00"
    }
  ]
}
```