---
uid: help-sv-document-template
title: Dokumentmall
description: Dokumentmall
keywords: dokumentmall, dokument, mall
author: Bergfrid Dias
date: 07.16.2024
version: 10.3
content_type: concept
language: sv
redirect_from: /sv/admin/lists/learn/document-template
---

# Dokumentmall

Det är viktigt för företagets profil att brev, fax och andra dokument har ett unikt och enhetligt utseende. Det betyder att alla dokument som skickas från företaget bör ha samma typsnitt, marginaler, logotyper och så vidare. Genom att skapa mallar som är anpassade för företaget kan du vara säker på att företagets kontakter lätt känner igen dokument från företaget.

Mallarna innehåller variabler som hämtar information från SuperOffice-databasen och automatiskt lägger in den i dokumentet.

SuperOffice CRM levereras med flera [standardmallar][2] som du kan använda så fort du har installerat programmet. Mallarna används när du skapar dokument från SuperOffice CRM.

Du kan redigera mallarna som medföljer SuperOffice CRM.

Du kan även skapa egna mallar i de applikationer du har valt att använda tillsammans med SuperOffice CRM. Det gör du genom att lägga till [mallvariabler][1] i malldokumenten.

## Fördelar med att skapa dokumentmallar

* Alla sparar tid när de skapar ett nytt dokument eftersom de inte behöver lägga in uppgifter som ofta upprepas i varje dokument, till exempel kundens namn och adress. Med hjälp av mallvariabler lägger SuperOffice CRM automatiskt till kundens uppgifter när du skapar nästa dokument.

* Du ser till att dina kontakter får dokument som har ett enhetligt och professionellt utseende med företagets logotyp och identitet.

* Du ser till att alla användare kommer åt och kan använda juridisk text som är viktig för företaget, till exempel villkor och liknande.

* Du kan till och med skapa listor och hitta företag som har en gemensam dokumentmall.

## Så väljer SuperOffice CRM rätt språkmall

SuperOffice CRM har flera standardmallar på 12–16 språk beroende på malltyp. Bland annat e-postmallar och GDPR-mallar (12 språk).

För att säkerställa att du kan kommunicera med dina kunder på deras eget språk (om möjligt) gör SuperOffice CRM automatiskt en språkkontroll för att avgöra vilken språkmall som ska användas. Detta är relevant när du skickar förfrågningar via e-post och när du informerar nya kontakter om att deras uppgifter har sparats. Detta är också ett krav för GDPR-relaterad kommunikation.

**Steg:**

1. Har ett supportspråk valts för kontakten? Finns en mall på det här språket?
2. Kan kontaktens land mappas till motsvarande språk?
3. Vad är det föredragna dokumentspråket för den inloggade användaren och finns det en mall på detta språk?
4. Vad är gränssnittsspråket för den inloggade användaren och finns det en mall på detta språk?
5. Om inget språk hittas används den engelska mallen.

## Så lägger du till ett malldokument

1. [Lägg till och definiera dokumentmallen][6] under Inställningar och underhåll.
1. Gör dokumentmallen tillgänglig för de [användargrupper][5] som behöver använda den.

## Related content

* [Redigera mall][2]
* [Skapa ett malldokument][4]
* [Visa mallvariabler][1]
* [Mallvariabler (Service)][8]
* [Offertmallar][7]

<!-- Referenced links -->
[1]: template-variables.md
[4]: create.md
[2]: ../admin/update-template.md
[6]: ../admin/link-template.md
[5]: ../../../admin/lists/user-group-filtering.md
[7]: quote-templates.md
[8]: ../../../knowledge-base/learn/reply-templates/template-variables.md

<!-- Referenced images -->
