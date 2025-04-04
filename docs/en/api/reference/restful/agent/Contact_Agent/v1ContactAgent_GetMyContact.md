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
  "ContactId": 403,
  "Name": "Rath LLC",
  "Department": "",
  "OrgNr": "899773",
  "Number1": "1105834",
  "Number2": "1439152",
  "UpdatedDate": "2021-03-27T13:13:59.7975699+01:00",
  "CreatedDate": "2017-03-15T13:13:59.7975699+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Upgradable 24 hour initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sit",
      "Description": "Upgradable 24 hour initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 378,
      "Name": "Lehner Inc and Sons",
      "ToolTip": "Ipsam ut accusamus quis delectus perferendis.",
      "Deleted": false,
      "Rank": 541,
      "Type": "illo",
      "ColorBlock": 426,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2010-12-30T13:13:59.7975699+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "suscipit",
      "Hidden": true,
      "FullName": "Mr. Clifton Waelchi IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 341
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Optimized scalable capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "est",
      "Description": "Optimized scalable capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 252
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "officia",
      "StrippedValue": "tempora",
      "Description": "Inverse next generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "tempora",
      "Description": "Inverse next generation groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Ameliorated actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptatem",
      "Description": "Ameliorated actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "Description": "Devolved maximized capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 24,
      "Mrmrs": "earum",
      "Firstname": "Okey",
      "Lastname": "Torphy",
      "MiddleName": "Treutel, Torp and Veum",
      "Title": "quisquam",
      "Description": "Centralized homogeneous implementation",
      "Email": "emory.hoppe@bahringer.us",
      "FullName": "Dahlia Pfannerstill",
      "DirectPhone": "768.693.2708",
      "FormalName": "Rogahn Group",
      "CountryId": 9,
      "ContactId": 203,
      "ContactName": "Stanton-Robel",
      "Retired": 106,
      "Rank": 651,
      "ActiveInterests": 345,
      "ContactDepartment": "",
      "ContactCountryId": 84,
      "ContactOrgNr": "582938",
      "FaxPhone": "668-568-0571",
      "MobilePhone": "107.736.7048",
      "ContactPhone": "(269)760-7248 x8078",
      "AssociateName": "Bergnaum-Schneider",
      "AssociateId": 427,
      "UsePersonAddress": false,
      "ContactFax": "placeat",
      "Kanafname": "hic",
      "Kanalname": "qui",
      "Post1": "quibusdam",
      "Post2": "dolorum",
      "Post3": "nesciunt",
      "EmailName": "alexandre@lockman.us",
      "ContactFullName": "Brandt Waters",
      "ActiveErpLinks": 394,
      "TicketPriorityId": 741,
      "SupportLanguageId": 751,
      "SupportAssociateId": 774,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1299797",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 53
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "inventore",
  "Xstop": true,
  "ActiveInterests": 49,
  "GroupId": 146,
  "ActiveStatusMonitorId": 858,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 379,
  "DbiAgentId": 798,
  "DbiLastSyncronized": "2019-06-06T13:13:59.7975699+02:00",
  "DbiKey": "id",
  "DbiLastModified": "2021-10-05T13:13:59.7975699+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 479,
  "ActiveErpLinks": 273,
  "BounceEmails": [
    "willa.hirthe@hane.uk",
    "domenico@moen.biz"
  ],
  "Domains": [
    "et",
    "fugit"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Carmela Haley",
    "SuperOffice:2": "Joey Eryn Moen DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "recusandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 883
    }
  }
}
```