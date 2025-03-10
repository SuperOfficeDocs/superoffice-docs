---
uid: help-da-screen-designer-button
title: Tilføj en knap eller et link
description: Sådan tilføjer du en knap eller et link til et layout ved hjælp af Skærmdesigneren i Indstillinger og vedligeholdelse.
keywords: Skærmdesigner, layout, knap, link, etiket, A-Z
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj en knap eller et link

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Brugerdefinerede knapper og links tilføjes i **Forhåndsvisning**-ruden, når du redigerer et layout. URL'en bruges til at åbne en webside i den aktuelle eller en ny fane, køre et CRMScript fra skærmen eller navigere til andre dele af SuperOffice ved hjælp af [SoProtocol][3].

Knapper og links fungerer på lignende måde. Forskellen er, at du kan style en knap, men ikke et link.

> [!TIP]
> Du kan bruge [skabelonvariabler][1] i URL'erne.

Instruktionerne nedenfor forudsætter, at du allerede er i gang med at [redigere layoutet][4].

## Tilføj en knap

1. Vælg den fane, du vil redigere.

1. Vælg sektionen **Elementer** til venstre.

1. Klik og træk elementet **Knap** til layoutet.

1. Klik for at vælge den nye knap.

1. I sektionen **Indstillinger**, erstat teksten "Knap" med det nye knapnavn.

    ![Skjermdesigner, indstillinger for knappelement -screenshot][img1]

    > [!TIP]
    > Du kan også tilføje knapnavnet på andre sprog.

1. Vælg i listen **Handling** den handling, der skal udføres, når der klikkes på knappen. For detaljer om hver handling, se referencen i slutningen af denne side.

    * Åbn websted: Vælg denne mulighed for at tilføje et link til et websted. Vælg URL-format og ny/samme fane efter behov.

    * Kør CRMScript: Vælg denne mulighed for at tilføje et [CRMScript][2] til at udføre bestemte handlinger i SuperOffice.

    * Genvej ([SoProtocol][3]): Vælg denne mulighed for at tilføje en kontrol, der, når der klikkes på den, navigerer til et andet område eller skærm i SuperOffice.

1. I listen **Tilstand** skal du vælge, om knappen altid skal være tilgængelig, eller om den kun skal være tilgængelig i læse- eller redigeringstilstand.

1. Vælg i listen **Stil** knapstilen.

## <a id="link"></a>Tilføj links

1. Vælg den fane, du vil redigere.

1. Vælg sektionen **Elementer** til venstre.

1. Klik og træk elementet **Link** til layoutet.

1. Klik for at vælge det nye linkfelt.

1. I sektionen **Indstillinger**, erstat teksten "Link" med det nye linknavn.

    > [!TIP]
    > Du kan også tilføje linknavnet på andre sprog.

1. Vælg i listen **Handling** den handling, der skal udføres, når der klikkes på linket. (Samme liste som for knapper.)

1. I **Tilstand**-listen skal du vælge, om linket altid skal være tilgængeligt, eller kun i læse- eller redigeringstilstand.

## Oversættelse af etiketter

Navnet og infobokssteksten kan oversættes til andre sprog.

Når elementet er valgt:

1. Klik på <i class="ph ph-translate" aria-label="Translate"></i> ved siden af etiketten.
1. Klik på **Tilføj** og vælg et sprog fra listen.
1. Indtast tekst for det nye sprog.

    ![Skjermdesigner, oversæt etiket -screenshot][img2]

1. Gentag trin 2-3 for yderligere sprog.
1. Klik på **Luk** for at afslutte oversættelsesdialogen.

Husk at udgive layoutet igen.

## Reference

| Indstilling | Beskrivelse | Kommentar |
|---|---|---|
| Navn | Tekst | Kan oversættes |
| Handling | Hvad sker der, når der klikkes: Åbn websted, CRMScript, SoProtocol | |
| URL | URL | HTTP-præfikset tilføjes automatisk. Du skal selv tilføje 'https://', hvis det er relevant. |
| Tilstand | Hvornår elementet vises: Altid, læsetilstand, redigeringstilstand | |
| Tekst i infoboks | Tekst | Kan oversættes |
| Stil | Handling, Normal, Slet, OK, Rediger | Gælder ikke for links |

Nogle indstillinger afhænger af den valgte handling.

### Åbn websted

* URL-format: ingen, ANSI eller Unicode
* Objekt: ny fane eller samme fane (mål)

![Skjermdesigner, åbn websted på knap -screenshot][img4]

> [!NOTE]
> Det anbefales at specificere protokollen, for eksempel `https://www.superoffice.com`; ellers er standarden HTTP.

### Kør CRMScript

* CRMScript: Vælg det specifikke script, der skal køres.

![Skjermdesigner, kør CRMScript på knap -screenshot][img3]

[Læs mere om CRMScript][2]

### Genvej (SoProtocol)

* SoProtocol: Den navigations- og indholdsdelen af URL'en uden præfikset `superoffice:`.

![Skjermdesigner, SoProtocol på knap -screenshot][img5]

[Læs mere om SoProtocol][3]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/from-company-card.md
[2]: ../../../../en/automation/crmscript/overview/index.md
[3]: ../../../../en/ui/soprotocol/index.md
[4]: edit-layout.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/new-button.png
[img2]: ../../../../media/loc/en/ui/translate-button-label.png
[img3]: ../../../../media/loc/en/ui/button-script.png
[img4]: ../../../../media/loc/en/ui/button-website.png
[img5]: ../../../../media/loc/en/ui/button-soprotocol.png
