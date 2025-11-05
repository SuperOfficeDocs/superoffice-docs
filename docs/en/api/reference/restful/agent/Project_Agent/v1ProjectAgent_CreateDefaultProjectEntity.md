---
title: POST Agents/Project/CreateDefaultProjectEntity
uid: v1ProjectAgent_CreateDefaultProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/CreateDefaultProjectEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
```

Loading default values into a new ProjectEntity.


NsApiSlow threshold: 2000 ms.







## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEntity

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

## Sample request

```http!
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 57,
  "Name": "Kling-Dach",
  "ProjectNumber": "1288549",
  "ProjectMembers": [
    {
      "ProjectmemberId": 721,
      "ContactId": 894,
      "ProjectId": 159,
      "ContactName": "Hermann-Hayes",
      "ContactDepartment": "",
      "ProjectName": "Hand-Price",
      "EmailId": 346,
      "EmailAddress": "kasandra.goldner@gerhold.com",
      "CountryId": 14,
      "Firstname": "Tommie",
      "MiddleName": "Kuhn Inc and Sons",
      "Lastname": "Kirlin",
      "PersonId": 284,
      "Mrmrs": "laboriosam",
      "ProjectMemberTypeName": "Hyatt Group",
      "Phone": "1-942-720-9248 x0892",
      "PhoneId": 536,
      "ProjectMemberTypeId": 301,
      "EmailAddressName": "rigoberto.emard@gutkowski.com",
      "Comment": "velit",
      "FullName": "Mr. Adah Durgan MD",
      "Registered": "2018-08-13T02:30:47.6006984+02:00",
      "Updated": "2013-11-29T02:30:47.6006984+01:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Customer-focused system-worthy secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Customer-focused system-worthy secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 501
        }
      }
    }
  ],
  "CreatedDate": "1998-12-25T02:30:47.6006984+01:00",
  "UpdatedDate": "2007-02-23T02:30:47.6006984+01:00",
  "Description": "Implemented neutral migration",
  "Postit": "consequuntur",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Innovative regional website",
  "ActiveStatusMonitorId": 145,
  "Links": [
    {
      "EntityName": "Schmidt-Lowe",
      "Id": 216,
      "Description": "Organized global emulation",
      "ExtraInfo": "sed",
      "LinkId": 88,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "ActiveLinks": 987,
  "Completed": false,
  "NextMilestoneDate": "2002-08-19T02:30:47.6006984+02:00",
  "NmdAppointmentId": 592,
  "EndDate": "2007-10-10T02:30:47.6006984+02:00",
  "ActiveErpLinks": 197,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "905540656"
  },
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "reiciendis",
    "CustomFields2": "officia"
  },
  "PublishEventDate": "2021-04-15T02:30:47.6006984+02:00",
  "PublishTo": "2000-06-22T02:30:47.6006984+02:00",
  "PublishFrom": "2001-04-09T02:30:47.6006984+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 1001
    }
  }
}
```