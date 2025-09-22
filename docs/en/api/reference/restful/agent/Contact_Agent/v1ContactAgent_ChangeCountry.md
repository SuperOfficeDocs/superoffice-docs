---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
content_type: reference
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

## Request Body: request 

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 612
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 63,
  "Name": "Senger LLC",
  "Department": "",
  "OrgNr": "1326043",
  "Number1": "245185",
  "Number2": "1427719",
  "UpdatedDate": "2001-02-23T11:24:47.7970448+01:00",
  "CreatedDate": "2003-04-29T11:24:47.7970448+02:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "nobis",
      "Description": "Enterprise-wide tertiary conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "nobis",
      "Description": "Enterprise-wide tertiary conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 414,
      "Name": "Streich Group",
      "ToolTip": "Dolorum repellat dolor qui harum facere quos.",
      "Deleted": true,
      "Rank": 381,
      "Type": "accusantium",
      "ColorBlock": 247,
      "IconHint": "illum",
      "Selected": true,
      "LastChanged": "2019-02-22T11:24:47.7970448+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Alanis Rippin",
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
      "Value": "sit",
      "StrippedValue": "numquam",
      "Description": "Fully-configurable 5th generation task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "numquam",
      "Description": "Fully-configurable 5th generation task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 761
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "dicta",
      "Description": "Secured interactive standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "dicta",
      "Description": "Secured interactive standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 158
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusantium",
      "StrippedValue": "cum",
      "Description": "Upgradable responsive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "cum",
      "Description": "Upgradable responsive application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 496
        }
      }
    }
  ],
  "Description": "Stand-alone grid-enabled portal",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ab",
      "PersonId": 451,
      "Mrmrs": "minus",
      "Firstname": "Bridie",
      "Lastname": "Steuber",
      "MiddleName": "Ruecker, Zemlak and Dach",
      "Title": "voluptatibus",
      "Description": "Reduced stable analyzer",
      "Email": "jules@considinecassin.ca",
      "FullName": "Gerda Rolfson",
      "DirectPhone": "135-640-8498",
      "FormalName": "Mosciski, Heidenreich and Feeney",
      "CountryId": 300,
      "ContactId": 923,
      "ContactName": "Beier-Huel",
      "Retired": 298,
      "Rank": 813,
      "ActiveInterests": 847,
      "ContactDepartment": "",
      "ContactCountryId": 457,
      "ContactOrgNr": "1121333",
      "FaxPhone": "(801)101-1247",
      "MobilePhone": "374-030-8252",
      "ContactPhone": "(350)957-9454",
      "AssociateName": "Krajcik Inc and Sons",
      "AssociateId": 322,
      "UsePersonAddress": false,
      "ContactFax": "labore",
      "Kanafname": "et",
      "Kanalname": "quidem",
      "Post1": "asperiores",
      "Post2": "maxime",
      "Post3": "eum",
      "EmailName": "jana.deckow@schinnergraham.name",
      "ContactFullName": "Mrs. Laurel Cole",
      "ActiveErpLinks": 268,
      "TicketPriorityId": 509,
      "SupportLanguageId": 304,
      "SupportAssociateId": 451,
      "CategoryName": "VIP Customer",
      "PersonNumber": "919595",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "error",
  "Xstop": true,
  "ActiveInterests": 283,
  "GroupId": 501,
  "ActiveStatusMonitorId": 471,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 328,
  "DbiAgentId": 479,
  "DbiLastSyncronized": "2010-06-20T11:24:47.7970448+02:00",
  "DbiKey": "autem",
  "DbiLastModified": "1999-03-25T11:24:47.7970448+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 277,
  "ActiveErpLinks": 686,
  "BounceEmails": [
    "declan.douglas@kuvalishirthe.info",
    "melissa@gleichner.info"
  ],
  "Domains": [
    "ut",
    "sint"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1490523721",
    "SuperOffice:2": "2106969686"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "iure"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 730
    }
  }
}
```