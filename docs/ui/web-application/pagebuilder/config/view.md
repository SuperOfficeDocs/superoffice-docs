---
title: View config files
uid: pagebuilder_config_view
description: View config files
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# View config files

A view represents the many faces a card in SuperOffice can take. The different views of a card appear in a card of a [panel config file][1] or a [card config file][2]. If our card has many views, the config data will appear inside a `card` element. If we extract a view, put it in another config file, and refer to it, then it becomes a **view config file**, which can only contain one view.

Looking at the view config file below, you can see that there is only one view defined.

[!code-xml[XML](includes/mainview.xml)]

The above config file represents only one view of the main card of the **Contact** page in SuperOffice.

A view configuration file defines the UI structure of a view and contains the layout of all controls in the view.

![PageFramework][img1]

```xml
<!-- SoExampleView.config -->
<view id="ExampleView" type="SoView" soprotocol="example"
      current="example" rendermode="display"
      minwidth="##MAINCARD.MINWIDTH##">
  <caption>View Caption</caption>
  <tooltip>Example Text</tooltip>
  <controlgroups>
    <controlgroup />
  </controlgroups>
  <config>
    <nopadding>true</nopadding>
    <dogear binding="preferences">Functions,DisableContactDogEar</dogear>
    <customcssclass />
    <watermark />
    <editmode />
    <header-controlgroup height="" />
    <footer-controlgroup height="" />
    <tab-controlgroups>
      <tab-controlgroup caption="" visibility="" onclientclick="">
    </tab-controlgroups>
    <no-entity-link tooltip="string value" linkcaption="string value"></no-entity-link>
  </config>
  <triggers>
    <trigger type="current">contact</trigger>
  </triggers>
</view>
```

## What is a view and how does a view config file come into existence?

Below is the MainView placed in the context of the surrounding panel and cards.

```XML
<?xml version="1.0" encoding="utf-8"?>
<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">
  <caption>[SR_COMMON_CONTACT]: [current:contact_name]</caption>
  <cards>
    <card id="ContactMainCard" type="SoTabbedCard" placeholderid="leftpanel" cardtype="MainCard">
      <views>
        <view id="MainView" reference="MainView"></view>
        <view id="more" type="SoView" soprotocol="udef" current="contact">
        <view id="interests" type="SoView" soprotocol="interest" current="contact"></view>
        <view id="WWW" reference="WWW" readonly="true"></view>
      </views>
    </card>
    <card id="ContactMiniCard" reference="MiniCard"></card>
    <card id="ContactArchives" placeholderid="bottom" type="SoTabbedCard" cardtype="ArchiveCard"></card>
  </cards>
  <config>
    <function-rights></function-rights>
  </config>
</panel>
```

Here we can see that the `views` element of `ContactMainCard` defines 4 views. (The ones available to the main card of the contact page.) The view with an ID like "MainView" references the view config file at the beginning of this section.

## controlgroup element

A view config contains config data of the control groups and, within the control groups, config data for the individual controls of a page. The PageBuilder framework may add controls to a page on information on the database. For example, The **Navigator** view can contain custom buttons that display web panels.

**A typical config of a control group:**

[!code-xml[XML](includes/mainview.xml?range=14-22)]

Here we can see that there are controls in a given control group section. The config data for the control is used to customize the control. For example, an *ArchiveList* control uses the config section to specify which columns to display as default.

Not all controls use the config section. From the `datasource` element, it will tell us which data provider will provide data for this particular control.

## Different view types

| Name | Description |
|---|---|
| [SoDialogView][3] | Used in dialogs only. |
| [SoDialogAbsoluteView][4] | Used in dialogs only. |
| [SoDialogHeaderView][5] | Used in dialogs only. |
| [SoDialogSimpleFooterView][6] | Used in dialogs only. |
| [SoDialogSimpleView][7] | Used in dialogs only. |
| [SoGenericView][8] | Basic view. |
| [SoPlainView][9] | Basic view. |
| [SoSystemView][10] | Not visible, but renders out all content in a hidden layer. |
| [SoTabbedView][11] | View with inline tabs |

## How to select a view

You can use SoProtocol strings in the URL to force a switch to a particular view:

* Open the contact page displaying the interest tab

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest`

* Open the **Contact** page displaying the **Interest** tab in the main card and displaying the month calendar in the minicard.

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest.minimonth`

* Open the **Contact** page displaying the **Interest** tab in the main card and displaying the **Activity** tab in the archive card and displaying the month calendar from the minicard.

  `http://localhost/SuperOfficeWeb/default.aspx?contact.interest.minimonth.activityarchive`

These links show us a direct way to open a page with wanted tabs. The SoProtocol name is declared on the view using an element in the config file. Otherwise, we can log in to the contact page, and then by clicking or by selecting the wanted views, we can get the same result.

<!-- Referenced links -->
[1]: panel.md
[2]: card.md
[3]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogView.htm
[4]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogAbsoluteView.htm
[5]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogHeaderView.htm
[6]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogSimpleFooterView.htm
[7]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_DialogSimpleView.htm
[8]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_DCF_Web_UI_Controls_GenericView.htm
[9]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_PlainView.htm
[10]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_SystemView.htm
[11]: https://community.superoffice.com/documentation/SDK/SO.Web.Application/html/T_SuperOffice_CRM_Web_UI_Controls_TabbedView.htm

<!-- Referenced images -->
[img1]: media/web-client-pagebuilder-framework2.png
