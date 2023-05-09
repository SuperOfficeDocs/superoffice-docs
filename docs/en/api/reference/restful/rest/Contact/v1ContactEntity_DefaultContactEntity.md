---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Tue, 15 Jul 2008 03:51:33 G7T

{
  "ContactId": 229,
  "Name": "Botsford Group",
  "Department": "",
  "OrgNr": "558035",
  "Number1": "819642",
  "Number2": "756453",
  "UpdatedDate": "2008-07-15T03:51:33.2710559+02:00",
  "CreatedDate": "2011-12-14T03:51:33.2710559+01:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "excepturi",
      "Description": "Switchable incremental approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "excepturi",
      "Description": "Switchable incremental approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 951,
      "Name": "Goyette, Howell and Streich",
      "ToolTip": "Eaque sunt fuga enim.",
      "Deleted": true,
      "Rank": 241,
      "Type": "consequatur",
      "ColorBlock": 798,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2000-05-02T03:51:33.2710559+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Rossie Swaniawski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 75
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "velit",
      "Description": "Optional next generation methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "velit",
      "Description": "Optional next generation methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sapiente",
      "StrippedValue": "sequi",
      "Description": "Re-contextualized 24/7 architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "sequi",
      "Description": "Re-contextualized 24/7 architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 639
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laboriosam",
      "StrippedValue": "et",
      "Description": "Horizontal human-resource productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "et",
      "Description": "Horizontal human-resource productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 174
        }
      }
    }
  ],
  "Description": "Ergonomic local firmware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "deserunt",
      "PersonId": 24,
      "Mrmrs": "impedit",
      "Firstname": "Mariane",
      "Lastname": "Langworth",
      "MiddleName": "Schumm LLC",
      "Title": "ut",
      "Description": "Vision-oriented clear-thinking superstructure",
      "Email": "daija@gutmann.name",
      "FullName": "Sigurd Smitham",
      "DirectPhone": "317.958.3391",
      "FormalName": "Runolfsdottir-Moore",
      "CountryId": 665,
      "ContactId": 704,
      "ContactName": "Kertzmann LLC",
      "Retired": 474,
      "Rank": 13,
      "ActiveInterests": 947,
      "ContactDepartment": "",
      "ContactCountryId": 736,
      "ContactOrgNr": "713366",
      "FaxPhone": "355.975.4542 x8204",
      "MobilePhone": "1-792-323-8218 x69988",
      "ContactPhone": "970-320-7575 x97353",
      "AssociateName": "Schumm-Strosin",
      "AssociateId": 482,
      "UsePersonAddress": false,
      "ContactFax": "iste",
      "Kanafname": "aut",
      "Kanalname": "officiis",
      "Post1": "quas",
      "Post2": "facere",
      "Post3": "corporis",
      "EmailName": "elisha_swaniawski@mcdermott.name",
      "ContactFullName": "Johnathon Ratke",
      "ActiveErpLinks": 137,
      "TicketPriorityId": 817,
      "SupportLanguageId": 748,
      "SupportAssociateId": 735,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 754
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "rerum",
  "Xstop": true,
  "ActiveInterests": 441,
  "GroupId": 846,
  "ActiveStatusMonitorId": 755,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 278,
  "DbiAgentId": 91,
  "DbiLastSyncronized": "1996-05-29T03:51:33.2710559+02:00",
  "DbiKey": "sit",
  "DbiLastModified": "2006-04-30T03:51:33.2710559+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 951,
  "ActiveErpLinks": 232,
  "BounceEmails": [
    "laury@streicheffertz.info",
    "jaron@brownzboncak.info"
  ],
  "Domains": [
    "quis",
    "accusamus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Anika Flatley",
    "SuperOffice:2": "Elvera Dach"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "delectus",
    "CustomFields2": "nulla"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 756
    }
  }
}
```