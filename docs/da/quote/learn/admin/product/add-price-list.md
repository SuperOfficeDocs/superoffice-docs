---
uid: help-da-price-list-add
title: Tilføj prisliste
description: I denne vejledning lærer du, hvordan du tilføjer og redigerer en prisliste i SuperOffice Quote.
author: SuperOffice RnD
date: 02.23.2023
keywords: produkt, prisliste
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj en prisliste

Det er ikke ualmindeligt at bruge forskellige prislister til forskellige tidspunkter af året eller til specifikke kampagner, du måske vil køre.

Tilpasning af prislister hjælper dine sælgere med at bruge de korrekte prisoplysninger uden at skulle spilde tid på at dobbelttjekke dem. Som administrator kan du bestemme, hvornår en bestemt prisliste skal bruges, ved hjælp af begrænset gyldighed.

![Du kan tilføje og redigere alle dine prislister under fanen SuperOffice produkter -screenshot][img1]

## Trin

1. [!include[Go to products](../includes/goto-products.md)]

1. Klik på knappen **Tilføj** øverst på fanen. Dialogboksen **Tilføj/rediger prisliste** vises.

1. Udfyld de følgende felter:

    * **Prislistenavn**: Giv prislisten et beskrivende navn for at gøre den lettere at skelne fra andre prislister.

    > [!NOTE]
    > Du kan ikke ændre valutaen, når du har oprettet prislisten. Hvis du vil aktivere valuta, skal du gå til **Præferencer** > **System** > **Aktivér brug af valuta**.

    * **Beskrivelse**: Angiv en beskrivelse af prislisten.

    * **Aktiv**: Markér feltet her for at aktivere prislisten for at gøre den tilgængelig til oprettelse af tilbud. Du bør ikke aktivere prislisten, før den er helt klar.

    * **Begrænset gyldighed**: Markér feltet her, hvis prislisten kun skal være gyldig i en begrænset periode. For eksempel under tidsbegrænset salgskampagne. Du kan vælge en start- og slutdato *ELLER* bare en slutdato.

1. Gør ét af følgende:

    * Vælg **Tilføj tom prisliste**, hvis du vil starte med en tom prisliste og indtast alle produkterne manuelt.
    * Vælg **Kopiér eksisterende prisliste** for at kopiere en prisliste og alle dens produkter.

    1. Vælg den ønskede prisliste på listen nedenfor.

    2. Vælg en af følgende valgmuligheder:

        * **Konverter priser fra oprindelig prisliste til &lt;currency&gt;**: Vælg denne indstilling, hvis du vil bruge de eksisterende priser på prislisten. Hvis du kopierer en prisliste med en anden valuta end den prisliste, du opretter, konverteres priserne til den rette valuta.

        * **Angiv priser til nul &lt;currency&gt;**: Vælg denne indstilling, hvis du ikke vil kopiere priserne fra prislisten. Du skal indtaste priserne på alle produkterne i prislisten manuelt.

1. Klik på **OK**.

    > [!NOTE]
    > Når prislisten er oprettet, kan du ikke længere ændre dens valuta og gyldighed.

## Relateret indhold

* [Tilføje produkter til en prisliste][1]
* [Sync][2]
* [Tilføje en Sync Connector][3]
* [Tilføje et ERP-link][4]

<!-- Referenced links -->
[1]: add-product-to-price-list.md
[2]: ../sync/index.md
[3]: ../sync/sync-connector-add.md
[4]: ../sync/sync-add-erp-connection.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/quote/add-price-list.png
