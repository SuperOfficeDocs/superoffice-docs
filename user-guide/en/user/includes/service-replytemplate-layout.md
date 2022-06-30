# Service_replytemplate_layout

<p>To give each department in your company a custom layout for their correspondence, 
 you can create reply templates with different layouts. Each reply template 
 can be linked to a category representing a department. All outgoing replies 
 from the categories (departments) will be merged with the department specific 
 design.</p>
<p>Apart from the layout/formatting of the reply template, it must contain 
 the following template variables to be able to merge with the reply:</p>
<p style="font-style: italic;">[[IF:message.bodyHtml!=&quot;&quot;]]</p>
<p style="font-style: italic;">[[message.bodyHtml]]</p>
<p style="font-style: italic;">[[ELSE]]</p>
<p style="font-style: italic;">[[message.body]]</p>
<p style="font-style: italic;">[[ENDIF]]</p>
<p style="font-style: normal;"><br style="page-break-before: always;" />
See also <a href="https://community.superoffice.com/en/Technical/Blog/reply-templates-on-categories-in-service-what-is-that/" 
 target="_blank">Reply templates on Categories in Service... 
 what is that?</a></p>

