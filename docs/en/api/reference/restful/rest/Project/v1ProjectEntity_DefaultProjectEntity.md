---
title: GET Project/default
uid: v1ProjectEntity_DefaultProjectEntity
generated: true
content_type: reference
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 05 May 2018 03:47:00 G5T

{
  "ProjectId": 214,
  "Name": "Beier-Hartmann",
  "ProjectNumber": "1129402",
  "ProjectMembers": [
    {
      "ProjectmemberId": 459,
      "ContactId": 661,
      "ProjectId": 500,
      "ContactName": "Rowe-Welch",
      "ContactDepartment": "",
      "ProjectName": "Miller, Zulauf and Emmerich",
      "EmailId": 279,
      "EmailAddress": "conor.monahan@blanda.info",
      "CountryId": 528,
      "Firstname": "Erwin",
      "MiddleName": "Schaden Inc and Sons",
      "Lastname": "Runolfsson",
      "PersonId": 971,
      "Mrmrs": "nemo",
      "ProjectMemberTypeName": "Heaney, Paucek and Price",
      "Phone": "610-452-0014 x19924",
      "PhoneId": 175,
      "ProjectMemberTypeId": 47,
      "EmailAddressName": "roslyn@beatty.uk",
      "Comment": "inventore",
      "FullName": "Bettye Huels",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 144
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minima",
      "StrippedValue": "deleniti",
      "Description": "Inverse leading edge hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "deleniti",
      "Description": "Inverse leading edge hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 315
        }
      }
    }
  ],
  "CreatedDate": "2001-04-15T03:47:00.1599324+02:00",
  "UpdatedDate": "2018-05-05T03:47:00.1599324+02:00",
  "Description": "Organized 5th generation function",
  "Postit": "molestias",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Realigned 3rd generation support",
  "ActiveStatusMonitorId": 921,
  "Links": [
    {
      "EntityName": "Schneider-Leuschke",
      "Id": 572,
      "Description": "Profit-focused human-resource frame",
      "ExtraInfo": "dolorem",
      "LinkId": 328,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 441
        }
      }
    }
  ],
  "ActiveLinks": 321,
  "Completed": false,
  "NextMilestoneDate": "2003-12-05T03:47:00.1599324+01:00",
  "NmdAppointmentId": 85,
  "EndDate": "2018-05-23T03:47:00.1599324+02:00",
  "ActiveErpLinks": 973,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Natalia Bosco III",
    "SuperOffice:2": "647335583"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "dolorem"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "numquam"
  },
  "PublishEventDate": "2011-09-24T03:47:00.1599324+02:00",
  "PublishTo": "2018-10-06T03:47:00.1599324+02:00",
  "PublishFrom": "2016-07-24T03:47:00.1599324+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 568
    }
  }
}
```