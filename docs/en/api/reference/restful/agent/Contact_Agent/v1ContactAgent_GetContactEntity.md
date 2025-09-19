---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The identifier of the ContactEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=897
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 268,
  "Name": "Conroy Group",
  "Department": "",
  "OrgNr": "1000648",
  "Number1": "491706",
  "Number2": "1255645",
  "UpdatedDate": "2023-07-02T03:41:53.2619943+02:00",
  "CreatedDate": "2018-11-20T03:41:53.2619943+01:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "harum",
      "Description": "Horizontal encompassing orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 41
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "harum",
      "Description": "Horizontal encompassing orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 41
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 369,
      "Name": "Sauer, Konopelski and Bode",
      "ToolTip": "Dolor reprehenderit excepturi voluptatem dolorem aut.",
      "Deleted": true,
      "Rank": 865,
      "Type": "aut",
      "ColorBlock": 8,
      "IconHint": "inventore",
      "Selected": false,
      "LastChanged": "2008-03-16T03:41:53.2619943+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repellat",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Rosella Mayert I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "harum",
      "StrippedValue": "facere",
      "Description": "Re-contextualized 3rd generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "facere",
      "Description": "Re-contextualized 3rd generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 614
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "accusantium",
      "StrippedValue": "consequatur",
      "Description": "Managed systemic website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "consequatur",
      "Description": "Managed systemic website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 450
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sunt",
      "StrippedValue": "quia",
      "Description": "Fully-configurable methodical secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "quia",
      "Description": "Fully-configurable methodical secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "Description": "Polarised assymetric analyzer",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "libero",
      "PersonId": 371,
      "Mrmrs": "vel",
      "Firstname": "Loma",
      "Lastname": "Zemlak",
      "MiddleName": "Schmidt LLC",
      "Title": "iste",
      "Description": "Re-engineered leading edge synergy",
      "Email": "melba_greenholt@nader.com",
      "FullName": "Jessika Hagenes",
      "DirectPhone": "1-876-828-0026",
      "FormalName": "Kunde, Lynch and Kshlerin",
      "CountryId": 550,
      "ContactId": 836,
      "ContactName": "Legros, Deckow and Oberbrunner",
      "Retired": 386,
      "Rank": 616,
      "ActiveInterests": 171,
      "ContactDepartment": "",
      "ContactCountryId": 532,
      "ContactOrgNr": "442716",
      "FaxPhone": "1-535-396-6244 x976",
      "MobilePhone": "994-103-2415",
      "ContactPhone": "1-098-274-3900 x2027",
      "AssociateName": "Leffler LLC",
      "AssociateId": 537,
      "UsePersonAddress": false,
      "ContactFax": "iusto",
      "Kanafname": "doloribus",
      "Kanalname": "possimus",
      "Post1": "dolorem",
      "Post2": "molestiae",
      "Post3": "at",
      "EmailName": "gracie.pfannerstill@lemkewelch.uk",
      "ContactFullName": "Fleta Hane",
      "ActiveErpLinks": 168,
      "TicketPriorityId": 242,
      "SupportLanguageId": 955,
      "SupportAssociateId": 431,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1054346",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 136
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "illum",
  "Xstop": true,
  "ActiveInterests": 860,
  "GroupId": 635,
  "ActiveStatusMonitorId": 189,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 686,
  "DbiAgentId": 562,
  "DbiLastSyncronized": "2018-11-03T03:41:53.2619943+01:00",
  "DbiKey": "ut",
  "DbiLastModified": "2004-01-23T03:41:53.2619943+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 209,
  "ActiveErpLinks": 15,
  "BounceEmails": [
    "blair_lakin@feeneycrona.ca",
    "valentine_johnston@ziemann.uk"
  ],
  "Domains": [
    "eligendi",
    "ipsa"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Emilie Fadel",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "ratione"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "at"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 76
    }
  }
}
```