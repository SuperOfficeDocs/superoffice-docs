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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 136,
  "Name": "Mante-Runolfsdottir",
  "Department": "",
  "OrgNr": "1413095",
  "Number1": "892927",
  "Number2": "1047928",
  "UpdatedDate": "2012-07-07T04:22:26.2465589+02:00",
  "CreatedDate": "2001-11-06T04:22:26.2465589+01:00",
  "Emails": [
    {
      "Value": "fugiat",
      "StrippedValue": "quam",
      "Description": "Managed contextually-based local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "quam",
      "Description": "Managed contextually-based local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 59
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 352,
      "Name": "Herman Inc and Sons",
      "ToolTip": "Quo aut cupiditate est quia odit.",
      "Deleted": false,
      "Rank": 615,
      "Type": "modi",
      "ColorBlock": 393,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "1999-11-08T04:22:26.2465589+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Prof. Tyler Libbie Rippin III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 548
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "rem",
      "Description": "Synchronised stable policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "rem",
      "Description": "Synchronised stable policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptates",
      "StrippedValue": "ut",
      "Description": "Balanced mobile throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "ut",
      "Description": "Balanced mobile throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 354
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "commodi",
      "Description": "Multi-lateral multi-tasking utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "commodi",
      "Description": "Multi-lateral multi-tasking utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    }
  ],
  "Description": "Managed well-modulated installation",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "unde",
      "PersonId": 52,
      "Mrmrs": "dolorem",
      "Firstname": "Ashlee",
      "Lastname": "Abernathy",
      "MiddleName": "King, Langworth and Legros",
      "Title": "quas",
      "Description": "Face to face transitional pricing structure",
      "Email": "verla.bartell@crona.us",
      "FullName": "Tito Effie Welch IV",
      "DirectPhone": "1-318-280-6639",
      "FormalName": "Terry Inc and Sons",
      "CountryId": 410,
      "ContactId": 705,
      "ContactName": "Kunze, Ondricka and Dooley",
      "Retired": 210,
      "Rank": 511,
      "ActiveInterests": 288,
      "ContactDepartment": "generate strategic paradigms",
      "ContactCountryId": 641,
      "ContactOrgNr": "856544",
      "FaxPhone": "(296)091-4795",
      "MobilePhone": "085.957.7371",
      "ContactPhone": "(718)388-4033 x3894",
      "AssociateName": "Fritsch-Ortiz",
      "AssociateId": 674,
      "UsePersonAddress": false,
      "ContactFax": "officia",
      "Kanafname": "iusto",
      "Kanalname": "nesciunt",
      "Post1": "corrupti",
      "Post2": "earum",
      "Post3": "veritatis",
      "EmailName": "imogene_pouros@kuhlman.info",
      "ContactFullName": "Daniela Wehner",
      "ActiveErpLinks": 583,
      "TicketPriorityId": 638,
      "SupportLanguageId": 723,
      "SupportAssociateId": 980,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 696
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": true,
  "ActiveInterests": 90,
  "GroupId": 924,
  "ActiveStatusMonitorId": 42,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 416,
  "DbiAgentId": 861,
  "DbiLastSyncronized": "2024-03-07T04:22:26.2465589+01:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2020-09-07T04:22:26.2465589+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 943,
  "ActiveErpLinks": 814,
  "BounceEmails": [
    "cathy@gislason.uk",
    "sydnee.murphy@metz.info"
  ],
  "Domains": [
    "eveniet",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Jaunita Noe Nader DDS",
    "SuperOffice:2": "Ms. Carmella Jaeden Rodriguez"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "doloribus"
  },
  "CustomFields": {
    "CustomFields1": "eligendi",
    "CustomFields2": "molestias"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 334
    }
  }
}
```