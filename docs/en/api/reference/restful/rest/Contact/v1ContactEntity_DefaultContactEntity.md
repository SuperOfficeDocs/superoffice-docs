---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 07 Mar 2021 17:54:08 G3T

{
  "ContactId": 353,
  "Name": "Considine Inc and Sons",
  "Department": "",
  "OrgNr": "823038",
  "Number1": "1247815",
  "Number2": "1692224",
  "UpdatedDate": "2021-03-07T17:54:08.0699594+01:00",
  "CreatedDate": "2023-10-17T17:54:08.0699594+02:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised analyzing orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised analyzing orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 218,
      "Name": "Wisoky-Bailey",
      "ToolTip": "Nam tempore ab et sapiente vel dolore molestias.",
      "Deleted": false,
      "Rank": 362,
      "Type": "et",
      "ColorBlock": 404,
      "IconHint": "beatae",
      "Selected": false,
      "LastChanged": "2022-02-14T17:54:08.0699594+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Abe Kihn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 810
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repellat",
      "StrippedValue": "debitis",
      "Description": "Focused background Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "debitis",
      "Description": "Focused background Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cum",
      "StrippedValue": "et",
      "Description": "Object-based next generation paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 510
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "et",
      "Description": "Object-based next generation paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 510
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "id",
      "Description": "Operative heuristic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "id",
      "Description": "Operative heuristic analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "Description": "Advanced tangible pricing structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 88,
      "Mrmrs": "perspiciatis",
      "Firstname": "Delia",
      "Lastname": "Dickinson",
      "MiddleName": "Wolff, Schoen and Kohler",
      "Title": "suscipit",
      "Description": "User-centric 6th generation migration",
      "Email": "kris_oconner@volkmangleason.co.uk",
      "FullName": "Miss Javier Niko Nikolaus",
      "DirectPhone": "(309)210-8244 x70676",
      "FormalName": "Barrows Inc and Sons",
      "CountryId": 19,
      "ContactId": 619,
      "ContactName": "Kihn Inc and Sons",
      "Retired": 660,
      "Rank": 636,
      "ActiveInterests": 61,
      "ContactDepartment": "",
      "ContactCountryId": 864,
      "ContactOrgNr": "1271326",
      "FaxPhone": "1-598-271-4998 x196",
      "MobilePhone": "515.950.9569 x06467",
      "ContactPhone": "335.590.0951 x8619",
      "AssociateName": "Braun-Walter",
      "AssociateId": 130,
      "UsePersonAddress": false,
      "ContactFax": "expedita",
      "Kanafname": "illum",
      "Kanalname": "reprehenderit",
      "Post1": "vitae",
      "Post2": "dolores",
      "Post3": "non",
      "EmailName": "stan@considine.uk",
      "ContactFullName": "Henderson Adams",
      "ActiveErpLinks": 230,
      "TicketPriorityId": 264,
      "SupportLanguageId": 88,
      "SupportAssociateId": 951,
      "CategoryName": "VIP Customer",
      "PersonNumber": "544541",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 569
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "provident",
  "Xstop": true,
  "ActiveInterests": 301,
  "GroupId": 348,
  "ActiveStatusMonitorId": 727,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 772,
  "DbiAgentId": 296,
  "DbiLastSyncronized": "2005-11-29T17:54:08.0699594+01:00",
  "DbiKey": "iste",
  "DbiLastModified": "2022-01-29T17:54:08.0699594+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 865,
  "ActiveErpLinks": 498,
  "BounceEmails": [
    "axel_green@trantow.info",
    "christelle@graham.us"
  ],
  "Domains": [
    "dolore",
    "molestiae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Watson Jast",
    "SuperOffice:2": "718411320"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "expedita",
    "CustomFields2": "quisquam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 385
    }
  }
}
```