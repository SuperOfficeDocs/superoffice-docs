---
title: PATCH Attachment/{id}
id: v1AttachmentEntity_PatchAttachmentEntity
---

# PATCH Attachment/{id}

```http
PATCH /api/v1/Attachment/{id}
```

Update a AttachmentEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.ITicketAgent} service SaveAttachmentEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The AttachmentEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Attachment/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The Attachment carrier represent meta data for a Service attachment



AttachmentEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | AttachmentEntity  updated. |
| 404 | AttachmentEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because AttachmentEntity has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AttachmentId | int32 | The primary key (auto-incremented) |
| Name | string | The filename for the attachment. |
| ContentType | string | The content type for the attachment (e.g. &amp;apos;applaction/octet-stream&amp;apos; or &amp;apos;application/vnd.openxmlformats-officedocument.wordprocessingml.document&amp;apos;). |
| AttSize | int32 | The size (in bytes) for the attachment. |
| InlineImage | bool | True if this attachment is inlined in the html_body. |
| ContentId | string | The content_id of this attachment, used for inline images |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/Attachment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "nostrum",
    "value": {
      "value1": {
        "PrimaryKey": 97,
        "EntityName": "sale",
        "saleId": 97,
        "contactId": 7255,
        "name": "Cartwright LLC"
      },
      "value2": {
        "PrimaryKey": 7619,
        "EntityName": "sale",
        "saleId": 7619,
        "contactId": 4375,
        "name": "Abbott-Rutherford"
      }
    }
  },
  {
    "op": "add",
    "path": "nostrum",
    "value": {
      "value1": {
        "PrimaryKey": 97,
        "EntityName": "sale",
        "saleId": 97,
        "contactId": 7255,
        "name": "Cartwright LLC"
      },
      "value2": {
        "PrimaryKey": 7619,
        "EntityName": "sale",
        "saleId": 7619,
        "contactId": 4375,
        "name": "Abbott-Rutherford"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 AttachmentEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "AttachmentId": 853,
  "Name": "Koch, Rau and Harris",
  "ContentType": "optio",
  "AttSize": 150,
  "InlineImage": true,
  "ContentId": "recusandae",
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
      "FieldLength": 505
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```