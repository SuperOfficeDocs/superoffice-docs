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


NsApiSlow threshold: 2000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEntityId | int32 | **Required** The identifier of the ProjectEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEntity?projectEntityId=406
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
  "ProjectId": 317,
  "Name": "Hamill-Parker",
  "ProjectNumber": "1020494",
  "ProjectMembers": [
    {
      "ProjectmemberId": 995,
      "ContactId": 874,
      "ProjectId": 615,
      "ContactName": "Gibson LLC",
      "ContactDepartment": "",
      "ProjectName": "Ruecker, Haag and Stanton",
      "EmailId": 932,
      "EmailAddress": "alvera.bins@schamberger.com",
      "CountryId": 292,
      "Firstname": "Georgette",
      "MiddleName": "Reichert-Grady",
      "Lastname": "Cassin",
      "PersonId": 382,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Nienow-Stroman",
      "Phone": "943-105-2637 x07002",
      "PhoneId": 857,
      "ProjectMemberTypeId": 123,
      "EmailAddressName": "felicia@jakubowski.info",
      "Comment": "cumque",
      "FullName": "Robb Jenkins",
      "Registered": "2013-01-15T02:30:47.6632017+01:00",
      "Updated": "2009-07-14T02:30:47.6632017+02:00",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "placeat",
      "StrippedValue": "enim",
      "Description": "Managed fault-tolerant customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "enim",
      "Description": "Managed fault-tolerant customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 869
        }
      }
    }
  ],
  "CreatedDate": "1999-09-14T02:30:47.6632017+02:00",
  "UpdatedDate": "2008-02-02T02:30:47.6632017+01:00",
  "Description": "Monitored upward-trending capability",
  "Postit": "qui",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Right-sized neutral definition",
  "ActiveStatusMonitorId": 638,
  "Links": [
    {
      "EntityName": "DuBuque-Klocko",
      "Id": 153,
      "Description": "Progressive cohesive core",
      "ExtraInfo": "sint",
      "LinkId": 772,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "ActiveLinks": 807,
  "Completed": false,
  "NextMilestoneDate": "2000-06-17T02:30:47.6632017+02:00",
  "NmdAppointmentId": 763,
  "EndDate": "2014-08-30T02:30:47.6632017+02:00",
  "ActiveErpLinks": 636,
  "UserDefinedFields": {
    "SuperOffice:1": "Ocie Muller",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "voluptatem"
  },
  "PublishEventDate": "2019-03-07T02:30:47.6632017+01:00",
  "PublishTo": "2002-09-16T02:30:47.6632017+02:00",
  "PublishFrom": "2017-02-12T02:30:47.6632017+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 484
    }
  }
}
```