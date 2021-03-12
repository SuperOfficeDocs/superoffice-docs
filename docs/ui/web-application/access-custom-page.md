---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: access_custom_page_in_web # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Accessing custom pages # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Accessing custom pages

To access your own pages, you will need to add links to them from somewhere. You can place links anywhere, really, but the most obvious places would be either the menu on the left side or the one in the bottom of the main page. The approach for doing so is exactly the same whichever one you choose.

The menu configuration files are *SoNavigatorPanel.config* and *SoButtonBarPanel.config* for the left and bottom menus respectively.

To add a new button on the left menu, we add a new element in the **ButtonGroup** controlGroup inside the **NavigatorView** view;

```xml
<control id="DevNetContact" type="SoToolButton">
  <caption>DevNet Custom Contact</caption>
  <tooltip>Our own contact dialog</tooltip>
  <menu>
    <context>navigator</context>
    <id binding="none">0</id>
    <position>below</position>
    <click>left</click>
  </menu>
  <config>
    <onclick>javascript:Dialog.open("devnetcontact","devnetcontact[dialog=stop]");</onclick>
    <passiveimage>images/toolicons/btn-sale-passive.png</passiveimage>
    <disabledimage>images/toolicons/btn-sale-disabled.png</disabledimage>
    <activeimage>images/toolicons/btn-sale-active.png</activeimage>
    <hoverimage>images/toolicons/btn-sale-hover.png</hoverimage>
    <width>70</width>
    <textalign>right</textalign>
  </config>
  <function-rights>
    <function-right type="hide">hide-inbox</function-right>
  </function-rights>
</control>
```

All the properties above should be pretty self-explanatory. The most important setting is the onclick element, which defines the javascript call to open the dialog using the page id, in our case "devnetcontact".

You should restart IIS to have all your changes take effect before you refresh SuperOffice. The new link icon should now be visible in the left side menu, and by clicking it our new page should open, showing the name of the current contact, in addition to the list of all persons for that contact.
