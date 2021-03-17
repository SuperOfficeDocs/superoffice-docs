---
# Mandatory fields.
title: display_image_from_blob_ws       # (Required) Very important for SEO.
description: How to display an image from the Blob table using services # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: services
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to display an image from the Blob table (services)

All pictures are stored in the `BinaryObject` table in the database. You can retrieve such information using `SoCore` and `SoDatabase` DLLs.

In this example, we display the image `Name`, which is contained in a `SelectableMDOListItem` object. We use the `IMDOAgent`’s `GetSelectableList` method to retrieve the information:

![01][img1]

## Display image list

Following is the code for retrieving and displaying the image list in the ListBox.

[!code-csharp[CS](includes/displayimagelist-services.cs)]

The `GetSelectableList` method requires 4 parameters:

* the image types that we want (project images)
* a Boolean value that determines whether to retrieve the list as a flat list
* any additional information we need to send
* a Boolean value that indicates whether to include only history values

## Display selected image

Once the list is displayed, the user will be able to select a name of which he wants to view the project image. The method below shows us how we can do this.

[!code-csharp[CS](includes/display-image-services.cs)]

Above, we have used the `GetSelectableListWithRestriction` method and passed the image types, any additional information, and the ID of the item that was selected from the ListBox. This will retrieve a `SelectableMDOListItem`.

To get the image we need to use the `IBLOBAgent`. By using its `GetBlobStream` method, we can get the image into the `Stream`, which in turn can be used to display the image inside the PictureBox. The ID of the item contained in the `SelectableMDOListItem` should be passed to `GetBlobStream()`.

<!-- Referenced images -->
[img1]: media/image001.jpg
