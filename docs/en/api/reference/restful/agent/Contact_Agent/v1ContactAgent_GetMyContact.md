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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 301,
  "Name": "Brekke Group",
  "Department": "",
  "OrgNr": "579280",
  "Number1": "705608",
  "Number2": "756379",
  "UpdatedDate": "2023-05-15T13:38:13.3271428+02:00",
  "CreatedDate": "2006-07-21T13:38:13.3271428+02:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "laudantium",
      "Description": "Right-sized discrete contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "laudantium",
      "Description": "Right-sized discrete contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 464,
      "Name": "Ankunding LLC",
      "ToolTip": "Necessitatibus iste illum aperiam sint soluta autem.",
      "Deleted": false,
      "Rank": 112,
      "Type": "inventore",
      "ColorBlock": 462,
      "IconHint": "quod",
      "Selected": true,
      "LastChanged": "2000-06-25T13:38:13.3271428+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Shirley Yost",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Quality-focused exuding collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Quality-focused exuding collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptates",
      "StrippedValue": "similique",
      "Description": "Visionary bandwidth-monitored firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "similique",
      "Description": "Visionary bandwidth-monitored firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "non",
      "Description": "Monitored neutral application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "non",
      "Description": "Monitored neutral application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 563
        }
      }
    }
  ],
  "Description": "Advanced discrete database",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "officiis",
      "PersonId": 78,
      "Mrmrs": "nemo",
      "Firstname": "Christian",
      "Lastname": "Leannon",
      "MiddleName": "Becker LLC",
      "Title": "facere",
      "Description": "Quality-focused interactive orchestration",
      "Email": "ricardo.price@casperabbott.com",
      "FullName": "Mrs. Devyn Eichmann II",
      "DirectPhone": "499.096.3289 x879",
      "FormalName": "Crona Inc and Sons",
      "CountryId": 71,
      "ContactId": 735,
      "ContactName": "Monahan, Rippin and Towne",
      "Retired": 357,
      "Rank": 476,
      "ActiveInterests": 282,
      "ContactDepartment": "",
      "ContactCountryId": 721,
      "ContactOrgNr": "572317",
      "FaxPhone": "1-477-196-3350 x4982",
      "MobilePhone": "1-410-548-0417 x91537",
      "ContactPhone": "1-638-017-9364",
      "AssociateName": "Steuber LLC",
      "AssociateId": 217,
      "UsePersonAddress": false,
      "ContactFax": "libero",
      "Kanafname": "ad",
      "Kanalname": "aut",
      "Post1": "ipsa",
      "Post2": "repellendus",
      "Post3": "ut",
      "EmailName": "gennaro@boganwill.ca",
      "ContactFullName": "Nayeli Kiehn",
      "ActiveErpLinks": 926,
      "TicketPriorityId": 786,
      "SupportLanguageId": 820,
      "SupportAssociateId": 477,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "totam",
  "Xstop": true,
  "ActiveInterests": 11,
  "GroupId": 303,
  "ActiveStatusMonitorId": 724,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 465,
  "DbiAgentId": 930,
  "DbiLastSyncronized": "2000-05-31T13:38:13.3271428+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2008-12-24T13:38:13.3271428+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 846,
  "ActiveErpLinks": 941,
  "BounceEmails": [
    "benton@dubuqueemard.co.uk",
    "kacey@corkery.uk"
  ],
  "Domains": [
    "id",
    "amet"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Avis Weber",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "suscipit",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "nulla"
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