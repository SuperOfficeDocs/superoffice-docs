---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 368,
  "Name": "Shanahan Inc and Sons",
  "Department": "",
  "OrgNr": "822139",
  "Number1": "723677",
  "Number2": "1102299",
  "UpdatedDate": "2000-10-17T10:17:55.2696438+02:00",
  "CreatedDate": "2002-02-14T10:17:55.2696438+01:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Mandatory encompassing methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Mandatory encompassing methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 52
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 708,
      "Name": "Oberbrunner-Braun",
      "ToolTip": "Aperiam in ea necessitatibus ea quod.",
      "Deleted": true,
      "Rank": 324,
      "Type": "eaque",
      "ColorBlock": 656,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2000-12-27T10:17:55.2696438+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "eos",
      "Hidden": true,
      "FullName": "Peggie Considine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 373
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ducimus",
      "StrippedValue": "est",
      "Description": "User-centric system-worthy hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    },
    {
      "Value": "ducimus",
      "StrippedValue": "est",
      "Description": "User-centric system-worthy hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quisquam",
      "StrippedValue": "in",
      "Description": "Progressive intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "in",
      "Description": "Progressive intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "omnis",
      "StrippedValue": "nobis",
      "Description": "Automated discrete knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 237
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "nobis",
      "Description": "Automated discrete knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 237
        }
      }
    }
  ],
  "Description": "Devolved object-oriented contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ipsa",
      "PersonId": 566,
      "Mrmrs": "alias",
      "Firstname": "Kieran",
      "Lastname": "Sporer",
      "MiddleName": "Volkman, Shields and Volkman",
      "Title": "iure",
      "Description": "Down-sized 24/7 paradigm",
      "Email": "adrienne_veum@kuhlmankoelpin.ca",
      "FullName": "Leanna Benny Walker MD",
      "DirectPhone": "1-710-964-2547 x73761",
      "FormalName": "Mayert Group",
      "CountryId": 238,
      "ContactId": 435,
      "ContactName": "Shanahan-Tromp",
      "Retired": 110,
      "Rank": 895,
      "ActiveInterests": 425,
      "ContactDepartment": "",
      "ContactCountryId": 555,
      "ContactOrgNr": "1124747",
      "FaxPhone": "220-548-1481 x327",
      "MobilePhone": "1-710-343-1763 x73846",
      "ContactPhone": "(351)135-9083",
      "AssociateName": "Bins Inc and Sons",
      "AssociateId": 236,
      "UsePersonAddress": false,
      "ContactFax": "consequatur",
      "Kanafname": "animi",
      "Kanalname": "repudiandae",
      "Post1": "qui",
      "Post2": "veniam",
      "Post3": "fugiat",
      "EmailName": "colton_rohan@fisher.info",
      "ContactFullName": "Kraig Feil Jr.",
      "ActiveErpLinks": 874,
      "TicketPriorityId": 547,
      "SupportLanguageId": 778,
      "SupportAssociateId": 914,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 784
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "porro",
  "Xstop": false,
  "ActiveInterests": 367,
  "GroupId": 941,
  "ActiveStatusMonitorId": 653,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 373,
  "DbiAgentId": 945,
  "DbiLastSyncronized": "2021-07-07T10:17:55.2696438+02:00",
  "DbiKey": "praesentium",
  "DbiLastModified": "2006-12-01T10:17:55.2696438+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 1000,
  "ActiveErpLinks": 932,
  "BounceEmails": [
    "lavonne.fahey@muellerromaguera.co.uk",
    "josephine.ernser@toymayer.info"
  ],
  "Domains": [
    "assumenda",
    "sapiente"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Arnulfo Newton McGlynn PhD",
    "SuperOffice:2": "Marcella Mohr"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "illum"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "voluptate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 772
    }
  }
}
```