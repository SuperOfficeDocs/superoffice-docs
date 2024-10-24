---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 941
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 896,
  "Name": "Jacobs Group",
  "Department": "",
  "OrgNr": "870915",
  "Number1": "1368644",
  "Number2": "1110289",
  "UpdatedDate": "2022-09-26T03:44:52.3396483+02:00",
  "CreatedDate": "2012-12-03T03:44:52.3396483+01:00",
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "nihil",
      "Description": "Up-sized system-worthy toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "nihil",
      "Description": "Up-sized system-worthy toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 618
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 487,
      "Name": "Kassulke-McLaughlin",
      "ToolTip": "Autem veritatis blanditiis voluptas mollitia suscipit.",
      "Deleted": false,
      "Rank": 6,
      "Type": "non",
      "ColorBlock": 809,
      "IconHint": "id",
      "Selected": true,
      "LastChanged": "2009-10-15T03:44:52.3396483+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "explicabo",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Tiffany Weimann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "at",
      "StrippedValue": "quia",
      "Description": "Operative demand-driven toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "quia",
      "Description": "Operative demand-driven toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 599
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Cross-group explicit capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Cross-group explicit capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "possimus",
      "StrippedValue": "soluta",
      "Description": "Reduced human-resource help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "soluta",
      "Description": "Reduced human-resource help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    }
  ],
  "Description": "Upgradable eco-centric support",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "similique",
      "PersonId": 107,
      "Mrmrs": "maxime",
      "Firstname": "Eloisa",
      "Lastname": "Hyatt",
      "MiddleName": "Swaniawski-Jacobson",
      "Title": "itaque",
      "Description": "Open-architected interactive migration",
      "Email": "haylee.ankunding@grady.ca",
      "FullName": "Ms. Duncan Helene Mante",
      "DirectPhone": "905.311.6137",
      "FormalName": "Schuster-Witting",
      "CountryId": 263,
      "ContactId": 45,
      "ContactName": "Auer-Bernier",
      "Retired": 189,
      "Rank": 632,
      "ActiveInterests": 496,
      "ContactDepartment": "",
      "ContactCountryId": 332,
      "ContactOrgNr": "1665659",
      "FaxPhone": "1-397-357-9085",
      "MobilePhone": "(164)715-8811",
      "ContactPhone": "1-246-622-5541 x68778",
      "AssociateName": "Quitzon, Lesch and Schuster",
      "AssociateId": 279,
      "UsePersonAddress": false,
      "ContactFax": "quia",
      "Kanafname": "ipsa",
      "Kanalname": "autem",
      "Post1": "tempore",
      "Post2": "nisi",
      "Post3": "magnam",
      "EmailName": "hilda.cummings@abernathy.uk",
      "ContactFullName": "Prof. Alessandra Block",
      "ActiveErpLinks": 826,
      "TicketPriorityId": 237,
      "SupportLanguageId": 998,
      "SupportAssociateId": 838,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 756
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quaerat",
  "Xstop": false,
  "ActiveInterests": 345,
  "GroupId": 639,
  "ActiveStatusMonitorId": 756,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 273,
  "DbiAgentId": 382,
  "DbiLastSyncronized": "2008-12-25T03:44:52.3396483+01:00",
  "DbiKey": "ullam",
  "DbiLastModified": "2000-11-09T03:44:52.3396483+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 845,
  "ActiveErpLinks": 395,
  "BounceEmails": [
    "raina@homenicknitzsche.ca",
    "hailey@boyergoodwin.co.uk"
  ],
  "Domains": [
    "explicabo",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "238919400",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "soluta",
    "ExtraFields2": "assumenda"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "facere"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 165
    }
  }
}
```