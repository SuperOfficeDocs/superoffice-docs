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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 18 Jan 2021 23:04:03 G1T

{
  "ContactId": 941,
  "Name": "Christiansen-Keeling",
  "Department": "",
  "OrgNr": "484943",
  "Number1": "1421090",
  "Number2": "931079",
  "UpdatedDate": "2021-01-18T23:04:03.9110204+01:00",
  "CreatedDate": "2021-07-14T23:04:03.9110204+02:00",
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "nostrum",
      "Description": "Programmable disintermediate portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "nostrum",
      "Description": "Programmable disintermediate portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 311,
      "Name": "Roob-White",
      "ToolTip": "Ab sit dolorem fuga unde illum mollitia.",
      "Deleted": false,
      "Rank": 991,
      "Type": "sunt",
      "ColorBlock": 240,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2006-11-18T23:04:03.9110204+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Miss Katrine Rippin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "dolores",
      "Description": "Seamless tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "dolores",
      "Description": "Seamless tertiary capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "culpa",
      "StrippedValue": "nihil",
      "Description": "Function-based heuristic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "nihil",
      "Description": "Function-based heuristic artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "culpa",
      "Description": "Advanced 24/7 groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "culpa",
      "Description": "Advanced 24/7 groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 151
        }
      }
    }
  ],
  "Description": "Operative bi-directional contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dignissimos",
      "PersonId": 405,
      "Mrmrs": "est",
      "Firstname": "Kurtis",
      "Lastname": "Hilll",
      "MiddleName": "Bins Inc and Sons",
      "Title": "quos",
      "Description": "Open-architected fresh-thinking application",
      "Email": "tom_funk@veum.name",
      "FullName": "Emelia Reynolds II",
      "DirectPhone": "(987)779-6311 x579",
      "FormalName": "Bauch Group",
      "CountryId": 94,
      "ContactId": 769,
      "ContactName": "Mayert Group",
      "Retired": 435,
      "Rank": 721,
      "ActiveInterests": 651,
      "ContactDepartment": "",
      "ContactCountryId": 602,
      "ContactOrgNr": "1450738",
      "FaxPhone": "1-958-023-1704 x43019",
      "MobilePhone": "(644)342-0423",
      "ContactPhone": "(742)750-8148",
      "AssociateName": "Gibson, Lehner and Waters",
      "AssociateId": 345,
      "UsePersonAddress": false,
      "ContactFax": "exercitationem",
      "Kanafname": "ea",
      "Kanalname": "eaque",
      "Post1": "unde",
      "Post2": "enim",
      "Post3": "nihil",
      "EmailName": "walter@gradyreichert.info",
      "ContactFullName": "Prof. Alda Beer",
      "ActiveErpLinks": 113,
      "TicketPriorityId": 927,
      "SupportLanguageId": 46,
      "SupportAssociateId": 681,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sapiente",
  "Xstop": true,
  "ActiveInterests": 411,
  "GroupId": 541,
  "ActiveStatusMonitorId": 127,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 283,
  "DbiAgentId": 394,
  "DbiLastSyncronized": "2016-10-17T23:04:03.9160204+02:00",
  "DbiKey": "vero",
  "DbiLastModified": "2007-11-11T23:04:03.9160204+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 157,
  "ActiveErpLinks": 492,
  "BounceEmails": [
    "dolly@cronin.com",
    "patience@cormier.com"
  ],
  "Domains": [
    "nostrum",
    "fugit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Elna Blick",
    "SuperOffice:2": "Prof. Magdalena Williamson"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 108
    }
  }
}
```