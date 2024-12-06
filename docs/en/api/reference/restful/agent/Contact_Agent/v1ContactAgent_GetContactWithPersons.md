---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
generated: true
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 662
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 483,
  "Name": "Reichel Group",
  "Department": "",
  "OrgNr": "1053303",
  "Number1": "1497202",
  "Number2": "1437023",
  "UpdatedDate": "2015-12-31T10:17:55.2696438+01:00",
  "CreatedDate": "2017-03-28T10:17:55.2696438+02:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Visionary upward-trending capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Visionary upward-trending capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 380
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 313,
      "Name": "Bogan-Collier",
      "ToolTip": "Debitis sapiente aspernatur odio ullam totam voluptatem nihil.",
      "Deleted": true,
      "Rank": 414,
      "Type": "ullam",
      "ColorBlock": 933,
      "IconHint": "exercitationem",
      "Selected": false,
      "LastChanged": "2007-11-22T10:17:55.2696438+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Miss Abdullah Issac Mueller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 335
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "facilis",
      "StrippedValue": "deleniti",
      "Description": "Optional tertiary encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "deleniti",
      "Description": "Optional tertiary encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nam",
      "StrippedValue": "facere",
      "Description": "Synchronised tertiary installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 366
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "facere",
      "Description": "Synchronised tertiary installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 366
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quas",
      "StrippedValue": "quod",
      "Description": "Horizontal static process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "quod",
      "Description": "Horizontal static process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "Description": "Re-contextualized eco-centric orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "adipisci",
      "PersonId": 517,
      "Mrmrs": "aliquid",
      "Firstname": "Forest",
      "Lastname": "Keebler",
      "MiddleName": "Osinski-Walker",
      "Title": "quam",
      "Description": "Cloned 24/7 attitude",
      "Email": "chelsea@bernierpouros.name",
      "FullName": "Lizeth Satterfield",
      "DirectPhone": "227-054-5835",
      "FormalName": "Bashirian, Koelpin and Luettgen",
      "CountryId": 919,
      "ContactId": 760,
      "ContactName": "Grimes Group",
      "Retired": 439,
      "Rank": 663,
      "ActiveInterests": 81,
      "ContactDepartment": "integrate sticky schemas",
      "ContactCountryId": 766,
      "ContactOrgNr": "826994",
      "FaxPhone": "831.562.6248 x0638",
      "MobilePhone": "(183)871-0322 x89577",
      "ContactPhone": "(290)432-0198 x34061",
      "AssociateName": "Gibson-O'Reilly",
      "AssociateId": 104,
      "UsePersonAddress": false,
      "ContactFax": "inventore",
      "Kanafname": "eaque",
      "Kanalname": "eos",
      "Post1": "voluptas",
      "Post2": "consequatur",
      "Post3": "distinctio",
      "EmailName": "bartholome_bednar@lang.biz",
      "ContactFullName": "Newton Auer",
      "ActiveErpLinks": 889,
      "TicketPriorityId": 575,
      "SupportLanguageId": 195,
      "SupportAssociateId": 630,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 499
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "a",
  "Xstop": false,
  "ActiveInterests": 744,
  "GroupId": 609,
  "ActiveStatusMonitorId": 976,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 351,
  "DbiAgentId": 186,
  "DbiLastSyncronized": "2022-12-26T10:17:55.2696438+01:00",
  "DbiKey": "voluptatibus",
  "DbiLastModified": "2022-02-17T10:17:55.2696438+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 367,
  "ActiveErpLinks": 275,
  "BounceEmails": [
    "bert.gutkowski@raynor.ca",
    "dayne_hills@cremintowne.biz"
  ],
  "Domains": [
    "ex",
    "inventore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Leonor Bayer",
    "SuperOffice:2": "Ms. Grant Bennett Gerlach"
  },
  "ExtraFields": {
    "ExtraFields1": "illo",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "optio",
    "CustomFields2": "dicta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 382
    }
  }
}
```