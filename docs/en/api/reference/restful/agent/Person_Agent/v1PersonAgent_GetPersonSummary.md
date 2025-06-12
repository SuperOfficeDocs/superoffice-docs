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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 939,
  "Limit": 412
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
      "TicketId": 638,
      "TicketStatus": 728,
      "Title": "accusamus",
      "Registered": "2024-02-14T17:54:03.4139422+01:00",
      "IconHint": "cum"
    },
    {
      "TicketId": 638,
      "TicketStatus": 728,
      "Title": "accusamus",
      "Registered": "2024-02-14T17:54:03.4139422+01:00",
      "IconHint": "cum"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 841,
      "DocumentId": 248,
      "Date": "2008-11-24T17:54:03.4139422+01:00",
      "Description": "Monitored regional utilisation",
      "Completed": "Completed",
      "Registered": "2004-04-21T17:54:03.4139422+02:00"
    },
    {
      "AppointmentId": 841,
      "DocumentId": 248,
      "Date": "2008-11-24T17:54:03.4139422+01:00",
      "Description": "Monitored regional utilisation",
      "Completed": "Completed",
      "Registered": "2004-04-21T17:54:03.4139422+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 250,
      "DocumentId": 881,
      "Date": "2012-03-20T17:54:03.4139422+01:00",
      "Description": "Universal 5th generation standardization",
      "Completed": "Completed",
      "Registered": "2014-04-11T17:54:03.4139422+02:00"
    },
    {
      "AppointmentId": 250,
      "DocumentId": 881,
      "Date": "2012-03-20T17:54:03.4139422+01:00",
      "Description": "Universal 5th generation standardization",
      "Completed": "Completed",
      "Registered": "2014-04-11T17:54:03.4139422+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 715,
      "SaleDate": "1999-05-08T17:54:03.4139422+02:00",
      "Probability": 648,
      "Heading": "alias",
      "Amount": 12564.206,
      "Currency": "dignissimos",
      "AmountInBaseCurrency": 29099.19,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2007-01-06T17:54:03.4139422+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 84,
      "Name": "Ratke LLC",
      "CompanyName": "Blanda, Wehner and Kuhic",
      "FirstMessage": "amet",
      "LastMessage": "eos",
      "WhenRequested": "2022-01-24T17:54:03.4139422+01:00",
      "WhenEnded": "2001-04-28T17:54:03.4139422+02:00"
    }
  ]
}
```