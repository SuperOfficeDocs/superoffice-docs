<!-- markdownlint-disable-file MD041 -->
### Configure the feed in Outlook

RSS feeds can be subscribed through Microsoft Office Outlook 2007. The RSS subscriptions are kept in a separate folder along with the mail folders in Outlook 2007. Once subscribed, RSS feeds can be read the same way emails are read. When you click a particular feed all the posts appear in the same format as regular email in the mail reader pane.

To subscribe to RSS in Outlook 2007:

1. Go to Tools, then Account Settings.
2. Click RSS Feeds tab and Click **New** to add a new RSS Feed.
3. Enter the URL of the feed as shown below.

Now you can see a folder under *RSS Feeds* main folder with the name of the feed.

![RSS feeds folder -screenshot][img1]

### General settings

For the application to run, some modifications are required in the web configuration file. The following section illustrates the modifications required in the authentication section and the database section of the configuration file.

[!code-xml[XML](../rss-webconfig.xml)]

The authentication mode is set to *Forms*, to enable custom user authentication. Here, the `loginUrl` points to the application's custom login page.

Further, the Database information has to be modified.

### Add references

To run the sample code, after we have updated the *web.config* file, we have to add the following references:

* SOCore.dll
* SODataBase.dll
* SuperOffice.Legacy.dll
* SuperOffice.Services.dll
* SuperOffice.Services.Impl.dll

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../media/image035.jpg
