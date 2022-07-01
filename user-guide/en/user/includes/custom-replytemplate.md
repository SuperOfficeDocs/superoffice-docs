To give each department in your company a custom layout for their correspondence, you can create reply templates with different layouts. Each reply template can be linked to a category representing a department. All outgoing replies from the categories (departments) will be merged with the department specific design.

Apart from the layout/formatting of the reply template, it must contain the following template variables to be able to merge with the reply:

\[\[IF:message.bodyHtml!=""\]\]

\[\[message.bodyHtml\]\]

\[\[ELSE\]\]

\[\[message.body\]\]

\[\[ENDIF\]\]

See also [Reply templates on Categories in Service... what is that?][1]

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/Technical/Blog/reply-templates-on-categories-in-service-what-is-that/
