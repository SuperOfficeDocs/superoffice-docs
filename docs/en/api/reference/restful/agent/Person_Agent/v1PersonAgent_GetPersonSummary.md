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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 950,
  "Limit": 171
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
      "TicketId": 385,
      "TicketStatus": 949,
      "Title": "ipsum",
      "Registered": "2018-06-04T14:45:05.9281683+02:00",
      "IconHint": "blanditiis"
    },
    {
      "TicketId": 385,
      "TicketStatus": 949,
      "Title": "ipsum",
      "Registered": "2018-06-04T14:45:05.9281683+02:00",
      "IconHint": "blanditiis"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 423,
      "DocumentId": 812,
      "Date": "2010-04-08T14:45:05.9281683+02:00",
      "Description": "Persistent web-enabled product",
      "Completed": "Completed",
      "Registered": "1999-11-10T14:45:05.9281683+01:00"
    },
    {
      "AppointmentId": 423,
      "DocumentId": 812,
      "Date": "2010-04-08T14:45:05.9281683+02:00",
      "Description": "Persistent web-enabled product",
      "Completed": "Completed",
      "Registered": "1999-11-10T14:45:05.9281683+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 477,
      "DocumentId": 245,
      "Date": "1998-10-08T14:45:05.9281683+02:00",
      "Description": "Face to face content-based toolset",
      "Completed": "Completed",
      "Registered": "2010-03-04T14:45:05.9281683+01:00"
    },
    {
      "AppointmentId": 477,
      "DocumentId": 245,
      "Date": "1998-10-08T14:45:05.9281683+02:00",
      "Description": "Face to face content-based toolset",
      "Completed": "Completed",
      "Registered": "2010-03-04T14:45:05.9281683+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 347,
      "SaleDate": "2007-11-17T14:45:05.9281683+01:00",
      "Probability": 338,
      "Heading": "est",
      "Amount": 5882.518,
      "Currency": "optio",
      "AmountInBaseCurrency": 14801.882,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-12-31T14:45:05.9281683+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 152,
      "Name": "Pacocha Inc and Sons",
      "CompanyName": "O'Reilly, Dickinson and Hauck",
      "FirstMessage": "est",
      "LastMessage": "expedita",
      "WhenRequested": "2020-11-19T14:45:05.9281683+01:00",
      "WhenEnded": "2004-02-23T14:45:05.9281683+01:00"
    }
  ]
}
```