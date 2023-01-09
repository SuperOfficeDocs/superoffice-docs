---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 950,
  "Name": "Conroy Group",
  "Department": "",
  "OrgNr": "376756",
  "Number1": "845447",
  "Number2": "1103068",
  "UpdatedDate": "2007-09-26T17:37:17.1482418+02:00",
  "CreatedDate": "2013-04-19T17:37:17.1492416+02:00",
  "Emails": [
    {
      "Value": "ipsam",
      "StrippedValue": "delectus",
      "Description": "Monitored hybrid success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "delectus",
      "Description": "Monitored hybrid success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 185
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 682,
      "Name": "Dibbert-Goyette",
      "ToolTip": "Mollitia et quia ut accusamus.",
      "Deleted": true,
      "Rank": 894,
      "Type": "tenetur",
      "ColorBlock": 490,
      "IconHint": "at",
      "Selected": true,
      "LastChanged": "2000-10-04T17:37:17.1492416+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "distinctio",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Ms. Madisen Dickinson III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "rerum",
      "Description": "Universal disintermediate time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "rerum",
      "Description": "Universal disintermediate time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "error",
      "Description": "Operative assymetric hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "error",
      "Description": "Operative assymetric hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 620
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ratione",
      "StrippedValue": "quam",
      "Description": "Programmable client-server function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "quam",
      "Description": "Programmable client-server function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 944
        }
      }
    }
  ],
  "Description": "De-engineered client-server capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 777,
      "Mrmrs": "doloremque",
      "Firstname": "Vicky",
      "Lastname": "Brekke",
      "MiddleName": "Huels Group",
      "Title": "aut",
      "Description": "Profound system-worthy migration",
      "Email": "emily_beer@shields.info",
      "FullName": "Maude Sporer",
      "DirectPhone": "726.185.9141 x817",
      "FormalName": "McKenzie, Jerde and Fisher",
      "CountryId": 411,
      "ContactId": 287,
      "ContactName": "Adams-Blanda",
      "Retired": 841,
      "Rank": 98,
      "ActiveInterests": 874,
      "ContactDepartment": "",
      "ContactCountryId": 428,
      "ContactOrgNr": "1754900",
      "FaxPhone": "418-614-7545 x7529",
      "MobilePhone": "283.200.6260 x8006",
      "ContactPhone": "450-085-5102",
      "AssociateName": "Konopelski LLC",
      "AssociateId": 452,
      "UsePersonAddress": false,
      "ContactFax": "veritatis",
      "Kanafname": "porro",
      "Kanalname": "sit",
      "Post1": "magnam",
      "Post2": "doloremque",
      "Post3": "sit",
      "EmailName": "rosamond@hoegerstokes.ca",
      "ContactFullName": "Miss Branson Jaren Ledner Jr.",
      "ActiveErpLinks": 638,
      "TicketPriorityId": 875,
      "SupportLanguageId": 130,
      "SupportAssociateId": 59,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 622,
  "GroupId": 638,
  "ActiveStatusMonitorId": 624,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 832,
  "DbiAgentId": 452,
  "DbiLastSyncronized": "2018-10-29T17:37:17.1532435+01:00",
  "DbiKey": "consequatur",
  "DbiLastModified": "2011-12-03T17:37:17.1532435+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 157,
  "ActiveErpLinks": 519,
  "BounceEmails": [
    "durward_witting@jenkins.uk",
    "rigoberto@oconner.com"
  ],
  "Domains": [
    "nesciunt",
    "a"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1201852969",
    "SuperOffice:2": "Mara Mosciski"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "praesentium"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 702
    }
  }
}
```