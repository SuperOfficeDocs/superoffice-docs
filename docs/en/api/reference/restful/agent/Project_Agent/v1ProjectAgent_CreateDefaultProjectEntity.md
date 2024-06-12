---
title: POST Agents/Project/CreateDefaultProjectEntity
uid: v1ProjectAgent_CreateDefaultProjectEntity
generated: true
---

# POST Agents/Project/CreateDefaultProjectEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEntity
```

Set default values into a new ProjectEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
  "ProjectId": 432,
  "Name": "Gulgowski-Kautzer",
  "ProjectNumber": "437347",
  "ProjectMembers": [
    {
      "ProjectmemberId": 371,
      "ContactId": 511,
      "ProjectId": 274,
      "ContactName": "Dickinson-Glover",
      "ContactDepartment": "",
      "ProjectName": "Beahan, Ratke and Jacobi",
      "EmailId": 485,
      "EmailAddress": "damion.bernier@anderson.com",
      "CountryId": 945,
      "Firstname": "Kaley",
      "MiddleName": "Stehr Group",
      "Lastname": "Tillman",
      "PersonId": 577,
      "Mrmrs": "quam",
      "ProjectMemberTypeName": "Streich-Davis",
      "Phone": "265.850.6570",
      "PhoneId": 406,
      "ProjectMemberTypeId": 241,
      "EmailAddressName": "luis_breitenberg@goodwin.name",
      "Comment": "eum",
      "FullName": "Kailee Osinski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 892
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "fuga",
      "Description": "Secured motivating conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "fuga",
      "Description": "Secured motivating conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "CreatedDate": "2016-10-26T04:22:27.2997425+02:00",
  "UpdatedDate": "2000-06-29T04:22:27.2997425+02:00",
  "Description": "Devolved high-level success",
  "Postit": "explicabo",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Integrated eco-centric toolset",
  "ActiveStatusMonitorId": 245,
  "Links": [
    {
      "EntityName": "VonRueden Group",
      "Id": 759,
      "Description": "Sharable responsive Graphic Interface",
      "ExtraInfo": "illum",
      "LinkId": 1002,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 655
        }
      }
    }
  ],
  "ActiveLinks": 92,
  "Completed": true,
  "NextMilestoneDate": "2023-05-27T04:22:27.2997425+02:00",
  "NmdAppointmentId": 841,
  "EndDate": "2015-12-30T04:22:27.2997425+01:00",
  "ActiveErpLinks": 895,
  "UserDefinedFields": {
    "SuperOffice:1": "Katlyn Franecki",
    "SuperOffice:2": "Lowell Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "suscipit",
    "CustomFields2": "temporibus"
  },
  "PublishEventDate": "1999-04-29T04:22:27.2997425+02:00",
  "PublishTo": "2019-06-27T04:22:27.2997425+02:00",
  "PublishFrom": "2016-08-21T04:22:27.2997425+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 871
    }
  }
}
```