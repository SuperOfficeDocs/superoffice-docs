---
title: POST Agents/Project/GetProjectEntity
uid: v1ProjectAgent_GetProjectEntity
generated: true
content_type: reference
---

# POST Agents/Project/GetProjectEntity

```http
POST /api/v1/Agents/Project/GetProjectEntity
```

Gets a ProjectEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The identifier of the ProjectEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=208
POST /api/v1/Agents/Project/GetProjectEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Project/GetProjectEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 496,
  "Name": "Conroy, Greenfelder and Leffler",
  "ProjectNumber": "641358",
  "ProjectMembers": [
    {
      "ProjectmemberId": 250,
      "ContactId": 451,
      "ProjectId": 115,
      "ContactName": "Dooley, Pagac and Hickle",
      "ContactDepartment": "",
      "ProjectName": "Sipes Group",
      "EmailId": 476,
      "EmailAddress": "giovanni_nader@rempelhahn.ca",
      "CountryId": 629,
      "Firstname": "Antoinette",
      "MiddleName": "Schuster-Funk",
      "Lastname": "Schmidt",
      "PersonId": 922,
      "Mrmrs": "voluptas",
      "ProjectMemberTypeName": "Lemke Inc and Sons",
      "Phone": "1-230-145-1172",
      "PhoneId": 382,
      "ProjectMemberTypeId": 890,
      "EmailAddressName": "nikita@mayer.com",
      "Comment": "veritatis",
      "FullName": "Dr. Noel Trey Botsford",
      "Registered": "2017-09-01T11:24:48.4688922+02:00",
      "Updated": "2016-09-10T11:24:48.4688922+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 878
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "dignissimos",
      "Description": "Customizable motivating middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "dignissimos",
      "Description": "Customizable motivating middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "CreatedDate": "2013-03-24T11:24:48.4688922+01:00",
  "UpdatedDate": "2016-11-18T11:24:48.4688922+01:00",
  "Description": "Business-focused global alliance",
  "Postit": "non",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Compatible needs-based protocol",
  "ActiveStatusMonitorId": 742,
  "Links": [
    {
      "EntityName": "Murphy-Schneider",
      "Id": 443,
      "Description": "Inverse bandwidth-monitored parallelism",
      "ExtraInfo": "quis",
      "LinkId": 286,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    }
  ],
  "ActiveLinks": 18,
  "Completed": false,
  "NextMilestoneDate": "2001-12-13T11:24:48.4688922+01:00",
  "NmdAppointmentId": 917,
  "EndDate": "2024-01-10T11:24:48.4688922+01:00",
  "ActiveErpLinks": 224,
  "UserDefinedFields": {
    "SuperOffice:1": "1327795870",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "praesentium",
    "CustomFields2": "doloremque"
  },
  "PublishEventDate": "2008-08-01T11:24:48.4688922+02:00",
  "PublishTo": "2010-01-12T11:24:48.4688922+01:00",
  "PublishFrom": "1999-03-08T11:24:48.4688922+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 350
    }
  }
}
```