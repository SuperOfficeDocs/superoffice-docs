---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=906
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 599,
  "Name": "Erdman, Nienow and Haley",
  "Department": "",
  "OrgNr": "462133",
  "Number1": "775737",
  "Number2": "1102565",
  "UpdatedDate": "2004-01-25T13:13:22.3988933+01:00",
  "CreatedDate": "2022-10-26T13:13:22.3988933+02:00",
  "Emails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "odio",
      "Description": "Mandatory tangible local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "odio",
      "Description": "Mandatory tangible local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 655,
      "Name": "Dicki, Abshire and Tillman",
      "ToolTip": "Quasi eos quod.",
      "Deleted": false,
      "Rank": 538,
      "Type": "necessitatibus",
      "ColorBlock": 947,
      "IconHint": "impedit",
      "Selected": false,
      "LastChanged": "2017-09-23T13:13:22.3988933+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "quis",
      "Hidden": true,
      "FullName": "Amara Rogahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 886
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "libero",
      "StrippedValue": "itaque",
      "Description": "Horizontal client-server migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "itaque",
      "Description": "Horizontal client-server migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 850
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "laudantium",
      "Description": "Reverse-engineered national initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "laudantium",
      "Description": "Reverse-engineered national initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "sunt",
      "Description": "Networked homogeneous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 863
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "sunt",
      "Description": "Networked homogeneous paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 863
        }
      }
    }
  ],
  "Description": "Object-based intangible secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 21,
      "Mrmrs": "ab",
      "Firstname": "Adrian",
      "Lastname": "Ratke",
      "MiddleName": "Berge-Gulgowski",
      "Title": "ducimus",
      "Description": "Distributed bi-directional function",
      "Email": "amya_kunde@champlinweimann.us",
      "FullName": "Jacey Ross Bernier DVM",
      "DirectPhone": "275-078-5171 x87959",
      "FormalName": "Corkery-Little",
      "CountryId": 342,
      "ContactId": 213,
      "ContactName": "Bins, Quigley and Walker",
      "Retired": 526,
      "Rank": 998,
      "ActiveInterests": 893,
      "ContactDepartment": "",
      "ContactCountryId": 562,
      "ContactOrgNr": "1212071",
      "FaxPhone": "847-553-1365",
      "MobilePhone": "693-674-0249 x2337",
      "ContactPhone": "(565)969-5248 x01458",
      "AssociateName": "Weimann, Moen and Barton",
      "AssociateId": 825,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "reiciendis",
      "Kanalname": "consequatur",
      "Post1": "quam",
      "Post2": "ullam",
      "Post3": "delectus",
      "EmailName": "kelli@wunsch.ca",
      "ContactFullName": "Al Hickle",
      "ActiveErpLinks": 385,
      "TicketPriorityId": 150,
      "SupportLanguageId": 517,
      "SupportAssociateId": 219,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "adipisci",
  "Xstop": false,
  "ActiveInterests": 501,
  "GroupId": 565,
  "ActiveStatusMonitorId": 493,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 599,
  "DbiAgentId": 625,
  "DbiLastSyncronized": "2024-05-26T13:13:22.3988933+02:00",
  "DbiKey": "quis",
  "DbiLastModified": "2011-12-08T13:13:22.3988933+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 330,
  "ActiveErpLinks": 331,
  "BounceEmails": [
    "caesar@hueloconnell.biz",
    "elody.bradtke@wisozk.com"
  ],
  "Domains": [
    "quia",
    "officia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "298438857"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "explicabo",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 357
    }
  }
}
```