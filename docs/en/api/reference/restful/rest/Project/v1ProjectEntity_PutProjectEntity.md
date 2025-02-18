---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
generated: true
---

# PUT Project/{id}

```http
PUT /api/v1/Project/{id}
```

Updates the existing ProjectEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Project/{id}?$select=name,department,category/id
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

## Request Body: entity 

The ProjectEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer | Primary key |
| Name | String | Project name |
| ProjectNumber | String | Automatically generated number |
| ProjectMembers | Array | The persons which are members of the project |
| Urls | Array | The project's internet adresses |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated date  in UTC. |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| CreatedBy | Associate | The person that created the project |
| UpdatedBy | Associate | The person that last updated the project |
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
| HasImage | Boolean | True if the project has an image. (This is the image that is displayed in the CRM client) |
| ImageDescription | String | Description of the project image if it exists. (This is the image that is displayed in the CRM client) |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for project |
| Links | Array | List of all elements linked to the project |
| ActiveLinks | Integer | Number of active links to documents, other appointments, and such |
| Completed | Boolean | Done (0=false, 1=true). Status implies changes in which fields are shown in GUI, as well as which fields can be updated |
| NextMilestoneDate | String | Calculated date, reflects date of closest non-complete future milestone activity |
| NmdAppointmentId | Integer | ID of appointment that "caused" the nextMilestoneDate, can be 0 |
| EndDate | String | Planned end date for project, inhertied from type and later editable |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ProjectEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |

## Response:

ProjectEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ProjectEntity updated. |
| 412 | Update stopped because ProjectEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/Project/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 540,
  "Name": "Johnson Inc and Sons",
  "ProjectNumber": "938935",
  "ProjectMembers": [
    {
      "ProjectmemberId": 688,
      "ContactId": 184,
      "ProjectId": 90,
      "ContactName": "Leannon-Miller",
      "ContactDepartment": "",
      "ProjectName": "Kozey-Kassulke",
      "EmailId": 814,
      "EmailAddress": "orpha.howell@lynch.com",
      "CountryId": 345,
      "Firstname": "George",
      "MiddleName": "Hayes, Walker and Donnelly",
      "Lastname": "Renner",
      "PersonId": 220,
      "Mrmrs": "quia",
      "ProjectMemberTypeName": "Feeney LLC",
      "Phone": "725-376-4914",
      "PhoneId": 74,
      "ProjectMemberTypeId": 230,
      "EmailAddressName": "addie.yost@quigley.info",
      "Comment": "quia",
      "FullName": "Nikolas Stark II"
    }
  ],
  "Urls": [
    {
      "Value": "nihil",
      "StrippedValue": "ipsum",
      "Description": "Visionary actuating synergy"
    },
    {
      "Value": "nihil",
      "StrippedValue": "ipsum",
      "Description": "Visionary actuating synergy"
    }
  ],
  "CreatedDate": "2001-11-06T14:32:11.6772827+01:00",
  "UpdatedDate": "2009-02-04T14:32:11.6772827+01:00",
  "Description": "Multi-tiered human-resource analyzer",
  "Postit": "quis",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Function-based multimedia intranet",
  "ActiveStatusMonitorId": 218,
  "Links": [
    {
      "EntityName": "Littel-Volkman",
      "Id": 986,
      "Description": "Intuitive modular instruction set",
      "ExtraInfo": "dolorum",
      "LinkId": 972
    },
    {
      "EntityName": "Littel-Volkman",
      "Id": 986,
      "Description": "Intuitive modular instruction set",
      "ExtraInfo": "dolorum",
      "LinkId": 972
    }
  ],
  "ActiveLinks": 893,
  "Completed": true,
  "NextMilestoneDate": "1999-11-16T14:32:11.6772827+01:00",
  "NmdAppointmentId": 664,
  "EndDate": "2001-10-18T14:32:11.6772827+02:00",
  "ActiveErpLinks": 258,
  "UserDefinedFields": {
    "SuperOffice:1": "Ova Sipes",
    "SuperOffice:2": "Fabian Auer"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "vero",
    "CustomFields2": "molestiae"
  },
  "PublishEventDate": "2020-12-05T14:32:11.6772827+01:00",
  "PublishTo": "2016-09-22T14:32:11.6772827+02:00",
  "PublishFrom": "1998-05-12T14:32:11.6772827+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 326,
  "Name": "Frami Inc and Sons",
  "ProjectNumber": "1222109",
  "ProjectMembers": [
    {
      "ProjectmemberId": 81,
      "ContactId": 19,
      "ProjectId": 549,
      "ContactName": "Ortiz-Conroy",
      "ContactDepartment": "",
      "ProjectName": "Hagenes Inc and Sons",
      "EmailId": 600,
      "EmailAddress": "marcia.predovic@wintheiser.info",
      "CountryId": 736,
      "Firstname": "Wilburn",
      "MiddleName": "Quitzon, Davis and Koelpin",
      "Lastname": "Nitzsche",
      "PersonId": 80,
      "Mrmrs": "rerum",
      "ProjectMemberTypeName": "Tremblay-Bahringer",
      "Phone": "1-297-768-1523 x223",
      "PhoneId": 59,
      "ProjectMemberTypeId": 426,
      "EmailAddressName": "cassandra@blandahayes.uk",
      "Comment": "perspiciatis",
      "FullName": "Mrs. Lexus Stamm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repellat",
      "StrippedValue": "eius",
      "Description": "Quality-focused intermediate emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 924
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "eius",
      "Description": "Quality-focused intermediate emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 924
        }
      }
    }
  ],
  "CreatedDate": "1998-02-22T14:32:11.6772827+01:00",
  "UpdatedDate": "2010-02-22T14:32:11.6772827+01:00",
  "Description": "Digitized impactful emulation",
  "Postit": "et",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Vision-oriented assymetric initiative",
  "ActiveStatusMonitorId": 470,
  "Links": [
    {
      "EntityName": "Feeney-Auer",
      "Id": 982,
      "Description": "Synchronised regional customer loyalty",
      "ExtraInfo": "molestiae",
      "LinkId": 247,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 225
        }
      }
    }
  ],
  "ActiveLinks": 715,
  "Completed": false,
  "NextMilestoneDate": "2023-05-05T14:32:11.6929043+02:00",
  "NmdAppointmentId": 934,
  "EndDate": "2004-04-19T14:32:11.6929043+02:00",
  "ActiveErpLinks": 356,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Joan Arnulfo Hermann DVM",
    "SuperOffice:2": "Eileen Fritsch"
  },
  "ExtraFields": {
    "ExtraFields1": "tenetur",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "neque",
    "CustomFields2": "expedita"
  },
  "PublishEventDate": "2010-03-03T14:32:11.6929043+01:00",
  "PublishTo": "2023-10-14T14:32:11.6929043+02:00",
  "PublishFrom": "2017-07-30T14:32:11.6929043+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 895
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```