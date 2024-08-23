---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 508,
  "Name": "Rowe-Becker",
  "Department": "",
  "OrgNr": "1076408",
  "Number1": "491669",
  "Number2": "907568",
  "UpdatedDate": "2012-08-01T13:28:22.1949288+02:00",
  "CreatedDate": "2012-12-21T13:28:22.1949288+01:00",
  "Emails": [
    {
      "Value": "accusantium",
      "StrippedValue": "vel",
      "Description": "Devolved static pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "vel",
      "Description": "Devolved static pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 961,
      "Name": "Zemlak LLC",
      "ToolTip": "Molestias dolores.",
      "Deleted": false,
      "Rank": 171,
      "Type": "modi",
      "ColorBlock": 605,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2014-08-15T13:28:22.1949288+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fuga",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Miss Kale Murl Kerluke DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 697
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "magnam",
      "Description": "Expanded eco-centric collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "magnam",
      "Description": "Expanded eco-centric collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "rerum",
      "StrippedValue": "enim",
      "Description": "Inverse foreground paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "enim",
      "Description": "Inverse foreground paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 144
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "repellendus",
      "Description": "User-centric assymetric framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "repellendus",
      "Description": "User-centric assymetric framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 952
        }
      }
    }
  ],
  "Description": "Universal contextually-based access",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "numquam",
      "PersonId": 468,
      "Mrmrs": "fuga",
      "Firstname": "Larue",
      "Lastname": "Hilll",
      "MiddleName": "Gislason Inc and Sons",
      "Title": "consequatur",
      "Description": "Phased 3rd generation forecast",
      "Email": "jonathon@bergnaumschimmel.biz",
      "FullName": "Carleton Gottlieb V",
      "DirectPhone": "499-291-3853",
      "FormalName": "Stark, Grady and Bailey",
      "CountryId": 109,
      "ContactId": 129,
      "ContactName": "Hudson Inc and Sons",
      "Retired": 261,
      "Rank": 404,
      "ActiveInterests": 644,
      "ContactDepartment": "",
      "ContactCountryId": 352,
      "ContactOrgNr": "1492043",
      "FaxPhone": "311.504.3188",
      "MobilePhone": "111-698-2044 x2329",
      "ContactPhone": "1-574-034-8475",
      "AssociateName": "Mitchell Inc and Sons",
      "AssociateId": 187,
      "UsePersonAddress": false,
      "ContactFax": "id",
      "Kanafname": "quis",
      "Kanalname": "illum",
      "Post1": "vitae",
      "Post2": "laboriosam",
      "Post3": "harum",
      "EmailName": "claudine_fritsch@feest.biz",
      "ContactFullName": "Audra Weber",
      "ActiveErpLinks": 326,
      "TicketPriorityId": 222,
      "SupportLanguageId": 889,
      "SupportAssociateId": 22,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 134,
  "GroupId": 367,
  "ActiveStatusMonitorId": 111,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 712,
  "DbiAgentId": 675,
  "DbiLastSyncronized": "2003-05-24T13:28:22.2105528+02:00",
  "DbiKey": "molestias",
  "DbiLastModified": "1998-06-05T13:28:22.2105528+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 75,
  "ActiveErpLinks": 143,
  "BounceEmails": [
    "kaci@hane.info",
    "emerson_mcdermott@schmittemmerich.us"
  ],
  "Domains": [
    "rem",
    "expedita"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Emmett Kuphal"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "suscipit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 587
    }
  }
}
```