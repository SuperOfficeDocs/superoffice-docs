---
uid: help-da-user-add
title: Tilføjelse af bruger
description: I denne vejledning lærer du, hvordan du tilføjer en ny bruger til SuperOffice CRM.
keywords: tilføj bruger, medarbejder
author: digitaldiina
date: 06.10.2026
version: 12.0
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
tier: starter
redirect_from: /da/admin/user-management/learn/add-associate
language: da
---

# Tilføjelse af brugere

Når din SuperOffice CRM-løsning er konfigureret og tilpasset, er det tid til at give dine brugere adgang. Denne vejledning beskriver, hvordan du tilføjer en bruger ad gangen.

Administratorer er ansvarlige for at tildele hver ny bruger et brugernavn, en adgangskode og en primærgruppe. I **SuperOffice CRM Online** inkluderer dette også valg af en brugerplan. I abonnementer på **SuperOffice CRM Suite** gælder firmaets plan for alle brugere – aktiver blot indstillingen **Kan logge på** for at give adgang.

> [!NOTE]
> Hvis du gav brugeroplysninger, da du bestilte SuperOffice CRM, er disse brugere muligvis allerede i systemet med logonoplysninger sendt til dem via e-mail. Kontroller skærmbilledet **Brugere**, inden du tilføjer nogen manuelt.

## Trin

1. Åbn skærmbilledet Brugere.
1. Vælg fanen **Medarbejdere**.
1. Klik på knappen **Tilføj** under listen.
1. Skriv navnet og e-mailadressen på den nye bruger i øverste del af kortet.
1. Hvis der er mere end ét ejerfirma tilgængeligt i din SuperOffice-tenant, kan du vælge ejeren under feltet **E-mail**.
1. Angiv de relevante oplysninger under fanerne **Detaljer** og **Licenser**.

    ![Create user details -screenshot][img7]

1. Klik på **Gem**. Navnet på den nye bruger vises nu på listen.

    * **SuperOffice CRM Online:** Hvis aktive brugere har brug for en anden brugerplan, kan du [tildele brugerplaner][4] i Indstillinger og vedligeholdelse.
    * **SuperOffice CRM Suite:** Administrer brugeradgang ved at aktivere eller deaktivere indstillingen **Kan logge på**. Firmaets plan bestemmer, hvilke funktioner alle brugere har adgang til. Se [CRM Suite-planer][5].

## <a id="fields"></a>Vigtige felter forklaret

<!-- markdownlint-disable-file MD051 -->
### [Fanen Detaljer](#tab/details)

Under fanen **Detaljer** har du følgende valgmuligheder:

* **Bruger-id:** Rediger det foreslåede ID for brugeren i feltet **Bruger-ID** (hvis du ikke vil bruge det automatisk genererede ID). Du kan ikke angive et bruger-ID, der allerede findes i databasen. Bruger-ID'et kan indeholde alle slags tegn.

    > [!NOTE]
    > Bruger-ID'et bør ikke indeholde for mange tegn, da det skal vises i ID-kolonnerne i SuperOffice CRM, og pladsen i disse kolonner kan være begrænset.

* **Kaldenavn:** Kaldenavnet er det navn, der ses af andre brugere af SuperOffice, og bruges kun til SuperOffice Service-brugere. Du kan redigere det foreslåede kaldenavn for brugeren (hvis du ikke vil bruge det automatisk genererede navn).

* **Godkendelse:** Hvis der findes flere godkendelsesmetoder, kan du vælge en godkendelsesmetode her.

* **Brugernavn:** Indtast SuperOffice-brugernavnet. Dette skal være det samme navn som i din identitetsudbyders system (hvis du bruger Office 365 eller Gmail til godkendelse). Når du bruger SuperOffice til godkendelse, skal du blot udfylde din e-mailadresse. Sørg for, at den adresserede e-mail er gyldig, da den vil blive brugt til kontobekræftelse.

* **Rolle:** Angiv, hvilken [rolle][3] brugeren skal have, i rullemenuen **Rolle**. Rollen bestemmer dataadgang og funktionelle rettigheder til brugeren. Du kan ikke ændre din egen rolle.

* **Brugerplan:** Vælg den relevante brugerplan for brugeren. Dette bestemmer, hvilke SuperOffice-funktioner brugeren kan få adgang til. (Kun SuperOffice CRM Online. I abonnementer på SuperOffice CRM Suite gælder firmaets plan for alle brugere.)

