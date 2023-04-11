---
title: PUT Project/{id}
uid: v1ProjectEntity_PutProjectEntity
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
| Associate | Associate | The person that created the project  <para>Use MDO List name "associate" to get list items.</para> |
| ProjectStatus | ProjectStatus | Project status is a list defined by the database administrator. Different statuses of a project may be: “In planning”, “Started”, “Finished” and so on  <para>Use MDO List name "projectstatus" to get list items.</para> |
| ProjectType | ProjectType | Project type is a list defined by the database admin. for example: 'Large', 'Small', 'Party'...  <para>Use MDO List name "projecttype" to get list items.</para> |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ProjectEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ProjectEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 831,
  "Name": "Kub, Walsh and Rath",
  "ProjectNumber": "1458371",
  "ProjectMembers": [
    {
      "ProjectmemberId": 254,
      "ContactId": 89,
      "ProjectId": 362,
      "ContactName": "Sanford-Miller",
      "ContactDepartment": "",
      "ProjectName": "Mraz LLC",
      "EmailId": 879,
      "EmailAddress": "kyra.hartmann@simonis.biz",
      "CountryId": 691,
      "Firstname": "Turner",
      "MiddleName": "Wolff-Kohler",
      "Lastname": "Muller",
      "PersonId": 470,
      "Mrmrs": "hic",
      "ProjectMemberTypeName": "Kulas-Lockman",
      "Phone": "1-882-119-6796",
      "PhoneId": 206,
      "ProjectMemberTypeId": 874,
      "EmailAddressName": "walton@franecki.biz",
      "Comment": "qui",
      "FullName": "Mona Herzog"
    }
  ],
  "Urls": [
    {
      "Value": "dolorum",
      "StrippedValue": "quos",
      "Description": "Organic value-added standardization"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "quos",
      "Description": "Organic value-added standardization"
    }
  ],
  "CreatedDate": "2003-08-15T15:29:29.961693+02:00",
  "UpdatedDate": "2011-10-13T15:29:29.961693+02:00",
  "Description": "Fully-configurable 24 hour installation",
  "Postit": "numquam",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Multi-channelled clear-thinking adapter",
  "ActiveStatusMonitorId": 409,
  "Links": [
    {
      "EntityName": "Monahan-Cartwright",
      "Id": 139,
      "Description": "Mandatory dedicated ability",
      "ExtraInfo": "a",
      "LinkId": 780
    },
    {
      "EntityName": "Monahan-Cartwright",
      "Id": 139,
      "Description": "Mandatory dedicated ability",
      "ExtraInfo": "a",
      "LinkId": 780
    }
  ],
  "ActiveLinks": 114,
  "Completed": false,
  "NextMilestoneDate": "2012-12-06T15:29:29.9631961+01:00",
  "NmdAppointmentId": 538,
  "EndDate": "1999-07-03T15:29:29.9631961+02:00",
  "ActiveErpLinks": 808,
  "UserDefinedFields": {
    "SuperOffice:1": "Jarvis Homenick",
    "SuperOffice:2": "Mrs. Elisabeth Cale Boyle"
  },
  "ExtraFields": {
    "ExtraFields1": "occaecati",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "ea"
  },
  "PublishEventDate": "2020-10-23T15:29:29.9641995+02:00",
  "PublishTo": "2010-10-02T15:29:29.9641995+02:00",
  "PublishFrom": "2007-11-14T15:29:29.9641995+01:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 ProjectEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 816,
  "Name": "Morar Group",
  "ProjectNumber": "710948",
  "ProjectMembers": [
    {
      "ProjectmemberId": 239,
      "ContactId": 573,
      "ProjectId": 775,
      "ContactName": "Dach LLC",
      "ContactDepartment": "",
      "ProjectName": "Von LLC",
      "EmailId": 68,
      "EmailAddress": "celestine_runte@spinkagaylord.co.uk",
      "CountryId": 865,
      "Firstname": "Gudrun",
      "MiddleName": "Fay-Goyette",
      "Lastname": "Kuvalis",
      "PersonId": 418,
      "Mrmrs": "cum",
      "ProjectMemberTypeName": "Frami Inc and Sons",
      "Phone": "1-364-813-6300 x78490",
      "PhoneId": 953,
      "ProjectMemberTypeId": 171,
      "EmailAddressName": "lorine.hodkiewicz@hoeger.co.uk",
      "Comment": "cupiditate",
      "FullName": "Miss Carolyn Elda Raynor",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 887
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "illum",
      "StrippedValue": "velit",
      "Description": "Programmable demand-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 962
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "velit",
      "Description": "Programmable demand-driven product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 962
        }
      }
    }
  ],
  "CreatedDate": "1997-02-25T15:29:29.9681957+01:00",
  "UpdatedDate": "2014-06-12T15:29:29.9681957+02:00",
  "Description": "Multi-channelled bandwidth-monitored process improvement",
  "Postit": "molestiae",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Centralized maximized budgetary management",
  "ActiveStatusMonitorId": 71,
  "Links": [
    {
      "EntityName": "Denesik, Koss and Willms",
      "Id": 984,
      "Description": "Adaptive composite support",
      "ExtraInfo": "vel",
      "LinkId": 310,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "ActiveLinks": 466,
  "Completed": false,
  "NextMilestoneDate": "2007-02-07T15:29:29.9701958+01:00",
  "NmdAppointmentId": 225,
  "EndDate": "2019-10-24T15:29:29.9701958+02:00",
  "ActiveErpLinks": 377,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Mrs. Jackie Bailey"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "maiores"
  },
  "PublishEventDate": "2016-09-08T15:29:29.9706933+02:00",
  "PublishTo": "2016-05-30T15:29:29.9706933+02:00",
  "PublishFrom": "2016-06-28T15:29:29.9706933+02:00",
  "IsPublished": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 591
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```