---
uid: help-da-user-add
title: Tilføjelse af bruger
description: I denne vejledning lærer du, hvordan du tilføjer en ny bruger til SuperOffice CRM.
keywords: tilføj bruger, medarbejder
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: /da/admin/user-management/learn/add-associate
language: da
---

# Tilføjelse af brugere

Når din SuperOffice CRM-løsning er konfigureret og tilpasset, er det tid til at give dine brugere adgang til deres CRM-løsning.

Administratorer er ansvarlige for at give nye brugere en brugerplan, et brugernavn, en adgangskode og den brugergruppe, brugeren tilhører. Du kan tilføje brugere til SuperOffice CRM under Indstillinger og vedligeholdelse.

> [!NOTE]
> Hvis du gav oplysninger om brugere, da du bestilte SuperOffice CRM, behøver du ikke tilføje brugere. Brugere vil have modtaget logonoplysninger fra SuperOffice via e-mail. Kontroller, om brugerne er i systemet i menuen Brugere i Indstillinger og vedligeholdelse.
>
> Denne procedure beskriver, hvordan du tilføjer en bruger ad gangen. Hvis du vil tilføje flere brugere, kan du se [Import af brugere][1].

## Trin

1. Åbn skærmbilledet Brugere.
1. Vælg fanen **Medarbejdere**.
1. Klik på knappen **Tilføj** under listen.
1. Skriv navnet og e-mailadressen på den nye bruger i øverste del af kortet.
1. Hvis der er mere end ét ejerfirma tilgængelig i din SuperOffice-installation, kan du vælge dette under feltet **E-mail**.
1. Angiv de relevante oplysninger under fanerne **Detaljer** og **Licenser**.

    ![Create user details -screenshot][img7]

1. Klik på **Gem**. Navnet på den nye bruger vises nu på listen.

    * Hvis aktive brugere har brug for en anden brugerplan, kan du [tildele brugerplaner][4] i Indstillinger og vedligeholdelse.

    * I den nederste del af brugerkortet kan du aktivere eller deaktivere den valgte brugers logonrettigheder ved at klikke på knappen **Kan logge på**. Denne indstilling aktiveres som standard, når du vælger en brugerplan for brugeren.

## <a id="fields"></a>Vigtige felter forklaret

<!-- markdownlint-disable-file MD051 -->
### [Fanen Detaljer](#tab/details)

Under fanen **Detaljer** har du følgende valgmuligheder:

* **Bruger-id**: Rediger det foreslåede ID for brugeren i feltet **Bruger-ID** (hvis du ikke vil bruge det automatisk genererede ID). Du kan ikke angive et bruger-ID, der allerede findes i databasen. Bruger-ID'et kan indeholde alle slags tegn.

    > [!NOTE]
    > Bruger-ID'et bør ikke indeholde for mange tegn, da det skal vises i ID-kolonnerne i SuperOffice CRM, og pladsen i disse kolonner kan være begrænset.

* **Kaldenavn**: Kaldenavnet er det navn, der ses af andre brugere af SuperOffice, og bruges kun til SuperOffice Service-brugere. Du kan redigere det foreslåede kaldenavn for brugeren (hvis du ikke vil bruge det automatisk genererede navn).

* **Godkendelse**: Hvis der findes flere godkendelsesmetoder, kan du vælge en godkendelsesmetode her.

* **Brugernavn**: Indtast SuperOffice-brugernavnet. Dette skal være det samme navn som i din identitetsudbyders system (hvis du bruger Office 365 eller Gmail til godkendelse). Når du bruger SuperOffice til godkendelse, skal du blot udfylde din e-mailadresse. Sørg for, at den adresserede e-mail er gyldig, da den vil blive brugt til kontobekræftelse.

* **Rolle**: Angiv, hvilken [rolle][3] brugeren skal have, i rullemenuen **Rolle**. Rollen bestemmer dataadgang og funktionelle rettigheder til brugeren. Du kan ikke ændre din egen rolle.

* **Brugerplan**: Vælg den relevante brugerplan for brugeren. Dette bestemmer, hvilke SuperOffice-funktioner brugeren kan få adgang til.

* **Fratrådt**: Hvis en bruger ikke længere skal have adgang til SuperOffice, skal du vælge denne indstilling for at fjerne brugerens brugerplan og logonrettigheder.

* **Primærgruppe**: I rullemenuen **Primærgruppe** vælges en af de foruddefinerede indstillinger for gruppetilhørsforhold. Grupperne defineres i skærmbilledet **Lister**. Brugeren får adgang til data, som ejes af andre brugere i samme primærgruppe. Adgangsrettighederne (for eksempel skrive- eller sletteadgang) for disse data er defineret i den [rolle][3], brugeren tilhører. Se [Synlighed][2], hvis du vil vide mere om, hvordan du deler data med primærgruppen.

* **Andre grupper**: Klik i feltet **Andre grupper**, og vælg, hvilke andre grupper brugeren skal tilhøre. Hvis listen indeholder mange grupper, skal du begynde at skrive et gruppenavn i søgefeltet for at filtrere listen.

* **Servicekategorier:** Disse kategorier bruges til at give brugerne adgang til bestemte sagskategorier.

* **Servicekategorier fra brugergrupper**: Viser de kategorier, som brugeren får af at være i en brugergruppe.

#### Eksempel

Joe Johnson arbejder i salgsafdelingen i et stort firma. Den primære gruppe er angivet til "Salg", så Joe har adgangsrettigheder til data, der er oprettet af brugere i salgsafdelingen. Adgangsrettighederne til den primære gruppe er defineret i den rolle, Joe tilhører. Denne rolle bestemmer, om Joe kan redigere eller slette data, der er oprettet af andre brugere i salgsafdelingen (se [Definition af datarettigheder for en rolle][8]).

Joe har også brug for begrænsede rettigheder til dokumenter fra marketingafdelingen og udviklingsafdelingen. Disse to afdelinger tilføjes under **Andre grupper**. I den rolle, Joe tilhører, er det angivet, at Joe kun har læseadgang til disse data.

### [Fanen Licenser](#tab/license)

Under fanen **Licenser** kan du vælge licenser ud over dem, der er defineret i den valgte brugerplan.

**Fortrolige aktiviteter**: Aktiverer listen **Synlig for** for opfølgninger, dokumenter og salg, så opfølgninger kun bliver synlige for brugeren, brugerens primærgruppe eller alle.

***

## Video: Tilføjelse af en ny SuperOffice CRM-bruger

Se denne demo for at se, hvordan du kan tilføje en ny bruger i SuperOffice CRM.
(Denne video viser en tidligere version af SuperOffice, så designet kan se anderledes ud. Trinene er de samme.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(videolængde – 1:46)

## Relateret indhold

* [Tilføjelse af anonym bruger eller systembruger (onsite)][5]
* [Redigering af bruger/medarbejder][6]

<!-- Referenced links -->
[1]: onsite/import-users.md
[2]: index.md#visible
[3]: role/index.md
[4]: ../license/change-user-plan.md
[5]: onsite/other-users.md
[6]: update-user.md
[8]: role/set-data-rights-for-role.md

<!-- Referenced images -->
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
