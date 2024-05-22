---
title: PATCH Project/{id}
uid: v1ProjectEntity_PatchProjectEntity
generated: true
---

# PATCH Project/{id}

```http
PATCH /api/v1/Project/{id}
```

Update a ProjectEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


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



Calls the {SuperOffice.CRM.Services.IProjectAgent} service SaveProjectEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Project/{id}?$select=name,department,category/id
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

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

ProjectEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity  updated. |
| 404 | ProjectEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: ProjectEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 | Primary key |
| Name | string | Project name |
| ProjectNumber | string | Automatically generated number |
| ProjectMembers | array | The persons which are members of the project |
| Urls | array | The project's internet adresses |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated date  in UTC. |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  Use MDO List name "associate" to get list items. |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  Use MDO List name "projectstatus" to get list items. |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  Use MDO List name "projecttype" to get list items. |
| HasImage | bool | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | string | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for project |
| Links | array | List of all elements linked to the project |
| ActiveLinks | int32 | Number of active links to documents, other appointments, and such |
| Completed | bool | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | date-time | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | int32 | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | date-time | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PATCH /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "eum",
    "value": {}
  },
  {
    "op": "add",
    "path": "eum",
    "value": {}
  }
]
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 421,
  "Name": "Stoltenberg Group",
  "ProjectNumber": "494900",
  "ProjectMembers": [
    {
      "ProjectmemberId": 104,
      "ContactId": 822,
      "ProjectId": 423,
      "ContactName": "Jacobi Inc and Sons",
      "ContactDepartment": "",
      "ProjectName": "Graham, Fritsch and Barton",
      "EmailId": 296,
      "EmailAddress": "andy.stoltenberg@corkery.uk",
      "CountryId": 351,
      "Firstname": "Thelma",
      "MiddleName": "Langosh, Yost and Ernser",
      "Lastname": "Ernser",
      "PersonId": 40,
      "Mrmrs": "repellendus",
      "ProjectMemberTypeName": "Hettinger Inc and Sons",
      "Phone": "905.790.9650 x23908",
      "PhoneId": 446,
      "ProjectMemberTypeId": 337,
      "EmailAddressName": "presley_keeling@kuhic.ca",
      "Comment": "excepturi",
      "FullName": "Athena Stamm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Horizontal discrete neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 943
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Horizontal discrete neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 943
        }
      }
    }
  ],
  "CreatedDate": "1999-06-09T12:57:42.6200918+02:00",
  "UpdatedDate": "2002-02-14T12:57:42.6200918+01:00",
  "Description": "Face to face user-facing protocol",
  "Postit": "unde",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Devolved multimedia standardization",
  "ActiveStatusMonitorId": 602,
  "Links": [
    {
      "EntityName": "Ratke LLC",
      "Id": 708,
      "Description": "Intuitive full-range core",
      "ExtraInfo": "asperiores",
      "LinkId": 566,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "ActiveLinks": 10,
  "Completed": false,
  "NextMilestoneDate": "2017-03-23T12:57:42.6200918+01:00",
  "NmdAppointmentId": 428,
  "EndDate": "1997-01-28T12:57:42.6200918+01:00",
  "ActiveErpLinks": 254,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Jevon Roob IV",
    "SuperOffice:2": "Prof. Jerry Eda Torphy PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "beatae"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "distinctio"
  },
  "PublishEventDate": "2011-09-06T12:57:42.6200918+02:00",
  "PublishTo": "2012-08-31T12:57:42.6200918+02:00",
  "PublishFrom": "2021-09-24T12:57:42.6200918+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 533
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```