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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 913,
  "Limit": 25
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
      "TicketId": 373,
      "TicketStatus": 600,
      "Title": "ut",
      "Registered": "2023-06-25T16:32:38.5396522+02:00",
      "IconHint": "quo"
    },
    {
      "TicketId": 373,
      "TicketStatus": 600,
      "Title": "ut",
      "Registered": "2023-06-25T16:32:38.5396522+02:00",
      "IconHint": "quo"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 7,
      "DocumentId": 618,
      "Date": "1999-04-23T16:32:38.5396522+02:00",
      "Description": "Visionary dedicated approach",
      "Completed": "Completed",
      "Registered": "2011-10-05T16:32:38.5396522+02:00"
    },
    {
      "AppointmentId": 7,
      "DocumentId": 618,
      "Date": "1999-04-23T16:32:38.5396522+02:00",
      "Description": "Visionary dedicated approach",
      "Completed": "Completed",
      "Registered": "2011-10-05T16:32:38.5396522+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 783,
      "DocumentId": 23,
      "Date": "2003-07-30T16:32:38.5396522+02:00",
      "Description": "Face to face incremental leverage",
      "Completed": "Completed",
      "Registered": "2005-05-14T16:32:38.5396522+02:00"
    },
    {
      "AppointmentId": 783,
      "DocumentId": 23,
      "Date": "2003-07-30T16:32:38.5396522+02:00",
      "Description": "Face to face incremental leverage",
      "Completed": "Completed",
      "Registered": "2005-05-14T16:32:38.5396522+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 504,
      "SaleDate": "2000-05-17T16:32:38.5396522+02:00",
      "Probability": 413,
      "Heading": "distinctio",
      "Amount": 30393.532,
      "Currency": "esse",
      "AmountInBaseCurrency": 21768.764,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2001-04-09T16:32:38.5396522+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 679,
      "Name": "Goodwin, Farrell and Leannon",
      "CompanyName": "Krajcik, Larkin and Donnelly",
      "FirstMessage": "ut",
      "LastMessage": "veritatis",
      "WhenRequested": "2019-04-13T16:32:38.5396522+02:00",
      "WhenEnded": "2002-12-31T16:32:38.5396522+01:00"
    }
  ]
}
```