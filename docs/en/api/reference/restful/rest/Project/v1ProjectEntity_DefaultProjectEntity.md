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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 25 Dec 2015 02:38:26 G12T

{
  "ProjectId": 587,
  "Name": "Keeling Group",
  "ProjectNumber": "786686",
  "ProjectMembers": [
    {
      "ProjectmemberId": 902,
      "ContactId": 860,
      "ProjectId": 542,
      "ContactName": "Schmidt-Roob",
      "ContactDepartment": "deploy intuitive markets",
      "ProjectName": "Okuneva, Williamson and Smith",
      "EmailId": 240,
      "EmailAddress": "kasandra.conroy@ebertshields.us",
      "CountryId": 958,
      "Firstname": "Jadon",
      "MiddleName": "Rohan Inc and Sons",
      "Lastname": "Rosenbaum",
      "PersonId": 244,
      "Mrmrs": "porro",
      "ProjectMemberTypeName": "Leannon Inc and Sons",
      "Phone": "(299)761-7743 x625",
      "PhoneId": 209,
      "ProjectMemberTypeId": 324,
      "EmailAddressName": "rose_hills@blanda.us",
      "Comment": "harum",
      "FullName": "Georgette Jacobson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "minus",
      "StrippedValue": "officia",
      "Description": "Grass-roots next generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    },
    {
      "Value": "minus",
      "StrippedValue": "officia",
      "Description": "Grass-roots next generation array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 737
        }
      }
    }
  ],
  "CreatedDate": "2002-07-05T02:38:26.1985521+02:00",
  "UpdatedDate": "2015-12-25T02:38:26.1985521+01:00",
  "Description": "Decentralized context-sensitive info-mediaries",
  "Postit": "maiores",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": true,
  "ImageDescription": "Open-architected high-level attitude",
  "ActiveStatusMonitorId": 821,
  "Links": [
    {
      "EntityName": "Pacocha, Lueilwitz and Jerde",
      "Id": 836,
      "Description": "Automated grid-enabled model",
      "ExtraInfo": "dignissimos",
      "LinkId": 882,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "ActiveLinks": 542,
  "Completed": true,
  "NextMilestoneDate": "2023-12-11T02:38:26.1985521+01:00",
  "NmdAppointmentId": 475,
  "EndDate": "2024-05-11T02:38:26.1985521+02:00",
  "ActiveErpLinks": 890,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "794712181"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "quos"
  },
  "PublishEventDate": "2006-08-05T02:38:26.1985521+02:00",
  "PublishTo": "2001-10-05T02:38:26.1985521+02:00",
  "PublishFrom": "2002-10-08T02:38:26.1985521+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 130
    }
  }
}
```