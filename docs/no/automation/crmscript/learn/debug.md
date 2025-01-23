---
uid: help-no-automation-script-debug
title:  Feilsøkingsøkter
description: Feilsøkingsøkter
author: SuperOffice RnD
date: 06.29.2022
keywords: CRMScript
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Feilsøkingsøkter

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Fanen **Feilsøkingsøkter** inneholder en liste over alle aktive feilsøkingssesjoner i systemet. Klikk på en økt i listen for å åpne den i **Feilsøking**.

## Gå til fanen Feilsøkingssesjoner

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klikk på **CRMScript**, og velg deretter fanen **Feilsøkingssesjoner** .

## Start feilsøkingssesjon

Du kan starte en av disse sesjonene ved å kjøre et skript i feilsøkingsmodus fra bildet **Skript**, eller ved å kalle funksjonen "Void enableDebug(String key)" i et CRMScript.

Du kan også klikke på **Start sporing av skript** for å begynne å [spore][2] skriptene i listen.

## Feilsøking

Feilsøkingsverktøyet gjør det enkelt å finne og løse feil i skript og makroer. Du kan feilsøke skript og makroer i et produksjonsmiljø uten å påvirke de andre SuperOffice-brukerne. Det gjør det mulig for deg å undersøke skriptene og makroene i sanntid, mens de kjøres. Du kan gå gjennom kjøringen av skriptet, bruke stoppunkter og vise de ulike verdiene.

Du kan feilsøke et skript eller en makro ved å åpne det/den i fanen **Makroer og skript** og deretter klikke på <i class="ph ph-bug" aria-hidden="true"></i> **Feilsøk skript**.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Klikk på **CRMScript**, og velg deretter **kategorien Makroer og skript** .

Du kan også klikke på **Spor skript** for å begynne å [spore et skript][2].

<!-- Referenced links -->
[2]: tracing.md
