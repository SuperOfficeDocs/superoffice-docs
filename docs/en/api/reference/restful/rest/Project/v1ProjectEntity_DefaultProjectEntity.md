---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
generated: true
---

# GET Project/default

```http
GET /api/v1/Project/default
```

Set default values into a new ProjectEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Project agent service CreateDefaultProjectEntity.







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
GET /api/v1/Project/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 19 Mar 2016 14:28:27 G3T

{
  "ProjectId": 300,
  "Name": "Hamill, Quigley and Blick",
  "ProjectNumber": "916165",
  "ProjectMembers": [
    {
      "ProjectmemberId": 361,
      "ContactId": 446,
      "ProjectId": 491,
      "ContactName": "Christiansen-Sawayn",
      "ContactDepartment": "",
      "ProjectName": "O'Hara-Ullrich",
      "EmailId": 277,
      "EmailAddress": "gus_brakus@pfeffer.uk",
      "CountryId": 746,
      "Firstname": "Marlin",
      "MiddleName": "Littel Inc and Sons",
      "Lastname": "Ryan",
      "PersonId": 1001,
      "Mrmrs": "delectus",
      "ProjectMemberTypeName": "Kassulke Group",
      "Phone": "(928)077-6663 x4092",
      "PhoneId": 972,
      "ProjectMemberTypeId": 52,
      "EmailAddressName": "brionna_christiansen@effertz.com",
      "Comment": "fugit",
      "FullName": "Ms. Cody Beatrice Keeling PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ex",
      "StrippedValue": "alias",
      "Description": "Persistent hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 509
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "alias",
      "Description": "Persistent hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 509
        }
      }
    }
  ],
  "CreatedDate": "2020-03-10T14:28:27.0239403+01:00",
  "UpdatedDate": "2016-03-19T14:28:27.0239403+01:00",
  "Description": "Ameliorated attitude-oriented task-force",
  "Postit": "ullam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Realigned cohesive function",
  "ActiveStatusMonitorId": 561,
  "Links": [
    {
      "EntityName": "Stracke, Labadie and DuBuque",
      "Id": 215,
      "Description": "Organized methodical architecture",
      "ExtraInfo": "voluptatem",
      "LinkId": 36,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "ActiveLinks": 168,
  "Completed": false,
  "NextMilestoneDate": "2001-01-18T14:28:27.0239403+01:00",
  "NmdAppointmentId": 535,
  "EndDate": "1999-07-12T14:28:27.0239403+02:00",
  "ActiveErpLinks": 996,
  "UserDefinedFields": {
    "SuperOffice:1": "Rollin Williamson",
    "SuperOffice:2": "Aidan Jeanne Walsh MD"
  },
  "ExtraFields": {
    "ExtraFields1": "quasi",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "ab",
    "CustomFields2": "ex"
  },
  "PublishEventDate": "2015-06-19T14:28:27.0239403+02:00",
  "PublishTo": "2010-04-30T14:28:27.0239403+02:00",
  "PublishFrom": "2014-06-30T14:28:27.0239403+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 634
    }
  }
}
```