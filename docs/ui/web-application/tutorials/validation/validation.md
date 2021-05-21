---
title: Validation controls
uid: validation_controls_web
description: Validation controls
author: Tony Yates
so.date: 10.07.2011
keywords:
so.topic: tutorial
---

# Validation controls

The most common question about web client development today is "How do I prevent a save operation on a Sale or Appointment?" The question generally stems from some pretty sophisticated business rules that depend on user-defined fields and the dependency between them.

In this tutorial, I'm going to present an easy way to enforce complex business rules, and demonstrate how you can interact with the user and tell them what needs to be done before a save will succeed.

## Web client validation

Today there are three well-defined ways to enforce validation. They are:

* Write JavaScript that overrides the default control event handlers.
* Write a validation component that implements the SuperOffice.DCF.Web.UI.IValidation interface.
* Write application server-side NetServer Services event handlers.

The JavaScript solution, which I'm not going to talk anymore about in this article, is discussed in further detail [here][1].

NetServer web service event handing is discussed in further detail in [this article][2], and will not be discussed here.

Validation components, which I am going to be discussing in this article, are well documented in the SDK, and read more about them reviewing the [documentation covering the ValidationBase class][3].

Probably the most widely used validation component is the MandatoryValidator. The validator component in the code below is used by appending an element as a child in the element declaration.

`Datasource` is an important element because the data source defined here gets passed into the validator and is used to determine if the control is valid or not.

**Snippet of SuperOffice Markup Language (SOML) from SoAppointmentPanel.config:**

![x][img1]

This mechanism is used through the web client application to validate every control that requires validation.

The really cool thing about this is that we can use this same means to validate fields that interest us and interact with the user if something isn't quite right.

So how do we take advantage of this for our own benefit towards complex rule-based validation? We simply create a generic control for accepting a datasource, and creating a validator that will be responsible for validating the datasource of that control.

## The conceptual overview

In ASP.NET, control validation is a recursive process. This means that when a page checks its `IsValid` property, the page recursively iterates over, and calls `IsValid` on each and every child control on that page. Each child control on that page will then also recursively iterates over each child control it contains and checks the `IsValid` property for each child control as well.

As each control validates, the validation results of the collective ultimately determine the validation state of the entire page.

**Recursive control validation model:**

![x][img2]

Under many common scenarios, such as wanting to run custom validation on user-defined fields,  it's impossible to append an element because user-defined fields, and their layouts, are dynamic and build at runtime. It's also true when trying to validate child control on a built-in user-control that doesn't have a validation check on a child control value.

## Enter the code

I will write a simple generic control with the sole purpose of validating a data source and notify the user if any business rules are violated. The control is not going to display any content to a page.

To get started, open Visual Studio and create a new Class library project and call whatever you like - I called mine ValidationControls. In the project reference the following assemblies:

* SoCore.dll
* SuperOffice.CRMWeb.dll
* SuperOffice.DCF.dll
* SuperOffice.DCFWeb.dll
* SuperOffice.Plugins.dll

### Class ValidationControl

Rename the Class1 file `ValidationControl` and type in the code shown below. This control is going to be declared in an element in a configuration file. The base class, `ControlBase`, takes care of usual databinding chores and allows me to focus on what I want the control to do.

In this case, I want the control to output and run a block of JavaScript *if* validation for my control fails for any reason.

I do two things to ensure this validation is only invoked once. First I subscript to the `Page.PreRender` method to output the JavaScript when the control is invalid. Next, I override the default `IsValid` property to set a flag telling me this control has already been validated - which happens when the controls `PreRender` method is called.

The flag ensures the message box is only displayed when a user clicks the Save button and validation fails. If the data source is not valid, the save will not complete, the dialog or panel will stay in edit mode and the message box will display the reason why.

**Validation Control written in C#:**

![x][img3]

**Validation Control written in VB.NET:**

![x][img4]

### Class ValidationRules

Now create a new class file and call it `ValidationRules`, then write the code below.

The purpose of the ValidationRules class is to carry out the validation logic, the business rules, for the page or dialog the ValidationControl is placed on.

The data source defined in the controls SOML declaration is passed into the overridden `_validate` method. The value argument is that data source. Although not shown in this example, you will need to cast the object to the same datatype as the actual data source.

**Listing 3** is an example control element defined in the SoSalePage.config with the data source element pointing to the SaleEntity, which is used to populate all the controls on the Sale page.

**C# Validator class:**

![x][img5]

**Validator class written in VB.NET:**

![x][img6]

The control element ID can be any unique ID value. Just ensure it's not already used somewhere else on the page, otherwise, your page may not display properly.

The data source element can point to any datahandler data source currently defined in context. So what data sources are defined in context? For that, you need to look at the datahandlers section, found at the top of the page definition.

For each datahandler listed in the datahandlers section, there is any number of data sources defined inside each datahandlers `DataCarriers` collection. Each data source is defined as "object", so you will have to cast the argument named value to the appropriate datatype inside the `ValidationRules` `_validate` method.

**SuperOffice Markup Language (SOML) to include the validation control:**

![x][img7]

## Bring it Home

Now, like any `SoControl` element, the figure below demonstrates how I can place my `ValidationControl` on a page, and hook up my `ValidationRules` logic by including it in the element. Notice how it is the **class attributes** that map to the **type** definition in the configuration file.

