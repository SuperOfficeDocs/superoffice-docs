---
uid: help-en-ui-extra-menu-properties
title: Menu properties
description: Menu properties
author: SuperOffice RnD
date: 04.24.2023
keywords: Service
content_type: reference
language: en
---

# Menu properties

[!include[Legacy](../includes/legacy-extra-menus.md)]

Here you can edit the properties of options on extra menus and web panels.

* **Base Program**: Select a base program if you want the content of the URL field to be added to a select base program. For this to work, the text in the URL field must start with &action=...

* **URL**: The URL to be executed when the menu is clicked.

* **Append ID**: Automatically appends the ID of the current entry to the end of the URL.

* **Return to same screen**: Checking this box will automatically return the users to the screen where the button (or similar) was clicked. Otherwise the users would have to do this manually.

  * Example of when to use this option: If you create a button (macro) in the Request screen to change the category of the request, you also want to return to the same request after the button is clicked.

  * Example of when NOT to use this option: If you create a button (script) that displays a lot of information on the screen, then you do not want this checked, because you want to view the information on the screen. The same goes for external URLs, because you want to go to the website when you click the button.

* **Append &lt;usec&gt;**: (NOT RECOMMENDED), not necessary since v8.5. &lt;usec&gt; is the session key for the NetServer session. To make a web panel work with NetServer using authentication, this key must be included.

  > [!include[Usec Forbidden Online](../../../../includes/usec-forbidden-online.md)]

* **Target**: Target for the URL. You can select which window the URL will open in, by entering the window instance name in the **Target** field. You can enter "_blank" if you always want to open a new window/tab or, for example, "customer" to open a separate window for this menu option or a group of menu options.

* **URL to icon**: If you want your own custom icon for the extra menu, type in the URL for the image here.

* **Position**: Indicates the position of the extra menus (0 = top).
