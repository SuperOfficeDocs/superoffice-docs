---
title: extra_menus
description: Extra menus
author:
so.date:
keywords:
so.topic:
---

# Extra menus

**Extra menus** are buttons, menus, links, shortcuts, lists and so on that you can add to SuperOffice Service to make something easily available.

## What can I add?

* URLs: Links to web pages or to specific records in SuperOffice Service.
* Screens: Shortcuts to specific screens.
* Scripts and macros: Buttons or menu options that trigger a script or macro.
* Selections: Shortcut to a selection.

## Where can I add extra menus?

**Top menu:**

* The **Status** tile on the dashboard
* Actions buttons and menu buttons in the main screens
* Menu buttons in the extra table view

**Navigator - additional options:**

* On the navigator buttons
* Under  **System settings > System design***
* On the **New** button in the top bar.

## Add function to menu button (actions)

To add a macro to the **Actions** button in the Company screen, Contact screen, Request screen, or Message tab:

1. Sign in to SuperOffice Service.
2. From the hamburger menu, select **System Design** and then select **Extra menus**.
3. Expand *Top menu*, point to one of the folders, and click **New menu**.
4. Enter menu properties.
    * Set **Label** to what you want the button text to be (keep it short).
    * Select **Use script** and then select your CRMScript.
    * Select where to insert your new menu item from the **Position** list (0 = top).
5. Click **OK**.
6. Test the result.

### Keyboard shortcuts (v. 3.1.8)

You can add keyboard shortcuts to the items in the extra menus by adding an ampersand **&** before the character you want to be the access key. For example, "M&y contacts".

The shortcut key will be shown with an underscore. To use the shortcut, press **Alt+ the selected character**. For example, Alt+y.

### Return to the same screen

This option is handy when you add buttons that update something and you want to **preserve the context**.

For example, if you create a button in the Request screen to change the category of the request, you also want to return to the same request after the button has been clicked.

**When NOT to use this option:**

You should not return to the same screen if it's an external URL or the button (script) displays a lot of information on the screen. In these cases, you want the user to be able to view the info you presented.

## Add navigator group

1. Open the **Extra menus** page.
2. Point to **Navigator** click **New menu**.
3. Set label and position for the group. Optionally select an icon.
4. Click **OK**. The new navigator group (currently empty) appears in the main menu.
5. Add menu button to new group.
6. Test the result.

If you link to an external website:

* **Don't** check Append ID or Append \<usec>.
* **Don't** check Return to same screen.
* Set Target to "_blank".

> [!TIP]
> Read more about the [main menu][1]

## Reference

### Menu properties

| Property              | Description                                                                 |
|:----------------------|:----------------------------------------------------------------------------|
| Base program          | Adds URL to the selected base program.<br>URL must start with `&action=`      |
| URL                   | The URL to be executed when the menu is clicked                             |
| Append ID             | Appends the ID of the current entry to the end of the URL (bool)            |
| Return to same screen | Whether to return the users to the screen where the action was clicked<br> If unchecked, users must do this manually |
| Append usec           | Includes the NetServer session key<br>Required for web panel authentication |
| Target                | Which window the URL should open in<br>"main": the html frame to which the output goes <br>"_blank" : always open a new window/tab<br>"customer" : open a separate window for this menu option or a group of menu options     |
| URL to icon           | Location of a custom icon for the extra menu                                |
| Position              | The position of the extra menu<br> 0 = top                                  |

<!-- Referenced links -->
[1]: https://github.com/superofficedocs/crmscript/blob/maion/docs/classes/mainmenu/mainmenu.md
