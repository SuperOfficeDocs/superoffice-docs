---
uid: help-en-create-role
title: Create role
description: Create role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create a role

> [!NOTE]
> Some functions in this topic require a separate licence (external users and anonymous users). See [Licences](../chap03/Licences_screen.md).

To create a role for associates in the company or for external users:

1. Click the **Roles** button in the Navigator (![icon](../media/Knapp_rolle_liten.bmp)).

2. Select one of the following tabs:
    * **Associates**: Here you can add roles for employees in your company.
    * ![icon](../OnPremises.png)**External**: Here you can add roles for external users.
    * ![icon](../media/question.bmp) <!-- Fix reuse ID=a3 -->
        ![icon](../OnPremises.png) There is only a single role for anonymous users and you cannot create a new one. See [Edit rights for anonymous users](Edit_rights_for_anonymous_users.md).

3. Click **Add** under the list. The **Create New Role** dialog opens.

4. Enter a name for the role in the **Role name** field.

5. Enter a description of the role in the **Description** field.

6. Select one of the following options:
    * Click the arrow (![icon](../media/pil_ned.bmp) ) next to the **Copy rights from**, and select the role you want to base the new role on.
    * Or
    * Click the arrow (![icon](../media/pil_ned.bmp) ) and select **Start with blank rights** to create the role from scratch.

7. Click **Save**. The new role is displayed in the **Roles** list.

8. Click the role name in the list to display the rights for the role in the **Data rights** tab.

9. Enter the data rights in the **Data rights** tab as described under [Set data rights for a role](Set_data_rights_for_role.md).  
    ![icon](../media/question.bmp) <!-- Fix reuse ID=a2 -->
    You can choose from these rights:

    <table data-cellspacing="0" style="width:100%; max-width:36.468%">
    
    <tbody>
    <tr>
    <td><p>Name</p></td>
    <td><p>Rights</p></td>
    <td><p>Tooltips</p></td>
    </tr>
    <tr>
    <td><p>None</p></td>
    <td><p>No rights</p></td>
    <td><p> </p></td>
    </tr>
    <tr>
    <td><p>Read</p></td>
    <td><p>Read rights</p></td>
    <td><p>R</p></td>
    </tr>
    <tr>
    <td><p>Create</p></td>
    <td><p>Read and create rights</p></td>
    <td><p>CR</p></td>
    </tr>
    <tr>
    <td><p>Update</p></td>
    <td><p>Read, create and update rights</p></td>
    <td><p>CRU</p></td>
    </tr>
    <tr>
    <td><p>Delete</p></td>
    <td><p>Read, create, update and delete rights</p></td>
    <td><p>CRUD</p></td>
    </tr>
    </tbody>
    </table>

    **C** = Create, **R** = Read, **U** = Update, **D** = Delete

10. If you are creating roles for associates: Click the **Functional rights** tab. In this tab you can determine which functions will be available for the role, e.g. mail merge, publishing, exporting selections and administrator access in Settings and maintenance.

    > [!TIP]
    > Hold the mouse pointer over a right to display more information about it.

11. To add a right: Select one or more rights in the **This role CANNOT** field, and click the right arrow ( ![icon](../media/Pil_hoeyre.bmp) ).

12. To remove a right: Select one or more rights in the **This role can** field, and click the left arrow ( ![icon](../media/Pil_venstre.bmp) ).

The changes are saved automatically.

## What would you like to do now?

[Add users](../chap07/Adding_users_web.md)
