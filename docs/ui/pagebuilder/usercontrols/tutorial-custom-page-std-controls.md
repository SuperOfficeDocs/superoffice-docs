---
title: pb_cust_page_std_controls
description: How to build a custom page with standard controls
author: Tony Yates
so.date: 06.24.2016
keywords: contact
so.topic: tutorial
so.client: web
so.envir: onsite
---

# How to build a custom page with standard controls

There are at least 3 things you need to do when adding a new page to CRM web:

1. **Create a new page configuration file**
2. Define the new page in the *SoApplicationConfiguration* file
3. Add a link to the new page from for example the SoNavigatorPanel or SoButtonBarPanel configuration files

>[!NOTE]
> If you use your own web controls, you must define these in the *SoObjectMapping* configuration file. This tutorial uses only standard CRM web controls, so we don't have to update *SoObjectMapping*.

The page we will create will be a variant of the **Contact** card, showing information from the current contact and all connected persons for that contact.

## Page configuration

Just to set the mood right, here is the complete configuration file for our demo page:

[!code-xml[xml](includes/sodevnetcontactpage.xml)]

This might look intimidating at first glance, but there is logic to it all. And what’s more, you can replace pretty much everything with your own controls, data handlers, etc that extend the ones from the SuperOffice framework.

Every page is defined with the `page` element.

### Page ID

**Every page needs a unique ID**: `<page id="DevNetContactDialog">` To view all existing pages, have a look at *SoApplicationConfiguration.config*. All pages are defined in the `pages` section.

> [!NOTE]
> The page IDs in *SoApplicationConfiguration.config* don't match the IDs defined in the corresponding page configuration files. All IDs here need to be lowercase. In the page configuration file, lowercase is not required for the `id` attribute.

The way to let SuperOffice know about our new page is by defining it in the *SoApplicationConfiguration.config* file.

```xml
<page id="devnetcontact" type="dialog" height="500px" width="650px" />
```

The ID of the page is *devnetcontact*, and since the page is of type "dialog", the ID of the page itself will have to be like this (from the config file listed above):

```xml
<page id="DevNetContactDialog">
```

### File naming

The name of the config file itself also has a naming convention, where every page needs to be named using the following syntax: So**PageId**Page.config

The pageId in this case would be the one from the definition in *SoApplicationConfiguration*, so the name of our file will be **SoDevNetContactPage.config**.

A page consists of at least these 3 main elements, with their sub-elements:

```xml
<title />
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
```

| Element | Description |
|--|---|
| title | specifies the title of your page. You can type in a title directly or use the localized text constants such as `[SR_COMMON_CONTACT]`. |
| data | contains a `datahandlers` element, which is simply a placeholder for one or more `datahandler` object elements, defining the data handlers used by the controls used on the page. |
| panels | a placeholder for one or more `panel` object elements, which in turn contains a `cards` placeholder for one or more `card` object elements.<br>The `card` element in turn contains a `views` placeholder for one or more `view` object elements, where we will be placing the controls we’ll be using. |

Every element I referred to as object elements (DataHandler, Panel, Card, View) are all objects that you will find in the web SDK, and all of them are declared with at least an `id` and a `type`. The ID needs to be unique within the current page, and the type declares for example the type of DataHandler to use. You can of course extend all of the standard objects and use your own versions if you need to make changes to any of these, such as creating your own DataHandler for the Sales page to extend what happens when you click the Save-button.

## Adding controls

### Views

In our demo page, we have 2 `view` elements defined, which is actually where all controls will be placed.

[!code-xml[xml](includes/sodevnetcontactpage.xml?range=20,37,38,66)]

The first view is defined as type SoPlainView, which has no borders, whereas the second one is of type SoView, which does have borders, and is ideal to use inside a tab control.

The View object has the following properties (and more):

| Property | Required |Description |
|--|---|---|
| caption | no | used on the tab (if the view is inside a tab control) |
| tooltip | no | text showing when placing your mouse (hovering) over the caption |
| controlgroups | yes | placeholder for one or more `controlgroup` object elements |
| controlgroup | yes |typically of type SoControlGroup |
| controls | yes | placeholder for one or more `control` object elements |
| control | yes | here’s an actual user control! |

