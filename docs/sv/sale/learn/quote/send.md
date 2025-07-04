---
uid: help-sv-quote-send
title: Skicka offert
description: Lär dig hur du skickar, godkänner och versionerar offerter i SuperOffice CRM.
keywords: skicka offert, godkänna offert, redigera skickad offert, skicka, publicera, godkännande, offertversion, fliken Bilagor, offert
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from:
  - /sv/quote/learn/approve
  - /sv/quote/learn/send
  - /sv/quote/learn/versions
---

# Skicka offert

När du har lagt till produkter och skapat ett offertdokument kan du skicka offerten till kunden. Offerten får statusen **Skickad** och låses för redigering.

## Förbered offerten

1. Gå till fliken **Offert** i försäljningen och klicka på **Öppna** för att redigera offerten.

1. Kontrollera följande:

    * Alla obligatoriska produktfält är ifyllda.
    * Offertdokumentet är skapat.
    * Eventuella bilagor är valda i fliken **Bilagor** (om tillämpligt). Dessa bifogas vid utskick.
    * Rätt alternativ är inställt som **favoritalternativ**.
    * Det finns inga [varningar eller fel][4].

> [!NOTE]
> Du kan inte skicka en offert som har varningar, fel eller kräver godkännande. Knappen **Skicka** är nedtonad tills allt är åtgärdat.

## <a id="approve"></a>Kräver godkännande?

Vissa offerter måste godkännas innan de kan skickas, till exempel om vinsten är för låg eller rabatten för hög. Reglerna för godkännande anges per försäljningstyp i Inställningar och underhåll (**Listor** > **Försäljning – Typ, Steg, Offert**).

* Om godkännande krävs får offerten statusen **Behöver godkännas**
* Ett meddelande visas i dialogrutan **Redigera offert** och varningsikoner visas

### Så här godkänns en offert

1. En användare med behörighet öppnar offerten.

1. Klicka på **Godkänn** eller **Avvisa**.

1. Statusen ändras till **Godkänd** (<i class="ph ph-check-square" aria-hidden="true"></i>) eller **Avvisad** (<i class="ph ph-x-square" aria-hidden="true"></i>).

## <a id="send"></a>Så här skickar du offerten

1. Klicka på **Skicka** i dialogrutan **Redigera offert**.

    Dialogrutan **Publicera/skicka en offert** öppnas.

    ![Dialogrutan Skicka offert -screenshot][img1]

2. Justera giltighetsdatumet i fältet **Giltig till** (standard är 30 dagar).

3. Välj **Offertformat** (mall) och **Språk** för offerten.

4. Om offerten har flera alternativ, kan du välja **Använd endast favoritalternativ** för att endast inkludera detta. Annars inkluderas alla alternativ i offerten.

5. I sektionen **Publicera**, välj hur offerten ska levereras:

    * **Skicka som e-post och arkivera som PDF** (välj en e-postmall)
    * **Arkivera endast som PDF** (du skickar offerten manuellt)

6. (Valfritt) Välj **Skapa händelse**, skriv en anteckning och välj datum för påminnelsen.

7. Klicka på **Förhandsgranskning** för att granska offerten som PDF.

8. Klicka på **OK** för att skicka och/eller arkivera offerten.

    Om du valt e-post öppnas dialogrutan **Ny e-post** där du kan anpassa meddelandet.

### Efter att du har skickat offerten

* Offerten får statusen **Skickad**
* Den aktuella versionen låses
* **Status** inkluderar giltighetsdatum (t.ex. *Skickad (Giltig till - 2025-05-03)*)
* Ikonen ändras från <i class="ph ph-pencil-simple" aria-label="Utkast ikon"></i> till ett kuvert (<i class="ph ph-envelope" aria-label="Skickad ikon"></i>)
* PDF-filen arkiveras i fliken **Aktiviteter**

    ![Offertfliken när offert är skickad -screenshot][img2]

## <a id="versions"></a>Redigera en skickad offert

När offerten är skickad blir den skrivskyddad. För att göra ändringar (till exempel som svar på en kundförfrågan) måste du skapa en ny version.

1. Klicka på **Öppna** i fliken **Offert**.
2. I dialogrutan **Redigera offert**, klicka på **Redigera**.
3. En ny version med status **Utkast** skapas. Den tidigare versionen arkiveras (<i class="ph ph-folder-simple" aria-hidden="true"></i>).

Använd rullgardinsmenyn **Version** för att växla mellan versioner.

> [!TIP]
> Ändringar i den nya versionen påverkar inte originalet. Du måste skicka den nya versionen.

## Relaterat innehåll

* [Skapa offertdokument][1]
* [Byt offertdokument][2]
* [Registrera en order][3]
* [Ställ in regler för offertgodkännande][5] i Inställningar och underhåll

<!-- Referenced links -->
[1]: create-quote-document.md
[2]: create-quote-document.md#replace
[3]: place-order.md
[4]: create.md#warning
[5]: ../../admin/sale-type.md#quote-fields

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/send-quote-dialog.png
[img2]: ../../../../media/loc/en/sale/sent-quote.png
