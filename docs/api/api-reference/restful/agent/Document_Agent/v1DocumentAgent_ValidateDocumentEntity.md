---
title: ValidateDocumentEntity
id: v1DocumentAgent_ValidateDocumentEntity
---

# ValidateDocumentEntity

```http
POST /api/v1/Agents/Document/ValidateDocumentEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/ValidateDocumentEntity?$select=name,department,category/id
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

DocumentEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Document/ValidateDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 211,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "quia",
    "Header": "veniam",
    "Name": "Okuneva, Ferry and Hartmann",
    "OurRef": "sit",
    "YourRef": "incidunt",
    "CreatedDate": "2020-07-06T14:58:03.9094596+02:00",
    "UpdatedDate": "2020-04-19T14:58:03.9094596+02:00",
    "Description": "Optimized modular capacity",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "2001-07-20T14:58:03.9094596+02:00",
    "ExternalRef": "nisi",
    "Completed": "Completed",
    "ActiveLinks": 314,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 973,
    "Snum": 832,
    "UserDefinedFields": {
      "SuperOffice:1": "823117957",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "et",
      "ExtraFields2": "repellendus"
    },
    "CustomFields": {
      "CustomFields1": "consequatur",
      "CustomFields2": "dolores"
    },
    "PublishEventDate": "2002-12-25T14:58:03.9094596+01:00",
    "PublishTo": "1997-12-02T14:58:03.9094596+01:00",
    "PublishFrom": "1995-02-03T14:58:03.9094596+01:00",
    "IsPublished": false,
    "VisibleFor": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "eligendi",
  "2": "quia"
}
```