* **Fratrådt:** Hvis en bruger ikke længere skal have adgang til SuperOffice, skal du vælge denne indstilling for at fjerne brugerens brugerplan og logonrettigheder.

* **Primærgruppe:** I rullemenuen **Primærgruppe** vælges en af de foruddefinerede indstillinger for gruppetilhørsforhold. Grupperne defineres i skærmbilledet **Lister**. Brugeren får adgang til data, som ejes af andre brugere i samme primærgruppe. Adgangsrettighederne (for eksempel skrive- eller sletteadgang) for disse data er defineret i den [rolle][3], brugeren tilhører. Se [Synlighed][2], hvis du vil vide mere om, hvordan du deler data med primærgruppen.

* **Andre grupper:** Klik i feltet **Andre grupper**, og vælg, hvilke andre grupper brugeren skal tilhøre. Hvis listen indeholder mange grupper, skal du begynde at skrive et gruppenavn i søgefeltet for at filtrere listen.

* **Servicekategorier:** Disse kategorier bruges til at give brugerne adgang til bestemte sagskategorier.

* **Servicekategorier fra brugergrupper:** Viser de kategorier, som brugeren får af at være i en brugergruppe.

#### Eksempel

Joe Johnson arbejder i salgsafdelingen i et stort firma. Den primære gruppe er angivet til "Salg", så Joe har adgangsrettigheder til data, der er oprettet af brugere i salgsafdelingen. Adgangsrettighederne til den primære gruppe er defineret i den rolle, Joe tilhører. Denne rolle bestemmer, om Joe kan redigere eller slette data, der er oprettet af andre brugere i salgsafdelingen (se [Definition af datarettigheder for en rolle][8]).

Joe har også brug for begrænsede rettigheder til dokumenter fra marketingafdelingen og udviklingsafdelingen. Disse to afdelinger tilføjes under **Andre grupper**. I den rolle, Joe tilhører, er det angivet, at Joe kun har læseadgang til disse data.

### [Fanen Licenser](#tab/license)

Under fanen **Licenser** kan du vælge yderligere licenser.

**Fortrolige aktiviteter:** Aktiverer listen **Synlig for** for opfølgninger, dokumenter og salg, så opfølgninger kun bliver synlige for brugeren, brugerens primærgruppe eller alle.

***

## Video: Tilføjelse af en ny SuperOffice CRM-bruger

Se denne demo for at se, hvordan du kan tilføje en ny bruger i SuperOffice CRM.
(Denne video viser en tidligere version af SuperOffice, så designet kan se anderledes ud. Trinene er de samme.)

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/oLlfTrCAqCU]

(videolængde – 1:46)

## Fejlfinding

### En nyoprettet bruger kan ikke logge på SuperOffice

Der er to almindelige situationer, når en ny bruger ikke kan logge på:

* Brugernavnet er ikke en e-mailadresse, eller e-mailadressen er ikke gyldig
* Den nye brugers konto er ikke aktiveret

1. [!include[Klik på Brugere](includes/goto-users.md)]

1. Vælg den bruger, der ikke kan logge på, på listen over brugere.

1. Sørg for, at brugeren har angivet en gyldig e-mailadresse, da aktiverings-e-mailen sendes til denne adresse.

    ![Bekræft brugerens e-mailadresse -screenshot][img2]

1. Sørg for, at brugeren har modtaget aktiverings-e-mailen, og at aktiveringslinket er klikket inden for 48 timer.

    ![Aktiverings-e-mail -screenshot][img3]

    Hvis du vil sende velkomst-e-mailen igen, skal du gå til **Indstillinger og vedligeholdelse** > **Brugere**, vælge din bruger, klikke på knappen **Opgave** og vælge **Send velkomst-e-mail**.

1. Sørg for, at brugeren har fulgt [vejledningen til at logge på SuperOffice CRM][7].

## Relateret indhold

* [Redigering af bruger/medarbejder][6]
* [Onsite-brugerstyring][10]

<!-- Referenced links -->

[2]: index.md#visible
[3]: role/index.md
[4]: ../license/user-plans.md#change
[5]: ../license/crm-suite.md
[6]: update-user.md
[7]: ../../learn/getting-started/login.md
[8]: role/set-data-rights-for-role.md
[10]: https://help.superoffice.com/docs/11/da/admin/user-management/add-associate.html

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/filled-in-email.png
[img3]: ../../../media/loc/en/admin/activation-email.png
[img7]: ../../../media/loc/en/admin/selected-user-plan.png
