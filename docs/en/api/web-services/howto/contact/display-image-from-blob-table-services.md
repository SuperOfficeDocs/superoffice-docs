---
uid: display-image-from-blob-ws
title: How to display an image from the Blob table (services)
description: How to display an image from the Blob table using services
author: Bergfrid Skaara Dias
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/contact/howto/services/display-image-from-blob-table-services
  - /en/api/netserver/web-services/howto/contact/display-image-from-blob-table-services
---

# How to display an image from the Blob table (services)

All pictures are stored in the `BinaryObject` table in the database. You can retrieve such information using `SoCore` and `SoDatabase` DLLs.

In this example, we display the image `Name`, which is contained in a `SelectableMDOListItem` object. We use the `IMDOAgent`’s `GetSelectableList` method to retrieve the information.

## Display image list

Following is the code for retrieving and displaying the image list in the ListBox.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;

//Method that displays the Image Name on the Listbox
private void DisplayImageList()
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Select a list of Project Images using the MDOAgent
    MDOAgent newMDOAgt = new MDOAgent();
    SelectableMDOListItem[] newSelLstArr = newMDOAgt.GetSelectableList("ProjectImage", true, "", false);

    foreach (SelectableMDOListItem newSelLst in newSelLstArr)
    {
      //Display the image name in the Listbox
      listBox1.Items.Add(newSelLst.Name);
    }
  }
}
```

The `GetSelectableList` method requires 4 parameters:

* the image types that we want (project images)
* a Boolean value that determines whether to retrieve the list as a flat list
* any additional information we need to send
* a Boolean value that indicates whether to include only history values

## Display selected image

Once the list is displayed, the user will be able to select a name of which he wants to view the project image. The method below shows us how we can do this.

```csharp
using System.IO;
using SuperOffice;
using SuperOffice.CRM.Services;

//Method that is invoked when an item is selected from the Listbox
private void listBox1_SelectedValueChanged(object sender, EventArgs e)
{
  using (SoSession newSoSession = SoSession.Authenticate("sam", "sam"))
  {
    //Retrieving the details of the selected image from the ListBox
    MDOAgent newMDOAgt = new MDOAgent();
    SelectableMDOListItem[] newSelLstArr = newMDOAgt.GetSelectableListWithRestriction("ProjectImage", "", listBox1.SelectedItem.ToString());

    //Using the BLOB agent retrieving the selected image
    BLOBAgent newBLOBAgt = new BLOBAgent();
    Stream newStream = newBLOBAgt.GetBlobStream(newSelLstArr[0].Id);
    pictureBox1.Image = Image.FromStream(newStream);
  }
}
```

Above, we have used the `GetSelectableListWithRestriction` method and passed the image types, any additional information, and the ID of the item that was selected from the ListBox. This will retrieve a `SelectableMDOListItem`.

To get the image we need to use the `IBLOBAgent`. By using its `GetBlobStream` method, we can get the image into the `Stream`, which in turn can be used to display the image inside the PictureBox. The ID of the item contained in the `SelectableMDOListItem` should be passed to `GetBlobStream()`.
