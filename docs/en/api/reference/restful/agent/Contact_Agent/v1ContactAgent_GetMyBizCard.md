---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 706,
  "Name": "Rutherford-Muller",
  "Department": "",
  "OrgNr": "1323000",
  "Number1": "599479",
  "Number2": "591576",
  "UpdatedDate": "2001-10-15T03:24:47.4239365+02:00",
  "CreatedDate": "2022-05-19T03:24:47.4239365+02:00",
  "Emails": [
    {
      "Value": "porro",
      "StrippedValue": "amet",
      "Description": "Profound zero tolerance installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    },
    {
      "Value": "porro",
      "StrippedValue": "amet",
      "Description": "Profound zero tolerance installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 631,
      "Name": "Braun Group",
      "ToolTip": "Impedit accusantium maiores ea consequatur quo.",
      "Deleted": false,
      "Rank": 655,
      "Type": "sed",
      "ColorBlock": 119,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2016-06-25T03:24:47.4239365+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "aliquid",
      "Hidden": false,
      "FullName": "Opal Balistreri",
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
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "ullam",
      "Description": "De-engineered radical knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "ullam",
      "Description": "De-engineered radical knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "deserunt",
      "Description": "Down-sized zero administration workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "deserunt",
      "Description": "Down-sized zero administration workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "dolor",
      "Description": "Seamless heuristic installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "dolor",
      "Description": "Seamless heuristic installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 515
        }
      }
    }
  ],
  "Description": "Fundamental context-sensitive moderator",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 232,
      "Mrmrs": "similique",
      "Firstname": "Samantha",
      "Lastname": "Wisozk",
      "MiddleName": "Robel LLC",
      "Title": "eligendi",
      "Description": "Cloned hybrid time-frame",
      "Email": "grady@wisozk.us",
      "FullName": "Blaze Botsford I",
      "DirectPhone": "(531)001-2221",
      "FormalName": "Fay-McGlynn",
      "CountryId": 918,
      "ContactId": 58,
      "ContactName": "Pouros Group",
      "Retired": 326,
      "Rank": 109,
      "ActiveInterests": 284,
      "ContactDepartment": "",
      "ContactCountryId": 592,
      "ContactOrgNr": "961739",
      "FaxPhone": "402.328.8990",
      "MobilePhone": "(855)044-5421",
      "ContactPhone": "142-967-2844",
      "AssociateName": "Corwin-Ernser",
      "AssociateId": 704,
      "UsePersonAddress": true,
      "ContactFax": "harum",
      "Kanafname": "nihil",
      "Kanalname": "sunt",
      "Post1": "rerum",
      "Post2": "expedita",
      "Post3": "non",
      "EmailName": "titus@kihn.info",
      "ContactFullName": "Mrs. Ladarius Ova Hudson Sr.",
      "ActiveErpLinks": 280,
      "TicketPriorityId": 753,
      "SupportLanguageId": 157,
      "SupportAssociateId": 438,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 515
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "cupiditate",
  "Xstop": false,
  "ActiveInterests": 645,
  "GroupId": 656,
  "ActiveStatusMonitorId": 168,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 494,
  "DbiAgentId": 283,
  "DbiLastSyncronized": "2018-06-16T03:24:47.4239365+02:00",
  "DbiKey": "ipsam",
  "DbiLastModified": "2000-12-05T03:24:47.4239365+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 230,
  "ActiveErpLinks": 558,
  "BounceEmails": [
    "magdalena.swift@ryan.us",
    "werner_swaniawski@schinner.biz"
  ],
  "Domains": [
    "fuga",
    "dolor"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mekhi Deshaun Welch IV",
    "SuperOffice:2": "Mr. Yoshiko Donnell Beahan MD"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "eum"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 708
    }
  }
}
```