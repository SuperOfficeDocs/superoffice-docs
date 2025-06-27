---
uid: help-sv-form-prefilled
title: Använda förifyllda fält i formulär
description: Använda förifyllda fält i formulär
keywords: formulär, fält, förifyllda fält, fältidentifierare
author: SuperOffice RnD
date: 02.25.2025
version: 10
content_type: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Använda förifyllda fält i formulär

För att bespara dina kunder tiden och besväret med att fylla i namn, e-postadress, telefonnummer och så vidare i formulär kan du lägga till fältidentifierare och mallvariabler i formulärlänkarna/URL:erna. När kunden öppnar ett formulär fylls befintliga kunddata i med SuperOffice-data.

En fältidentifierare är en unik ID för ett specifikt fält. Den kommer inte att ändras även om fältets namn/etikett eller språket ändras. På detta sätt kan du säkerställa att länkar till detta fält inte blir brutna efter att formuläret har publicerats.

## Steg

1. [Skapa nytt formulär][1].

2. För varje fält som du vill ska förifyllas: Klicka på **Avancerat** (<i class="ph ph-gear" aria-hidden="true"></i>) om du vill visa fältet **Identifierare** där du kan lägga till ett ID för fältet.

3. [Publicera formulär][2].

4. Välj **Visa med förifyllda fält** om du vill lägga till fältidentifierare i länken/JavaScript. Det borde se ut ungefär så här:

    ```text
    ...formId=F-FH2K4Vru&field-name-1=&field-mail=
    ```

    Om inga fältidentifierare läggs till har du förmodligen inte lagt till dessa ID:n till fälten i formuläret.

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