> [!NOTE]
> The optional `caption` and `tooltip` are useful only if your view resides within a tab control.

### ContactHeader

We are using 2 different types of controls on our demo page:

* One of type ContactHeader, which is the standard user control used in the Contact card for showing the name and flag of the current company.
* One of type SoArchiveControl, which is a more general control using the new ArchiveProviders

Here’s the definition of the **ContactHeader** control:

[!code-xml[xml](includes/sodevnetcontactpage.xml?range=26-30)]

The only thing you need to specify for using this control is the data source, which is one of the data handlers that are defined in the `<page><data><datahandlers>` section:

[!code-xml[xml](includes/sodevnetcontactpage.xml?range=5)]

You can think of it as declaring a variable of type ContactEntityDataHandler that you call ContactEntityDataHandler. So when defining the `datasource` for the control, we can use the ID of the `datahandler` (or the name of the variable if you will), to reference methods and properties within the instance of that object. In this case, we have access to the ContactEntity, which is an instance of the ContactEntity from the service layer, and it will contain all properties as expected from an entity. The ContactHeader control only uses a couple of these properties, you can create your own control for showing what you like.

### ArchiveControl

Let’s move on to the more dynamic ArchiveControl;

[!code-xml[xml](includes/sodevnetcontactpage.xml?range=44-58)]

The things to note about this definition are:

* The `restriction` definition tells the control to add a restriction saying "contactId = current contactId" when retrieving data. The restriction defined here is used to create one or more ArchiveRestrictionInfo instances that establish a criterion. This is similar to a WHERE clause in an SQL statement.

* The `providername` specifies what ArchiveProvider to use. We are using the standard one for Person, but you could easily create your own.

* `archivecolumninfo-datasourcename` defines what set of columns to use (more about that below)

The other settings are pretty self-explanatory.

An SoArchiveControl object also needs a datahandler:

[!code-xml[xml](includes/sodevnetcontactpage.xml?range=6-12)]

This data handler is different in the way that it has its own `config` section for specifying which columns to use in the `archivecolumninfo` element.

## Archive columns

We are using the SoArchiveControl for showing a specified set of columns from data defined by an ArchiveProvider. The previous section covered the definition of the data handler and the control using the archive architecture, and now we’ll be looking at how to define what columns to show/ use.

The file containing the definition of all archive column sets is *SoArchiveColumnList.config*.

The file has an `archives` section with many `archive` object elements. The Archive object has three different sets of columns:

1. Mandatory
2. Default
3. Ignore

We will only be defining Default columns, which are the ones shown in for example a person list when using the PersonArchiveProvider.

To define your own set of columns, simply add a new `archive` element (preferably at the end), and specify the name of the provider in addition to a unique `guiname`.

Here’s the one used from our demo page:

```xml
<archive providername="person" guiname="devnetcontactpersonarchive">
  <columns type="mandatory">
  </columns>
  <columns type="default">
    <column name="mrMrs" />
    <column name="firstName" />
    <column name="lastName" />
    <column name="title"/>
    <column name="personDirectPhone/formattedNumber" />
    <column name="email/emailAddress"/>
  </columns>
  <columns type="ignore">
  </columns>
</archive>
```

As you can see, we are using the standard Person provider, and we have defined a set of default columns.

The only thing left for us to open our new dialog from SuperOffce is to add a link to it.

## Accessing custom pages

To access your own pages, you will need to add links to them from somewhere. You can place links anywhere, really, but the most obvious places would be the menus listed below. The approach for doing so is exactly the same whichever one you choose.

| Location | File |
|--|---|
| the menu on the left side | SoNavigatorPanel.config |
| the on the bottom of the main page | SoButtonBarPanel.config |

To add a new button on the left menu, we add a new `control` element in the "ButtonGroup" controlGroup inside the "NavigatorView" view:

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

All the properties above should be pretty self-explanatory. The most important setting is the `onclick element, which defines the javascript call to open the dialog using the page ID, in our case "devnetcontact".

You should restart IIS to have all your changes take effect before you refresh SuperOffice. The new link icon should now be visible in the left side menu, and by clicking it our new page should open, showing the name of the current contact, in addition to the list of all persons for that contact.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
