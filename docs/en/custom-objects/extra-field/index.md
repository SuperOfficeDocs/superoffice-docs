---
uid: extra_fields
title: Extra fields
description: An extra field is a custom field that you add to an existing SuperOffice database table in Service.
author: HanneGunnarsson
so.date: 02.07.2022
keywords: extra field, Service
so.topic: concept
---

# Extra fields

An *extra field* is a custom field that you add to an existing SuperOffice database table. You can extend the following entities:

* category
* company
* contact
* FAQ category and entry
* message
* request
* user
* your [custom tables][6]

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

Extra fields are managed in **Settings and maintenance**, in the **Tables** screen.

> [!NOTE]
> Extra fields on company or contact are not the same as user-defined fields on those entities!

## Extra field types

* Bool (yes/no)
* Integer
* Float
* Text (short)
* Text (long)
* Date
* Date and time
* Time
* Timespan
* Attachment
* Dynamic link

In addition, there's a relation type for each entity. For example, the *contact relation*.

## Relations (foreign keys)

Database tables are connected with foreign keys (FK). These are the field types ending in *relation*.

* contact relation
* company relation
* user relation
* request relation
* category relation
* priority relation
* FAQ relation
* sale relation
* project relation
* appointment relation
* extra table relation

### Add FK

1. Open the **Tables** screen, hover the table you want to alter, and click **New field**.
1. Select the relation type for the entity you want to connect to and click **OK**.
1. [Set field properties][6].
1. Click **OK** to save the FK.
1. Click **Restart NetServer** to apply the changes.

For example, to connect all incoming requests to a specific sale, you can add an extra field of type sale relation to [requests][4] (ticket table). To list connected requests when viewing a sale in SuperOffice CRM, you'll need to build a web panel.

## Storage

Unlike user-defined fields, extra fields are added as actual fields to the database tables. There are no pre-defined slots you need to take into consideration, and essentially no limitations.

If you add a field with database name `x_field` to the `ticket` table, the value will be stored in 1 of these 2 places:

* If it's an FK, the actual value is stored in a related table. `ticket.x_field` holds only the reference
* Otherwise, the value is stored in `ticket.x_field`

### The extra_fields table

| Property           | Description                               |
|:-------------------|:------------------------------------------|
| id                 | ID (PK)                                   |
| name               | UI label                                  |
| field_name         | the database name of the field            |
| type               | of field                                  |
| domain             | which table the field belongs to          |
| extra_table        | reference to the extra table the field belongs to, or -1 |
| target_extra_table | FK to an extra table                      |
| params             | various parameters for the field (string) |

For a complete list of properties, see the [database reference][7].

## Create extra field

See instructions under [extra tables][6].

## Add extra fields to the Details tab

Scenario: you've added an extra field to a company (`contact` table) conveying whether or not it has a support contract and you want to display that info when viewing a request.

### Display extra field for you

1. In **Settings and maintenance**, click **Screen designer** > **Requests**.
1. Click **Edit layout** at the bottom of the screen. The **Edit card layout** screen dialogue.
1. Locate the **Fields** setting.
1. Select your field.
1. Optionally, select the appropriate styling options.
1. Click **Save** to save the settings.

> [!TIP]
> You can also group fields, add headers for groups, and change the sizes of columns.

### Display extra field for role

To make the field visible to others than yourself, you'll need to create a profile.

1. In **Settings and maintenance**, click **System design** and select **Profile**.
2. Select **System screens**, then click **View ticket**, point the cursor to **ticketinfo**, and then click **New common profile**.
3. In the **Edit element profile** dialogue, do steps 3-6 of *Display extra field for you*.
4. Click the hamburger menu again and select **Roles**.
5. Select a role (who should be able to see the field in the request screen).
6. In the **Edit role screen**, select the **Profile** tab.
7. From the **New element profile** list, select the profile you just created.
8. Click **OK** to save the settings.

All users who have this role will now be able to see the extra field in the **Details** tab in all their requests.

<!-- Referenced links -->
[4]: ../../database/tables/ticket.md
[6]: ../extra-table/index.md
[7]: ../../database/tables/extra-fields.md
