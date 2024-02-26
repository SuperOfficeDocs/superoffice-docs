---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
---

# POST Agents/Person/GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer |  |
| Limit | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person | Person | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 294,
  "Limit": 350
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": null,
  "Tickets": [
    {
      "TicketId": 374,
      "TicketStatus": 795,
      "Title": "est",
      "Registered": "2023-06-19T10:30:24.2600237+02:00",
      "IconHint": "explicabo"
    },
    {
      "TicketId": 374,
      "TicketStatus": 795,
      "Title": "est",
      "Registered": "2023-06-19T10:30:24.2600237+02:00",
      "IconHint": "explicabo"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 892,
      "DocumentId": 1002,
      "Date": "2011-05-15T10:30:24.2600237+02:00",
      "Description": "Managed web-enabled monitoring",
      "Completed": "Completed",
      "Registered": "2023-06-10T10:30:24.2600237+02:00"
    },
    {
      "AppointmentId": 892,
      "DocumentId": 1002,
      "Date": "2011-05-15T10:30:24.2600237+02:00",
      "Description": "Managed web-enabled monitoring",
      "Completed": "Completed",
      "Registered": "2023-06-10T10:30:24.2600237+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 141,
      "DocumentId": 538,
      "Date": "1999-10-16T10:30:24.2600237+02:00",
      "Description": "Multi-layered fresh-thinking knowledge user",
      "Completed": "Completed",
      "Registered": "2000-10-30T10:30:24.2600237+01:00"
    },
    {
      "AppointmentId": 141,
      "DocumentId": 538,
      "Date": "1999-10-16T10:30:24.2600237+02:00",
      "Description": "Multi-layered fresh-thinking knowledge user",
      "Completed": "Completed",
      "Registered": "2000-10-30T10:30:24.2600237+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 128,
      "SaleDate": "2007-04-07T10:30:24.2600237+02:00",
      "Probability": 923,
      "Heading": "recusandae",
      "Amount": 8355.244,
      "Currency": "voluptates",
      "AmountInBaseCurrency": 13253.686,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2019-11-28T10:30:24.2600237+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 270,
      "Name": "Wintheiser Group",
      "CompanyName": "Ryan-Breitenberg",
      "FirstMessage": "earum",
      "LastMessage": "a",
      "WhenRequested": "2018-01-21T10:30:24.2600237+01:00",
      "WhenEnded": "2009-10-30T10:30:24.2600237+01:00"
    }
  ]
}
```