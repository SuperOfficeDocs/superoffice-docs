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
  "PersonId": 28,
  "Limit": 82
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
      "TicketId": 978,
      "TicketStatus": 966,
      "Title": "in",
      "Registered": "2011-05-04T12:57:34.5397338+02:00",
      "IconHint": "doloremque"
    },
    {
      "TicketId": 978,
      "TicketStatus": 966,
      "Title": "in",
      "Registered": "2011-05-04T12:57:34.5397338+02:00",
      "IconHint": "doloremque"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 135,
      "DocumentId": 361,
      "Date": "2017-01-18T12:57:34.5397338+01:00",
      "Description": "Organic systematic product",
      "Completed": "Completed",
      "Registered": "2019-01-04T12:57:34.5397338+01:00"
    },
    {
      "AppointmentId": 135,
      "DocumentId": 361,
      "Date": "2017-01-18T12:57:34.5397338+01:00",
      "Description": "Organic systematic product",
      "Completed": "Completed",
      "Registered": "2019-01-04T12:57:34.5397338+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 90,
      "DocumentId": 259,
      "Date": "2019-10-25T12:57:34.5397338+02:00",
      "Description": "Operative regional structure",
      "Completed": "Completed",
      "Registered": "2020-06-14T12:57:34.5397338+02:00"
    },
    {
      "AppointmentId": 90,
      "DocumentId": 259,
      "Date": "2019-10-25T12:57:34.5397338+02:00",
      "Description": "Operative regional structure",
      "Completed": "Completed",
      "Registered": "2020-06-14T12:57:34.5397338+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 244,
      "SaleDate": "2005-11-13T12:57:34.5397338+01:00",
      "Probability": 784,
      "Heading": "cum",
      "Amount": 14889.634,
      "Currency": "officia",
      "AmountInBaseCurrency": 21847.113999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2004-02-13T12:57:34.5397338+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 79,
      "Name": "Flatley, Lockman and Welch",
      "CompanyName": "Krajcik Inc and Sons",
      "FirstMessage": "recusandae",
      "LastMessage": "non",
      "WhenRequested": "2018-05-11T12:57:34.5397338+02:00",
      "WhenEnded": "2004-03-30T12:57:34.5397338+02:00"
    }
  ]
}
```