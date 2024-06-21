---
uid: help-da-duplicates-import
title: Dubletimport
description: Dubletimport
author: SuperOffice RnD
date: 06.29.2022
keywords: Indstillinger for Windows-klient
topic: help
language: da
client: win
envir: onsite
---

# Dubletter

Der opstår dubletter, hvis den samme post findes både i importfilen og i databasen. Du skal altid angive regler for håndtering af dubletter under en import i en [importbeskrivelse][1]. Disse regler medtages derefter i importbeskrivelsen, når du gemmer den. Dette gælder for alle datatyper. Tabellen **Dublethåndtering** har følgende kolonner:

* **Tabel**: viser, hvilken datatype denne regel for dublethåndtering gælder for. Indholdet af denne kolonne er baseret på det, du har angivet i kolonnen **Felt i SuperOffice CRM** under **Felttilknytning**.
* **Nøgle**: viser en importnøgle, de kriterier, der skal opfyldes, for at en post kan betragtes som en dublet.
* **Handling**: viser, hvad der sker, hvis der registreres en dublet.

## Hvad vil du foretage dig nu?

* [Opdatering af regler for dublethåndtering][2]
* [Nulstilling af regler for dublethåndtering][3]

<!-- Referenced links -->
[1]: import-descriptions.md
[2]: updating-rules-for-duplicate-handling.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
