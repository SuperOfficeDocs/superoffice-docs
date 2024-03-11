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
  "ProjectId": 519,
  "Name": "Bernier Group",
  "ProjectNumber": "1181602",
  "ProjectMembers": [
    {
      "ProjectmemberId": 383,
      "ContactId": 323,
      "ProjectId": 108,
      "ContactName": "Bailey, Pfeffer and Treutel",
      "ContactDepartment": "redefine seamless experiences",
      "ProjectName": "Bayer-Koss",
      "EmailId": 162,
      "EmailAddress": "ethel_sawayn@lockmanwill.us",
      "CountryId": 710,
      "Firstname": "Colby",
      "MiddleName": "Volkman LLC",
      "Lastname": "Brown",
      "PersonId": 197,
      "Mrmrs": "qui",
      "ProjectMemberTypeName": "Hills, Kerluke and Bernhard",
      "Phone": "1-608-797-2232 x5242",
      "PhoneId": 501,
      "ProjectMemberTypeId": 587,
      "EmailAddressName": "isabell.conn@skiles.info",
      "Comment": "nihil",
      "FullName": "Mitchel Muhammad DuBuque Jr."
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "placeat",
      "Description": "Polarised upward-trending intranet"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "placeat",
      "Description": "Polarised upward-trending intranet"
    }
  ],
  "CreatedDate": "2015-01-23T14:23:55.3377117+01:00",
  "UpdatedDate": "2021-02-15T14:23:55.3377117+01:00",
  "Description": "Function-based bi-directional capacity",
  "Postit": "quaerat",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Open-source fresh-thinking capacity",
  "ActiveStatusMonitorId": 39,
  "Links": [
    {
      "EntityName": "Willms-Treutel",
      "Id": 556,
      "Description": "Triple-buffered high-level capacity",
      "ExtraInfo": "odio",
      "LinkId": 507
    },
    {
      "EntityName": "Willms-Treutel",
      "Id": 556,
      "Description": "Triple-buffered high-level capacity",
      "ExtraInfo": "odio",
      "LinkId": 507
    }
  ],
  "ActiveLinks": 130,
  "Completed": true,
  "NextMilestoneDate": "2018-11-29T14:23:55.3377117+01:00",
  "NmdAppointmentId": 100,
  "EndDate": "2018-12-06T14:23:55.3377117+01:00",
  "ActiveErpLinks": 372,
  "UserDefinedFields": {
    "SuperOffice:1": "Everett Rempel",
    "SuperOffice:2": "Allan Metz"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "corrupti"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "quae"
  },
  "PublishEventDate": "2021-08-24T14:23:55.3377117+02:00",
  "PublishTo": "2022-12-13T14:23:55.3377117+01:00",
  "PublishFrom": "2001-10-17T14:23:55.3377117+02:00",
  "IsPublished": true
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 635,
  "Name": "Stokes, Stiedemann and Deckow",
  "ProjectNumber": "1410418",
  "ProjectMembers": [
    {
      "ProjectmemberId": 66,
      "ContactId": 245,
      "ProjectId": 191,
      "ContactName": "Beier Group",
      "ContactDepartment": "",
      "ProjectName": "McClure, Kemmer and Shields",
      "EmailId": 744,
      "EmailAddress": "jarvis.bednar@hagenes.co.uk",
      "CountryId": 585,
      "Firstname": "Selina",
      "MiddleName": "Lindgren, Lehner and Rodriguez",
      "Lastname": "Grimes",
      "PersonId": 329,
      "Mrmrs": "nisi",
      "ProjectMemberTypeName": "Lockman-Romaguera",
      "Phone": "663.021.3956 x235",
      "PhoneId": 28,
      "ProjectMemberTypeId": 291,
      "EmailAddressName": "jeramie@herzog.name",
      "Comment": "cupiditate",
      "FullName": "Trinity Jewess",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aspernatur",
      "StrippedValue": "consectetur",
      "Description": "Multi-layered attitude-oriented workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "consectetur",
      "Description": "Multi-layered attitude-oriented workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "CreatedDate": "2022-10-19T14:23:55.3533546+02:00",
  "UpdatedDate": "2003-10-02T14:23:55.3533546+02:00",
  "Description": "Optional responsive superstructure",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Down-sized foreground middleware",
  "ActiveStatusMonitorId": 910,
  "Links": [
    {
      "EntityName": "Veum-Wiegand",
      "Id": 905,
      "Description": "Right-sized radical workforce",
      "ExtraInfo": "illum",
      "LinkId": 934,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "ActiveLinks": 192,
  "Completed": false,
  "NextMilestoneDate": "2009-09-20T14:23:55.3533546+02:00",
  "NmdAppointmentId": 179,
  "EndDate": "1999-10-03T14:23:55.3533546+02:00",
  "ActiveErpLinks": 925,
  "UserDefinedFields": {
    "SuperOffice:1": "1655614331",
    "SuperOffice:2": "Miss Cleo Volkman"
  },
  "ExtraFields": {
    "ExtraFields1": "saepe",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "molestiae"
  },
  "PublishEventDate": "2013-03-07T14:23:55.3533546+01:00",
  "PublishTo": "2004-11-17T14:23:55.3533546+01:00",
  "PublishFrom": "2000-08-20T14:23:55.3533546+02:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 699
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```