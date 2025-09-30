---
uid: help-sv-mailing-create
title: Skapa nytt utskick
description: För att skicka ett marknadsföringsutskick behöver du bara följa fem enkla steg. Att ställa in ett utskick innebär att skapa utskicket, fylla i grundläggande information och sedan välja en mall.
keywords: skapa utskick
author: SuperOffice Product and Engineering
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: mailing
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Skapa nytt utskick

Du kan skapa ett nytt utskick antingen direkt i SuperOffice Marknadsföring eller som en dokumentkoppling från ett urval i SuperOffice CRM.

## Arbetsflödet för utskick

När du skapar ett utskick följer du ett arbetsflöde som består av 5 steg:

1. **Konfiguration**
1. **Mall** (hoppa över om du skapar utskicket från en mall eller ett befintligt utskick)
1. **Innehåll**
1. **Mottagare** (gäller ej formulär)
1. **Bekräfta** (gäller ej formulär)

![Arbetsflödet för utskick -screenshot][img1]

Grön (ifylld) = Fullständigt steg | Grön (ring) = Ofullständigt eller överhoppat steg | Grå/prickad = Steg inte påbörjat

Varje steg i arbetsflödet måste vara avslutat innan du kan gå vidare till nästa steg. Du kan dock klicka på fullständiga steg om du vill ändra något innan du skickar utskicket.

## Välj utskickstyp

Det första du måste göra är att välja vilken typ av utskick du vill skicka. När du väljer utskickstyp ser SuperOffice CRM till att du inte skickar ditt utskick till de personer som inte prenumererar på det utskick du ska skicka.

> [!NOTE]
> Om du har skapat utskicket som en dokumentkoppling från SuperOffice CRM har du redan valt utskickstyp. Du förs då automatiskt till steget **Konfiguration**.

1. Välj fliken **Utskick**.

2. Välj ett av följande alternativ under **Skapa nytt utskick** på högra sidan av skärmen:
    * **E-post**
    * **SMS**
    * **Dokument**
    * **Formulärsvar**

3. Du har nu startat arbetsflödet för att skapa ett utskick. Följ stegen för den valda typen:

    * [E-post][1]
    * [SMS][2]
    * [Dokument][3]
    * [Formulärsvar][4]

## Öppningsfrekvenser

Din ämnesrad påverkar öppningsfrekvensen för ditt utskick. Människor bestämmer om de ska öppna och läsa din e-post baserat på din ämnesrad. Så se till att din ämnesrad väcker uppmärksamhet.

Avsändaren spelar också en roll för öppningsfrekvensen. Det är mer troligt att personer öppnar din e-post om de känner igen avsändarens namn. Du styr hur avsändaren visas genom att ange avsändarens namn och e-postadress så här: `"Namn"<email@address.com>`

Om du använder Google Analytics för att analysera trafik och användarbeteende på din webbplats kan du koppla dina utskick till dina Google Analytics-rapporter.

## Gör ett utskick

I steg tre kan [du testa ditt utskick genom][10] att skicka det till dig själv och/eller dina kollegor för att granska innehållet du lagt till. På så sätt kan du se till att du är 100 procent nöjd med ditt utskick innan du skickar det.

I steg fyra är du redo att [lägga till din mållista][11] som innehåller mottagarna till ditt utskick.

I det femte och sista steget bekräftar du och skickar eller schemalägger ditt utskick. Du kan antingen skicka ditt utskick direkt eller så kan du schemalägga ditt utskick.

## Relaterat innehåll

* [Ange inställningar för utskick][5]
* [Spåra utskick och visa statistik][7]
* [Jobba med mottagarlistan efter utskicket][8]
* [Jobba med spårade länkar efter utskicket][9]

<!-- Referenced links -->
[1]: tutorial-email-mailing.md
[2]: tutorial-sms-mailing.md
[3]: tutorial-document-mailing.md
[4]: tutorial-form-mailing.md
[10]: send-test-email.md
[5]: ../../admin/define-settings-for-mailings.md
[7]: ../view-statistics.md
[9]: ../../../tracked-links/learn/explore-clicks.md
[11]: ../../../recipients/learn/index.md
[8]: ../../../recipients/learn/look-at-recipient-list.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/marketing/mailing-workflow-all.png
