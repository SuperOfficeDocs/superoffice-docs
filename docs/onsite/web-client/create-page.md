---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_page_in_web       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Creating a new page  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite         # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Creating a new page

There are at least three things you need to do when adding a new page to SuperOffice:

* Create a new page configuration file
* Define the new page in the SoApplicationConfiguration.config
* Add a link to the new page from e.g. the SoNavigatorPanel or SoButtonBarPanel configuration files

In addition, if you are using your own web controls, you need to define these in the SoObjectMapping configuration file. In the example we will only be using standard web client controls, so we will not be using the SoObjectMapping.config. The page we will create is a variant of the Contact card, showing information from the current contact and all connected persons for that contact.

## Page Configuration

Just to set the mood right, here is the complete configuration file for our demo page:

```xml
<page id="DevNetContactDialog">
  <title>DevNet Custom Contact Dialog</title>
  <data>
    <datahandlers>
      <datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler" />
      <datahandler id="ArchiveColumnConfigDataHandler" type="ArchiveColumnConfigDataHandler" />
      <config>
        <archivecolumninfos>
          <archivecolumninfo guiname="DevNetContactPersonArchive" providername="person" />
        </archivecolumninfos>
      </config>
    </datahandlers>
  </data>
  <panels>
    <panel id="DevNetContactPanel" type="SoDialogPanel" soprotocol="devnetcontact" paneltype="Main" placeholderid="MainPlaceHolder" >
      <cards>
        <card id="DevNetContactCard" type="SoDialogCard" placeholderid="DialogCardPlaceHolder" cardtype="MainCard" >
          <views>
            <view id="ContactMainView" type="SoPlainView" soprotocol="devnetcontactmain" current="contact">
              <caption>[SR_COMMON_CONTACT]</caption>
              <tooltip></tooltip>
              <controlgroups>
                <controlgroup id="mainHeadergroup" type="SoControlGroup" position="absolute" top="5px" left="5px" right="20px" >
                  <controls>
                    <control id="ContactMainHeaderControl" type="ContactHeader">
                      <datasource>ContactEntityDataHandler.ContactEntity</datasource>
                      <config>
                      </config>
                    </control>
                  </controls>
                </controlgroup>
              </controlgroups>
              <triggers>
                <trigger type="current">contact</trigger>
              </triggers>
            </view>
            <view id="ContactPersonArchiveView" type="SoView" soprotocol="devnetcontactpersons" >
              <caption>[SR_PL_PERSONS]</caption>
              <tooltip></tooltip>
              <controlgroups>
                <controlgroup id="mainpersongroup" type="SoControlGroup" position="absolute" left="0px" right="0px" top="0px" bottom="0px">
                  <controls>
                    <control id="ContactPersonArchive" type="SoArchiveControl" width="100%" top="0px" left="0px" height="100%" position="absolute" >
                      <config>
                        <restrictions>
                          <restriction name="contactId" operator="=" binding="current">contact</restriction>
                        </restrictions>
                        <providername>person</providername >
                        <archivecolumninfo-datasourcename>ArchiveColumnConfigDataHandler.ContactPersonArchive</archivecolumninfo-datasourcename>
                        <showheader>true</showheader>
                        <showtoolbar>true</showtoolbar>
                        <defaultsort>rank</defaultsort>
                        <current>person</current>
                        <linkhint-prefix>personarchive:</linkhint-prefix>
                        <dblclick-action>javascript:Dialog.open('Person','person[dialog=stop].main[mode=edit;new=true]?person_id=0','ContactPersonArchiveArchiveControl.RefreshList()');</dblclick-action>
                      </config>
                    </control>
                  </controls>
                </controlgroup>
              </controlgroups>
              <triggers>
                <trigger type="current">contact</trigger>
                <trigger type="current">person</trigger>
              </triggers>
            </view>
          </views>
          <config>
            <headerviews>
              <viewref>ContactMainView</viewref>
            </headerviews>
            <tabbedviews top="40px" bottom="0px">
              <viewref>ContactPersonArchiveView</viewref >
            </tabbedviews>
            <footerviews>
            </footerviews>
          </config>
        </card>
      </cards>
      <config>
      </config>
    </panel>
  </panels>
</page>
```

This might look intimidating at first glance, but there is logic to it all. And what's more, you can replace pretty much everything with your own controls, data handlers, etc that extend the ones from the web framework.

Every page is defined with the page element. Every page needs a unique id. To view all existing pages already defined in SuperOffice, have a look at SoApplicationConfiguration.config; all pages are defined in the pages section.

When examining the pages, notice that the id of the pages do not match the ids defined in the corresponding page configuration files. The way SuperOffice knows about pages is by defining them in SoApplicationConfiguration.config.

> [!NOTE]
> All ids here need to be specified in lowercase.

`<page id="devnetcontact" type="dialog" height="500px" width="650px" />`

The ID of the page is "devnetcontact", and since the page is of type "dialog", the ID of the page itself will have to be like this (from the config file listed above):

`<page id="DevNetContactDialog" >`

In the page configuration file you do not need to use lowercase for the ID.

In addition, notice that the name of the config file itself also has its own naming convention, where every page needs to be named using the following syntax;

`SoPage.config`

The page ID in this case would be the one from the definition in *SoApplicationConfiguration.config*, so the name of our file will be *SoDevNetContactPage.config*.

A page in SuperOffice consists of at least these three main elements, with their sub-elements;

```xml
<page>
  <data>
    <datahandlers>
      <datahandler />
    </datahandlers>
  </data>
  <panels>
    <panel>
      <cards>
        <card>
          <views>
            <view>
              <controlgroups>
                <controlgroup>
                  <controls>
                    <control />
                  </controls>
                </controlgroup>
              </controlgroups>
            </view>
          </views>
        </card>
      </cards>
    </panel>
  </panels>
</page>
```

