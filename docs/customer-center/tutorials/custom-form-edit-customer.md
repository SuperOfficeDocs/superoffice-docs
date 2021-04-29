---
title: custom_form_edit_customer
description: Custom form in Customer Centre to edit a customer
author: {github-id}
so.date: 09.15.2011
keywords:
so.topic: tutorial
---

# Custom form - edit customer

This tutorial shows you how to create a custom form in the Customer Care Center to allow modifying a customer

By default, we have a page in the customer care center allowing the customer to change his/her name, password, and any extra fields, such as an address or interest flags used for subscriptions to eMarketing messages. In many cases, our standard page will suffice. However, if you need something a bit more customized, here is an example of how to create another page in the customer care center, allowing the customer to modify "something" :-)

Most pages in the customer care center use the simplified parser-language. In this scenario, I will rather use a CRMScript created from within Service. This also allows me to edit the script without having to access the disk on the Service server.

You can execute any script in eJournal from the customer care center, given that you have the id and the key for the script. The URL should be `.../bin/customer.exe?action=safeParse&includeId=the-include-id&key=the-key` where the-include-id and the-key are values you specify when creating the CRMScript.

![x][img1]

In this example, I have created a new CRMScript with the following values:

* Include-id: change-customer-information
* Key: test
* Body:

```html
%EJSCRIPT_START%
<%
Customer theCustomer;
theCustomer.load(getParserVariable("customer.id").toInteger());

if (getCgiVariable("ok") != "")
{
  theCustomer.setValue("firstname", getCgiVariable("firstname"));
  theCustomer.setValue("lastname", getCgiVariable("lastname"));
  theCustomer.setValue("x_address", getCgiVariable("address"));
  theCustomer.save();
  print("Information saved!");
}
else
{
  %>
  <form method='post' action='/bin/customer.exe?action=safeParse&includeId=change-customer-address&key=test&withFrame=1'>
  <table>
  <tr><td>First name:</td><td><input type='text' name='firstname' value='<% print(theCustomer.getValue("firstname")); %>'></td></tr>
  <tr><td>Last name:</td><td><input type='text' name='lastname' value='<% print(theCustomer.getValue("lastname")); %>'></td></tr>
  <tr><td>Address:</td><td><textarea name='address' rows='5' cols='50'><% print(theCustomer.getValue("x_address")); %></textarea></td></tr>
  <tr><td align='center' colspan='2'><input style='width: 100px' type='submit' name='ok' value=' Ok '></td></tr>
  </form>
  <%
}

%>
%EJSCRIPT_END%
```

Notice how the body is not in "core" CRMScript syntax, but rather in our "embedded CRMSript" format, which resembles PHP, ASP, and so on. As you can see, this is a format that by default is HTML, but that allows you to embed CRMScript between <% and %>. The first and last lines define the beginning and end of this embedded language section.

You can execute this script from your customer care center with the following URL. Note that for this particular scenario, I have added an extra field, `x_address`, to the `customer` table.

`http://.../bin/customer.exe?action=safeParse&includeId=change-customer-information&key=test&withFrame=1`

## Add to left menu

If you want to, you can add this item to the left menu of the customer care center. To do this, you will have to edit *framework.md* (in *c:\ejournal\templates\en\customer*) to add this item. You only want this screen for logged in customers, which means you will add something like this to your *framework.md*:

```html
<tr><td nowrap class="menuItemTd" ><a onmouseenter="imageFocus(this, true);" onmouseout="imageFocus(this, false);" class="menuItemA" href="%AuthProgram%&action=safeParse&includeId=change-customer-address&key=test&withFrame=1"><img border="0" class="menuItemImg" src="%WwwRoot%/graphics/customer/list_tickets%list_tickets_suffix%.gif">Custom form</a></td></tr>
```

It's just a copy of another menu line with the modified URL. You probably want to change the icon. This is how it looks:

![form 1][img2]

![form 2][img3]

<!-- Referenced image -->
[img1]: media/script.jpg
[img2]: media/form1.jpg
[img3]: media/form2.jpg
