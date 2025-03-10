---
uid: help-da-faq-create
title: Oprettelse af FAQ-poster
description: Oprettelse af FAQ-poster
keywords: FAQ
author: Bergfrid Dias
date: 02.25.2025
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: da
---

# Oprettelse af FAQ-poster

Ved at oprette FAQ-poster kan organisationen opbygge en omfattende samling spørgsmål og svar, som både kunder og interne sagsbehandlere kan bruge til at tilegne sig nyttige oplysninger. FAQ-poster kan oprettes på to forskellige måder:

* En sagsbehandler tager initiativ til, at der oprettes en FAQ-post baseret på kommunikation med en kunde i skærmbilledet Sager.
* En administrator kan oprette en FAQ-post direkte i **Vidensbase** > **FAQ**.

Se denne video, og find ud af, hvordan du opretter og udgiver ofte stillede spørgsmål i kundecenteret, eller følg den trinvise vejledning nedenfor (videoens længde - 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/TLOukelJp54]
*Sådan opretter og udgiver du en FAQ - Denne video er oprettet til version 8, så vejledningerne kan afvige lidt fra, hvordan den ser ud i dag, men du vil forstå, hvordan du gør de samme trin i dagens version.*

## Krav

* Du skal have en licens til Service Premium eller Customer Engagement-platformen for at bruge videnbasen.
* Hvis du ikke kan se denne funktion, skal du tilføje *Knowledge base* som funktionel ret til at oprette ofte stillede spørgsmål.

## Oprettelse af FAQ-poster fra en sag

Hvis du svarer på en henvendelse og tænker, at det samme spørgsmål ofte går igen, kan det være smart at oprette et svar, der kan genbruges og gøres tilgængeligt for alle kunder.

1. [Åbn en sag][1].

1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i>, og vælg **Udgiv til FAQ**. Du kommer til skærmbilledet **Egenskaber for FAQ-post**.

   ![Skærmbilledet Egenskaber for FAQ-post -screenshot][img5]

1. Rediger sagens navn i feltet **Navn**, det er nødvendigt.

1. I feltet **Placering** vælger du et nummer, det repræsenterer postens placering i sorteringsrækkefølgen i den mappe, den tilhører. 1 betyder øverst på listen.

1. I feltet **Mappe** skal du vælge, hvilken mappe du vil anbringe posten i (hvis du har en [mappestruktur for FAQ-poster][2]).

1. I feltet **Adgang** skal du vælge, hvem der skal have adgang til den aktuelle FAQ-post:

    * **Privat**: Kun dig. Dette kan være relevant, hvis du opretter nye FAQ-poster eller opdaterer forældede FAQ-poster.
    * **Tilgængelig for interne brugere**: Kun interne brugere (og ikke kunder, der bruger SuperOffice Customer Centre).
    * **Tilgængelig for registrerede**kunder: Registrerede kunder, der har logonadgang til SuperOffice Customer Centre.
    * **Tilgængelig for alle**: Alle (intet logon påkrævet for at læse FAQ).

1. I feltet **Nøgleord** kan du tilføje nøgleord (brug mellemrum eller komma som skilletegn) for posten. Sørg for kun at tilføje nøgleord, der er relevante for posten. Nøgleord gør det nemmere at finde posten, når du søger. Desuden bruges nøgleord til automatisk at foreslå FAQ-poster, der svarer til en sag fra en kunde.

1. Hvis du er FAQ-administrator, kan du vælge mellem følgende valgmuligheder i feltet **Workflow**:

    * **Ikke-udgivet**: Vælg denne valgmulighed, hvis du ikke vil udgive FAQ-posten med det samme.
    * **Udgivet**: Vælg denne valgmulighed, hvis du vil [udgive FAQ-posten med det samme][3].
    * **Udløbet**: Vælg denne valgmulighed, hvis FAQ-posten ikke længere er aktuel. Relevant, når du redigerer eksisterende FAQ-poster.

    > [!NOTE]
    > Listen indeholder også eventuelle brugerdefinerede workflowtrin, som er lagt ind i systemet.

1. Hvis du vælger en dato i feltet **Gyldig til**, ændres postens status til **Udløbet** på denne dato. Derefter vil den ikke være tilgængelig for andre end FAQ-administratorerne. De vil blive underrettet om, at posten er udløbet. Dette kan være aktuelt i forbindelse med kampagner. Hvis du ikke angiver nogen dato her, betyder det, at FAQ-posten altid vil være tilgængelig.

1. I feltet **Vedhæftning** kan du vedhæfte ét eller flere dokumenter til sagen:

    1. Klik på **Vælg fil** ved siden af **Vedhæftet fil**.
    2. I dialogboksen skal du gennemse mulighederne, indtil du når frem til det ønskede dokument.
    3. Klik på **+** for at tilføje vedhæftningen.
    4. Gentag denne fremgangsmåde for at tilføje flere vedhæftede filer.

1. I feltet **Link** kan du tilføje én eller flere adresser til relevante websider:

    1. I feltet til venstre skal du indtaste det navn, der skal vises for linket.
    2. I feltet til højre skal du indtaste den faktiske webadresse efter `http://`
    3. Klik på **+** for at tilføje linket.
    4. Gentag denne fremgangsmåde for at tilføje flere links.

1. Gå til fanen **Spørgsmål**.

1. Indtast det spørgsmål, du vil have FAQ-posten til at indeholde. Som standard indsættes den første meddelelse i sagen i fanen **Spørgsmål** .

    > [!TIP]
    > Klik på **Formater skrifttype** knappen (<i class="ph ph-text-a-underline" aria-hidden="true"></i>) for at ændre tekstens layout.

1. Gå til fanen **Svar**, og angiv svaret. Som standard indsættes de næste meddelelser i sagen i fanen **Svar**.

1. Hvis du har mere end ét [sprog][6], skal du vælge de forskellige **sprog**, i sidefoden og gentage trinnene for **Spørgsmål** og **svar**.

1. Klik på **OK**, når du er færdig. Skærmbilledet **FAQ-post** vises, og dit forslag til en FAQ-post sendes til administratoren, som kan udgive den.

## Oprettelse af ny FAQ

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> på toplinjen, og vælg **Vidensbase** > **FAQ**.

1. Gå til den mappe, du vil placere FAQ-posten i. Hvis den endnu ikke findes, kan du [oprette en ny mappe][2].

1. Klik på knappen **Ny post**. Du kommer til skærmbilledet **Egenskaber for FAQ-post**.

    ![Skærmen FAQ -screenshot][img3]

1. Følg fremgangsmåden ovenfor startende ved **trin 3**.

Da muligheden for at oprette FAQ-poster på denne måde kun er tilgængelig for **administratorer**, er der ikke er behov for et selvstændigt udgivelsestrin i processen. Administratoren kan oprette og udgive på samme tid.

## Relateret indhold

* [Rediger FAQ-poster][4]
* [Tilføj ofte stillede spørgsmål i en meddelelse][5]
* [Konfigurer flere sprog][6]

<!-- Referenced links -->
[1]: ../../request/learn/index.md#open
[2]: manage-folders.md
[3]: publish.md
[4]: edit.md
[5]: add-to-request.md
[6]: ../../admin/options/learn/custlang/index.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/faq/create-publish-faq.png
[img5]: ../../../media/loc/en/faq/faq-create.png
