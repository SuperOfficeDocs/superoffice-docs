---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
content_type: reference
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.
NsApiSlow threshold: 2000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 02 Jun 2025 03:40:55 G6T

{
  "ContactId": 4,
  "Name": "Koch LLC",
  "Department": "",
  "OrgNr": "938678",
  "Number1": "936716",
  "Number2": "665402",
  "UpdatedDate": "2025-06-02T03:40:55.4599408+02:00",
  "CreatedDate": "2005-10-15T03:40:55.4599408+02:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "est",
      "Description": "Synergistic stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 368
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "est",
      "Description": "Synergistic stable framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 368
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 503,
      "Name": "Homenick LLC",
      "ToolTip": "Dolorum qui a cumque nesciunt.",
      "Deleted": false,
      "Rank": 46,
      "Type": "quidem",
      "ColorBlock": 462,
      "IconHint": "cupiditate",
      "Selected": true,
      "LastChanged": "2008-09-12T03:40:55.4755673+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "nisi",
      "Hidden": false,
      "FullName": "Mr. Candida Schaden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 538
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "doloremque",
      "StrippedValue": "vitae",
      "Description": "Persevering grid-enabled solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "vitae",
      "Description": "Persevering grid-enabled solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 967
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ratione",
      "StrippedValue": "ab",
      "Description": "Expanded optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "ab",
      "Description": "Expanded optimizing data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 565
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vitae",
      "StrippedValue": "assumenda",
      "Description": "Monitored 24/7 process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "assumenda",
      "Description": "Monitored 24/7 process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 171
        }
      }
    }
  ],
  "Description": "Progressive secondary product",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorem",
      "PersonId": 572,
      "Mrmrs": "quas",
      "Firstname": "Roxanne",
      "Lastname": "Tromp",
      "MiddleName": "Mueller-Sporer",
      "Title": "magnam",
      "Description": "Reduced demand-driven success",
      "Email": "lee@sporer.info",
      "FullName": "Hillard Gutkowski V",
      "DirectPhone": "477-455-4108 x70631",
      "FormalName": "Batz, Rogahn and Ondricka",
      "CountryId": 21,
      "ContactId": 350,
      "ContactName": "Rosenbaum, Reilly and Littel",
      "Retired": 403,
      "Rank": 121,
      "ActiveInterests": 339,
      "ContactDepartment": "brand seamless web-readiness",
      "ContactCountryId": 73,
      "ContactOrgNr": "1080366",
      "FaxPhone": "578.863.2958 x3535",
      "MobilePhone": "(938)108-2838 x82397",
      "ContactPhone": "(098)185-8024 x7555",
      "AssociateName": "Anderson, Considine and Reynolds",
      "AssociateId": 423,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "debitis",
      "Kanalname": "facere",
      "Post1": "sunt",
      "Post2": "dolorem",
      "Post3": "neque",
      "EmailName": "geo@bergstrom.name",
      "ContactFullName": "Seth Julio Larkin MD",
      "ActiveErpLinks": 142,
      "TicketPriorityId": 773,
      "SupportLanguageId": 984,
      "SupportAssociateId": 488,
      "CategoryName": "VIP Customer",
      "PersonNumber": "906130",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "impedit",
  "Xstop": false,
  "ActiveInterests": 922,
  "GroupId": 825,
  "ActiveStatusMonitorId": 371,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 261,
  "DbiAgentId": 791,
  "DbiLastSyncronized": "2013-10-19T03:40:55.4755673+02:00",
  "DbiKey": "libero",
  "DbiLastModified": "2009-01-21T03:40:55.4755673+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 639,
  "ActiveErpLinks": 120,
  "BounceEmails": [
    "selina_gerhold@kingframi.biz",
    "yasmin_pacocha@dubuqueschiller.biz"
  ],
  "Domains": [
    "assumenda",
    "quasi"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Alice Jakubowski III",
    "SuperOffice:2": "Susie Aufderhar"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "minus"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 574
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```