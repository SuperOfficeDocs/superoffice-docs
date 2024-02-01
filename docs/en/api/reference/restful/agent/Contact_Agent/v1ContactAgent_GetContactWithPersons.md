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
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 914
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 886,
  "Name": "Runolfsdottir, Turner and Kihn",
  "Department": "",
  "OrgNr": "1601026",
  "Number1": "874015",
  "Number2": "446832",
  "UpdatedDate": "2009-12-08T23:03:55.3361375+01:00",
  "CreatedDate": "2020-06-30T23:03:55.3361375+02:00",
  "Emails": [
    {
      "Value": "quidem",
      "StrippedValue": "nesciunt",
      "Description": "Realigned client-driven hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "nesciunt",
      "Description": "Realigned client-driven hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 17
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 217,
      "Name": "Wolff-Stiedemann",
      "ToolTip": "Error consectetur et eum ea temporibus.",
      "Deleted": false,
      "Rank": 638,
      "Type": "qui",
      "ColorBlock": 747,
      "IconHint": "nobis",
      "Selected": true,
      "LastChanged": "2014-08-21T23:03:55.3366427+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "pariatur",
      "Hidden": false,
      "FullName": "Meredith Bins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 539
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eveniet",
      "StrippedValue": "nam",
      "Description": "Down-sized leading edge installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "nam",
      "Description": "Down-sized leading edge installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "accusantium",
      "StrippedValue": "porro",
      "Description": "Fully-configurable fresh-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "porro",
      "Description": "Fully-configurable fresh-thinking strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repudiandae",
      "StrippedValue": "harum",
      "Description": "Balanced reciprocal moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "harum",
      "Description": "Balanced reciprocal moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 965
        }
      }
    }
  ],
  "Description": "Versatile interactive archive",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 252,
      "Mrmrs": "qui",
      "Firstname": "Maverick",
      "Lastname": "Hills",
      "MiddleName": "Hauck Inc and Sons",
      "Title": "doloremque",
      "Description": "Triple-buffered fault-tolerant toolset",
      "Email": "aubrey@denesik.co.uk",
      "FullName": "Lorenzo Maegan Lang Jr.",
      "DirectPhone": "(190)942-7684",
      "FormalName": "Dach, Zemlak and Hermann",
      "CountryId": 690,
      "ContactId": 412,
      "ContactName": "Stracke-Kozey",
      "Retired": 690,
      "Rank": 147,
      "ActiveInterests": 322,
      "ContactDepartment": "",
      "ContactCountryId": 631,
      "ContactOrgNr": "1032295",
      "FaxPhone": "(850)308-6514 x36411",
      "MobilePhone": "(106)281-5753 x28169",
      "ContactPhone": "835-996-5627 x8040",
      "AssociateName": "Jenkins, Oberbrunner and Goodwin",
      "AssociateId": 315,
      "UsePersonAddress": false,
      "ContactFax": "quas",
      "Kanafname": "recusandae",
      "Kanalname": "quis",
      "Post1": "in",
      "Post2": "ad",
      "Post3": "quos",
      "EmailName": "jerome.kiehn@hand.biz",
      "ContactFullName": "Trace Walker",
      "ActiveErpLinks": 890,
      "TicketPriorityId": 163,
      "SupportLanguageId": 442,
      "SupportAssociateId": 609,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 637
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "beatae",
  "Xstop": false,
  "ActiveInterests": 607,
  "GroupId": 538,
  "ActiveStatusMonitorId": 86,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 198,
  "DbiAgentId": 791,
  "DbiLastSyncronized": "2004-05-02T23:03:55.3401372+02:00",
  "DbiKey": "aliquid",
  "DbiLastModified": "1999-09-05T23:03:55.3401372+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 337,
  "ActiveErpLinks": 811,
  "BounceEmails": [
    "florian@dickinson.name",
    "serena_lehner@hodkiewiczkassulke.uk"
  ],
  "Domains": [
    "recusandae",
    "voluptatem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Skyla Auer",
    "SuperOffice:2": "Mrs. Leanne Peter Hyatt"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "unde"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 8
    }
  }
}
```