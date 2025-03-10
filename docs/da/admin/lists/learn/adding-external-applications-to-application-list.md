---
uid: help-da-adding-external-applications-to-application-list
title: Tilføjelse af eksterne programmer til programlisten
description: Tilføjelse af eksterne programmer til programlisten
keywords: listen GUI – Applikation
author: SuperOffice RnD
date: 02.28.2025
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af forekomster på listen GUI – Applikation

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] når forekomsterne er programmer eller lignende:

> [!NOTE]
> Filer eller programmer, som skal køres lokalt (for eksempel en *.exe*-fil), er ikke tilgængelige i SuperOffice CRM for Web.

1. Indtast det ønskede navn for forekomsten i feltet **Navn**. Dette navn vises der, hvor du tilføjer programmet i SuperOffice CRM (se trin 7 om rullemenuen **Vis**).

    > [!NOTE]
    > [!include[Mandatory](includes/note-mandatory-field.md)]

1. Under **Tilføj som** vælger du, hvad programmet skal tilføjes som:

    * **Knap**: Programikonet vises i navigatoren. Brugeren kan nu åbne programmet direkte ved at klikke på ikonet i navigatoren.
    * **Menuvalg**: Brugeren får adgang til programmet ved at klikke på knappen **Værktøj** (<i class="ph ph-wrench" aria-hidden="true"></i>) i navigatoren og/eller ved at vælge **Andre programmer** i hovedmenuen (<i class="ph ph-list" aria-hidden="true"></i>).
    * **Hændelse**: Programmet køres, når SuperOffice CRM startes eller afsluttes, eller ved lokal opdatering (Travel). Se trin 8. Du kan for eksempel køre et synkroniseringsprogram for en PDA, når SuperOffice CRM afsluttes.
    * **Opgave**: Vælg en indstilling i denne rullemenu for at gøre programmet tilgængeligt fra fanen **Opgave** i skærmbilledet Udvalg eller knapperne **Opgave**.

        <details><summary>Få mere at vide om de forskellige indstillinger.</summary>

        Navnene i parentes angiver det detaljekort, hvor programmet er tilgængeligt.

        Eksempler:

        * **Salgsudvalg (Salg)**: Når du har åbnet et salgsudvalg i skærmbilledet Udvalg, og detaljekortet **Salg** er aktivt, vises programmet som en opgave under fanen **Opgave**.
        * **Salgsudvalg (firmaer)**: Når du har åbnet et salgsudvalg i skærmbilledet Udvalg, og detaljekortet **Firmaer** er aktivt, vises programmet som en opgave under fanen **Opgave**.
        * **Salgsudvalg (ekstern)**: Hvis dit SuperOffice CRM-program er tilknyttet et tredjepartsprogram, sker det, at der vises flere detaljekort for de forskellige udvalg. Du kan så vælge for eksempel **Salgsudvalg (ekstern)** for at vise programmet som en opgave på fanen **Opgave**, når du åbner et salgsudvalg i skærmbilledet Udvalg, og detaljekortet for tredjepartsprogrammet er aktivt.

        Andre alternativer:

        * **Værktøjslinje**: Programmet vises som et valg på værktøjslinjen. Brugerne skal konfigurere værktøjslinjen i SuperOffice CRM og vælge at få vist programmet.

        * **Dialogboksen for opfølgninger**: Programmet vises som et valg under knappen **Opgave** i dialogboksen for opfølgninger.

        * **Dialogboksen Dokument**: Programmet vises som et alternativ under knappen **Opgave** i den valgte dialogboks. Den samme indstilling er tilgængelig for skærmbillederne Person, Tilbud og Produkt.

        </details>

    > [!NOTE]
    > Det er de valg, du foretager under **Tilføj som**, som afgør, hvilke indstillinger der skal være tilgængelige i resten af dialogboksen.

1. Under **Tilgængelig på** vælger du, hvor programmet er tilgængeligt. Du kan vælge flere af disse indstillinger samtidig.

    * **Central database**: Når du arbejder på den centrale database.
    * **Satellit**: Når du arbejder på en satellit.
    * **Travel**: Når du bruger en lokal database ved hjælp af Travel-funktionen.

1. Angiv det ønskede program i feltet **Filnavn**.

1. I feltet **Parametre** kan du angive eventuelle opstartsparametre for programmet.

1. I feltet **Arbejdsmappe** kan du angive den mappe, der skal være den gældende mappe, når programmet startes. Indtast stien manuelt. Normalt lader du dette felt stå tomt.

1. På listen **Vis** vælger du den ønskede indstilling. Denne liste vises kun, hvis du har valgt **Menuvalg** under **Tilføj som**.

    * **Værktøjsmenuen**: Brugeren får adgang til programmet ved at klikke på knappen **Værktøj** i navigatoren eller ved at vælge **Andre programmer** i hovedmenuen i SuperOffice CRM.
    * **Menuen Vis**: Brugeren får adgang til programmet via menupunktet **Andre programmer** i menuen **Vis** i SuperOffice CRM.

1. På listen **Kør når** vælger du, hvornår programmet skal startes. Denne liste vises kun, hvis du har valgt **Hændelse** under **Tilføj som**.

    * **SuperOffice CRM starter**: Programmet kører, når SuperOffice CRM starter.
    * **SuperOffice CRM afsluttes**: Programmet kører, når SuperOffice CRM lukkes.
    * **Lokal opdatering**: Programmet startes ved brug af Travel.

1. Marker **Vent på at programmet afslutter**, hvis SuperOffice CRM ikke skal lukkes, før du afslutter det eksterne program. Hvis du ikke markerer denne indstilling, kan du lukke SuperOffice CRM uden at lukke det eksterne program. Denne liste vises kun, hvis du har valgt **Hændelse** under **Tilføj som**.

1. Under **Opstartstilstand** vælger du den slags vindue, programmet skal startes i – maksimeret, minimeret eller gendannet.

1. I feltet **Ikon** kan du vælge det ikon, som eventuelt skal repræsentere programmet i navigatoren i SuperOffice CRM (se trin 7 om listen **Vis**). Denne liste vises kun, hvis du har valgt **Knap** under **Tilføj som**.

    * **Fra biblioteket**: Vælg et af de tilgængelige ikoner på listen.
    * **Brug programikonet**: Brug standardikonet for det valgte program.

1. Angiv eventuelt en beskrivelse af forekomsten i feltet **Beskrivelse**.

1. Klik på **Gem**. Forekomsten bliver nu tilføjet på listen **Forekomster**. Gentag proceduren, hvis du vil tilføje flere forekomster.

> [!NOTE]
> Brugerne skal logge på SuperOffice CRM på ny, før programmet vises.
