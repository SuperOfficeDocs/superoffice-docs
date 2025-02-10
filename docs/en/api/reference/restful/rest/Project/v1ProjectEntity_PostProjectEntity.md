---
title: POST Project
uid: v1ProjectEntity_PostProjectEntity
generated: true
---

# POST Project

```http
POST /api/v1/Project
```

Creates a new ProjectEntity


Calls the Project agent service SaveProjectEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Project?$select=name,department,category/id
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

## Request Body: newEntity 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Project
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 510,
  "Name": "Torp LLC",
  "ProjectNumber": "865915",
  "ProjectMembers": [
    {
      "ProjectmemberId": 161,
      "ContactId": 279,
      "ProjectId": 849,
      "ContactName": "Waelchi, Dare and O'Conner",
      "ContactDepartment": "",
      "ProjectName": "Hudson-Bartell",
      "EmailId": 897,
      "EmailAddress": "dalton.mcclure@kunzewolff.name",
      "CountryId": 978,
      "Firstname": "Daniela",
      "MiddleName": "Schultz, Jacobs and Smith",
      "Lastname": "Runolfsdottir",
      "PersonId": 646,
      "Mrmrs": "excepturi",
      "ProjectMemberTypeName": "Hegmann LLC",
      "Phone": "289.470.7154 x87799",
      "PhoneId": 614,
      "ProjectMemberTypeId": 11,
      "EmailAddressName": "eli@ward.co.uk",
      "Comment": "earum",
      "FullName": "Prof. Norval Darrel Hayes"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Synergistic national knowledge user"
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Synergistic national knowledge user"
    }
  ],
  "CreatedDate": "2021-01-19T12:01:32.9956921+01:00",
  "UpdatedDate": "2014-06-22T12:01:32.9956921+02:00",
  "Description": "Persevering didactic framework",
  "Postit": "sed",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Integrated upward-trending encoding",
  "ActiveStatusMonitorId": 939,
  "Links": [
    {
      "EntityName": "Stroman LLC",
      "Id": 226,
      "Description": "Managed systemic solution",
      "ExtraInfo": "dolores",
      "LinkId": 626
    },
    {
      "EntityName": "Stroman LLC",
      "Id": 226,
      "Description": "Managed systemic solution",
      "ExtraInfo": "dolores",
      "LinkId": 626
    }
  ],
  "ActiveLinks": 774,
  "Completed": false,
  "NextMilestoneDate": "2014-01-28T12:01:32.9956921+01:00",
  "NmdAppointmentId": 545,
  "EndDate": "2019-02-25T12:01:32.9956921+01:00",
  "ActiveErpLinks": 394,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "551729652"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "quia"
  },
  "PublishEventDate": "2017-07-20T12:01:32.9956921+02:00",
  "PublishTo": "2018-08-29T12:01:32.9956921+02:00",
  "PublishFrom": "2014-09-15T12:01:32.9956921+02:00",
  "IsPublished": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 265,
  "Name": "Kerluke Inc and Sons",
  "ProjectNumber": "1315901",
  "ProjectMembers": [
    {
      "ProjectmemberId": 338,
      "ContactId": 187,
      "ProjectId": 508,
      "ContactName": "Conn Group",
      "ContactDepartment": "",
      "ProjectName": "Berge Group",
      "EmailId": 563,
      "EmailAddress": "al_nicolas@mertz.info",
      "CountryId": 953,
      "Firstname": "Fritz",
      "MiddleName": "Hills Inc and Sons",
      "Lastname": "Wyman",
      "PersonId": 354,
      "Mrmrs": "non",
      "ProjectMemberTypeName": "Bergstrom LLC",
      "Phone": "(672)831-8626",
      "PhoneId": 208,
      "ProjectMemberTypeId": 313,
      "EmailAddressName": "cecile@hauck.name",
      "Comment": "doloremque",
      "FullName": "Verna Waters",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 51
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "temporibus",
      "Description": "Persevering national toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "temporibus",
      "Description": "Persevering national toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 170
        }
      }
    }
  ],
  "CreatedDate": "2017-04-14T12:01:32.9956921+02:00",
  "UpdatedDate": "2006-08-21T12:01:32.9956921+02:00",
  "Description": "Team-oriented hybrid monitoring",
  "Postit": "voluptas",
  "CreatedBy": null,
  "UpdatedBy": null,
  "Associate": null,
  "ProjectStatus": null,
  "ProjectType": null,
  "HasImage": false,
  "ImageDescription": "Virtual didactic encoding",
  "ActiveStatusMonitorId": 178,
  "Links": [
    {
      "EntityName": "Gulgowski Group",
      "Id": 860,
      "Description": "Enterprise-wide homogeneous forecast",
      "ExtraInfo": "similique",
      "LinkId": 701,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 471
        }
      }
    }
  ],
  "ActiveLinks": 242,
  "Completed": true,
  "NextMilestoneDate": "2000-06-19T12:01:32.9956921+02:00",
  "NmdAppointmentId": 337,
  "EndDate": "2007-12-06T12:01:32.9956921+01:00",
  "ActiveErpLinks": 686,
  "UserDefinedFields": {
    "SuperOffice:1": "Sunny Kuphal",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "illum"
  },
  "PublishEventDate": "2003-11-30T12:01:32.9956921+01:00",
  "PublishTo": "2012-06-04T12:01:32.9956921+02:00",
  "PublishFrom": "2002-03-10T12:01:32.9956921+01:00",
  "IsPublished": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 189
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```