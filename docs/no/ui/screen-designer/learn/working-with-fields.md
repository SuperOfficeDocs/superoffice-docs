---
uid: help-no-screen-designer-fields
title: Arbeide med felt
description: Hvordan legge til, flytte og fjerne felt i en layout ved hjelp av Skjermdesigneren i Innstillinger of vedlikehold.
keywords: Skjermdesigner, layout, oppsett, feltinnstilling, feltformatering, felt
author: Bergfrid Dias
date: 10.07.2024
version: 10
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Arbeide med felt

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Etiketter og felt representerer det essensielle innholdet på en skjerm. Enten du oppretter en ny layout eller redigerer en eksisterende, starter du med å klikke på **Rediger layout**. [Vis meg de detaljerte trinnene.][1] Når du er ferdig, **lagre eller publiser** layouten.

> [!TIP]
> Vurder å [legge til eller fjerne faner][2] før du finjusterer feltene.

![Skjermdesigner, firmakort, standard feltlayout -screenshot][img1]

Listen over felt på en hvilken som helst skjerm inneholder alle standardfelt for det området i SuperOffice, i tillegg til alle tilpassede felt (både brukerdefinerte og ekstra felt).

## <a id="add"></a>Legg til felt

Alle felt kan vises på flere steder hvis det er relevant.

1. Velg fanen der du vil legge til feltet.

2. Sørg for at seksjonen **Felt** er valgt.

3. Finn ønsket felt i **Felt**-listen.

    > [!TIP]
    > Bruk filterfunksjonen for å finne spesifikke felt.

4. Dra feltet fra listen til et område med stiplede linjer i den valgte fanen.

    ![Bokser med stiplede linjer -screenshot][img6]

    For å gjøre et felt synlig på alle faner, plasser feltet i overskriften eller bunnteksten av layouten.

## <a id="settings"></a>Rediger feltinnstillinger

Rediger feltformatering (for eksempel skriftstørrelse) for å forbedre synligheten.

1. Velg fanen som inneholder feltet.

1. Klikk på feltet i forhåndsvisningen.

1. I seksjonen **Innstillinger**, rediger feltformateringen. De tilgjengelige innstillingene avhenger av valgt felttype.

    * Velg **Fet** eller *Kursiv* for å endre skriftstilen
    * Bytt mellom venstre- og høyrejusterte verdier
    * Velg mellom liten, normal og stor skrift

For eksempler på formatering, se skjermbildet i seksjonen om å [legge til en overskrift eller skillelinje][3].

## <a id="move"></a>Flytt felt

Legg til eller flytt viktige tilpassede felt til hovedfanen (den venstre fanen) for enkel tilgang. Flytt mindre viktige felt til sekundære faner som et alternativ til å fjerne dem.

**Trinn:**

1. Velg fanen som inneholder feltet.

2. Klikk på **=** til venstre for feltets etikett, og dra feltet til en ny posisjon.

    > [!TIP]
    > For å flytte et felt til en annen fane, dra det til den nye fanen, vent på at forhåndsvisningen oppdateres, og slipp deretter feltet i et stiplede område på den nye fanen.

## <a id="delete"></a>Fjern (skjul) felt

For å redusere rot, skjul felt som aldri brukes. Fjernede felt påvirker kun det som vises i brukergrensesnittet og endrer ikke databasen eller tabellverdier.

* For å fjerne et felt, hold markøren over feltet og klikk på den røde sirkel x-en.

* For å gjenopprette feltet, bare [legg til feltet på nytt](#add).

> [!NOTE]
> Obligatoriske felt kan ikke slettes. Du kan imidlertid flytte et obligatorisk felt til en annen fane.

<!-- Referenced links -->
[1]: edit-layout.md
[2]: working-with-tabs.md
[3]: working-with-tabs.md#label

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/ui/edit-card-layout-fields.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
