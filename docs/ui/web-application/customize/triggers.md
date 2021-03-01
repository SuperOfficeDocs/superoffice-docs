---
title: pagebuilder_triggers
description: How triggers affect a view
author: Tony Yates
so.date: 06.24.2016
keywords: gui
so.topic: concept
so.client: web
so.envir: onsite
---

# How triggers affect a view

A **trigger** is used by the PageBuilder to determine if a panel, view, or control needs to be redrawn after the SuperState has changed. For web, triggers are defined with the trigger element. The Contact page in the web GUI, SoContactPanel.config, consists of three cards and each card contains multiple views. Each of the views in the different cards is triggered by certain information displayed.

For example, consider the following screenshot:

![05][img1]

The information displayed on Card 2 is based on the information displayed on Card 1. In other words, an update on Card 2 is triggered by a change in the Current Contact caused by card 1. Here's how:

```XML
<?xml version="1.0" encoding="utf-8"?>
<panel id="Contact" type="SplitterPanel" soprotocol="Contact" paneltype="Main" placeholderid="MainPlaceHolder">
  <caption>[SR_COMMON_CONTACT]: [current:contact_name]</caption>
  <cards>
  <!--Some other Code -->
    <card id="ContactArchives" placeholderid="bottom" type="SoTabbedCard" cardtype="ArchiveCard">
      <views>
        <!--Some other Code -->
        <view id="ContactProjectArchiveView" type="SoView" soprotocol="projectarchive" >
          <caption>[SR_PL_PROJECTS]</caption>
          <!--Some other Code -->
          <!--Code that relates to triggers Begins-->
          <triggers>
            <trigger type="current">contact</trigger>
          </triggers>
          <!--Code that relates to triggers Ends-->
        </view>
        <!--Some other Code -->
      </views>
    <!--Some other Code -->
    </card>
  </cards>
  <!--Some other Code -->
</panel>
```

> [!NOTE]
> Pay attention to the `triggers` element (3 lines).

Let's say that the view called *ContactProjectArchiveView* (inside the **ContactArchives** card) is based on the contact’s information displayed in Card 1. If we remove this element from the config file, the information displayed in the view will no longer be based on the Contact displayed in Card 1, and for all contacts, the same project details would be shown.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image005.jpg
