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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 425,
  "Name": "Nitzsche-McClure",
  "Department": "",
  "OrgNr": "1201549",
  "Number1": "1480152",
  "Number2": "871127",
  "UpdatedDate": "2021-10-07T12:19:44.9298363+02:00",
  "CreatedDate": "2002-10-08T12:19:44.9298363+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "eum",
      "Description": "Digitized fresh-thinking orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "eum",
      "Description": "Digitized fresh-thinking orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 974,
      "Name": "Little-Mitchell",
      "ToolTip": "Maiores omnis dolore hic.",
      "Deleted": false,
      "Rank": 721,
      "Type": "blanditiis",
      "ColorBlock": 760,
      "IconHint": "eaque",
      "Selected": false,
      "LastChanged": "2010-01-21T12:19:44.9298363+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Nelson Champlin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 921
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "ab",
      "Description": "Devolved value-added installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "ab",
      "Description": "Devolved value-added installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "eos",
      "StrippedValue": "omnis",
      "Description": "Phased contextually-based artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "omnis",
      "Description": "Phased contextually-based artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Managed discrete protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "maiores",
      "Description": "Managed discrete protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "Description": "Diverse tangible complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perferendis",
      "PersonId": 491,
      "Mrmrs": "est",
      "Firstname": "Clementina",
      "Lastname": "Metz",
      "MiddleName": "Kutch, Ullrich and Eichmann",
      "Title": "similique",
      "Description": "Up-sized coherent throughput",
      "Email": "eulah_reilly@strackeblanda.ca",
      "FullName": "Brisa Fisher",
      "DirectPhone": "(180)314-5261 x849",
      "FormalName": "Muller, Stracke and Leuschke",
      "CountryId": 661,
      "ContactId": 149,
      "ContactName": "Hackett, Abernathy and Beahan",
      "Retired": 929,
      "Rank": 270,
      "ActiveInterests": 937,
      "ContactDepartment": "",
      "ContactCountryId": 35,
      "ContactOrgNr": "1093469",
      "FaxPhone": "045.244.5440",
      "MobilePhone": "582-545-9397 x20655",
      "ContactPhone": "1-970-520-3239 x661",
      "AssociateName": "Brekke, Bruen and Ortiz",
      "AssociateId": 181,
      "UsePersonAddress": false,
      "ContactFax": "occaecati",
      "Kanafname": "molestiae",
      "Kanalname": "ut",
      "Post1": "perferendis",
      "Post2": "aperiam",
      "Post3": "cupiditate",
      "EmailName": "lorena.stehr@jacobi.ca",
      "ContactFullName": "Rodrick Wintheiser",
      "ActiveErpLinks": 733,
      "TicketPriorityId": 192,
      "SupportLanguageId": 544,
      "SupportAssociateId": 208,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quia",
  "Xstop": false,
  "ActiveInterests": 420,
  "GroupId": 588,
  "ActiveStatusMonitorId": 790,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 944,
  "DbiAgentId": 143,
  "DbiLastSyncronized": "2019-07-29T12:19:44.9298363+02:00",
  "DbiKey": "autem",
  "DbiLastModified": "1997-04-01T12:19:44.9298363+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 802,
  "ActiveErpLinks": 442,
  "BounceEmails": [
    "pansy@green.co.uk",
    "shakira@mayer.info"
  ],
  "Domains": [
    "et",
    "expedita"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Brett Harris Jr.",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "quis"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "distinctio"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 361
    }
  }
}
```