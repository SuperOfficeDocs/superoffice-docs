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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 35,
  "Name": "Ruecker Inc and Sons",
  "Department": "",
  "OrgNr": "941193",
  "Number1": "909000",
  "Number2": "734217",
  "UpdatedDate": "2014-02-02T16:32:38.4771663+01:00",
  "CreatedDate": "2007-05-23T16:32:38.4771663+02:00",
  "Emails": [
    {
      "Value": "unde",
      "StrippedValue": "cumque",
      "Description": "Team-oriented responsive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "cumque",
      "Description": "Team-oriented responsive data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 274
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 663,
      "Name": "Mertz Group",
      "ToolTip": "Dolorem quisquam error qui adipisci doloremque.",
      "Deleted": false,
      "Rank": 758,
      "Type": "debitis",
      "ColorBlock": 628,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2018-05-05T16:32:38.4771663+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "autem",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Prof. Emie Claire Prohaska",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tempora",
      "StrippedValue": "quasi",
      "Description": "Right-sized fresh-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "quasi",
      "Description": "Right-sized fresh-thinking knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 113
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "sequi",
      "Description": "Synergistic empowering matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "sequi",
      "Description": "Synergistic empowering matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Re-engineered regional concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 825
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "et",
      "Description": "Re-engineered regional concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 825
        }
      }
    }
  ],
  "Description": "Persistent composite adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "est",
      "PersonId": 6,
      "Mrmrs": "vitae",
      "Firstname": "Jed",
      "Lastname": "Emmerich",
      "MiddleName": "Deckow-Murazik",
      "Title": "officiis",
      "Description": "Configurable national product",
      "Email": "deshaun.howe@nicolasjacobi.info",
      "FullName": "Hudson Koelpin",
      "DirectPhone": "045.204.1524 x868",
      "FormalName": "Boyle, Miller and Emmerich",
      "CountryId": 478,
      "ContactId": 650,
      "ContactName": "Zboncak, Wilkinson and Leannon",
      "Retired": 340,
      "Rank": 357,
      "ActiveInterests": 405,
      "ContactDepartment": "",
      "ContactCountryId": 957,
      "ContactOrgNr": "1025038",
      "FaxPhone": "(830)672-3801 x066",
      "MobilePhone": "1-330-178-7168 x824",
      "ContactPhone": "764.202.8144 x53755",
      "AssociateName": "Kihn, Schoen and Larson",
      "AssociateId": 784,
      "UsePersonAddress": false,
      "ContactFax": "officiis",
      "Kanafname": "dolorum",
      "Kanalname": "odio",
      "Post1": "voluptas",
      "Post2": "sunt",
      "Post3": "aspernatur",
      "EmailName": "dewayne@kunde.uk",
      "ContactFullName": "Patrick Ettie Wiza I",
      "ActiveErpLinks": 965,
      "TicketPriorityId": 255,
      "SupportLanguageId": 814,
      "SupportAssociateId": 536,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1153801",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "accusantium",
  "Xstop": false,
  "ActiveInterests": 920,
  "GroupId": 747,
  "ActiveStatusMonitorId": 927,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 33,
  "DbiAgentId": 194,
  "DbiLastSyncronized": "2012-05-02T16:32:38.4771663+02:00",
  "DbiKey": "aspernatur",
  "DbiLastModified": "2021-06-13T16:32:38.4771663+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 357,
  "ActiveErpLinks": 707,
  "BounceEmails": [
    "harmon_strosin@lakin.com",
    "bell_pacocha@romaguera.info"
  ],
  "Domains": [
    "ad",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Maria Gusikowski",
    "SuperOffice:2": "Keon Runolfsson"
  },
  "ExtraFields": {
    "ExtraFields1": "harum",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 308
    }
  }
}
```