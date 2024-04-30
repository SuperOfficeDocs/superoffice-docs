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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 913,
  "Name": "Morissette, Heathcote and Reynolds",
  "Department": "",
  "OrgNr": "1038699",
  "Number1": "1942513",
  "Number2": "1332363",
  "UpdatedDate": "2018-05-01T11:44:33.0254682+02:00",
  "CreatedDate": "1997-08-07T11:44:33.0254682+02:00",
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "sequi",
      "Description": "Inverse well-modulated hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "sequi",
      "Description": "Inverse well-modulated hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 130
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 846,
      "Name": "Rowe-Spinka",
      "ToolTip": "Dolores blanditiis vitae dolor possimus hic.",
      "Deleted": false,
      "Rank": 850,
      "Type": "nam",
      "ColorBlock": 679,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2002-06-13T11:44:33.0254682+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "blanditiis",
      "Hidden": false,
      "FullName": "Prof. Santa Cummerata",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "soluta",
      "Description": "Synchronised responsive methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "soluta",
      "Description": "Synchronised responsive methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 719
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "eveniet",
      "Description": "Cloned dynamic open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 960
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "eveniet",
      "Description": "Cloned dynamic open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 960
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "voluptas",
      "Description": "Exclusive reciprocal projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "voluptas",
      "Description": "Exclusive reciprocal projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "Description": "Fundamental impactful migration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "repellendus",
      "PersonId": 922,
      "Mrmrs": "laboriosam",
      "Firstname": "Anya",
      "Lastname": "Buckridge",
      "MiddleName": "Rutherford, Harris and Labadie",
      "Title": "est",
      "Description": "Total reciprocal customer loyalty",
      "Email": "violet@faymacejkovic.co.uk",
      "FullName": "Jonathon Kemmer",
      "DirectPhone": "230.880.8660 x80613",
      "FormalName": "Heaney, Doyle and Feil",
      "CountryId": 259,
      "ContactId": 579,
      "ContactName": "Sauer LLC",
      "Retired": 513,
      "Rank": 232,
      "ActiveInterests": 670,
      "ContactDepartment": "",
      "ContactCountryId": 654,
      "ContactOrgNr": "714060",
      "FaxPhone": "(861)138-9045 x5973",
      "MobilePhone": "1-743-748-5238 x4203",
      "ContactPhone": "182.180.4991 x26001",
      "AssociateName": "Von-Bednar",
      "AssociateId": 215,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "maxime",
      "Kanalname": "ullam",
      "Post1": "ut",
      "Post2": "eaque",
      "Post3": "consequuntur",
      "EmailName": "benedict@aufderharwitting.uk",
      "ContactFullName": "Mr. Rosella Collier I",
      "ActiveErpLinks": 377,
      "TicketPriorityId": 193,
      "SupportLanguageId": 831,
      "SupportAssociateId": 688,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolor",
  "Xstop": false,
  "ActiveInterests": 528,
  "GroupId": 792,
  "ActiveStatusMonitorId": 797,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 238,
  "DbiAgentId": 267,
  "DbiLastSyncronized": "2016-08-17T11:44:33.0254682+02:00",
  "DbiKey": "saepe",
  "DbiLastModified": "1997-04-02T11:44:33.0254682+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 282,
  "ActiveErpLinks": 257,
  "BounceEmails": [
    "nya@fisher.name",
    "gianni@manteharris.biz"
  ],
  "Domains": [
    "facilis",
    "magnam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Herbert Bartoletti",
    "SuperOffice:2": "Rosalia Williamson"
  },
  "ExtraFields": {
    "ExtraFields1": "velit",
    "ExtraFields2": "atque"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 797
    }
  }
}
```