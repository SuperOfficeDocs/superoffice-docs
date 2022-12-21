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

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 675,
  "Name": "Reynolds LLC",
  "Department": "transform end-to-end portals",
  "OrgNr": "1442818",
  "Number1": "401735",
  "Number2": "1115858",
  "UpdatedDate": "2020-06-19T02:49:43.8722795+02:00",
  "CreatedDate": "1996-08-25T02:49:43.8722795+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Centralized national neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Centralized national neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 508,
      "Name": "Eichmann-Graham",
      "ToolTip": "Non iure.",
      "Deleted": true,
      "Rank": 951,
      "Type": "sit",
      "ColorBlock": 310,
      "IconHint": "facere",
      "Selected": false,
      "LastChanged": "2013-02-16T02:49:43.8722795+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Ms. Mariano Sam Douglas Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "asperiores",
      "StrippedValue": "nihil",
      "Description": "Polarised disintermediate structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 362
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "nihil",
      "Description": "Polarised disintermediate structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 362
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "esse",
      "StrippedValue": "id",
      "Description": "Re-contextualized actuating orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "id",
      "Description": "Re-contextualized actuating orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quasi",
      "StrippedValue": "accusantium",
      "Description": "Versatile logistical application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "accusantium",
      "Description": "Versatile logistical application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 316
        }
      }
    }
  ],
  "Description": "Sharable dynamic benchmark",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "culpa",
      "PersonId": 793,
      "Mrmrs": "impedit",
      "Firstname": "Camille",
      "Lastname": "Gulgowski",
      "MiddleName": "Hoeger LLC",
      "Title": "voluptas",
      "Description": "Configurable grid-enabled forecast",
      "Email": "loyce@connellyberge.us",
      "FullName": "Miss Jewel Ernser",
      "DirectPhone": "1-258-423-1939 x926",
      "FormalName": "Runolfsson LLC",
      "CountryId": 540,
      "ContactId": 46,
      "ContactName": "Hoeger Inc and Sons",
      "Retired": 710,
      "Rank": 147,
      "ActiveInterests": 868,
      "ContactDepartment": "",
      "ContactCountryId": 352,
      "ContactOrgNr": "1267977",
      "FaxPhone": "1-181-190-6630 x5496",
      "MobilePhone": "178.367.0632 x15298",
      "ContactPhone": "242.180.2553 x494",
      "AssociateName": "Hayes LLC",
      "AssociateId": 13,
      "UsePersonAddress": false,
      "ContactFax": "sed",
      "Kanafname": "nam",
      "Kanalname": "dolor",
      "Post1": "rerum",
      "Post2": "sit",
      "Post3": "quia",
      "EmailName": "jesse_oberbrunner@cruickshank.com",
      "ContactFullName": "Dr. Lazaro Ondricka",
      "ActiveErpLinks": 821,
      "TicketPriorityId": 413,
      "SupportLanguageId": 746,
      "SupportAssociateId": 950,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 956,
  "GroupId": 577,
  "ActiveStatusMonitorId": 823,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 819,
  "DbiAgentId": 321,
  "DbiLastSyncronized": "2020-05-10T02:49:43.8879031+02:00",
  "DbiKey": "reiciendis",
  "DbiLastModified": "2005-03-08T02:49:43.8879031+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 714,
  "ActiveErpLinks": 90,
  "BounceEmails": [
    "evangeline@hicklerohan.co.uk",
    "antonetta@herzog.co.uk"
  ],
  "Domains": [
    "occaecati",
    "inventore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "157682787",
    "SuperOffice:2": "1622172156"
  },
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "nostrum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 143
    }
  }
}
```