---
uid: help-da-archive-edit-layout
title: Rediger layout på detaljekort/arkiver
description: Skærmdesigner Rediger layout – Arkiver (detaljekort)
author: SuperOffice RnD
so.date: 02.23.2023
keywords: skærmdesigner, detaljekort, arkiv
so.topic: howto
so.user: admin
language: da
---

# Rediger layout på detaljekort/arkiver

Du kan redigere layoutet ved at tilføje eller fjerne detaljekort/arkiver på de forskellige hovedkort for Firma, Person, Salg, Projekt, og Sag.

## Entydighed

Detaljekort er fanerne placeret nederst på de fleste SuperOffice CRM-skærme. Eksempel: Skærmen Firma har detaljekort, der indeholder personer, aktiviteter, projekter og salg. De kaldes også arkiver. Der er også detaljekort, der ikke betragtes som arkiver, for eksempel detaljekort, der indeholder salgsguider, projektguider og tilbud. Med henblik på dette emne vil vi henvise til dem som arkiver eller arkivfaner (når vi henviser til den faktiske fane, der indeholder arkivet).

Når du har oprettet et nyt layout for arkiver (detaljekort) som beskrevet i Tilføj nyt layout, er det tid til at tilpasse det efter behovene i den eller de tildelte brugergrupper. Hvis du tilpasser et layout til salgsteamet, skal du have en klar plan for, hvad deres behov er med hensyn til arkivernes layout, formatering og indhold. Har de brug for tilpassede arkiver med filtrerede data? Hvilke oplysninger skal være først og nemmest at finde? Har de brug for alle arkiverne?

## Trin

Du kan tilføje en ny sektionsfane på de hovedkort, du vil. Afhængigt af det valgte hovedkort kan du tilføje en ny fane,der indeholder: Dokument, Aftale, Produkt, Projekt, Projektdeltager, Salg, Salgsinteressent, Sag, Person og Relation.

![Vælg den type indhold, du vil vise på detaljekortet -screenshot][img5]

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klik på **Arkiver**.

4. Vælg et layout på listen i venstre side.

5. Klik på **Rediger layout** under forhåndsvisningen. Et nyt vindue åbnes.

6. Se afsnittene nedenfor for at få flere oplysninger om, hvordan du redigerer layoutet.

7. Når du er færdig med at redigere layoutet, skal du klikke på en af følgende knapper:

    * **Gem udkast**: Klik på denne knap, hvis layoutet endnu ikke er færdigt.
    * **Gem + Udgiv**: Klik på denne knap for at udgive layoutet for de valgte brugergrupper.
    * **Annuller**: Klik på denne knap for at [forkaste alle ændringer](#undo-changes).
<!-- markdownlint-restore -->

## Tilføj arkivfane

1. Klik på ![ikonet][img2] **Tilføj**. Afsnittet **Fane** åbnes til venstre.

2. Under **Navn** skal du erstatte teksten **Ny fane** med navnet på arkivet. Du kan også tilføje navnet på [andre sprog][1] ved at klikke på ![ikon][img3].

3. Hvis det er relevant, skal du redigere **Unikt navn til fane (soprotocol)**. Dette navn kan ikke ændres senere.

4. Angiv en beskrivelse af arkivet i feltet **Beskrivelse**. Du kan også tilføje beskrivelsen på [andre sprog][1] ved at klikke på ![ikon][img3].

5. Vælg afsnittet **Indstillinger**.

6. På listen **Indhold** skal du vælge den type data, du vil have vist i arkivet. Dataene i arkivet vil være begrænset til data for den aktuelle skærm.

    Eksempel: Hvis du tilføjer et arkiv til skærmbilledet Firma, vises kun data, der er knyttet til det aktuelle firma.

7. Under **Filter** skal du tilføje/redigere de relevante kriterier på følgende måde:

    * [Rediger et kriterium][2].

        Eksempel: Vælg **Aftale** på listen **Indhold**, og tilføj kriterier for kun at få vist interne og eksterne møder i denne og næste uge.

    * Klik på **Tilføj** for at angive flere kriterier. Der tilføjes en ny linje til kriterielisten.

    * Hvis du vil flytte kriterier, skal du klikke og trække.

    * Klik på **Eller** for at tilføje et andet sæt kriterier.

8. Klik på **Opdater forhåndsvisning** for at få vist data for de aktuelle kriterier i forhåndsvisningen i højre side. Brug listen **Forhåndsvisning af firma** til at vælge, hvilket firma der skal forhåndsvises.

9. Klik på **Avancerede indstillinger** for at ændre standardhandlingerne for enkeltklik og dobbeltklik i arkivet. Du kan se eksempler på, hvordan du konfigurerer dette, under **Eksempel på syntaks** og ved at holde musemarkøren over ikonet (![ikon][img4]).

    > [!NOTE]
    > Som standard vælger et enkelt klik en række, og et dobbeltklik åbner en post/enhed i SuperOffice. Hvis dit firma imidlertid bruger brugerdefinerede arkiver til at vise data fra andre systemer, kan du ændre disse indstillinger for at åbne en post i et eksternt system.

10. Klik og træk det nyoprettede arkiv i forhåndsvisningen, og flyt det til den ønskede placering.

11. Gem ændringerne som beskrevet ovenfor.

## Rediger eksisterende detaljekort

Hvis du vil redigere et eksisterende arkiv, skal du markere det og redigere de tilgængelige felter og indstillinger i sektionerne **Fane** og **Indstillinger**. Du kan også klikke og trække det til en ny placering.

## Begrænsninger

* Standardfaner kan ikke redigeres.

* Nogle faner, for eksempel **Tilbud**, **Salgsguide** og **Projektguide** kan ikke redigeres, fordi de har bestemte funktioner.

## Fjern et arkiv

1. Vælg arkivet (eller en anden sektionsfane), og klik på fanen **Opgave** &gt; **Fjern**.

1. Klik på **OK** i den dialogboks, der vises. Fanen fjernes (skjult, men ikke slettet).

![Klik på Opgave og derefter Fjern fane for at fjerne uønskede faner i detaljekortet (arkiv) -screenshot][img1]

Du kan altid klikke på **Gendan faner** for at fortryde disse ændringer.

## <a id="undo-changes" />Fortryd ændringer

Hvis du har brug for at vende tilbage til en tidligere version af skærmen, kan du få adgang til følgende indstillinger fra knappen **Opgave**:

* **Nulstil til fabriksindstillinger**: Denne indstilling kasserer alle ændringer og nulstiller layoutet til det standardlayout, der leveres af SuperOffice.

* **Gendan faner**: Denne indstilling gendanner alle faner, der er blevet fjernet.

* **Slet kladde**: Kasserer alle ændringer og nulstiller til den udgivne version af layoutet.

## Tilknyttet

* [Hvordan omorganiserer jeg felterne under fanen Mere på skærmbillederne Firma og Person efter opgraderingen til SuperOffice version 10?][3] - FAQ
* [Opret nyt layout][4]

<!-- Referenced links -->
[1]: ../../../globalization-and-localization/learn/translate-fields.md
[2]: ../../../search-options/learn/using-search-criteria.md
[3]: https://community.superoffice.com/en/support-faqs/faq/how-do-i-reorganize-the-fields-in-the-more-tab-in-company-and-contact-screenscards-after-the-upgrade-to-superoffice-version-10/
[4]: add-new-layout.md

<!-- Referenced images -->
[img2]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../../common/icons/az.png
[img4]: ../../../../../common/icons/info-ball.png
[img1]: media/admin-screendesigner-edit-archive.png
[img5]: media/admin-screendesigner-edit-archive-add-tab.png
