---
uid: help-sv-form-prefilled
title: Använda förifyllda fält i formulär
description: Använda förifyllda fält i formulär
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formulär
so.topic: howto
language: sv
---

# Använda förifyllda fält i formulär

För att bespara dina kunder tiden och besväret med att fylla i namn, e-postadress, telefonnummer och så vidare i formulär kan du lägga till fältidentifierare och mallvariabler i formulärlänkarna/URL:erna. När kunden öppnar ett formulär fylls befintliga kunddata i med SuperOffice-data.

1. [Skapa nytt formulär][1].

2. För varje fält som du vill ska förifyllas: Klicka på **Avancerat** ![ikon][img1] om du vill visa fältet **Identifierare** där du kan lägga till ett ID för fältet. Detta är ett unikt ID för fältet och ändras inte även om fältnamnet/etiketten eller språket ändras. På så sätt kan du vara säker på att länkar till fältet inte är brutna när formuläret har publicerats.

3. [Publicera formulär][2].

4. Välj **Visa med förifyllda fält** om du vill lägga till fältidentifierare i länken/JavaScript.
    Det borde se ut ungefär så här:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

5. Kopiera länken eller JavaScript till en textredigerare eller liknande.

6. Ange relevanta [mallvariabler][3] mellan två hakparenteser EFTER likhetstecknet:
    ```text
    ...formId=F-FH2K4Vru&field-name-1=\[\[customer.name\]\]&field-mail=\[\[customer.email\]\]
    ```

7. Kopiera hela länken eller JavaScript och publicera det.

<!-- Referenced links -->
[1]: create.md
[2]: publish.md
[3]: ../../../request/reply-templates/learn/template-variables.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/cog-wheel.png
