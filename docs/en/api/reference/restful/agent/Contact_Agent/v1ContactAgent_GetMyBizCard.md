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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 485,
  "Name": "Harber-Corkery",
  "Department": "",
  "OrgNr": "711416",
  "Number1": "253142",
  "Number2": "1251873",
  "UpdatedDate": "2009-04-25T14:45:05.1002222+02:00",
  "CreatedDate": "2021-12-22T14:45:05.1002222+01:00",
  "Emails": [
    {
      "Value": "id",
      "StrippedValue": "atque",
      "Description": "Business-focused contextually-based complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "atque",
      "Description": "Business-focused contextually-based complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 117,
      "Name": "Abernathy Inc and Sons",
      "ToolTip": "Est veritatis animi quo laboriosam ut exercitationem.",
      "Deleted": true,
      "Rank": 734,
      "Type": "distinctio",
      "ColorBlock": 932,
      "IconHint": "reiciendis",
      "Selected": true,
      "LastChanged": "2002-03-14T14:45:05.1002222+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "sapiente",
      "Hidden": false,
      "FullName": "Miss Herta Gerhold DVM",
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
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Re-contextualized optimal definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Re-contextualized optimal definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "tenetur",
      "Description": "Robust stable synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "tenetur",
      "Description": "Robust stable synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "minima",
      "StrippedValue": "totam",
      "Description": "Organic eco-centric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "totam",
      "Description": "Organic eco-centric encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 600
        }
      }
    }
  ],
  "Description": "Multi-layered cohesive superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 179,
      "Mrmrs": "voluptatem",
      "Firstname": "Domenico",
      "Lastname": "Schinner",
      "MiddleName": "Sawayn-Jacobson",
      "Title": "quae",
      "Description": "Assimilated fresh-thinking toolset",
      "Email": "easton@ferrycollins.co.uk",
      "FullName": "Terrell Corkery",
      "DirectPhone": "441-743-4948 x4988",
      "FormalName": "Trantow-Weissnat",
      "CountryId": 741,
      "ContactId": 643,
      "ContactName": "Lueilwitz, Spinka and Paucek",
      "Retired": 154,
      "Rank": 327,
      "ActiveInterests": 489,
      "ContactDepartment": "",
      "ContactCountryId": 864,
      "ContactOrgNr": "1282775",
      "FaxPhone": "1-733-897-3956 x1457",
      "MobilePhone": "(161)010-5397",
      "ContactPhone": "228-282-5116 x0437",
      "AssociateName": "Willms Inc and Sons",
      "AssociateId": 468,
      "UsePersonAddress": false,
      "ContactFax": "vel",
      "Kanafname": "vel",
      "Kanalname": "modi",
      "Post1": "similique",
      "Post2": "a",
      "Post3": "eum",
      "EmailName": "sheldon@green.ca",
      "ContactFullName": "Vivien Roberts",
      "ActiveErpLinks": 256,
      "TicketPriorityId": 560,
      "SupportLanguageId": 433,
      "SupportAssociateId": 659,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nostrum",
  "Xstop": false,
  "ActiveInterests": 677,
  "GroupId": 161,
  "ActiveStatusMonitorId": 388,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 738,
  "DbiAgentId": 485,
  "DbiLastSyncronized": "1997-07-05T14:45:05.1158461+02:00",
  "DbiKey": "est",
  "DbiLastModified": "2006-09-01T14:45:05.1158461+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 875,
  "ActiveErpLinks": 162,
  "BounceEmails": [
    "esther_davis@volkman.com",
    "georgianna@medhurstmurazik.uk"
  ],
  "Domains": [
    "numquam",
    "ab"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Shyann Malinda Hand Jr.",
    "SuperOffice:2": "250975020"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "quibusdam"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 306
    }
  }
}
```