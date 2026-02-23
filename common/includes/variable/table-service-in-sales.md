<!-- markdownlint-disable-file MD041 -->
These are template variables from Service that can be used in Sales and Marketing document templates. Service also has [reply template variables][1].

| Variable | Description | Example |
|---|---|---|
| csbl | Base URL | Online: `http://online2.superoffice.com/Cust1234/CS/scripts/blogic.fcgi` / Onsite: `http://systemtest.superoffice.com/scripts/blogic.fcgi` |
| csbu | Base URL | Online: `http://online2.superoffice.com/Cust1234/CS/scripts/ticket.fcgi` / Onsite: `http://systemtest.superoffice.com/scripts/ticket.fcgi` |
| cscu | Base URL | Online: `http://online2.superoffice.com/Cust1234/CS/scripts/customer.fcgi` / Onsite: `http://systemtest.superoffice.com/scripts/customer.fcgi` |
| csiu | CgiUrlInternal | Online: `http://online2.superoffice.com/Cust1234/` / Onsite: `http://systemtest.superoffice.com` |
| csbn | CgiBin | /scripts |
| csre | RegistryExtension | .fcgi |
| csrm | Base URL | Online: `http://online2.superoffice.com/Cust1234/CS/scripts/rms.fcgi` / Onsite: `http://systemtest.superoffice.com/scripts/rms.fcgi` |
| csti | Base URL | Online: `http://online2.superoffice.com/Cust1234/CS/scripts/ticket.fcgi` / Onsite: `http://systemtest.superoffice.com/scripts/ticket.fcgi` |

## Using variables in URLs

To get SuperOffice Sales to parse Service variables (for example in a web panel) the variable must be followed by a ? character.

As an example, displaying an image through customer.fcgi, you can format it like this:

`<cscu>?action=getAttachment&id=xxx&key=xxxxxxxxxxx`

## Why you should use these variables

To ensure your customizations remain stable and functional even if the customer environment changes, you must use the available Service template variables in any URLs you construct—for example in web panels.

SuperOffice Online environments may move between hosts (for example: online2.superoffice.com/Cust1234 to app.superoffice.com/Cust1234).
If you hardcode URLs, your solution may break when such migrations occur.

By using variables like: 
`<csbl>?_sf=0&action=doScript&includeId=OurOwnScript` 
the URLs are generated dynamically. This ensures your customizations continue to work even if we relocate or reorganize the customer’s environment. 

> [!NOTE]
> The "-0" from the end is removed. That actually indicates if the image should be shown in a browser or saved to a disk. Using the above syntax, you can enable saving to disk by appending "&saveToDisk=1" at the end of the URL.

<!-- Referenced links -->
[1]: ../../../docs/en/knowledge-base/learn/reply-templates/template-variables.md

