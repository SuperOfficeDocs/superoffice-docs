---
title: POST Agents/Document/GetProjectMemberDocumentsByTemplateHeading
id: v1DocumentAgent_GetProjectMemberDocumentsByTemplateHeading
---

# POST Agents/Document/GetProjectMemberDocumentsByTemplateHeading

```http
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading
```

Method that returns a specified number of document appointments within a time range, filtered by document template heading.

The document appointments belong to the project member specified. The heading represents a grouping or filtering of document templates.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading?$select=name,department,category/id
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

PersonId, StartTime, EndTime, Count, TemplateHeadingId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| StartTime | date-time |  |
| EndTime | date-time |  |
| Count | int32 |  |
| TemplateHeadingId | int32 |  |


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
POST /api/v1/Agents/Document/GetProjectMemberDocumentsByTemplateHeading
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 861,
  "StartTime": "2013-09-05T18:28:48.7149596+02:00",
  "EndTime": "2005-03-02T18:28:48.7149596+01:00",
  "Count": 902,
  "TemplateHeadingId": 565
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DocumentId": 786,
    "Attention": "et",
    "Header": "perferendis",
    "Name": "Stanton Group",
    "OurRef": "et",
    "YourRef": "saepe",
    "Description": "Synchronised dedicated algorithm",
    "DocumentTemplate": "delectus",
    "IsPublished": true,
    "PersonId": 980,
    "PersonFullName": "Trevion Sawayn",
    "AssociateFullName": "August Gibson",
    "ContactId": 918,
    "ContactName": "Stoltenberg Group",
    "ProjectId": 906,
    "ProjectName": "Gislason, Hegmann and Hickle",
    "AssociateId": 153,
    "Snum": 365,
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
        "FieldType": "System.Int32",
        "FieldLength": 496
      }
    }
  }
]
```