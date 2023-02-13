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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 57,
  "Name": "Shanahan, O'Conner and Lang",
  "Department": "",
  "OrgNr": "781897",
  "Number1": "1189412",
  "Number2": "1007240",
  "UpdatedDate": "2016-07-07T11:22:37.6336208+02:00",
  "CreatedDate": "2020-03-02T11:22:37.6336208+01:00",
  "Emails": [
    {
      "Value": "eos",
      "StrippedValue": "fuga",
      "Description": "Enterprise-wide analyzing circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "fuga",
      "Description": "Enterprise-wide analyzing circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 821,
      "Name": "Dare, Wilderman and Kohler",
      "ToolTip": "Consequuntur illum quia quo vero praesentium sunt.",
      "Deleted": false,
      "Rank": 431,
      "Type": "consectetur",
      "ColorBlock": 648,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "1996-03-02T11:22:37.6336208+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "consequuntur",
      "Hidden": true,
      "FullName": "Candida Smitham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 580
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "asperiores",
      "StrippedValue": "consequatur",
      "Description": "Synergized zero tolerance Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "consequatur",
      "Description": "Synergized zero tolerance Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Mandatory responsive synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "et",
      "Description": "Mandatory responsive synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 304
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "ea",
      "Description": "Focused clear-thinking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "ea",
      "Description": "Focused clear-thinking knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "Description": "Profit-focused object-oriented solution",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "atque",
      "PersonId": 928,
      "Mrmrs": "quo",
      "Firstname": "Juston",
      "Lastname": "Stracke",
      "MiddleName": "Purdy-Flatley",
      "Title": "magnam",
      "Description": "Robust motivating concept",
      "Email": "itzel_macejkovic@marksharris.biz",
      "FullName": "Prof. Cleve Emmet Grimes II",
      "DirectPhone": "013.488.7700",
      "FormalName": "Mraz-Daugherty",
      "CountryId": 249,
      "ContactId": 855,
      "ContactName": "Mertz Inc and Sons",
      "Retired": 181,
      "Rank": 51,
      "ActiveInterests": 134,
      "ContactDepartment": "",
      "ContactCountryId": 384,
      "ContactOrgNr": "1397224",
      "FaxPhone": "1-204-048-8082 x3153",
      "MobilePhone": "1-884-755-5406 x0484",
      "ContactPhone": "065-542-1684",
      "AssociateName": "Blick, Ledner and Osinski",
      "AssociateId": 741,
      "UsePersonAddress": true,
      "ContactFax": "nihil",
      "Kanafname": "ut",
      "Kanalname": "possimus",
      "Post1": "quis",
      "Post2": "qui",
      "Post3": "aut",
      "EmailName": "maeve@conn.com",
      "ContactFullName": "Mrs. Haskell Upton",
      "ActiveErpLinks": 26,
      "TicketPriorityId": 374,
      "SupportLanguageId": 106,
      "SupportAssociateId": 627,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "temporibus",
  "Xstop": false,
  "ActiveInterests": 858,
  "GroupId": 158,
  "ActiveStatusMonitorId": 220,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 454,
  "DbiAgentId": 998,
  "DbiLastSyncronized": "2022-10-16T11:22:37.6336208+02:00",
  "DbiKey": "unde",
  "DbiLastModified": "2000-04-24T11:22:37.6336208+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 590,
  "ActiveErpLinks": 857,
  "BounceEmails": [
    "bertha.kuhlman@cruickshankpurdy.info",
    "nedra@oconnercassin.name"
  ],
  "Domains": [
    "et",
    "voluptatem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1669129689",
    "SuperOffice:2": "Ms. Dedric Zechariah Breitenberg"
  },
  "ExtraFields": {
    "ExtraFields1": "ex",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "similique",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 878
    }
  }
}
```