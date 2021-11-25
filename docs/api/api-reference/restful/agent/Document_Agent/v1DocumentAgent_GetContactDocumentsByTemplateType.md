---
title: POST Agents/Document/GetContactDocumentsByTemplateType
id: v1DocumentAgent_GetContactDocumentsByTemplateType
---

# POST Agents/Document/GetContactDocumentsByTemplateType

```http
POST /api/v1/Agents/Document/GetContactDocumentsByTemplateType
```

Method that returns a specified number of document appointments within a time range, filtered by document template type.

The document appointments belong to the contact specified.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetContactDocumentsByTemplateType?$select=name,department,category/id
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

ContactId, StartTime, EndTime, Count, DocumentTemplateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| StartTime | date-time |  |
| EndTime | date-time |  |
| Count | int32 |  |
| DocumentTemplateId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 | Primary key |
| Attention | string | Attention/salutation |
| Header | string | Visible document name |
| Name | string | File name |
| OurRef | string | Our reference, searchable field from freetext search |
| YourRef | string | Your reference |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| DocumentTemplate | string |  |
| IsPublished | bool | True if document have an entry in published table |
| PersonId | int32 | Person ID of person the appointment is with, may be 0 |
| PersonFullName | string | The full name of the person this document belongs to. |
| AssociateFullName | string | The associate's culture formatted fullname (firstname, middleName and lastname) |
| ContactId | int32 | Contact ID of owning contact, may be 0 |
| ContactName | string | Contact name |
| ProjectId | int32 | ID of project referred to, may be 0 |
| ProjectName | string | Project name |
| AssociateId | int32 | ID of associate whose diary the appointment is in, REQUIRED |
| Snum | int32 | The sequence number allocated from refcount on used template when creating the document |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Document/GetContactDocumentsByTemplateType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 614,
  "StartTime": "2015-06-10T18:28:48.7059585+02:00",
  "EndTime": "2015-01-27T18:28:48.7059585+01:00",
  "Count": 543,
  "DocumentTemplateId": 755
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DocumentId": 79,
    "Attention": "voluptatem",
    "Header": "a",
    "Name": "Hartmann, Schinner and Zulauf",
    "OurRef": "provident",
    "YourRef": "modi",
    "Description": "Face to face non-volatile database",
    "DocumentTemplate": "dolorem",
    "IsPublished": false,
    "PersonId": 549,
    "PersonFullName": "Mya Douglas",
    "AssociateFullName": "Kameron Harris",
    "ContactId": 681,
    "ContactName": "Boyle-Leannon",
    "ProjectId": 906,
    "ProjectName": "Hilpert LLC",
    "AssociateId": 824,
    "Snum": 871,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 858
      }
    }
  }
]
```