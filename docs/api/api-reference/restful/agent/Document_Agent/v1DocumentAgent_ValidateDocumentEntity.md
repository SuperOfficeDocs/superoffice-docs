---
title: POST Agents/Document/ValidateDocumentEntity
id: v1DocumentAgent_ValidateDocumentEntity
---

# POST Agents/Document/ValidateDocumentEntity

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 890,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "molestias",
    "Header": "recusandae",
    "Name": "Hansen Inc and Sons",
    "OurRef": "consectetur",
    "YourRef": "ipsum",
    "CreatedDate": "1995-03-16T18:28:48.8059291+01:00",
    "UpdatedDate": "2015-02-03T18:28:48.8059291+01:00",
    "Description": "Synergistic bottom-line archive",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1998-08-26T18:28:48.8059291+02:00",
    "ExternalRef": "et",
    "Completed": "Completed",
    "ActiveLinks": 242,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 322,
    "Snum": 558,
    "UserDefinedFields": {
      "SuperOffice:1": "1015436476",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "praesentium",
      "ExtraFields2": "consequuntur"
    },
    "CustomFields": {
      "CustomFields1": "nisi",
      "CustomFields2": "asperiores"
    },
    "PublishEventDate": "2000-11-09T18:28:48.8059291+01:00",
    "PublishTo": "2009-03-14T18:28:48.8059291+01:00",
    "PublishFrom": "2003-07-10T18:28:48.8059291+02:00",
    "IsPublished": true,
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
  "1": "doloremque",
  "2": "ut"
}
```