**How Attribute Mapping Names are used to define the type in the configuration:**

![x][im8]

Hopefully, this will help make it all clearer. `ValidationControl` is responsible for displaying a message to the user, while the `ValidationRules` validator is responsible for running my business rules and returning whether the page is valid or not.

The `ValidationMessage` property becomes the control's tooltip, which is normally displayed when hovering the cursor over the Save button to inform the user about an error when something is wrong.

The `Tooltip` property is used by the `ValidationControl` as the text to display in a SuperOffice web client dialog message box.

Finally, compile the project and place the DLL inside the website *bin* directory.

This example demonstrates how to validate a SaleEntity on the Sale panel for version 7 and the Sale dialog for 6.

Now go ahead and place the control markup in the `SalePage` configuration somewhere. It's best to place it in a control group that you know is only loaded once for that page, for example, the same control group as the header control. Do NOT place it inside any of the tab view control groups.

For SuperOffice 6.3, the best place for this control is in the *SoSalePage.config* file, as the last control element in the following controls element path: ....

For SuperOffice 7.0, place the control declaration in the *SoSaleMainViewView.config* file, as the last control in the element.

If you have `CacheConfigurations` set to True in the *web.config*, remember to first log in and then flush the cached configuration from the database by appending and invoking "?flush" in the URL of the browser address bar, i.e. `http://crm.yourcompany.com/default.aspx?flush`.

The next time you try to edit and save a sale, you should observe that it's not possible to save and will see the message box with the error displayed.

## The correct way to validate the client

While the capability to validate an entire entity is possible, be aware that under certain conditions the entity passed into the validator is not going to contain all of the fields that you might expect. Underneath the web-client covers, hidden way deep down in the bowels of the data handlers (think of these as controllers), there exists a collection of data sources that may or may not be connected to the root entity shown in the browser.

So how do you access these 'out of sync' values to conduct validation? By narrowing your validations down to that single property - set the datasource you are checking to one property of the entity, not the entire thing. In the validator, you can also use the DataDispatcher to try and get current values from any datasource that resides in the data handler's data carrier collections. This will be discussed more soon.

There are other situations as well that circumvent external validation altogether. Such is the case in the `PersonNames` control that has replaced the old `SoTextBoxes` that once represented the `FirstName`, `MiddleName`, and `LastName` controls. Internal to the web control, it only checks its internal validator to ensure that the name in the person dialog meets the minimum requirement of at least containing a first name.

**Snippet from SoPersonPage.config:**

![x][img9]

If I create my own custom validator to ensure that the last name is also filled in, and append the validations markup, what do you think will happen?

**Appended a custom validator to the PersonNames (SoNameControl) control:**

![x][img10]

The custom validator, MandatoryFieldValidator, expects a config element that contains at least one datasource element. Each datasource element must contain one attribute (friendlyname) and one innerText entry to specify the datasource that is mandatory. When the `MandatoryFieldValidator` class is instantiated, the config element is passed into the `Initialize` method and the validator then loops over the datasource elements and populates a Dictionary with the datasources the control is expected to validate.

A valuable takeaway from the code shown below, specifically in the `_validate` method, is the use of the `DataDispatcher`. This is how you get current field values for controls that are displayed in the browser but not necessarily passed in with the main entity that may have been the datasource of a validator.

Unfortunately, while the control is instantiated and the `Initialize` method is invoked, the `_validate` method never gets called. The reason is that the `SoNameControl` overrides the Validate method internally and does not rely or invoke any other validators.

**The MandatoryFieldValidator class:**

![x][img11]

To ensure that a last name for a person is specified, we can make use of the validation control in the previous section and add the new MandatoryFieldValidator control to it.

**Custom validation of a specific field or property:**

![x][img12]

Then when a new person is created and the person does not have a last name, the user will be unable to save the current person until either the last name is filled in or the user clicks the **Cancel** button.

Using the `MandatoryFieldValidator` control, the error message will display the friendlyname text to the user, indicating which field must be filled in.

![x][img13]

## Conclusion

In this tutorial, I have shown you how to create a control and use it to validate any data source on any given page in the SuperOffice web client and display a message to the user if necessary.

This technique should be used when you want to add business logic to a page, and need to interact with the user when those business rules do not fulfill the business requirements.

<a href="../../../assets/downloads/webvalidation.zip" download>Click to download examples</a>

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/content/content/samples-and-code/web-client-sdk/overriding-default-save-button-functionality/
[2]: https://community.superoffice.com/en/content/content/webclient/Scripting-in-the-NetServer-World/
[3]: https://community.superoffice.com/Documentation/SDK/SO.WebGUI/html/b27602d5-7621-7792-966c-f1b7b659007d.htm

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
[img3]: media/validationcontrol.png
[img4]: media/validationcontrol-vb.png
[img5]: media/validationvalidator.png
[img6]: media/validationvalidator-vb.png
[img7]: media/image007.jpg
[img8]: media/validationmarkup.png
[img9]: media/persondialogpersonname.png
[img10]: media/personnamescontrol.png
[img11]: media/mandatoryfieldvalidator.png
[img12]: media/personnamevalidation.png
[img13]: media/errordialog.png
