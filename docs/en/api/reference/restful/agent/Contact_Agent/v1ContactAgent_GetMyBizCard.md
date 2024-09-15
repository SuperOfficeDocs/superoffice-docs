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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 41,
  "Name": "Murphy LLC",
  "Department": "",
  "OrgNr": "425555",
  "Number1": "667401",
  "Number2": "620920",
  "UpdatedDate": "2013-08-01T04:02:01.4717645+02:00",
  "CreatedDate": "2010-10-22T04:02:01.4717645+02:00",
  "Emails": [
    {
      "Value": "nam",
      "StrippedValue": "excepturi",
      "Description": "Switchable fault-tolerant workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "excepturi",
      "Description": "Switchable fault-tolerant workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 540
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 111,
      "Name": "Cormier-Friesen",
      "ToolTip": "Qui explicabo voluptatem id in reiciendis officiis in.",
      "Deleted": false,
      "Rank": 527,
      "Type": "possimus",
      "ColorBlock": 771,
      "IconHint": "atque",
      "Selected": false,
      "LastChanged": "2013-01-23T04:02:01.4717645+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "animi",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Drake Kulas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 715
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "eligendi",
      "Description": "Total value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "eligendi",
      "Description": "Total value-added local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quidem",
      "StrippedValue": "id",
      "Description": "Quality-focused maximized customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "id",
      "Description": "Quality-focused maximized customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellat",
      "StrippedValue": "iure",
      "Description": "Business-focused encompassing model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 951
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "iure",
      "Description": "Business-focused encompassing model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 951
        }
      }
    }
  ],
  "Description": "De-engineered grid-enabled toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nobis",
      "PersonId": 895,
      "Mrmrs": "modi",
      "Firstname": "Madeline",
      "Lastname": "Halvorson",
      "MiddleName": "Cummerata-Bechtelar",
      "Title": "et",
      "Description": "Ergonomic fault-tolerant solution",
      "Email": "daniella.mosciski@kuhn.com",
      "FullName": "Buford Blanda",
      "DirectPhone": "021-194-2591 x6870",
      "FormalName": "Bergnaum Group",
      "CountryId": 473,
      "ContactId": 276,
      "ContactName": "Corwin-Sporer",
      "Retired": 607,
      "Rank": 606,
      "ActiveInterests": 984,
      "ContactDepartment": "",
      "ContactCountryId": 26,
      "ContactOrgNr": "916063",
      "FaxPhone": "(230)505-8783 x25572",
      "MobilePhone": "1-788-898-2180 x344",
      "ContactPhone": "(922)112-8007 x95588",
      "AssociateName": "Wiza-Powlowski",
      "AssociateId": 563,
      "UsePersonAddress": true,
      "ContactFax": "reprehenderit",
      "Kanafname": "fugiat",
      "Kanalname": "eligendi",
      "Post1": "et",
      "Post2": "alias",
      "Post3": "assumenda",
      "EmailName": "yasmine.jacobs@leannon.uk",
      "ContactFullName": "Lon Reilly",
      "ActiveErpLinks": 278,
      "TicketPriorityId": 964,
      "SupportLanguageId": 570,
      "SupportAssociateId": 395,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 240
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "in",
  "Xstop": true,
  "ActiveInterests": 522,
  "GroupId": 278,
  "ActiveStatusMonitorId": 761,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 682,
  "DbiAgentId": 885,
  "DbiLastSyncronized": "2013-05-14T04:02:01.487388+02:00",
  "DbiKey": "impedit",
  "DbiLastModified": "2004-04-24T04:02:01.487388+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 386,
  "ActiveErpLinks": 886,
  "BounceEmails": [
    "gia_stanton@purdy.com",
    "trenton@thiel.us"
  ],
  "Domains": [
    "commodi",
    "dolorem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2133178077",
    "SuperOffice:2": "Chasity Myra Altenwerth PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "voluptate"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "cupiditate"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 152
    }
  }
}
```