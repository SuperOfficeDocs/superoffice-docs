---
uid: help-no-screen-designer-tabs
title: Arbeide med faner
description: Slik legger du til, organiserer, sletter og gjenoppretter en fane i et oppsett, og hvordan du organiserer informasjonen i logiske grupper ved hjelp av Skjermdesigneren i Innstillinger og vedlikehold.
keywords: Skjermdesigner, layout, oppsett, faneoppsett, overskrift, etikett, skillelinje, kolonne
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.7
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Arbeide med faner

[!include[Krav](../../../../../common/includes/req-dev-tools.md)]

Denne veiledningen antar at du allerede er [i ferd med å redigere layouten][2]. De følgende seksjonene forklarer hvordan du organiserer og tilpasser faner i SuperOffice CRM for å tilpasse grensesnittet til organisasjonens behov.

## Legg til fane

Opprettelse av tilpassede faner lar deg gruppere relaterte felter på en måte som gir mening for din organisasjon. For eksempel kan du opprette faner dedikert til spesifikke forretningsområder, noe som gjør informasjonen lettere å finne.

**Trinn:**

1. Klikk på **Legg til**. Seksjonen **Faneoppsett** åpnes til venstre.

2. Under **Fanenavn**, erstatt teksten "Ny fane" med det nye fanenavnet.

    Du kan også klikke på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til fanenavnet på andre språk][3].

3. Velg antall kolonner du vil bruke i den nye fanen.

## Gi fane nytt navn

Hvis du trenger å gi fanen nytt navn senere, velg fanen og gå til **Faneoppsett**. Du **kan ikke gi standardfanene nytt navn**.

## Fjern fane

For å forenkle skjermbildet kan du fjerne faner som ikke lenger er nødvendige. En layout må ha minst én fane. Hvis bare én fane gjenstår, kan den ikke fjernes.

> [!NOTE]
> Hvis fanen inneholder obligatoriske felt, må du flytte disse feltene til en annen fane før du sletter den gjeldende.

**Trinn:**

1. Velg fanen.
1. Klikk på **Oppgave** og velg **Fjern fane**.
1. Klikk **OK** for å bekrefte og lukke dialogen.

## Gjenopprett fane

Hvis du fjerner en fane og senere finner ut at du trenger den, kan du enkelt gjenopprette den.

1. Åpne layouten i redigeringsmodus.
1. Klikk på **Oppgave** og velg **Gjenopprett faner**.

> [!NOTE]
> Denne handlingen gjenoppretter **alle** tidligere fjernede faner.

## <a id="label"></a>Legg til overskrift eller skillelinje

Etiketter og skillelinjer hjelper deg med å organisere felter i en fane, noe som gjør informasjonen mer lesbar og tilgjengelig. Bruk etiketter til å lage overskrifter og skillelinjer til å dele opp seksjoner i en kolonne.

1. Velg fanen der du vil legge til elementet.
2. Klikk for å velge seksjonen **Elementer**.
3. For å legge til en overskrift, dra elementet **Etikett** inn i layouten.

    * I seksjonen **Innstillinger** erstatt "Ny etikett" med den nye etikettens navn. Du kan også klikke på <i class="ph ph-translate" aria-label="Translate"></i> for å [legge til overskriften på andre språk][9].
    * Juster skriften etter behov.

4. For å legge til en horisontal skillelinje, dra elementet **Skillelinje** inn i layouten. Endre skilletegnet om nødvendig.

![Skjermdesigner felter og elementer -screenshot][img2]

## <a id="columns"></a>Gruppér felter i kolonner

Som standard har faner to kolonner, men du kan justere dette etter behov. Hver fane kan ha 1, 2, 3 eller 4 kolonner, avhengig av hvor mye informasjon du vil vise.

> [!NOTE]
> Faner med spesifikke funksjoner, som **ERP** og **Notat**, støtter ikke kolonnejustering. Gå til **Innstillinger og vedlikehold** > **ERP** for å konfigurere innholdet i ERP-fanen.

**Trinn:**

1. Velg fanen der du vil justere kolonnene.
1. Gå til seksjonen **Faneoppsett**.
1. Velg ett av de fire layoutalternativene.

Når du reduserer antall kolonner, flyttes feltene fra de fjernede kolonnene til den siste gjenværende kolonnen. For eksempel, hvis du reduserer fra tre kolonner til to, vil feltene i den tredje kolonnen flyttes til bunnen av den andre kolonnen.

Kolonner vil stables oppå hverandre når skjermen er for liten til å vise dem horisontalt.

Hvis du har en bred skjerm, kan du bruke flere kolonner for å vise mer data samtidig. Vær imidlertid forsiktig: Bruk av fire kolonner kan redusere synligheten til noen felt. Å skjule feltetiketter kan bidra til å skape mer plass.

> [!TIP]
> Hvis en fane blir for overfylt, bør du vurdere å legge til flere faner for å organisere informasjonen bedre.

## <a id="more"></a>Mer-fanen

**Mer**-fanen inneholder automatisk alle [tilpassede felt][3], arrangert etter rang. Du kan konfigurere disse feltene i denne fanen og eventuelt legge dem til på andre skjermer.

[Brukerdefinerte felt][5] (udef) og [ekstra felt][4] opprettes på samme måte som før.

## Relatert innhold

* [Arbeide med felt][1]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: edit-layout.md
[3]: ../../../custom-objects/learn/index.md
[4]: ../../../custom-objects/admin/create-extra-field.md
[5]: ../../../custom-objects/admin/add-udef.md
[9]: ../../../globalization-and-localization/learn/translate-fields.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/ui/field-settings.png
