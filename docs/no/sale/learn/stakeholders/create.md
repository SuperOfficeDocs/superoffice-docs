---
uid: help-no-stakeholder-create
title: Legge til interessenter
description: Slik knytter du et salg til en interessent (firma eller person) i SuperOffice.
keywords: legg til interessent, ny interessent, rediger interessent, Legg til/rediger interessenter, tildel rolle, Interessenter-detaljkortet, detaljkortet Interessenter, interessent, salg
author: Bergfrid Dias
date: 02.05.2025
version: 10.5.2
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Legge til interessenter

Når du legger til interessenter i et salg, kan du enten tildele roller individuelt når du legger til personer/firmaer, tildele roller etter at alle interessenter er lagt til, eller bruke en kombinasjon av begge metodene.

Et firma/en person kan legges til som en interessent flere ganger, forutsatt at forskjellige roller er spesifisert hver gang.

## Steg

1. Åpne salget (se [Bruke Finn-bildet][1]) og gå til **Interessenter**-detaljkortet.

1. Klikk **Legg til** under detaljkortet. Dialogen **Legg til/rediger interessenter** åpnes.

1. Klikk på **Firma/person**-listen for å legge til interessenter. Du har flere alternativer:

    * **Søk**: Skriv inn minst to tegn for å søke etter en person eller et firma.

    * **Historie/Favoritter**: Velg fra historielisten eller favoritter.

      ![Dialog for Legg til/rediger interessenter, historie -screenshot][img5]

    * **Brukergruppe**: Klikk <i class="ph ph-users" aria-label="Associate icon"></i> for å bla gjennom samarbeidspartnere etter gruppe.

      ![Dialog for Legg til/rediger interessenter, gruppe -screenshot][img6]

    * **Firma**: Klikk <i class="ph ph-arrow-circle-right" aria-label="Arrow right"></i> for å bla gjennom personer i et firma eller legge til et firma som interessent.

      ![Dialog for Legg til/rediger interessenter, firma -screenshot][img7]

1. **Tildel roller**: Velg en interessent og tildel en rolle. For å tildele samme rolle til flere interessenter samtidig, bruk **Velg alle** eller hold **Ctrl/Shift** mens du velger.

    ![Dialog for Legg til/rediger interessenter, rolle -screenshot][img8]

    Valgfritt: Legg til en kommentar for å beskrive interessentens rolle i mer detalj.

1. Klikk **Lagre**.

## Feilsøking

* **Manglende detaljkort**: Hvis detaljkortet **Interessenter** ikke er synlig, sørg for at denne [salgstypen har interessenter][4] aktivert i Innstillinger og vedlikehold.

* **Manglende person**: Hvis en interessent ikke er oppført, må du først [opprette personen][3].

* **Manglende roller**: [Roller][5] er definert i Innstillinger og vedlikehold.

## Tips

* **Legg til interessenter via firma eller utvalg**

    Du kan også [legge til interessenter via detaljkort][2] som inneholder personer i Firma- og Utvalgsskjermer.

* **Legg til kommentarer**

    Hvis en kommentar er lagt til, vises en binders (<i class="ph ph-paperclip" aria-hidden="true"></i>) ved siden av **Salgsrolle**-kolonnen i **Interessenter**-detaljkortet. Hold musepekeren over bindersen for å se kommentartipset.

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: ../../../project/learn/project-members/add.md
[3]: ../../../contact/learn/create.md
[4]: ../../admin/sale-type.md
[5]: ../../../admin/lists/learn/editing-items.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/sale/add-stakeholders-from-history.png
[img6]: ../../../../media/loc/en/sale/add-stakeholders-from-group.png
[img7]: ../../../../media/loc/en/sale/add-stakeholders-from-company.png
[img8]: ../../../../media/loc/en/sale/set-stakeholder-role.png
