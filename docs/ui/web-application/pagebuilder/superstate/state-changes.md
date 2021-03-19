---
title: superstate_state_changes
description: What causes SuperState to change?
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: concept
so.client: web
so.envir: onsite
---

# What causes SuperState to change?

All the user's GET requests and callbacks will lead to a change in the SuperState. A **GET request** is a request for a whole page in the SuperOffice application. For example, if the user is in the Company view and he changes his current view to the Selection view it will result in getting a whole page from the system. In a scenario like this, the SuperState will use the **ConfigurationManager** to get the page config data that describes the selection page and use the **SuperStateManager** to get the selection-data that is shown on the page, either from the cache or the database. The user’s GET request resulted in a change in the SuperState, which will hold all the data that was changed in the cache for future reference.

A **callback** is a request that is triggered within a page, for example when you click on the dog ears that appear in the main card.

![04][img1]

When you click on the dog ears, it would just refresh the card since SuperOffice uses Ajax to render parts of a webpage. If the card is marked in the config as being triggered, it will also get updated.

## Triggers

A **trigger** is used by the PageBuilder to determine if a panel, view, or control needs to be redrawn after the SuperState has changed. For web, triggers are defined with the trigger element. The Contact page in the web GUI, SoContactPanel.config, consists of three cards and each card contains multiple views. Each of the views in the different cards is triggered by certain information displayed.

For example, if the archive card contains the contacts of the company the archive will also get refreshed since the Contact archive is declared in the company panel config as being triggered by the current company. This means that SuperState will do the necessary calculation for which parts of the page need to be refreshed and it will get all the config data of the parts of the page that needs to be updated. If the data is in the cache, it will fetch them from the cache or if it is not there it will fetch them from the database and hand them over to the page builder to build the page and render. As in all cases, the data that got changed will be stored in the cache.

Let's look at a page:

![05][img2]

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

> [!NOTE]
> The `view` element declares the soprotocol name for this part of the page. When SuperState sees the soprotocol name *personarchive*, it can ask the PageBuilder to build the view with that soprotocol name.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image004.jpg
[img2]: media/image005.jpg
