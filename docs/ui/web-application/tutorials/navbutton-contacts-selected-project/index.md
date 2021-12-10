---
title: How to add a new panel
uid: pb_usercontrols_tutorial_mypage
description: How to add a panel and link it from the navigator
author: Tony Yates
so.date: 06.24.2016
keywords: pagebuilder
so.topic: tutorial
so.client: web
so.envir: onsite
---

# How to add a new panel

In this tutorial, we are going to add a new button to the navigator which triggers a new panel.

## Add a new navigator button

The SoButton control is a standard ASP.NET button control inherited from `System.Web.UI.WebControls.Button`. It exposes all properties that a button control has. The only property that is set is the CSS class property: The SoButton will have the look defined in the INPUT.sobutton CSS definition.

The following tutorial shows how we can add a button to the Navigator panel by making modifications to the *SONavigatorPanel.config* file.

### Config

[!code-xml[XML](includes/navigator-panel.xml)]

### Walk-through

What we have done is added a code segment to the *SoNavigatorPanel.config* file so that a new button would be visible in the navigator panel. The most important element is `onclick`, which provides the navigation for the button. It defines the Javascript to be used to call the `page_id`. Here, the Javascript used is the `PageUpdate` and the `page_id` is *test*. Test is the SoProtocol of the panel created by us.

> [!NOTE]
> IIS should be restarted to make all changes take effect before refreshing SuperOffice.

Alternatively, you can enable the `CacheConfigurations` parameter in the [ClientConfigurationProvider section][1] of the *web.config* file to force the PageBuilder to load the config files from disk every time. Turning on this option will cause SuperOffice to run more slowly.

The new button should now be visible in the Navigator panel on the left side of the screen. By clicking the button, we would be able to our **Test** page (Custom Page).

![04][img1]

## Add page

This is the code for our new page.

[!code-xml[XML](includes/test-page.xml)]

The ID in the app settings determines the file name. The `panel reference="Test"` implies the existence of a *SoTestPanel.config* file containing the definition of the panel. And a reference to this page should be placed in the *SoApplicationConfiguration.config* file.

```XML
<?xml version="1.0" encoding="utf-8" ?>
<applicationsettings defaultprefsection="SuperMode">
  <pages prefsection="SuperMode" prefkey="MainPanel">
    <!--Some other Page references-->
    <!--Reference to our page-->
    <!—The id determines the file name. The page would be called SoTestPage.config-->
    <page id="test" type="mainpage" function-right="hide-company"/>
    <!--Some other Page references-->
  </pages>
  <currents>
    <!--Some current tab references-->
  </currents>
</applicationsettings>
```

The `page` element for our page should be added between the `pages` tag of the file.

> [!NOTE]
> All ID attributes should be in lower case since these will be matched with the SoProtocol query string pages. The query pages map the panels with the SuperMode in the database.

## Putting it together

In this tutorial, we have created a panel including cards, views, and control which is used by the page that has been created earlier.

The following code segment is associated with the panel that we have created.

[!code-xml[XML](includes/test-panel.xml)]

When saving the code it should be saved under the file name *SoTestPanel.config*.

The overall goal of our panel is to display Contact details in the Contact view and then to display data related to that Contact's selected project in the Project view. The Calendar and the NotePad views are not binding on any information on the Contact Card or the Archive Card. The archive Card contains a list of projects relating to the Contact details displayed in the Contact Card.

The different parts of the interface:

![05][img2]

The overall view of our page, which is linked to our button **My Page**:

![06][img3]

It consists of 4 panels and multiple cards and views.

<!-- **See Also:** System.Web.UI.WebControls.Button -->

<!-- Referenced links -->
[1]: ../../../../../data-access/docs/netserver/config/clientconfigurationprovider.md

<!-- Referenced images -->
[img1]: media/image004.jpg
[img2]: media/image005.jpg
[img3]: media/image006.jpg
