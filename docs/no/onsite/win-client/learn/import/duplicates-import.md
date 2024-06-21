---
uid: help-no-duplicates-import
title: Import av duplikater
description: Import av duplikater
author: SuperOffice RnD
date: 06.29.2022
keywords: Innstillinger for Windows-klient
topic: help
language: no
client: win
envir: onsite
---

# Duplikater

Det oppstår duplikater hvis samme oppføring finnes i både importfilen og i databasen. I en [importbeskrivelse][1] må du alltid angi regler for hvordan duplikater skal håndteres ved import. Disse reglene blir deretter inkludert i importbeskrivelsen når du lagrer denne. Dette gjelder alle datatyper. I tabellen **Duplikathåndtering** finner du følgende kolonner:

* **Tabell**: Viser hvilken datatype denne duplikathåndteringsregelen gjelder for. Innholdet i denne kolonnen baseres på hva du har angitt i kolonnen **Felt i SuperOffice CRM** under **Felttilordning**.
* **Nøkkel**: Viser en importnøkkel, kriteriene som må oppfylles for at en oppføring skal oppfattes som et duplikat.
* **Handling**: Viser hva som skjer hvis det oppstår et duplikat.

## Hva vil du gjøre nå?

* [Oppdatere regler for duplikathåndtering][2]
* [Tilbakestille regler for duplikathåndtering][3]

<!-- Referenced links -->
[1]: import-descriptions.md
[2]: updating-rules-for-duplicate-handling.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
