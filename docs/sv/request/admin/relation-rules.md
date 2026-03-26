---
uid: help-sv-request-relation-rules
title: Regler för relation
description: Lär dig hur du konfigurerar regler för relation för att automatisera beteendet vid skapande och stängning av ärenden baserat på parent-child-relationer i SuperOffice Service.
keywords: regler för relation, ärenderelation, parent-child, relationsregel, automatisering, stänga ärende, fliken Regler för relation
author: digitaldiina
date: 04.08.2026
version: 11.12
content_type: howto
license: servicepremium
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
---

# Regler för relation

Regler för relation definierar automatiska beteenden som tillämpas när ärenden skapas eller stängs, baserat på parent-child-relationer mellan specifika ärendetyper. De hjälper dig att upprätthålla konsekvens i din supportprocess — till exempel genom att blockera ett parent-ärende från att stängas tills alla child-ärenden är lösta, eller genom att uppmana agenter att stänga relaterade ärenden tillsammans.

> [!NOTE]
> Regler utlöser automatiska åtgärder endast i användargränssnittet för ärenden. API- och CRMScript-operationer påverkas inte.

## Vad är en regel för relation?

En regel för relation består av:

* **Villkor:** vilka ärendetyper regeln gäller för (källa och mål).
* **Beteende:** vad som händer automatiskt när matchande ärenden skapas eller stängs.

## Var hittar jag regler för relation?

Välj **Ärenden** i navigatorn i **Inställningar och underhåll** och gå till fliken **Regler för relation**.

![Inställningar och underhåll, Regler för relation -screenshot][img1]

[!include[Begränsad åtkomst](../../learn/includes/note-insufficient-rights.md)]

## Inställningar

### Villkor

| Fält | Beskrivning |
|---|---|
| Från (källa) | En eller flera källärendetyper. |
| Relation | Relationstypen (Parent eller Child). |
| Till (mål) | En eller flera målärendetyper. |

Sammanfattningsraden nedanför villkoret bekräftar regelns fulla omfång på ett tydligt språk. En varning visas om villkoret överlappar med en befintlig regel.

### Beteende: Vid skapande

| Alternativ | Beskrivning |
|---|---|
| **Kräver att parent har angetts** | Förhindrar att ett nytt ärende sparas om inte ett parent-ärende har angetts. Gäller endast om fältet **Parent** har lagts till i ärendeskärmbilden i [Screen Designer][3]. |

### Beteende: Vid stängning

| Alternativ | Beskrivning |
|---|---|
| **Förhindra stängning av parent tills alla underordnade ärenden har stängts** | Blockerar parent-ärendet från att stängas medan child-ärenden fortfarande är öppna. |
| **Erbjudande om att stänga parent när alla underordnade ärenden (child) stängs** | När det sista child-ärendet stängs uppmanas agenten att även stänga parent-ärendet. |
| **Erbjudande om att stänga underordnade (child) ärenden och skicka meddelande när parent stängs** | När parent-ärendet stängs uppmanas agenten att stänga alla öppna child-ärenden och lägga till ett svarsmeddelande i varje, som skickas till deras mottagare. |

## Lägg till regel för relation

1. Välj **Ärenden** i navigatorn i **Inställningar och underhåll** och gå till fliken **Regler för relation**.

1. Klicka på knappen **Lägg till**.

    ![Lägg till regel för relation -screenshot][img2]

1. Ange ett **Regelnamn** och eventuellt en **Beskrivning**.

1. I avsnittet **Villkor** väljer du **Relation**-typen och sedan en eller flera ärendetyper i fälten **Från (källa)** och **Till (mål)**. Sammanfattningsraden nedanför villkoret bekräftar vad regeln gäller för.

    > [!NOTE]
    > Om villkoret överlappar med en befintlig regel visas en konfliktvarning. Justera ärendetyperna för att lösa konflikten innan du sparar.

1. I avsnittet **Beteende** markerar du de alternativ du vill aktivera för **Vid skapande** och **Vid stängning**.

1. Klicka på **Spara**.

## Redigera regel för relation

1. I fliken **Regler för relation** klickar du på regeln i listan till vänster.

1. Gör dina ändringar.

1. Klicka på **Spara**.

## Ta bort regel för relation

1. I fliken **Regler för relation** väljer du regeln i listan till vänster.

1. Klicka på knappen **Ta bort** längst ned i listan.

## Exempel: Incidenthantering

Ett stort serviceavbrott genererar flera enskilda problemrapporter från berörda kunder. Varje kundrapport registreras som ett child-ärende kopplat till en gemensam incident som parent-ärende.

* **Förhindra stängning av parent tills alla underordnade ärenden har stängts:** håller incidenten öppen tills varje problemrapport har hanterats och säkerställer att ingenting förbises.

* **Erbjudande om att stänga parent när alla underordnade ärenden (child) stängs:** när den sista problemrapporten är löst uppmanas agenten att stänga incidenten.

* **Erbjudande om att stänga underordnade (child) ärenden och skicka meddelande när parent stängs:** när incidenten är löst kan agenten stänga alla återstående child-ärenden på en gång och svara direkt till varje berörd kund om att problemet är åtgärdat.

## Relaterat innehåll

* [Ärenderelationer][1]
* [Ärendetyper][2]

<!-- Referenced links -->
[1]: ../learn/request-relations.md
[2]: type/index.md
[3]: ../../customization/screen-designer/admin/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/relation-rules.png
[img2]: ../../../../media/loc/en/request/add-relation-rule.png
