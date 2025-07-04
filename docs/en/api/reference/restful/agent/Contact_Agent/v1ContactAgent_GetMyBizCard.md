---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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

### Response body: ContactEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 776,
  "Name": "Lebsack Group",
  "Department": "",
  "OrgNr": "525053",
  "Number1": "496776",
  "Number2": "888786",
  "UpdatedDate": "2016-12-08T03:45:23.2017113+01:00",
  "CreatedDate": "1999-01-12T03:45:23.2017113+01:00",
  "Emails": [
    {
      "Value": "vel",
      "StrippedValue": "est",
      "Description": "Robust transitional task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "est",
      "Description": "Robust transitional task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 367
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 308,
      "Name": "Schulist, McGlynn and Feeney",
      "ToolTip": "Sit ex excepturi molestiae qui possimus.",
      "Deleted": false,
      "Rank": 789,
      "Type": "magni",
      "ColorBlock": 192,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2004-12-07T03:45:23.2017113+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "illum",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Mariana Kuvalis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "quod",
      "Description": "Multi-tiered hybrid superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "quod",
      "Description": "Multi-tiered hybrid superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "esse",
      "StrippedValue": "unde",
      "Description": "Implemented disintermediate service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "unde",
      "Description": "Implemented disintermediate service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 932
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "mollitia",
      "Description": "Profound 24 hour Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 434
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "mollitia",
      "Description": "Profound 24 hour Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 434
        }
      }
    }
  ],
  "Description": "Implemented multi-tasking matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "corrupti",
      "PersonId": 442,
      "Mrmrs": "molestiae",
      "Firstname": "Jammie",
      "Lastname": "Yundt",
      "MiddleName": "Hartmann-Mante",
      "Title": "iusto",
      "Description": "Integrated composite orchestration",
      "Email": "deonte@leuschkebrakus.biz",
      "FullName": "Mrs. Garfield Terrence Pollich",
      "DirectPhone": "034.830.6585",
      "FormalName": "Cummerata Inc and Sons",
      "CountryId": 355,
      "ContactId": 142,
      "ContactName": "Ziemann-Haag",
      "Retired": 393,
      "Rank": 339,
      "ActiveInterests": 37,
      "ContactDepartment": "",
      "ContactCountryId": 756,
      "ContactOrgNr": "1487990",
      "FaxPhone": "976.668.6568 x51830",
      "MobilePhone": "506.546.8637 x021",
      "ContactPhone": "1-045-214-8965 x095",
      "AssociateName": "Schaden Inc and Sons",
      "AssociateId": 88,
      "UsePersonAddress": false,
      "ContactFax": "necessitatibus",
      "Kanafname": "error",
      "Kanalname": "omnis",
      "Post1": "est",
      "Post2": "fugiat",
      "Post3": "occaecati",
      "EmailName": "layla.braun@stiedemannschaden.info",
      "ContactFullName": "Hanna Wilderman V",
      "ActiveErpLinks": 431,
      "TicketPriorityId": 55,
      "SupportLanguageId": 830,
      "SupportAssociateId": 774,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1011331",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 602
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "perferendis",
  "Xstop": false,
  "ActiveInterests": 976,
  "GroupId": 507,
  "ActiveStatusMonitorId": 930,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 188,
  "DbiAgentId": 622,
  "DbiLastSyncronized": "2007-05-30T03:45:23.2017113+02:00",
  "DbiKey": "cum",
  "DbiLastModified": "2025-01-05T03:45:23.2017113+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 850,
  "ActiveErpLinks": 623,
  "BounceEmails": [
    "kaylee@mueller.info",
    "emiliano@heathcote.name"
  ],
  "Domains": [
    "est",
    "esse"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1882244587",
    "SuperOffice:2": "Leone Weissnat"
  },
  "ExtraFields": {
    "ExtraFields1": "libero",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "magnam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 282
    }
  }
}
```