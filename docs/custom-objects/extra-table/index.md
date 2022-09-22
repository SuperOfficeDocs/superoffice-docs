---
uid: extra_tables
title: Third-party tables
author: Bergfrid Skaara Dias
so.date: 02.07.2022
keywords: database, extra table
so.topic: concept
---

# Third-party tables

SuperOffice Expander Tools license gives you the possibility to create extra tables in the database. Instantly, these third-party tables will be available for standard CRUD operations in SuperOffice Service. You need to set up a web panel to access them from the Sales client.

However, an empty table is not very useful. So you have to set up fields for the new table and then you can populate with data.

[!include[License requirement](../../../common/includes/req-dev-tools.md)]

## The Tables screen in System design

The **Tables** screen is your tool for customizing the database schema. Here you will find  a list of the tables in the system:

* standard tables: predefined by SuperOffice and forms the basis of different screens
* extra tables: created by you or other 3rd parties with optional content

**To open:**

1. Sign in to SuperOffice Service.
2. Click the hamburger menu and select **System Design**. Then select **Tables**.

## Conventions

> [!CAUTION]
> Choose your database table and field names carefully. They cannot be changed later!
>
> A logical name is best because it makes it easier to see what the database contains.

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
    * Enter a *name* to be used as the label.
    * Enter a *database field* beginning with **y_** to identify it in the schema.
    * Optionally set other properties.
4. Click **OK** to save the new table (runs `create table y_mynewtable ...`).
5. Add fields to your new table. (See next task for details.)
6. Optionally adjust table properties such as sort order.
    * Click the table link to get to the Edit table screen
7. Click **Restart NetServer**.

> [!TIP]
> Some table properties can't be set until you've added fields. Click the table name in the list to enter edit mode.

You can now open the table in the UI to add content to it **or** populate it via the APIs.

## Add fields to the new table

1. In the **Tables** screen, hover the table you want to alter and click **New field**.
2. Select a type for the new field and click **OK**.
3. Set field properties:
    * Enter a *name* to be used as the label.
    * Enter a *database table* beginning with **x_** to identify it in the schema.
    * Optionally set other properties. The type determines what's available.
4. Click **OK** to save the new field (runs `alter table y_mynewtable add column x_mynewfield ...`).
5. Continue adding more fields. Click **Restart NetServer** when you're done.

> [!TIP]
> To make a field mandatory, select **Cannot be empty**.

## Add data to the new table

1. In Service, click **Requests** and then click **Tables**.
2. Hover the table you want to add data to and click **New entry**.
3. Fill in the data for the new row and click **OK**.
