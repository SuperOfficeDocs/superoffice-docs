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
  "ContactId": 888,
  "Limit": 847
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
      "TicketId": 89,
      "TicketStatus": 187,
      "Title": "labore",
      "Registered": "2004-03-12T16:54:55.0407662+01:00",
      "IconHint": "aspernatur"
    },
    {
      "TicketId": 89,
      "TicketStatus": 187,
      "Title": "labore",
      "Registered": "2004-03-12T16:54:55.0407662+01:00",
      "IconHint": "aspernatur"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 480,
      "DocumentId": 402,
      "Date": "2009-07-13T16:54:55.0407662+02:00",
      "Description": "De-engineered responsive ability",
      "Completed": "Completed",
      "Registered": "2014-02-18T16:54:55.0407662+01:00"
    },
    {
      "AppointmentId": 480,
      "DocumentId": 402,
      "Date": "2009-07-13T16:54:55.0407662+02:00",
      "Description": "De-engineered responsive ability",
      "Completed": "Completed",
      "Registered": "2014-02-18T16:54:55.0407662+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 523,
      "DocumentId": 506,
      "Date": "2007-11-19T16:54:55.0407662+01:00",
      "Description": "Optional coherent attitude",
      "Completed": "Completed",
      "Registered": "2018-07-29T16:54:55.0407662+02:00"
    },
    {
      "AppointmentId": 523,
      "DocumentId": 506,
      "Date": "2007-11-19T16:54:55.0407662+01:00",
      "Description": "Optional coherent attitude",
      "Completed": "Completed",
      "Registered": "2018-07-29T16:54:55.0407662+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 364,
      "SaleDate": "1997-11-02T16:54:55.0407662+01:00",
      "Probability": 1000,
      "Heading": "enim",
      "Amount": 17979.757999999998,
      "Currency": "hic",
      "AmountInBaseCurrency": 16497.376,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2013-01-29T16:54:55.0407662+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 295,
      "Name": "Schoen-Hettinger",
      "CompanyName": "Schmidt Group",
      "FirstMessage": "maiores",
      "LastMessage": "impedit",
      "WhenRequested": "2015-04-09T16:54:55.0407662+02:00",
      "WhenEnded": "1997-12-03T16:54:55.0407662+01:00"
    }
  ]
}
```