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
  "ContactId": 644,
  "Name": "Predovic-Kulas",
  "Department": "",
  "OrgNr": "842495",
  "Number1": "1278301",
  "Number2": "74901",
  "UpdatedDate": "2018-06-17T03:31:25.8384743+02:00",
  "CreatedDate": "2013-04-07T03:31:25.8384743+02:00",
  "Emails": [
    {
      "Value": "asperiores",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised responsive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised responsive workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 988,
      "Name": "Ritchie-Boyer",
      "ToolTip": "Sunt possimus eos qui libero earum iure.",
      "Deleted": true,
      "Rank": 831,
      "Type": "aut",
      "ColorBlock": 407,
      "IconHint": "adipisci",
      "Selected": true,
      "LastChanged": "2005-02-27T03:31:25.8384743+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "cumque",
      "Hidden": true,
      "FullName": "Melvin Monahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 993
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "aperiam",
      "Description": "Function-based human-resource benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "aperiam",
      "Description": "Function-based human-resource benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 998
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illum",
      "StrippedValue": "autem",
      "Description": "Extended real-time core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "autem",
      "Description": "Extended real-time core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "corrupti",
      "Description": "Enterprise-wide even-keeled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "corrupti",
      "Description": "Enterprise-wide even-keeled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 212
        }
      }
    }
  ],
  "Description": "Monitored leading edge moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vero",
      "PersonId": 830,
      "Mrmrs": "libero",
      "Firstname": "Asha",
      "Lastname": "Windler",
      "MiddleName": "Satterfield LLC",
      "Title": "qui",
      "Description": "Managed next generation collaboration",
      "Email": "albertha.price@jastwunsch.uk",
      "FullName": "Juliana Wyman",
      "DirectPhone": "460.939.8705",
      "FormalName": "Grimes Group",
      "CountryId": 658,
      "ContactId": 830,
      "ContactName": "Wintheiser Group",
      "Retired": 920,
      "Rank": 621,
      "ActiveInterests": 653,
      "ContactDepartment": "",
      "ContactCountryId": 463,
      "ContactOrgNr": "640475",
      "FaxPhone": "528.336.2169 x54763",
      "MobilePhone": "110.704.6054",
      "ContactPhone": "(280)136-4312 x0822",
      "AssociateName": "Bosco LLC",
      "AssociateId": 556,
      "UsePersonAddress": false,
      "ContactFax": "consequuntur",
      "Kanafname": "porro",
      "Kanalname": "sapiente",
      "Post1": "sed",
      "Post2": "nihil",
      "Post3": "quaerat",
      "EmailName": "helen@hudson.com",
      "ContactFullName": "Mrs. Axel Hessel",
      "ActiveErpLinks": 66,
      "TicketPriorityId": 648,
      "SupportLanguageId": 558,
      "SupportAssociateId": 552,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "eum",
  "Xstop": true,
  "ActiveInterests": 739,
  "GroupId": 758,
  "ActiveStatusMonitorId": 376,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 203,
  "DbiAgentId": 776,
  "DbiLastSyncronized": "2020-01-29T03:31:25.8384743+01:00",
  "DbiKey": "eum",
  "DbiLastModified": "2011-09-14T03:31:25.8384743+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 621,
  "ActiveErpLinks": 267,
  "BounceEmails": [
    "fritz@schmitt.info",
    "corrine_casper@lebsacklangosh.uk"
  ],
  "Domains": [
    "veritatis",
    "iusto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Derek Crona",
    "SuperOffice:2": "1996435860"
  },
  "ExtraFields": {
    "ExtraFields1": "dignissimos",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 975
    }
  }
}
```