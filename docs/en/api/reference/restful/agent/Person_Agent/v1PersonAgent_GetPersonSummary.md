---
title: POST Agents/Person/GetPersonSummary
uid: v1PersonAgent_GetPersonSummary
generated: true
content_type: reference
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
  "PersonId": 243,
  "Limit": 152
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
      "TicketId": 540,
      "TicketStatus": 590,
      "Title": "non",
      "Registered": "2015-05-08T03:46:55.0976201+02:00",
      "IconHint": "ea"
    },
    {
      "TicketId": 540,
      "TicketStatus": 590,
      "Title": "non",
      "Registered": "2015-05-08T03:46:55.0976201+02:00",
      "IconHint": "ea"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 922,
      "DocumentId": 986,
      "Date": "1999-03-31T03:46:55.0976201+02:00",
      "Description": "Public-key impactful encryption",
      "Completed": "Completed",
      "Registered": "2002-04-29T03:46:55.0976201+02:00"
    },
    {
      "AppointmentId": 922,
      "DocumentId": 986,
      "Date": "1999-03-31T03:46:55.0976201+02:00",
      "Description": "Public-key impactful encryption",
      "Completed": "Completed",
      "Registered": "2002-04-29T03:46:55.0976201+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 737,
      "DocumentId": 498,
      "Date": "2002-05-18T03:46:55.0976201+02:00",
      "Description": "Mandatory scalable algorithm",
      "Completed": "Completed",
      "Registered": "2004-09-04T03:46:55.0976201+02:00"
    },
    {
      "AppointmentId": 737,
      "DocumentId": 498,
      "Date": "2002-05-18T03:46:55.0976201+02:00",
      "Description": "Mandatory scalable algorithm",
      "Completed": "Completed",
      "Registered": "2004-09-04T03:46:55.0976201+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 718,
      "SaleDate": "2001-05-27T03:46:55.0976201+02:00",
      "Probability": 460,
      "Heading": "officia",
      "Amount": 28792.057999999997,
      "Currency": "et",
      "AmountInBaseCurrency": 19618.84,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2000-02-27T03:46:55.0976201+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 272,
      "Name": "Kihn-Lebsack",
      "CompanyName": "Simonis LLC",
      "FirstMessage": "sed",
      "LastMessage": "enim",
      "WhenRequested": "2023-09-19T03:46:55.0976201+02:00",
      "WhenEnded": "2016-07-04T03:46:55.0976201+02:00"
    }
  ]
}
```