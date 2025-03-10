---
uid: help-da-document-external
title: Arbejde med eksterne dokumenter
description: Arbejde med eksterne dokumenter
keywords: sag, dokument
author: Bergfrid Dias
date: 03.07.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Arbejde med eksterne dokumenter (vidensbase)

Du kan tilføje dokumenter (inklusive billeder og andre filer), der skal være tilgængelige for alle, der bruger SuperOffice CRM, herunder ikke-registrerede kunder. Dokumenter, der uploades til vidensbasen, er tilgængelige, når du indtaster indhold i en meddelelse, der skal sendes til en kunde.

Dette gælder f.eks., når du bruger fanen **Meddelelse**, når du [besvarer sager][1]. Hér kan du indtaste tekst på samme måde som i et tekstbehandlingsprogram. Du kan også tilføje billeder ved at klikke på knappen **Billede** på værktøjslinjen, men i så fald skal billedet først være uploadet til **Eksterne dokumenter**. Når meddelelsen sendes, genereres der links til filer, der ligger under **Eksterne dokumenter**. Det samme gælder, f.eks. når du opretter svarskabeloner og SuperOffice Marketing-meddelelser.

## Vis dokument

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> **Hovedmenu** på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.

1. Gå til den ønskede mappe.

1. Gør ét af følgende:
    * Klik på dokumentets navn for at gå til skærmbilledet **Egenskaber for dokument**. Her kan du også få vist og redigere indholdet af bestemte dokumenttyper, f.eks. html, txt og det lokale ejr-format.
    * Klik på <i class="ph ph-download-simple" aria-label="Download"></i> for at downloade dokumenter, som ikke kan vises i browseren, f.eks. PDF- og Microsoft Office-filer. Et ikon i dokumentlisten angiver dokumenttypen.

## Tilføj dokument

> [!NOTE]
> Du skal oprette selve det fysiske dokument, før du kan føje det til SuperOffice. Hvis du f.eks. skal oprette en prisliste, kan du bruge Microsoft Word eller Excel til at skrive indholdet.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.

1. Gå til den mappe, du vil placere dokumentet i. Hvis den endnu ikke findes, kan du oprette en ny mappe som beskrevet nedenfor.

1. Klik på knappen **Nyt dokument**. Du kommer til skærmbilledet **Egenskaber for dokument**.

1. Angiv et beskrivende navn på dokumentet i feltet **Navn**.

1. I feltet **I mappe** vises navnet på den mappe, du har valgt, automatisk. Hvis du har ombestemt dig, kan du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge en anden mappe på den liste, der vises.

1. I feltet **Adgang** skal du vælge, hvem der skal have adgang til at læse og ændre det aktuelle dokument.

1. Brug dokumentet i et webbaseret kundecenter ved at tilføje en valgbar, unik id-streng i feltet **Id-streng**.

1. I feltet **Beskrivelse** kan du tilføje en kort beskrivelse af, hvad dokumentet indeholder.

1. Klik på knappen **Vælg fil** ved siden af **Fil**, og vælg det nye dokument i den dialogboks, der vises.

1. Klik på **Gem**. Hvis dokumenttypen kan redigeres i browseren, udfyldes feltet **Indhold** med dokumentets indhold.

1. Klik på **OK**. Dokumentet tilføjes i den angivne mappe.

> [!NOTE]
> Visse filtyper er som standard blokeret fra at blive uploadet som eksterne dokumenter i Service. Hvis du har brug for at tillade upload af nogle af disse typer, såsom **js**, kan en administrator opdatere [systempræferencen **usikre filtyper**][9] i Indstillinger og vedligeholdelse.

## Redigering af dokumentindhold

Visse dokumenttyper, f.eks. html, txt og det lokale ejr-format, kan redigeres direkte i skærmbilledet **Egenskaber for dokument**. For andre typer, f.eks. PDF, skal du bruge det program, som dokumentet oprindeligt blev oprettet i.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.
1. Gå til den mappe, som dokumentet ligger i.
1. Klik på <i class="ph ph-download-simple" aria-label="Download"></i> for at downloade et dokument.
1. Rediger og gem dokumentet ved hjælp af det program, som dokumentet oprindeligt blev oprettet i.
1. Klik på dokumentets navn for at gå til skærmbilledet **Egenskaber for dokument**.
1. Klik på knappen **Gennemse** ved siden af **Fil**, og vælg det dokument, du har redigeret, i den dialogboks, der vises.
1. Klik på **OK** for at uploade dokumentet.

## Redigering af dokumentegenskaber

Ved at redigere dokumentegenskaberne kan du f.eks. justere, hvem der skal have adgang til dokumentet.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.
1. Gå til den mappe, som dokumentet ligger i.
1. Klik på dokumentets navn for at gå til skærmbilledet **Egenskaber for dokument**.
1. Foretag de nødvendige ændringer (se ovenfor).
1. Klik på **OK**. Ændringerne gemmes.

> [!TIP]
> Flyt dokumentet til en anden mappe ved at vælge en ny mappe i feltet **I mappe**.

## Slet dokument

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.
1. Gå til den mappe, som dokumentet ligger i.
1. Klik på dokumentets navn for at gå til skærmbilledet **Egenskaber for dokument**.
1. Klik på knappen **Slet** nederst i skærmbilledet.
1. Klik på **OK** for at bekræfte. Dokumentet fjernes fra SuperOffice Service.

## Oprettelse af mapper

Du kan oprette en mappestruktur til dokumenter, så du får en logisk struktur, der gør det let for andre at finde oplysningerne. Du kan oprette undermapper i alle mapper, og i hver af disse mapper kan du tilføje de dokumenter, der hører hjemme der.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.

1. Gå til den mappe, som du vil oprette undermappen under. Du kan vælge at oprette den lige under **Dokumenter** eller i en vilkårlig undermappe under denne.

1. Klik på knappen **Ny mappe** øverst i skærmbilledet. Du kommer til skærmbilledet **Egenskaber for dokumentmappe**.

1. Angiv et beskrivende navn på mappen i feltet **Navn**.

1. I feltet **I mappe** vises automatisk navnet på den overordnede mappe, du har valgt. Hvis du har ombestemt dig, kan du klikke på <i class="ph ph-caret-down" aria-label="Chevron"></i> og vælge en anden mappe på den liste, der vises.

1. I rullemenuen **Adgang** skal du vælge, hvem der skal have adgang til at læse og ændre den aktuelle mappe.

1. Klik på **OK**. Den nye mappe oprettes. Du er nu klar til at tilføje dokumenter til den nye mappe.

### Sletning af mapper

Når du sletter en mappe, slettes alle dokumenterne i den også fra SuperOffice.

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **Eksterne dokumenter**.
1. Gå til den ønskede mappe.
1. Klik på **Rediger mappe**. Du kommer til skærmbilledet **Egenskaber for dokumentmappe**.
1. Klik på **Slet**.
1. Klik på **OK** for at bekræfte. Mappen og indholdet i den fjernes fra SuperOffice.

<!-- Referenced links -->
[1]: reply.md
[9]: ../../../../release-notes/10.3/service/10.3.11-update.md
