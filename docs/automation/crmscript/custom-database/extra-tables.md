---
uid: crmscript_extra_tables
title: Third-party tables
author:
so.date:
keywords:
so.topic: concept
---

# Third-party tables

SuperOffice Expander Service License gives you the possibility to create extra tables in the database. Instantly, these third-party tables will be available for standard CRUD operations in SuperOffice Service. You need to set up a web panel to access them from the Sales client.

However, an empty table is not very useful. So you have to set up fields for the new table and then you can populate with data.

## The Tables screen in System design

The **Tables** screen is your tool for customizing the database schema. Here you will find  a list of the tables in the system:

* standard tables: predefined by SuperOffice and forms the basis of different screens
* extra tables: created by you or other 3rd parties with optional content

**To open:**

1. Sign in to SuperOffice Service.
2. Click the hamburger menu and select **System Design**. Then select **Tables**.

## Conventions

> [!CAUTION]
> Choose your database table and field names carefully. They cannot be changed later!<br>A logical name is best because it makes it easier to see what the database contains.

The prefixes ensure that what you create don't conflict with future SuperOffice table and field names. However, it doesn't guarantee a lack of naming conflicts between different 3rd parties.

### Table names

* must start with **y_**
* may contain only underscores, the letters a to z, and numbers

### Field names

* must start with **x_**
* must be unique within the table
* must be a single word
* may contain only underscores, letters from a to z, or numbers

## Creating an extra table

> [!NOTE]
> This task is done in the Tables screen of SuperOffice Service.

1. Open the **Tables** screen.
2. Click **New table**.
3. Set table properties:
    * Enter a *name* to be used as label.
    * Enter a *database field* beginning with **y_** to identify it in the schema.
    * Optionally set other properties. See the [user guide][1] for details.
4. Click **OK** to save the new table (runs `create table y_mynewtable ...`).
5. Add fields to your new table. (See next task for details.)
6. Optionally adjust table properties such as sort order.
    * Click the table link to get to the Edit table screen
7. Click **Restart NetServer**.

> [!TIP]
> Some table properties can't be set until you've added fields. Click the table name in the list to enter edit mode.

You can now open the table in the UI to add content to it **or** populate it via the APIs.

## Add fields to new table

1. In the **Tables** screen, hover the table you want to alter and click **New field**.
2. Select a type for the new field and click **OK**.
3. Set field properties:
    * Enter a *name* to be used as label.
    * Enter a *database table* beginning with **x_** to identify it in the schema.
    * Optionally set other properties. The type determines what's available.
4. Click **OK** to save the new field (runs `alter table y_mynewtable add column x_mynewfield ...`).
5. Continue adding more fields. Click **Restart NetServer** when you're done.

> [!TIP]
> To make a field mandatory, select **Cannot be empty**.

## Add data to new table

### In Service

1. In Service, click **Requests** and then click **Tables**.
2. Hover the table you want to add data to and click **New entry**.
3. Fill in the data for the new row and click **OK**.

### With CRMScript

Using [SearchEngine][2] and `addData()`, you set up the row and then do an insert.

This example adds a row to the `y_equipment` table with values for the `x_label` and `x_manufacturer` fields.

```crmscript
SearchEngine se;
se.addData("y_equipment.x_label", "tablet");
se.addData("y_equipment.x_manufacturer", "HP");
se.insert();
```

## Reference

### Table properties

| Property       | Description                                                 |
|:---------------|:------------------------------------------------------------|
| Folder         | to organize tables in a hierarchy, optional                 |
| Name           | label                                                       |
| Database table | for the schema, can't be changed after creation             |
| Sort order     | which column the table will be sorted on, and the direction |
| Display field  | for relations                                               |
| SuperOffice CRM access | controls access to the table from web panels<br>no access, read access, or full access |

For a complete list of properties, see the [help files][1].

### Field properties

| Property        | Description                                                 |
|:----------------|:------------------------------------------------------------|
| Name            | label                                                       |
| Database field  | for the schema, can't be changed after creation             |
| Cannot be empty | makes field mandatory                                       |
| Create index    | whether to index the field                                  |
| Show in table   | whether to as a column when listing entries                 |
| Default value   | used if not set explicitly                                  |
| Update null values now | whether to replace all empty fields with the default value |

In addition, each type has its own set of properties. For example, items for a list box and decimals in a number, or units for a time span.

For a complete list of properties, see the [help files][3].

<!-- Referenced links -->
[1]: https://community.superoffice.com/Documentation/Help/en/CRM/8.5/UserHelp/Service/topics/blogic.listExtraTables.editExtraTable.html
[2]: ../searchengine/index.md
[3]: https://community.superoffice.com/documentation/help/en/crm/8.5/userhelp/index.htm#t=Service%2Ftopics%2Fblogic.listExtraTables.listFields.editField.html
