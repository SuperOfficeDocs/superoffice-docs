---
uid: help-da-stakeholder-create
title: Opret en interessent
description: Sådan knyttes et salg til en interessent (firma eller person) i SuperOffice.
keywords: salg, interessent
author: Bergfrid Dias
date: 11.19.2024
version: 10.3.12
topic: concept
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Tilføj interessenter

Når du tilføjer interessenter til et salg, kan du enten tildele roller individuelt, mens du tilføjer personer/firma, tildele roller efter, at alle interessenter er tilføjet, eller bruge en kombination af begge metoder.

Et firma/en person kan tilføjes som en interessent flere gange, forudsat at forskellige roller angives hver gang.

## Trin

1. Åbn salget (se [Brug skærmbilledet Søg][1]) og gå til **Interessenter**-detaljekortet.

1. Klik på **Tilføj** under detaljekortet. Dialogen **Tilføj/rediger interessenter** åbnes.

1. Klik på **Firma/person**-listen for at tilføje interessenter. Du har flere muligheder:

    * **Søg:** Skriv mindst to tegn for at søge efter en person eller et firma.

    * **Historik/Favoritter:** Vælg fra historiklisten eller favoritter.

      ![Tilføj/rediger interessenter dialog, historik -screenshot][img5]

    * **Brugergruppe:** Klik ![ikon][img2] for at gennemse samarbejdspartnere efter gruppe.

      ![Tilføj/rediger interessenter dialog, gruppe -screenshot][img6]

    * **Firma:** Klik ![ikon][img3] for at gennemse personer efter firma eller tilføje et firma som interessent.

      ![Tilføj/rediger interessenter dialog, firma -screenshot][img7]

1. **Tildel roller**: Vælg en interessent og tildel en rolle. For at tildele samme rolle til flere interessenter på én gang skal du bruge **Vælg alle** eller holde **Ctrl/Shift**, mens du vælger.

    ![Tilføj/rediger interessenter dialog, rolle -screenshot][img8]

    Valgfrit: Tilføj en kommentar for at beskrive interessentens rolle mere detaljeret.

1. Klik på **Gem**.

## Fejlfinding

* **Manglende detaljekort**: Hvis detaljekortet **Interessenter** ikke er synlig, skal du sørge for, at denne [salgstype har interessenter][4] aktiveret under Indstillinger og vedligeholdelse.

* **Manglende person**: Hvis en interessent ikke er opført, skal du først [oprette personen][3].

* **Manglende roller**: [Roller][5] defineres under Indstillinger og vedligeholdelse.

## Tips

* **Tilføj interessenter via firma eller udvalg**

    Du kan også [tilføje interessenter via detaljekort][2], der indeholder personer i skærmbillederne Firma og Udvalg.

* **Tilføj kommentarer**

    Hvis der tilføjes en kommentar, vises et ![ikon][img1] papirclip ved siden af **Salgsrolle**-kolonnen i **Interessenter**-detaljekortet. Hold musen over clipsen for at se kommentarens tooltip.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: ../../../project/learn/project-members/add.md
[3]: ../../../contact/learn/create.md
[4]: ../../../admin/lists/learn/sale-type.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/binders.png
[img2]: ../../../../../common/icons/associate-group.png
[img3]: ../../../../../common/icons/singlecolour/contact.png
[img5]: ../../../../media/loc/en/sale/add-stakeholders-from-history.png
[img6]: ../../../../media/loc/en/sale/add-stakeholders-from-group.png
[img7]: ../../../../media/loc/en/sale/add-stakeholders-from-company.png
[img8]: ../../../../media/loc/en/sale/set-stakeholder-role.png
