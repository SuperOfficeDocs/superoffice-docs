<!-- markdownlint-disable-file MD041 -->
These are template variables from Service which can be used in Sales & Marketing document templates. Service has also its own [template variables][1] used in reply templates.

| Variable | Description | Example |
|---|---|---|
| csbl | Base URL | `http://systemtest.superoffice.com/scripts/blogic.fcgi` |
| csbu | Base URL | `http://systemtest.superoffice.com/scripts/ticket.fcgi` |
| cscu | Base URL | `http://systemtest.superoffice.com/scripts/customer.fcgi` |
| csiu | CgiUrlInternal | `http://systemtest.superoffice.com` |
| csbn | CgiBin | /scripts |
| csre | RegistryExtension | .fcgi |
| csrm | Base URL | `http://systemtest.superoffice.com/scripts/rms.fcgi` |
| csti | Base URL | `http://systemtest.superoffice.com/scripts/ticket.fcgi` |

To get SuperOffice Sales to parse Service variables (for example in a web panel) the variable must be followed by a ? character.

As an example, displaying an image through customer.fcgi, you can format it like this:

`<cscu>?action=getAttachment&id=xxx&key=xxxxxxxxxxx`

> [!NOTE]
> The "-0" from the end is removed. That actually indicates if the image should be shown in a browser or saved to a disk. Using the above syntax, you can enable saving to disk by appending "&saveToDisk=1" at the end of the URL.

<!-- Referenced links -->
[1]: https://docs.superoffice.com/en/request/reply-templates/index.html
