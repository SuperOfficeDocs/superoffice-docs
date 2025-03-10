---
uid: help-da-mailing-create
title: Oprette ny udsendelse
description: Hvis du vil sende en marketingmail ud, skal du bare følge fem nemme trin. En opsætning af mail indebærer, at mailbeskeden skal udarbejdes, der skal udfyldes basisoplysninger, og der skal vælges en skabelon.
author: SuperOffice RnD
date: 02.20.2023
keywords: Marketing, udsendelse
topic: howto
language: da
---

# Oprette ny udsendelse

Du kan enten oprette ny mail direkte i SuperOffice Marketing, eller du kan sammensætte en mail ved hjælp af udvalget i SuperOffice CRM.

## Workflow for udsendelser

Når du opretter en udsendelse, følger du et workflow der består af 5 trin:

1. **Opsætning**
1. **Skabelon** (dette trin springes over, hvis du opretter udsendelsen ved hjælp af en skabelon eller en eksisterende mailudsendelse)
1. **Indhold**
1. **Modtagere** (gælder ikke for formularer)
1. **Bekræft** (gælder ikke for formularer)

![Workflow for udsendelser -screenshot][img1]

**Grøn** = Fuldført trin | **Rød** = Trin ikke fuldført eller sprunget over | Grå/prikket = Trin ikke påbegyndt

Hvert trin i workflowet skal være fuldført, inden du går videre til det næste. Du kan dog klikke på færdige trin og foretage ændringer, før du sender udsendelsen.

## Vælge udsendelsestype

Det første, du skal gøre, er at vælge hvilken udsendelsestype du ønsker at sende. Når du vælger type mailudsendelse, sikrer SuperOffice CRM, at du ikke sender din mail ud til de personer, der ikke abonnerer på den mailtype, du skal til at sende.

> [!NOTE]
Hvis du har påbegyndt mailen ved at sammensætte fra udvalget i SuperOffice CRM har du allerede valgt udsendelsestype. Du føres automatisk videre til trinnet **Indstillinger**.

1. Vælg fanen **Udsendelser**.

2. Vælg en af de følgende under **Opret ny udsendelse** i højre side af skærmen:
    * **E-mail**
    * **SMS**
    * **Dokument**
    * **Formular svar**

3. Du har nu påbegyndt et workflow for at oprette en udsendelse. Følg trinnene for den valgte type:

    * [E-mail][1]
    * [SMS][2]
    * [Dokument][3]
    * [Formularbesvarelse][4]

## Åbningsrate

Din emnelinje har indflydelse på din mails åbningsrate. På grundlag af emnelinjen afgør folk, om de vil åbne og læse en e-mail. Så sørg for, at din emnelinje skiller sig ud.

Afsenderen spiller også en rolle for åbningsraten. Folk er mere tilbøjelige til at åbne din e-mail, hvis de genkender dit navn som afsender. Du kan styre, hvordan afsenderen vises, ved at angive afsenderens navn og e-mailadresse på denne måde: "Navn"<email@address.com>

Hvis du bruger Google Analytics til at analysere trafik og brugeradfærd på dit websted, kan du koble dine mailudsendelser til dine Google Analytics-rapporter.

## Oprette en mailudsendelse

I trin tre kan [du teste din mailudsendelse][10] ved at sende den til dig selv og/eller dine kolleger for at vurdere det indhold, du har tilføjet. På den måde kan du sikre dig, at du er 100 % tilfreds med din mail, inden du afsender den.

I trin fire er du klar til at [tilføje din målliste][11] med modtagerne af din udsendelse.

I det femte og sidste trin bekræfter du og afsender eller tidsindstiller din udsendelse. Du kan enten afsende din mail med det samme, eller du kan tidsindstille den.

## Relateret indhold

* [Angive indstillinger for udsendelser][5]
* [Spore udsendelsen og få vist statistik][7]
* [Arbejde med modtagerlisten efter udsendelsen][8]
* [Arbejde med sporede links efter udsendelsen][9]

<!-- Referenced links -->
[1]: tutorial-email-mailing.yml
[2]: tutorial-sms-mailing.yml
[3]: tutorial-document-mailing.yml
[4]: tutorial-form-mailing.yml
[10]: send-test-email.md
[5]: ../../admin/define-settings-for-mailings.md
[7]: ../view-statistics.md
[9]: ../../../tracked-links/learn/explore-clicks.md
[11]: ../../../recipients/learn/index.md
[8]: ../../../recipients/learn/look-at-recipient-list.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/marketing/mailing-workflow-all.png
