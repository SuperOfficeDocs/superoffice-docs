---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=785
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 421,
  "Name": "Mann, Wehner and Wintheiser",
  "Department": "",
  "OrgNr": "976955",
  "Number1": "1448372",
  "Number2": "463502",
  "UpdatedDate": "2006-08-03T13:13:59.766318+02:00",
  "CreatedDate": "2010-12-10T13:13:59.766318+01:00",
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "delectus",
      "Description": "Re-contextualized zero administration leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 394
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "delectus",
      "Description": "Re-contextualized zero administration leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 394
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 471,
      "Name": "Wehner Group",
      "ToolTip": "Officiis a ut sed aut dignissimos reiciendis.",
      "Deleted": false,
      "Rank": 222,
      "Type": "porro",
      "ColorBlock": 179,
      "IconHint": "quod",
      "Selected": false,
      "LastChanged": "2007-05-12T13:13:59.766318+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquam",
      "StyleHint": "quod",
      "Hidden": true,
      "FullName": "Tommie Turcotte",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "tempore",
      "Description": "Adaptive zero defect data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "tempore",
      "Description": "Adaptive zero defect data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 345
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Profound radical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "qui",
      "Description": "Profound radical project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "quia",
      "Description": "Re-engineered impactful adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "quia",
      "Description": "Re-engineered impactful adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 134
        }
      }
    }
  ],
  "Description": "Universal neutral local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 370,
      "Mrmrs": "dolore",
      "Firstname": "Marcel",
      "Lastname": "Kulas",
      "MiddleName": "Roob-Larkin",
      "Title": "ab",
      "Description": "Visionary exuding approach",
      "Email": "cali@bradtke.info",
      "FullName": "Mrs. Dorris Mona Daniel",
      "DirectPhone": "935-797-6325",
      "FormalName": "O'Kon Inc and Sons",
      "CountryId": 319,
      "ContactId": 547,
      "ContactName": "Adams, Stamm and Hirthe",
      "Retired": 295,
      "Rank": 395,
      "ActiveInterests": 995,
      "ContactDepartment": "",
      "ContactCountryId": 79,
      "ContactOrgNr": "1170010",
      "FaxPhone": "771-599-4661 x29323",
      "MobilePhone": "504.572.3994 x387",
      "ContactPhone": "980.350.5211 x8856",
      "AssociateName": "Stehr-Kuhlman",
      "AssociateId": 146,
      "UsePersonAddress": false,
      "ContactFax": "esse",
      "Kanafname": "ut",
      "Kanalname": "excepturi",
      "Post1": "vitae",
      "Post2": "quaerat",
      "Post3": "ipsum",
      "EmailName": "janae_reichert@denesik.biz",
      "ContactFullName": "Lila Stanton",
      "ActiveErpLinks": 19,
      "TicketPriorityId": 204,
      "SupportLanguageId": 181,
      "SupportAssociateId": 229,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1395162",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 682
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "recusandae",
  "Xstop": false,
  "ActiveInterests": 589,
  "GroupId": 246,
  "ActiveStatusMonitorId": 212,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 28,
  "DbiAgentId": 850,
  "DbiLastSyncronized": "2008-12-13T13:13:59.766318+01:00",
  "DbiKey": "provident",
  "DbiLastModified": "2003-10-13T13:13:59.766318+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 639,
  "ActiveErpLinks": 138,
  "BounceEmails": [
    "lorenza.von@larkin.ca",
    "kiel.collier@mannrau.co.uk"
  ],
  "Domains": [
    "accusamus",
    "modi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Destin Lubowitz",
    "SuperOffice:2": "Janis Parisian"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "dolore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 317
    }
  }
}
```