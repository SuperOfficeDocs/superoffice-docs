---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 516,
  "Limit": 619
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
      "TicketId": 121,
      "TicketStatus": 312,
      "Title": "dolore",
      "Registered": "2004-07-19T14:19:03.8582508+02:00",
      "IconHint": "ad"
    },
    {
      "TicketId": 121,
      "TicketStatus": 312,
      "Title": "dolore",
      "Registered": "2004-07-19T14:19:03.8582508+02:00",
      "IconHint": "ad"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 796,
      "DocumentId": 1001,
      "Date": "2004-09-05T14:19:03.8582508+02:00",
      "Description": "Profit-focused reciprocal forecast",
      "Completed": "Completed",
      "Registered": "2008-04-14T14:19:03.8582508+02:00"
    },
    {
      "AppointmentId": 796,
      "DocumentId": 1001,
      "Date": "2004-09-05T14:19:03.8582508+02:00",
      "Description": "Profit-focused reciprocal forecast",
      "Completed": "Completed",
      "Registered": "2008-04-14T14:19:03.8582508+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 790,
      "DocumentId": 85,
      "Date": "1997-06-09T14:19:03.8582508+02:00",
      "Description": "Automated cohesive service-desk",
      "Completed": "Completed",
      "Registered": "2003-04-16T14:19:03.8582508+02:00"
    },
    {
      "AppointmentId": 790,
      "DocumentId": 85,
      "Date": "1997-06-09T14:19:03.8582508+02:00",
      "Description": "Automated cohesive service-desk",
      "Completed": "Completed",
      "Registered": "2003-04-16T14:19:03.8582508+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 986,
      "SaleDate": "2004-05-19T14:19:03.8582508+02:00",
      "Probability": 703,
      "Heading": "rerum",
      "Amount": 1516.856,
      "Currency": "tempora",
      "AmountInBaseCurrency": 24219.552,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-08-21T14:19:03.8582508+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 461,
      "Name": "Collier Inc and Sons",
      "CompanyName": "Watsica-Spencer",
      "FirstMessage": "quos",
      "LastMessage": "in",
      "WhenRequested": "2015-02-07T14:19:03.8582508+01:00",
      "WhenEnded": "2001-06-15T14:19:03.8582508+02:00"
    }
  ]
}
```