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
  "ContactId": 401,
  "Name": "Waelchi-Nader",
  "Department": "",
  "OrgNr": "816839",
  "Number1": "1346134",
  "Number2": "1833268",
  "UpdatedDate": "1997-05-07T10:30:23.3355689+02:00",
  "CreatedDate": "2008-10-26T10:30:23.3355689+01:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Re-engineered methodical software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Re-engineered methodical software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 864,
      "Name": "Gutkowski, Braun and Jaskolski",
      "ToolTip": "Omnis porro omnis adipisci deserunt.",
      "Deleted": false,
      "Rank": 617,
      "Type": "qui",
      "ColorBlock": 980,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2023-04-08T10:30:23.3355689+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Davion Block",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 778
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "quisquam",
      "Description": "Assimilated executive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "quisquam",
      "Description": "Assimilated executive productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 411
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ipsa",
      "StrippedValue": "natus",
      "Description": "Decentralized client-driven implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    },
    {
      "Value": "ipsa",
      "StrippedValue": "natus",
      "Description": "Decentralized client-driven implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 451
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptate",
      "StrippedValue": "minus",
      "Description": "Upgradable demand-driven emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 468
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "minus",
      "Description": "Upgradable demand-driven emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 468
        }
      }
    }
  ],
  "Description": "Function-based 4th generation structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "vero",
      "PersonId": 387,
      "Mrmrs": "aliquam",
      "Firstname": "Marjory",
      "Lastname": "Lueilwitz",
      "MiddleName": "Gottlieb Inc and Sons",
      "Title": "et",
      "Description": "Expanded tertiary methodology",
      "Email": "brendon@monahan.co.uk",
      "FullName": "Kenyatta Reinger",
      "DirectPhone": "1-546-327-9679 x7371",
      "FormalName": "Hettinger, Gibson and Gaylord",
      "CountryId": 780,
      "ContactId": 574,
      "ContactName": "Smitham-Graham",
      "Retired": 440,
      "Rank": 139,
      "ActiveInterests": 790,
      "ContactDepartment": "",
      "ContactCountryId": 814,
      "ContactOrgNr": "625499",
      "FaxPhone": "(525)579-7161 x4888",
      "MobilePhone": "1-758-031-3834 x473",
      "ContactPhone": "(951)321-1185 x75318",
      "AssociateName": "Cassin-Mitchell",
      "AssociateId": 270,
      "UsePersonAddress": false,
      "ContactFax": "dolorum",
      "Kanafname": "excepturi",
      "Kanalname": "et",
      "Post1": "sed",
      "Post2": "quos",
      "Post3": "iure",
      "EmailName": "casandra@dooleynienow.biz",
      "ContactFullName": "Cooper Leuschke",
      "ActiveErpLinks": 714,
      "TicketPriorityId": 755,
      "SupportLanguageId": 563,
      "SupportAssociateId": 478,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "omnis",
  "Xstop": false,
  "ActiveInterests": 878,
  "GroupId": 298,
  "ActiveStatusMonitorId": 224,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 891,
  "DbiAgentId": 653,
  "DbiLastSyncronized": "2017-06-29T10:30:23.3355689+02:00",
  "DbiKey": "id",
  "DbiLastModified": "2000-01-22T10:30:23.3355689+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 11,
  "ActiveErpLinks": 973,
  "BounceEmails": [
    "vernice_blick@smith.com",
    "sydney.hills@sengergerhold.biz"
  ],
  "Domains": [
    "temporibus",
    "atque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ella Botsford",
    "SuperOffice:2": "Mrs. Allie Georgiana Konopelski"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "repellat",
    "CustomFields2": "provident"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 844
    }
  }
}
```