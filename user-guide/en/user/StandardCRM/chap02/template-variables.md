 CRM

# Template variables (CRM)

**Tip**: Here you can find some examples of how template variables can enrich your mailings and documents: [Template variables - examples](Template-variables-examples.md)

The topics below give an overview of different template variables in SuperOffice CRM, which you can use when you create template documents.

[How to use template variables](#Using-template-variables)

[Fill characters](#Fill-characters)

[Variables from the company card](#Variables-from-the-Company-card)

[Variables for a selected contact](#Variables-for-selected-contact)

[Variables for international addresses](#Variables-for-international-addresses)

[Variables from the Document dialog or from the system](#Variables-from-the-Document-dialog-or-from-the-system)

[Variables from the project card](#Variables-from-the-Project-card)

[Variables for the sender (contact card)](#Variables-relating-to-the-sender-Contact-dialog-)

[Variables from the sender’s own company card](#Variables-from-the-sender-s-own-company-card)

[Variables for sales](#Variables-for-sales)

[Variables for selections](#Variables-for-selection)

[Variables for appointments](#Variables-for-appointment)

[Variables for appointments corresponding to the iCal standard](#Variabler-for-avtaler-iCal)

[Variables for integration with web applications](#Variables-for-web-application-integration)

[Variables for Quote alternative](Template-variables.md#Variables-for-Quote-alternative)

[Variables for Quote info](Template-variables.md#Variables-for-Quote-info)

[Variables for Quote line](Template-variables.md#Variables-for-Quote-line)

[Quote line subscription variables](Template-variables.md#Quote-line-subscription-variables)

[Variables for SuperOffice Service](Template-variables.md#Variables-for-SuperOffice-Service)

## How to use template variables

The following sections list the different template variables, which you can use when creating template documents.

Here is a brief overview of how to use the variables in the templates:

* In documents of file type .doc in Office 2003 and older, you need to use angled brackets – &lt; &gt; – around variables instead of curly brackets – { } –.

<!-- -->

* The whole variable must be formatted using the same font and font size, and you must only use lowercase letters. However, if the **Use case-sensitive template variables** preference is enabled, the template variable can be formatted.
* You can mix normal text and variables in the template document: For example, you can enter template variables which retrieve a company’s name and address, type in standard text for the body of the letter and enter the variable for our contact to conclude the letter.
* You can also use fill characters in the template document (see [Fill characters](#Fill-characters)).
* The date and time in template variables are controlled by the PC's system clock.

> [!TIP]
> When you have created a new template document, you have to add it using the **Lists** screen in Settings and maintenance in order to use it in SuperOffice CRM.

## Fill characters

Sometimes you have to use fill characters in templates so that a field’s contents or formatting will not be changed or deleted if the content of a field is shorter than the length specified by the field variable.

Use the variable padd# to specify the fill character to use. Replace the \# character with the ANSI code of the character you wish to use as a fill character. You will usually find a list of ANSI codes in the manual for the program you are creating templates for.

SuperOffice CRM has default values for fill characters for the most commonly used word-processing and spreadsheet applications. A soft hyphen is usually used because it does not display on the screen or a printout. For applications where the set-up is unknown, SuperOffice CRM uses {padd32}, which is the ANSI code for a space.

> [!TIP]
> Microsoft Word uses {padd31} as a fill character.

If you do not want to use fill characters, use the template variable {padd0}.

> [!NOTE]
> This only works for document formats that are sequential, for example, Notepad and AmiPro templates without graphics.

When you use {padd0} you can write all the template variables without blank characters between the name of the template variable and the closing variable delimiter (}).

## Variables from the company card

**Note**: Address variables from the company card are so called "smart" template variables. This means that the system selects address data in a specific order. The variables in **bold text** below (such as **addr** and **city**) are smart template variables.

<!-- Fix reuse ID=a1 -->

When you use address variables from the company card, the system will select address data in the following order:

1. If the **Use as postal address** option is active for a contact in the company, the contact's address data will be used.
2. If the above option is not active, the company's address data will be used.
3. If the company's postal address is empty, the company street address will be used.

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>addr</p></td>
<td><p>Postal address line 1. If this is empty, street address line 1.</p></td>
</tr>
<tr>
<td><p>busi</p></td>
<td><p>Business.</p></td>
</tr>
<tr>
<td><p>cate</p></td>
<td><p>Category.</p></td>
</tr>
<tr>
<td><p>ccid</p></td>
<td><p>Company’s country code.</p></td>
</tr>
<tr>
<td><p>cf01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>cicn</p></td>
<td><p>Country name in English.</p></td>
</tr>
<tr>
<td><p>city</p></td>
<td><p>Postal town.</p></td>
</tr>
<tr>
<td><p>cl01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>cnt?</p></td>
<td><p>Country if different from the sender’s country.</p></td>
</tr>
<tr>
<td><p>cntr</p></td>
<td><p>Country.</p></td>
</tr>
<tr>
<td><p>cnty</p></td>
<td><p>County (for UK addresses).</p></td>
</tr>
<tr>
<td><p>code</p></td>
<td><p>Code.</p></td>
</tr>
<tr>
<td><p>cont</p></td>
<td><p>Our contact.</p></td>
</tr>
<tr>
<td><p>cozg</p></td>
<td><p>Line feed for internal post in Germany.</p></td>
</tr>
<tr>
<td><p>cozi</p></td>
<td><p>Postcode including country prefix (e.g. N-0163 for a postcode in Norway). Prefix is not used for Germany.</p></td>
</tr>
<tr>
<td><p>cozn</p></td>
<td><p>Line feed for Australian and UK treatment of counties and postcodes.</p></td>
</tr>
<tr>
<td><p>cphi</p></td>
<td><p>Company's phone number, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>cpho</p></td>
<td><p>Company’s phone number.</p></td>
</tr>
<tr>
<td><p>cpht</p></td>
<td><p>Company's phone number with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>cs01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>cspi</p></td>
<td><p>Main contact, ID</p></td>
</tr>
<tr>
<td><p>cspn</p></td>
<td><p>Main contact, full name</p></td>
</tr>
<tr>
<td><p>cszc</p></td>
<td><p>Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730).</p></td>
</tr>
<tr>
<td><p>cuid</p></td>
<td><p>Company ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>cwwi</p></td>
<td><p>The company's primary web address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>cwww</p></td>
<td><p>The company's primary web address.</p></td>
</tr>
<tr>
<td><p>czip</p></td>
<td><p>County and postcode (for UK addresses).</p></td>
</tr>
<tr>
<td><p>dept</p></td>
<td><p>Department.</p></td>
</tr>
<tr>
<td><p>faxi</p></td>
<td><p>Fax number, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>faxn</p></td>
<td><p>Fax number. The contact’s direct number, if available. Otherwise the company’s fax number.</p></td>
</tr>
<tr>
<td><p>faxs</p></td>
<td><p>Fax number. The contact’s direct number, if available. Otherwise the company’s fax number. Without spaces.</p></td>
</tr>
<tr>
<td><p>maii</p></td>
<td><p>The company's primary e-mail address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>mail</p></td>
<td><p>The company’s primary e-mail address.</p></td>
</tr>
<tr>
<td><p>name</p></td>
<td><p>The company’s name.</p></td>
</tr>
<tr>
<td><p>ndep</p></td>
<td><p>The company’s name and department</p></td>
</tr>
<tr>
<td><p>numb</p></td>
<td><p>Number.</p></td>
</tr>
<tr>
<td><p>orgn</p></td>
<td><p>The company’s organisation number.</p></td>
</tr>
<tr>
<td><p>padr</p></td>
<td><p>Postal address, line 1.</p></td>
</tr>
<tr>
<td><p>pad2</p></td>
<td><p>Postal address, line 2.</p></td>
</tr>
<tr>
<td><p>pad3</p></td>
<td><p>Postal address, line 3.</p></td>
</tr>
<tr>
<td><p>phoi</p></td>
<td><p>Phone number, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>phon</p></td>
<td><p>Phone number. The contact’s direct number, if available. Otherwise the company’s phone number.</p></td>
</tr>
<tr>
<td><p>sadr</p></td>
<td><p>Street address/office address, address line 1.</p></td>
</tr>
<tr>
<td><p>sams</p></td>
<td><p>First address line, including Mail Stop (for American addresses).</p></td>
</tr>
<tr>
<td><p>scit</p></td>
<td><p>Postal town for street address (for German addresses).</p></td>
</tr>
<tr>
<td><p>ssta</p></td>
<td><p>State/province for street address (for American, Canadian and Australian addresses).</p></td>
</tr>
<tr>
<td><p>stat</p></td>
<td><p>State/province (for American, Canadian and Australian addresses). (See also [cszc](#cszc).)</p></td>
</tr>
<tr>
<td><p>szip</p></td>
<td><p>Postcode for street address (for German addresses).</p></td>
</tr>
<tr>
<td><p>zici</p></td>
<td><p>Postcode and postal town (e.g. 0572 OSLO).</p></td>
</tr>
<tr>
<td><p>zino</p></td>
<td><p>Postcode prefix.</p></td>
</tr>
<tr>
<td><p>zipc</p></td>
<td><p>Postcode. (See also [cszc](#cszc).)</p></td>
</tr>
<tr>
<td><p>zipp</p></td>
<td><p>Postcode for street address.</p></td>
</tr>
</tbody>
</table>

## Variables for a selected contact

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>abdt</p></td>
<td><p>Date of birth.</p></td>
</tr>
<tr>
<td><p>acha</p></td>
<td><p>The contact's chat address</p></td>
</tr>
<tr>
<td><p>achi</p></td>
<td><p>The contact's chat address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>achp</p></td>
<td><p>The contact's chat address protocol</p></td>
</tr>
<tr>
<td><p>acid</p></td>
<td><p>Contact’s country code.</p></td>
</tr>
<tr>
<td><p>acit</p></td>
<td><p>Postal town. (See also [acsz](#acsz).)</p></td>
</tr>
<tr>
<td><p>acnt</p></td>
<td><p>County (for UK addresses).</p></td>
</tr>
<tr>
<td><p>acsz</p></td>
<td><p>Postal town, state/province and postcode (e.g. Bedford, MA 01730).</p></td>
</tr>
<tr>
<td><p>act?</p></td>
<td><p>Country (if different from the sender’s country).</p></td>
</tr>
<tr>
<td><p>actg</p></td>
<td><p>Line feed for internal post in Germany.</p></td>
</tr>
<tr>
<td><p>actr</p></td>
<td><p>Country.</p></td>
</tr>
<tr>
<td><p>adep</p></td>
<td><p>Department.</p></td>
</tr>
<tr>
<td><p>af01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>al01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>amai</p></td>
<td><p>The contact’s primary e-mail address.</p></td>
</tr>
<tr>
<td><p>amid</p></td>
<td><p>The contact's primary e-mail address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>anum</p></td>
<td><p>Number recorded for the contact.</p></td>
</tr>
<tr>
<td><p>apad</p></td>
<td><p>Postal address, line 1.</p></td>
</tr>
<tr>
<td><p>apa2</p></td>
<td><p>Postal address, line 2.</p></td>
</tr>
<tr>
<td><p>apa3</p></td>
<td><p>Postal address, line 3.</p></td>
</tr>
<tr>
<td><p>aphi</p></td>
<td><p>The contact's phone number, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>apho</p></td>
<td><p>The contact’s phone number.</p></td>
</tr>
<tr>
<td><p>apli</p></td>
<td><p>Support language ID</p></td>
</tr>
<tr>
<td><p>aret</p></td>
<td><p>Is the contact a former employee? True or False.</p></td>
</tr>
<tr>
<td><p>as01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>asal</p></td>
<td><p>Academic title (salutation).</p></td>
</tr>
<tr>
<td><p>asci</p></td>
<td><p>Support contact, ID</p></td>
</tr>
<tr>
<td><p>ascn</p></td>
<td><p>Support contact, full name</p></td>
</tr>
<tr>
<td><p>asmu</p></td>
<td><p>URL for subscription management</p></td>
</tr>
<tr>
<td><p>aspr</p></td>
<td><p>Support priority</p></td>
</tr>
<tr>
<td><p>asta</p></td>
<td><p>State/province. (See also [acsz](#acsz).)</p></td>
</tr>
<tr>
<td><p>atei</p></td>
<td><p>The contact's primary e-mail address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>atem</p></td>
<td><p>The contact's primary e-mail address. If no e-mail address is recorded for the contact, the company's e-mail address is used.</p></td>
</tr>
<tr>
<td><p>atfa</p></td>
<td><p>Direct fax (Attention Fax).</p></td>
</tr>
<tr>
<td><p>atfi</p></td>
<td><p>Direct fax, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>atfn</p></td>
<td><p>First name.</p></td>
</tr>
<tr>
<td><p>ati.</p></td>
<td><p>First name (first letter followed by stop).</p></td>
</tr>
<tr>
<td><p>atid</p></td>
<td><p>Selected contact's unique ID (person-id).</p></td>
</tr>
<tr>
<td><p>atin</p></td>
<td><p>First name (first letter).</p></td>
</tr>
<tr>
<td><p>atln</p></td>
<td><p>Last name.</p></td>
</tr>
<tr>
<td><p>atm?</p></td>
<td><p>Middle name (if middle name preference is set).</p></td>
</tr>
<tr>
<td><p>atmn</p></td>
<td><p>Middle name.</p></td>
</tr>
<tr>
<td><p>atmr</p></td>
<td><p>Mr/Ms field.</p></td>
</tr>
<tr>
<td><p>atms</p></td>
<td><p>Mail Stop (for American addresses).</p></td>
</tr>
<tr>
<td><p>atpc</p></td>
<td><p>Mobile phone (Attention Phone Cellular).</p></td>
</tr>
<tr>
<td><p>atpi</p></td>
<td><p>Mobile phone, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>atph</p></td>
<td><p>Home telephone (Attention Phone Home).</p></td>
</tr>
<tr>
<td><p>atpj</p></td>
<td><p>Home telephone, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>atpk</p></td>
<td><p>Pager, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>atpl</p></td>
<td><p>Other phone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>atpm</p></td>
<td><p>Mobile phone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>atpo</p></td>
<td><p>Position.</p></td>
</tr>
<tr>
<td><p>atpp</p></td>
<td><p>Pager (Attention Phone Pager).</p></td>
</tr>
<tr>
<td><p>atpt</p></td>
<td><p>Home telephone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>atti</p></td>
<td><p>Title.</p></td>
</tr>
<tr>
<td><p>attl</p></td>
<td><p>The contact's login name if he/she has login rights (Attention).</p></td>
</tr>
<tr>
<td><p>attn</p></td>
<td><p>The contact's full name.</p></td>
</tr>
<tr>
<td><p>avoa</p></td>
<td><p>The contact's VOIP address.</p></td>
</tr>
<tr>
<td><p>avoi</p></td>
<td><p>The contact's VOIP address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>avos</p></td>
<td><p>The sender's VOIP service (description).</p></td>
</tr>
<tr>
<td><p>awwi</p></td>
<td><p>The contact's primary web address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>awww</p></td>
<td><p>The contact's primary web address.</p></td>
</tr>
<tr>
<td><p>azip</p></td>
<td><p>Postcode. (See also [acsz](#acsz).)</p></td>
</tr>
</tbody>
</table>

## Variables for international addresses

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>fad1</p></td>
<td><p>Line 1 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad2</p></td>
<td><p>Line 2 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad3</p></td>
<td><p>Line 3 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad4</p></td>
<td><p>Line 4 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad5</p></td>
<td><p>Line 5 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad6</p></td>
<td><p>Line 6 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad7</p></td>
<td><p>Line 7 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad8</p></td>
<td><p>Line 8 in international addresses.</p></td>
</tr>
<tr>
<td><p>fad9</p></td>
<td><p>Line 9 in international addresses.</p></td>
</tr>
<tr>
<td><p>fada</p></td>
<td><p>Line 10 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadb</p></td>
<td><p>Line 11 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadc</p></td>
<td><p>Line 12 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadd</p></td>
<td><p>Line 13 in international addresses.</p></td>
</tr>
<tr>
<td><p>fade</p></td>
<td><p>Line 14 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadf</p></td>
<td><p>Line 15 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadg</p></td>
<td><p>Line 16 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadh</p></td>
<td><p>Line 17 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadi</p></td>
<td><p>Line 18 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadj</p></td>
<td><p>Line 19 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadk</p></td>
<td><p>Line 20 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadl</p></td>
<td><p>Line 21 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadm</p></td>
<td><p>Line 22 in international addresses.</p></td>
</tr>
<tr>
<td><p>fadn</p></td>
<td><p>Line 23 in international addresses.</p></td>
</tr>
<tr>
<td><p>fado</p></td>
<td><p>Line 24 in international addresses.</p></td>
</tr>
</tbody>
</table>

## Variables from the Document dialog or from the system

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>apid</p></td>
<td><p>Appointment ID.</p></td>
</tr>
<tr>
<td><p>atti</p></td>
<td><p>Title of the contact the document will be sent to.</p></td>
</tr>
<tr>
<td><p>attn</p></td>
<td><p>Selected contact in the **Document** dialog or text that is specified in the **Company** field for a recipient of the document.</p></td>
</tr>
<tr>
<td><p>dat1</p></td>
<td><p>Date in long format: d. MMMM yyyy (example: 6. December 2021). This variable will ignore any other date format.</p></td>
</tr>
<tr>
<td><p>date</p></td>
<td><p>Date in long format, e.g. 10 December 2004.</p></td>
</tr>
<tr>
<td><p>desc</p></td>
<td><p>Description of the created document.</p></td>
</tr>
<tr>
<td><p>df01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>dl01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>doid</p></td>
<td><p>Document ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>dope</p></td>
<td><p>Document, end date for publishing.</p></td>
</tr>
<tr>
<td><p>dops</p></td>
<td><p>Document, start date for publishing.</p></td>
</tr>
<tr>
<td><p>ds01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>dsug</p></td>
<td><p>Suggested document ID for the document ("SuggestedDocument Id"). Set to 0 when the document is not part of a sale/project guide.</p></td>
</tr>
<tr>
<td><p>file</p></td>
<td><p>Name of the document, without the path (e.g. SUPER001.DOC).</p></td>
</tr>
<tr>
<td><p>head</p></td>
<td><p>The heading for the created document.</p></td>
</tr>
<tr>
<td><p>lanc</p></td>
<td><p>The ISO language code: "nb-NO", "en", "de-DE" etc.</p></td>
</tr>
<tr>
<td><p>lang</p></td>
<td><p>The language being used in SuperOffice CRM.</p></td>
</tr>
<tr>
<td><p>lanx</p></td>
<td><p>The SuperOffice language code: "NO", "US" "GE" etc.</p></td>
</tr>
<tr>
<td><p>ltim</p></td>
<td><p>Time in long format, e.g. 12:10:05.</p></td>
</tr>
<tr>
<td><p>oref</p></td>
<td><p>Our reference.</p></td>
</tr>
<tr>
<td><p>pltf</p></td>
<td><p>Platform: Windows or web.</p></td>
</tr>
<tr>
<td><p>ptha</p></td>
<td><p>SOARC path (from **SuperOffice.ini**).</p></td>
</tr>
<tr>
<td><p>pthi</p></td>
<td><p>Path to the folder where **SuperOffice.ini** is located.</p></td>
</tr>
<tr>
<td><p>pthp</p></td>
<td><p>Path to the folder where SuperOffice CRM is installed.</p></td>
</tr>
<tr>
<td><p>salu</p></td>
<td><p>Salutation as entered, or created automatically from the contact (Mr/Ms and last name).</p></td>
</tr>
<tr>
<td><p>sdat</p></td>
<td><p>Date in short format, e.g. 10.12.04.</p></td>
</tr>
<tr>
<td><p>ser#</p></td>
<td><p>SuperOffice CRM's serial number.</p></td>
</tr>
<tr>
<td><p>snum</p></td>
<td><p>Ascending serial number (different for every template).</p></td>
</tr>
<tr>
<td><p>time</p></td>
<td><p>Time in short format, e.g. 12:10.</p></td>
</tr>
<tr>
<td><p>ver#</p></td>
<td><p>SuperOffice CRM's version number.</p></td>
</tr>
<tr>
<td><p>vern</p></td>
<td><p>NetServer full name "Netserver 7.1 (Debug) 7.1.200.300".</p></td>
</tr>
<tr>
<td><p>yref</p></td>
<td><p>Your reference.</p></td>
</tr>
</tbody>
</table>

> [!NOTE]
> The short and long date formats will be determined by your computer’s settings. You can edit the settings in Control Panel in Windows.

## Variables from the project card

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>pend</p></td>
<td><p>The project's end date, formatted 02.11.2011 (system format).</p></td>
</tr>
<tr>
<td><p>pgui</p></td>
<td><p>Is the project guided? "Yes" or "No" (translated).</p></td>
</tr>
<tr>
<td><p>pf01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>pl01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>plea</p></td>
<td><p>Project manager.</p></td>
</tr>
<tr>
<td><p>pmid</p></td>
<td><p>The project's next milestone appointment, ID.</p></td>
</tr>
<tr>
<td><p>pmil</p></td>
<td><p>The project's next milestone date, formatted 02.11.2011 (system format).</p></td>
</tr>
<tr>
<td><p>pnam</p></td>
<td><p>Project name.</p></td>
</tr>
<tr>
<td><p>pnum</p></td>
<td><p>Project number.</p></td>
</tr>
<tr>
<td><p>popa</p></td>
<td><p>Project, event date.</p></td>
</tr>
<tr>
<td><p>pope</p></td>
<td><p>Project, end date for publishing.</p></td>
</tr>
<tr>
<td><p>pops</p></td>
<td><p>Project, start date for publishing.</p></td>
</tr>
<tr>
<td><p>prid</p></td>
<td><p>Project ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>ps01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>psta</p></td>
<td><p>Project status.</p></td>
</tr>
<tr>
<td><p>ptyp</p></td>
<td><p>Project type.</p></td>
</tr>
<tr>
<td><p>pwwi</p></td>
<td><p>The project's primary web address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>pwww</p></td>
<td><p>The project's primary web address.</p></td>
</tr>
</tbody>
</table>

## Variables for the sender (contact card)

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>alid</p></td>
<td><p>Sender’s user name (User ID of the selected diary owner).</p></td>
</tr>
<tr>
<td><p>atit</p></td>
<td><p>Sender’s title.</p></td>
</tr>
<tr>
<td><p>auac</p></td>
<td><p>The sender's academic title</p></td>
</tr>
<tr>
<td><p>aubd</p></td>
<td><p>Date of birth.</p></td>
</tr>
<tr>
<td><p>auca</p></td>
<td><p>The sender's chat address</p></td>
</tr>
<tr>
<td><p>aucd</p></td>
<td><p>The sender's chat address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>auci</p></td>
<td><p>Postal town. (See also [aucs](#aucs).)</p></td>
</tr>
<tr>
<td><p>aucn</p></td>
<td><p>Country.</p></td>
</tr>
<tr>
<td><p>aucp</p></td>
<td><p>The sender's chat address protocol.</p></td>
</tr>
<tr>
<td><p>aucs</p></td>
<td><p>Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730).</p></td>
</tr>
<tr>
<td><p>aucy</p></td>
<td><p>County (for UK addresses).</p></td>
</tr>
<tr>
<td><p>audf</p></td>
<td><p>Direct fax number.</p></td>
</tr>
<tr>
<td><p>audi</p></td>
<td><p>Direct fax number with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>audl</p></td>
<td><p>Direct phone number with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>audp</p></td>
<td><p>Direct phone number.</p></td>
</tr>
<tr>
<td><p>auem</p></td>
<td><p>E-mail.</p></td>
</tr>
<tr>
<td><p>auid</p></td>
<td><p>Sender’s unique ID (person-id of the selected diary owner).</p></td>
</tr>
<tr>
<td><p>aumr</p></td>
<td><p>Mr/Ms for sender</p></td>
</tr>
<tr>
<td><p>aums</p></td>
<td><p>Mail Stop (for American addresses).</p></td>
</tr>
<tr>
<td><p>aunm</p></td>
<td><p>Number recorded for the document's owner.</p></td>
</tr>
<tr>
<td><p>aup1</p></td>
<td><p>Sender’s postal address, line 1.</p></td>
</tr>
<tr>
<td><p>aup2</p></td>
<td><p>Sender’s postal address, line 2.</p></td>
</tr>
<tr>
<td><p>aup3</p></td>
<td><p>Sender’s postal address, line 3.</p></td>
</tr>
<tr>
<td><p>aupc</p></td>
<td><p>Mobile phone.</p></td>
</tr>
<tr>
<td><p>auph</p></td>
<td><p>Home telephone.</p></td>
</tr>
<tr>
<td><p>aupl</p></td>
<td><p>Home telephone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>aupm</p></td>
<td><p>Mobile phone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>aupo</p></td>
<td><p>Position.</p></td>
</tr>
<tr>
<td><p>aupp</p></td>
<td><p>Other phone (was "Pager" before 7.0).</p></td>
</tr>
<tr>
<td><p>aupt</p></td>
<td><p>Other phone with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>aust</p></td>
<td><p>State/province (for American, Canadian and Australian addresses). (See also [aucs](#aucs).)</p></td>
</tr>
<tr>
<td><p>auth</p></td>
<td><p>Sender’s first name and last name.</p></td>
</tr>
<tr>
<td><p>auvo</p></td>
<td><p>The sender's VOIP address.</p></td>
</tr>
<tr>
<td><p>auvi</p></td>
<td><p>The sender's VOIP address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>auvs</p></td>
<td><p>The sender's VOIP service (description).</p></td>
</tr>
<tr>
<td><p>auwi</p></td>
<td><p>The sender's primary web address, ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>auww</p></td>
<td><p>The sender's primary web address.</p></td>
</tr>
<tr>
<td><p>auzi</p></td>
<td><p>Postcode. (See also [aucs](#aucs).)</p></td>
</tr>
<tr>
<td><p>uf01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>ul01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>us01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>usid</p></td>
<td><p>Current user's unique ID (associate-id of the logged in user).</p></td>
</tr>
</tbody>
</table>

## Variables from the sender’s own company card

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>ocid</p></td>
<td><p>Country code for sender’s company card.</p></td>
</tr>
<tr>
<td><p>ocit</p></td>
<td><p>Own organisation’s postal town.</p></td>
</tr>
<tr>
<td><p>ocnr</p></td>
<td><p>Own organisation’s country.</p></td>
</tr>
<tr>
<td><p>ocnt</p></td>
<td><p>Own organisation’s county (for UK addresses).</p></td>
</tr>
<tr>
<td><p>ocsz</p></td>
<td><p>Own organisation’s postal town, state/province and zipcode (for American, Canadian and Australian addresses).</p></td>
</tr>
<tr>
<td><p>oczi</p></td>
<td><p>Own organisation’s county and postcode (for UK addresses).</p></td>
</tr>
<tr>
<td><p>odep</p></td>
<td><p>The department the sender belongs to.</p></td>
</tr>
<tr>
<td><p>oema</p></td>
<td><p>Own organisation’s primary e-mail address.</p></td>
</tr>
<tr>
<td><p>of01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>ofax</p></td>
<td><p>Own organisation’s primary fax number.</p></td>
</tr>
<tr>
<td><p>ol01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>onam</p></td>
<td><p>Name of own organisation.</p></td>
</tr>
<tr>
<td><p>oorg</p></td>
<td><p>Organisation number.</p></td>
</tr>
<tr>
<td><p>opad</p></td>
<td><p>Own organisation’s postal address, line 1.</p></td>
</tr>
<tr>
<td><p>opa2</p></td>
<td><p>Own organisation’s postal address, line 2.</p></td>
</tr>
<tr>
<td><p>opa3</p></td>
<td><p>Own organisation’s postal address, line 3.</p></td>
</tr>
<tr>
<td><p>ophi</p></td>
<td><p>Own organization's primary telephone number with inter-area and international prefix.</p></td>
</tr>
<tr>
<td><p>opho</p></td>
<td><p>Own organisation’s primary telephone number.</p></td>
</tr>
<tr>
<td><p>os01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>osad</p></td>
<td><p>Own organisation’s street address.</p></td>
</tr>
<tr>
<td><p>osct</p></td>
<td><p>Postal town for own organisation’s street address.</p></td>
</tr>
<tr>
<td><p>osta</p></td>
<td><p>Own organisation’s state/province (for American, Canadian and Australian addresses).</p></td>
</tr>
<tr>
<td><p>oszi</p></td>
<td><p>Postcode for own organisation’s street address.</p></td>
</tr>
<tr>
<td><p>owid</p></td>
<td><p>Own organisation's ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>owww</p></td>
<td><p>Own organisation’s primary web address.</p></td>
</tr>
<tr>
<td><p>ozip</p></td>
<td><p>Own organisation’s postcode.</p></td>
</tr>
</tbody>
</table>

## Variables for sales

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>saam</p></td>
<td><p>Sale amount.</p></td>
</tr>
<tr>
<td><p>saau</p></td>
<td><p>Sale owner (associate), full name.</p></td>
</tr>
<tr>
<td><p>saca</p></td>
<td><p>Associate who made the sale, full name</p></td>
</tr>
<tr>
<td><p>sacu</p></td>
<td><p>Sale currency.</p></td>
</tr>
<tr>
<td><p>saco</p></td>
<td><p>Competitor, sale.</p></td>
</tr>
<tr>
<td><p>sacr</p></td>
<td><p>Sale credited to.</p></td>
</tr>
<tr>
<td><p>sada</p></td>
<td><p>Sale date, formatted 02.11.2011 (system format).</p></td>
</tr>
<tr>
<td><p>sadu</p></td>
<td><p>Sale next due date, formatted 02.11.2011 (system format).</p></td>
</tr>
<tr>
<td><p>said</p></td>
<td><p>Sales ID (hidden, unique ID).</p></td>
</tr>
<tr>
<td><p>sanu</p></td>
<td><p>Sales number.</p></td>
</tr>
<tr>
<td><p>sape</p></td>
<td><p>Sale, end date for publishing.</p></td>
</tr>
<tr>
<td><p>sapr</p></td>
<td><p>Probability, sale.</p></td>
</tr>
<tr>
<td><p>saps</p></td>
<td><p>Sale, start date for publishing.</p></td>
</tr>
<tr>
<td><p>sare</p></td>
<td><p>Reason (sold, lost or stalled).</p></td>
</tr>
<tr>
<td><p>saso</p></td>
<td><p>Sale source.</p></td>
</tr>
<tr>
<td><p>sast</p></td>
<td><p>Sale stage.</p></td>
</tr>
<tr>
<td><p>sati</p></td>
<td><p>Title of the sale.</p></td>
</tr>
<tr>
<td><p>satu</p></td>
<td><p>Sale status (stage) ("Open", "Sold", "Lost" or "Stalled").</p></td>
</tr>
<tr>
<td><p>saty</p></td>
<td><p>Sale type.</p></td>
</tr>
<tr>
<td><p>sf01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>sgui</p></td>
<td><p>Is the sale guided? "Yes" or "No" (translated).</p></td>
</tr>
<tr>
<td><p>sl01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>ss01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
<tr>
<td><p>sste</p></td>
<td><p>Are Stakeholders enabled on this sale? "Yes" or "No" (translated).</p></td>
</tr>
</tbody>
</table>

## Variables for selections

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>mbrs</p></td>
<td><p>Selected list from selection. (Space-separated list of comma-separated companies and contacts from a selection).</p></td>
</tr>
<tr>
<td><p>slid</p></td>
<td><p>Selection ID.</p></td>
</tr>
<tr>
<td><p>snam</p></td>
<td><p>The selection name.</p></td>
</tr>
</tbody>
</table>

## Variables for appointments

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>bafp</p></td>
<td><p>A list of persons invited to a meeting. Used in invitation e-mails.</p></td>
</tr>
<tr>
<td><p>baid</p></td>
<td><p>Appointment ID.</p></td>
</tr>
<tr>
<td><p>bape</p></td>
<td><p>Appointment, end date for publishing.</p></td>
</tr>
<tr>
<td><p>baps</p></td>
<td><p>Appointment, start date for publishing.</p></td>
</tr>
<tr>
<td><p>bcon</p></td>
<td><p>The appointment's company, name.</p></td>
</tr>
<tr>
<td><p>bcrd</p></td>
<td><p>The appointment's creation date, in PC's local time, formatted YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bcrt</p></td>
<td><p>The appointment's creation time, in PC's local time, formatted HHmmss.</p></td>
</tr>
<tr>
<td><p>bdlg</p></td>
<td><p>The "superoffice:invitations" link to the invitation dialog.</p></td>
</tr>
<tr>
<td><p>bdll</p></td>
<td><p>The "Use this link to open the Invitation dialog in SuperOffice CRM" link displayed for registered contacts. Blank if recipient is not a registered contact.</p></td>
</tr>
<tr>
<td><p>beda</p></td>
<td><p>The appointment's end date, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bema</p></td>
<td><p>The appointment's owner, e-mail address.</p></td>
</tr>
<tr>
<td><p>beti</p></td>
<td><p>The appointment's end time, formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>bfre</p></td>
<td><p>Free/busy time.</p></td>
</tr>
<tr>
<td><p>biid</p></td>
<td><p>ID of the person invited to the follow-up.</p></td>
</tr>
<tr>
<td><p>binf</p></td>
<td><p>The appointment's description.</p></td>
</tr>
<tr>
<td><p>binl</p></td>
<td><p>First line of the appointment's description.</p></td>
</tr>
<tr>
<td><p>binv</p></td>
<td><p>Name of the person invited to the follow-up.</p></td>
</tr>
<tr>
<td><p>blab</p></td>
<td><p>Date or deadline. Translated name of an appointment or task.</p></td>
</tr>
<tr>
<td><p>bloc</p></td>
<td><p>Appointment location.</p></td>
</tr>
<tr>
<td><p>bmil</p></td>
<td><p>Is the appointment a milestone appointment? Translated "Yes" or "No".</p></td>
</tr>
<tr>
<td><p>bold</p></td>
<td><p>The appointment's old start date, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bolt</p></td>
<td><p>The appointment's old start time, formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>bown</p></td>
<td><p>The appointment's owner, name.</p></td>
</tr>
<tr>
<td><p>bper</p></td>
<td><p>The appointment's contact, name.</p></td>
</tr>
<tr>
<td><p>bprd</p></td>
<td><p>The appointment's priority as a number. 1 = low, 2 = medium, 3 = high.</p></td>
</tr>
<tr>
<td><p>bpri</p></td>
<td><p>The appointment's priority as text.</p></td>
</tr>
<tr>
<td><p>bpro</p></td>
<td><p>The appointment's project, name.</p></td>
</tr>
<tr>
<td><p>brec</p></td>
<td><p>The appointment's tooltip for repeating appointments.</p></td>
</tr>
<tr>
<td><p>bred</p></td>
<td><p>The end date for the appointment's repeating pattern, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>brei</p></td>
<td><p>Translated text: "This appointment is part of a repeating pattern:". Empty if this is not a repeating pattern.</p></td>
</tr>
<tr>
<td><p>brel</p></td>
<td><p>Translated text "See below in this message for a list of the repeating appointments." Empty if this is not a repeating pattern.</p></td>
</tr>
<tr>
<td><p>brid</p></td>
<td><p>ID of the appointment's recurrence rule.</p></td>
</tr>
<tr>
<td><p>brph</p></td>
<td><p>Changes in the recurrence rule and/or participants for appointments. Used when sending e-mail to participants to notify them of changes to an appointment they are invited to.</p></td>
</tr>
<tr>
<td><p>brsd</p></td>
<td><p>The start date for the appointment's repeating pattern, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bsda</p></td>
<td><p>The appointment's start date, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bsta</p></td>
<td><p>The appointment's status (in English): "TENTATIVE", "CONFIRMED" or "CANCELLED".</p></td>
</tr>
<tr>
<td><p>bsti</p></td>
<td><p>The appointment's start time, formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>bsug</p></td>
<td><p>Suggested appointment ID for the appointment ("SuggestedAppointment Id"). Set to 0 when the appointment is not part of a sale/project guide.</p></td>
</tr>
<tr>
<td><p>btim</p></td>
<td><p>The appointment's date and time, e.g. 30.03.2005 (16:00)-(17:00).</p></td>
</tr>
<tr>
<td><p>btod</p></td>
<td><p>Today's date in UTC, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>btot</p></td>
<td><p>Current time in UTC, formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>btyp</p></td>
<td><p>Activity type.</p></td>
</tr>
<tr>
<td><p>btza</p></td>
<td><p>The appointment's start date, converted into the PC's local time. Formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>btzb</p></td>
<td><p>The appointment's start time, converted into the PC's local time. Formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>btzd</p></td>
<td><p>The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200</p></td>
</tr>
<tr>
<td><p>btze</p></td>
<td><p>The appointment's end time, converted into the PC's local time. Formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>btzf</p></td>
<td><p>The appointment's end time, converted into the PC's local time. Formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>btzk</p></td>
<td><p>The time zone key, from the appointment's start date. (AR-CN means the Argentina-Corrientes time zone -0300.)</p></td>
</tr>
<tr>
<td><p>btzl</p></td>
<td><p>The time zone ID of the appointment.</p></td>
</tr>
<tr>
<td><p>btzn</p></td>
<td><p>The appointment's date and time converted to UTC if time zones are enabled. For example, 30.03.2005 (17:00)-(18:00).</p></td>
</tr>
<tr>
<td><p>btzm</p></td>
<td><p>Time zone formatted as Norway (GMT +1:00) if time zones are enabled.</p></td>
</tr>
<tr>
<td><p>btzs</p></td>
<td><p>The time zone offset for summer time, for the PC's local time. Formatted as +0200 or -1200.</p></td>
</tr>
<tr>
<td><p>btzt</p></td>
<td><p>Time zone information, for the PC's local time. Formatted as (GMT+01.00) or (GMT-04.00).</p></td>
</tr>
<tr>
<td><p>btzv</p></td>
<td><p>The appointment's start date converted to UTC if time zones are enabled. Formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>btzw</p></td>
<td><p>The appointment's start time converted to UTC if time zones are enabled. Formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>btzx</p></td>
<td><p>The appointment's end date converted to UTC if time zones are enabled. Formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>btzy</p></td>
<td><p>The appointment's end time converted to UTC if time zones are enabled. Formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>bunt</p></td>
<td><p>The end date for the appointment's repeating pattern, formatted as "UNTIL=YYYYMMdd;".</p></td>
</tr>
<tr>
<td><p>bupc</p></td>
<td><p>The number of times the appointment has been updated. (Counter from version 6 onwards only).</p></td>
</tr>
<tr>
<td><p>bupd</p></td>
<td><p>Update date for the appointment, formatted as YYYYMMdd.</p></td>
</tr>
<tr>
<td><p>bupt</p></td>
<td><p>Update time for the appointment, formatted as HHmmss.</p></td>
</tr>
<tr>
<td><p>burl</p></td>
<td><p>Link to video meeting.</p></td>
</tr>
<tr>
<td><p>tf01-10</p></td>
<td><p>User-defined field 1-10 of the decimal number type.</p></td>
</tr>
<tr>
<td><p>tl01-60</p></td>
<td><p>User-defined field 1-60 of the whole number type.</p></td>
</tr>
<tr>
<td><p>ts01-49</p></td>
<td><p>User-defined field 1-49 of the text type.</p></td>
</tr>
</tbody>
</table>

## Variables for appointments corresponding to the iCal standard

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>bate</p></td>
<td><p>Formatted list of people invited to an appointment, created for iCal.</p>
<p>ATTENDEE;RSVP=TRUE;CN="First Invited":MAILTO:;PARTSTAT=ACCEPTED</p>
<p>ATTENDEE;RSVP=TRUE;CN="Test Testesen":MAILTO:test@superoffice.com;PARTSTAT=TENTATIVE</p></td>
</tr>
<tr>
<td><p>bpat</p></td>
<td><p>The main feature of the appointment's repeating pattern, formatted like the Daily pattern "FREQ=DAILY;", for example.</p></td>
</tr>
<tr>
<td><p>bprt</p></td>
<td><p>The priority of the appointment, converted to iCal format: our 1 = iCal 9, our 2 = iCal 5 (default), our 3 = iCal 1.</p></td>
</tr>
<tr>
<td><p>brul</p></td>
<td><p>The entire appointment's repeating pattern, formatted as "RRULE:" + bpat + bsub + bunt.</p></td>
</tr>
<tr>
<td><p>bsub</p></td>
<td><p>The secondary feature of the appointment's repeating pattern, formatted as the sub-pattern Daily Workday "BYDAY=MO,TU,WE,TH,FR;", for example.</p></td>
</tr>
<tr>
<td><p>bsun</p></td>
<td><p>The start of the week for the appointment's repeating pattern, formatted as "WKST=SU" or "WKST=MO".</p></td>
</tr>
<tr>
<td><p>btzr</p></td>
<td><p>The time zone rule for standard time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=3;BYDAY=4SU</p></td>
</tr>
<tr>
<td><p>btzu</p></td>
<td><p>The time zone rule for summer time, for the PC's local time. Formatted as RRULE:FREQ=YEARLY;WKST=MO;INTERVAL=1;BYMONTH=10;BYDAY=4SU</p></td>
</tr>
<tr>
<td><p>buid</p></td>
<td><p>Unique ID created for iCal. SerialnoDfollowupIdDinvitedId (where D is a separator). For example, 1010000014D345D971. Only for follow-ups with several participants.</p></td>
</tr>
</tbody>
</table>

## Variables for integration with web applications

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>usec</p></td>
<td><p>Encrypted login information for NetServer.</p></td>
</tr>
<tr>
<td><p>usem</p></td>
<td><p>Current user's primary e-mail address.</p></td>
</tr>
<tr>
<td><p>user</p></td>
<td><p>Current user ID.</p></td>
</tr>
<tr>
<td><p>usfn</p></td>
<td><p>Current user's first name.</p></td>
</tr>
<tr>
<td><p>usid</p></td>
<td><p>Current user's unique ID (associate-id of the logged in user).</p></td>
</tr>
<tr>
<td><p>usln</p></td>
<td><p>Current user's last name.</p></td>
</tr>
<tr>
<td><p>usmn</p></td>
<td><p>Current user's middle name.</p></td>
</tr>
</tbody>
</table>

## Variables for Quote alternative

<table class="SimpleGridBlack" data-cellspacing="0px" style="width:100%; max-width:683px">
<tbody>
<tr>
<td><p>qaf1</p></td>
<td><p>Extra field 1.</p></td>
</tr>
<tr>
<td><p>qaf2</p></td>
<td><p>Extra field 2.</p></td>
</tr>
<tr>
<td><p>qaf3</p></td>
<td><p>Extra field 3.</p></td>
</tr>
<tr>
<td><p>qaf4</p></td>
<td><p>Extra field 4.</p></td>
</tr>
<tr>
<td><p>qaf5</p></td>
<td><p>Extra field 5.</p></td>
</tr>
<tr>
<td><p>qaky</p></td>
<td><p>ERP Quote alternative key.</p></td>
</tr>
<tr>
<td><p>qanm</p></td>
<td><p>Name.</p></td>
</tr>
</tbody>
</table>

## Variables for Quote info

<table>
<tbody>
<tr>
<td><p>qabi</p></td>
<td><p>Version approved by (ID).</p></td>
</tr>
<tr>
<td><p>qaby</p></td>
<td><p>Version approved by (Full name).</p></td>
</tr>
<tr>
<td><p>qadt</p></td>
<td><p>Version approval reg date.</p></td>
</tr>
<tr>
<td><p>qarb</p></td>
<td><p>Version approval reg by (Full name).</p></td>
</tr>
<tr>
<td><p>qari</p></td>
<td><p>Version approval reg by (ID).</p></td>
</tr>
<tr>
<td><p>qatx</p></td>
<td><p>Version approved text.</p></td>
</tr>
<tr>
<td><p>qcom</p></td>
<td><p>Quote Comment.</p></td>
</tr>
<tr>
<td><p>qda1</p></td>
<td><p>Version delivery address line 1, formatted.</p></td>
</tr>
<tr>
<td><p>qda2</p></td>
<td><p>Version delivery address line 2, formatted.</p></td>
</tr>
<tr>
<td><p>qda3</p></td>
<td><p>Version delivery address line 3, formatted.</p></td>
</tr>
<tr>
<td><p>qda4</p></td>
<td><p>Version delivery address line 4, formatted.</p></td>
</tr>
<tr>
<td><p>qda5</p></td>
<td><p>Version delivery address line 5, formatted.</p></td>
</tr>
<tr>
<td><p>qda6</p></td>
<td><p>Version delivery address line 6, formatted.</p></td>
</tr>
<tr>
<td><p>qda7</p></td>
<td><p>Version delivery address line 7, formatted.</p></td>
</tr>
<tr>
<td><p>qda8</p></td>
<td><p>Version delivery address line 8, formatted.</p></td>
</tr>
<tr>
<td><p>qda9</p></td>
<td><p>Version delivery address line 9, formatted.</p></td>
</tr>
<tr>
<td><p>qdci</p></td>
<td><p>Version delivery country ID.</p></td>
</tr>
<tr>
<td><p>qdcn</p></td>
<td><p>Version delivery country name.</p></td>
</tr>
<tr>
<td><p>qdek</p></td>
<td><p>Version delivery terms key (ID).</p></td>
</tr>
<tr>
<td><p>qdev</p></td>
<td><p>Version delivery terms (Display text).</p></td>
</tr>
<tr>
<td><p>qdtk</p></td>
<td><p>Version delivery type key (ID).</p></td>
</tr>
<tr>
<td><p>qdtv</p></td>
<td><p>Version delivery type (Display text).</p></td>
</tr>
<tr>
<td><p>qexp</p></td>
<td><p>Version expiry date.</p></td>
</tr>
<tr>
<td><p>qia1</p></td>
<td><p>Version invoice address line 1, formatted.</p></td>
</tr>
<tr>
<td><p>qia2</p></td>
<td><p>Version invoice address line 2, formatted.</p></td>
</tr>
<tr>
<td><p>qia3</p></td>
<td><p>Version invoice address line 3, formatted.</p></td>
</tr>
<tr>
<td><p>qia4</p></td>
<td><p>Version invoice address line 4, formatted.</p></td>
</tr>
<tr>
<td><p>qia5</p></td>
<td><p>Version invoice address line 5, formatted.</p></td>
</tr>
<tr>
<td><p>qia6</p></td>
<td><p>Version invoice address line 6, formatted.</p></td>
</tr>
<tr>
<td><p>qia7</p></td>
<td><p>Version invoice address line 7, formatted.</p></td>
</tr>
<tr>
<td><p>qia8</p></td>
<td><p>Version invoice address line 8, formatted.</p></td>
</tr>
<tr>
<td><p>qia9</p></td>
<td><p>Version invoice address line 9, formatted.</p></td>
</tr>
<tr>
<td><p>qici</p></td>
<td><p>Version invoice country ID.</p></td>
</tr>
<tr>
<td><p>qicn</p></td>
<td><p>Version invoice country name.</p></td>
</tr>
<tr>
<td><p>qkey</p></td>
<td><p>Quote ERP quote key.</p></td>
</tr>
<tr>
<td><p>qnum</p></td>
<td><p>Version number.</p></td>
</tr>
<tr>
<td><p>qord</p></td>
<td><p>Quote ERP order key.</p></td>
</tr>
<tr>
<td><p>qpek</p></td>
<td><p>Version payment terms key (ID).</p></td>
</tr>
<tr>
<td><p>qpev</p></td>
<td><p>Version payment terms (Display text).</p></td>
</tr>
<tr>
<td><p>qpon</p></td>
<td><p>Quote PO Number.</p></td>
</tr>
<tr>
<td><p>qptk</p></td>
<td><p>Version payment type key (ID).</p></td>
</tr>
<tr>
<td><p>qptv</p></td>
<td><p>Version payment type (Display text).</p></td>
</tr>
<tr>
<td><p>qver</p></td>
<td><p>Version rank.</p></td>
</tr>
<tr>
<td><p>qvf1</p></td>
<td><p>Version extra field 1.</p></td>
</tr>
<tr>
<td><p>qvf2</p></td>
<td><p>Version extra field 2.</p></td>
</tr>
<tr>
<td><p>qvf3</p></td>
<td><p>Version extra field 3.</p></td>
</tr>
<tr>
<td><p>qvf4</p></td>
<td><p>Version extra field 4.</p></td>
</tr>
<tr>
<td><p>qvf5</p></td>
<td><p>Version extra field 5.</p></td>
</tr>
<tr>
<td><p>qvid</p></td>
<td><p>Version ID.</p></td>
</tr>
<tr>
<td><p>qvky</p></td>
<td><p>Version ERP Key.</p></td>
</tr>
</tbody>
</table>

## Variables for Quote line

<table>
<tbody>
<tr>
<td><p>qlca</p></td>
<td><p>Product category.</p></td>
</tr>
<tr>
<td><p>qlda</p></td>
<td><p>Discount amount.</p></td>
</tr>
<tr>
<td><p>qldc</p></td>
<td><p>Description.</p></td>
</tr>
<tr>
<td><p>qldp</p></td>
<td><p>Discount percent.</p></td>
</tr>
<tr>
<td><p>qlf1</p></td>
<td><p>Extra field 1.</p></td>
</tr>
<tr>
<td><p>qlf2</p></td>
<td><p>Extra field 2.</p></td>
</tr>
<tr>
<td><p>qlf3</p></td>
<td><p>Extra field 3.</p></td>
</tr>
<tr>
<td><p>qlf4</p></td>
<td><p>Extra field 4.</p></td>
</tr>
<tr>
<td><p>qlf5</p></td>
<td><p>Extra field 5.</p></td>
</tr>
<tr>
<td><p>qlfa</p></td>
<td><p>Product family.</p></td>
</tr>
<tr>
<td><p>qlit</p></td>
<td><p>Item number.</p></td>
</tr>
<tr>
<td><p>qlky</p></td>
<td><p>ERP Quote Line key.</p></td>
</tr>
<tr>
<td><p>qllp</p></td>
<td><p>Unit list price.</p></td>
</tr>
<tr>
<td><p>qlmp</p></td>
<td><p>Unit minimum price.</p></td>
</tr>
<tr>
<td><p>qlnm</p></td>
<td><p>Name.</p></td>
</tr>
<tr>
<td><p>qlpc</p></td>
<td><p>Code.</p></td>
</tr>
<tr>
<td><p>qlpk</p></td>
<td><p>ERP Product key.</p></td>
</tr>
<tr>
<td><p>qlpu</p></td>
<td><p>Price unit.</p></td>
</tr>
<tr>
<td><p>qlqa</p></td>
<td><p>Quantity.</p></td>
</tr>
<tr>
<td><p>qlqd</p></td>
<td><p>Quantity delivered.</p></td>
</tr>
<tr>
<td><p>qlqu</p></td>
<td><p>Quantity unit.</p></td>
</tr>
<tr>
<td><p>qlre</p></td>
<td><p>Reason.</p></td>
</tr>
<tr>
<td><p>qlsc</p></td>
<td><p>Supplier code.</p></td>
</tr>
<tr>
<td><p>qlst</p></td>
<td><p>Subtotal.</p></td>
</tr>
<tr>
<td><p>qlsu</p></td>
<td><p>Supplier.</p></td>
</tr>
<tr>
<td><p>qltp</p></td>
<td><p>Total price.</p></td>
</tr>
<tr>
<td><p>qlty</p></td>
<td><p>Product type.</p></td>
</tr>
<tr>
<td><p>qlur</p></td>
<td><p>URL.</p></td>
</tr>
<tr>
<td><p>qlva</p></td>
<td><p>VAT.</p></td>
</tr>
<tr>
<td><p>qlvi</p></td>
<td><p>VAT info.</p></td>
</tr>
</tbody>
</table>

## Variables for quote lines with subscription

<table class="SimpleBorder" data-cellspacing="0" data-bgcolor="#FFFFFF" style="width:100%; max-width:683px">
<tbody>
<tr>
<td><p>qsqa</p></td>
<td><p>Subscription quantity (Blank if not subscription).</p></td>
</tr>
<tr>
<td><p>qsub</p></td>
<td><p>Is subscription? ("Yes" or blank).</p></td>
</tr>
<tr>
<td><p>qsun</p></td>
<td><p>Subscription unit (Blank if not subscription).</p></td>
</tr>
</tbody>
</table>

## Variables for SuperOffice Service

These are variables for SuperOffice Service data used in SuperOffice CRM. [Click here to see template variables for SuperOffice Service and SuperOffice Marketing](../../Service/topics/Template-variables.md).

<table class="SimpleBorder" data-cellspacing="0" data-bgcolor="#FFFFFF" style="width:100%; max-width:683px">
<tbody>
<tr>
<td>diid</td>
<td><p>Current diary owner</p></td>
</tr>
<tr>
<td>tiid</td>
<td>Current request ID</td>
</tr>
<tr>
<td>csbu</td>
<td>BaseUrl e.g: http://systemtest.superoffice.com/scripts/ticket.fcgi</td>
</tr>
<tr>
<td>csiu</td>
<td>CgiUrlInternal e.g: http://systemtest.superoffice.com</td>
</tr>
<tr>
<td>csbn</td>
<td>CgiBin e.g: /scripts</td>
</tr>
<tr>
<td>csre</td>
<td>RegistryExtension e.g: .fcgi</td>
</tr>
</tbody>
</table>