Every element: dataHandler, panel, card, and view, are all elements that you will find defined in the SDK, and all of them are declared with at least an id and a type. The id needs to be unique within the current page, and the type declares e.g. the type of DataHandler to use. You can of course extend all of the standard objects and use your own versions if you need to make changes to any of these, like e.g. creating your own DataHandler for the Sales page to extend what happens when you click the Save-button. We will be looking into creating our own DataHandlers later in this series.

## Adding Controls

In our demo page we have two elements defined, which is actually where all controls will be placed:

`<view id="ContactMainView" type="SoPlainView" soprotocol="devnetcontactmain" current="contact" />`

`<view id="ContactPersonArchiveView" type="SoView" soprotocol="devnetcontactpersons" />`

The first view is defined as type SoPlainView, which has no borders, whereas the second one is type SoView, which does have borders, and is ideal to use inside a tab control.

The View object has the following properties (and more):

* caption used on the tab (if the view is inside a tab control)
* Tooltip: text showing when placing your mouse (hovering) over the caption
* placeholder for one or more object elements
  * typically of type SoControlGroup
    * placeholder for one or more object elements
      * here's an actual user control!

Both and are optional, and are actually only useful if your view resides within a tab control.

We are using two different types of controls in our demo page:

* One of type ContactHeader, which is the standard user control used in the Contact card for showing the name and flag of the current company.
* One of type SoArchiveControl, which is a more general control using the new ArchiveProviders

Here's the definition of the ContactHeader control;

```xml
<control id="ContactMainHeaderControl" type="ContactHeader">
  <datasource>ContactEntityDataHandler.ContactEntity</datasource>
  <config>
  </config>
</control>
```

The only thing you need to specify for using this control is the datasource, which is one of the datahandlers that are defined in the section;

`<datahandler id="ContactEntityDataHandler" type="ContactEntityDataHandler" />`

You can think of it as declaring a variable of type ContactEntity that you call ContactEntityDataHandler. So when defining datasource the for the control we can use the id of the datahandler (or the name of the variable if you will), to reference properties within the instance of that object. In this case we have access to the ContactEntity, which is actually an instance of the ContactEntity from the service layer, and it will contain all properties as expected from an entity. Actually the ContactHeader control only uses a couple of these properties, you can create your own control for showing what you like.

Let's move on to the more dynamic ArchiveControl;

```xml
<control id="ContactPersonArchive" type="SoArchiveControl" width="100%" top="0px" left="0px" height="100%" position="absolute">
  <config>
    <restrictions>
      <restriction name="contactId" operator="=" binding="current">contact</restriction>
    </restrictions>
    <providername>person</providername>
    <archivecolumninfo-datasourcename>ArchiveColumnConfigDataHandler.DevNetContactPersonArchive</archivecolumninfo-datasourcename>
    <showheader>true</showheader>
    <showtoolbar>true</showtoolbar>
    <defaultsort>rank</defaultsort>
    <current>person</current>
    <linkhint-prefix>personarchive:</linkhint-prefix>
    <dblclick-action>javascript:Dialog.open('Person','person[dialog=stop].main[mode=edit;new=true]?person_id=0','ContactPersonArchiveArchiveControl.RefreshList()');</dblclick-action>
  </config>
</control>
```

The things to note about this definition are:

* The definition tells the control to add a restriction saying "contactId = current contactId" when retrieving data. The restriction defined here is used to create one or more ArchiveRestrictionInfo instances that establish a criterion. This effectively is similar to a WHERE clause in an SQL statement.
* The specifies what ArchiveProvider to use. We are using the standard one for Person, but you could easily create your own.
* Defines what set of columns to use (more about that below)

The other settings are pretty self-explanatory.

An SoArchiveControl object also needs a datahandler, one specifically to fetch the correct columns that will be available in the archive control.

```xml
<datahandler id="ArchiveColumnConfigDataHandler" type="ArchiveColumnConfigDataHandler">
  <config>
    <archivecolumninfos>
      <archivecolumninfo guiname="DevNetContactPersonArchive" providername="person" />
    </archivecolumninfos>
  </config>
</datahandler>
```

This datahandler is different in the way that it has its own section for specifying which columns to use in the element.

## Archive columns

We are using the SoArchiveControl for showing a specified set of columns from data defined by an ArchiveProvider. The previous section covered the definition of the datahandler and the control using the archive architecture, and now we'll be looking at how to define what columns to show/ use.

The file containing the definition of all archive column sets is SoArchiveColumnList.config.

The file has an section with many object elements. The Archive object has three different sets of columns; Mandatory, Default and Ignore.

We will only be defining Default columns, which are the ones shown in e.g. a person list when using the PersonArchiveProvider.

To define your own set of columns, simply add a new element (preferably at the end), and specify the name of the provider in addition to a unique guiname. Ensure both attributes, providername and guiname, are lowercase.

Here's the one used from our demo page:

```xml
<archive providername="person" guiname="devnetcontactpersonarchive">
  <columns type="default">
    <column name="mrMrs" />
    <column name="firstName" />
    <column name="lastName" />
    <column name="title"/>
    <column name="personDirectPhone/formattedNumber" />
    <column name="email/emailAddress"/>
  </columns>
  <columns type="mandatory"></columns>
  <columns type="ignore"></columns>
</archive>
```

As you can see, we are using the standard Person provider, and we have defined a set of default columns. The only thing left for us to open our new dialog from SuperOffice is to add a link to it.
